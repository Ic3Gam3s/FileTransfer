using System.Runtime.CompilerServices;
using System.Xml.Serialization;


namespace DeviceBackupLoader
{
    public partial class Form1 : Form
    {
        String fromFolderString = "";
        String toFolderString = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
            this.Enabled = settingsForm.Enabled!;
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String temp = SelectFolderPath();

            toFolderString = temp;
            this.SelectedFolderToLabel.Text = "Selected Path: " + toFolderString;

            updateFileList(toFolderString, listBox2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String temp = SelectFolderPath();

            fromFolderString = temp;
            this.SelectedFolderFromLabel.Text = "Selected Path: " + fromFolderString;

            updateFileList(fromFolderString, listBox1);
        }

        private String[] GetFilesFromPath(String path, bool useLowerFolders)
        {
            return useLowerFolders ? Directory.GetFiles(path, "*.*", SearchOption.AllDirectories) : Directory.GetFiles(path);
        }

        private void updateFileList(String path, ListBox listBox)
        {
            listBox.Items.Clear();

            String[] files = GetFilesFromPath(path , true);
            foreach (String item in files)
            {
                int index = item.IndexOf(path);
                String cleanItem = item.Replace(path, "");
                listBox.Items.Add(cleanItem);
            }
        }

        private String SelectFolderPath()
        {
            using (var fdb = new FolderBrowserDialog())
            {
                DialogResult result = fdb.ShowDialog();

                if (result == DialogResult.OK && fdb.SelectedPath != "")
                {
                    return fdb.SelectedPath;
                }
                else
                {
                    return "";
                }
            }
        }

        private void CopyFilesRecursively(string sourcePath, string targetPath)
        {
            progressBar1.Equals(0);

            if (sourcePath.Equals(targetPath))
            {
                MessageBox.Show("Source Path equals Target Path\nStopping Backup", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // If ALL FILES should be Backed up, Delete and create new Directory
            if (this.checkBox2.Checked)
            {
                Directory.Delete(targetPath, true);
                Directory.CreateDirectory(targetPath);
            }

            progressBar1.Maximum = GetFilesFromPath(sourcePath, this.checkBox1.Checked).Length;
            progressBar1.Step = 1;

            if (this.checkBox1.Checked)
            {
                //Now Create all of the directories
                foreach (string dirPath in Directory.GetDirectories(sourcePath, "*", SearchOption.AllDirectories))
                {
                    Directory.CreateDirectory(dirPath.Replace(sourcePath, targetPath));
                }

                //Copy all the files & Replaces any files with the same name
                foreach (string newPath in Directory.GetFiles(sourcePath, "*.*", SearchOption.AllDirectories))
                {
                    progressBar1.PerformStep();
                    File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);

                    if (checkBox3.Checked)
                    {
                        File.Delete(newPath);
                    }
                }
            }
            else
            {
                //Copy all the files & Replaces any files with the same name
                foreach (string newPath in Directory.GetFiles(sourcePath))
                {
                    progressBar1.PerformStep();
                    File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);

                    if (checkBox3.Checked)
                    {
                        File.Delete(newPath);
                    }
                }
            }


            updateFileList(fromFolderString, listBox1);
            updateFileList(toFolderString, listBox2);

            MessageBox.Show("Copied " + progressBar1.Maximum + " Files\n  from " + sourcePath + "\nto " + targetPath , "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            progressBar1.Equals(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CopyFilesRecursively(fromFolderString, toFolderString);
        }
    }
}
