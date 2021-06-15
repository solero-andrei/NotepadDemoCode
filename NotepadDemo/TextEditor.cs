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
            this.Text = "Untitled - " + this.Text;
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
    }
}
