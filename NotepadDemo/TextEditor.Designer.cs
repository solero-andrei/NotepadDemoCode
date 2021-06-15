﻿namespace NotepadDemo
{
    partial class TextEditor
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
            if(disposing && (components != null))
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextEditor));
            this.Menus = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatWordWrap = new System.Windows.Forms.ToolStripMenuItem();
            this.formatFont = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewZoomIn = new System.Windows.Forms.ToolStripMenuItem();
            this.viewZoomOut = new System.Windows.Forms.ToolStripMenuItem();
            this.viewRestoreZoom = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelSeperator = new System.Windows.Forms.Panel();
            this.txtEditor = new System.Windows.Forms.RichTextBox();
            this.editorFont = new System.Windows.Forms.FontDialog();
            this.statusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menus.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menus
            // 
            this.Menus.BackColor = System.Drawing.Color.White;
            this.Menus.GripMargin = new System.Windows.Forms.Padding(1, 1, 0, 1);
            this.Menus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.Menus.Location = new System.Drawing.Point(0, 0);
            this.Menus.Name = "Menus";
            this.Menus.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.Menus.Size = new System.Drawing.Size(788, 24);
            this.Menus.TabIndex = 0;
            this.Menus.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.newWindowToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripSeparator2,
            this.toolStripMenuItem3});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.fileToolStripMenuItem.ShortcutKeyDisplayString = "F";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(29, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.newToolStripMenuItem.Text = "New ";
            // 
            // newWindowToolStripMenuItem
            // 
            this.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            this.newWindowToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.newWindowToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.newWindowToolStripMenuItem.Text = "New Window          ";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.openToolStripMenuItem.Text = "Open...";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(247, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(250, 22);
            this.toolStripMenuItem1.Text = "Page Setup...";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(250, 22);
            this.toolStripMenuItem2.Text = "Print...";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(247, 6);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(250, 22);
            this.toolStripMenuItem3.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.editToolStripMenuItem.Size = new System.Drawing.Size(31, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formatWordWrap,
            this.formatFont});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.formatToolStripMenuItem.Text = "&Format";
            // 
            // formatWordWrap
            // 
            this.formatWordWrap.Name = "formatWordWrap";
            this.formatWordWrap.Size = new System.Drawing.Size(152, 22);
            this.formatWordWrap.Text = "Word Wrap";
            this.formatWordWrap.Click += new System.EventHandler(this.formatWordWrap_Click);
            // 
            // formatFont
            // 
            this.formatFont.Name = "formatFont";
            this.formatFont.Size = new System.Drawing.Size(152, 22);
            this.formatFont.Text = "Font";
            this.formatFont.Click += new System.EventHandler(this.formatFont_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomToolStripMenuItem,
            this.statusBarToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewZoomIn,
            this.viewZoomOut,
            this.viewRestoreZoom});
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.zoomToolStripMenuItem.Text = "Zoom";
            // 
            // viewZoomIn
            // 
            this.viewZoomIn.Name = "viewZoomIn";
            this.viewZoomIn.ShortcutKeyDisplayString = "Ctrl + Plus";
            this.viewZoomIn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus)));
            this.viewZoomIn.Size = new System.Drawing.Size(229, 22);
            this.viewZoomIn.Text = "Zoom In";
            this.viewZoomIn.Click += new System.EventHandler(this.viewZoomIn_Click);
            // 
            // viewZoomOut
            // 
            this.viewZoomOut.Name = "viewZoomOut";
            this.viewZoomOut.ShortcutKeyDisplayString = "Ctrl + Minus";
            this.viewZoomOut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemMinus)));
            this.viewZoomOut.Size = new System.Drawing.Size(229, 22);
            this.viewZoomOut.Text = "Zoom Out";
            this.viewZoomOut.Click += new System.EventHandler(this.viewZoomOut_Click);
            // 
            // viewRestoreZoom
            // 
            this.viewRestoreZoom.Name = "viewRestoreZoom";
            this.viewRestoreZoom.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0)));
            this.viewRestoreZoom.Size = new System.Drawing.Size(229, 22);
            this.viewRestoreZoom.Text = "Restore Default Zoom";
            this.viewRestoreZoom.Click += new System.EventHandler(this.viewRestoreZoom_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.viewHelpToolStripMenuItem.Text = "View Help";
            // 
            // panelSeperator
            // 
            this.panelSeperator.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSeperator.Location = new System.Drawing.Point(0, 24);
            this.panelSeperator.Name = "panelSeperator";
            this.panelSeperator.Size = new System.Drawing.Size(788, 2);
            this.panelSeperator.TabIndex = 1;
            // 
            // txtEditor
            // 
            this.txtEditor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEditor.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditor.Location = new System.Drawing.Point(0, 26);
            this.txtEditor.Name = "txtEditor";
            this.txtEditor.Size = new System.Drawing.Size(788, 511);
            this.txtEditor.TabIndex = 2;
            this.txtEditor.Text = "";
            this.txtEditor.WordWrap = false;
            // 
            // statusBarToolStripMenuItem
            // 
            this.statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            this.statusBarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.statusBarToolStripMenuItem.Text = "Status Bar";
            // 
            // TextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 537);
            this.Controls.Add(this.txtEditor);
            this.Controls.Add(this.panelSeperator);
            this.Controls.Add(this.Menus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menus;
            this.Name = "TextEditor";
            this.Text = "Notepad";
            this.Menus.ResumeLayout(false);
            this.Menus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menus;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Panel panelSeperator;
        private System.Windows.Forms.RichTextBox txtEditor;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem formatWordWrap;
        private System.Windows.Forms.ToolStripMenuItem formatFont;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewZoomIn;
        private System.Windows.Forms.ToolStripMenuItem viewZoomOut;
        private System.Windows.Forms.ToolStripMenuItem viewRestoreZoom;
        private System.Windows.Forms.FontDialog editorFont;
        private System.Windows.Forms.ToolStripMenuItem statusBarToolStripMenuItem;
    }
}

