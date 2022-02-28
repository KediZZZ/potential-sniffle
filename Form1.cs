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
            PISystems piSystems = new PISystems();
            var piSystem = (new PISystems())[connectionInfo.AFServerName];
            var analysisService = piSystem.AnalysisService;
            string querytext = $"name:'{AnalysisQ.AnalysisName}' path: '{AnalysisQ.Path}' status:in ('{AnalysisQ.RunningStatus}') sortBy: '{AnalysisQ.SortBy}' sortOrder: 'Desc' maxCount: {AnalysisQ.MaxCount}";
            string queryfields = "id name status lastLag lastTriggerTime"; //KD: to add more fields in the future
            var resultsWithFactory = analysisService.QueryRuntimeInformation(querytext,queryfields,
             (list) => new
                 {
                     id = (Guid)list[0],
                     name = list[1],
                     status = list[2],
                     lastLag = list[3].ToObject<double>(),
                     lastTriggerTime = list[4].ToObject<AFTime>(AFTime.MinValue)
             }

          );
            var firstResult = resultsWithFactory.First();
            Guid id = firstResult.id;
            string name = firstResult.name;
            string status = firstResult.status;
            double lastLag = firstResult.lastLag;
            AFTime lastTriggerTime = firstResult.lastTriggerTime;
            string s = $"The analysis '{name}' is {status}. \n It was last triggered at {lastTriggerTime}.\n Its current lag is {lastLag} milliseconds.";
            MessageBox.Show(s);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
