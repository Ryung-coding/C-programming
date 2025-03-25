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
            this.button = new System.Windows.Forms.Button();
            this.data = new System.Windows.Forms.Label();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(60, 12);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(48, 58);
            this.button.TabIndex = 0;
            this.button.Text = "go";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button1_Click);
            // 
            // data
            // 
            this.data.AutoSize = true;
            this.data.Font = new System.Drawing.Font("굴림", 15F);
            this.data.Location = new System.Drawing.Point(12, 12);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(20, 20);
            this.data.TabIndex = 1;
            this.data.Text = "0";
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(6, 54);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(48, 16);
            this.checkBox.TabIndex = 2;
            this.checkBox.Text = "stop";
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 82);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.data);
            this.Controls.Add(this.button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label data;
        private System.Windows.Forms.CheckBox checkBox;
    }
}

