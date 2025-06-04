namespace DllMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNPrime = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtNMax = new System.Windows.Forms.TextBox();
            this.btnInCSharp = new System.Windows.Forms.Button();
            this.btnInCPP = new System.Windows.Forms.Button();
            this.btn_sort_cs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "N Max :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "N Prime :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Time(sec) :";
            // 
            // lblNPrime
            // 
            this.lblNPrime.AutoSize = true;
            this.lblNPrime.Location = new System.Drawing.Point(112, 90);
            this.lblNPrime.Name = "lblNPrime";
            this.lblNPrime.Size = new System.Drawing.Size(15, 14);
            this.lblNPrime.TabIndex = 3;
            this.lblNPrime.Text = "0";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(112, 131);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(15, 14);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "0";
            // 
            // txtNMax
            // 
            this.txtNMax.Location = new System.Drawing.Point(112, 45);
            this.txtNMax.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNMax.Name = "txtNMax";
            this.txtNMax.Size = new System.Drawing.Size(79, 22);
            this.txtNMax.TabIndex = 5;
            this.txtNMax.Text = "3000";
            // 
            // btnInCSharp
            // 
            this.btnInCSharp.Location = new System.Drawing.Point(267, 45);
            this.btnInCSharp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInCSharp.Name = "btnInCSharp";
            this.btnInCSharp.Size = new System.Drawing.Size(104, 52);
            this.btnInCSharp.TabIndex = 6;
            this.btnInCSharp.Text = "in C#";
            this.btnInCSharp.UseVisualStyleBackColor = true;
            this.btnInCSharp.Click += new System.EventHandler(this.btnInCSharp_Click);
            // 
            // btnInCPP
            // 
            this.btnInCPP.Location = new System.Drawing.Point(267, 123);
            this.btnInCPP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInCPP.Name = "btnInCPP";
            this.btnInCPP.Size = new System.Drawing.Size(104, 52);
            this.btnInCPP.TabIndex = 7;
            this.btnInCPP.Text = "in C++";
            this.btnInCPP.UseVisualStyleBackColor = true;
            this.btnInCPP.Click += new System.EventHandler(this.btnInCPP_Click);
            // 
            // btn_sort_cs
            // 
            this.btn_sort_cs.Location = new System.Drawing.Point(398, 45);
            this.btn_sort_cs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_sort_cs.Name = "btn_sort_cs";
            this.btn_sort_cs.Size = new System.Drawing.Size(104, 52);
            this.btn_sort_cs.TabIndex = 8;
            this.btn_sort_cs.Text = "sort C#";
            this.btn_sort_cs.UseVisualStyleBackColor = true;
            this.btn_sort_cs.Click += new System.EventHandler(this.btn_sort_cs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 205);
            this.Controls.Add(this.btn_sort_cs);
            this.Controls.Add(this.btnInCPP);
            this.Controls.Add(this.btnInCSharp);
            this.Controls.Add(this.txtNMax);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblNPrime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "N Prime";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNPrime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtNMax;
        private System.Windows.Forms.Button btnInCSharp;
        private System.Windows.Forms.Button btnInCPP;
        private System.Windows.Forms.Button btn_sort_cs;
    }
}

