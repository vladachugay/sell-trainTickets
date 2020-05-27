namespace sellTrainTickets.Views
{
    partial class DeleteRaceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteRaceForm));
            this.menuPanel = new System.Windows.Forms.Panel();
            this.deleteAdminButton = new System.Windows.Forms.Button();
            this.addAdministratorButton = new System.Windows.Forms.Button();
            this.deleteRaceButton = new System.Windows.Forms.Button();
            this.addRaceButton = new System.Windows.Forms.Button();
            this.infoButton = new System.Windows.Forms.Button();
            this.searchRaceButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Label();
            this.deleteRButton = new System.Windows.Forms.Button();
            this.IDField = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
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
            this.menuPanel.TabIndex = 36;
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
            this.CloseButton.Location = new System.Drawing.Point(751, 1);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(18, 17);
            this.CloseButton.TabIndex = 40;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // deleteRButton
            // 
            this.deleteRButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(177)))));
            this.deleteRButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteRButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteRButton.Font = new System.Drawing.Font("Yu Gothic UI", 12.8F);
            this.deleteRButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteRButton.Location = new System.Drawing.Point(375, 336);
            this.deleteRButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteRButton.Name = "deleteRButton";
            this.deleteRButton.Size = new System.Drawing.Size(197, 42);
            this.deleteRButton.TabIndex = 39;
            this.deleteRButton.Text = "Видалити рейс";
            this.deleteRButton.UseVisualStyleBackColor = false;
            this.deleteRButton.Click += new System.EventHandler(this.deleteRButton_Click);
            // 
            // IDField
            // 
            this.IDField.BackColor = System.Drawing.Color.GhostWhite;
            this.IDField.Font = new System.Drawing.Font("Arial Narrow", 18F);
            this.IDField.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.IDField.Location = new System.Drawing.Point(317, 189);
            this.IDField.Margin = new System.Windows.Forms.Padding(2, 12, 2, 2);
            this.IDField.Name = "IDField";
            this.IDField.Size = new System.Drawing.Size(319, 35);
            this.IDField.TabIndex = 38;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Yu Gothic UI", 14.75F);
            this.label.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label.Location = new System.Drawing.Point(302, 65);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(370, 28);
            this.label.TabIndex = 37;
            this.label.Text = "Введіть ID рейсу, який хочете видалити";
            // 
            // DeleteRaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(770, 480);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.deleteRButton);
            this.Controls.Add(this.IDField);
            this.Controls.Add(this.label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteRaceForm";
            this.Text = "DeleteRaceForm";
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
        private System.Windows.Forms.Button deleteRButton;
        private System.Windows.Forms.TextBox IDField;
        private System.Windows.Forms.Label label;
    }
}