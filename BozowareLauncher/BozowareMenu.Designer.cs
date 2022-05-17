using System.ComponentModel;

namespace BozowareLauncher
{
    partial class BozowareMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BozowareMenu));
            this.BozowareIcon = new Guna.UI2.WinForms.Guna2ImageButton();
            this.BorderlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.dragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.SuspendLayout();
            // 
            // BozowareIcon
            // 
            this.BozowareIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
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
            this.BozowareIcon.TabIndex = 1;
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
            this.dragControl.TransparentWhileDrag = false;
            // 
            // BozowareMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.BozowareIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "BozowareMenu";
            this.Text = "BozowareMenu";
            this.ResumeLayout(false);
        }

        private Guna.UI2.WinForms.Guna2DragControl dragControl;

        private Guna.UI2.WinForms.Guna2BorderlessForm BorderlessForm;

        private Guna.UI2.WinForms.Guna2ImageButton BozowareIcon;

        #endregion
    }
}