namespace ClubsManagement.Views
{
    partial class AddAdherentForm
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
            this.txtAdherentLastName = new System.Windows.Forms.MaskedTextBox();
            this.lblAdherentLastName = new System.Windows.Forms.Label();
            this.txtAdherentFirstName = new System.Windows.Forms.MaskedTextBox();
            this.lblAdherentFirstName = new System.Windows.Forms.Label();
            this.lblAdherentBirthDate = new System.Windows.Forms.Label();
            this.txtAdherentBirthDate = new System.Windows.Forms.MaskedTextBox();
            this.txtAdherentZipCode = new System.Windows.Forms.MaskedTextBox();
            this.lblAdherentZipCode = new System.Windows.Forms.Label();
            this.txtAdherentCity = new System.Windows.Forms.MaskedTextBox();
            this.lblAdherentCity = new System.Windows.Forms.Label();
            this.txtAdherentAddress = new System.Windows.Forms.MaskedTextBox();
            this.lblAdherentAddress = new System.Windows.Forms.Label();
            this.lblAdherentClub = new System.Windows.Forms.Label();
            this.MonthCalendarAdherent = new System.Windows.Forms.MonthCalendar();
            this.btnAddAdherent = new System.Windows.Forms.Button();
            this.GBAddAdherent = new System.Windows.Forms.GroupBox();
            this.cmbAdherentClub = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.GBAddAdherent.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAdherentLastName
            // 
            this.txtAdherentLastName.Location = new System.Drawing.Point(199, 27);
            this.txtAdherentLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdherentLastName.Mask = "LLLLLLLLLLLL";
            this.txtAdherentLastName.Name = "txtAdherentLastName";
            this.txtAdherentLastName.PromptChar = ' ';
            this.txtAdherentLastName.Size = new System.Drawing.Size(107, 22);
            this.txtAdherentLastName.TabIndex = 0;
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
            // lblAdherentFirstName
            // 
            this.lblAdherentFirstName.AutoSize = true;
            this.lblAdherentFirstName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdherentFirstName.Location = new System.Drawing.Point(8, 69);
            this.lblAdherentFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdherentFirstName.Name = "lblAdherentFirstName";
            this.lblAdherentFirstName.Size = new System.Drawing.Size(77, 22);
            this.lblAdherentFirstName.TabIndex = 3;
            this.lblAdherentFirstName.Text = "Prénom";
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
            // MonthCalendarAdherent
            // 
            this.MonthCalendarAdherent.Location = new System.Drawing.Point(383, 33);
            this.MonthCalendarAdherent.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.MonthCalendarAdherent.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.MonthCalendarAdherent.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.MonthCalendarAdherent.Name = "MonthCalendarAdherent";
            this.MonthCalendarAdherent.TabIndex = 15;
            this.MonthCalendarAdherent.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.MonthCalendar_Adherent_DateChanged);
            // 
            // btnAddAdherent
            // 
            this.btnAddAdherent.Location = new System.Drawing.Point(517, 300);
            this.btnAddAdherent.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddAdherent.Name = "btnAddAdherent";
            this.btnAddAdherent.Size = new System.Drawing.Size(100, 28);
            this.btnAddAdherent.TabIndex = 16;
            this.btnAddAdherent.Text = "Ajouter";
            this.btnAddAdherent.UseVisualStyleBackColor = true;
            this.btnAddAdherent.Click += new System.EventHandler(this.btn_Add_Adherent_Click);
            // 
            // GBAddAdherent
            // 
            this.GBAddAdherent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBAddAdherent.Controls.Add(this.cmbAdherentClub);
            this.GBAddAdherent.Controls.Add(this.btnCancel);
            this.GBAddAdherent.Controls.Add(this.MonthCalendarAdherent);
            this.GBAddAdherent.Controls.Add(this.btnAddAdherent);
            this.GBAddAdherent.Controls.Add(this.lblAdherentBirthDate);
            this.GBAddAdherent.Controls.Add(this.txtAdherentLastName);
            this.GBAddAdherent.Controls.Add(this.lblAdherentClub);
            this.GBAddAdherent.Controls.Add(this.lblAdherentLastName);
            this.GBAddAdherent.Controls.Add(this.lblAdherentAddress);
            this.GBAddAdherent.Controls.Add(this.txtAdherentFirstName);
            this.GBAddAdherent.Controls.Add(this.txtAdherentAddress);
            this.GBAddAdherent.Controls.Add(this.lblAdherentFirstName);
            this.GBAddAdherent.Controls.Add(this.lblAdherentCity);
            this.GBAddAdherent.Controls.Add(this.txtAdherentBirthDate);
            this.GBAddAdherent.Controls.Add(this.txtAdherentCity);
            this.GBAddAdherent.Controls.Add(this.txtAdherentZipCode);
            this.GBAddAdherent.Controls.Add(this.lblAdherentZipCode);
            this.GBAddAdherent.Location = new System.Drawing.Point(13, 13);
            this.GBAddAdherent.Margin = new System.Windows.Forms.Padding(4);
            this.GBAddAdherent.Name = "GBAddAdherent";
            this.GBAddAdherent.Padding = new System.Windows.Forms.Padding(4);
            this.GBAddAdherent.Size = new System.Drawing.Size(702, 377);
            this.GBAddAdherent.TabIndex = 17;
            this.GBAddAdherent.TabStop = false;
            this.GBAddAdherent.Text = "Ajouter un adhérent";
            // 
            // cmbAdherentClub
            // 
            this.cmbAdherentClub.FormattingEnabled = true;
            this.cmbAdherentClub.Location = new System.Drawing.Point(199, 310);
            this.cmbAdherentClub.Margin = new System.Windows.Forms.Padding(4);
            this.cmbAdherentClub.Name = "cmbAdherentClub";
            this.cmbAdherentClub.Size = new System.Drawing.Size(107, 24);
            this.cmbAdherentClub.TabIndex = 19;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(517, 337);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddAdherentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 403);
            this.Controls.Add(this.GBAddAdherent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(746, 450);
            this.MinimumSize = new System.Drawing.Size(746, 450);
            this.Name = "AddAdherentForm";
            this.Text = "Ajout adhérent";
            this.Load += new System.EventHandler(this.AddAdherentForm_Load);
            this.GBAddAdherent.ResumeLayout(false);
            this.GBAddAdherent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtAdherentLastName;
        private System.Windows.Forms.Label lblAdherentLastName;
        private System.Windows.Forms.MaskedTextBox txtAdherentFirstName;
        private System.Windows.Forms.Label lblAdherentFirstName;
        private System.Windows.Forms.Label lblAdherentBirthDate;
        private System.Windows.Forms.MaskedTextBox txtAdherentBirthDate;
        private System.Windows.Forms.MaskedTextBox txtAdherentZipCode;
        private System.Windows.Forms.Label lblAdherentZipCode;
        private System.Windows.Forms.MaskedTextBox txtAdherentCity;
        private System.Windows.Forms.Label lblAdherentCity;
        private System.Windows.Forms.MaskedTextBox txtAdherentAddress;
        private System.Windows.Forms.Label lblAdherentAddress;
        private System.Windows.Forms.Label lblAdherentClub;
        private System.Windows.Forms.MonthCalendar MonthCalendarAdherent;
        private System.Windows.Forms.Button btnAddAdherent;
        private System.Windows.Forms.GroupBox GBAddAdherent;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbAdherentClub;
    }
}