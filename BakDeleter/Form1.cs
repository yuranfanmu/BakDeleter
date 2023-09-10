using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BakDeleter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbBaks_DragEnter(object sender, DragEventArgs e)
        {
            DragDropEffects effects = DragDropEffects.None;
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                var path = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
                if (Directory.Exists(path))
                    effects = DragDropEffects.Copy;
            }

            e.Effect = effects;
        }

        private void lbBaks_DragDrop(object sender, DragEventArgs e)
        {
            lbBaks.Items.Clear();
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] s = (string[])e.Data.GetData(DataFormats.FileDrop);
                lblFolder.Text = s[0];
                string[] allfiles = Directory.GetFiles(s[0], "*.bak", SearchOption.AllDirectories);
                allfiles = allfiles.OrderBy(x => x.Length).ToArray();
                foreach (string file in allfiles)
                {
                    lbBaks.Items.Add(file);
                }
            }
        }

        private void btnDeleteBak_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (string s in lbBaks.Items)
            {
                File.Delete(s);
                i++;
            }
            lbBaks.Items.Clear();
            MessageBox.Show($"Успешно {getWord(i)}", "Успешный успех");
        }

        private string getWord(int i)
        {
            switch (i%10)
            {
                case 1:
                    return $"удален {i} файл";
                case 2:
                    return $"удалено {i} файла";
                case 3:
                    return $"удалено {i} файла";
                case 4:
                    return $"удалено {i} файла";
                default:
                    return $"удалено {i} файлов";
            }
        }

        private void lbBaks_KeyDown(object sender, KeyEventArgs e)
        {
            int n = (sender as ListBox).SelectedIndex;

            if (e.KeyCode == Keys.Delete && lbBaks.Items.Count > 0 && n != -1)
            {
                lbBaks.Items.RemoveAt(n);
            }

        }
    }
}
