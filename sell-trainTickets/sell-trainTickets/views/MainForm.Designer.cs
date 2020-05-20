namespace sellTrainTickets.Views
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchRaceButton = new System.Windows.Forms.Button();
            this.infoButton = new System.Windows.Forms.Button();
            this.addRaceButton = new System.Windows.Forms.Button();
            this.deleteRaceButton = new System.Windows.Forms.Button();
            this.addAdministratorButton = new System.Windows.Forms.Button();
            this.deleteAdminButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 28);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 211);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 28);
            this.label2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.deleteAdminButton);
            this.panel1.Controls.Add(this.addAdministratorButton);
            this.panel1.Controls.Add(this.deleteRaceButton);
            this.panel1.Controls.Add(this.addRaceButton);
            this.panel1.Controls.Add(this.infoButton);
            this.panel1.Controls.Add(this.searchRaceButton);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 484);
            this.panel1.TabIndex = 2;
            // 
            // searchRaceButton
            // 
            this.searchRaceButton.BackColor = System.Drawing.Color.Transparent;
            this.searchRaceButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchRaceButton.Font = new System.Drawing.Font("Yu Gothic UI Light", 10.8F);
            this.searchRaceButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchRaceButton.Location = new System.Drawing.Point(1, 3);
            this.searchRaceButton.Name = "searchRaceButton";
            this.searchRaceButton.Size = new System.Drawing.Size(184, 58);
            this.searchRaceButton.TabIndex = 0;
            this.searchRaceButton.Text = "Пошук рейсу";
            this.searchRaceButton.UseVisualStyleBackColor = false;
            // 
            // infoButton
            // 
            this.infoButton.BackColor = System.Drawing.Color.Transparent;
            this.infoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.infoButton.Font = new System.Drawing.Font("Yu Gothic UI Light", 10.8F);
            this.infoButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.infoButton.Location = new System.Drawing.Point(1, 63);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(184, 58);
            this.infoButton.TabIndex = 1;
            this.infoButton.Text = "Особистий кабінет";
            this.infoButton.UseVisualStyleBackColor = false;
            // 
            // addRaceButton
            // 
            this.addRaceButton.BackColor = System.Drawing.Color.Transparent;
            this.addRaceButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addRaceButton.Font = new System.Drawing.Font("Yu Gothic UI Light", 10.8F);
            this.addRaceButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addRaceButton.Location = new System.Drawing.Point(1, 123);
            this.addRaceButton.Name = "addRaceButton";
            this.addRaceButton.Size = new System.Drawing.Size(184, 58);
            this.addRaceButton.TabIndex = 2;
            this.addRaceButton.Text = "Додати рейс";
            this.addRaceButton.UseVisualStyleBackColor = false;
            // 
            // deleteRaceButton
            // 
            this.deleteRaceButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteRaceButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteRaceButton.Font = new System.Drawing.Font("Yu Gothic UI Light", 10.8F);
            this.deleteRaceButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteRaceButton.Location = new System.Drawing.Point(1, 184);
            this.deleteRaceButton.Name = "deleteRaceButton";
            this.deleteRaceButton.Size = new System.Drawing.Size(184, 58);
            this.deleteRaceButton.TabIndex = 3;
            this.deleteRaceButton.Text = "Видалити рейс";
            this.deleteRaceButton.UseVisualStyleBackColor = false;
            // 
            // addAdministratorButton
            // 
            this.addAdministratorButton.BackColor = System.Drawing.Color.Transparent;
            this.addAdministratorButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addAdministratorButton.Font = new System.Drawing.Font("Yu Gothic UI Light", 10.8F);
            this.addAdministratorButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addAdministratorButton.Location = new System.Drawing.Point(1, 245);
            this.addAdministratorButton.Name = "addAdministratorButton";
            this.addAdministratorButton.Size = new System.Drawing.Size(184, 58);
            this.addAdministratorButton.TabIndex = 4;
            this.addAdministratorButton.Text = "Додати адміністратора";
            this.addAdministratorButton.UseVisualStyleBackColor = false;
            // 
            // deleteAdminButton
            // 
            this.deleteAdminButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteAdminButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteAdminButton.Font = new System.Drawing.Font("Yu Gothic UI Light", 10.8F);
            this.deleteAdminButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteAdminButton.Location = new System.Drawing.Point(1, 305);
            this.deleteAdminButton.Name = "deleteAdminButton";
            this.deleteAdminButton.Size = new System.Drawing.Size(184, 58);
            this.deleteAdminButton.TabIndex = 5;
            this.deleteAdminButton.Text = "Видалити адміністратора";
            this.deleteAdminButton.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(772, 481);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button searchRaceButton;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.Button deleteRaceButton;
        private System.Windows.Forms.Button addRaceButton;
        private System.Windows.Forms.Button deleteAdminButton;
        private System.Windows.Forms.Button addAdministratorButton;
    }
}