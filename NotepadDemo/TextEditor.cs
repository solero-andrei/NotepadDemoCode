using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotepadDemo
{
    public partial class TextEditor : Form
    {
        private float DefaultFontSize = 0F;
        private string SelectedFont;
        public TextEditor()
        {
            InitializeComponent();

            DefaultFontSize = this.txtEditor.Font.Size;
            this.Text = "Untitled - Notepad";
        }

        private void formatFont_Click(object sender, EventArgs e)
        {
            if(this.editorFont.ShowDialog() == DialogResult.OK)
            {
                this.SelectedFont = this.editorFont.Font.FontFamily.Name;
                this.txtEditor.Font = this.editorFont.Font;
            }
        }

        private void formatWordWrap_Click(object sender, EventArgs e)
        {
            if(this.formatWordWrap.Checked == false)
            {
                this.formatWordWrap.Checked = true;
            }
            else
            {
                this.formatWordWrap.Checked = false;
            }

            this.txtEditor.WordWrap = formatWordWrap.Checked;
        }

        private void viewZoomIn_Click(object sender, EventArgs e)
        {
            float existingFontSize = this.txtEditor.Font.Size;
            this.txtEditor.Font = new Font(SelectedFont, existingFontSize + 2);
        }

        private void viewZoomOut_Click(object sender, EventArgs e)
        {
            float existingFontSize = this.txtEditor.Font.Size;
            this.txtEditor.Font = new Font(SelectedFont, existingFontSize - 2);
        }

        private void viewRestoreZoom_Click(object sender, EventArgs e)
        {
            this.txtEditor.Font = new Font(SelectedFont, DefaultFontSize);
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(SelectedFont);
        }

        private void fileNewWindow_Click(object sender, EventArgs e)
        {
            TextEditor newWindow = new TextEditor();
            newWindow.Show();
        }

        private void txtEditor_TextChanged(object sender, EventArgs e)
        {
            if(txtEditor.Text.Length == 0) this.Text = "Untitled - Notepad";
            else this.Text = "*Untitled - Notepad";
        }

        private void fileSave_Click(object sender, EventArgs e)
        {
            //if(savingFile.ShowDialog() == DialogResult.Parse(FileDialog, "Save"))
            //{
            //    MessageBox.Show("Test");
            //}
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openingFile.ShowDialog() == DialogResult.Yes)
            {
                MessageBox.Show("Test");
            }
        }
    }
}