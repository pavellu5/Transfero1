using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Transfero
{
    public partial class Transfer : Form
    {
        private Command comm = null;
        private Zotero zotero = null;

        private string usrName = "";
        private string transferLocation = "";
        private ArrayList samplesToTransfer = new ArrayList();

        private string newSampleName = "";
        private string newSampleLocation = "";
        private string newSampleOrigin = "";
        private string newSampleDescription = "";
        private string newSampleWeblink = "";
        
        private string newLocationName = "";

        
        public Transfer()
        {
            InitializeComponent();
        }

        private void Transfer_Load(object sender, EventArgs e)
        {
            comm = new Command();
            zotero = new Zotero();
            LoadOffers();
        }


        private void Transfer_FormClosing(object sender, FormClosingEventArgs e)
        {
            //MessageBox.Show("Closing form and database.");
            comm.Close();
        }

        //NEW TRANSFER FORM
        //loading filter offers list - from locations
        private void LoadOffers()
        {
            filterSamples.Items.Add("All samples");

            ArrayList locations = comm.Reader("select name from locations order by id");
            for (int i = 0; i < locations.Count; i++)
            {
                listOfLocations.Items.Add(locations[i]);
                string filter = "Samples in location " + locations[i];
                filterSamples.Items.Add(filter);
            }
        }

        //load only list of locations
        private void LoadLocations()
        {
            ArrayList locations = comm.Reader("select name from locations order by id");
            for (int i = 0; i < locations.Count; i++)
            {
                listOfLocations.Items.Add(locations[i]);
            }
        }

        //generating list of samples by filtering by locations
        private void filterSamples_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filterSamples.SelectedItem.Equals("All samples"))
            {
                ArrayList values = comm.Reader("select name from samples order by id");
                listOfSamples.Items.Clear();
                for (int i = 0; i < values.Count; i++)
                {
                    listOfSamples.Items.Add(values[i]);
                }
            }
            else
            {
                string filter = filterSamples.GetItemText(filterSamples.SelectedItem);
                filter = filter.Remove(0, 20);

                ArrayList values = comm.Reader("select name from samples where current_location = '" + filter + "'order by id");
                listOfSamples.Items.Clear();
                for (int i = 0; i < values.Count; i++)
                {
                    listOfSamples.Items.Add(values[i]);
                }
                listOfLocations.Items.Clear();
                LoadLocations();
                listOfLocations.Items.Remove(filter);
                listOfLocations.Text = "--select location";
                label2.Text = "";
            }
        }

        //select sample by doubleclick and add it to list of selected samples
        private void listOfSamples_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string sample = listOfSamples.GetItemText(listOfSamples.SelectedItem);
            samplesToTransfer.Add(sample);
            selectedSamples.Items.Add(sample);
        }

        //select location from list and writing it to label
        private void listOfLocations_SelectedIndexChanged(object sender, EventArgs e)
        {
            string location = listOfLocations.GetItemText(listOfLocations.SelectedItem);
            transferLocation = location;
            label2.Text = location;
        }

        //getting username from textbox
        private void username_TextChanged(object sender, EventArgs e)
        {
            usrName = username.Text;
        }

        //buttonclick DO TRANSFER - create new transfer record to database
        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (usrName.Equals("") || samplesToTransfer.Count == 0 || transferLocation.Equals(""))
            {
                MessageBox.Show("All fields must be filled.");
            }
            else
            {
                bool succ = true;
                for (int i = 0; i < samplesToTransfer.Count; i++)
                {
                    string transferedSampleName = "" + samplesToTransfer[i];
                    string collectionKey = comm.GetCollectionKey(transferLocation);
                    string itemKey = comm.GetItemKey(transferedSampleName);
                    bool run = zotero.Transfer(itemKey, collectionKey);
                    if (!run)
                    {
                        succ = false;
                        MessageBox.Show("Conection to Zotero isn't working.\rCheck internet connection.");
                        break;
                    }
                    else
                    {
                        bool transfer = comm.NewTransfer(usrName, transferedSampleName, transferLocation);
                        if (!transfer)
                        {
                            MessageBox.Show("Transfer of sample " + transferedSampleName + " failed.");
                            succ = false;
                        }
                    }
                }
                if (succ)
                    MessageBox.Show("All transfers were succesfull.");
            }
        }

        //buttonclick Clear - clear all lists
        private void buttonStorno_Click(object sender, EventArgs e)
        {
            username.Clear();
            listOfSamples.Items.Clear();
            selectedSamples.Items.Clear();

            filterSamples.Text = "--select filter";
            listOfLocations.Text = "--select location";
            label2.Text = "";
        }


        //MENU ACTIONS
        //New Item
        private void newSampleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBoxSampleLocation.Items.Clear();
            ArrayList locations = comm.Reader("select name from locations order by id");
            for (int i = 0; i < locations.Count; i++)
            {
                comboBoxSampleLocation.Items.Add(locations[i]);
            }

            panelNewSample.Visible = true;
            panelNewLocation.Visible = false;
            panelData.Visible = false;
        }

        private void newLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelNewSample.Visible = true;
            panelNewLocation.Visible = true;
            panelData.Visible = false;
        }

        private void newTransferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelNewSample.Visible = false;
            panelNewLocation.Visible = false;
            panelData.Visible = false;
        }

        //Settings
        //zotero API connection settings
        private void zoteroConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Connection conn = new Connection(zotero.GetPath());
            conn.Show();
            if (!zotero.LoadConnection())
            {
                MessageBox.Show("Unsuccessful loading of connection.");
            }
        }
        //open delete manager
        private void deteleManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //Data
        private void showDataToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panelNewSample.Visible = true;
            panelNewLocation.Visible = true;
            panelData.Visible = true;
        }


        //NEW SAMPLE FORM
        //getting properties of sample
        private void textBoxNameSample_TextChanged(object sender, EventArgs e)
        {
            newSampleName = textBoxNameSample.Text;
        }

        private void textBoxSampleOrigin_TextChanged(object sender, EventArgs e)
        {
            newSampleOrigin = textBoxSampleOrigin.Text;
        }

        private void comboBoxSampleLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            newSampleLocation = comboBoxSampleLocation.GetItemText(comboBoxSampleLocation.SelectedItem);
        }

        private void textBoxSampleDescription_TextChanged(object sender, EventArgs e)
        {
            newSampleDescription = textBoxSampleDescription.Text;
        }

        private void textBoxSampleWeblink_TextChanged(object sender, EventArgs e)
        {
            newSampleWeblink = textBoxSampleWeblink.Text;
        }
        
        //buttonclick Add - add sample to database
        private void buttonAddSample_Click(object sender, EventArgs e)
        {
            if (newSampleName.Equals("") || newSampleLocation.Equals("") || newSampleOrigin.Equals("") || newSampleOrigin.Equals("") || newSampleWeblink.Equals(""))
            {
                MessageBox.Show("All fields must be filled.");
            }
            else
            {
                string collectionKey = comm.GetCollectionKey(newSampleLocation);
                string itemKey = zotero.NewSample(newSampleName, newSampleLocation, newSampleOrigin, newSampleDescription, newSampleWeblink, collectionKey);
                bool succ = false;
                if (itemKey.Equals(""))
                {
                    MessageBox.Show("Conection to Zotero isn't working.\rCheck internet connection.");
                }
                else
                {
                    succ = comm.NewSample(itemKey, newSampleName, newSampleLocation, newSampleOrigin, newSampleDescription, newSampleWeblink);
                }
                if (succ)
                    MessageBox.Show("Sample was added.");
                else
                    MessageBox.Show("Adding failed.");

                textBoxNameSample.Clear();
                textBoxSampleOrigin.Clear();
                comboBoxSampleLocation.Text = "";
                textBoxSampleDescription.Clear();
                textBoxSampleWeblink.Clear();
            }
        }

        //buttonclick Storno - close New sample panel
        private void buttonStornoSample_Click(object sender, EventArgs e)
        {
            panelNewSample.Visible = false;
        }


        //NEW LOCATION FORM
        //geting location properties
        private void textBoxNameLocation_TextChanged(object sender, EventArgs e)
        {
            newLocationName = textBoxNameLocation.Text;
        }

        //buttonclick Add - add location to database
        private void buttonAddLocation_Click(object sender, EventArgs e)
        {
            if (newLocationName.Equals(""))
            {
                MessageBox.Show("Location name must be entered.");
            }
            else
            {
                string collectionKey = zotero.NewLocation(newLocationName);
                bool succ = false;
                if (collectionKey.Equals(""))
                {
                    MessageBox.Show("Conection to Zotero isn't working.\rCheck internet connection.");
                }
                else
                {
                    succ = comm.NewLocation(collectionKey, newLocationName);
                }
                if (succ)
                    MessageBox.Show("Location was added.");
                else
                    MessageBox.Show("Adding failed.");
                
                textBoxNameLocation.Clear();
                
            }
        }

        private void buttonStornoLocation_Click(object sender, EventArgs e)
        {
            textBoxNameLocation.Clear();
            panelNewSample.Visible = false;
            panelNewLocation.Visible = false;
        }

        //SHOW DATA
        private void buttonDataShow_Click(object sender, EventArgs e)
        {
            DataTable data = comm.GetData("select * from samples");
            if (data.Rows.Count > 0)
            {
                dataGridView1.DataSource = data;
            }
            else
            {
                MessageBox.Show("No Data Exist in Table");
            }
        }

        private void buttonDataStorno_Click(object sender, EventArgs e)
        {
            panelNewSample.Visible = false;
            panelNewLocation.Visible = false;
            panelData.Visible = false;
        }




    }
}
