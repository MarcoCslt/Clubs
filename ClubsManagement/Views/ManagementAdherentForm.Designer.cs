namespace ClubsManagement.Views
{
    partial class ManagementAdherentForm
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
            this.DGAdherents = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddAdherent = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnModAdherent = new System.Windows.Forms.Button();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code_Postal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ville = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cotisation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Club = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGAdherents)).BeginInit();
            this.SuspendLayout();
            // 
            // DGAdherents
            // 
            this.DGAdherents.AllowUserToAddRows = false;
            this.DGAdherents.AllowUserToDeleteRows = false;
            this.DGAdherents.AllowUserToOrderColumns = true;
            this.DGAdherents.AllowUserToResizeRows = false;
            this.DGAdherents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGAdherents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGAdherents.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGAdherents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGAdherents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero,
            this.Nom,
            this.Prenom,
            this.Code_Postal,
            this.Ville,
            this.Adresse,
            this.Cotisation,
            this.Club});
            this.DGAdherents.Location = new System.Drawing.Point(13, 27);
            this.DGAdherents.Margin = new System.Windows.Forms.Padding(4);
            this.DGAdherents.MultiSelect = false;
            this.DGAdherents.Name = "DGAdherents";
            this.DGAdherents.ReadOnly = true;
            this.DGAdherents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGAdherents.Size = new System.Drawing.Size(856, 300);
            this.DGAdherents.TabIndex = 0;
            this.DGAdherents.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGAdherents_RowHeaderMouseDoubleClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(361, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liste des Adhérents";
            // 
            // btnAddAdherent
            // 
            this.btnAddAdherent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddAdherent.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddAdherent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAdherent.Location = new System.Drawing.Point(13, 335);
            this.btnAddAdherent.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddAdherent.Name = "btnAddAdherent";
            this.btnAddAdherent.Size = new System.Drawing.Size(100, 55);
            this.btnAddAdherent.TabIndex = 2;
            this.btnAddAdherent.Text = "Ajouter";
            this.btnAddAdherent.UseVisualStyleBackColor = false;
            this.btnAddAdherent.Click += new System.EventHandler(this.btn_Add_Adherent_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(769, 363);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 28);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "fermer";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(661, 362);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 28);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Rafraichir";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btnModAdherent
            // 
            this.btnModAdherent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModAdherent.BackColor = System.Drawing.Color.LightBlue;
            this.btnModAdherent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnModAdherent.Location = new System.Drawing.Point(120, 336);
            this.btnModAdherent.Name = "btnModAdherent";
            this.btnModAdherent.Size = new System.Drawing.Size(110, 55);
            this.btnModAdherent.TabIndex = 5;
            this.btnModAdherent.Text = "Modifier";
            this.btnModAdherent.UseVisualStyleBackColor = false;
            this.btnModAdherent.Click += new System.EventHandler(this.btn_Mod_Adherent_Click);
            // 
            // numero
            // 
            this.numero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.numero.HeaderText = "N° Licence";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            this.numero.Width = 106;
            // 
            // Nom
            // 
            this.Nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            this.Nom.Width = 66;
            // 
            // Prenom
            // 
            this.Prenom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Prenom.HeaderText = "prenom";
            this.Prenom.Name = "Prenom";
            this.Prenom.ReadOnly = true;
            this.Prenom.Width = 85;
            // 
            // Code_Postal
            // 
            this.Code_Postal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Code_Postal.HeaderText = "Code Postal";
            this.Code_Postal.Name = "Code_Postal";
            this.Code_Postal.ReadOnly = true;
            this.Code_Postal.Width = 113;
            // 
            // Ville
            // 
            this.Ville.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Ville.HeaderText = "Ville";
            this.Ville.Name = "Ville";
            this.Ville.ReadOnly = true;
            this.Ville.Width = 63;
            // 
            // Adresse
            // 
            this.Adresse.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Adresse.HeaderText = "Adresse";
            this.Adresse.Name = "Adresse";
            this.Adresse.ReadOnly = true;
            this.Adresse.Width = 89;
            // 
            // Cotisation
            // 
            this.Cotisation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Cotisation.HeaderText = "Cotisation";
            this.Cotisation.Name = "Cotisation";
            this.Cotisation.ReadOnly = true;
            this.Cotisation.Width = 99;
            // 
            // Club
            // 
            this.Club.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Club.HeaderText = "Club";
            this.Club.Name = "Club";
            this.Club.ReadOnly = true;
            this.Club.Width = 65;
            // 
            // ManagementAdherentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 403);
            this.Controls.Add(this.btnModAdherent);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddAdherent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGAdherents);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(900, 450);
            this.Name = "ManagementAdherentForm";
            this.Text = "Gestion des adhérents";
            this.Load += new System.EventHandler(this.Management_Adherent_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGAdherents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGAdherents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddAdherent;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnModAdherent;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code_Postal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ville;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cotisation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Club;
    }
}