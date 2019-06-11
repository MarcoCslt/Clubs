namespace ClubsManagement.Views
{
    partial class ManagementClubForm
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
            this.DGClubs = new System.Windows.Forms.DataGridView();
            this.btnAddClub = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnModClub = new System.Windows.Forms.Button();
            this.id_club = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titre_club = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Code_Postal_club = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ville_Club = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresse_Club = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail_Club = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telephone_Club = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nbr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbrE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGClubs)).BeginInit();
            this.SuspendLayout();
            // 
            // DGClubs
            // 
            this.DGClubs.AllowUserToAddRows = false;
            this.DGClubs.AllowUserToDeleteRows = false;
            this.DGClubs.AllowUserToOrderColumns = true;
            this.DGClubs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGClubs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGClubs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGClubs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGClubs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_club,
            this.Titre_club,
            this.Code_Postal_club,
            this.Ville_Club,
            this.Adresse_Club,
            this.Mail_Club,
            this.Telephone_Club,
            this.libelle,
            this.Nbr,
            this.nbrE});
            this.DGClubs.Location = new System.Drawing.Point(13, 13);
            this.DGClubs.Margin = new System.Windows.Forms.Padding(4);
            this.DGClubs.Name = "DGClubs";
            this.DGClubs.ReadOnly = true;
            this.DGClubs.Size = new System.Drawing.Size(1146, 290);
            this.DGClubs.TabIndex = 1;
            this.DGClubs.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DG_Club_RowHeaderMouseDoubleClick);
            // 
            // btnAddClub
            // 
            this.btnAddClub.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddClub.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddClub.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClub.Location = new System.Drawing.Point(13, 311);
            this.btnAddClub.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddClub.Name = "btnAddClub";
            this.btnAddClub.Size = new System.Drawing.Size(110, 55);
            this.btnAddClub.TabIndex = 3;
            this.btnAddClub.Text = "Ajouter";
            this.btnAddClub.UseVisualStyleBackColor = false;
            this.btnAddClub.Click += new System.EventHandler(this.btn_Add_Club_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRefresh.Location = new System.Drawing.Point(952, 327);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 28);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Rafraichir";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClose.Location = new System.Drawing.Point(1060, 327);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 28);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Fermer";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnModClub
            // 
            this.btnModClub.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnModClub.BackColor = System.Drawing.Color.LightBlue;
            this.btnModClub.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModClub.Location = new System.Drawing.Point(131, 311);
            this.btnModClub.Margin = new System.Windows.Forms.Padding(4);
            this.btnModClub.Name = "btnModClub";
            this.btnModClub.Size = new System.Drawing.Size(110, 55);
            this.btnModClub.TabIndex = 6;
            this.btnModClub.Text = "Modifier";
            this.btnModClub.UseVisualStyleBackColor = false;
            this.btnModClub.Click += new System.EventHandler(this.btnModClub_Click);
            // 
            // id_club
            // 
            this.id_club.HeaderText = "Id";
            this.id_club.Name = "id_club";
            this.id_club.ReadOnly = true;
            this.id_club.Width = 48;
            // 
            // Titre_club
            // 
            this.Titre_club.HeaderText = "Nom";
            this.Titre_club.Name = "Titre_club";
            this.Titre_club.ReadOnly = true;
            this.Titre_club.Width = 66;
            // 
            // Code_Postal_club
            // 
            this.Code_Postal_club.HeaderText = "Code postal";
            this.Code_Postal_club.Name = "Code_Postal_club";
            this.Code_Postal_club.ReadOnly = true;
            this.Code_Postal_club.Width = 112;
            // 
            // Ville_Club
            // 
            this.Ville_Club.HeaderText = "Ville";
            this.Ville_Club.Name = "Ville_Club";
            this.Ville_Club.ReadOnly = true;
            this.Ville_Club.Width = 63;
            // 
            // Adresse_Club
            // 
            this.Adresse_Club.HeaderText = "Adresse";
            this.Adresse_Club.Name = "Adresse_Club";
            this.Adresse_Club.ReadOnly = true;
            this.Adresse_Club.Width = 89;
            // 
            // Mail_Club
            // 
            this.Mail_Club.HeaderText = "Mail";
            this.Mail_Club.Name = "Mail_Club";
            this.Mail_Club.ReadOnly = true;
            this.Mail_Club.Width = 62;
            // 
            // Telephone_Club
            // 
            this.Telephone_Club.HeaderText = "Téléphone";
            this.Telephone_Club.Name = "Telephone_Club";
            this.Telephone_Club.ReadOnly = true;
            this.Telephone_Club.Width = 105;
            // 
            // libelle
            // 
            this.libelle.HeaderText = "Ligue";
            this.libelle.Name = "libelle";
            this.libelle.ReadOnly = true;
            this.libelle.Width = 72;
            // 
            // Nbr
            // 
            this.Nbr.HeaderText = "Nombre d\'adhérents";
            this.Nbr.Name = "Nbr";
            this.Nbr.ReadOnly = true;
            this.Nbr.Width = 152;
            // 
            // nbrE
            // 
            this.nbrE.HeaderText = "Nombre d\'événements";
            this.nbrE.Name = "nbrE";
            this.nbrE.ReadOnly = true;
            this.nbrE.Width = 163;
            // 
            // ManagementClubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 379);
            this.Controls.Add(this.btnModClub);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAddClub);
            this.Controls.Add(this.DGClubs);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1190, 426);
            this.Name = "ManagementClubForm";
            this.Text = "Gestion des clubs";
            this.Load += new System.EventHandler(this.Management_Club_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGClubs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGClubs;
        private System.Windows.Forms.Button btnAddClub;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnModClub;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_club;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titre_club;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code_Postal_club;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ville_Club;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresse_Club;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail_Club;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telephone_Club;
        private System.Windows.Forms.DataGridViewTextBoxColumn libelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nbr;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbrE;
    }
}