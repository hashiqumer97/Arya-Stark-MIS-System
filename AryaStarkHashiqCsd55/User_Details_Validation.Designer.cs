﻿namespace AryaStarkHashiqCsd55
{
    partial class frm_validateusermenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_proceed = new MetroFramework.Controls.MetroButton();
            this.btn_cancel = new MetroFramework.Controls.MetroButton();
            this.tbl_user_detailsTableAdapter1 = new AryaStarkHashiqCsd55.DataSet1TableAdapters.tbl_user_detailsTableAdapter();
            this.lbl_verifyerror = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(169, 37);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(232, 20);
            this.txt_username.TabIndex = 0;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(169, 79);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(232, 20);
            this.txt_password.TabIndex = 1;
            // 
            // btn_proceed
            // 
            this.btn_proceed.Location = new System.Drawing.Point(173, 156);
            this.btn_proceed.Name = "btn_proceed";
            this.btn_proceed.Size = new System.Drawing.Size(96, 23);
            this.btn_proceed.TabIndex = 2;
            this.btn_proceed.Text = "Proceed";
            this.btn_proceed.UseSelectable = true;
            this.btn_proceed.Click += new System.EventHandler(this.btn_proceed_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(290, 156);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(96, 23);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseSelectable = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // tbl_user_detailsTableAdapter1
            // 
            this.tbl_user_detailsTableAdapter1.ClearBeforeFill = true;
            // 
            // lbl_verifyerror
            // 
            this.lbl_verifyerror.AutoSize = true;
            this.lbl_verifyerror.BackColor = System.Drawing.Color.Transparent;
            this.lbl_verifyerror.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_verifyerror.ForeColor = System.Drawing.Color.Red;
            this.lbl_verifyerror.Location = new System.Drawing.Point(51, 117);
            this.lbl_verifyerror.Name = "lbl_verifyerror";
            this.lbl_verifyerror.Size = new System.Drawing.Size(303, 23);
            this.lbl_verifyerror.TabIndex = 7;
            this.lbl_verifyerror.Text = "INCORRECT USERNAME/PASSWORD!";
            this.lbl_verifyerror.Visible = false;
            // 
            // frm_validateusermenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AryaStarkHashiqCsd55.Properties.Resources.pic_white_background;
            this.ClientSize = new System.Drawing.Size(450, 200);
            this.Controls.Add(this.lbl_verifyerror);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_proceed);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_validateusermenu";
            this.Text = "User_Details_Validation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private MetroFramework.Controls.MetroButton btn_proceed;
        private MetroFramework.Controls.MetroButton btn_cancel;
        private DataSet1TableAdapters.tbl_user_detailsTableAdapter tbl_user_detailsTableAdapter1;
        private System.Windows.Forms.Label lbl_verifyerror;
    }
}