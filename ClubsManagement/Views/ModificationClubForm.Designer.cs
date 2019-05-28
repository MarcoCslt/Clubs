namespace ClubsManagement.Views
{
    partial class ModificationClubForm
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
            this.GBModClub = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbl_erreur = new System.Windows.Forms.Label();
            this.txtClubTel = new System.Windows.Forms.MaskedTextBox();
            this.lblClubTel = new System.Windows.Forms.Label();
            this.txtClubMail = new System.Windows.Forms.MaskedTextBox();
            this.btnModClub = new System.Windows.Forms.Button();
            this.txtClubName = new System.Windows.Forms.MaskedTextBox();
            this.lblClubMail = new System.Windows.Forms.Label();
            this.lblClubName = new System.Windows.Forms.Label();
            this.lblClubAddress = new System.Windows.Forms.Label();
            this.txtClubUrl = new System.Windows.Forms.MaskedTextBox();
            this.txtClubAddress = new System.Windows.Forms.MaskedTextBox();
            this.lblClubUrl = new System.Windows.Forms.Label();
            this.lblClubCity = new System.Windows.Forms.Label();
            this.txtCLubCity = new System.Windows.Forms.MaskedTextBox();
            this.txtClubZipCode = new System.Windows.Forms.MaskedTextBox();
            this.lblClubZipCode = new System.Windows.Forms.Label();
            this.GBModClub.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBModClub
            // 
            this.GBModClub.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBModClub.Controls.Add(this.btnCancel);
            this.GBModClub.Controls.Add(this.lbl_erreur);
            this.GBModClub.Controls.Add(this.txtClubTel);
            this.GBModClub.Controls.Add(this.lblClubTel);
            this.GBModClub.Controls.Add(this.txtClubMail);
            this.GBModClub.Controls.Add(this.btnModClub);
            this.GBModClub.Controls.Add(this.txtClubName);
            this.GBModClub.Controls.Add(this.lblClubMail);
            this.GBModClub.Controls.Add(this.lblClubName);
            this.GBModClub.Controls.Add(this.lblClubAddress);
            this.GBModClub.Controls.Add(this.txtClubUrl);
            this.GBModClub.Controls.Add(this.txtClubAddress);
            this.GBModClub.Controls.Add(this.lblClubUrl);
            this.GBModClub.Controls.Add(this.lblClubCity);
            this.GBModClub.Controls.Add(this.txtCLubCity);
            this.GBModClub.Controls.Add(this.txtClubZipCode);
            this.GBModClub.Controls.Add(this.lblClubZipCode);
            this.GBModClub.Location = new System.Drawing.Point(13, 13);
            this.GBModClub.Margin = new System.Windows.Forms.Padding(4);
            this.GBModClub.Name = "GBModClub";
            this.GBModClub.Padding = new System.Windows.Forms.Padding(4);
            this.GBModClub.Size = new System.Drawing.Size(702, 353);
            this.GBModClub.TabIndex = 19;
            this.GBModClub.TabStop = false;
            this.GBModClub.Text = "Modifier un club";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(579, 297);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbl_erreur
            // 
            this.lbl_erreur.AutoSize = true;
            this.lbl_erreur.ForeColor = System.Drawing.Color.Red;
            this.lbl_erreur.Location = new System.Drawing.Point(485, 191);
            this.lbl_erreur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_erreur.Name = "lbl_erreur";
            this.lbl_erreur.Size = new System.Drawing.Size(0, 17);
            this.lbl_erreur.TabIndex = 23;
            // 
            // txtClubTel
            // 
            this.txtClubTel.Location = new System.Drawing.Point(199, 303);
            this.txtClubTel.Margin = new System.Windows.Forms.Padding(4);
            this.txtClubTel.Mask = "0000000000";
            this.txtClubTel.Name = "txtClubTel";
            this.txtClubTel.PromptChar = ' ';
            this.txtClubTel.Size = new System.Drawing.Size(157, 22);
            this.txtClubTel.TabIndex = 20;
            // 
            // lblClubTel
            // 
            this.lblClubTel.AutoSize = true;
            this.lblClubTel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClubTel.Location = new System.Drawing.Point(8, 303);
            this.lblClubTel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClubTel.Name = "lblClubTel";
            this.lblClubTel.Size = new System.Drawing.Size(101, 22);
            this.lblClubTel.TabIndex = 19;
            this.lblClubTel.Text = "Téléphone";
            // 
            // txtClubMail
            // 
            this.txtClubMail.Location = new System.Drawing.Point(199, 257);
            this.txtClubMail.Margin = new System.Windows.Forms.Padding(4);
            this.txtClubMail.Name = "txtClubMail";
            this.txtClubMail.PromptChar = ' ';
            this.txtClubMail.Size = new System.Drawing.Size(157, 22);
            this.txtClubMail.TabIndex = 18;
            // 
            // btnModClub
            // 
            this.btnModClub.Location = new System.Drawing.Point(471, 297);
            this.btnModClub.Margin = new System.Windows.Forms.Padding(4);
            this.btnModClub.Name = "btnModClub";
            this.btnModClub.Size = new System.Drawing.Size(100, 28);
            this.btnModClub.TabIndex = 16;
            this.btnModClub.Text = "Modifier";
            this.btnModClub.UseVisualStyleBackColor = true;
            this.btnModClub.Click += new System.EventHandler(this.btn_Mod_Club_Click);
            // 
            // txtClubName
            // 
            this.txtClubName.Location = new System.Drawing.Point(199, 21);
            this.txtClubName.Margin = new System.Windows.Forms.Padding(4);
            this.txtClubName.Name = "txtClubName";
            this.txtClubName.PromptChar = ' ';
            this.txtClubName.Size = new System.Drawing.Size(157, 22);
            this.txtClubName.TabIndex = 0;
            // 
            // lblClubMail
            // 
            this.lblClubMail.AutoSize = true;
            this.lblClubMail.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClubMail.Location = new System.Drawing.Point(8, 261);
            this.lblClubMail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClubMail.Name = "lblClubMail";
            this.lblClubMail.Size = new System.Drawing.Size(43, 22);
            this.lblClubMail.TabIndex = 12;
            this.lblClubMail.Text = "Mail";
            // 
            // lblClubName
            // 
            this.lblClubName.AutoSize = true;
            this.lblClubName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClubName.Location = new System.Drawing.Point(8, 25);
            this.lblClubName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClubName.Name = "lblClubName";
            this.lblClubName.Size = new System.Drawing.Size(50, 22);
            this.lblClubName.TabIndex = 1;
            this.lblClubName.Text = "Nom";
            // 
            // lblClubAddress
            // 
            this.lblClubAddress.AutoSize = true;
            this.lblClubAddress.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClubAddress.Location = new System.Drawing.Point(8, 215);
            this.lblClubAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClubAddress.Name = "lblClubAddress";
            this.lblClubAddress.Size = new System.Drawing.Size(82, 22);
            this.lblClubAddress.TabIndex = 11;
            this.lblClubAddress.Text = "Adresse";
            // 
            // txtClubUrl
            // 
            this.txtClubUrl.Location = new System.Drawing.Point(199, 71);
            this.txtClubUrl.Margin = new System.Windows.Forms.Padding(4);
            this.txtClubUrl.Name = "txtClubUrl";
            this.txtClubUrl.PromptChar = ' ';
            this.txtClubUrl.Size = new System.Drawing.Size(157, 22);
            this.txtClubUrl.TabIndex = 2;
            // 
            // txtClubAddress
            // 
            this.txtClubAddress.Location = new System.Drawing.Point(199, 212);
            this.txtClubAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtClubAddress.Name = "txtClubAddress";
            this.txtClubAddress.PromptChar = ' ';
            this.txtClubAddress.Size = new System.Drawing.Size(157, 22);
            this.txtClubAddress.TabIndex = 10;
            // 
            // lblClubUrl
            // 
            this.lblClubUrl.AutoSize = true;
            this.lblClubUrl.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClubUrl.Location = new System.Drawing.Point(8, 75);
            this.lblClubUrl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClubUrl.Name = "lblClubUrl";
            this.lblClubUrl.Size = new System.Drawing.Size(33, 22);
            this.lblClubUrl.TabIndex = 3;
            this.lblClubUrl.Text = "Url";
            // 
            // lblClubCity
            // 
            this.lblClubCity.AutoSize = true;
            this.lblClubCity.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClubCity.Location = new System.Drawing.Point(8, 169);
            this.lblClubCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClubCity.Name = "lblClubCity";
            this.lblClubCity.Size = new System.Drawing.Size(46, 22);
            this.lblClubCity.TabIndex = 9;
            this.lblClubCity.Text = "Ville";
            // 
            // txtCLubCity
            // 
            this.txtCLubCity.Location = new System.Drawing.Point(199, 169);
            this.txtCLubCity.Margin = new System.Windows.Forms.Padding(4);
            this.txtCLubCity.Name = "txtCLubCity";
            this.txtCLubCity.PromptChar = ' ';
            this.txtCLubCity.Size = new System.Drawing.Size(157, 22);
            this.txtCLubCity.TabIndex = 8;
            // 
            // txtClubZipCode
            // 
            this.txtClubZipCode.Location = new System.Drawing.Point(199, 123);
            this.txtClubZipCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtClubZipCode.Mask = "00000";
            this.txtClubZipCode.Name = "txtClubZipCode";
            this.txtClubZipCode.PromptChar = ' ';
            this.txtClubZipCode.Size = new System.Drawing.Size(157, 22);
            this.txtClubZipCode.TabIndex = 6;
            // 
            // lblClubZipCode
            // 
            this.lblClubZipCode.AutoSize = true;
            this.lblClubZipCode.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClubZipCode.Location = new System.Drawing.Point(8, 123);
            this.lblClubZipCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClubZipCode.Name = "lblClubZipCode";
            this.lblClubZipCode.Size = new System.Drawing.Size(113, 22);
            this.lblClubZipCode.TabIndex = 7;
            this.lblClubZipCode.Text = "Code postal";
            // 
            // ModificationClubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 379);
            this.Controls.Add(this.GBModClub);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(746, 426);
            this.MinimumSize = new System.Drawing.Size(746, 426);
            this.Name = "ModificationClubForm";
            this.Text = "Modification club";
            this.Load += new System.EventHandler(this.Modification_Club_Form_Load);
            this.GBModClub.ResumeLayout(false);
            this.GBModClub.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBModClub;
        private System.Windows.Forms.Label lbl_erreur;
        private System.Windows.Forms.MaskedTextBox txtClubTel;
        private System.Windows.Forms.Label lblClubTel;
        private System.Windows.Forms.MaskedTextBox txtClubMail;
        private System.Windows.Forms.Button btnModClub;
        private System.Windows.Forms.MaskedTextBox txtClubName;
        private System.Windows.Forms.Label lblClubMail;
        private System.Windows.Forms.Label lblClubName;
        private System.Windows.Forms.Label lblClubAddress;
        private System.Windows.Forms.MaskedTextBox txtClubUrl;
        private System.Windows.Forms.MaskedTextBox txtClubAddress;
        private System.Windows.Forms.Label lblClubUrl;
        private System.Windows.Forms.Label lblClubCity;
        private System.Windows.Forms.MaskedTextBox txtCLubCity;
        private System.Windows.Forms.MaskedTextBox txtClubZipCode;
        private System.Windows.Forms.Label lblClubZipCode;
        private System.Windows.Forms.Button btnCancel;
    }
}