using OSIsoft.AF;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static OSIsoft.AF.Analysis.AFAnalysisService;

namespace AFUtility_UI01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AFServerName_Changed(object sender, EventArgs e)
        {
            AnalysisQ.AFServerName = AFServerName.Text;
        }

        private void AnalysisName_Changed(object sender, EventArgs e)
        {
            AnalysisQ.AnalysisName = AnalysisName.Text;
        }

        private void Path_Changed(object sender, EventArgs e)
        {
            AnalysisQ.Path = Path.Text;
        }

        private void AnalysisRunningStatus_Changed(object sender, EventArgs e)
        {
            AnalysisQ.RunningStatus = AnalysisRunningStatus.Text;
        }

        private void SortBy_Changed(object sender, EventArgs e)
        {
            AnalysisQ.SortBy = (string)comboBox_SortBy.SelectedItem;
            comboBox_SortBy.ForeColor = Color.Black;
        }

        private void MaxCount_TextChanged(object sender, EventArgs e)
        {
            AnalysisQ.MaxCount = MaxCount.Text;
        }

        private void QueryRunTime(object sender, EventArgs e)
        {
            tablequeryresults.Rows.Clear();

            //Gary: originally is using "AFServerName.Text", changed it into "AnalysisQ.AFServerName"
            //both are working fine, but since we have already assigned the text into variable, should be using it
            PISystems AFServers = new PISystems();
            var AFServer = AFServers[AnalysisQ.AFServerName];

            if (AFServerName.Text.Trim() == string.Empty)
            {
                //Gary: 
                AFServer = AFServers.DefaultPISystem;
                AFServerName.Text = AFServer.Name;
                MessageBox.Show("AF Server Name is empty. Default AF Server will be used: " + AFServerName.Text, "Info", MessageBoxButtons.OK);
                //return; // return because we don't want to run normal code of button click
            }

            var analysisService = AFServer.AnalysisService;


            //Gary: just listing the options can be used in the "query":
            //System.InvalidOperationException: 'Invalid query: Unsupported field 'XXX'. Only 'id, name, category, description,
            //elementname, template, path, status, statusdetail, lastevaluationstatus, lastevaluationstatusdetail, lastlag, averagelag,
            //lastelapsed, averageelapsed, lasttriggertime, averagetrigger, successcount, errorcount, skipcount, sortby, sortorder, maxcount' are supported..'

            //Gary: radioButton are been used to select Basic or Advanced Filter
            //we need to define the variables for query and fields outside the if-else
            //as the Basic Filters cant specify the fields value, we need to define the fields with some default value
            //might as well define the query with default value as well
            var query = "status: 'Running', 'Error' lastLag:> 5000 maxCount: 5";
            var fields = "name path status lastLag lastTriggerTime id";

            if (radioButton1.Checked)
            {
                query = "name: " + AnalysisName.Text + " path: " + Path.Text + " status: " + AnalysisRunningStatus.Text
                    + " sortBy: " + AnalysisQ.SortBy + " MaxCount: " + MaxCount.Text;
            }
            else
            {
                query = queryAFSearchbox.Text;  // "status: 'Running' maxCount:2";
                fields = fieldsReturn.Text; // "path lastLag lastTriggerTime";
            }

            IEnumerable<IList<RuntimeFieldValue>> result = analysisService.QueryRuntimeInformation(query, fields);

            // For dataView table
            List<string> fieldlist = fields.Split(' ').ToList();
            int fieldcount = fieldlist.Count;

            // Create an unbound DataGridView by declaring a column count.
            tablequeryresults.ColumnCount = fieldcount;
            tablequeryresults.ColumnHeadersVisible = true;

            // Set the column header style.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
            tablequeryresults.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Populate the headers
            for (int i = 0; i < fieldcount; i++)
            {
                tablequeryresults.Columns[i].Name = fieldlist[i];
            }

            // Populate the rows.
            foreach (var ab in result)
            {
                List<string> listab = new List<string>();

                for (int j = 0; j < ab.Count; j++)
                {
                    listab.Add(ab[j]);
                }
                // Original code but is hardcoded to 4 elements
                // string[] row = new string[] { ab[0], ab[1], ab[2], ab[3] };
                tablequeryresults.Rows.Add(listab.ToArray());
            }
        }
        private void exportCSV_Click(object sender, EventArgs e)
        {
            // Lee: the code below thanks to <Export DataGridView Data To CSV In C#> example, works like a charm
            if (tablequeryresults.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = "Output.csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = tablequeryresults.Columns.Count;
                            string columnNames = "";
                            string[] outputCsv = new string[tablequeryresults.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += tablequeryresults.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCsv[0] += columnNames;

                            for (int i = 1; i < tablequeryresults.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCsv[i] += tablequeryresults.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                }
                            }

                            File.WriteAllLines(sfd.FileName, outputCsv, Encoding.UTF8);
                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }
        private void Testconnection(object sender, EventArgs e)
        {
            if (AFServerName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter AFServer Name in the textbox!", "Info", MessageBoxButtons.OK);
                return; // return because we don't want to run normal code of buton click
            }
            else
            {
                // Get the PISystems collection for the current user.
                PISystems AFServers = new PISystems();
                var AFServer = AFServers[AFServerName.Text];

                //Lee: exception is not fully tested yet
                try
                {
                    // Simple connect.
                    AFServer.Connect();
                    MessageBox.Show(string.Format("Connected to {0}, test successful!", AFServer), "Results", MessageBoxButtons.OK);
                    AFServer.Disconnect();

                    // Connect and display a credential prompt dialog if current user login fails.
                    AFServer.Connect(true, null);
                    AFServer.Disconnect();

                    // Connect using a specified credential.
                    //NetworkCredential credential = new NetworkCredential("guest", String.Empty);
                    //AFServer.Connect(credential);
                }
                catch (Exception ex)
                {
                    // Expected exception since credential needs a valid user name and password.
                    Console.WriteLine(ex.Message);
                }
            }
        }
 
        private void comboBox_SortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Gary this was empty, I'm thinking to delete this
            //until I realized we can use this to trigger the ForeColor change
            //its triggered when user press
            //comboBox_SortBy.ForeColor = Color.Black;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Gary: when the form load, it immediately assigned our comboBox_SortBy with the index 0
            comboBox_SortBy.SelectedIndex = 0;
            //Gary: because of the above line, the DropDown trigger is also being triggered
            //and so it will replace whatever the default properties with Black
            //in order to override that added line below to change the color to Silver
            //in this case the default ForeColor property dont matter
            comboBox_SortBy.ForeColor = Color.Silver;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AnalysisName_Enter(object sender, EventArgs e)
        {
            if (AnalysisName.Text == "'*'")
            {
                AnalysisName.Text = "";
                AnalysisName.ForeColor = Color.Black;
            }
        }

        private void AnalysisName_Leave(object sender, EventArgs e)
        {
            if (AnalysisName.Text == "")
            {
                AnalysisName.Text = "'*'";
                AnalysisName.ForeColor = Color.Silver;
            }
        }

        private void Path_Enter(object sender, EventArgs e)
        {
            if (Path.Text == "'*'")
            {
                Path.Text = "";
                Path.ForeColor = Color.Black;
            }
        }

        private void Path_Leave(object sender, EventArgs e)
        {
            if (Path.Text == "")
            {
                Path.Text = "'*'";
                Path.ForeColor = Color.Silver;
            }
        }

        private void AnalysisRunningStatus_Enter(object sender, EventArgs e)
        {
            if (AnalysisRunningStatus.Text == "in ('Running', 'Error')")
            {
                AnalysisRunningStatus.Text = "";
                AnalysisRunningStatus.ForeColor = Color.Black;
            }
        }

        private void AnalysisRunningStatus_Leave(object sender, EventArgs e)
        {
            if (AnalysisRunningStatus.Text == "")
            {
                AnalysisRunningStatus.Text = "in ('Running', 'Error')";
                AnalysisRunningStatus.ForeColor = Color.Silver;
            }
        }

        private void MaxCount_Enter(object sender, EventArgs e)
        {
            //Gary: even though the default value specify in the MaxCount.Text is simply 5 (as an int)
            //I believed inheritently it add ToString() to it, hence it's been converted into String automatically
            if (MaxCount.Text == "5")
            {
                MaxCount.Text = "";
                MaxCount.ForeColor = Color.Black;
            }
        }

        private void MaxCount_Leave(object sender, EventArgs e)
        {
            if (MaxCount.Text == "")
            {
                //Gary: Cannot implicitly convert type 'int' to 'string'
                //hence ToString() is needed
                MaxCount.Text = 5.ToString();
                MaxCount.ForeColor = Color.Silver;
            }
        }

        private void queryAFSearchbox_Enter(object sender, EventArgs e)
        {
            if (queryAFSearchbox.Text == "status: 'Running' lastLag:> 5000 maxCount: 5")
            {
                queryAFSearchbox.Text = "";
                queryAFSearchbox.ForeColor = Color.Black;
            }
        }

        private void queryAFSearchbox_Leave(object sender, EventArgs e)
        {
            if (queryAFSearchbox.Text == "")
            {
                queryAFSearchbox.Text = "status: 'Running' lastLag:> 5000 maxCount: 5";
                queryAFSearchbox.ForeColor = Color.Silver;
            }
        }

        private void fieldsReturn_Enter(object sender, EventArgs e)
        {
            if (fieldsReturn.Text == "name path status lastLag lastTriggerTime id")
            {
                fieldsReturn.Text = "";
                fieldsReturn.ForeColor = Color.Black;
            }
        }

        private void fieldsReturn_Leave(object sender, EventArgs e)
        {
            if (fieldsReturn.Text == "")
            {
                fieldsReturn.Text = "name path status lastLag lastTriggerTime id";
                fieldsReturn.ForeColor = Color.Silver;
            }
        }
    }
}
