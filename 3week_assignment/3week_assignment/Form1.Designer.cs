namespace _3week_assignment
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
            this.hour = new System.Windows.Forms.TextBox();
            this.min = new System.Windows.Forms.TextBox();
            this.sec = new System.Windows.Forms.TextBox();
            this.input = new System.Windows.Forms.TextBox();
            this.total2hms = new System.Windows.Forms.Button();
            this.hms2total = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hour
            // 
            this.hour.Location = new System.Drawing.Point(159, 10);
            this.hour.Name = "hour";
            this.hour.Size = new System.Drawing.Size(31, 21);
            this.hour.TabIndex = 0;
            // 
            // min
            // 
            this.min.Location = new System.Drawing.Point(159, 41);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(31, 21);
            this.min.TabIndex = 1;
            // 
            // sec
            // 
            this.sec.Location = new System.Drawing.Point(159, 68);
            this.sec.Name = "sec";
            this.sec.Size = new System.Drawing.Size(31, 21);
            this.sec.TabIndex = 2;
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(8, 41);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(100, 21);
            this.input.TabIndex = 3;
            this.input.Text = "100000";
            // 
            // total2hms
            // 
            this.total2hms.Location = new System.Drawing.Point(114, 25);
            this.total2hms.Name = "total2hms";
            this.total2hms.Size = new System.Drawing.Size(39, 23);
            this.total2hms.TabIndex = 4;
            this.total2hms.Text = ">>";
            this.total2hms.UseVisualStyleBackColor = true;
            this.total2hms.Click += new System.EventHandler(this.total2hms_Click);
            // 
            // hms2total
            // 
            this.hms2total.Location = new System.Drawing.Point(114, 54);
            this.hms2total.Name = "hms2total";
            this.hms2total.Size = new System.Drawing.Size(39, 23);
            this.hms2total.TabIndex = 5;
            this.hms2total.Text = "<<";
            this.hms2total.UseVisualStyleBackColor = true;
            this.hms2total.Click += new System.EventHandler(this.hms2total_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 100);
            this.Controls.Add(this.hms2total);
            this.Controls.Add(this.total2hms);
            this.Controls.Add(this.input);
            this.Controls.Add(this.sec);
            this.Controls.Add(this.min);
            this.Controls.Add(this.hour);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox hour;
        private System.Windows.Forms.TextBox min;
        private System.Windows.Forms.TextBox sec;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button total2hms;
        private System.Windows.Forms.Button hms2total;
    }
}

