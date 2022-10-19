namespace week4_BankAPP.User_Inerface
{
    partial class UserDashBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDashBoard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.picCloase = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblLogOut = new System.Windows.Forms.Label();
            this.pbLogOut = new System.Windows.Forms.PictureBox();
            this.lblWelcomeUser = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblPrintStatement = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblCheckBalance = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblTransfer = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblWithdrawal = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblaccountnumberDisplay = new System.Windows.Forms.Label();
            this.lblAmountDisplay = new System.Windows.Forms.Label();
            this.lblAccountType = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCloase)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.picCloase);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1215, 65);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(474, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "DESKTOP BANK";
            // 
            // picCloase
            // 
            this.picCloase.Image = ((System.Drawing.Image)(resources.GetObject("picCloase.Image")));
            this.picCloase.Location = new System.Drawing.Point(1155, 3);
            this.picCloase.Name = "picCloase";
            this.picCloase.Size = new System.Drawing.Size(50, 50);
            this.picCloase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCloase.TabIndex = 7;
            this.picCloase.TabStop = false;
            this.picCloase.Click += new System.EventHandler(this.picCloase_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.lblAccountType);
            this.panel2.Controls.Add(this.lblAmountDisplay);
            this.panel2.Controls.Add(this.lblaccountnumberDisplay);
            this.panel2.Controls.Add(this.lblLogOut);
            this.panel2.Controls.Add(this.pbLogOut);
            this.panel2.Controls.Add(this.lblWelcomeUser);
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lblWelcome);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(357, 697);
            this.panel2.TabIndex = 1;
            // 
            // lblLogOut
            // 
            this.lblLogOut.AutoSize = true;
            this.lblLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogOut.ForeColor = System.Drawing.Color.White;
            this.lblLogOut.Location = new System.Drawing.Point(96, 638);
            this.lblLogOut.Name = "lblLogOut";
            this.lblLogOut.Size = new System.Drawing.Size(82, 25);
            this.lblLogOut.TabIndex = 7;
            this.lblLogOut.Text = "Log Out";
            this.lblLogOut.Click += new System.EventHandler(this.lblLogOut_Click);
            // 
            // pbLogOut
            // 
            this.pbLogOut.Image = ((System.Drawing.Image)(resources.GetObject("pbLogOut.Image")));
            this.pbLogOut.Location = new System.Drawing.Point(119, 600);
            this.pbLogOut.Name = "pbLogOut";
            this.pbLogOut.Size = new System.Drawing.Size(32, 32);
            this.pbLogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbLogOut.TabIndex = 5;
            this.pbLogOut.TabStop = false;
            // 
            // lblWelcomeUser
            // 
            this.lblWelcomeUser.AutoSize = true;
            this.lblWelcomeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblWelcomeUser.Location = new System.Drawing.Point(134, 32);
            this.lblWelcomeUser.Name = "lblWelcomeUser";
            this.lblWelcomeUser.Size = new System.Drawing.Size(70, 25);
            this.lblWelcomeUser.TabIndex = 8;
            this.lblWelcomeUser.Text = "label2";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(12, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(88, 94);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 7;
            this.pictureBox6.TabStop = false;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.pictureBox2);
            this.panel8.Controls.Add(this.lblPrintStatement);
            this.panel8.Location = new System.Drawing.Point(1, 459);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(356, 73);
            this.panel8.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // lblPrintStatement
            // 
            this.lblPrintStatement.AutoSize = true;
            this.lblPrintStatement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrintStatement.ForeColor = System.Drawing.Color.White;
            this.lblPrintStatement.Location = new System.Drawing.Point(69, 35);
            this.lblPrintStatement.Name = "lblPrintStatement";
            this.lblPrintStatement.Size = new System.Drawing.Size(199, 25);
            this.lblPrintStatement.TabIndex = 4;
            this.lblPrintStatement.Text = "PRINT STATEMENT";
            this.lblPrintStatement.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.pictureBox3);
            this.panel7.Controls.Add(this.lblCheckBalance);
            this.panel7.Location = new System.Drawing.Point(1, 386);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(356, 73);
            this.panel7.TabIndex = 4;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(7, 19);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // lblCheckBalance
            // 
            this.lblCheckBalance.AutoSize = true;
            this.lblCheckBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckBalance.ForeColor = System.Drawing.Color.White;
            this.lblCheckBalance.Location = new System.Drawing.Point(71, 37);
            this.lblCheckBalance.Name = "lblCheckBalance";
            this.lblCheckBalance.Size = new System.Drawing.Size(182, 25);
            this.lblCheckBalance.TabIndex = 3;
            this.lblCheckBalance.Text = "CHECK BALANCE";
            this.lblCheckBalance.Click += new System.EventHandler(this.lblCheckBalance_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.pictureBox4);
            this.panel6.Controls.Add(this.lblTransfer);
            this.panel6.Location = new System.Drawing.Point(1, 313);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(356, 73);
            this.panel6.TabIndex = 3;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(7, 15);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(48, 48);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // lblTransfer
            // 
            this.lblTransfer.AutoSize = true;
            this.lblTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransfer.ForeColor = System.Drawing.Color.White;
            this.lblTransfer.Location = new System.Drawing.Point(80, 37);
            this.lblTransfer.Name = "lblTransfer";
            this.lblTransfer.Size = new System.Drawing.Size(118, 25);
            this.lblTransfer.TabIndex = 2;
            this.lblTransfer.Text = "TRANSFER";
            this.lblTransfer.Click += new System.EventHandler(this.lblTransfer_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblWithdrawal);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(1, 240);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(356, 73);
            this.panel4.TabIndex = 2;
            // 
            // lblWithdrawal
            // 
            this.lblWithdrawal.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblWithdrawal.AutoSize = true;
            this.lblWithdrawal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWithdrawal.ForeColor = System.Drawing.Color.White;
            this.lblWithdrawal.Location = new System.Drawing.Point(75, 37);
            this.lblWithdrawal.Name = "lblWithdrawal";
            this.lblWithdrawal.Size = new System.Drawing.Size(150, 25);
            this.lblWithdrawal.TabIndex = 1;
            this.lblWithdrawal.Text = "WITHDRAWAL";
            this.lblWithdrawal.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox5);
            this.panel3.Controls.Add(this.lblDeposit);
            this.panel3.Location = new System.Drawing.Point(1, 168);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(356, 73);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(7, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(48, 48);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeposit.ForeColor = System.Drawing.Color.White;
            this.lblDeposit.Location = new System.Drawing.Point(78, 35);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(100, 25);
            this.lblDeposit.TabIndex = 0;
            this.lblDeposit.Text = "DEPOSIT";
            this.lblDeposit.Click += new System.EventHandler(this.lblDeposit_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(155, 6);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(85, 22);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "welcome:";
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // lblaccountnumberDisplay
            // 
            this.lblaccountnumberDisplay.AutoSize = true;
            this.lblaccountnumberDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaccountnumberDisplay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblaccountnumberDisplay.Location = new System.Drawing.Point(123, 78);
            this.lblaccountnumberDisplay.Name = "lblaccountnumberDisplay";
            this.lblaccountnumberDisplay.Size = new System.Drawing.Size(98, 22);
            this.lblaccountnumberDisplay.TabIndex = 9;
            this.lblaccountnumberDisplay.Text = "account no";
            // 
            // lblAmountDisplay
            // 
            this.lblAmountDisplay.AutoSize = true;
            this.lblAmountDisplay.ForeColor = System.Drawing.Color.LightCoral;
            this.lblAmountDisplay.Location = new System.Drawing.Point(125, 122);
            this.lblAmountDisplay.Name = "lblAmountDisplay";
            this.lblAmountDisplay.Size = new System.Drawing.Size(76, 16);
            this.lblAmountDisplay.TabIndex = 10;
            this.lblAmountDisplay.Text = "account bal";
            // 
            // lblAccountType
            // 
            this.lblAccountType.AutoSize = true;
            this.lblAccountType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountType.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAccountType.Location = new System.Drawing.Point(118, 97);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(98, 22);
            this.lblAccountType.TabIndex = 11;
            this.lblAccountType.Text = "account no";
            // 
            // UserDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1215, 762);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "UserDashBoard";
            this.Text = "UserDashBoard";
            this.Load += new System.EventHandler(this.UserDashBoard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCloase)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPrintStatement;
        private System.Windows.Forms.Label lblCheckBalance;
        private System.Windows.Forms.Label lblTransfer;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblWithdrawal;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox picCloase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWelcomeUser;
        private System.Windows.Forms.Label lblLogOut;
        private System.Windows.Forms.PictureBox pbLogOut;
        private System.Windows.Forms.Label lblAmountDisplay;
        private System.Windows.Forms.Label lblaccountnumberDisplay;
        private System.Windows.Forms.Label lblAccountType;
    }
}