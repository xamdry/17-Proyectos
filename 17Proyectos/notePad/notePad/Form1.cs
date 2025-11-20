namespace notePad
{
    public partial class frmMain : Form
    {
        string ourFileName;
        string lastFindWord;
        bool lastFindDown;
        bool lastfindMatchCase;

        void DoSave(string filename)
        {
            ourFileName = filename;
            textBox1.SaveFile(filename);
        }

        void DoSaveAs()
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                DoSave(saveFileDialog1.FileName);
            }
        }
        public frmMain()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText = "";
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFile find = new frmFile();
            find.Show(this);
        }

        public void DoFind(string search, bool down, bool match_case)
        {
            lastFindWord = search;
            lastFindDown = down;
            lastfindMatchCase = match_case;

            if (string.IsNullOrEmpty(search))
            {
                MessageBox.Show("Por favor ingresa un texto para buscar.",
                    "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int startIndex = textBox1.SelectionStart + textBox1.SelectionLength;

            if (down)
            {
                // Buscar hacia abajo
                if (match_case)
                {
                    int index = textBox1.Find(search, startIndex, RichTextBoxFinds.MatchCase);
                    if (index == -1)
                    {
                        MessageBox.Show("No se encontraron más coincidencias.",
                            "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    int index = textBox1.Find(search, startIndex, RichTextBoxFinds.None);
                    if (index == -1)
                    {
                        MessageBox.Show("No se encontraron más coincidencias.",
                            "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                // Buscar hacia arriba
                if (match_case)
                {
                    int index = textBox1.Find(search, 0, startIndex, RichTextBoxFinds.Reverse | RichTextBoxFinds.MatchCase);
                    if (index == -1)
                    {
                        MessageBox.Show("No se encontraron más coincidencias.",
                            "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    int index = textBox1.Find(search, 0, startIndex, RichTextBoxFinds.Reverse);
                    if (index == -1)
                    {
                        MessageBox.Show("No se encontraron más coincidencias.",
                            "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void findNextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lastFindWord))
            {
                DoFind(lastFindWord, lastFindDown, lastfindMatchCase);
            }
            else
            {
                // Si no hay búsqueda previa, abrir el diálogo de búsqueda
                findToolStripMenuItem_Click(sender, e);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CheckChanges())
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    textBox1.LoadFile(openFileDialog1.FileName);

                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ourFileName))
            {
                DoSaveAs();
            }
            else
            {
                DoSave(ourFileName);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SaveFile("save as file");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool CheckChanges()
        {
            // Verificar si hay cambios sin guardar
            if (textBox1.Modified)
            {
                DialogResult result = MessageBox.Show(
                    "¿Deseas guardar los cambios?",
                    "Notepad",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(this, EventArgs.Empty);
                    return true;
                }
                else if (result == DialogResult.No)
                {
                    return true;
                }
                else // Cancel
                {
                    return false;
                }
            }
            return true;
        }
    }
}
