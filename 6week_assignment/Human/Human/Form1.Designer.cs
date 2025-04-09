namespace Human
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
            this.call_button = new System.Windows.Forms.Button();
            this.call_btn_random = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // call_button
            // 
            this.call_button.Location = new System.Drawing.Point(12, 12);
            this.call_button.Name = "call_button";
            this.call_button.Size = new System.Drawing.Size(75, 23);
            this.call_button.TabIndex = 0;
            this.call_button.Text = "gogoring";
            this.call_button.UseVisualStyleBackColor = true;
            this.call_button.Click += new System.EventHandler(this.call_button_Click);
            // 
            // call_btn_random
            // 
            this.call_btn_random.Location = new System.Drawing.Point(12, 41);
            this.call_btn_random.Name = "call_btn_random";
            this.call_btn_random.Size = new System.Drawing.Size(75, 23);
            this.call_btn_random.TabIndex = 1;
            this.call_btn_random.Text = "gogoring";
            this.call_btn_random.UseVisualStyleBackColor = true;
            this.call_btn_random.Click += new System.EventHandler(this.call_btn_random_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 477);
            this.Controls.Add(this.call_btn_random);
            this.Controls.Add(this.call_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button call_button;
        private System.Windows.Forms.Button call_btn_random;
    }
}

