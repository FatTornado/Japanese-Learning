namespace 五十音
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDouble = new System.Windows.Forms.RadioButton();
            this.rbPian = new System.Windows.Forms.RadioButton();
            this.rbPing = new System.Windows.Forms.RadioButton();
            this.rbVoice = new System.Windows.Forms.RadioButton();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnAutoPlay = new System.Windows.Forms.Button();
            this.txtSeconds = new System.Windows.Forms.NumericUpDown();
            this.chkMute = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeconds)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkMute);
            this.groupBox1.Controls.Add(this.rbDouble);
            this.groupBox1.Controls.Add(this.rbPian);
            this.groupBox1.Controls.Add(this.rbPing);
            this.groupBox1.Controls.Add(this.rbVoice);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox1.Size = new System.Drawing.Size(384, 50);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "模式";
            // 
            // rbDouble
            // 
            this.rbDouble.AutoSize = true;
            this.rbDouble.Location = new System.Drawing.Point(238, 21);
            this.rbDouble.Name = "rbDouble";
            this.rbDouble.Size = new System.Drawing.Size(136, 26);
            this.rbDouble.TabIndex = 3;
            this.rbDouble.Text = "平假名+片假名";
            this.rbDouble.UseVisualStyleBackColor = true;
            this.rbDouble.CheckedChanged += new System.EventHandler(this.RbDouble_CheckedChanged);
            // 
            // rbPian
            // 
            this.rbPian.AutoSize = true;
            this.rbPian.Location = new System.Drawing.Point(156, 21);
            this.rbPian.Name = "rbPian";
            this.rbPian.Size = new System.Drawing.Size(76, 26);
            this.rbPian.TabIndex = 2;
            this.rbPian.Text = "片假名";
            this.rbPian.UseVisualStyleBackColor = true;
            this.rbPian.CheckedChanged += new System.EventHandler(this.RbPian_CheckedChanged);
            // 
            // rbPing
            // 
            this.rbPing.AutoSize = true;
            this.rbPing.Location = new System.Drawing.Point(74, 21);
            this.rbPing.Name = "rbPing";
            this.rbPing.Size = new System.Drawing.Size(76, 26);
            this.rbPing.TabIndex = 1;
            this.rbPing.Text = "平假名";
            this.rbPing.UseVisualStyleBackColor = true;
            this.rbPing.CheckedChanged += new System.EventHandler(this.RbPing_CheckedChanged);
            // 
            // rbVoice
            // 
            this.rbVoice.AutoSize = true;
            this.rbVoice.Checked = true;
            this.rbVoice.Location = new System.Drawing.Point(8, 21);
            this.rbVoice.Name = "rbVoice";
            this.rbVoice.Size = new System.Drawing.Size(60, 26);
            this.rbVoice.TabIndex = 0;
            this.rbVoice.TabStop = true;
            this.rbVoice.Text = "发音";
            this.rbVoice.UseVisualStyleBackColor = true;
            this.rbVoice.CheckedChanged += new System.EventHandler(this.RbVoice_CheckedChanged);
            // 
            // lb1
            // 
            this.lb1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lb1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb1.Font = new System.Drawing.Font("楷体", 108F);
            this.lb1.ForeColor = System.Drawing.Color.Purple;
            this.lb1.Location = new System.Drawing.Point(12, 56);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(150, 150);
            this.lb1.TabIndex = 1;
            this.lb1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb2
            // 
            this.lb2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lb2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb2.Font = new System.Drawing.Font("楷体", 72F);
            this.lb2.ForeColor = System.Drawing.Color.DarkBlue;
            this.lb2.Location = new System.Drawing.Point(168, 106);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(100, 100);
            this.lb2.TabIndex = 2;
            this.lb2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb3
            // 
            this.lb3.Font = new System.Drawing.Font("楷体", 28F);
            this.lb3.ForeColor = System.Drawing.Color.Cyan;
            this.lb3.Location = new System.Drawing.Point(168, 56);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(100, 42);
            this.lb3.TabIndex = 3;
            this.lb3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnPlay
            // 
            this.btnPlay.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnPlay.Location = new System.Drawing.Point(274, 144);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(98, 62);
            this.btnPlay.TabIndex = 4;
            this.btnPlay.Text = "▶\r\n[Enter]";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // btnAutoPlay
            // 
            this.btnAutoPlay.ForeColor = System.Drawing.Color.Black;
            this.btnAutoPlay.Location = new System.Drawing.Point(274, 106);
            this.btnAutoPlay.Name = "btnAutoPlay";
            this.btnAutoPlay.Size = new System.Drawing.Size(98, 32);
            this.btnAutoPlay.TabIndex = 5;
            this.btnAutoPlay.Text = "AUTO";
            this.btnAutoPlay.UseVisualStyleBackColor = true;
            this.btnAutoPlay.Click += new System.EventHandler(this.BtnAutoPlay_Click);
            // 
            // txtSeconds
            // 
            this.txtSeconds.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSeconds.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSeconds.Location = new System.Drawing.Point(331, 78);
            this.txtSeconds.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.txtSeconds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtSeconds.Name = "txtSeconds";
            this.txtSeconds.Size = new System.Drawing.Size(41, 25);
            this.txtSeconds.TabIndex = 6;
            this.txtSeconds.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.txtSeconds.ValueChanged += new System.EventHandler(this.TxtSeconds_ValueChanged);
            // 
            // chkMute
            // 
            this.chkMute.AutoSize = true;
            this.chkMute.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.chkMute.ForeColor = System.Drawing.Color.LightPink;
            this.chkMute.Location = new System.Drawing.Point(301, 0);
            this.chkMute.Name = "chkMute";
            this.chkMute.Size = new System.Drawing.Size(75, 23);
            this.chkMute.TabIndex = 7;
            this.chkMute.Text = "静音(&M)";
            this.chkMute.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(271, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "间隔(秒)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.txtSeconds);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAutoPlay);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "MainForm";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "五十音";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeconds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDouble;
        private System.Windows.Forms.RadioButton rbPian;
        private System.Windows.Forms.RadioButton rbPing;
        private System.Windows.Forms.RadioButton rbVoice;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnAutoPlay;
        private System.Windows.Forms.NumericUpDown txtSeconds;
        private System.Windows.Forms.CheckBox chkMute;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}

