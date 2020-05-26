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
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(186, 480);
            this.menuPanel.TabIndex = 9;
            // 
            // deleteAdminButton
            // 
            this.deleteAdminButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteAdminButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteAdminButton.Font = new System.Drawing.Font("Yu Gothic UI Light", 10.8F);
            this.deleteAdminButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteAdminButton.Location = new System.Drawing.Point(1, 268);
            this.deleteAdminButton.Name = "deleteAdminButton";
            this.deleteAdminButton.Size = new System.Drawing.Size(184, 50);
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
            this.addAdministratorButton.Location = new System.Drawing.Point(1, 215);
            this.addAdministratorButton.Name = "addAdministratorButton";
            this.addAdministratorButton.Size = new System.Drawing.Size(184, 50);
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
            this.deleteRaceButton.Location = new System.Drawing.Point(1, 162);
            this.deleteRaceButton.Name = "deleteRaceButton";
            this.deleteRaceButton.Size = new System.Drawing.Size(184, 50);
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
            this.addRaceButton.Location = new System.Drawing.Point(1, 109);
            this.addRaceButton.Name = "addRaceButton";
            this.addRaceButton.Size = new System.Drawing.Size(184, 50);
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
            this.infoButton.Location = new System.Drawing.Point(1, 56);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(184, 50);
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
            this.searchRaceButton.Location = new System.Drawing.Point(1, 3);
            this.searchRaceButton.Name = "searchRaceButton";
            this.searchRaceButton.Size = new System.Drawing.Size(184, 50);
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
            this.CloseButton.Location = new System.Drawing.Point(751, 2);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(18, 17);
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
            this.raceID.Location = new System.Drawing.Point(229, 33);
            this.raceID.Name = "raceID";
            this.raceID.Size = new System.Drawing.Size(71, 20);
            this.raceID.TabIndex = 11;
            this.raceID.Text = "ID рейсу:";
            // 
            // departureLabel
            // 
            this.departureLabel.AutoSize = true;
            this.departureLabel.Font = new System.Drawing.Font("Yu Gothic UI", 10.75F);
            this.departureLabel.Location = new System.Drawing.Point(229, 73);
            this.departureLabel.Name = "departureLabel";
            this.departureLabel.Size = new System.Drawing.Size(56, 20);
            this.departureLabel.TabIndex = 12;
            this.departureLabel.Text = "Звідки:";
            // 
            // arrivalLabel
            // 
            this.arrivalLabel.AutoSize = true;
            this.arrivalLabel.Font = new System.Drawing.Font("Yu Gothic UI", 10.75F);
            this.arrivalLabel.Location = new System.Drawing.Point(229, 109);
            this.arrivalLabel.Name = "arrivalLabel";
            this.arrivalLabel.Size = new System.Drawing.Size(45, 20);
            this.arrivalLabel.TabIndex = 13;
            this.arrivalLabel.Text = "Куди:";
            // 
            // fullNamelabel
            // 
            this.fullNamelabel.AutoSize = true;
            this.fullNamelabel.Font = new System.Drawing.Font("Yu Gothic UI", 10.75F);
            this.fullNamelabel.Location = new System.Drawing.Point(229, 187);
            this.fullNamelabel.Name = "fullNamelabel";
            this.fullNamelabel.Size = new System.Drawing.Size(113, 20);
            this.fullNamelabel.TabIndex = 14;
            this.fullNamelabel.Text = "Прізвище, ім\'я:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Yu Gothic UI", 10.75F);
            this.priceLabel.Location = new System.Drawing.Point(230, 226);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(44, 20);
            this.priceLabel.TabIndex = 15;
            this.priceLabel.Text = "Ціна:";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Yu Gothic UI", 10.75F);
            this.DateLabel.Location = new System.Drawing.Point(229, 148);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(44, 20);
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
            this.payButton.Location = new System.Drawing.Point(394, 356);
            this.payButton.Margin = new System.Windows.Forms.Padding(2);
            this.payButton.Name = "payButton";
            this.payButton.Size = new System.Drawing.Size(161, 42);
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
            this.raceIDTextBox.Location = new System.Drawing.Point(341, 35);
            this.raceIDTextBox.Name = "raceIDTextBox";
            this.raceIDTextBox.ReadOnly = true;
            this.raceIDTextBox.Size = new System.Drawing.Size(131, 20);
            this.raceIDTextBox.TabIndex = 36;
            // 
            // departureStationTextBox
            // 
            this.departureStationTextBox.BackColor = System.Drawing.Color.GhostWhite;
            this.departureStationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.departureStationTextBox.Font = new System.Drawing.Font("Yu Gothic UI", 10.75F);
            this.departureStationTextBox.Location = new System.Drawing.Point(316, 73);
            this.departureStationTextBox.Name = "departureStationTextBox";
            this.departureStationTextBox.ReadOnly = true;
            this.departureStationTextBox.Size = new System.Drawing.Size(209, 20);
            this.departureStationTextBox.TabIndex = 37;
            // 
            // arrivalStationTextBox
            // 
            this.arrivalStationTextBox.BackColor = System.Drawing.Color.GhostWhite;
            this.arrivalStationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.arrivalStationTextBox.Font = new System.Drawing.Font("Yu Gothic UI", 10.75F);
            this.arrivalStationTextBox.Location = new System.Drawing.Point(316, 109);
            this.arrivalStationTextBox.Name = "arrivalStationTextBox";
            this.arrivalStationTextBox.ReadOnly = true;
            this.arrivalStationTextBox.Size = new System.Drawing.Size(209, 20);
            this.arrivalStationTextBox.TabIndex = 38;
            // 
            // departureTimeTextBox
            // 
            this.departureTimeTextBox.BackColor = System.Drawing.Color.GhostWhite;
            this.departureTimeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.departureTimeTextBox.Font = new System.Drawing.Font("Yu Gothic UI", 10.75F);
            this.departureTimeTextBox.Location = new System.Drawing.Point(568, 73);
            this.departureTimeTextBox.Name = "departureTimeTextBox";
            this.departureTimeTextBox.ReadOnly = true;
            this.departureTimeTextBox.Size = new System.Drawing.Size(130, 20);
            this.departureTimeTextBox.TabIndex = 39;
            // 
            // arrivalTimeTextBox
            // 
            this.arrivalTimeTextBox.BackColor = System.Drawing.Color.GhostWhite;
            this.arrivalTimeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.arrivalTimeTextBox.Font = new System.Drawing.Font("Yu Gothic UI", 10.75F);
            this.arrivalTimeTextBox.Location = new System.Drawing.Point(568, 109);
            this.arrivalTimeTextBox.Name = "arrivalTimeTextBox";
            this.arrivalTimeTextBox.ReadOnly = true;
            this.arrivalTimeTextBox.Size = new System.Drawing.Size(130, 20);
            this.arrivalTimeTextBox.TabIndex = 40;
            // 
            // dateTextBox
            // 
            this.dateTextBox.BackColor = System.Drawing.Color.GhostWhite;
            this.dateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dateTextBox.Font = new System.Drawing.Font("Yu Gothic UI", 10.75F);
            this.dateTextBox.Location = new System.Drawing.Point(316, 148);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.ReadOnly = true;
            this.dateTextBox.Size = new System.Drawing.Size(197, 20);
            this.dateTextBox.TabIndex = 41;
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.BackColor = System.Drawing.Color.GhostWhite;
            this.fullNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fullNameTextBox.Font = new System.Drawing.Font("Yu Gothic UI", 10.75F);
            this.fullNameTextBox.Location = new System.Drawing.Point(374, 187);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.ReadOnly = true;
            this.fullNameTextBox.Size = new System.Drawing.Size(324, 20);
            this.fullNameTextBox.TabIndex = 42;
            // 
            // priceTextBox
            // 
            this.priceTextBox.BackColor = System.Drawing.Color.GhostWhite;
            this.priceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.priceTextBox.Font = new System.Drawing.Font("Yu Gothic UI", 10.75F);
            this.priceTextBox.Location = new System.Drawing.Point(292, 226);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.ReadOnly = true;
            this.priceTextBox.Size = new System.Drawing.Size(221, 20);
            this.priceTextBox.TabIndex = 43;
            // 
            // PayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(770, 480);
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
            this.Name = "PayForm";
            this.Text = "PayForm";
            this.menuPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button deleteAdminButton;
        private System.Windows.Forms.Button addAdministratorButton;
        private System.Windows.Forms.Button deleteRaceButton;
        private System.Windows.Forms.Button addRaceButton;
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
        private System.Windows.Forms.TextBox raceIDTextBox;
        private System.Windows.Forms.TextBox departureStationTextBox;
        private System.Windows.Forms.TextBox arrivalStationTextBox;
        private System.Windows.Forms.TextBox departureTimeTextBox;
        private System.Windows.Forms.TextBox arrivalTimeTextBox;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
    }
}