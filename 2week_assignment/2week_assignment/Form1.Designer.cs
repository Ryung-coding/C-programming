namespace _2week_assignment
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
            this.print_label = new System.Windows.Forms.Label();
            this.pic_draw = new System.Windows.Forms.PictureBox();
            this.green = new System.Windows.Forms.RadioButton();
            this.blue = new System.Windows.Forms.RadioButton();
            this.red = new System.Windows.Forms.RadioButton();
            this.color_box = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_draw)).BeginInit();
            this.color_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // print_label
            // 
            this.print_label.AutoSize = true;
            this.print_label.Font = new System.Drawing.Font("한컴 훈민정음 세로쓰기", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.print_label.Location = new System.Drawing.Point(53, 25);
            this.print_label.Name = "print_label";
            this.print_label.Size = new System.Drawing.Size(0, 35);
            this.print_label.TabIndex = 1;
            // 
            // pic_draw
            // 
            this.pic_draw.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pic_draw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_draw.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pic_draw.Location = new System.Drawing.Point(12, 12);
            this.pic_draw.Name = "pic_draw";
            this.pic_draw.Size = new System.Drawing.Size(475, 520);
            this.pic_draw.TabIndex = 2;
            this.pic_draw.TabStop = false;
            this.pic_draw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_draw_MouseDown);
            this.pic_draw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_draw_MouseMove);
            // 
            // green
            // 
            this.green.AutoSize = true;
            this.green.Location = new System.Drawing.Point(6, 40);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(55, 16);
            this.green.TabIndex = 4;
            this.green.Text = "green";
            this.green.UseVisualStyleBackColor = true;
            // 
            // blue
            // 
            this.blue.AutoSize = true;
            this.blue.Location = new System.Drawing.Point(6, 64);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(47, 16);
            this.blue.TabIndex = 5;
            this.blue.Text = "blue";
            this.blue.UseVisualStyleBackColor = true;
            // 
            // red
            // 
            this.red.AutoSize = true;
            this.red.Location = new System.Drawing.Point(6, 18);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(41, 16);
            this.red.TabIndex = 6;
            this.red.Text = "red";
            this.red.UseVisualStyleBackColor = true;
            // 
            // color_box
            // 
            this.color_box.Controls.Add(this.green);
            this.color_box.Controls.Add(this.blue);
            this.color_box.Controls.Add(this.red);
            this.color_box.Location = new System.Drawing.Point(493, 12);
            this.color_box.Name = "color_box";
            this.color_box.Size = new System.Drawing.Size(81, 88);
            this.color_box.TabIndex = 7;
            this.color_box.TabStop = false;
            this.color_box.Text = "color";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(583, 544);
            this.Controls.Add(this.color_box);
            this.Controls.Add(this.pic_draw);
            this.Controls.Add(this.print_label);
            this.Name = "Form1";
            this.Text = "windows";
            ((System.ComponentModel.ISupportInitialize)(this.pic_draw)).EndInit();
            this.color_box.ResumeLayout(false);
            this.color_box.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected internal System.Windows.Forms.Label print_label;
        private System.Windows.Forms.PictureBox pic_draw;
        private System.Windows.Forms.RadioButton green;
        private System.Windows.Forms.RadioButton blue;
        private System.Windows.Forms.RadioButton red;
        private System.Windows.Forms.GroupBox color_box;
    }
}

