namespace bitmap
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
            this.components = new System.ComponentModel.Container();
            this.pic = new System.Windows.Forms.PictureBox();
            this.pic_copy = new System.Windows.Forms.PictureBox();
            this.load = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.trans = new System.Windows.Forms.Button();
            this.R_data = new System.Windows.Forms.Label();
            this.G_data = new System.Windows.Forms.Label();
            this.B_data = new System.Windows.Forms.Label();
            this.picClock = new System.Windows.Forms.PictureBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_copy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClock)).BeginInit();
            this.SuspendLayout();
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.White;
            this.pic.Location = new System.Drawing.Point(12, 12);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(215, 281);
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            // 
            // pic_copy
            // 
            this.pic_copy.BackColor = System.Drawing.Color.White;
            this.pic_copy.Location = new System.Drawing.Point(245, 12);
            this.pic_copy.Name = "pic_copy";
            this.pic_copy.Size = new System.Drawing.Size(205, 281);
            this.pic_copy.TabIndex = 1;
            this.pic_copy.TabStop = false;
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(12, 317);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(75, 23);
            this.load.TabIndex = 2;
            this.load.Text = "button1";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // trans
            // 
            this.trans.Location = new System.Drawing.Point(245, 299);
            this.trans.Name = "trans";
            this.trans.Size = new System.Drawing.Size(75, 23);
            this.trans.TabIndex = 3;
            this.trans.Text = "button1";
            this.trans.UseVisualStyleBackColor = true;
            this.trans.Click += new System.EventHandler(this.trans_Click);
            // 
            // R_data
            // 
            this.R_data.AutoSize = true;
            this.R_data.Location = new System.Drawing.Point(124, 317);
            this.R_data.Name = "R_data";
            this.R_data.Size = new System.Drawing.Size(38, 12);
            this.R_data.TabIndex = 4;
            this.R_data.Text = "label1";
            // 
            // G_data
            // 
            this.G_data.AutoSize = true;
            this.G_data.Location = new System.Drawing.Point(124, 341);
            this.G_data.Name = "G_data";
            this.G_data.Size = new System.Drawing.Size(38, 12);
            this.G_data.TabIndex = 5;
            this.G_data.Text = "label2";
            // 
            // B_data
            // 
            this.B_data.AutoSize = true;
            this.B_data.Location = new System.Drawing.Point(124, 367);
            this.B_data.Name = "B_data";
            this.B_data.Size = new System.Drawing.Size(38, 12);
            this.B_data.TabIndex = 6;
            this.B_data.Text = "label3";
            // 
            // picClock
            // 
            this.picClock.BackColor = System.Drawing.Color.White;
            this.picClock.Location = new System.Drawing.Point(488, 30);
            this.picClock.Name = "picClock";
            this.picClock.Size = new System.Drawing.Size(275, 263);
            this.picClock.TabIndex = 7;
            this.picClock.TabStop = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(486, 304);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(38, 12);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.picClock);
            this.Controls.Add(this.B_data);
            this.Controls.Add(this.G_data);
            this.Controls.Add(this.R_data);
            this.Controls.Add(this.trans);
            this.Controls.Add(this.load);
            this.Controls.Add(this.pic_copy);
            this.Controls.Add(this.pic);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_copy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.PictureBox pic_copy;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button trans;
        private System.Windows.Forms.Label R_data;
        private System.Windows.Forms.Label G_data;
        private System.Windows.Forms.Label B_data;
        private System.Windows.Forms.PictureBox picClock;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
    }
}

