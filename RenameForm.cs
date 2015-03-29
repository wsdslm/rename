using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace rename
{
    public partial class RenameForm : Form
    {
        public RenameForm()
        {
            InitializeComponent();
        }

        private void listViewPath_DragDrop(object sender, DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string path in s)
            {
                listViewPath.Items.Add(path).Checked = true;
            }
        }

        private void listViewPath_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void buttonRuleAdd_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text != "")
            {
                listViewRule.Items.Add(new ListViewItem(new string[] { textBoxSearch.Text, textBoxReplace.Text, checkBoxRegex.Checked ? "是" : "否" })).Checked = true;
                textBoxSearch.Text = "";
                textBoxReplace.Text = "";
            }
        }

        private void buttonPreviewClear_Click(object sender, EventArgs e)
        {
            listViewPreview.Items.Clear();
        }

        private void buttonPreviewStart_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewPath.Items)
            {
                string origin = item.Text;
                string newName = rename(origin);
                listViewPreview.Items.Add(new ListViewItem(new string[] { origin, newName }));
            }
        }

        private string rename(string origin)
        {
            string result = origin;
            foreach (ListViewItem item in listViewRule.CheckedItems)
            {
                if (item.SubItems[2].Text.Trim() == "是")
                {
                    result = Regex.Replace(result, @item.SubItems[0].Text, item.SubItems[1].Text);
                }
                else
                {
                    result = result.Replace(@item.SubItems[0].Text, item.SubItems[1].Text);
                }
            }
            return result;
        }

        private void buttonRuleClear_Click(object sender, EventArgs e)
        {
            listViewRule.Items.Clear();
        }

        private void buttonRuleDelete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewRule.SelectedItems)
            {
                item.Remove();
            }
        }

        private void buttonRename_Click(object sender, EventArgs e)
        {
            List<string[]> logList = new List<string[]>();
            if (radioButtonPreview.Checked)
            {
                foreach (ListViewItem item in listViewPreview.Items)
                {
                    string origin = item.SubItems[0].Text;
                    string newName = item.SubItems[1].Text;

                    if (File.Exists(origin))
                    {
                        File.Move(origin, newName);
                    }
                    else
                    {
                        Directory.Move(origin, newName);
                    }

                    logList.Add(new string[2] { origin, newName });
                    listViewResult.Items.Add(new ListViewItem(new string[] { origin, newName }));
                }
            }
            else
            {
                foreach (ListViewItem item in listViewPath.Items)
                {
                    string origin = item.Text;
                    string newName = rename(origin);

                    if (File.Exists(origin))
                    {
                        File.Move(origin, newName);
                    }
                    else
                    {
                        Directory.Move(origin, newName);
                    }

                    logList.Add(new string[2] { origin, newName });
                    listViewResult.Items.Add(new ListViewItem(new string[] { origin, newName }));
                }
            }
            if (checkBoxLog.Checked)
            {
                try
                {
                    string path = Application.StartupPath;
                    string filename = DateTime.Now.ToString("yyyyMMddHHmmss") + ".bak";
                    StreamWriter sw = new StreamWriter(path + "/" + filename);
                    foreach (string[] log in logList)
                    {
                        sw.WriteLine(log[0] + "\t" + log[1]);
                    }
                    sw.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("记录日志失败");
                }

            }
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            StreamWriter sw;
            saveFileDialogLog.FileName = DateTime.Now.ToString("yyyyMMddHHmmss");
            saveFileDialogLog.InitialDirectory = Application.StartupPath;
            if (saveFileDialogLog.ShowDialog() == DialogResult.OK)
            {
                if ((sw = new StreamWriter(saveFileDialogLog.OpenFile())) != null)
                {
                    foreach (ListViewItem item in listViewRule.Items)
                    {
                        sw.WriteLine(item.SubItems[0].Text + "\t" + item.SubItems[1].Text + "\t" + item.SubItems[2].Text);
                    }
                    sw.Close();
                }
            }
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            StreamReader sr;
            try
            {
                if (openFileDialogLog.ShowDialog() == DialogResult.OK)
                {
                    if ((sr = new StreamReader(openFileDialogLog.OpenFile())) != null)
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] cols = Regex.Split(line, "\t");
                            listViewRule.Items.Add(new ListViewItem(new string[] { cols[0], cols[1], cols[2] })).Checked = true;
                        }
                        sr.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("导入出错" + "\r\n" + ex.Message);
            }
        }

        private void buttonBakImport_Click(object sender, EventArgs e)
        {
            StreamReader sr;
            openFileDialogBak.InitialDirectory = Application.StartupPath;
            if (openFileDialogBak.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((sr = new StreamReader(openFileDialogBak.OpenFile())) != null)
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] cols = Regex.Split(line, "\t");
                            listViewBak.Items.Add(new ListViewItem(new string[] { cols[1], cols[0] }));
                        }
                        sr.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("导入出错" + "\r\n" + ex.Message);
                }
            }
        }

        private void buttonBakReturn_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewBak.Items)
            {
                string filename = item.SubItems[0].Text;
                string oldName = item.SubItems[1].Text;
                File.Move(filename, oldName);
            }
            MessageBox.Show("还原完毕");
        }

        private void buttonBakClear_Click(object sender, EventArgs e)
        {
            listViewBak.Items.Clear();
        }
    }
}
