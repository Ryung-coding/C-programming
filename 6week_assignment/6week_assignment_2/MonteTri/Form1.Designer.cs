namespace MonteTri
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblRatioMonte = new System.Windows.Forms.Label();
            this.lblRatioReal = new System.Windows.Forms.Label();
            this.lblNIn = new System.Windows.Forms.Label();
            this.lblNTotal = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.picDraw = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picDraw)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRatioMonte
            // 
            this.lblRatioMonte.AutoSize = true;
            this.lblRatioMonte.Location = new System.Drawing.Point(468, 242);
            this.lblRatioMonte.Name = "lblRatioMonte";
            this.lblRatioMonte.Size = new System.Drawing.Size(81, 12);
            this.lblRatioMonte.TabIndex = 11;
            this.lblRatioMonte.Text = "lblRatioMonte";
            // 
            // lblRatioReal
            // 
            this.lblRatioReal.AutoSize = true;
            this.lblRatioReal.Location = new System.Drawing.Point(468, 202);
            this.lblRatioReal.Name = "lblRatioReal";
            this.lblRatioReal.Size = new System.Drawing.Size(71, 12);
            this.lblRatioReal.TabIndex = 10;
            this.lblRatioReal.Text = "lblRatioReal";
            // 
            // lblNIn
            // 
            this.lblNIn.AutoSize = true;
            this.lblNIn.Location = new System.Drawing.Point(468, 162);
            this.lblNIn.Name = "lblNIn";
            this.lblNIn.Size = new System.Drawing.Size(37, 12);
            this.lblNIn.TabIndex = 9;
            this.lblNIn.Text = "lblNIn";
            // 
            // lblNTotal
            // 
            this.lblNTotal.AutoSize = true;
            this.lblNTotal.Location = new System.Drawing.Point(468, 122);
            this.lblNTotal.Name = "lblNTotal";
            this.lblNTotal.Size = new System.Drawing.Size(55, 12);
            this.lblNTotal.TabIndex = 8;
            this.lblNTotal.Text = "lblNTotal";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(470, 15);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(80, 59);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // picDraw
            // 
            this.picDraw.BackColor = System.Drawing.Color.White;
            this.picDraw.Location = new System.Drawing.Point(12, 12);
            this.picDraw.Name = "picDraw";
            this.picDraw.Size = new System.Drawing.Size(450, 491);
            this.picDraw.TabIndex = 6;
            this.picDraw.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 520);
            this.Controls.Add(this.lblRatioMonte);
            this.Controls.Add(this.lblRatioReal);
            this.Controls.Add(this.lblNIn);
            this.Controls.Add(this.lblNTotal);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.picDraw);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picDraw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRatioMonte;
        private System.Windows.Forms.Label lblRatioReal;
        private System.Windows.Forms.Label lblNIn;
        private System.Windows.Forms.Label lblNTotal;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox picDraw;
    }
}

