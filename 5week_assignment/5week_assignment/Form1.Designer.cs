namespace _5week_assignment
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
            this.start = new System.Windows.Forms.Button();
            this.picArea = new System.Windows.Forms.PictureBox();
            this.ratio_real = new System.Windows.Forms.Label();
            this.in_area = new System.Windows.Forms.Label();
            this.out_area = new System.Windows.Forms.Label();
            this.ratio_monte = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picArea)).BeginInit();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(513, 12);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(101, 23);
            this.start.TabIndex = 0;
            this.start.Text = "start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // picArea
            // 
            this.picArea.BackColor = System.Drawing.Color.White;
            this.picArea.Location = new System.Drawing.Point(12, 12);
            this.picArea.Name = "picArea";
            this.picArea.Size = new System.Drawing.Size(493, 483);
            this.picArea.TabIndex = 1;
            this.picArea.TabStop = false;
            // 
            // ratio_real
            // 
            this.ratio_real.AutoSize = true;
            this.ratio_real.Location = new System.Drawing.Point(511, 43);
            this.ratio_real.Name = "ratio_real";
            this.ratio_real.Size = new System.Drawing.Size(56, 12);
            this.ratio_real.TabIndex = 2;
            this.ratio_real.Text = "ratio_real";
            // 
            // in_area
            // 
            this.in_area.AutoSize = true;
            this.in_area.Location = new System.Drawing.Point(511, 66);
            this.in_area.Name = "in_area";
            this.in_area.Size = new System.Drawing.Size(46, 12);
            this.in_area.TabIndex = 3;
            this.in_area.Text = "in_area";
            // 
            // out_area
            // 
            this.out_area.AutoSize = true;
            this.out_area.Location = new System.Drawing.Point(511, 89);
            this.out_area.Name = "out_area";
            this.out_area.Size = new System.Drawing.Size(53, 12);
            this.out_area.TabIndex = 4;
            this.out_area.Text = "out_area";
            // 
            // ratio_monte
            // 
            this.ratio_monte.AutoSize = true;
            this.ratio_monte.Location = new System.Drawing.Point(511, 112);
            this.ratio_monte.Name = "ratio_monte";
            this.ratio_monte.Size = new System.Drawing.Size(70, 12);
            this.ratio_monte.TabIndex = 5;
            this.ratio_monte.Text = "ratio_monte";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 507);
            this.Controls.Add(this.ratio_monte);
            this.Controls.Add(this.out_area);
            this.Controls.Add(this.in_area);
            this.Controls.Add(this.ratio_real);
            this.Controls.Add(this.picArea);
            this.Controls.Add(this.start);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.PictureBox picArea;
        private System.Windows.Forms.Label ratio_real;
        private System.Windows.Forms.Label in_area;
        private System.Windows.Forms.Label out_area;
        private System.Windows.Forms.Label ratio_monte;
    }
}

