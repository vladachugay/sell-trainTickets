namespace sellTrainTickets.Views
{
    partial class AvailableRacesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AvailableRacesForm));
            this.availableRacesLabel = new System.Windows.Forms.Label();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.deleteAdminButton = new System.Windows.Forms.Button();
            this.addAdministratorButton = new System.Windows.Forms.Button();
            this.deleteRaceButton = new System.Windows.Forms.Button();
            this.addRaceButton = new System.Windows.Forms.Button();
            this.infoButton = new System.Windows.Forms.Button();
            this.searchRaceButton = new System.Windows.Forms.Button();
            this.availableRacesGrid = new System.Windows.Forms.DataGridView();
            this.CloseButton = new System.Windows.Forms.Label();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.availableRacesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // availableRacesLabel
            // 
            this.availableRacesLabel.AutoSize = true;
            this.availableRacesLabel.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 10.75F);
            this.availableRacesLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.availableRacesLabel.Location = new System.Drawing.Point(272, 11);
            this.availableRacesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.availableRacesLabel.Name = "availableRacesLabel";
            this.availableRacesLabel.Size = new System.Drawing.Size(137, 25);
            this.availableRacesLabel.TabIndex = 0;
            this.availableRacesLabel.Text = "Доступні рейси:";
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.AliceBlue;
            this.menuPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuPanel.BackgroundImage")));
            this.menuPanel.Controls.Add(this.deleteAdminButton);
            this.menuPanel.Controls.Add(this.addAdministratorButton);
            this.menuPanel.Controls.Add(this.deleteRaceButton);
            this.menuPanel.Controls.Add(this.addRaceButton);
            this.menuPanel.Controls.Add(this.infoButton);
            this.menuPanel.Controls.Add(this.searchRaceButton);
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Margin = new System.Windows.Forms.Padding(4);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(248, 591);
            this.menuPanel.TabIndex = 6;
            // 
            // deleteAdminButton
            // 
            this.deleteAdminButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteAdminButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteAdminButton.Font = new System.Drawing.Font("Yu Gothic UI Light", 10.8F);
            this.deleteAdminButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteAdminButton.Location = new System.Drawing.Point(1, 330);
            this.deleteAdminButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteAdminButton.Name = "deleteAdminButton";
            this.deleteAdminButton.Size = new System.Drawing.Size(245, 62);
            this.deleteAdminButton.TabIndex = 5;
            this.deleteAdminButton.Text = "Видалити адміністратора";
            this.deleteAdminButton.UseVisualStyleBackColor = false;
            this.deleteAdminButton.Click += new System.EventHandler(this.deleteAdminButton_Click);
            // 
            // addAdministratorButton
            // 
            this.addAdministratorButton.BackColor = System.Drawing.Color.Transparent;
            this.addAdministratorButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addAdministratorButton.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addAdministratorButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addAdministratorButton.Location = new System.Drawing.Point(1, 265);
            this.addAdministratorButton.Margin = new System.Windows.Forms.Padding(4);
            this.addAdministratorButton.Name = "addAdministratorButton";
            this.addAdministratorButton.Size = new System.Drawing.Size(245, 62);
            this.addAdministratorButton.TabIndex = 4;
            this.addAdministratorButton.Text = "Додати адміністратора";
            this.addAdministratorButton.UseVisualStyleBackColor = false;
            this.addAdministratorButton.Click += new System.EventHandler(this.addAdministratorButton_Click);
            // 
            // deleteRaceButton
            // 
            this.deleteRaceButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteRaceButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteRaceButton.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteRaceButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteRaceButton.Location = new System.Drawing.Point(1, 199);
            this.deleteRaceButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteRaceButton.Name = "deleteRaceButton";
            this.deleteRaceButton.Size = new System.Drawing.Size(245, 62);
            this.deleteRaceButton.TabIndex = 3;
            this.deleteRaceButton.Text = "Видалити рейс";
            this.deleteRaceButton.UseVisualStyleBackColor = false;
            this.deleteRaceButton.Click += new System.EventHandler(this.deleteRaceButton_Click);
            // 
            // addRaceButton
            // 
            this.addRaceButton.BackColor = System.Drawing.Color.Transparent;
            this.addRaceButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addRaceButton.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addRaceButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addRaceButton.Location = new System.Drawing.Point(1, 134);
            this.addRaceButton.Margin = new System.Windows.Forms.Padding(4);
            this.addRaceButton.Name = "addRaceButton";
            this.addRaceButton.Size = new System.Drawing.Size(245, 62);
            this.addRaceButton.TabIndex = 2;
            this.addRaceButton.Text = "Додати рейс";
            this.addRaceButton.UseVisualStyleBackColor = false;
            this.addRaceButton.Click += new System.EventHandler(this.addRaceButton_Click);
            // 
            // infoButton
            // 
            this.infoButton.BackColor = System.Drawing.Color.Transparent;
            this.infoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.infoButton.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.infoButton.Location = new System.Drawing.Point(1, 69);
            this.infoButton.Margin = new System.Windows.Forms.Padding(4);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(245, 62);
            this.infoButton.TabIndex = 1;
            this.infoButton.Text = "Особистий кабінет";
            this.infoButton.UseVisualStyleBackColor = false;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // searchRaceButton
            // 
            this.searchRaceButton.BackColor = System.Drawing.Color.Transparent;
            this.searchRaceButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchRaceButton.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchRaceButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchRaceButton.Location = new System.Drawing.Point(1, 4);
            this.searchRaceButton.Margin = new System.Windows.Forms.Padding(4);
            this.searchRaceButton.Name = "searchRaceButton";
            this.searchRaceButton.Size = new System.Drawing.Size(245, 62);
            this.searchRaceButton.TabIndex = 0;
            this.searchRaceButton.Text = "Пошук рейсу";
            this.searchRaceButton.UseVisualStyleBackColor = false;
            this.searchRaceButton.Click += new System.EventHandler(this.searchRaceButton_Click);
            // 
            // availableRacesGrid
            // 
            this.availableRacesGrid.AllowUserToAddRows = false;
            this.availableRacesGrid.AllowUserToDeleteRows = false;
            this.availableRacesGrid.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.availableRacesGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.availableRacesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.availableRacesGrid.Location = new System.Drawing.Point(277, 60);
            this.availableRacesGrid.Margin = new System.Windows.Forms.Padding(4);
            this.availableRacesGrid.Name = "availableRacesGrid";
            this.availableRacesGrid.ReadOnly = true;
            this.availableRacesGrid.RowHeadersWidth = 51;
            this.availableRacesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.availableRacesGrid.Size = new System.Drawing.Size(716, 491);
            this.availableRacesGrid.TabIndex = 7;
            this.availableRacesGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.availableRacesGrid_CellContentClick);
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(77)))), ((int)(((byte)(156)))));
            this.CloseButton.Location = new System.Drawing.Point(999, 5);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(21, 20);
            this.CloseButton.TabIndex = 8;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // AvailableRacesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1027, 591);
            this.ControlBox = false;
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.availableRacesGrid);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.availableRacesLabel);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AvailableRacesForm";
            this.Text = "AvailableRacesForm";
            this.Load += new System.EventHandler(this.AvailableRacesForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AvailableRacesForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AvailableRacesForm_MouseMove);
            this.menuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.availableRacesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label availableRacesLabel;
        private System.Windows.Forms.Panel menuPanel;
        public System.Windows.Forms.Button deleteAdminButton;
        public System.Windows.Forms.Button addAdministratorButton;
        public System.Windows.Forms.Button deleteRaceButton;
        public System.Windows.Forms.Button addRaceButton;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.Button searchRaceButton;
        private System.Windows.Forms.DataGridView availableRacesGrid;
        private System.Windows.Forms.Label CloseButton;
    }
}