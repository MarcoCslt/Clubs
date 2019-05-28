namespace ClubsManagement.Views
{
    partial class ManagementEventForm
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.DGEvents = new System.Windows.Forms.DataGridView();
            this.Id_event = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titre_event = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debut_event = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fin_event = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Club_event = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnModEvent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClose.Location = new System.Drawing.Point(615, 327);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 28);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Fermer";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRefresh.Location = new System.Drawing.Point(507, 327);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 28);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Rafraichir";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAddEvent.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEvent.Location = new System.Drawing.Point(13, 311);
            this.btnAddEvent.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(110, 55);
            this.btnAddEvent.TabIndex = 7;
            this.btnAddEvent.Text = "Ajouter";
            this.btnAddEvent.UseVisualStyleBackColor = false;
            this.btnAddEvent.Click += new System.EventHandler(this.btn_Add_Event_Click);
            // 
            // DGEvents
            // 
            this.DGEvents.AllowUserToAddRows = false;
            this.DGEvents.AllowUserToDeleteRows = false;
            this.DGEvents.AllowUserToOrderColumns = true;
            this.DGEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGEvents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGEvents.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGEvents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_event,
            this.Titre_event,
            this.Debut_event,
            this.Fin_event,
            this.Club_event});
            this.DGEvents.Location = new System.Drawing.Point(13, 15);
            this.DGEvents.Margin = new System.Windows.Forms.Padding(4);
            this.DGEvents.Name = "DGEvents";
            this.DGEvents.ReadOnly = true;
            this.DGEvents.Size = new System.Drawing.Size(702, 288);
            this.DGEvents.TabIndex = 6;
            this.DGEvents.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DG_Event_RowHeaderMouseDoubleClick);
            // 
            // Id_event
            // 
            this.Id_event.HeaderText = "Id";
            this.Id_event.Name = "Id_event";
            this.Id_event.ReadOnly = true;
            this.Id_event.Width = 48;
            // 
            // Titre_event
            // 
            this.Titre_event.HeaderText = "Titre";
            this.Titre_event.Name = "Titre_event";
            this.Titre_event.ReadOnly = true;
            this.Titre_event.Width = 66;
            // 
            // Debut_event
            // 
            this.Debut_event.HeaderText = "Début";
            this.Debut_event.MaxInputLength = 10;
            this.Debut_event.Name = "Debut_event";
            this.Debut_event.ReadOnly = true;
            this.Debut_event.Width = 75;
            // 
            // Fin_event
            // 
            this.Fin_event.HeaderText = "Fin";
            this.Fin_event.Name = "Fin_event";
            this.Fin_event.ReadOnly = true;
            this.Fin_event.Width = 56;
            // 
            // Club_event
            // 
            this.Club_event.HeaderText = "Club";
            this.Club_event.Name = "Club_event";
            this.Club_event.ReadOnly = true;
            this.Club_event.Width = 65;
            // 
            // btnModEvent
            // 
            this.btnModEvent.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnModEvent.BackColor = System.Drawing.Color.LightBlue;
            this.btnModEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModEvent.Location = new System.Drawing.Point(131, 311);
            this.btnModEvent.Margin = new System.Windows.Forms.Padding(4);
            this.btnModEvent.Name = "btnModEvent";
            this.btnModEvent.Size = new System.Drawing.Size(110, 55);
            this.btnModEvent.TabIndex = 10;
            this.btnModEvent.Text = "Modifier";
            this.btnModEvent.UseVisualStyleBackColor = false;
            this.btnModEvent.Click += new System.EventHandler(this.btn_Mod_Event_Click);
            // 
            // ManagementEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 379);
            this.Controls.Add(this.btnModEvent);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAddEvent);
            this.Controls.Add(this.DGEvents);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(746, 426);
            this.Name = "ManagementEventForm";
            this.Text = "Gestion des événements";
            this.Load += new System.EventHandler(this.Management_Event_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGEvents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.DataGridView DGEvents;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_event;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titre_event;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debut_event;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fin_event;
        private System.Windows.Forms.DataGridViewTextBoxColumn Club_event;
        private System.Windows.Forms.Button btnModEvent;
    }
}