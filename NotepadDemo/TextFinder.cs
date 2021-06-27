using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotepadDemo
{
    public partial class TextFinder : Form
    {
        private string EditorContent = "";
        TextEditor editor;
        public TextFinder(string EditorContent, TextEditor Editor)
        {
            InitializeComponent();

            this.EditorContent = EditorContent;
            this.editor = Editor;
        }

        private void TextFinder_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(EditorContent);
        }
    }
}
