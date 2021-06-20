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
        private string EditorCurrentFile = "";
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
            if(!string.IsNullOrEmpty(EditorCurrentFile))
            {
                txtEditor.SaveFile(EditorCurrentFile, RichTextBoxStreamType.PlainText);
            }
            else
            {
                if(savingFile.ShowDialog() == DialogResult.OK)
                {
                    if(File.Exists(savingFile.FileName) == true)
                        File.WriteAllText(savingFile.FileName, txtEditor.Text); //Overwrite the existing file
                    else
                        txtEditor.SaveFile(savingFile.FileName, RichTextBoxStreamType.PlainText); //Save a new file
                }
            }

            this.Text = Path.GetFileNameWithoutExtension(openingFile.FileName) + " - Notepad";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openingFile.ShowDialog() == DialogResult.OK)
            {
                this.txtEditor.Text = File.ReadAllText(openingFile.FileName);
                this.EditorCurrentFile = openingFile.FileName;
                this.Text = Path.GetFileNameWithoutExtension(openingFile.FileName) + " - Notepad";
            }
        }

        private void TextEditor_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void filePageSetup_Click(object sender, EventArgs e)
        {

        }

        private void txtEditor_TextChanged(object sender, EventArgs e)
        {
            //Count the lines and columns of richtextbox
            int currentIndex = txtEditor.SelectionStart;
            int Ln = txtEditor.GetLineFromCharIndex(currentIndex);
            int firstLineCharIndex = txtEditor.GetFirstCharIndexFromLine(Ln);
            int Col = currentIndex - firstLineCharIndex;

            lblColumnsAndLines.Text = "Col: " + (Col + 1) + "   Ln: " + (Ln + 1);


            // Count each word on the richtextbox
            int numberOfWords = -1;
            string[] words = txtEditor.Text.Split(' ');

            foreach(var word in words)
            {
                numberOfWords += 1;
            }

            this.lblNumberOfWords.Text = "Number of words: " + numberOfWords.ToString();

            //Count each character entered in richtextbox
            this.lblLength.Text = "Number of char: " + this.txtEditor.TextLength.ToString();

        }

        private void TextEditor_Load(object sender, EventArgs e)
        {
            txtEditor_TextChanged(sender, e);
            viewStatusBar_Click(sender, e);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void viewStatusBar_Click(object sender, EventArgs e)
        {
            if(this.viewStatusBar.Checked == false)
            {
                viewStatusBar.Checked = true;
                this.statusBar.Visible = true;
            }
            else
            {
                viewStatusBar.Checked = false;
                this.statusBar.Visible = false;
            }

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.EditorCurrentFile);
        }

        private void fileSaveAs_Click(object sender, EventArgs e)
        {
            if(savingFile.ShowDialog() == DialogResult.OK)
            {
                if(File.Exists(savingFile.FileName) == true)
                    File.WriteAllText(savingFile.FileName, txtEditor.Text); //Overwrite the existing file
                else
                    txtEditor.SaveFile(savingFile.FileName, RichTextBoxStreamType.PlainText); //Save a new file
            }
        }

        private void filePrint_Click(object sender, EventArgs e)
        {
            if(printDialog1.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}