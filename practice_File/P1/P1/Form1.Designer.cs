namespace P1
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
            this.picDraw = new System.Windows.Forms.PictureBox();
            this.lblstring1 = new System.Windows.Forms.Label();
            this.lblstring2 = new System.Windows.Forms.Label();
            this.lblstring3 = new System.Windows.Forms.Label();
            this.lblscore = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picDraw)).BeginInit();
            this.SuspendLayout();
            // 
            // picDraw
            // 
            this.picDraw.BackColor = System.Drawing.Color.White;
            this.picDraw.Location = new System.Drawing.Point(12, 12);
            this.picDraw.Name = "picDraw";
            this.picDraw.Size = new System.Drawing.Size(339, 426);
            this.picDraw.TabIndex = 0;
            this.picDraw.TabStop = false;
            // 
            // lblstring1
            // 
            this.lblstring1.AutoSize = true;
            this.lblstring1.Location = new System.Drawing.Point(42, 52);
            this.lblstring1.Name = "lblstring1";
            this.lblstring1.Size = new System.Drawing.Size(37, 12);
            this.lblstring1.TabIndex = 1;
            this.lblstring1.Text = "drone";
            this.lblstring1.Click += new System.EventHandler(this.lblstring1_Click);
            // 
            // lblstring2
            // 
            this.lblstring2.AutoSize = true;
            this.lblstring2.Location = new System.Drawing.Point(146, 76);
            this.lblstring2.Name = "lblstring2";
            this.lblstring2.Size = new System.Drawing.Size(33, 12);
            this.lblstring2.TabIndex = 2;
            this.lblstring2.Text = "robot";
            this.lblstring2.Click += new System.EventHandler(this.lblstring2_Click);
            // 
            // lblstring3
            // 
            this.lblstring3.AutoSize = true;
            this.lblstring3.Location = new System.Drawing.Point(268, 52);
            this.lblstring3.Name = "lblstring3";
            this.lblstring3.Size = new System.Drawing.Size(32, 12);
            this.lblstring3.TabIndex = 3;
            this.lblstring3.Text = "AMR";
            this.lblstring3.Click += new System.EventHandler(this.lblstring3_Click);
            // 
            // lblscore
            // 
            this.lblscore.AutoSize = true;
            this.lblscore.Font = new System.Drawing.Font("굴림", 30F);
            this.lblscore.Location = new System.Drawing.Point(357, 12);
            this.lblscore.Name = "lblscore";
            this.lblscore.Size = new System.Drawing.Size(40, 40);
            this.lblscore.TabIndex = 4;
            this.lblscore.Text = "0";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 200;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 450);
            this.Controls.Add(this.lblscore);
            this.Controls.Add(this.lblstring3);
            this.Controls.Add(this.lblstring2);
            this.Controls.Add(this.lblstring1);
            this.Controls.Add(this.picDraw);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picDraw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDraw;
        private System.Windows.Forms.Label lblstring1;
        private System.Windows.Forms.Label lblstring2;
        private System.Windows.Forms.Label lblstring3;
        private System.Windows.Forms.Label lblscore;
        private System.Windows.Forms.Timer timer;
    }
}

