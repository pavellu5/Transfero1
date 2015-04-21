using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Transfero
{
    public partial class Connection : Form
    {
        private string path;
        private bool set = true;
        private string group = "";
        private string key = "";
        private string timeout = "4000";
        private Transfer transfer = null;

        public Connection(string path)
        {
            InitializeComponent();
            this.path = path;
        }

        public Connection(string path, Transfer transfer)
        {
            InitializeComponent();
            this.path = path;
            this.transfer = transfer;
        }

        private void Connection_Load(object sender, EventArgs e)
        {

        }

        private void textBoxGroupID_TextChanged(object sender, EventArgs e)
        {
            group = textBoxGroupID.Text;
        }

        private void textBoxCollectionID_TextChanged(object sender, EventArgs e)
        {
            timeout = textBoxCollectionID.Text;
        }

        private void textBoxKey_TextChanged(object sender, EventArgs e)
        {
            key = textBoxKey.Text;
        }

        private void buttonSet_Click(object sender, EventArgs e)
        {
            if (group.Equals(""))
            {
                set = false;
                MessageBox.Show("Group ID must be entered.");
            }
            if (timeout.Equals(""))
            {
                set = false;
                MessageBox.Show("Collection ID must be entered.");
            }
            if (key.Equals(""))
            {
                set = false;
                MessageBox.Show("API Key must be entered.");
            }
            if (set)
            {
                string[] lines = { group, timeout, key };
                System.IO.File.WriteAllLines(path, lines);
                Close();
                if (transfer != null)
                {
                    transfer.refreshZotero();
                }
            }
        }

        public bool getSet()
        {
            return set;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
