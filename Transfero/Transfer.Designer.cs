namespace Transfero
{
    partial class Transfer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.filterSamples = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listOfSamples = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newSampleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTransferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoteroConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deteleManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showDataToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectedSamples = new System.Windows.Forms.ListBox();
            this.username = new System.Windows.Forms.TextBox();
            this.listOfLocations = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonStorno = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelNewSample = new System.Windows.Forms.Panel();
            this.panelNewLocation = new System.Windows.Forms.Panel();
            this.panelData = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonDataShow = new System.Windows.Forms.Button();
            this.buttonDataStorno = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxNameLocation = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonAddLocation = new System.Windows.Forms.Button();
            this.buttonStornoLocation = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxSampleWeblink = new System.Windows.Forms.TextBox();
            this.textBoxSampleDescription = new System.Windows.Forms.TextBox();
            this.textBoxSampleOrigin = new System.Windows.Forms.TextBox();
            this.textBoxNameSample = new System.Windows.Forms.TextBox();
            this.comboBoxSampleLocation = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonAddSample = new System.Windows.Forms.Button();
            this.buttonStornoSample = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panelNewSample.SuspendLayout();
            this.panelNewLocation.SuspendLayout();
            this.panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // filterSamples
            // 
            this.filterSamples.FormattingEnabled = true;
            this.filterSamples.Location = new System.Drawing.Point(25, 96);
            this.filterSamples.Name = "filterSamples";
            this.filterSamples.Size = new System.Drawing.Size(174, 21);
            this.filterSamples.TabIndex = 0;
            this.filterSamples.Text = "--select filter";
            this.filterSamples.SelectedIndexChanged += new System.EventHandler(this.filterSamples_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(159, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "New transfer";
            // 
            // listOfSamples
            // 
            this.listOfSamples.FormattingEnabled = true;
            this.listOfSamples.Location = new System.Drawing.Point(25, 123);
            this.listOfSamples.Name = "listOfSamples";
            this.listOfSamples.Size = new System.Drawing.Size(173, 95);
            this.listOfSamples.TabIndex = 2;
            this.listOfSamples.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listOfSamples_MouseDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.showDataToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(483, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newSampleToolStripMenuItem,
            this.newLocationToolStripMenuItem,
            this.newTransferToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.newToolStripMenuItem.Text = "New";
            // 
            // newSampleToolStripMenuItem
            // 
            this.newSampleToolStripMenuItem.Name = "newSampleToolStripMenuItem";
            this.newSampleToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.newSampleToolStripMenuItem.Text = "New Sample";
            this.newSampleToolStripMenuItem.Click += new System.EventHandler(this.newSampleToolStripMenuItem_Click);
            // 
            // newLocationToolStripMenuItem
            // 
            this.newLocationToolStripMenuItem.Name = "newLocationToolStripMenuItem";
            this.newLocationToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.newLocationToolStripMenuItem.Text = "New Location";
            this.newLocationToolStripMenuItem.Click += new System.EventHandler(this.newLocationToolStripMenuItem_Click);
            // 
            // newTransferToolStripMenuItem
            // 
            this.newTransferToolStripMenuItem.Name = "newTransferToolStripMenuItem";
            this.newTransferToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.newTransferToolStripMenuItem.Text = "New Transfer";
            this.newTransferToolStripMenuItem.Click += new System.EventHandler(this.newTransferToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoteroConnectionToolStripMenuItem,
            this.deteleManagerToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // zoteroConnectionToolStripMenuItem
            // 
            this.zoteroConnectionToolStripMenuItem.Name = "zoteroConnectionToolStripMenuItem";
            this.zoteroConnectionToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.zoteroConnectionToolStripMenuItem.Text = "Zotero Connection";
            this.zoteroConnectionToolStripMenuItem.Click += new System.EventHandler(this.zoteroConnectionToolStripMenuItem_Click);
            // 
            // deteleManagerToolStripMenuItem
            // 
            this.deteleManagerToolStripMenuItem.Name = "deteleManagerToolStripMenuItem";
            this.deteleManagerToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.deteleManagerToolStripMenuItem.Text = "Detele Manager";
            this.deteleManagerToolStripMenuItem.Click += new System.EventHandler(this.deteleManagerToolStripMenuItem_Click);
            // 
            // showDataToolStripMenuItem
            // 
            this.showDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDataToolStripMenuItem1});
            this.showDataToolStripMenuItem.Name = "showDataToolStripMenuItem";
            this.showDataToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.showDataToolStripMenuItem.Text = "Data";
            // 
            // showDataToolStripMenuItem1
            // 
            this.showDataToolStripMenuItem1.Name = "showDataToolStripMenuItem1";
            this.showDataToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.showDataToolStripMenuItem1.Text = "Show data";
            this.showDataToolStripMenuItem1.Click += new System.EventHandler(this.showDataToolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // selectedSamples
            // 
            this.selectedSamples.FormattingEnabled = true;
            this.selectedSamples.Location = new System.Drawing.Point(270, 123);
            this.selectedSamples.Name = "selectedSamples";
            this.selectedSamples.Size = new System.Drawing.Size(170, 95);
            this.selectedSamples.TabIndex = 4;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(270, 96);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(100, 20);
            this.username.TabIndex = 5;
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // listOfLocations
            // 
            this.listOfLocations.FormattingEnabled = true;
            this.listOfLocations.Location = new System.Drawing.Point(25, 255);
            this.listOfLocations.Name = "listOfLocations";
            this.listOfLocations.Size = new System.Drawing.Size(174, 21);
            this.listOfLocations.TabIndex = 6;
            this.listOfLocations.Text = "--select location";
            this.listOfLocations.SelectedIndexChanged += new System.EventHandler(this.listOfLocations_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 7;
            // 
            // buttonStorno
            // 
            this.buttonStorno.Location = new System.Drawing.Point(396, 325);
            this.buttonStorno.Name = "buttonStorno";
            this.buttonStorno.Size = new System.Drawing.Size(75, 23);
            this.buttonStorno.TabIndex = 8;
            this.buttonStorno.Text = "Clear all";
            this.buttonStorno.UseVisualStyleBackColor = true;
            this.buttonStorno.Click += new System.EventHandler(this.buttonStorno_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(315, 325);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 9;
            this.buttonOk.Text = "Do transfer";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(267, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(23, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Select samples";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(23, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Select location";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(267, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Selected location";
            // 
            // panelNewSample
            // 
            this.panelNewSample.Controls.Add(this.panelNewLocation);
            this.panelNewSample.Controls.Add(this.label15);
            this.panelNewSample.Controls.Add(this.label14);
            this.panelNewSample.Controls.Add(this.label13);
            this.panelNewSample.Controls.Add(this.label10);
            this.panelNewSample.Controls.Add(this.label9);
            this.panelNewSample.Controls.Add(this.textBoxSampleWeblink);
            this.panelNewSample.Controls.Add(this.textBoxSampleDescription);
            this.panelNewSample.Controls.Add(this.textBoxSampleOrigin);
            this.panelNewSample.Controls.Add(this.textBoxNameSample);
            this.panelNewSample.Controls.Add(this.comboBoxSampleLocation);
            this.panelNewSample.Controls.Add(this.label11);
            this.panelNewSample.Controls.Add(this.label12);
            this.panelNewSample.Controls.Add(this.buttonAddSample);
            this.panelNewSample.Controls.Add(this.buttonStornoSample);
            this.panelNewSample.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNewSample.Location = new System.Drawing.Point(0, 24);
            this.panelNewSample.Name = "panelNewSample";
            this.panelNewSample.Size = new System.Drawing.Size(483, 336);
            this.panelNewSample.TabIndex = 14;
            this.panelNewSample.Visible = false;
            // 
            // panelNewLocation
            // 
            this.panelNewLocation.Controls.Add(this.panelData);
            this.panelNewLocation.Controls.Add(this.label8);
            this.panelNewLocation.Controls.Add(this.textBoxNameLocation);
            this.panelNewLocation.Controls.Add(this.label7);
            this.panelNewLocation.Controls.Add(this.buttonAddLocation);
            this.panelNewLocation.Controls.Add(this.buttonStornoLocation);
            this.panelNewLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNewLocation.Location = new System.Drawing.Point(0, 0);
            this.panelNewLocation.Name = "panelNewLocation";
            this.panelNewLocation.Size = new System.Drawing.Size(483, 336);
            this.panelNewLocation.TabIndex = 37;
            this.panelNewLocation.Visible = false;
            // 
            // panelData
            // 
            this.panelData.Controls.Add(this.dataGridView1);
            this.panelData.Controls.Add(this.buttonDataShow);
            this.panelData.Controls.Add(this.buttonDataStorno);
            this.panelData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelData.Location = new System.Drawing.Point(0, 0);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(483, 336);
            this.panelData.TabIndex = 20;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(459, 224);
            this.dataGridView1.TabIndex = 4;
            // 
            // buttonDataShow
            // 
            this.buttonDataShow.Location = new System.Drawing.Point(315, 301);
            this.buttonDataShow.Name = "buttonDataShow";
            this.buttonDataShow.Size = new System.Drawing.Size(75, 23);
            this.buttonDataShow.TabIndex = 3;
            this.buttonDataShow.Text = "Show";
            this.buttonDataShow.UseVisualStyleBackColor = true;
            this.buttonDataShow.Click += new System.EventHandler(this.buttonDataShow_Click);
            // 
            // buttonDataStorno
            // 
            this.buttonDataStorno.Location = new System.Drawing.Point(396, 301);
            this.buttonDataStorno.Name = "buttonDataStorno";
            this.buttonDataStorno.Size = new System.Drawing.Size(75, 23);
            this.buttonDataStorno.TabIndex = 2;
            this.buttonDataStorno.Text = "Storno";
            this.buttonDataStorno.UseVisualStyleBackColor = true;
            this.buttonDataStorno.Click += new System.EventHandler(this.buttonDataStorno_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(35, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Name";
            // 
            // textBoxNameLocation
            // 
            this.textBoxNameLocation.Location = new System.Drawing.Point(35, 73);
            this.textBoxNameLocation.Multiline = true;
            this.textBoxNameLocation.Name = "textBoxNameLocation";
            this.textBoxNameLocation.Size = new System.Drawing.Size(135, 20);
            this.textBoxNameLocation.TabIndex = 18;
            this.textBoxNameLocation.TextChanged += new System.EventHandler(this.textBoxNameLocation_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(159, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "New location";
            // 
            // buttonAddLocation
            // 
            this.buttonAddLocation.Location = new System.Drawing.Point(315, 301);
            this.buttonAddLocation.Name = "buttonAddLocation";
            this.buttonAddLocation.Size = new System.Drawing.Size(75, 23);
            this.buttonAddLocation.TabIndex = 1;
            this.buttonAddLocation.Text = "Add location";
            this.buttonAddLocation.UseVisualStyleBackColor = true;
            this.buttonAddLocation.Click += new System.EventHandler(this.buttonAddLocation_Click);
            // 
            // buttonStornoLocation
            // 
            this.buttonStornoLocation.Location = new System.Drawing.Point(396, 301);
            this.buttonStornoLocation.Name = "buttonStornoLocation";
            this.buttonStornoLocation.Size = new System.Drawing.Size(75, 23);
            this.buttonStornoLocation.TabIndex = 0;
            this.buttonStornoLocation.Text = "Storno";
            this.buttonStornoLocation.UseVisualStyleBackColor = true;
            this.buttonStornoLocation.Click += new System.EventHandler(this.buttonStornoLocation_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(38, 234);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 13);
            this.label15.TabIndex = 36;
            this.label15.Text = "Weblink";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(38, 128);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 13);
            this.label14.TabIndex = 36;
            this.label14.Text = "Desctiption";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(38, 83);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 13);
            this.label13.TabIndex = 36;
            this.label13.Text = "Current location";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(257, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Origin";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(38, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Name";
            // 
            // textBoxSampleWeblink
            // 
            this.textBoxSampleWeblink.Location = new System.Drawing.Point(41, 250);
            this.textBoxSampleWeblink.Name = "textBoxSampleWeblink";
            this.textBoxSampleWeblink.Size = new System.Drawing.Size(384, 20);
            this.textBoxSampleWeblink.TabIndex = 35;
            this.textBoxSampleWeblink.TextChanged += new System.EventHandler(this.textBoxSampleWeblink_TextChanged);
            // 
            // textBoxSampleDescription
            // 
            this.textBoxSampleDescription.Location = new System.Drawing.Point(41, 144);
            this.textBoxSampleDescription.Multiline = true;
            this.textBoxSampleDescription.Name = "textBoxSampleDescription";
            this.textBoxSampleDescription.Size = new System.Drawing.Size(384, 81);
            this.textBoxSampleDescription.TabIndex = 34;
            this.textBoxSampleDescription.TextChanged += new System.EventHandler(this.textBoxSampleDescription_TextChanged);
            // 
            // textBoxSampleOrigin
            // 
            this.textBoxSampleOrigin.Location = new System.Drawing.Point(260, 76);
            this.textBoxSampleOrigin.Multiline = true;
            this.textBoxSampleOrigin.Name = "textBoxSampleOrigin";
            this.textBoxSampleOrigin.Size = new System.Drawing.Size(165, 44);
            this.textBoxSampleOrigin.TabIndex = 33;
            this.textBoxSampleOrigin.TextChanged += new System.EventHandler(this.textBoxSampleOrigin_TextChanged);
            // 
            // textBoxNameSample
            // 
            this.textBoxNameSample.Location = new System.Drawing.Point(41, 58);
            this.textBoxNameSample.Name = "textBoxNameSample";
            this.textBoxNameSample.Size = new System.Drawing.Size(100, 20);
            this.textBoxNameSample.TabIndex = 32;
            this.textBoxNameSample.TextChanged += new System.EventHandler(this.textBoxNameSample_TextChanged);
            // 
            // comboBoxSampleLocation
            // 
            this.comboBoxSampleLocation.FormattingEnabled = true;
            this.comboBoxSampleLocation.Location = new System.Drawing.Point(41, 99);
            this.comboBoxSampleLocation.Name = "comboBoxSampleLocation";
            this.comboBoxSampleLocation.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSampleLocation.TabIndex = 31;
            this.comboBoxSampleLocation.SelectedIndexChanged += new System.EventHandler(this.comboBoxSampleLocation_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(267, 240);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(159, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 25);
            this.label12.TabIndex = 16;
            this.label12.Text = "New sample";
            // 
            // buttonAddSample
            // 
            this.buttonAddSample.Location = new System.Drawing.Point(315, 301);
            this.buttonAddSample.Name = "buttonAddSample";
            this.buttonAddSample.Size = new System.Drawing.Size(75, 23);
            this.buttonAddSample.TabIndex = 1;
            this.buttonAddSample.Text = "Add sample";
            this.buttonAddSample.UseVisualStyleBackColor = true;
            this.buttonAddSample.Click += new System.EventHandler(this.buttonAddSample_Click);
            // 
            // buttonStornoSample
            // 
            this.buttonStornoSample.Location = new System.Drawing.Point(396, 301);
            this.buttonStornoSample.Name = "buttonStornoSample";
            this.buttonStornoSample.Size = new System.Drawing.Size(75, 23);
            this.buttonStornoSample.TabIndex = 0;
            this.buttonStornoSample.Text = "Storno";
            this.buttonStornoSample.UseVisualStyleBackColor = true;
            this.buttonStornoSample.Click += new System.EventHandler(this.buttonStornoSample_Click);
            // 
            // Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 360);
            this.Controls.Add(this.panelNewSample);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonStorno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listOfLocations);
            this.Controls.Add(this.username);
            this.Controls.Add(this.selectedSamples);
            this.Controls.Add(this.listOfSamples);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filterSamples);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Transfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transfero";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Transfer_FormClosing);
            this.Load += new System.EventHandler(this.Transfer_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelNewSample.ResumeLayout(false);
            this.panelNewSample.PerformLayout();
            this.panelNewLocation.ResumeLayout(false);
            this.panelNewLocation.PerformLayout();
            this.panelData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox filterSamples;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listOfSamples;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ListBox selectedSamples;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.ComboBox listOfLocations;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonStorno;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem newTransferToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newSampleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newLocationToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelNewSample;
        private System.Windows.Forms.Button buttonAddSample;
        private System.Windows.Forms.Button buttonStornoSample;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxSampleWeblink;
        private System.Windows.Forms.TextBox textBoxSampleDescription;
        private System.Windows.Forms.TextBox textBoxSampleOrigin;
        private System.Windows.Forms.TextBox textBoxNameSample;
        private System.Windows.Forms.ComboBox comboBoxSampleLocation;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panelNewLocation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxNameLocation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonAddLocation;
        private System.Windows.Forms.Button buttonStornoLocation;
        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.Button buttonDataShow;
        private System.Windows.Forms.Button buttonDataStorno;
        private System.Windows.Forms.ToolStripMenuItem showDataToolStripMenuItem1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoteroConnectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deteleManagerToolStripMenuItem;
    }
}

