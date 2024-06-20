namespace DeviceBackupLoader
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            dataToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            infoToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            label4 = new Label();
            listBox1 = new ListBox();
            checkBox1 = new CheckBox();
            SelectedFolderFromLabel = new Label();
            button1 = new Button();
            label1 = new Label();
            panel3 = new Panel();
            button3 = new Button();
            CurrentFileLabel = new Label();
            progressBar1 = new ProgressBar();
            label3 = new Label();
            button2 = new Button();
            label2 = new Label();
            SelectedFolderToLabel = new Label();
            panel2 = new Panel();
            checkBox2 = new CheckBox();
            label5 = new Label();
            listBox2 = new ListBox();
            checkBox3 = new CheckBox();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { dataToolStripMenuItem, settingsToolStripMenuItem, infoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(944, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // dataToolStripMenuItem
            // 
            dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            dataToolStripMenuItem.Size = new Size(43, 20);
            dataToolStripMenuItem.Text = "Data";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(61, 20);
            settingsToolStripMenuItem.Text = "Settings";
            settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
            // 
            // infoToolStripMenuItem
            // 
            infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            infoToolStripMenuItem.Size = new Size(40, 20);
            infoToolStripMenuItem.Text = "Info";
            infoToolStripMenuItem.Click += infoToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(checkBox3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(SelectedFolderFromLabel);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(920, 253);
            panel1.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(495, 0);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 6;
            label4.Text = "Found Files";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(495, 15);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(424, 229);
            listBox1.TabIndex = 5;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(3, 94);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(138, 19);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Include lower Folders";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // SelectedFolderFromLabel
            // 
            SelectedFolderFromLabel.AutoSize = true;
            SelectedFolderFromLabel.Location = new Point(3, 60);
            SelectedFolderFromLabel.Name = "SelectedFolderFromLabel";
            SelectedFolderFromLabel.Size = new Size(126, 15);
            SelectedFolderFromLabel.TabIndex = 3;
            SelectedFolderFromLabel.Text = "Selected Folder: NONE";
            // 
            // button1
            // 
            button1.Location = new Point(3, 34);
            button1.Name = "button1";
            button1.Size = new Size(122, 23);
            button1.TabIndex = 1;
            button1.Text = "Select Folder";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 0;
            label1.Text = "From";
            // 
            // panel3
            // 
            panel3.Controls.Add(button3);
            panel3.Controls.Add(CurrentFileLabel);
            panel3.Controls.Add(progressBar1);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(12, 545);
            panel3.Name = "panel3";
            panel3.Size = new Size(920, 110);
            panel3.TabIndex = 4;
            // 
            // button3
            // 
            button3.Location = new Point(786, 6);
            button3.Name = "button3";
            button3.Size = new Size(130, 23);
            button3.TabIndex = 3;
            button3.Text = "Backup Files";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // CurrentFileLabel
            // 
            CurrentFileLabel.AutoSize = true;
            CurrentFileLabel.Location = new Point(4, 58);
            CurrentFileLabel.Name = "CurrentFileLabel";
            CurrentFileLabel.Size = new Size(0, 15);
            CurrentFileLabel.TabIndex = 2;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(3, 32);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(913, 23);
            progressBar1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 14);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 0;
            label3.Text = "Progess";
            // 
            // button2
            // 
            button2.Location = new Point(3, 30);
            button2.Name = "button2";
            button2.Size = new Size(122, 23);
            button2.TabIndex = 4;
            button2.Text = "Select Folder";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(19, 15);
            label2.TabIndex = 1;
            label2.Text = "To";
            // 
            // SelectedFolderToLabel
            // 
            SelectedFolderToLabel.AutoSize = true;
            SelectedFolderToLabel.Location = new Point(3, 56);
            SelectedFolderToLabel.Name = "SelectedFolderToLabel";
            SelectedFolderToLabel.Size = new Size(126, 15);
            SelectedFolderToLabel.TabIndex = 5;
            SelectedFolderToLabel.Text = "Selected Folder: NONE";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(checkBox2);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(listBox2);
            panel2.Controls.Add(SelectedFolderToLabel);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(12, 286);
            panel2.Name = "panel2";
            panel2.Size = new Size(920, 253);
            panel2.TabIndex = 3;
            panel2.Tag = "To";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(3, 100);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(135, 19);
            checkBox2.TabIndex = 9;
            checkBox2.Text = "Clear selected Folder";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(491, 4);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 8;
            label5.Text = "Found Files";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(491, 19);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(424, 229);
            listBox2.TabIndex = 7;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(3, 119);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(71, 19);
            checkBox3.TabIndex = 7;
            checkBox3.Text = "Cut Files";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 667);
            Controls.Add(panel3);
            Controls.Add(menuStrip1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem dataToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem infoToolStripMenuItem;
        private Panel panel1;
        private Panel panel3;
        private Label label1;
        private Label CurrentFileLabel;
        private ProgressBar progressBar1;
        private Label label3;
        private Label SelectedFolderFromLabel;
        private Button button1;
        private CheckBox checkBox1;
        private Button button2;
        private Label label2;
        private Label SelectedFolderToLabel;
        private Panel panel2;
        private Button button3;
        private Label label4;
        private ListBox listBox1;
        private Label label5;
        private ListBox listBox2;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
    }
}
