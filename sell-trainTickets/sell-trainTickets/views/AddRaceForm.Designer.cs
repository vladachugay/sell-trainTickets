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
            this.stationsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.departureRichTextBox = new System.Windows.Forms.RichTextBox();
            this.arrivalRichTextBox = new System.Windows.Forms.RichTextBox();
            this.stopsLabel = new System.Windows.Forms.Label();
            this.arrivalLabel = new System.Windows.Forms.Label();
            this.departureLabel = new System.Windows.Forms.Label();
            this.addRButton = new System.Windows.Forms.Button();
            this.seatsLabel = new System.Windows.Forms.Label();
            this.seatsTextBox = new System.Windows.Forms.TextBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(77)))), ((int)(((byte)(156)))));
            this.CloseButton.Location = new System.Drawing.Point(749, 3);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(18, 17);
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
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(186, 480);
            this.menuPanel.TabIndex = 10;
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
            // stationsRichTextBox
            // 
            this.stationsRichTextBox.BackColor = System.Drawing.Color.GhostWhite;
            this.stationsRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stationsRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stationsRichTextBox.Location = new System.Drawing.Point(196, 56);
            this.stationsRichTextBox.Name = "stationsRichTextBox";
            this.stationsRichTextBox.Size = new System.Drawing.Size(562, 65);
            this.stationsRichTextBox.TabIndex = 11;
            this.stationsRichTextBox.Text = "";
            // 
            // departureRichTextBox
            // 
            this.departureRichTextBox.BackColor = System.Drawing.Color.GhostWhite;
            this.departureRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.departureRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.departureRichTextBox.Location = new System.Drawing.Point(196, 162);
            this.departureRichTextBox.Name = "departureRichTextBox";
            this.departureRichTextBox.Size = new System.Drawing.Size(562, 65);
            this.departureRichTextBox.TabIndex = 12;
            this.departureRichTextBox.Text = "";
            // 
            // arrivalRichTextBox
            // 
            this.arrivalRichTextBox.BackColor = System.Drawing.Color.GhostWhite;
            this.arrivalRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.arrivalRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            this.arrivalRichTextBox.Location = new System.Drawing.Point(191, 268);
            this.arrivalRichTextBox.Name = "arrivalRichTextBox";
            this.arrivalRichTextBox.Size = new System.Drawing.Size(575, 65);
            this.arrivalRichTextBox.TabIndex = 13;
            this.arrivalRichTextBox.Text = "";
            // 
            // stopsLabel
            // 
            this.stopsLabel.AutoSize = true;
            this.stopsLabel.Font = new System.Drawing.Font("Yu Gothic UI", 10F);
            this.stopsLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.stopsLabel.Location = new System.Drawing.Point(192, 34);
            this.stopsLabel.Name = "stopsLabel";
            this.stopsLabel.Size = new System.Drawing.Size(277, 19);
            this.stopsLabel.TabIndex = 14;
            this.stopsLabel.Text = "Введіть назву кожної зупинки через кому:";
            // 
            // arrivalLabel
            // 
            this.arrivalLabel.AutoSize = true;
            this.arrivalLabel.Font = new System.Drawing.Font("Yu Gothic UI", 10F);
            this.arrivalLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.arrivalLabel.Location = new System.Drawing.Point(188, 246);
            this.arrivalLabel.Name = "arrivalLabel";
            this.arrivalLabel.Size = new System.Drawing.Size(543, 19);
            this.arrivalLabel.TabIndex = 15;
            this.arrivalLabel.Text = "Введіть час прибуття для кожної зупинки відповідно через кому (формат - \"12:45\"):" +
    "";
            // 
            // departureLabel
            // 
            this.departureLabel.AutoSize = true;
            this.departureLabel.Font = new System.Drawing.Font("Yu Gothic UI", 10F);
            this.departureLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.departureLabel.Location = new System.Drawing.Point(188, 140);
            this.departureLabel.Name = "departureLabel";
            this.departureLabel.Size = new System.Drawing.Size(570, 19);
            this.departureLabel.TabIndex = 16;
            this.departureLabel.Text = "Введіть час відправлення для кожної зупинки відповідно через кому (формат - \"12:4" +
    "5\"):";
            // 
            // addRButton
            // 
            this.addRButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(177)))));
            this.addRButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addRButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addRButton.Font = new System.Drawing.Font("Yu Gothic UI", 12.8F);
            this.addRButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addRButton.Location = new System.Drawing.Point(388, 408);
            this.addRButton.Margin = new System.Windows.Forms.Padding(2);
            this.addRButton.Name = "addRButton";
            this.addRButton.Size = new System.Drawing.Size(158, 42);
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
            this.seatsLabel.Location = new System.Drawing.Point(214, 362);
            this.seatsLabel.Name = "seatsLabel";
            this.seatsLabel.Size = new System.Drawing.Size(116, 20);
            this.seatsLabel.TabIndex = 19;
            this.seatsLabel.Text = "Кількість місць:";
            // 
            // seatsTextBox
            // 
            this.seatsTextBox.BackColor = System.Drawing.Color.GhostWhite;
            this.seatsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.seatsTextBox.Font = new System.Drawing.Font("Yu Gothic UI", 10.75F);
            this.seatsTextBox.Location = new System.Drawing.Point(336, 360);
            this.seatsTextBox.Name = "seatsTextBox";
            this.seatsTextBox.Size = new System.Drawing.Size(104, 27);
            this.seatsTextBox.TabIndex = 20;
            // 
            // IDTextBox
            // 
            this.IDTextBox.BackColor = System.Drawing.Color.GhostWhite;
            this.IDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IDTextBox.Font = new System.Drawing.Font("Yu Gothic UI", 10.75F);
            this.IDTextBox.Location = new System.Drawing.Point(568, 360);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(107, 27);
            this.IDTextBox.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 10.75F);
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(535, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "ID:";
            // 
            // AddRaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(770, 480);
            this.ControlBox = false;
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.seatsTextBox);
            this.Controls.Add(this.seatsLabel);
            this.Controls.Add(this.addRButton);
            this.Controls.Add(this.departureLabel);
            this.Controls.Add(this.arrivalLabel);
            this.Controls.Add(this.stopsLabel);
            this.Controls.Add(this.arrivalRichTextBox);
            this.Controls.Add(this.departureRichTextBox);
            this.Controls.Add(this.stationsRichTextBox);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.CloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddRaceForm";
            this.Text = "AddRaceForm";
            this.menuPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button deleteAdminButton;
        private System.Windows.Forms.Button addAdministratorButton;
        private System.Windows.Forms.Button deleteRaceButton;
        private System.Windows.Forms.Button addRaceButton;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.Button searchRaceButton;
        private System.Windows.Forms.RichTextBox stationsRichTextBox;
        private System.Windows.Forms.RichTextBox departureRichTextBox;
        private System.Windows.Forms.RichTextBox arrivalRichTextBox;
        private System.Windows.Forms.Label stopsLabel;
        private System.Windows.Forms.Label arrivalLabel;
        private System.Windows.Forms.Label departureLabel;
        private System.Windows.Forms.Button addRButton;
        private System.Windows.Forms.Label seatsLabel;
        private System.Windows.Forms.TextBox seatsTextBox;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label label1;
    }
}