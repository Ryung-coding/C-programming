namespace _4week_assignment
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
            this.count = new System.Windows.Forms.Label();
            this.card01 = new System.Windows.Forms.PictureBox();
            this.card03 = new System.Windows.Forms.PictureBox();
            this.card04 = new System.Windows.Forms.PictureBox();
            this.card02 = new System.Windows.Forms.PictureBox();
            this.card00 = new System.Windows.Forms.PictureBox();
            this.timer_open = new System.Windows.Forms.Timer(this.components);
            this.timer_closed = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.card01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card00)).BeginInit();
            this.SuspendLayout();
            // 
            // count
            // 
            this.count.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.count.AutoSize = true;
            this.count.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.count.Location = new System.Drawing.Point(89, 226);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(64, 73);
            this.count.TabIndex = 0;
            this.count.Text = "0";
            // 
            // card01
            // 
            this.card01.Image = global::_4week_assignment.Properties.Resources.closed;
            this.card01.Location = new System.Drawing.Point(12, 114);
            this.card01.Name = "card01";
            this.card01.Size = new System.Drawing.Size(71, 96);
            this.card01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.card01.TabIndex = 1;
            this.card01.TabStop = false;
            this.card01.Click += new System.EventHandler(this.card_Click);
            // 
            // card03
            // 
            this.card03.Image = global::_4week_assignment.Properties.Resources.closed;
            this.card03.Location = new System.Drawing.Point(12, 318);
            this.card03.Name = "card03";
            this.card03.Size = new System.Drawing.Size(71, 96);
            this.card03.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.card03.TabIndex = 2;
            this.card03.TabStop = false;
            this.card03.Click += new System.EventHandler(this.card_Click);
            // 
            // card04
            // 
            this.card04.Image = global::_4week_assignment.Properties.Resources.closed;
            this.card04.Location = new System.Drawing.Point(12, 420);
            this.card04.Name = "card04";
            this.card04.Size = new System.Drawing.Size(71, 96);
            this.card04.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.card04.TabIndex = 3;
            this.card04.TabStop = false;
            this.card04.Click += new System.EventHandler(this.card_Click);
            // 
            // card02
            // 
            this.card02.Image = global::_4week_assignment.Properties.Resources.closed;
            this.card02.Location = new System.Drawing.Point(12, 216);
            this.card02.Name = "card02";
            this.card02.Size = new System.Drawing.Size(71, 96);
            this.card02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.card02.TabIndex = 4;
            this.card02.TabStop = false;
            this.card02.Click += new System.EventHandler(this.card_Click);
            // 
            // card00
            // 
            this.card00.Image = global::_4week_assignment.Properties.Resources.closed;
            this.card00.Location = new System.Drawing.Point(12, 12);
            this.card00.Name = "card00";
            this.card00.Size = new System.Drawing.Size(71, 96);
            this.card00.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.card00.TabIndex = 5;
            this.card00.TabStop = false;
            this.card00.Click += new System.EventHandler(this.card_Click);
            // 
            // timer_open
            // 
            this.timer_open.Enabled = true;
            this.timer_open.Interval = 500;
            this.timer_open.Tick += new System.EventHandler(this.timer_open_Tick);
            // 
            // timer_closed
            // 
            this.timer_closed.Interval = 200;
            this.timer_closed.Tick += new System.EventHandler(this.timer_closed_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(163, 528);
            this.Controls.Add(this.card00);
            this.Controls.Add(this.card02);
            this.Controls.Add(this.card04);
            this.Controls.Add(this.card03);
            this.Controls.Add(this.card01);
            this.Controls.Add(this.count);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.card01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card00)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label count;
        private System.Windows.Forms.PictureBox card01;
        private System.Windows.Forms.PictureBox card03;
        private System.Windows.Forms.PictureBox card04;
        private System.Windows.Forms.PictureBox card02;
        private System.Windows.Forms.PictureBox card00;
        private System.Windows.Forms.Timer timer_open;
        private System.Windows.Forms.Timer timer_closed;
    }
}

