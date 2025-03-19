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
            this.year = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.month = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.day = new System.Windows.Forms.TextBox();
            this.yoil = new System.Windows.Forms.Label();
            this.geasangi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(12, 12);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(34, 21);
            this.year.TabIndex = 0;
            this.year.Text = "2025";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "년";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "월";
            // 
            // month
            // 
            this.month.Location = new System.Drawing.Point(75, 12);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(34, 21);
            this.month.TabIndex = 2;
            this.month.Text = "3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "일";
            // 
            // day
            // 
            this.day.Location = new System.Drawing.Point(138, 12);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(34, 21);
            this.day.TabIndex = 4;
            this.day.Text = "19";
            // 
            // yoil
            // 
            this.yoil.AutoSize = true;
            this.yoil.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.yoil.Location = new System.Drawing.Point(18, 49);
            this.yoil.Name = "yoil";
            this.yoil.Size = new System.Drawing.Size(28, 16);
            this.yoil.TabIndex = 6;
            this.yoil.Text = "***";
            // 
            // geasangi
            // 
            this.geasangi.Location = new System.Drawing.Point(75, 42);
            this.geasangi.Name = "geasangi";
            this.geasangi.Size = new System.Drawing.Size(117, 23);
            this.geasangi.TabIndex = 7;
            this.geasangi.Text = "계산";
            this.geasangi.UseVisualStyleBackColor = true;
            this.geasangi.Click += new System.EventHandler(this.geasangi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 77);
            this.Controls.Add(this.geasangi);
            this.Controls.Add(this.yoil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.day);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.month);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.year);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox month;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox day;
        private System.Windows.Forms.Label yoil;
        private System.Windows.Forms.Button geasangi;
    }
}

