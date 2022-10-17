namespace week4_BankAPP.User_Inerface
{
    partial class DepositForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepositForm));
            this.txtAmountToDeposit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorMsgDeposit = new System.Windows.Forms.Label();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.SuccessMsgDeposit = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAmountToDeposit
            // 
            this.txtAmountToDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountToDeposit.Location = new System.Drawing.Point(212, 249);
            this.txtAmountToDeposit.Name = "txtAmountToDeposit";
            this.txtAmountToDeposit.Size = new System.Drawing.Size(322, 30);
            this.txtAmountToDeposit.TabIndex = 0;
            this.txtAmountToDeposit.TextChanged += new System.EventHandler(this.txtAmountToDeposit_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(91, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Amount:";
            // 
            // errorMsgDeposit
            // 
            this.errorMsgDeposit.AutoSize = true;
            this.errorMsgDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMsgDeposit.ForeColor = System.Drawing.Color.Red;
            this.errorMsgDeposit.Location = new System.Drawing.Point(227, 282);
            this.errorMsgDeposit.Name = "errorMsgDeposit";
            this.errorMsgDeposit.Size = new System.Drawing.Size(140, 25);
            this.errorMsgDeposit.TabIndex = 2;
            this.errorMsgDeposit.Text = "Error Message";
            // 
            // btnDeposit
            // 
            this.btnDeposit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDeposit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDeposit.Location = new System.Drawing.Point(321, 346);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(108, 32);
            this.btnDeposit.TabIndex = 3;
            this.btnDeposit.Text = "DEPOSIT";
            this.btnDeposit.UseVisualStyleBackColor = true;
            // 
            // SuccessMsgDeposit
            // 
            this.SuccessMsgDeposit.AutoSize = true;
            this.SuccessMsgDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuccessMsgDeposit.ForeColor = System.Drawing.Color.Green;
            this.SuccessMsgDeposit.Location = new System.Drawing.Point(293, 94);
            this.SuccessMsgDeposit.Name = "SuccessMsgDeposit";
            this.SuccessMsgDeposit.Size = new System.Drawing.Size(174, 25);
            this.SuccessMsgDeposit.TabIndex = 4;
            this.SuccessMsgDeposit.Text = "Success Message";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(321, 149);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // DepositForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 674);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SuccessMsgDeposit);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.errorMsgDeposit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAmountToDeposit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(367, 74);
            this.Name = "DepositForm";
            this.Text = "DepositForm";
            this.Load += new System.EventHandler(this.DepositForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAmountToDeposit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label errorMsgDeposit;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Label SuccessMsgDeposit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}