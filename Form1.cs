using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OSIsoft.AF;
using OSIsoft.AF.Analysis;
using OSIsoft.AF.Time;
using static OSIsoft.AF.Analysis.AFAnalysisService;
using System.IO;
using System.Net;

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
            connectionInfo.AFServerName = AFServerName.Text;
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
        }

        private void MaxCount_TextChanged(object sender, EventArgs e)
        {
            AnalysisQ.MaxCount = MaxCount.Text;
        }

        private void QueryRunTime(object sender, EventArgs e)
        {
            tablequeryresults.Rows.Clear();

            if (AFServerName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter AFServer Name in the textbox");
                return; // return because we don't want to run normal code of buton click
            }
            else
            {
                PISystems AFServers = new PISystems();
                var AFServer = AFServers[AFServerName.Text];
                var analysisService = AFServer.AnalysisService;

                string query = queryAFSearchbox.Text;  // "status: 'Running' maxCount:2";
                string fields = fieldsReturn.Text; // "path lastLag lastTriggerTime";

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
        }
        private void exportCSV_Click(object sender, EventArgs e)
        {
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

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabHome_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_SortBy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void QueryAFSearch(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
