namespace LinkedList
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
            this.btnMake20 = new System.Windows.Forms.Button();
            this.txtPrint = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtRemoveData = new System.Windows.Forms.TextBox();
            this.btnReverse = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMake20
            // 
            this.btnMake20.Location = new System.Drawing.Point(24, 117);
            this.btnMake20.Name = "btnMake20";
            this.btnMake20.Size = new System.Drawing.Size(99, 58);
            this.btnMake20.TabIndex = 0;
            this.btnMake20.Text = "Make 20";
            this.btnMake20.UseVisualStyleBackColor = true;
            this.btnMake20.Click += new System.EventHandler(this.btnMake20_Click);
            // 
            // txtPrint
            // 
            this.txtPrint.Location = new System.Drawing.Point(143, 24);
            this.txtPrint.Multiline = true;
            this.txtPrint.Name = "txtPrint";
            this.txtPrint.Size = new System.Drawing.Size(457, 457);
            this.txtPrint.TabIndex = 1;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(24, 213);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(99, 58);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // txtRemoveData
            // 
            this.txtRemoveData.Location = new System.Drawing.Point(24, 277);
            this.txtRemoveData.Name = "txtRemoveData";
            this.txtRemoveData.Size = new System.Drawing.Size(79, 21);
            this.txtRemoveData.TabIndex = 3;
            this.txtRemoveData.Text = "5";
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(24, 334);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(99, 58);
            this.btnReverse.TabIndex = 4;
            this.btnReverse.Text = "Reverse";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(24, 423);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(99, 58);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(24, 24);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(99, 58);
            this.btnTest.TabIndex = 6;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 501);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.txtRemoveData);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.txtPrint);
            this.Controls.Add(this.btnMake20);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMake20;
        private System.Windows.Forms.TextBox txtPrint;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox txtRemoveData;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnTest;
    }
}

