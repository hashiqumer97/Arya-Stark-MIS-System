namespace AryaStarkHashiqCsd55
{
    partial class frm_validatestocks
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
            this.btn_cancel = new MetroFramework.Controls.MetroButton();
            this.btn_proceed = new MetroFramework.Controls.MetroButton();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbl_user_detailsTableAdapter1 = new AryaStarkHashiqCsd55.DataSet1TableAdapters.tbl_user_detailsTableAdapter();
            this.lbl_passworderror = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(280, 87);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(96, 23);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseSelectable = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_proceed
            // 
            this.btn_proceed.Location = new System.Drawing.Point(156, 87);
            this.btn_proceed.Name = "btn_proceed";
            this.btn_proceed.Size = new System.Drawing.Size(96, 23);
            this.btn_proceed.TabIndex = 1;
            this.btn_proceed.Text = "Proceed";
            this.btn_proceed.UseSelectable = true;
            this.btn_proceed.Click += new System.EventHandler(this.btn_proceed_Click);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(156, 20);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(237, 20);
            this.txt_password.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Password";
            // 
            // tbl_user_detailsTableAdapter1
            // 
            this.tbl_user_detailsTableAdapter1.ClearBeforeFill = true;
            // 
            // lbl_passworderror
            // 
            this.lbl_passworderror.AutoSize = true;
            this.lbl_passworderror.BackColor = System.Drawing.Color.Transparent;
            this.lbl_passworderror.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_passworderror.ForeColor = System.Drawing.Color.Red;
            this.lbl_passworderror.Location = new System.Drawing.Point(94, 52);
            this.lbl_passworderror.Name = "lbl_passworderror";
            this.lbl_passworderror.Size = new System.Drawing.Size(203, 23);
            this.lbl_passworderror.TabIndex = 8;
            this.lbl_passworderror.Text = "INCORRECT PASSWORD!";
            this.lbl_passworderror.Visible = false;
            // 
            // frm_validatestocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AryaStarkHashiqCsd55.Properties.Resources.pic_white_background;
            this.ClientSize = new System.Drawing.Size(418, 122);
            this.Controls.Add(this.lbl_passworderror);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_proceed);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_validatestocks";
            this.Text = "Validate_Stocks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn_cancel;
        private MetroFramework.Controls.MetroButton btn_proceed;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label1;
        private DataSet1TableAdapters.tbl_user_detailsTableAdapter tbl_user_detailsTableAdapter1;
        private System.Windows.Forms.Label lbl_passworderror;
    }
}