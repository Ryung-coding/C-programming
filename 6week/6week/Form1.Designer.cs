namespace _6week
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
            this.btn_cat = new System.Windows.Forms.Button();
            this.btn_N_cat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cat
            // 
            this.btn_cat.Location = new System.Drawing.Point(24, 12);
            this.btn_cat.Name = "btn_cat";
            this.btn_cat.Size = new System.Drawing.Size(75, 23);
            this.btn_cat.TabIndex = 0;
            this.btn_cat.Text = "button1";
            this.btn_cat.UseVisualStyleBackColor = true;
            this.btn_cat.Click += new System.EventHandler(this.btn_cat_Click);
            // 
            // btn_N_cat
            // 
            this.btn_N_cat.Location = new System.Drawing.Point(24, 83);
            this.btn_N_cat.Name = "btn_N_cat";
            this.btn_N_cat.Size = new System.Drawing.Size(75, 23);
            this.btn_N_cat.TabIndex = 1;
            this.btn_N_cat.Text = "button2";
            this.btn_N_cat.UseVisualStyleBackColor = true;
            this.btn_N_cat.Click += new System.EventHandler(this.btn_N_cat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 118);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_N_cat);
            this.Controls.Add(this.btn_cat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cat;
        private System.Windows.Forms.Button btn_N_cat;
        private System.Windows.Forms.Label label1;
    }
}

