using System.Drawing;
using System;

namespace BozowareLauncher
{
    partial class BozowareLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BozowareLogin));
            this.BorderlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.dragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.BozowareIcon = new Guna.UI2.WinForms.Guna2ImageButton();
            this.LoginButton = new Guna.UI2.WinForms.Guna2Button();
            this.PasswordTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.UsernameTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.MainLogo = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.StatusTextBox = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BorderlessForm
            // 
            this.BorderlessForm.AnimationInterval = 10;
            this.BorderlessForm.BorderRadius = 2;
            this.BorderlessForm.ContainerControl = this;
            this.BorderlessForm.DockForm = false;
            this.BorderlessForm.DockIndicatorTransparencyValue = 1D;
            this.BorderlessForm.DragForm = false;
            this.BorderlessForm.DragStartTransparencyValue = 1D;
            this.BorderlessForm.ResizeForm = false;
            this.BorderlessForm.ShadowColor = System.Drawing.Color.MediumSlateBlue;
            this.BorderlessForm.TransparentWhileDrag = true;
            // 
            // dragControl
            // 
            this.dragControl.DockIndicatorColor = System.Drawing.Color.Red;
            this.dragControl.DockIndicatorTransparencyValue = 0.6D;
            this.dragControl.TargetControl = this;
            this.dragControl.TransparentWhileDrag = false;
            // 
            // BozowareIcon
            // 
            this.BozowareIcon.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BozowareIcon.HoverState.ImageSize = new System.Drawing.Size(16, 16);
            this.BozowareIcon.Image = ((System.Drawing.Image)(resources.GetObject("BozowareIcon.Image")));
            this.BozowareIcon.ImageOffset = new System.Drawing.Point(0, 0);
            this.BozowareIcon.ImageRotate = 0F;
            this.BozowareIcon.ImageSize = new System.Drawing.Size(16, 16);
            this.BozowareIcon.Location = new System.Drawing.Point(0, 0);
            this.BozowareIcon.Name = "BozowareIcon";
            this.BozowareIcon.PressedState.ImageSize = new System.Drawing.Size(16, 16);
            this.BozowareIcon.Size = new System.Drawing.Size(32, 32);
            this.BozowareIcon.TabIndex = 0;
            this.BozowareIcon.Click += new System.EventHandler(this.bozowareIcon_Clicked);
            // 
            // LoginButton
            // 
            this.LoginButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LoginButton.BackColor = System.Drawing.Color.Transparent;
            this.LoginButton.BorderRadius = 5;
            this.LoginButton.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.LoginButton.CustomBorderThickness = new System.Windows.Forms.Padding(2);
            this.LoginButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LoginButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LoginButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LoginButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LoginButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(56)))), ((int)(((byte)(65)))));
            this.LoginButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(66)))), ((int)(((byte)(75)))));
            this.LoginButton.Location = new System.Drawing.Point(250, 280);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(44)))));
            this.LoginButton.Size = new System.Drawing.Size(100, 25);
            this.LoginButton.TabIndex = 3;
            this.LoginButton.Text = "Login";
            this.LoginButton.Click += new System.EventHandler(this.loginButton_Clicked);
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.PasswordTextbox.BorderRadius = 5;
            this.PasswordTextbox.BorderThickness = 2;
            this.PasswordTextbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.PasswordTextbox.DefaultText = "";
            this.PasswordTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTextbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.PasswordTextbox.FocusedState.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.PasswordTextbox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextbox.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.PasswordTextbox.Location = new System.Drawing.Point(175, 245);
            this.PasswordTextbox.Margin = new System.Windows.Forms.Padding(10);
            this.PasswordTextbox.MaxLength = 255;
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.PasswordChar = '*';
            this.PasswordTextbox.PlaceholderForeColor = System.Drawing.SystemColors.GrayText;
            this.PasswordTextbox.PlaceholderText = "Password";
            this.PasswordTextbox.SelectedText = "";
            this.PasswordTextbox.Size = new System.Drawing.Size(250, 25);
            this.PasswordTextbox.TabIndex = 4;
            this.PasswordTextbox.TextChanged += new System.EventHandler(this.PasswordTextbox_TextChanged);
            // 
            // UsernameTextbox
            // 
            this.UsernameTextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.UsernameTextbox.BorderRadius = 5;
            this.UsernameTextbox.BorderThickness = 2;
            this.UsernameTextbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.UsernameTextbox.DefaultText = "";
            this.UsernameTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UsernameTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UsernameTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsernameTextbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.UsernameTextbox.FocusedState.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.UsernameTextbox.FocusedState.PlaceholderForeColor = System.Drawing.SystemColors.GrayText;
            this.UsernameTextbox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTextbox.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.UsernameTextbox.HoverState.PlaceholderForeColor = System.Drawing.SystemColors.GrayText;
            this.UsernameTextbox.Location = new System.Drawing.Point(175, 210);
            this.UsernameTextbox.Margin = new System.Windows.Forms.Padding(10);
            this.UsernameTextbox.MaxLength = 255;
            this.UsernameTextbox.Name = "UsernameTextbox";
            this.UsernameTextbox.PasswordChar = '\0';
            this.UsernameTextbox.PlaceholderForeColor = System.Drawing.SystemColors.GrayText;
            this.UsernameTextbox.PlaceholderText = "Username";
            this.UsernameTextbox.SelectedText = "";
            this.UsernameTextbox.Size = new System.Drawing.Size(250, 25);
            this.UsernameTextbox.TabIndex = 5;
            this.UsernameTextbox.TextChanged += new System.EventHandler(this.UsernameTextbox_TextChanged);
            // 
            // MainLogo
            // 
            this.MainLogo.CheckedState.ImageSize = new System.Drawing.Size(128, 128);
            this.MainLogo.HoverState.ImageSize = new System.Drawing.Size(128, 128);
            this.MainLogo.Image = ((System.Drawing.Image)(resources.GetObject("MainLogo.Image")));
            this.MainLogo.ImageOffset = new System.Drawing.Point(0, 0);
            this.MainLogo.ImageRotate = 0F;
            this.MainLogo.ImageSize = new System.Drawing.Size(128, 128);
            this.MainLogo.Location = new System.Drawing.Point(236, 50);
            this.MainLogo.Name = "MainLogo";
            this.MainLogo.PressedState.ImageSize = new System.Drawing.Size(128, 128);
            this.MainLogo.Size = new System.Drawing.Size(128, 128);
            this.MainLogo.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(25, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Bozoware Reborn Launcher";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StatusTextBox
            // 
            this.StatusTextBox.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.StatusTextBox.Location = new System.Drawing.Point(172, 175);
            this.StatusTextBox.Name = "StatusTextBox";
            this.StatusTextBox.Size = new System.Drawing.Size(256, 26);
            this.StatusTextBox.TabIndex = 8;
            this.StatusTextBox.Text = "Ready To Login...";
            this.StatusTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StatusTextBox.Click += new System.EventHandler(this.StatusTextBox_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.Snow;
            this.CloseButton.Location = new System.Drawing.Point(552, -7);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.CloseButton.Size = new System.Drawing.Size(48, 35);
            this.CloseButton.TabIndex = 10;
            this.CloseButton.Text = "×";
            this.CloseButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // BozowareLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.ControlBox = false;
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.StatusTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MainLogo);
            this.Controls.Add(this.UsernameTextbox);
            this.Controls.Add(this.PasswordTextbox);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.BozowareIcon);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "BozowareLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bozoware Launcher";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button CloseButton;

        private System.Windows.Forms.Label StatusTextBox;

        private System.Windows.Forms.Label label1;

        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes1;

        private Guna.UI2.WinForms.Guna2ImageButton MainLogo;

        private Guna.UI2.WinForms.Guna2TextBox PasswordTextbox;
        private Guna.UI2.WinForms.Guna2Button LoginButton;

        private Guna.UI2.WinForms.Guna2TextBox UsernameTextbox;

        private Guna.UI2.WinForms.Guna2ImageButton BozowareIcon;

        private Guna.UI2.WinForms.Guna2DragControl dragControl;

        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessForm;

        #endregion
    }
}