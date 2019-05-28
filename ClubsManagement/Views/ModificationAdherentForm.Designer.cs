namespace ClubsManagement.Views
{
    partial class ModificationAdherentForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.MonthCalendarAdherent = new System.Windows.Forms.MonthCalendar();
            this.btnModAdherent = new System.Windows.Forms.Button();
            this.lblAdherentBirthDate = new System.Windows.Forms.Label();
            this.GBModAdherent = new System.Windows.Forms.GroupBox();
            this.btnDelAdherent = new System.Windows.Forms.Button();
            this.cmbAdherentClub = new System.Windows.Forms.ComboBox();
            this.txtAdherentLastName = new System.Windows.Forms.MaskedTextBox();
            this.lblAdherentClub = new System.Windows.Forms.Label();
            this.lblAdherentLastName = new System.Windows.Forms.Label();
            this.lblAdherentAddress = new System.Windows.Forms.Label();
            this.txtAdherentFirstName = new System.Windows.Forms.MaskedTextBox();
            this.txtAdherentAddress = new System.Windows.Forms.MaskedTextBox();
            this.lblAdherentFirstName = new System.Windows.Forms.Label();
            this.lblAdherentCity = new System.Windows.Forms.Label();
            this.txtAdherentBirthDate = new System.Windows.Forms.MaskedTextBox();
            this.txtAdherentCity = new System.Windows.Forms.MaskedTextBox();
            this.txtAdherentZipCode = new System.Windows.Forms.MaskedTextBox();
            this.lblAdherentZipCode = new System.Windows.Forms.Label();
            this.GBModAdherent.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(591, 305);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 28);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // MonthCalendarAdherent
            // 
            this.MonthCalendarAdherent.Location = new System.Drawing.Point(372, 21);
            this.MonthCalendarAdherent.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.MonthCalendarAdherent.Name = "MonthCalendarAdherent";
            this.MonthCalendarAdherent.TabIndex = 15;
            this.MonthCalendarAdherent.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.MonthCalendar_Adherent_DateChanged);
            // 
            // btnModAdherent
            // 
            this.btnModAdherent.Location = new System.Drawing.Point(401, 305);
            this.btnModAdherent.Margin = new System.Windows.Forms.Padding(4);
            this.btnModAdherent.Name = "btnModAdherent";
            this.btnModAdherent.Size = new System.Drawing.Size(87, 28);
            this.btnModAdherent.TabIndex = 16;
            this.btnModAdherent.Text = "Modifier";
            this.btnModAdherent.UseVisualStyleBackColor = true;
            this.btnModAdherent.Click += new System.EventHandler(this.btn_Mod_Adherent_Click);
            // 
            // lblAdherentBirthDate
            // 
            this.lblAdherentBirthDate.AutoSize = true;
            this.lblAdherentBirthDate.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdherentBirthDate.Location = new System.Drawing.Point(8, 122);
            this.lblAdherentBirthDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdherentBirthDate.Name = "lblAdherentBirthDate";
            this.lblAdherentBirthDate.Size = new System.Drawing.Size(167, 22);
            this.lblAdherentBirthDate.TabIndex = 4;
            this.lblAdherentBirthDate.Text = "Date de naissance";
            // 
            // GBModAdherent
            // 
            this.GBModAdherent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBModAdherent.Controls.Add(this.btnDelAdherent);
            this.GBModAdherent.Controls.Add(this.btnCancel);
            this.GBModAdherent.Controls.Add(this.MonthCalendarAdherent);
            this.GBModAdherent.Controls.Add(this.btnModAdherent);
            this.GBModAdherent.Controls.Add(this.lblAdherentBirthDate);
            this.GBModAdherent.Controls.Add(this.cmbAdherentClub);
            this.GBModAdherent.Controls.Add(this.txtAdherentLastName);
            this.GBModAdherent.Controls.Add(this.lblAdherentClub);
            this.GBModAdherent.Controls.Add(this.lblAdherentLastName);
            this.GBModAdherent.Controls.Add(this.lblAdherentAddress);
            this.GBModAdherent.Controls.Add(this.txtAdherentFirstName);
            this.GBModAdherent.Controls.Add(this.txtAdherentAddress);
            this.GBModAdherent.Controls.Add(this.lblAdherentFirstName);
            this.GBModAdherent.Controls.Add(this.lblAdherentCity);
            this.GBModAdherent.Controls.Add(this.txtAdherentBirthDate);
            this.GBModAdherent.Controls.Add(this.txtAdherentCity);
            this.GBModAdherent.Controls.Add(this.txtAdherentZipCode);
            this.GBModAdherent.Controls.Add(this.lblAdherentZipCode);
            this.GBModAdherent.Location = new System.Drawing.Point(13, 13);
            this.GBModAdherent.Margin = new System.Windows.Forms.Padding(4);
            this.GBModAdherent.Name = "GBModAdherent";
            this.GBModAdherent.Padding = new System.Windows.Forms.Padding(4);
            this.GBModAdherent.Size = new System.Drawing.Size(702, 353);
            this.GBModAdherent.TabIndex = 18;
            this.GBModAdherent.TabStop = false;
            this.GBModAdherent.Text = "Modifier un adhérent";
            // 
            // btnDelAdherent
            // 
            this.btnDelAdherent.Location = new System.Drawing.Point(496, 305);
            this.btnDelAdherent.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelAdherent.Name = "btnDelAdherent";
            this.btnDelAdherent.Size = new System.Drawing.Size(87, 28);
            this.btnDelAdherent.TabIndex = 18;
            this.btnDelAdherent.Text = "Supprimer";
            this.btnDelAdherent.UseVisualStyleBackColor = true;
            this.btnDelAdherent.Click += new System.EventHandler(this.btn_Del_Adherent_Click);
            // 
            // cmbAdherentClub
            // 
            this.cmbAdherentClub.FormattingEnabled = true;
            this.cmbAdherentClub.Location = new System.Drawing.Point(199, 308);
            this.cmbAdherentClub.Margin = new System.Windows.Forms.Padding(4);
            this.cmbAdherentClub.Name = "cmbAdherentClub";
            this.cmbAdherentClub.Size = new System.Drawing.Size(107, 24);
            this.cmbAdherentClub.TabIndex = 14;
            // 
            // txtAdherentLastName
            // 
            this.txtAdherentLastName.Location = new System.Drawing.Point(199, 21);
            this.txtAdherentLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdherentLastName.Mask = "LLLLLLLLLLLL";
            this.txtAdherentLastName.Name = "txtAdherentLastName";
            this.txtAdherentLastName.PromptChar = ' ';
            this.txtAdherentLastName.Size = new System.Drawing.Size(107, 22);
            this.txtAdherentLastName.TabIndex = 0;
            // 
            // lblAdherentClub
            // 
            this.lblAdherentClub.AutoSize = true;
            this.lblAdherentClub.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdherentClub.Location = new System.Drawing.Point(8, 308);
            this.lblAdherentClub.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdherentClub.Name = "lblAdherentClub";
            this.lblAdherentClub.Size = new System.Drawing.Size(49, 22);
            this.lblAdherentClub.TabIndex = 12;
            this.lblAdherentClub.Text = "Club";
            // 
            // lblAdherentLastName
            // 
            this.lblAdherentLastName.AutoSize = true;
            this.lblAdherentLastName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdherentLastName.Location = new System.Drawing.Point(8, 25);
            this.lblAdherentLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdherentLastName.Name = "lblAdherentLastName";
            this.lblAdherentLastName.Size = new System.Drawing.Size(50, 22);
            this.lblAdherentLastName.TabIndex = 1;
            this.lblAdherentLastName.Text = "Nom";
            // 
            // lblAdherentAddress
            // 
            this.lblAdherentAddress.AutoSize = true;
            this.lblAdherentAddress.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdherentAddress.Location = new System.Drawing.Point(8, 262);
            this.lblAdherentAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdherentAddress.Name = "lblAdherentAddress";
            this.lblAdherentAddress.Size = new System.Drawing.Size(82, 22);
            this.lblAdherentAddress.TabIndex = 11;
            this.lblAdherentAddress.Text = "Adresse";
            // 
            // txtAdherentFirstName
            // 
            this.txtAdherentFirstName.Location = new System.Drawing.Point(199, 71);
            this.txtAdherentFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdherentFirstName.Mask = "LLLLLLLLLLLL";
            this.txtAdherentFirstName.Name = "txtAdherentFirstName";
            this.txtAdherentFirstName.PromptChar = ' ';
            this.txtAdherentFirstName.Size = new System.Drawing.Size(107, 22);
            this.txtAdherentFirstName.TabIndex = 2;
            // 
            // txtAdherentAddress
            // 
            this.txtAdherentAddress.Location = new System.Drawing.Point(199, 258);
            this.txtAdherentAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdherentAddress.Mask = "AAAAAAAAAAAA";
            this.txtAdherentAddress.Name = "txtAdherentAddress";
            this.txtAdherentAddress.PromptChar = ' ';
            this.txtAdherentAddress.Size = new System.Drawing.Size(157, 22);
            this.txtAdherentAddress.TabIndex = 10;
            // 
            // lblAdherentFirstName
            // 
            this.lblAdherentFirstName.AutoSize = true;
            this.lblAdherentFirstName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdherentFirstName.Location = new System.Drawing.Point(8, 75);
            this.lblAdherentFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdherentFirstName.Name = "lblAdherentFirstName";
            this.lblAdherentFirstName.Size = new System.Drawing.Size(77, 22);
            this.lblAdherentFirstName.TabIndex = 3;
            this.lblAdherentFirstName.Text = "Prénom";
            // 
            // lblAdherentCity
            // 
            this.lblAdherentCity.AutoSize = true;
            this.lblAdherentCity.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdherentCity.Location = new System.Drawing.Point(8, 214);
            this.lblAdherentCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdherentCity.Name = "lblAdherentCity";
            this.lblAdherentCity.Size = new System.Drawing.Size(46, 22);
            this.lblAdherentCity.TabIndex = 9;
            this.lblAdherentCity.Text = "Ville";
            // 
            // txtAdherentBirthDate
            // 
            this.txtAdherentBirthDate.Location = new System.Drawing.Point(199, 118);
            this.txtAdherentBirthDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdherentBirthDate.Mask = "00/00/0000";
            this.txtAdherentBirthDate.Name = "txtAdherentBirthDate";
            this.txtAdherentBirthDate.PromptChar = ' ';
            this.txtAdherentBirthDate.Size = new System.Drawing.Size(107, 22);
            this.txtAdherentBirthDate.TabIndex = 5;
            this.txtAdherentBirthDate.ValidatingType = typeof(System.DateTime);
            // 
            // txtAdherentCity
            // 
            this.txtAdherentCity.Location = new System.Drawing.Point(199, 214);
            this.txtAdherentCity.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdherentCity.Mask = "AAAAAAAAAAAAAAAAA";
            this.txtAdherentCity.Name = "txtAdherentCity";
            this.txtAdherentCity.PromptChar = ' ';
            this.txtAdherentCity.Size = new System.Drawing.Size(157, 22);
            this.txtAdherentCity.TabIndex = 8;
            // 
            // txtAdherentZipCode
            // 
            this.txtAdherentZipCode.Location = new System.Drawing.Point(199, 166);
            this.txtAdherentZipCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdherentZipCode.Mask = "00000";
            this.txtAdherentZipCode.Name = "txtAdherentZipCode";
            this.txtAdherentZipCode.PromptChar = ' ';
            this.txtAdherentZipCode.Size = new System.Drawing.Size(107, 22);
            this.txtAdherentZipCode.TabIndex = 6;
            // 
            // lblAdherentZipCode
            // 
            this.lblAdherentZipCode.AutoSize = true;
            this.lblAdherentZipCode.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdherentZipCode.Location = new System.Drawing.Point(8, 166);
            this.lblAdherentZipCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdherentZipCode.Name = "lblAdherentZipCode";
            this.lblAdherentZipCode.Size = new System.Drawing.Size(113, 22);
            this.lblAdherentZipCode.TabIndex = 7;
            this.lblAdherentZipCode.Text = "Code postal";
            // 
            // ModificationAdherentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 379);
            this.Controls.Add(this.GBModAdherent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(746, 426);
            this.MinimumSize = new System.Drawing.Size(746, 426);
            this.Name = "ModificationAdherentForm";
            this.Text = "Modification adhérent";
            this.Load += new System.EventHandler(this.Modification_Adherent_Form_Load);
            this.GBModAdherent.ResumeLayout(false);
            this.GBModAdherent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.MonthCalendar MonthCalendarAdherent;
        private System.Windows.Forms.Button btnModAdherent;
        private System.Windows.Forms.Label lblAdherentBirthDate;
        private System.Windows.Forms.GroupBox GBModAdherent;
        private System.Windows.Forms.ComboBox cmbAdherentClub;
        private System.Windows.Forms.MaskedTextBox txtAdherentLastName;
        private System.Windows.Forms.Label lblAdherentClub;
        private System.Windows.Forms.Label lblAdherentLastName;
        private System.Windows.Forms.Label lblAdherentAddress;
        private System.Windows.Forms.MaskedTextBox txtAdherentFirstName;
        private System.Windows.Forms.MaskedTextBox txtAdherentAddress;
        private System.Windows.Forms.Label lblAdherentFirstName;
        private System.Windows.Forms.Label lblAdherentCity;
        private System.Windows.Forms.MaskedTextBox txtAdherentBirthDate;
        private System.Windows.Forms.MaskedTextBox txtAdherentCity;
        private System.Windows.Forms.MaskedTextBox txtAdherentZipCode;
        private System.Windows.Forms.Label lblAdherentZipCode;
        private System.Windows.Forms.Button btnDelAdherent;
    }
}