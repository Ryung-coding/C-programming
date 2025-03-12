namespace _2week_assignment
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.print_label = new System.Windows.Forms.Label();
            this.pic_ball = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.fast_radio = new System.Windows.Forms.RadioButton();
            this.slow_radio = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ball)).BeginInit();
            this.SuspendLayout();
            // 
            // print_label
            // 
            this.print_label.AutoSize = true;
            this.print_label.Font = new System.Drawing.Font("한컴 훈민정음 세로쓰기", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.print_label.Location = new System.Drawing.Point(53, 25);
            this.print_label.Name = "print_label";
            this.print_label.Size = new System.Drawing.Size(0, 35);
            this.print_label.TabIndex = 1;
            // 
            // pic_ball
            // 
            this.pic_ball.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pic_ball.Location = new System.Drawing.Point(47, 96);
            this.pic_ball.Name = "pic_ball";
            this.pic_ball.Size = new System.Drawing.Size(57, 57);
            this.pic_ball.TabIndex = 2;
            this.pic_ball.TabStop = false;
            this.pic_ball.Click += new System.EventHandler(this.pic_ball_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // fast_radio
            // 
            this.fast_radio.AutoSize = true;
            this.fast_radio.Checked = true;
            this.fast_radio.Location = new System.Drawing.Point(528, 12);
            this.fast_radio.Name = "fast_radio";
            this.fast_radio.Size = new System.Drawing.Size(43, 16);
            this.fast_radio.TabIndex = 3;
            this.fast_radio.TabStop = true;
            this.fast_radio.Text = "fast";
            this.fast_radio.UseVisualStyleBackColor = true;
            this.fast_radio.CheckedChanged += new System.EventHandler(this.fast_radio_CheckedChanged);
            // 
            // slow_radio
            // 
            this.slow_radio.AutoSize = true;
            this.slow_radio.Location = new System.Drawing.Point(528, 34);
            this.slow_radio.Name = "slow_radio";
            this.slow_radio.Size = new System.Drawing.Size(50, 16);
            this.slow_radio.TabIndex = 4;
            this.slow_radio.Text = "slow";
            this.slow_radio.UseVisualStyleBackColor = true;
            this.slow_radio.CheckedChanged += new System.EventHandler(this.slow_radio_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(583, 544);
            this.Controls.Add(this.slow_radio);
            this.Controls.Add(this.fast_radio);
            this.Controls.Add(this.pic_ball);
            this.Controls.Add(this.print_label);
            this.Name = "Form1";
            this.Text = "windows";
            ((System.ComponentModel.ISupportInitialize)(this.pic_ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected internal System.Windows.Forms.Label print_label;
        private System.Windows.Forms.PictureBox pic_ball;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.RadioButton fast_radio;
        private System.Windows.Forms.RadioButton slow_radio;
    }
}

