namespace tClient
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
            this.lblCommNG = new System.Windows.Forms.Label();
            this.lblCommOK = new System.Windows.Forms.Label();
            this.lblConnComm = new System.Windows.Forms.Label();
            this.btnReadBits = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.picLamp07 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.picLamp06 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.picLamp05 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.picLamp04 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.picLamp03 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.picLamp02 = new System.Windows.Forms.PictureBox();
            this.picLamp01 = new System.Windows.Forms.PictureBox();
            this.picLamp00 = new System.Windows.Forms.PictureBox();
            this.btnServerMe = new System.Windows.Forms.Button();
            this.txtServerIP = new System.Windows.Forms.TextBox();
            this.lblConnChat = new System.Windows.Forms.Label();
            this.pnlDraw = new System.Windows.Forms.Panel();
            this.lblO = new System.Windows.Forms.Label();
            this.lblComInfo = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.txtDialog = new System.Windows.Forms.TextBox();
            this.lblConnCopy = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.timConnStatus = new System.Windows.Forms.Timer(this.components);
            this.timGetRcvMsg = new System.Windows.Forms.Timer(this.components);
            this.timAskBits = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLamp07)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLamp06)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLamp05)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLamp04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLamp03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLamp02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLamp01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLamp00)).BeginInit();
            this.pnlDraw.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCommNG
            // 
            this.lblCommNG.AutoSize = true;
            this.lblCommNG.Location = new System.Drawing.Point(510, 574);
            this.lblCommNG.Name = "lblCommNG";
            this.lblCommNG.Size = new System.Drawing.Size(11, 12);
            this.lblCommNG.TabIndex = 106;
            this.lblCommNG.Text = "0";
            // 
            // lblCommOK
            // 
            this.lblCommOK.AutoSize = true;
            this.lblCommOK.Location = new System.Drawing.Point(510, 558);
            this.lblCommOK.Name = "lblCommOK";
            this.lblCommOK.Size = new System.Drawing.Size(11, 12);
            this.lblCommOK.TabIndex = 105;
            this.lblCommOK.Text = "0";
            // 
            // lblConnComm
            // 
            this.lblConnComm.AutoSize = true;
            this.lblConnComm.Location = new System.Drawing.Point(431, 171);
            this.lblConnComm.Name = "lblConnComm";
            this.lblConnComm.Size = new System.Drawing.Size(86, 12);
            this.lblConnComm.TabIndex = 104;
            this.lblConnComm.Text = "lblConnComm";
            // 
            // btnReadBits
            // 
            this.btnReadBits.Location = new System.Drawing.Point(434, 556);
            this.btnReadBits.Name = "btnReadBits";
            this.btnReadBits.Size = new System.Drawing.Size(69, 30);
            this.btnReadBits.TabIndex = 103;
            this.btnReadBits.Text = "Read Bits";
            this.btnReadBits.UseVisualStyleBackColor = true;
            this.btnReadBits.Click += new System.EventHandler(this.btnReadBits_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.picLamp07);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.picLamp06);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.picLamp05);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.picLamp04);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.picLamp03);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.picLamp02);
            this.groupBox2.Controls.Add(this.picLamp01);
            this.groupBox2.Controls.Add(this.picLamp00);
            this.groupBox2.Location = new System.Drawing.Point(433, 334);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(119, 216);
            this.groupBox2.TabIndex = 102;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "입력접점";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 123;
            this.label9.Text = "입력접점2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 116;
            this.label2.Text = "입력접점8";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 122;
            this.label8.Text = "입력접점3";
            // 
            // picLamp07
            // 
            this.picLamp07.BackColor = System.Drawing.Color.Gray;
            this.picLamp07.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLamp07.Location = new System.Drawing.Point(21, 21);
            this.picLamp07.Name = "picLamp07";
            this.picLamp07.Size = new System.Drawing.Size(13, 13);
            this.picLamp07.TabIndex = 108;
            this.picLamp07.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 121;
            this.label7.Text = "입력접점4";
            // 
            // picLamp06
            // 
            this.picLamp06.BackColor = System.Drawing.Color.Gray;
            this.picLamp06.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLamp06.Location = new System.Drawing.Point(21, 45);
            this.picLamp06.Name = "picLamp06";
            this.picLamp06.Size = new System.Drawing.Size(13, 13);
            this.picLamp06.TabIndex = 109;
            this.picLamp06.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 120;
            this.label6.Text = "입력접점5";
            // 
            // picLamp05
            // 
            this.picLamp05.BackColor = System.Drawing.Color.Gray;
            this.picLamp05.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLamp05.Location = new System.Drawing.Point(21, 69);
            this.picLamp05.Name = "picLamp05";
            this.picLamp05.Size = new System.Drawing.Size(13, 13);
            this.picLamp05.TabIndex = 110;
            this.picLamp05.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 119;
            this.label5.Text = "입력접점6";
            // 
            // picLamp04
            // 
            this.picLamp04.BackColor = System.Drawing.Color.Gray;
            this.picLamp04.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLamp04.Location = new System.Drawing.Point(21, 93);
            this.picLamp04.Name = "picLamp04";
            this.picLamp04.Size = new System.Drawing.Size(13, 13);
            this.picLamp04.TabIndex = 111;
            this.picLamp04.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 118;
            this.label4.Text = "입력접점7";
            // 
            // picLamp03
            // 
            this.picLamp03.BackColor = System.Drawing.Color.Gray;
            this.picLamp03.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLamp03.Location = new System.Drawing.Point(21, 117);
            this.picLamp03.Name = "picLamp03";
            this.picLamp03.Size = new System.Drawing.Size(13, 13);
            this.picLamp03.TabIndex = 112;
            this.picLamp03.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 117;
            this.label3.Text = "입력접점1";
            // 
            // picLamp02
            // 
            this.picLamp02.BackColor = System.Drawing.Color.Gray;
            this.picLamp02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLamp02.Location = new System.Drawing.Point(21, 141);
            this.picLamp02.Name = "picLamp02";
            this.picLamp02.Size = new System.Drawing.Size(13, 13);
            this.picLamp02.TabIndex = 113;
            this.picLamp02.TabStop = false;
            // 
            // picLamp01
            // 
            this.picLamp01.BackColor = System.Drawing.Color.Gray;
            this.picLamp01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLamp01.Location = new System.Drawing.Point(21, 165);
            this.picLamp01.Name = "picLamp01";
            this.picLamp01.Size = new System.Drawing.Size(13, 13);
            this.picLamp01.TabIndex = 114;
            this.picLamp01.TabStop = false;
            // 
            // picLamp00
            // 
            this.picLamp00.BackColor = System.Drawing.Color.Gray;
            this.picLamp00.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLamp00.Location = new System.Drawing.Point(21, 189);
            this.picLamp00.Name = "picLamp00";
            this.picLamp00.Size = new System.Drawing.Size(13, 13);
            this.picLamp00.TabIndex = 115;
            this.picLamp00.TabStop = false;
            // 
            // btnServerMe
            // 
            this.btnServerMe.Location = new System.Drawing.Point(509, 54);
            this.btnServerMe.Name = "btnServerMe";
            this.btnServerMe.Size = new System.Drawing.Size(42, 22);
            this.btnServerMe.TabIndex = 101;
            this.btnServerMe.Text = "Me";
            this.btnServerMe.UseVisualStyleBackColor = true;
            this.btnServerMe.Click += new System.EventHandler(this.btnServerMe_Click);
            // 
            // txtServerIP
            // 
            this.txtServerIP.Location = new System.Drawing.Point(431, 29);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(120, 21);
            this.txtServerIP.TabIndex = 99;
            // 
            // lblConnChat
            // 
            this.lblConnChat.AutoSize = true;
            this.lblConnChat.Location = new System.Drawing.Point(431, 139);
            this.lblConnChat.Name = "lblConnChat";
            this.lblConnChat.Size = new System.Drawing.Size(74, 12);
            this.lblConnChat.TabIndex = 98;
            this.lblConnChat.Text = "lblConnChat";
            // 
            // pnlDraw
            // 
            this.pnlDraw.BackColor = System.Drawing.Color.Silver;
            this.pnlDraw.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDraw.Controls.Add(this.lblO);
            this.pnlDraw.Location = new System.Drawing.Point(12, 292);
            this.pnlDraw.Name = "pnlDraw";
            this.pnlDraw.Size = new System.Drawing.Size(411, 253);
            this.pnlDraw.TabIndex = 97;
            this.pnlDraw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlDraw_MouseDown);
            this.pnlDraw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlDraw_MouseMove);
            // 
            // lblO
            // 
            this.lblO.AutoSize = true;
            this.lblO.Location = new System.Drawing.Point(115, 37);
            this.lblO.Name = "lblO";
            this.lblO.Size = new System.Drawing.Size(14, 12);
            this.lblO.TabIndex = 1;
            this.lblO.Text = "O";
            // 
            // lblComInfo
            // 
            this.lblComInfo.AutoSize = true;
            this.lblComInfo.Location = new System.Drawing.Point(431, 83);
            this.lblComInfo.Name = "lblComInfo";
            this.lblComInfo.Size = new System.Drawing.Size(65, 12);
            this.lblComInfo.TabIndex = 96;
            this.lblComInfo.Text = "lblComInfo";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(431, 287);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(121, 41);
            this.btnSend.TabIndex = 95;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(12, 265);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(411, 21);
            this.txtSend.TabIndex = 94;
            // 
            // txtDialog
            // 
            this.txtDialog.Location = new System.Drawing.Point(12, 12);
            this.txtDialog.Multiline = true;
            this.txtDialog.Name = "txtDialog";
            this.txtDialog.Size = new System.Drawing.Size(411, 247);
            this.txtDialog.TabIndex = 93;
            // 
            // lblConnCopy
            // 
            this.lblConnCopy.AutoSize = true;
            this.lblConnCopy.Location = new System.Drawing.Point(431, 155);
            this.lblConnCopy.Name = "lblConnCopy";
            this.lblConnCopy.Size = new System.Drawing.Size(78, 12);
            this.lblConnCopy.TabIndex = 92;
            this.lblConnCopy.Text = "lblConnCopy";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(431, 242);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(121, 41);
            this.btnClose.TabIndex = 91;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(431, 197);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(121, 41);
            this.btnConnect.TabIndex = 90;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // timConnStatus
            // 
            this.timConnStatus.Enabled = true;
            this.timConnStatus.Tick += new System.EventHandler(this.timConnStatus_Tick);
            // 
            // timGetRcvMsg
            // 
            this.timGetRcvMsg.Enabled = true;
            this.timGetRcvMsg.Interval = 10;
            this.timGetRcvMsg.Tick += new System.EventHandler(this.timGetRcvMsg_Tick);
            // 
            // timAskBits
            // 
            this.timAskBits.Enabled = true;
            this.timAskBits.Tick += new System.EventHandler(this.timAskBits_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(431, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 12);
            this.label1.TabIndex = 107;
            this.label1.Text = "Server IP";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 596);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCommNG);
            this.Controls.Add(this.lblCommOK);
            this.Controls.Add(this.lblConnComm);
            this.Controls.Add(this.btnReadBits);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnServerMe);
            this.Controls.Add(this.txtServerIP);
            this.Controls.Add(this.lblConnChat);
            this.Controls.Add(this.pnlDraw);
            this.Controls.Add(this.lblComInfo);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtSend);
            this.Controls.Add(this.txtDialog);
            this.Controls.Add(this.lblConnCopy);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnConnect);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLamp07)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLamp06)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLamp05)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLamp04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLamp03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLamp02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLamp01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLamp00)).EndInit();
            this.pnlDraw.ResumeLayout(false);
            this.pnlDraw.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCommNG;
        private System.Windows.Forms.Label lblCommOK;
        private System.Windows.Forms.Label lblConnComm;
        private System.Windows.Forms.Button btnReadBits;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnServerMe;
        private System.Windows.Forms.TextBox txtServerIP;
        private System.Windows.Forms.Label lblConnChat;
        private System.Windows.Forms.Panel pnlDraw;
        private System.Windows.Forms.Label lblO;
        private System.Windows.Forms.Label lblComInfo;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.TextBox txtDialog;
        private System.Windows.Forms.Label lblConnCopy;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Timer timConnStatus;
        private System.Windows.Forms.Timer timGetRcvMsg;
        private System.Windows.Forms.Timer timAskBits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picLamp07;
        private System.Windows.Forms.PictureBox picLamp06;
        private System.Windows.Forms.PictureBox picLamp05;
        private System.Windows.Forms.PictureBox picLamp04;
        private System.Windows.Forms.PictureBox picLamp00;
        private System.Windows.Forms.PictureBox picLamp01;
        private System.Windows.Forms.PictureBox picLamp02;
        private System.Windows.Forms.PictureBox picLamp03;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

