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
            this.geasangi = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // geasangi
            // 
            this.geasangi.Location = new System.Drawing.Point(91, 10);
            this.geasangi.Name = "geasangi";
            this.geasangi.Size = new System.Drawing.Size(36, 23);
            this.geasangi.TabIndex = 0;
            this.geasangi.Text = "go";
            this.geasangi.UseVisualStyleBackColor = true;
            this.geasangi.Click += new System.EventHandler(this.geasangi_Click);
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(12, 12);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(50, 21);
            this.input.TabIndex = 1;
            this.input.Text = "2025";
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Location = new System.Drawing.Point(68, 15);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(17, 12);
            this.output.TabIndex = 2;
            this.output.Text = "??";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(140, 43);
            this.Controls.Add(this.output);
            this.Controls.Add(this.input);
            this.Controls.Add(this.geasangi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button geasangi;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label output;
    }
}

