namespace sellTrainTickets.Views
{
    partial class PayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayForm));
            this.menuPanel = new System.Windows.Forms.Panel();
            this.deleteAdminButton = new System.Windows.Forms.Button();
            this.addAdministratorButton = new System.Windows.Forms.Button();
            this.deleteRaceButton = new System.Windows.Forms.Button();
            this.addRaceButton = new System.Windows.Forms.Button();
            this.infoButton = new System.Windows.Forms.Button();
            this.searchRaceButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Label();
            this.raceID = new System.Windows.Forms.Label();
            this.departureLabel = new System.Windows.Forms.Label();
            this.arrivalLabel = new System.Windows.Forms.Label();
            this.fullNamelabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.payButton = new System.Windows.Forms.Button();
            this.raceIDTextBox = new System.Windows.Forms.TextBox();
            this.departureStationTextBox = new System.Windows.Forms.TextBox();
            this.arrivalStationTextBox = new System.Windows.Forms.TextBox();
            this.departureTimeTextBox = new System.Windows.Forms.TextBox();
            this.arrivalTimeTextBox = new System.Windows.Forms.TextBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
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
            this.menuPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(248, 591);
            this.menuPanel.TabIndex = 9;
            // 
            // deleteAdminButton
            // 
            this.deleteAdminButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteAdminButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteAdminButton.Font = new System.Drawing.Font("Yu Gothic UI Light", 10.8F);
            this.deleteAdminButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteAdminButton.Location = new System.Drawing.Point(1, 330);
            this.deleteAdminButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.addAdministratorButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.deleteRaceButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.addRaceButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.infoButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.searchRaceButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchRaceButton.Name = "searchRaceButton";
            this.searchRaceButton.Size = new System.Drawing.Size(245, 62);
            this.searchRaceButton.TabIndex = 0;
            this.searchRaceButton.Text = "Пошук рейсу";
            this.searchRaceButton.UseVisualStyleBackColor = false;
            this.searchRaceButton.Click += new System.EventHandler(this.searchRaceButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(77)))), ((int)(((byte)(156)))));
            this.CloseButton.Location = new System.Drawing.Point(1001, 2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(21, 20);
            this.CloseButton.TabIndex = 10;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // raceID
            // 
            this.raceID.AutoSize = true;
            this.raceID.Font = new System.Drawing.Font("Yu Gothic UI", 10.75F);
            this.raceID.Location = new System.Drawing.Point(305, 41);
            this.raceID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.raceID.Name = "raceID";
            this.raceID.Size = new System.Drawing.Size(86, 25);
            this.raceID.TabIndex = 11;
            this.raceID.Text = "ID рейсу:";
            // 
            // departureLabel
            // 
            this.departureLabel.AutoSize = true;
            this.departureLabel.Font = new System.Drawing.Font("Yu Gothic UI", 10.75F);
            this.departureLabel.Location = new System.Drawing.Point(305, 90);
            this.departureLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.departureLabel.Name = "departureLabel";
            this.departureLabel.Size = new System.Drawing.Size(69, 25);
            this.departureLabel.TabIndex = 12;
            this.departureLabel.Text = "Звідки:";
            // 
            // arrivalLabel
            // 
            this.arrivalLabel.AutoSize = true;
            this.arrivalLabel.Font = new System.Drawing.Font("Yu Gothic UI", 10.75F);
            this.arrivalLabel.Location = new System.Drawing.Point(305, 134);
            this.arrivalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.arrivalLabel.Name = "arrivalLabel";
            this.arrivalLabel.Size = new System.Drawing.Size(55, 25);
            this.arrivalLabel.TabIndex = 13;
            this.arrivalLabel.Text = "Куди:";
            // 
            // fullNamelabel
            // 
            this.fullNamelabel.AutoSize = true;
            this.fullNamelabel.Font = new System.Drawing.Font("Yu Gothic UI", 10.75F);
            this.fullNamelabel.Location = new System.Drawing.Point(305, 230);
            this.fullNamelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fullNamelabel.Name = "fullNamelabel";
            this.fullNamelabel.Size = new System.Drawing.Size(135, 25);
            this.fullNamelabel.TabIndex = 14;
            this.fullNamelabel.Text = "Прізвище, ім\'я:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Yu Gothic UI", 10.75F);
            this.priceLabel.Location = new System.Drawing.Point(307, 278);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(52, 25);
            this.priceLabel.TabIndex = 15;
            this.priceLabel.Text = "Ціна:";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Yu Gothic UI", 10.75F);
            this.DateLabel.Location = new System.Drawing.Point(305, 182);
            this.DateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(53, 25);
            this.DateLabel.TabIndex = 16;
            this.DateLabel.Text = "Дата:";
            // 
            // payButton
            // 
            this.payButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(177)))));
            this.payButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.payButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payButton.Font = new System.Drawing.Font("Yu Gothic UI", 12.8F);
            this.payButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.payButton.Location = new System.Drawing.Point(525, 438);
            this.payButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(215, 52);
            this.payButton.TabIndex = 35;
            this.payButton.Text = "Оплатити";
            this.payButton.UseVisualStyleBackColor = false;
            this.payButton.Click += new System.EventHandler(this.payButton_Click);
            // 
            // raceIDTextBox
            // 
            this.raceIDTextBox.BackColor = System.Drawing.Color.GhostWhite;
            this.raceIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.raceIDTextBox.Font = new System.Drawing.Font("Yu Gothic UI", 10.75F);
            this.raceIDTextBox.Location = new System.Drawing.Point(455, 43);
            this.raceIDTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.raceIDTextBox.Name = "raceIDTextBox";
            this.raceIDTextBox.ReadOnly = true;
            this.raceIDTextBox.Size = new System.Drawing.Size(203, 24);
            this.raceIDTextBox.TabIndex = 36;
            // 
            // departureStationTextBox
            // 
            this.departureStationTextBox.BackColor = System.Drawing.Color.GhostWhite;
            this.departureStationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.departureStationTextBox.Font = new System.Drawing.Font("Yu Gothic UI", 10.75F);
            this.departureStationTextBox.Location = new System.Drawing.Point(421, 90);
            this.departureStationTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.departureStationTextBox.Name = "departureStationTextBox";
            this.departureStationTextBox.ReadOnly = true;
            this.departureStationTextBox.Size = new System.Drawing.Size(279, 24);
            this.departureStationTextBox.TabIndex = 37;
            // 
            // arrivalStationTextBox
            // 
            this.arrivalStationTextBox.BackColor = System.Drawing.Color.GhostWhite;
            this.arrivalStationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.arrivalStationTextBox.Font = new System.Drawing.Font("Yu Gothic UI", 10.75F);
            this.arrivalStationTextBox.Location = new System.Drawing.Point(421, 134);
            this.arrivalStationTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.arrivalStationTextBox.Name = "arrivalStationTextBox";
            this.arrivalStationTextBox.ReadOnly = true;
            this.arrivalStationTextBox.Size = new System.Drawing.Size(279, 24);
            this.arrivalStationTextBox.TabIndex = 38;
            // 
            // departureTimeTextBox
            // 
            this.departureTimeTextBox.BackColor = System.Drawing.Color.GhostWhite;
            this.departureTimeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.departureTimeTextBox.Font = new System.Drawing.Font("Yu Gothic UI", 10.75F);
            this.departureTimeTextBox.Location = new System.Drawing.Point(757, 90);
            this.departureTimeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.departureTimeTextBox.Name = "departureTimeTextBox";
            this.departureTimeTextBox.ReadOnly = true;
            this.departureTimeTextBox.Size = new System.Drawing.Size(173, 24);
            this.departureTimeTextBox.TabIndex = 39;
            // 
            // arrivalTimeTextBox
            // 
            this.arrivalTimeTextBox.BackColor = System.Drawing.Color.GhostWhite;
            this.arrivalTimeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.arrivalTimeTextBox.Font = new System.Drawing.Font("Yu Gothic UI", 10.75F);
            this.arrivalTimeTextBox.Location = new System.Drawing.Point(757, 134);
            this.arrivalTimeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.arrivalTimeTextBox.Name = "arrivalTimeTextBox";
            this.arrivalTimeTextBox.ReadOnly = true;
            this.arrivalTimeTextBox.Size = new System.Drawing.Size(173, 24);
            this.arrivalTimeTextBox.TabIndex = 40;
            // 
            // dateTextBox
            // 
            this.dateTextBox.BackColor = System.Drawing.Color.GhostWhite;
            this.dateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dateTextBox.Font = new System.Drawing.Font("Yu Gothic UI", 10.75F);
            this.dateTextBox.Location = new System.Drawing.Point(421, 182);
            this.dateTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.ReadOnly = true;
            this.dateTextBox.Size = new System.Drawing.Size(263, 24);
            this.dateTextBox.TabIndex = 41;
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.BackColor = System.Drawing.Color.GhostWhite;
            this.fullNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fullNameTextBox.Font = new System.Drawing.Font("Yu Gothic UI", 10.75F);
            this.fullNameTextBox.Location = new System.Drawing.Point(499, 230);
            this.fullNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.ReadOnly = true;
            this.fullNameTextBox.Size = new System.Drawing.Size(432, 24);
            this.fullNameTextBox.TabIndex = 42;
            // 
            // priceTextBox
            // 
            this.priceTextBox.BackColor = System.Drawing.Color.GhostWhite;
            this.priceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.priceTextBox.Font = new System.Drawing.Font("Yu Gothic UI", 10.75F);
            this.priceTextBox.Location = new System.Drawing.Point(389, 278);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.ReadOnly = true;
            this.priceTextBox.Size = new System.Drawing.Size(295, 24);
            this.priceTextBox.TabIndex = 43;
            // 
            // PayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1027, 591);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.fullNameTextBox);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.arrivalTimeTextBox);
            this.Controls.Add(this.departureTimeTextBox);
            this.Controls.Add(this.arrivalStationTextBox);
            this.Controls.Add(this.departureStationTextBox);
            this.Controls.Add(this.raceIDTextBox);
            this.Controls.Add(this.payButton);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.fullNamelabel);
            this.Controls.Add(this.arrivalLabel);
            this.Controls.Add(this.departureLabel);
            this.Controls.Add(this.raceID);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.CloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PayForm";
            this.Text = "PayForm";
            this.menuPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        public System.Windows.Forms.Button deleteAdminButton;
        public System.Windows.Forms.Button addAdministratorButton;
        public System.Windows.Forms.Button deleteRaceButton;
        public System.Windows.Forms.Button addRaceButton;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.Button searchRaceButton;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label raceID;
        private System.Windows.Forms.Label departureLabel;
        private System.Windows.Forms.Label arrivalLabel;
        private System.Windows.Forms.Label fullNamelabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Button payButton;
        public System.Windows.Forms.TextBox raceIDTextBox;
        public System.Windows.Forms.TextBox departureStationTextBox;
        public System.Windows.Forms.TextBox arrivalStationTextBox;
        public System.Windows.Forms.TextBox departureTimeTextBox;
        public System.Windows.Forms.TextBox arrivalTimeTextBox;
        public System.Windows.Forms.TextBox dateTextBox;
        public System.Windows.Forms.TextBox fullNameTextBox;
        public System.Windows.Forms.TextBox priceTextBox;
    }
}