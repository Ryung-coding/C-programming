namespace P2_real_not_P3
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
            this.picOrg = new System.Windows.Forms.PictureBox();
            this.picRot = new System.Windows.Forms.PictureBox();
            this.btnRot = new System.Windows.Forms.Button();
            this.chkInverse = new System.Windows.Forms.CheckBox();
            this.txtDeg = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picOrg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRot)).BeginInit();
            this.SuspendLayout();
            // 
            // picOrg
            // 
            this.picOrg.BackColor = System.Drawing.Color.White;
            this.picOrg.BackgroundImage = global::P2_real_not_P3.Properties.Resources.튤립_400_300;
            this.picOrg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picOrg.Image = global::P2_real_not_P3.Properties.Resources.튤립_400_300;
            this.picOrg.Location = new System.Drawing.Point(12, 12);
            this.picOrg.Name = "picOrg";
            this.picOrg.Size = new System.Drawing.Size(402, 302);
            this.picOrg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picOrg.TabIndex = 0;
            this.picOrg.TabStop = false;
            // 
            // picRot
            // 
            this.picRot.BackColor = System.Drawing.Color.White;
            this.picRot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picRot.Location = new System.Drawing.Point(428, 12);
            this.picRot.Name = "picRot";
            this.picRot.Size = new System.Drawing.Size(402, 302);
            this.picRot.TabIndex = 1;
            this.picRot.TabStop = false;
            // 
            // btnRot
            // 
            this.btnRot.Location = new System.Drawing.Point(206, 358);
            this.btnRot.Name = "btnRot";
            this.btnRot.Size = new System.Drawing.Size(75, 23);
            this.btnRot.TabIndex = 2;
            this.btnRot.Text = "button1";
            this.btnRot.UseVisualStyleBackColor = true;
            this.btnRot.Click += new System.EventHandler(this.btnRot_Click);
            // 
            // chkInverse
            // 
            this.chkInverse.AutoSize = true;
            this.chkInverse.Location = new System.Drawing.Point(312, 336);
            this.chkInverse.Name = "chkInverse";
            this.chkInverse.Size = new System.Drawing.Size(86, 16);
            this.chkInverse.TabIndex = 3;
            this.chkInverse.Text = "checkBox1";
            this.chkInverse.UseVisualStyleBackColor = true;
            this.chkInverse.CheckedChanged += new System.EventHandler(this.chkInverse_CheckedChanged);
            // 
            // txtDeg
            // 
            this.txtDeg.Location = new System.Drawing.Point(206, 331);
            this.txtDeg.Name = "txtDeg";
            this.txtDeg.Size = new System.Drawing.Size(100, 21);
            this.txtDeg.TabIndex = 4;
            this.txtDeg.Text = "0";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 439);
            this.Controls.Add(this.txtDeg);
            this.Controls.Add(this.chkInverse);
            this.Controls.Add(this.btnRot);
            this.Controls.Add(this.picRot);
            this.Controls.Add(this.picOrg);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picOrg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picOrg;
        private System.Windows.Forms.PictureBox picRot;
        private System.Windows.Forms.Button btnRot;
        private System.Windows.Forms.CheckBox chkInverse;
        private System.Windows.Forms.TextBox txtDeg;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

