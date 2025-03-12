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
            this.components = new System.ComponentModel.Container();
            this.label = new System.Windows.Forms.Label();
            this.print_label = new System.Windows.Forms.Label();
            this.time_Controller = new System.Windows.Forms.Timer(this.components);
            this.undo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label.Font = new System.Drawing.Font("한컴 훈민정음 세로쓰기", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label.Location = new System.Drawing.Point(12, 25);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(48, 35);
            this.label.TabIndex = 0;
            this.label.Text = "10";
            // 
            // print_label
            // 
            this.print_label.AutoSize = true;
            this.print_label.Font = new System.Drawing.Font("한컴 훈민정음 세로쓰기", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.print_label.Location = new System.Drawing.Point(53, 25);
            this.print_label.Name = "print_label";
            this.print_label.Size = new System.Drawing.Size(264, 35);
            this.print_label.TabIndex = 1;
            this.print_label.Text = "s 남았습니다 ㅋㅋ";
            // 
            // time_Controller
            // 
            this.time_Controller.Enabled = true;
            this.time_Controller.Interval = 200;
            this.time_Controller.Tick += new System.EventHandler(this.time_Controller_Tick);
            // 
            // undo
            // 
            this.undo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.undo.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.undo.Location = new System.Drawing.Point(127, 108);
            this.undo.Name = "undo";
            this.undo.Size = new System.Drawing.Size(43, 23);
            this.undo.TabIndex = 2;
            this.undo.Text = "undo";
            this.undo.UseVisualStyleBackColor = false;
            this.undo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.undo_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 256);
            this.Controls.Add(this.undo);
            this.Controls.Add(this.print_label);
            this.Controls.Add(this.label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        protected internal System.Windows.Forms.Label print_label;
        private System.Windows.Forms.Timer time_Controller;
        private System.Windows.Forms.Button undo;
    }
}

