namespace _3week_assignment
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
            this.btnToBit = new System.Windows.Forms.Button();
            this.btnFromBit = new System.Windows.Forms.Button();
            this.On = new System.Windows.Forms.Button();
            this.Off = new System.Windows.Forms.Button();
            this.Toggle = new System.Windows.Forms.Button();
            this.btnShiftDown = new System.Windows.Forms.Button();
            this.btnShiftUp = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.chk7 = new System.Windows.Forms.CheckBox();
            this.bit_box = new System.Windows.Forms.GroupBox();
            this.chk5 = new System.Windows.Forms.CheckBox();
            this.chk6 = new System.Windows.Forms.CheckBox();
            this.chk4 = new System.Windows.Forms.CheckBox();
            this.chk1 = new System.Windows.Forms.CheckBox();
            this.chk3 = new System.Windows.Forms.CheckBox();
            this.chk2 = new System.Windows.Forms.CheckBox();
            this.chk0 = new System.Windows.Forms.CheckBox();
            this.bit_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnToBit
            // 
            this.btnToBit.Location = new System.Drawing.Point(52, 10);
            this.btnToBit.Name = "btnToBit";
            this.btnToBit.Size = new System.Drawing.Size(60, 23);
            this.btnToBit.TabIndex = 0;
            this.btnToBit.Text = ">>";
            this.btnToBit.UseVisualStyleBackColor = true;
            this.btnToBit.Click += new System.EventHandler(this.btnToBit_Click);
            // 
            // btnFromBit
            // 
            this.btnFromBit.Location = new System.Drawing.Point(52, 41);
            this.btnFromBit.Name = "btnFromBit";
            this.btnFromBit.Size = new System.Drawing.Size(60, 23);
            this.btnFromBit.TabIndex = 1;
            this.btnFromBit.Text = "<<";
            this.btnFromBit.UseVisualStyleBackColor = true;
            this.btnFromBit.Click += new System.EventHandler(this.btnFromBit_Click);
            // 
            // On
            // 
            this.On.Location = new System.Drawing.Point(52, 70);
            this.On.Name = "On";
            this.On.Size = new System.Drawing.Size(60, 23);
            this.On.TabIndex = 2;
            this.On.Text = "On";
            this.On.UseVisualStyleBackColor = true;
            this.On.Click += new System.EventHandler(this.On_Click);
            // 
            // Off
            // 
            this.Off.Location = new System.Drawing.Point(52, 99);
            this.Off.Name = "Off";
            this.Off.Size = new System.Drawing.Size(60, 23);
            this.Off.TabIndex = 3;
            this.Off.Text = "Off";
            this.Off.UseVisualStyleBackColor = true;
            this.Off.Click += new System.EventHandler(this.Off_Click);
            // 
            // Toggle
            // 
            this.Toggle.Location = new System.Drawing.Point(52, 128);
            this.Toggle.Name = "Toggle";
            this.Toggle.Size = new System.Drawing.Size(60, 23);
            this.Toggle.TabIndex = 4;
            this.Toggle.Text = "Toggle";
            this.Toggle.UseVisualStyleBackColor = true;
            this.Toggle.Click += new System.EventHandler(this.Toggle_Click);
            // 
            // btnShiftDown
            // 
            this.btnShiftDown.Location = new System.Drawing.Point(12, 186);
            this.btnShiftDown.Name = "btnShiftDown";
            this.btnShiftDown.Size = new System.Drawing.Size(100, 23);
            this.btnShiftDown.TabIndex = 5;
            this.btnShiftDown.Text = "Shift_down";
            this.btnShiftDown.UseVisualStyleBackColor = true;
            this.btnShiftDown.Click += new System.EventHandler(this.btnShiftDown_Click);
            // 
            // btnShiftUp
            // 
            this.btnShiftUp.Location = new System.Drawing.Point(12, 157);
            this.btnShiftUp.Name = "btnShiftUp";
            this.btnShiftUp.Size = new System.Drawing.Size(100, 23);
            this.btnShiftUp.TabIndex = 6;
            this.btnShiftUp.Text = "Shift_up";
            this.btnShiftUp.UseVisualStyleBackColor = true;
            this.btnShiftUp.Click += new System.EventHandler(this.btnShiftUp_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(12, 12);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(34, 21);
            this.txtNumber.TabIndex = 15;
            this.txtNumber.Text = "256";
            // 
            // txtIndex
            // 
            this.txtIndex.Location = new System.Drawing.Point(12, 72);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(34, 21);
            this.txtIndex.TabIndex = 16;
            // 
            // chk7
            // 
            this.chk7.AutoSize = true;
            this.chk7.Location = new System.Drawing.Point(6, 22);
            this.chk7.Name = "chk7";
            this.chk7.Size = new System.Drawing.Size(30, 16);
            this.chk7.TabIndex = 7;
            this.chk7.Text = "7";
            this.chk7.UseVisualStyleBackColor = true;
            // 
            // bit_box
            // 
            this.bit_box.Controls.Add(this.chk0);
            this.bit_box.Controls.Add(this.chk2);
            this.bit_box.Controls.Add(this.chk3);
            this.bit_box.Controls.Add(this.chk1);
            this.bit_box.Controls.Add(this.chk4);
            this.bit_box.Controls.Add(this.chk6);
            this.bit_box.Controls.Add(this.chk5);
            this.bit_box.Controls.Add(this.chk7);
            this.bit_box.Location = new System.Drawing.Point(118, 13);
            this.bit_box.Name = "bit_box";
            this.bit_box.Size = new System.Drawing.Size(60, 196);
            this.bit_box.TabIndex = 17;
            this.bit_box.TabStop = false;
            this.bit_box.Text = "bit_box";
            // 
            // chk5
            // 
            this.chk5.AutoSize = true;
            this.chk5.Location = new System.Drawing.Point(6, 66);
            this.chk5.Name = "chk5";
            this.chk5.Size = new System.Drawing.Size(30, 16);
            this.chk5.TabIndex = 9;
            this.chk5.Text = "5";
            this.chk5.UseVisualStyleBackColor = true;
            // 
            // chk6
            // 
            this.chk6.AutoSize = true;
            this.chk6.Location = new System.Drawing.Point(6, 44);
            this.chk6.Name = "chk6";
            this.chk6.Size = new System.Drawing.Size(30, 16);
            this.chk6.TabIndex = 10;
            this.chk6.Text = "6";
            this.chk6.UseVisualStyleBackColor = true;
            // 
            // chk4
            // 
            this.chk4.AutoSize = true;
            this.chk4.Location = new System.Drawing.Point(6, 86);
            this.chk4.Name = "chk4";
            this.chk4.Size = new System.Drawing.Size(30, 16);
            this.chk4.TabIndex = 11;
            this.chk4.Text = "4";
            this.chk4.UseVisualStyleBackColor = true;
            // 
            // chk1
            // 
            this.chk1.AutoSize = true;
            this.chk1.Location = new System.Drawing.Point(6, 149);
            this.chk1.Name = "chk1";
            this.chk1.Size = new System.Drawing.Size(30, 16);
            this.chk1.TabIndex = 12;
            this.chk1.Text = "1";
            this.chk1.UseVisualStyleBackColor = true;
            // 
            // chk3
            // 
            this.chk3.AutoSize = true;
            this.chk3.Location = new System.Drawing.Point(6, 105);
            this.chk3.Name = "chk3";
            this.chk3.Size = new System.Drawing.Size(30, 16);
            this.chk3.TabIndex = 12;
            this.chk3.Text = "3";
            this.chk3.UseVisualStyleBackColor = true;
            // 
            // chk2
            // 
            this.chk2.AutoSize = true;
            this.chk2.Location = new System.Drawing.Point(6, 127);
            this.chk2.Name = "chk2";
            this.chk2.Size = new System.Drawing.Size(30, 16);
            this.chk2.TabIndex = 13;
            this.chk2.Text = "2";
            this.chk2.UseVisualStyleBackColor = true;
            // 
            // chk0
            // 
            this.chk0.AutoSize = true;
            this.chk0.Location = new System.Drawing.Point(6, 170);
            this.chk0.Name = "chk0";
            this.chk0.Size = new System.Drawing.Size(30, 16);
            this.chk0.TabIndex = 14;
            this.chk0.Text = "0";
            this.chk0.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 215);
            this.Controls.Add(this.bit_box);
            this.Controls.Add(this.txtIndex);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.btnShiftUp);
            this.Controls.Add(this.btnShiftDown);
            this.Controls.Add(this.Toggle);
            this.Controls.Add(this.Off);
            this.Controls.Add(this.On);
            this.Controls.Add(this.btnFromBit);
            this.Controls.Add(this.btnToBit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.bit_box.ResumeLayout(false);
            this.bit_box.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnToBit;
        private System.Windows.Forms.Button btnFromBit;
        private System.Windows.Forms.Button On;
        private System.Windows.Forms.Button Off;
        private System.Windows.Forms.Button Toggle;
        private System.Windows.Forms.Button btnShiftDown;
        private System.Windows.Forms.Button btnShiftUp;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtIndex;
        private System.Windows.Forms.CheckBox chk7;
        private System.Windows.Forms.GroupBox bit_box;
        private System.Windows.Forms.CheckBox chk2;
        private System.Windows.Forms.CheckBox chk3;
        private System.Windows.Forms.CheckBox chk1;
        private System.Windows.Forms.CheckBox chk4;
        private System.Windows.Forms.CheckBox chk6;
        private System.Windows.Forms.CheckBox chk5;
        private System.Windows.Forms.CheckBox chk0;
    }
}

