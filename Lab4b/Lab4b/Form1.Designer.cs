/*
 * Author: Justin Baja
 * Student Number: 000356032
 * File Date: Thursday November 22, 2018
 * Programs Purpose: This class handles the properties and form design
 * Statement of Authorship: I, Justin Baja, 000356032 certify that this material is my original work. 
 * No other person's work has been used without due acknowledgement.
 */

 /// <summary>
 /// Able to share through out the project
 /// </summary>
namespace Lab4b
{
    /// <summary>
    /// This class handles the properties/design of the form
    /// </summary>
    partial class Form1
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.closeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.processMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.checkTagsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.statusLabel = new System.Windows.Forms.Label();
            this.tagsListBox = new System.Windows.Forms.ListBox();
            this.htmlOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.processMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(598, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMenu,
            this.closeMenu});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(44, 24);
            this.fileMenu.Text = "&File";
            // 
            // openMenu
            // 
            this.openMenu.Name = "openMenu";
            this.openMenu.Size = new System.Drawing.Size(216, 26);
            this.openMenu.Text = "&Open";
            this.openMenu.Click += new System.EventHandler(this.openMenu_Click);
            // 
            // closeMenu
            // 
            this.closeMenu.Name = "closeMenu";
            this.closeMenu.Size = new System.Drawing.Size(216, 26);
            this.closeMenu.Text = "&Close";
            this.closeMenu.Click += new System.EventHandler(this.closeMenu_Click);
            // 
            // processMenu
            // 
            this.processMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkTagsMenu});
            this.processMenu.Name = "processMenu";
            this.processMenu.Size = new System.Drawing.Size(70, 24);
            this.processMenu.Text = "&Process";
            // 
            // checkTagsMenu
            // 
            this.checkTagsMenu.Name = "checkTagsMenu";
            this.checkTagsMenu.Size = new System.Drawing.Size(216, 26);
            this.checkTagsMenu.Text = "&Check Tags";
            this.checkTagsMenu.Click += new System.EventHandler(this.checkTagsMenu_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.Location = new System.Drawing.Point(13, 32);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(573, 54);
            this.statusLabel.TabIndex = 1;
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tagsListBox
            // 
            this.tagsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagsListBox.FormattingEnabled = true;
            this.tagsListBox.ItemHeight = 29;
            this.tagsListBox.Location = new System.Drawing.Point(12, 107);
            this.tagsListBox.Name = "tagsListBox";
            this.tagsListBox.Size = new System.Drawing.Size(547, 555);
            this.tagsListBox.TabIndex = 2;
            // 
            // htmlOpenFileDialog
            // 
            this.htmlOpenFileDialog.FileName = "openFileDialog";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 715);
            this.Controls.Add(this.tagsListBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.menuStrip);
            this.Name = "Form1";
            this.Text = "Justin\'s File Checker";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem openMenu;
        private System.Windows.Forms.ToolStripMenuItem closeMenu;
        private System.Windows.Forms.ToolStripMenuItem processMenu;
        private System.Windows.Forms.ToolStripMenuItem checkTagsMenu;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.ListBox tagsListBox;
        private System.Windows.Forms.OpenFileDialog htmlOpenFileDialog;
    }
}

