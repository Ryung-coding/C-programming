namespace practice_zip
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radio_blue = new System.Windows.Forms.RadioButton();
            this.radio_green = new System.Windows.Forms.RadioButton();
            this.radio_red = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(418, 534);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio_blue);
            this.groupBox1.Controls.Add(this.radio_green);
            this.groupBox1.Controls.Add(this.radio_red);
            this.groupBox1.Location = new System.Drawing.Point(436, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // radio_blue
            // 
            this.radio_blue.AutoSize = true;
            this.radio_blue.Location = new System.Drawing.Point(7, 65);
            this.radio_blue.Name = "radio_blue";
            this.radio_blue.Size = new System.Drawing.Size(81, 16);
            this.radio_blue.TabIndex = 2;
            this.radio_blue.TabStop = true;
            this.radio_blue.Text = "radio_blue";
            this.radio_blue.UseVisualStyleBackColor = true;
            // 
            // radio_green
            // 
            this.radio_green.AutoSize = true;
            this.radio_green.Location = new System.Drawing.Point(7, 43);
            this.radio_green.Name = "radio_green";
            this.radio_green.Size = new System.Drawing.Size(89, 16);
            this.radio_green.TabIndex = 1;
            this.radio_green.TabStop = true;
            this.radio_green.Text = "radio_green";
            this.radio_green.UseVisualStyleBackColor = true;
            // 
            // radio_red
            // 
            this.radio_red.AutoSize = true;
            this.radio_red.Location = new System.Drawing.Point(7, 21);
            this.radio_red.Name = "radio_red";
            this.radio_red.Size = new System.Drawing.Size(75, 16);
            this.radio_red.TabIndex = 0;
            this.radio_red.TabStop = true;
            this.radio_red.Text = "radio_red";
            this.radio_red.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 625);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radio_blue;
        private System.Windows.Forms.RadioButton radio_green;
        private System.Windows.Forms.RadioButton radio_red;
    }
}

