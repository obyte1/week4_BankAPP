namespace week4_BankAPP.User_Inerface
{
    partial class WithdrawalForm
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
            this.txtAmountToWithdraw = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.lblErrorMsgWithdraw = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAmountToWithdraw
            // 
            this.txtAmountToWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountToWithdraw.Location = new System.Drawing.Point(276, 198);
            this.txtAmountToWithdraw.Name = "txtAmountToWithdraw";
            this.txtAmountToWithdraw.Size = new System.Drawing.Size(333, 30);
            this.txtAmountToWithdraw.TabIndex = 0;
            this.txtAmountToWithdraw.TextChanged += new System.EventHandler(this.txtAmountToWithdraw_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Amount:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(350, 293);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(121, 49);
            this.btnWithdraw.TabIndex = 2;
            this.btnWithdraw.Text = "WITHDRAW";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            // 
            // lblErrorMsgWithdraw
            // 
            this.lblErrorMsgWithdraw.AutoSize = true;
            this.lblErrorMsgWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMsgWithdraw.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMsgWithdraw.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            this.lblErrorMsgWithdraw.Location = new System.Drawing.Point(300, 240);
            this.lblErrorMsgWithdraw.Name = "lblErrorMsgWithdraw";
            this.lblErrorMsgWithdraw.Size = new System.Drawing.Size(112, 20);
            this.lblErrorMsgWithdraw.TabIndex = 3;
            this.lblErrorMsgWithdraw.Text = "ERROR MSG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(360, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "SUCCESS";
            // 
            // WithdrawalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 674);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblErrorMsgWithdraw);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAmountToWithdraw);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(367, 74);
            this.Name = "WithdrawalForm";
            this.Text = "WithdrawalForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAmountToWithdraw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Label lblErrorMsgWithdraw;
        private System.Windows.Forms.Label label3;
    }
}