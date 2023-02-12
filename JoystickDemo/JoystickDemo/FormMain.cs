using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using JoyKeys;
using JoyKeys.DirectInputJoy;

namespace LibHHControlTest
{
    public partial class FormMain : Form
    {
        Joystick_V _joystick_V = null; //摇杆主动模式
        System.Windows.Forms.Timer m_Timer=new System.Windows.Forms.Timer();
        //============================================
        public FormMain()
        {
            InitializeComponent();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            //设置双缓存属性：
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw |
                ControlStyles.AllPaintingInWmPaint,
                true);
            JoystickInit();
            if (!_joystick_V.IsConnected) return;
            //如果没有检测到摇杆，则不启动时钟：
            StartTimer();
        }

        void StartTimer()
        {
            m_Timer.Enabled= true;
            m_Timer.Tick += new EventHandler(OnTimer);
            m_Timer.Interval = 40;
            m_Timer.Start();
        }

        void StopTimer()
        {
            m_Timer.Stop();
            m_Timer.Dispose();
        }

        /// <summary>
        /// 初始化Joystick
        /// </summary>
        private void JoystickInit()
        {
            _joystick_V = Joystick_V.ReturnJoystick(API.JOYSTICKID1);
            _joystick_V.Capture();
        }

        /// <summary>
        /// 卸载Joystick
        /// </summary>
        private void JoystickDispose()
        {
            _joystick_V.ReleaseCapture();
            _joystick_V.Dispose();
        }

        /// <summary>
        /// 在每个时钟周期，读取摇杆输入，并向飞控板发消息：
        /// </summary>
        /// <param name="myObject"></param>
        /// <param name="myEventArgs"></param>
        private void OnTimer(Object myObject, EventArgs myEventArgs)
        {
            UpdateJoyStickUI();
        }

        private float ComputePercent(int val, int max, int min)
        {
            float re = 0;
            if (max == min)
                throw new Exception("Error from ComputePercent(int val, int max, int min): max==min! ");
            re = (float)(val - min) / (float)(max - min);
            return re;
        }

        /// <summary>
        /// 读取摇杆，并在界面上更新摇杆的显示
        /// </summary>
        void UpdateJoyStickUI()
        {
            JoystickAPI.JOYCAPS joystickinfo = _joystick_V.GetJoyStickInfo();
            float fx, fy, fz, fr, fu, fv;
            int iX, iY, iZ, iR, iU, iV;
            iX = _joystick_V.AxisX;
            iY = _joystick_V.AxisY;
            iZ = _joystick_V.AxisZ;
            iR = _joystick_V.AxisR;
            iU = _joystick_V.AxisU;
            iV = _joystick_V.AxisV;
            //计算各轴相对坐标（取值0-1）：
            fx = ComputePercent(_joystick_V.AxisX, joystickinfo.wXmax, joystickinfo.wXmin);
            fy = ComputePercent(_joystick_V.AxisY, joystickinfo.wYmax, joystickinfo.wYmin);
            fz = ComputePercent(_joystick_V.AxisZ, joystickinfo.wZmax, joystickinfo.wZmin);
            fr = ComputePercent(_joystick_V.AxisR, joystickinfo.wRmax, joystickinfo.wRmin);
            fu = ComputePercent(_joystick_V.AxisU, joystickinfo.wUmax, joystickinfo.wUmin);
            fv = ComputePercent(_joystick_V.AxisV, joystickinfo.wVmax, joystickinfo.wVmin);
            string strDebug = "";
            string fmt = "0.00";
            strDebug = "Axis X = " + _joystick_V.AxisX.ToString() + " (" + fx.ToString(fmt) + "); " +
                     "\tAxis Y = " + _joystick_V.AxisY.ToString() + " (" + fy.ToString(fmt) + "); " +
                     "\tAxis Throttle = " + _joystick_V.AxisZ.ToString() + "(" + fz.ToString(fmt) + "); \r\n" +
                     "Axis Rudder = " + _joystick_V.AxisR.ToString() + " (" + fr.ToString(fmt) + "); " +
                     "\tAxis U = " + _joystick_V.AxisU.ToString() + " (" + fu.ToString(fmt) + "); " +
                     "\tAxis V = " + _joystick_V.AxisV.ToString() + " (" + fv.ToString(fmt) + ")";
            //Console.WriteLine(strDebug);
            textBox_StickInfo.Text = strDebug;
            //绘制十字线：
            DrawCursor(fx, fy);
            //更新油门：
            verticalProgressBar_Thr.Value = (int)(fz * 100);
            //更新方向舵：
            progressBar_Rudder.Value = (int)(fr * 100);
        }

        int LimitCursorPosition(int x, int min, int max, int delta)
        {
            int re;
            re = x;
            if ((x - delta) < min) re = min + delta;
            if ((x + delta) > max) re = max - delta;
            return re;
        }

        /// <summary>
        /// 绘制表示摇杆位置的十字线
        /// </summary>
        /// <param name="fx">控件坐标系下的十字线中心位置X坐标，取值0-1之间，是比例</param>
        /// <param name="fy">控件坐标系下的十字线中心位置Y坐标，取值0-1之间，是比例</param>
        void DrawCursor(float fx, float fy)
        {
            int xcenter, ycenter;
            xcenter = (int)(fx * pictureBox_XY.ClientSize.Width);
            ycenter = (int)(fy * pictureBox_XY.ClientSize.Height);
            Bitmap image = new Bitmap(pictureBox_XY.ClientSize.Width, pictureBox_XY.ClientSize.Height);
            Graphics g = Graphics.FromImage(image);
            g.Clear(pictureBox_XY.BackColor);
            g.SmoothingMode = SmoothingMode.HighQuality; //高质量
            g.PixelOffsetMode = PixelOffsetMode.HighQuality; //高像素偏移质量
            //************下面是绘图代码段***********
            int delta = 10;
            //限制绘图区域：
            xcenter = LimitCursorPosition(xcenter, 0, pictureBox_XY.ClientSize.Width, delta);
            ycenter = LimitCursorPosition(ycenter, 0, pictureBox_XY.ClientSize.Height, delta);
            /*
            string strDebug = "";
            strDebug = "xcenter = " + xcenter + "; " +
                     "ycenter = " + ycenter + "; ";
            Console.WriteLine(strDebug);
            */
            //开始绘图：
            Pen mypen = new Pen(Color.Black, 2);//Color, width;
            Point pCenter = new Point(xcenter, ycenter);
            //左边：
            Point pLeft = new Point(xcenter - delta, ycenter);
            g.DrawLine(mypen, pCenter, pLeft);
            //上边：
            Point pUp = new Point(xcenter, ycenter - delta);
            g.DrawLine(mypen, pCenter, pUp);
            //右边：
            Point pRight = new Point(xcenter + delta, ycenter);
            g.DrawLine(mypen, pCenter, pRight);
            //下边：
            Point pDown = new Point(xcenter, ycenter + delta);
            g.DrawLine(mypen, pCenter, pDown);
            //***********上面是绘图代码段************
            pictureBox_XY.CreateGraphics().DrawImage(image, 0, 0);
            g.Dispose();
            image.Dispose();
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            if(_joystick_V.IsConnected)
            {
                StopTimer();
                JoystickDispose();
            }
            this.Close();
        }

    }
}
