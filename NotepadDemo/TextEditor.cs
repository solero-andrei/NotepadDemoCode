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
        public TextEditor()
        {
            InitializeComponent();

            this.Text = "Untitled - " + this.Text;
        }

        private void formatFont_Click(object sender, EventArgs e)
        {
            if(this.editorFont.ShowDialog() == DialogResult.OK)
            {
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
    }
}
