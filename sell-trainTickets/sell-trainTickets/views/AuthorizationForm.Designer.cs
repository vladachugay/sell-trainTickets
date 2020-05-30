namespace sellTrainTickets.Views
{
    partial class AuthorizationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.WelcomLabel3 = new System.Windows.Forms.Label();
            this.WelcomeLabel3 = new System.Windows.Forms.Label();
            this.WelcomLabel2 = new System.Windows.Forms.Label();
            this.WelcomLabel1 = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.LoginField = new System.Windows.Forms.TextBox();
            this.PassLabel = new System.Windows.Forms.Label();
            this.PassField = new System.Windows.Forms.TextBox();
            this.EnterButton = new System.Windows.Forms.Button();
            this.GoToRegistrationButton = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(110)))), ((int)(((byte)(194)))));
            this.label1.Location = new System.Drawing.Point(555, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "Авторизація";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(237)))), ((int)(((byte)(226)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.WelcomLabel3);
            this.panel1.Controls.Add(this.WelcomeLabel3);
            this.panel1.Controls.Add(this.WelcomLabel2);
            this.panel1.Controls.Add(this.WelcomLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 608);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // WelcomLabel3
            // 
            this.WelcomLabel3.AutoSize = true;
            this.WelcomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.WelcomLabel3.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold);
            this.WelcomLabel3.ForeColor = System.Drawing.Color.Lavender;
            this.WelcomLabel3.Location = new System.Drawing.Point(51, 532);
            this.WelcomLabel3.Name = "WelcomLabel3";
            this.WelcomLabel3.Size = new System.Drawing.Size(291, 46);
            this.WelcomLabel3.TabIndex = 2;
            this.WelcomLabel3.Text = "Авторийзуйтесь, щоб скористатися\r\n          повним функціоналом. ";
            // 
            // WelcomeLabel3
            // 
            this.WelcomeLabel3.AutoSize = true;
            this.WelcomeLabel3.BackColor = System.Drawing.Color.Transparent;
            this.WelcomeLabel3.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold);
            this.WelcomeLabel3.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.WelcomeLabel3.Location = new System.Drawing.Point(60, 532);
            this.WelcomeLabel3.Name = "WelcomeLabel3";
            this.WelcomeLabel3.Size = new System.Drawing.Size(291, 46);
            this.WelcomeLabel3.TabIndex = 2;
            this.WelcomeLabel3.Text = "Авторийзуйтесь, щоб скористатися\r\n          повним функціоналом. ";
            // 
            // WelcomLabel2
            // 
            this.WelcomLabel2.AutoSize = true;
            this.WelcomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.WelcomLabel2.Font = new System.Drawing.Font("Yu Gothic UI Light", 17.2F);
            this.WelcomLabel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.WelcomLabel2.Location = new System.Drawing.Point(70, 112);
            this.WelcomLabel2.Name = "WelcomLabel2";
            this.WelcomLabel2.Size = new System.Drawing.Size(256, 40);
            this.WelcomLabel2.TabIndex = 1;
            this.WelcomLabel2.Text = "до нашого сервісу!";
            // 
            // WelcomLabel1
            // 
            this.WelcomLabel1.AutoSize = true;
            this.WelcomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.WelcomLabel1.Font = new System.Drawing.Font("Yu Gothic UI Light", 22.8F);
            this.WelcomLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.WelcomLabel1.Location = new System.Drawing.Point(46, 61);
            this.WelcomLabel1.Name = "WelcomLabel1";
            this.WelcomLabel1.Size = new System.Drawing.Size(314, 51);
            this.WelcomLabel1.TabIndex = 0;
            this.WelcomLabel1.Text = "Ласкаво просимо\r\n";
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(77)))), ((int)(((byte)(156)))));
            this.CloseButton.Location = new System.Drawing.Point(938, 9);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(21, 20);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Tahoma", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LoginLabel.Location = new System.Drawing.Point(487, 193);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(46, 14);
            this.LoginLabel.TabIndex = 4;
            this.LoginLabel.Text = "ЛОГІН";
            // 
            // LoginField
            // 
            this.LoginField.BackColor = System.Drawing.Color.GhostWhite;
            this.LoginField.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginField.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.LoginField.Location = new System.Drawing.Point(490, 210);
            this.LoginField.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.LoginField.Multiline = true;
            this.LoginField.Name = "LoginField";
            this.LoginField.Size = new System.Drawing.Size(397, 50);
            this.LoginField.TabIndex = 5;
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Font = new System.Drawing.Font("Tahoma", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PassLabel.Location = new System.Drawing.Point(487, 295);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(59, 14);
            this.PassLabel.TabIndex = 6;
            this.PassLabel.Text = "ПАРОЛЬ";
            // 
            // PassField
            // 
            this.PassField.BackColor = System.Drawing.Color.GhostWhite;
            this.PassField.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassField.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.PassField.Location = new System.Drawing.Point(490, 312);
            this.PassField.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.PassField.Name = "PassField";
            this.PassField.Size = new System.Drawing.Size(397, 49);
            this.PassField.TabIndex = 7;
            this.PassField.UseSystemPasswordChar = true;
            // 
            // EnterButton
            // 
            this.EnterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(177)))));
            this.EnterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EnterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EnterButton.Location = new System.Drawing.Point(622, 414);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(130, 49);
            this.EnterButton.TabIndex = 8;
            this.EnterButton.Text = "Зайти";
            this.EnterButton.UseVisualStyleBackColor = false;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            this.EnterButton.MouseEnter += new System.EventHandler(this.EnterButton_MouseEnter);
            this.EnterButton.MouseLeave += new System.EventHandler(this.EnterButton_MouseLeave);
            // 
            // GoToRegistrationButton
            // 
            this.GoToRegistrationButton.AutoSize = true;
            this.GoToRegistrationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoToRegistrationButton.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoToRegistrationButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(59)))), ((int)(((byte)(130)))));
            this.GoToRegistrationButton.Location = new System.Drawing.Point(580, 485);
            this.GoToRegistrationButton.Name = "GoToRegistrationButton";
            this.GoToRegistrationButton.Size = new System.Drawing.Size(218, 46);
            this.GoToRegistrationButton.TabIndex = 9;
            this.GoToRegistrationButton.Text = "Немає облікового запису?\r\n            Реєстарція";
            this.GoToRegistrationButton.Click += new System.EventHandler(this.GoToRegistrationButton_Click);
            this.GoToRegistrationButton.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            this.GoToRegistrationButton.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(70)))), ((int)(((byte)(156)))));
            this.errorLabel.Location = new System.Drawing.Point(565, 379);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(236, 23);
            this.errorLabel.TabIndex = 10;
            this.errorLabel.Text = "Неправильний логін/пароль";
            this.errorLabel.Visible = false;
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(968, 608);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.GoToRegistrationButton);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.PassField);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.LoginField);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "AuthorizationForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AuthorizationForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AuthorizationForm_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.TextBox LoginField;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.TextBox PassField;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.Label WelcomLabel1;
        private System.Windows.Forms.Label WelcomLabel2;
        private System.Windows.Forms.Label WelcomeLabel3;
        private System.Windows.Forms.Label WelcomLabel3;
        private System.Windows.Forms.Label GoToRegistrationButton;
        public System.Windows.Forms.Label errorLabel;
    }
}

