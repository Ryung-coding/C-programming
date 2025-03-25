namespace _4week
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button = new System.Windows.Forms.Button();
            this.data = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.SystemColors.Window;
            this.button.Location = new System.Drawing.Point(364, 136);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(37, 23);
            this.button.TabIndex = 0;
            this.button.Text = "go";
            this.button.UseVisualStyleBackColor = false;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // data
            // 
            this.data.Location = new System.Drawing.Point(351, 109);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(62, 21);
            this.data.TabIndex = 1;
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.BackColor = System.Drawing.Color.White;
            this.output.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.Location = new System.Drawing.Point(47, 86);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(86, 73);
            this.output.TabIndex = 2;
            this.output.Text = "??";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(449, 243);
            this.Controls.Add(this.output);
            this.Controls.Add(this.data);
            this.Controls.Add(this.button);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button;
        private System.Windows.Forms.TextBox data;
        private System.Windows.Forms.Label output;
    }
}

