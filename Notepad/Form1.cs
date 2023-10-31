﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class MewaelNotePad : Form
    {
        public MewaelNotePad()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog mewael = new OpenFileDialog();
            mewael.Title = "Open";
            mewael.Filter = "Text Document(*.txt)*.txt All Files(*.*) *.*";
            if(mewael.ShowDialog() == DialogResult.OK)
                richTextBox1.LoadFile(mewael.FileName, RichTextBoxStreamType.PlainText);
            this.Text = mewael.FileName;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog mewael = new SaveFileDialog();
            mewael.Title = "Save";
            mewael.Filter = "Text Document(*.txt)*.txt All Files(*.*)*.*";
            if (mewael.ShowDialog() == DialogResult.OK)
                richTextBox1.SaveFile(mewael.FileName, RichTextBoxStreamType.PlainText);
            this.Text = mewael.FileName;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = System.DateTime.Now.ToString();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();  
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fnt = new FontDialog();
            if(fnt.ShowDialog() == DialogResult.OK) 
                richTextBox1.Font = fnt.Font;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog fnt = new ColorDialog();
            if (fnt.ShowDialog() == DialogResult.OK)
                richTextBox1.ForeColor = fnt.Color;
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
