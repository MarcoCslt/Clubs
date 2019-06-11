namespace ClubsManagement.Views
{
    partial class AddClubForm
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
            this.GBAddClub = new System.Windows.Forms.GroupBox();
            this.lblClubLeague = new System.Windows.Forms.Label();
            this.cmbClubLeague = new System.Windows.Forms.ComboBox();
            this.txtClubTel = new System.Windows.Forms.MaskedTextBox();
            this.lblClubTel = new System.Windows.Forms.Label();
            this.txtClubMail = new System.Windows.Forms.MaskedTextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddClub = new System.Windows.Forms.Button();
            this.txtClubName = new System.Windows.Forms.MaskedTextBox();
            this.lblClubMail = new System.Windows.Forms.Label();
            this.lblClubName = new System.Windows.Forms.Label();
            this.lblClubAddress = new System.Windows.Forms.Label();
            this.txtClubAddress = new System.Windows.Forms.MaskedTextBox();
            this.lblClubCity = new System.Windows.Forms.Label();
            this.txtClubCity = new System.Windows.Forms.MaskedTextBox();
            this.txtClubZipCode = new System.Windows.Forms.MaskedTextBox();
            this.lblClubZipCode = new System.Windows.Forms.Label();
            this.GBAddClub.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBAddClub
            // 
            this.GBAddClub.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBAddClub.Controls.Add(this.lblClubLeague);
            this.GBAddClub.Controls.Add(this.cmbClubLeague);
            this.GBAddClub.Controls.Add(this.txtClubTel);
            this.GBAddClub.Controls.Add(this.lblClubTel);
            this.GBAddClub.Controls.Add(this.txtClubMail);
            this.GBAddClub.Controls.Add(this.btnCancel);
            this.GBAddClub.Controls.Add(this.btnAddClub);
            this.GBAddClub.Controls.Add(this.txtClubName);
            this.GBAddClub.Controls.Add(this.lblClubMail);
            this.GBAddClub.Controls.Add(this.lblClubName);
            this.GBAddClub.Controls.Add(this.lblClubAddress);
            this.GBAddClub.Controls.Add(this.txtClubAddress);
            this.GBAddClub.Controls.Add(this.lblClubCity);
            this.GBAddClub.Controls.Add(this.txtClubCity);
            this.GBAddClub.Controls.Add(this.txtClubZipCode);
            this.GBAddClub.Controls.Add(this.lblClubZipCode);
            this.GBAddClub.Location = new System.Drawing.Point(13, 13);
            this.GBAddClub.Margin = new System.Windows.Forms.Padding(4);
            this.GBAddClub.Name = "GBAddClub";
            this.GBAddClub.Padding = new System.Windows.Forms.Padding(4);
            this.GBAddClub.Size = new System.Drawing.Size(702, 353);
            this.GBAddClub.TabIndex = 18;
            this.GBAddClub.TabStop = false;
            this.GBAddClub.Text = "Ajouter un club";
            // 
            // lblClubLeague
            // 
            this.lblClubLeague.AutoSize = true;
            this.lblClubLeague.Location = new System.Drawing.Point(515, 69);
            this.lblClubLeague.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClubLeague.Name = "lblClubLeague";
            this.lblClubLeague.Size = new System.Drawing.Size(93, 17);
            this.lblClubLeague.TabIndex = 22;
            this.lblClubLeague.Text = "Ligue du club";
            // 
            // cmbClubLeague
            // 
            this.cmbClubLeague.FormattingEnabled = true;
            this.cmbClubLeague.Location = new System.Drawing.Point(487, 107);
            this.cmbClubLeague.Margin = new System.Windows.Forms.Padding(4);
            this.cmbClubLeague.Name = "cmbClubLeague";
            this.cmbClubLeague.Size = new System.Drawing.Size(160, 24);
            this.cmbClubLeague.TabIndex = 21;
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
            this.txtClubMail.Location = new System.Drawing.Point(199, 255);
            this.txtClubMail.Margin = new System.Windows.Forms.Padding(4);
            this.txtClubMail.Name = "txtClubMail";
            this.txtClubMail.PromptChar = ' ';
            this.txtClubMail.Size = new System.Drawing.Size(157, 22);
            this.txtClubMail.TabIndex = 18;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(594, 317);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddClub
            // 
            this.btnAddClub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddClub.Location = new System.Drawing.Point(486, 317);
            this.btnAddClub.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddClub.Name = "btnAddClub";
            this.btnAddClub.Size = new System.Drawing.Size(100, 28);
            this.btnAddClub.TabIndex = 16;
            this.btnAddClub.Text = "Ajouter";
            this.btnAddClub.UseVisualStyleBackColor = true;
            this.btnAddClub.Click += new System.EventHandler(this.btn_Add_Club_Click);
            // 
            // txtClubName
            // 
            this.txtClubName.Location = new System.Drawing.Point(199, 64);
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
            this.lblClubMail.Location = new System.Drawing.Point(8, 255);
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
            this.lblClubName.Location = new System.Drawing.Point(8, 64);
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
            this.lblClubAddress.Location = new System.Drawing.Point(8, 207);
            this.lblClubAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClubAddress.Name = "lblClubAddress";
            this.lblClubAddress.Size = new System.Drawing.Size(82, 22);
            this.lblClubAddress.TabIndex = 11;
            this.lblClubAddress.Text = "Adresse";
            // 
            // txtClubAddress
            // 
            this.txtClubAddress.Location = new System.Drawing.Point(199, 207);
            this.txtClubAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtClubAddress.Name = "txtClubAddress";
            this.txtClubAddress.PromptChar = ' ';
            this.txtClubAddress.Size = new System.Drawing.Size(157, 22);
            this.txtClubAddress.TabIndex = 10;
            // 
            // lblClubCity
            // 
            this.lblClubCity.AutoSize = true;
            this.lblClubCity.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClubCity.Location = new System.Drawing.Point(8, 156);
            this.lblClubCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClubCity.Name = "lblClubCity";
            this.lblClubCity.Size = new System.Drawing.Size(46, 22);
            this.lblClubCity.TabIndex = 9;
            this.lblClubCity.Text = "Ville";
            // 
            // txtClubCity
            // 
            this.txtClubCity.Location = new System.Drawing.Point(199, 156);
            this.txtClubCity.Margin = new System.Windows.Forms.Padding(4);
            this.txtClubCity.Name = "txtClubCity";
            this.txtClubCity.PromptChar = ' ';
            this.txtClubCity.Size = new System.Drawing.Size(157, 22);
            this.txtClubCity.TabIndex = 8;
            // 
            // txtClubZipCode
            // 
            this.txtClubZipCode.Location = new System.Drawing.Point(199, 105);
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
            this.lblClubZipCode.Location = new System.Drawing.Point(8, 105);
            this.lblClubZipCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClubZipCode.Name = "lblClubZipCode";
            this.lblClubZipCode.Size = new System.Drawing.Size(113, 22);
            this.lblClubZipCode.TabIndex = 7;
            this.lblClubZipCode.Text = "Code postal";
            // 
            // AddClubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 379);
            this.Controls.Add(this.GBAddClub);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(746, 426);
            this.MinimumSize = new System.Drawing.Size(746, 426);
            this.Name = "AddClubForm";
            this.Text = "Ajout club";
            this.Load += new System.EventHandler(this.Add_Club_Form_Load);
            this.GBAddClub.ResumeLayout(false);
            this.GBAddClub.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBAddClub;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddClub;
        private System.Windows.Forms.MaskedTextBox txtClubName;
        private System.Windows.Forms.Label lblClubMail;
        private System.Windows.Forms.Label lblClubName;
        private System.Windows.Forms.Label lblClubAddress;
        private System.Windows.Forms.MaskedTextBox txtClubAddress;
        private System.Windows.Forms.Label lblClubCity;
        private System.Windows.Forms.MaskedTextBox txtClubCity;
        private System.Windows.Forms.MaskedTextBox txtClubZipCode;
        private System.Windows.Forms.Label lblClubZipCode;
        private System.Windows.Forms.MaskedTextBox txtClubTel;
        private System.Windows.Forms.Label lblClubTel;
        private System.Windows.Forms.MaskedTextBox txtClubMail;
        private System.Windows.Forms.Label lblClubLeague;
        private System.Windows.Forms.ComboBox cmbClubLeague;
    }
}