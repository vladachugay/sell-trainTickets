namespace sellTrainTickets.Views
{
    partial class AddRaceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRaceForm));
            this.CloseButton = new System.Windows.Forms.Label();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.deleteAdminButton = new System.Windows.Forms.Button();
            this.addAdministratorButton = new System.Windows.Forms.Button();
            this.deleteRaceButton = new System.Windows.Forms.Button();
            this.addRaceButton = new System.Windows.Forms.Button();
            this.infoButton = new System.Windows.Forms.Button();
            this.searchRaceButton = new System.Windows.Forms.Button();
            this.addRButton = new System.Windows.Forms.Button();
            this.seatsLabel = new System.Windows.Forms.Label();
            this.seatsTextBox = new System.Windows.Forms.TextBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addRaceDataGrid = new System.Windows.Forms.DataGridView();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addRaceDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(77)))), ((int)(((byte)(156)))));
            this.CloseButton.Location = new System.Drawing.Point(999, 4);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(21, 20);
            this.CloseButton.TabIndex = 9;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
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
            this.menuPanel.TabIndex = 10;
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
            // addRButton
            // 
            this.addRButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(177)))));
            this.addRButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addRButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addRButton.Font = new System.Drawing.Font("Yu Gothic UI", 12.8F);
            this.addRButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addRButton.Location = new System.Drawing.Point(517, 502);
            this.addRButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addRButton.Name = "addRButton";
            this.addRButton.Size = new System.Drawing.Size(211, 52);
            this.addRButton.TabIndex = 18;
            this.addRButton.Text = "Додати рейс";
            this.addRButton.UseVisualStyleBackColor = false;
            this.addRButton.Click += new System.EventHandler(this.addRButton_Click);
            // 
            // seatsLabel
            // 
            this.seatsLabel.AutoSize = true;
            this.seatsLabel.Font = new System.Drawing.Font("Yu Gothic UI", 10.75F);
            this.seatsLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.seatsLabel.Location = new System.Drawing.Point(768, 40);
            this.seatsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.seatsLabel.Name = "seatsLabel";
            this.seatsLabel.Size = new System.Drawing.Size(135, 25);
            this.seatsLabel.TabIndex = 19;
            this.seatsLabel.Text = "Кількість місць:";
            // 
            // seatsTextBox
            // 
            this.seatsTextBox.BackColor = System.Drawing.Color.GhostWhite;
            this.seatsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seatsTextBox.Font = new System.Drawing.Font("Yu Gothic UI", 10.75F);
            this.seatsTextBox.Location = new System.Drawing.Point(769, 69);
            this.seatsTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.seatsTextBox.Name = "seatsTextBox";
            this.seatsTextBox.Size = new System.Drawing.Size(219, 31);
            this.seatsTextBox.TabIndex = 20;
            // 
            // IDTextBox
            // 
            this.IDTextBox.BackColor = System.Drawing.Color.GhostWhite;
            this.IDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IDTextBox.Font = new System.Drawing.Font("Yu Gothic UI", 10.75F);
            this.IDTextBox.Location = new System.Drawing.Point(769, 165);
            this.IDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(219, 31);
            this.IDTextBox.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 10.75F);
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(770, 136);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "ID:";
            // 
            // addRaceDataGrid
            // 
            this.addRaceDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addRaceDataGrid.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.addRaceDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.addRaceDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addRaceDataGrid.GridColor = System.Drawing.SystemColors.ScrollBar;
            this.addRaceDataGrid.Location = new System.Drawing.Point(274, 42);
            this.addRaceDataGrid.Name = "addRaceDataGrid";
            this.addRaceDataGrid.RowHeadersWidth = 51;
            this.addRaceDataGrid.RowTemplate.Height = 24;
            this.addRaceDataGrid.Size = new System.Drawing.Size(471, 427);
            this.addRaceDataGrid.TabIndex = 23;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Yu Gothic UI", 10.75F);
            this.priceLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.priceLabel.Location = new System.Drawing.Point(764, 236);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(224, 25);
            this.priceLabel.TabIndex = 24;
            this.priceLabel.Text = "Мінімальні ціна за проїзд:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.BackColor = System.Drawing.Color.GhostWhite;
            this.priceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.priceTextBox.Font = new System.Drawing.Font("Yu Gothic UI", 10.75F);
            this.priceTextBox.Location = new System.Drawing.Point(769, 265);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(219, 31);
            this.priceTextBox.TabIndex = 25;
            // 
            // AddRaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1027, 591);
            this.ControlBox = false;
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.addRaceDataGrid);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.seatsTextBox);
            this.Controls.Add(this.seatsLabel);
            this.Controls.Add(this.addRButton);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.CloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddRaceForm";
            this.Text = "AddRaceForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddRaceForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AddRaceForm_MouseMove);
            this.menuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.addRaceDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Panel menuPanel;
        public System.Windows.Forms.Button deleteAdminButton;
        public System.Windows.Forms.Button addAdministratorButton;
        public System.Windows.Forms.Button deleteRaceButton;
        public System.Windows.Forms.Button addRaceButton;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.Button searchRaceButton;
        private System.Windows.Forms.Button addRButton;
        private System.Windows.Forms.Label seatsLabel;
        private System.Windows.Forms.TextBox seatsTextBox;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView addRaceDataGrid;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox priceTextBox;
    }
}