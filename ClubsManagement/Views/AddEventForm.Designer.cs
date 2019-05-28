namespace ClubsManagement.Views
{
    partial class AddEventForm
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
            this.GBAddEvent = new System.Windows.Forms.GroupBox();
            this.cmbEventClub = new System.Windows.Forms.ComboBox();
            this.lbl_erreur = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.txtEventTitle = new System.Windows.Forms.MaskedTextBox();
            this.lblEventTitle = new System.Windows.Forms.Label();
            this.txtEventStart = new System.Windows.Forms.MaskedTextBox();
            this.lblEventStart = new System.Windows.Forms.Label();
            this.lblEventClub = new System.Windows.Forms.Label();
            this.txtEventEnd = new System.Windows.Forms.MaskedTextBox();
            this.lblEventEnd = new System.Windows.Forms.Label();
            this.GBAddEvent.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBAddEvent
            // 
            this.GBAddEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GBAddEvent.Controls.Add(this.cmbEventClub);
            this.GBAddEvent.Controls.Add(this.lbl_erreur);
            this.GBAddEvent.Controls.Add(this.btnCancel);
            this.GBAddEvent.Controls.Add(this.btnAddEvent);
            this.GBAddEvent.Controls.Add(this.txtEventTitle);
            this.GBAddEvent.Controls.Add(this.lblEventTitle);
            this.GBAddEvent.Controls.Add(this.txtEventStart);
            this.GBAddEvent.Controls.Add(this.lblEventStart);
            this.GBAddEvent.Controls.Add(this.lblEventClub);
            this.GBAddEvent.Controls.Add(this.txtEventEnd);
            this.GBAddEvent.Controls.Add(this.lblEventEnd);
            this.GBAddEvent.Location = new System.Drawing.Point(13, 13);
            this.GBAddEvent.Margin = new System.Windows.Forms.Padding(4);
            this.GBAddEvent.Name = "GBAddEvent";
            this.GBAddEvent.Padding = new System.Windows.Forms.Padding(4);
            this.GBAddEvent.Size = new System.Drawing.Size(702, 353);
            this.GBAddEvent.TabIndex = 19;
            this.GBAddEvent.TabStop = false;
            this.GBAddEvent.Text = "Ajouter un événement";
            // 
            // cmbEventClub
            // 
            this.cmbEventClub.FormattingEnabled = true;
            this.cmbEventClub.Location = new System.Drawing.Point(310, 235);
            this.cmbEventClub.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEventClub.Name = "cmbEventClub";
            this.cmbEventClub.Size = new System.Drawing.Size(160, 24);
            this.cmbEventClub.TabIndex = 24;
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
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(370, 317);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.Location = new System.Drawing.Point(244, 317);
            this.btnAddEvent.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(100, 28);
            this.btnAddEvent.TabIndex = 16;
            this.btnAddEvent.Text = "Ajouter";
            this.btnAddEvent.UseVisualStyleBackColor = true;
            this.btnAddEvent.Click += new System.EventHandler(this.btn_Add_Event_Click);
            // 
            // txtEventTitle
            // 
            this.txtEventTitle.Location = new System.Drawing.Point(310, 34);
            this.txtEventTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtEventTitle.Name = "txtEventTitle";
            this.txtEventTitle.PromptChar = ' ';
            this.txtEventTitle.Size = new System.Drawing.Size(259, 22);
            this.txtEventTitle.TabIndex = 0;
            // 
            // lblEventTitle
            // 
            this.lblEventTitle.AutoSize = true;
            this.lblEventTitle.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventTitle.Location = new System.Drawing.Point(240, 34);
            this.lblEventTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEventTitle.Name = "lblEventTitle";
            this.lblEventTitle.Size = new System.Drawing.Size(47, 22);
            this.lblEventTitle.TabIndex = 1;
            this.lblEventTitle.Text = "Titre";
            // 
            // txtEventStart
            // 
            this.txtEventStart.Location = new System.Drawing.Point(310, 103);
            this.txtEventStart.Margin = new System.Windows.Forms.Padding(4);
            this.txtEventStart.Mask = "00/00/0000";
            this.txtEventStart.Name = "txtEventStart";
            this.txtEventStart.PromptChar = ' ';
            this.txtEventStart.Size = new System.Drawing.Size(157, 22);
            this.txtEventStart.TabIndex = 2;
            this.txtEventStart.ValidatingType = typeof(System.DateTime);
            // 
            // lblEventStart
            // 
            this.lblEventStart.AutoSize = true;
            this.lblEventStart.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventStart.Location = new System.Drawing.Point(240, 103);
            this.lblEventStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEventStart.Name = "lblEventStart";
            this.lblEventStart.Size = new System.Drawing.Size(61, 22);
            this.lblEventStart.TabIndex = 3;
            this.lblEventStart.Text = "Début";
            // 
            // lblEventClub
            // 
            this.lblEventClub.AutoSize = true;
            this.lblEventClub.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventClub.Location = new System.Drawing.Point(240, 235);
            this.lblEventClub.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEventClub.Name = "lblEventClub";
            this.lblEventClub.Size = new System.Drawing.Size(49, 22);
            this.lblEventClub.TabIndex = 9;
            this.lblEventClub.Text = "Club";
            // 
            // txtEventEnd
            // 
            this.txtEventEnd.Location = new System.Drawing.Point(310, 170);
            this.txtEventEnd.Margin = new System.Windows.Forms.Padding(4);
            this.txtEventEnd.Mask = "00/00/0000";
            this.txtEventEnd.Name = "txtEventEnd";
            this.txtEventEnd.PromptChar = ' ';
            this.txtEventEnd.Size = new System.Drawing.Size(157, 22);
            this.txtEventEnd.TabIndex = 6;
            this.txtEventEnd.ValidatingType = typeof(System.DateTime);
            // 
            // lblEventEnd
            // 
            this.lblEventEnd.AutoSize = true;
            this.lblEventEnd.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventEnd.Location = new System.Drawing.Point(240, 170);
            this.lblEventEnd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEventEnd.Name = "lblEventEnd";
            this.lblEventEnd.Size = new System.Drawing.Size(36, 22);
            this.lblEventEnd.TabIndex = 7;
            this.lblEventEnd.Text = "Fin";
            // 
            // AddEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 379);
            this.Controls.Add(this.GBAddEvent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(746, 426);
            this.MinimumSize = new System.Drawing.Size(746, 426);
            this.Name = "AddEventForm";
            this.Text = "Ajout événement";
            this.Load += new System.EventHandler(this.Add_Event_Form_Load);
            this.GBAddEvent.ResumeLayout(false);
            this.GBAddEvent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBAddEvent;
        private System.Windows.Forms.Label lbl_erreur;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.MaskedTextBox txtEventTitle;
        private System.Windows.Forms.Label lblEventTitle;
        private System.Windows.Forms.MaskedTextBox txtEventStart;
        private System.Windows.Forms.Label lblEventStart;
        private System.Windows.Forms.Label lblEventClub;
        private System.Windows.Forms.MaskedTextBox txtEventEnd;
        private System.Windows.Forms.Label lblEventEnd;
        private System.Windows.Forms.ComboBox cmbEventClub;
    }
}