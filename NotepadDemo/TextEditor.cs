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
using System.IO;

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

        private void fileNewWindow_Click(object sender, EventArgs e)
        {
            TextEditor newWindow = new TextEditor();
            newWindow.Show();
        }

        private void fileSave_Click(object sender, EventArgs e)
        {
            if(savingFile.ShowDialog() == DialogResult.OK)
            {
                if(File.Exists(savingFile.FileName) == true) File.WriteAllText(savingFile.FileName, txtEditor.Text);
                else
                    txtEditor.SaveFile(savingFile.FileName, RichTextBoxStreamType.PlainText);
            }

            this.Text = Path.GetFileNameWithoutExtension(openingFile.FileName) + " - Notepad";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openingFile.ShowDialog() == DialogResult.OK)
            {
                txtEditor.Text = File.ReadAllText(openingFile.FileName);
                this.Text = Path.GetFileNameWithoutExtension(openingFile.FileName) + " - Notepad";
            }
        }

        private void TextEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(this.txtEditor.Text.Length > 0)
            {
                DialogResult saving = MessageBox.Show("Do you want to save the file before closing?", "Notepad", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(saving != DialogResult.Yes)
                {
                    MessageBox.Show("Test");
                }
            }
        }

        private void filePageSetup_Click(object sender, EventArgs e)
        {

        }

        private void txtEditor_TextChanged(object sender, EventArgs e)
        {
            int currentIndex = txtEditor.SelectionStart;
            int Ln = txtEditor.GetLineFromCharIndex(currentIndex);
            int firstLineCharIndex = txtEditor.GetFirstCharIndexFromLine(Ln);
            int Col = currentIndex - firstLineCharIndex;

            lblColumnsAndLines.Text = "Col: " + (Col + 1) + "   Ln: " + (Ln + 1);

            int numberOfWords = -1;
            string[] words = txtEditor.Text.Split(' ');

            foreach(var word in words)
            {
                numberOfWords += 1;
            }

            lblNumberOfWords.Text = "Number of words: " + numberOfWords.ToString();

        }

        private void TextEditor_Load(object sender, EventArgs e)
        {
            txtEditor_TextChanged(sender, e);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}