namespace ClubsManagement.Views
{
    partial class ModificationEventForm
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
            this.GBModEvent = new System.Windows.Forms.GroupBox();
            this.btnDelEvent = new System.Windows.Forms.Button();
            this.txtEventClub = new System.Windows.Forms.MaskedTextBox();
            this.lbl_erreur = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnModEvent = new System.Windows.Forms.Button();
            this.txtEventTitle = new System.Windows.Forms.MaskedTextBox();
            this.lblEventTitle = new System.Windows.Forms.Label();
            this.txtEventStart = new System.Windows.Forms.MaskedTextBox();
            this.lblEventStart = new System.Windows.Forms.Label();
            this.lblEventClub = new System.Windows.Forms.Label();
            this.txtEventEnd = new System.Windows.Forms.MaskedTextBox();
            this.lblEventEnd = new System.Windows.Forms.Label();
            this.GBModEvent.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBModEvent
            // 
            this.GBModEvent.Controls.Add(this.btnDelEvent);
            this.GBModEvent.Controls.Add(this.txtEventClub);
            this.GBModEvent.Controls.Add(this.lbl_erreur);
            this.GBModEvent.Controls.Add(this.btnCancel);
            this.GBModEvent.Controls.Add(this.btnModEvent);
            this.GBModEvent.Controls.Add(this.txtEventTitle);
            this.GBModEvent.Controls.Add(this.lblEventTitle);
            this.GBModEvent.Controls.Add(this.txtEventStart);
            this.GBModEvent.Controls.Add(this.lblEventStart);
            this.GBModEvent.Controls.Add(this.lblEventClub);
            this.GBModEvent.Controls.Add(this.txtEventEnd);
            this.GBModEvent.Controls.Add(this.lblEventEnd);
            this.GBModEvent.Location = new System.Drawing.Point(13, 13);
            this.GBModEvent.Margin = new System.Windows.Forms.Padding(4);
            this.GBModEvent.Name = "GBModEvent";
            this.GBModEvent.Padding = new System.Windows.Forms.Padding(4);
            this.GBModEvent.Size = new System.Drawing.Size(670, 303);
            this.GBModEvent.TabIndex = 20;
            this.GBModEvent.TabStop = false;
            this.GBModEvent.Text = "Modifier un événement";
            // 
            // btnDelEvent
            // 
            this.btnDelEvent.Location = new System.Drawing.Point(287, 267);
            this.btnDelEvent.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelEvent.Name = "btnDelEvent";
            this.btnDelEvent.Size = new System.Drawing.Size(100, 28);
            this.btnDelEvent.TabIndex = 25;
            this.btnDelEvent.Text = "Supprimer";
            this.btnDelEvent.UseVisualStyleBackColor = true;
            this.btnDelEvent.Click += new System.EventHandler(this.btn_Del_Event_Click);
            // 
            // txtEventClub
            // 
            this.txtEventClub.Location = new System.Drawing.Point(278, 216);
            this.txtEventClub.Margin = new System.Windows.Forms.Padding(4);
            this.txtEventClub.Name = "txtEventClub";
            this.txtEventClub.PromptChar = ' ';
            this.txtEventClub.ReadOnly = true;
            this.txtEventClub.Size = new System.Drawing.Size(157, 22);
            this.txtEventClub.TabIndex = 24;
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
            this.btnCancel.Location = new System.Drawing.Point(408, 267);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnModEvent
            // 
            this.btnModEvent.Location = new System.Drawing.Point(167, 267);
            this.btnModEvent.Margin = new System.Windows.Forms.Padding(4);
            this.btnModEvent.Name = "btnModEvent";
            this.btnModEvent.Size = new System.Drawing.Size(100, 28);
            this.btnModEvent.TabIndex = 16;
            this.btnModEvent.Text = "Modifier";
            this.btnModEvent.UseVisualStyleBackColor = true;
            this.btnModEvent.Click += new System.EventHandler(this.btn_Mod_Event_Click);
            // 
            // txtEventTitle
            // 
            this.txtEventTitle.Location = new System.Drawing.Point(278, 19);
            this.txtEventTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtEventTitle.Name = "txtEventTitle";
            this.txtEventTitle.PromptChar = ' ';
            this.txtEventTitle.Size = new System.Drawing.Size(157, 22);
            this.txtEventTitle.TabIndex = 0;
            // 
            // lblEventTitle
            // 
            this.lblEventTitle.AutoSize = true;
            this.lblEventTitle.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventTitle.Location = new System.Drawing.Point(208, 19);
            this.lblEventTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEventTitle.Name = "lblEventTitle";
            this.lblEventTitle.Size = new System.Drawing.Size(47, 22);
            this.lblEventTitle.TabIndex = 1;
            this.lblEventTitle.Text = "Titre";
            // 
            // txtEventStart
            // 
            this.txtEventStart.Location = new System.Drawing.Point(278, 85);
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
            this.lblEventStart.Location = new System.Drawing.Point(194, 88);
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
            this.lblEventClub.Location = new System.Drawing.Point(206, 220);
            this.lblEventClub.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEventClub.Name = "lblEventClub";
            this.lblEventClub.Size = new System.Drawing.Size(49, 22);
            this.lblEventClub.TabIndex = 9;
            this.lblEventClub.Text = "Club";
            // 
            // txtEventEnd
            // 
            this.txtEventEnd.Location = new System.Drawing.Point(278, 151);
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
            this.lblEventEnd.Location = new System.Drawing.Point(219, 155);
            this.lblEventEnd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEventEnd.Name = "lblEventEnd";
            this.lblEventEnd.Size = new System.Drawing.Size(36, 22);
            this.lblEventEnd.TabIndex = 7;
            this.lblEventEnd.Text = "Fin";
            // 
            // ModificationEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 329);
            this.Controls.Add(this.GBModEvent);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(714, 376);
            this.MinimumSize = new System.Drawing.Size(714, 376);
            this.Name = "ModificationEventForm";
            this.Text = "Modification événement";
            this.Load += new System.EventHandler(this.Modification_Event_Form_Load);
            this.GBModEvent.ResumeLayout(false);
            this.GBModEvent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBModEvent;
        private System.Windows.Forms.MaskedTextBox txtEventClub;
        private System.Windows.Forms.Label lbl_erreur;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnModEvent;
        private System.Windows.Forms.MaskedTextBox txtEventTitle;
        private System.Windows.Forms.Label lblEventTitle;
        private System.Windows.Forms.MaskedTextBox txtEventStart;
        private System.Windows.Forms.Label lblEventStart;
        private System.Windows.Forms.Label lblEventClub;
        private System.Windows.Forms.MaskedTextBox txtEventEnd;
        private System.Windows.Forms.Label lblEventEnd;
        private System.Windows.Forms.Button btnDelEvent;
    }
}