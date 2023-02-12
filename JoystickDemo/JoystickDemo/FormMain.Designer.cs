namespace LibHHControlTest
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button_Close = new System.Windows.Forms.Button();
            this.pictureBox_XY = new System.Windows.Forms.PictureBox();
            this.progressBar_Rudder = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_StickInfo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.verticalProgressBar_Thr = new LibHHControlTest.VerticalProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_XY)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 357);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "油门";
            // 
            // button_Close
            // 
            this.button_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Close.Location = new System.Drawing.Point(192, 495);
            this.button_Close.Margin = new System.Windows.Forms.Padding(4);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(100, 31);
            this.button_Close.TabIndex = 4;
            this.button_Close.Text = "关闭";
            this.button_Close.UseVisualStyleBackColor = false;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // pictureBox_XY
            // 
            this.pictureBox_XY.BackColor = System.Drawing.Color.White;
            this.pictureBox_XY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_XY.Location = new System.Drawing.Point(75, 16);
            this.pictureBox_XY.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_XY.Name = "pictureBox_XY";
            this.pictureBox_XY.Size = new System.Drawing.Size(400, 300);
            this.pictureBox_XY.TabIndex = 5;
            this.pictureBox_XY.TabStop = false;
            // 
            // progressBar_Rudder
            // 
            this.progressBar_Rudder.Location = new System.Drawing.Point(75, 320);
            this.progressBar_Rudder.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar_Rudder.Name = "progressBar_Rudder";
            this.progressBar_Rudder.Size = new System.Drawing.Size(400, 27);
            this.progressBar_Rudder.TabIndex = 6;
            this.progressBar_Rudder.Value = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(212, 357);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "方向舵";
            // 
            // textBox_StickInfo
            // 
            this.textBox_StickInfo.BackColor = System.Drawing.Color.Black;
            this.textBox_StickInfo.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_StickInfo.ForeColor = System.Drawing.Color.White;
            this.textBox_StickInfo.Location = new System.Drawing.Point(15, 399);
            this.textBox_StickInfo.Multiline = true;
            this.textBox_StickInfo.Name = "textBox_StickInfo";
            this.textBox_StickInfo.ReadOnly = true;
            this.textBox_StickInfo.Size = new System.Drawing.Size(460, 88);
            this.textBox_StickInfo.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(13, 380);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "摇杆输入数据：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(102, 539);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(365, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "Flight control test console (By Hu Yu, NWPU, 2023.0212.1112)";
            // 
            // verticalProgressBar_Thr
            // 
            this.verticalProgressBar_Thr.Location = new System.Drawing.Point(23, 16);
            this.verticalProgressBar_Thr.Margin = new System.Windows.Forms.Padding(4);
            this.verticalProgressBar_Thr.Name = "verticalProgressBar_Thr";
            this.verticalProgressBar_Thr.Size = new System.Drawing.Size(33, 331);
            this.verticalProgressBar_Thr.TabIndex = 1;
            this.verticalProgressBar_Thr.Value = 10;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(481, 555);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_StickInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar_Rudder);
            this.Controls.Add(this.pictureBox_XY);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.verticalProgressBar_Thr);
            this.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Text = "Flight control test console";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_XY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private VerticalProgressBar verticalProgressBar_Thr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.PictureBox pictureBox_XY;
        private System.Windows.Forms.ProgressBar progressBar_Rudder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_StickInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

