
namespace AFUtility_UI01
{
    partial class Form1
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LAFServer = new System.Windows.Forms.Label();
            this.AFServerName = new System.Windows.Forms.TextBox();
            this.LAnalysisName = new System.Windows.Forms.Label();
            this.AnalysisName = new System.Windows.Forms.TextBox();
            this.Path = new System.Windows.Forms.TextBox();
            this.LAnalysisPath = new System.Windows.Forms.Label();
            this.AnalysisRunningStatus = new System.Windows.Forms.TextBox();
            this.LAnalysisStatus = new System.Windows.Forms.Label();
            this.LSortBy = new System.Windows.Forms.Label();
            this.MaxCount = new System.Windows.Forms.TextBox();
            this.LMaxCount = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.exportCSV = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_SortBy = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.tablequeryresults = new System.Windows.Forms.DataGridView();
            this.fieldsReturn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.queryAFSearchbox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.form1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.programBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.form1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.form1BindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.programBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablequeryresults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // LAFServer
            // 
            this.LAFServer.AutoSize = true;
            this.LAFServer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.LAFServer.Location = new System.Drawing.Point(10, 8);
            this.LAFServer.Name = "LAFServer";
            this.LAFServer.Size = new System.Drawing.Size(87, 21);
            this.LAFServer.TabIndex = 0;
            this.LAFServer.Text = "AF Server:";
            // 
            // AFServerName
            // 
            this.AFServerName.Location = new System.Drawing.Point(100, 8);
            this.AFServerName.Name = "AFServerName";
            this.AFServerName.Size = new System.Drawing.Size(220, 25);
            this.AFServerName.TabIndex = 1;
            this.AFServerName.TextChanged += new System.EventHandler(this.AFServerName_Changed);
            // 
            // LAnalysisName
            // 
            this.LAnalysisName.AutoSize = true;
            this.LAnalysisName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.LAnalysisName.Location = new System.Drawing.Point(12, 110);
            this.LAnalysisName.Name = "LAnalysisName";
            this.LAnalysisName.Size = new System.Drawing.Size(47, 17);
            this.LAnalysisName.TabIndex = 2;
            this.LAnalysisName.Text = "Name:";
            // 
            // AnalysisName
            // 
            this.AnalysisName.BackColor = System.Drawing.SystemColors.Window;
            this.AnalysisName.ForeColor = System.Drawing.Color.Silver;
            this.AnalysisName.Location = new System.Drawing.Point(115, 110);
            this.AnalysisName.Name = "AnalysisName";
            this.AnalysisName.Size = new System.Drawing.Size(220, 25);
            this.AnalysisName.TabIndex = 3;
            this.AnalysisName.Text = "\'*\'";
            this.AnalysisName.TextChanged += new System.EventHandler(this.AnalysisName_Changed);
            this.AnalysisName.Enter += new System.EventHandler(this.AnalysisName_Enter);
            this.AnalysisName.Leave += new System.EventHandler(this.AnalysisName_Leave);
            // 
            // Path
            // 
            this.Path.ForeColor = System.Drawing.Color.Silver;
            this.Path.Location = new System.Drawing.Point(115, 135);
            this.Path.Name = "Path";
            this.Path.Size = new System.Drawing.Size(220, 25);
            this.Path.TabIndex = 5;
            this.Path.Text = "\'*\'";
            this.Path.TextChanged += new System.EventHandler(this.Path_Changed);
            this.Path.Enter += new System.EventHandler(this.Path_Enter);
            this.Path.Leave += new System.EventHandler(this.Path_Leave);
            // 
            // LAnalysisPath
            // 
            this.LAnalysisPath.AutoSize = true;
            this.LAnalysisPath.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.LAnalysisPath.Location = new System.Drawing.Point(12, 135);
            this.LAnalysisPath.Name = "LAnalysisPath";
            this.LAnalysisPath.Size = new System.Drawing.Size(39, 17);
            this.LAnalysisPath.TabIndex = 4;
            this.LAnalysisPath.Text = "Path:";
            // 
            // AnalysisRunningStatus
            // 
            this.AnalysisRunningStatus.ForeColor = System.Drawing.Color.Silver;
            this.AnalysisRunningStatus.Location = new System.Drawing.Point(115, 160);
            this.AnalysisRunningStatus.Name = "AnalysisRunningStatus";
            this.AnalysisRunningStatus.Size = new System.Drawing.Size(220, 25);
            this.AnalysisRunningStatus.TabIndex = 7;
            this.AnalysisRunningStatus.Text = "in (\'Running\', \'Error\')";
            this.AnalysisRunningStatus.TextChanged += new System.EventHandler(this.AnalysisRunningStatus_Changed);
            this.AnalysisRunningStatus.Enter += new System.EventHandler(this.AnalysisRunningStatus_Enter);
            this.AnalysisRunningStatus.Leave += new System.EventHandler(this.AnalysisRunningStatus_Leave);
            // 
            // LAnalysisStatus
            // 
            this.LAnalysisStatus.AutoSize = true;
            this.LAnalysisStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.LAnalysisStatus.Location = new System.Drawing.Point(12, 160);
            this.LAnalysisStatus.Name = "LAnalysisStatus";
            this.LAnalysisStatus.Size = new System.Drawing.Size(49, 17);
            this.LAnalysisStatus.TabIndex = 6;
            this.LAnalysisStatus.Text = "Status:";
            // 
            // LSortBy
            // 
            this.LSortBy.AutoSize = true;
            this.LSortBy.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.LSortBy.Location = new System.Drawing.Point(12, 185);
            this.LSortBy.Name = "LSortBy";
            this.LSortBy.Size = new System.Drawing.Size(95, 17);
            this.LSortBy.TabIndex = 8;
            this.LSortBy.Text = "Sort By (Desc):";
            // 
            // MaxCount
            // 
            this.MaxCount.ForeColor = System.Drawing.Color.Silver;
            this.MaxCount.Location = new System.Drawing.Point(115, 210);
            this.MaxCount.Name = "MaxCount";
            this.MaxCount.Size = new System.Drawing.Size(220, 25);
            this.MaxCount.TabIndex = 11;
            this.MaxCount.Text = "5";
            this.MaxCount.TextChanged += new System.EventHandler(this.MaxCount_TextChanged);
            this.MaxCount.Enter += new System.EventHandler(this.MaxCount_Enter);
            this.MaxCount.Leave += new System.EventHandler(this.MaxCount_Leave);
            // 
            // LMaxCount
            // 
            this.LMaxCount.AutoSize = true;
            this.LMaxCount.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.LMaxCount.Location = new System.Drawing.Point(12, 210);
            this.LMaxCount.Name = "LMaxCount";
            this.LMaxCount.Size = new System.Drawing.Size(78, 17);
            this.LMaxCount.TabIndex = 10;
            this.LMaxCount.Text = "Max Count:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(378, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(452, 28);
            this.button1.TabIndex = 13;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.QueryRunTime);
            // 
            // exportCSV
            // 
            this.exportCSV.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.exportCSV.Location = new System.Drawing.Point(703, 8);
            this.exportCSV.Name = "exportCSV";
            this.exportCSV.Size = new System.Drawing.Size(127, 29);
            this.exportCSV.TabIndex = 14;
            this.exportCSV.Text = "Export to CSV";
            this.exportCSV.UseVisualStyleBackColor = true;
            this.exportCSV.Click += new System.EventHandler(this.exportCSV_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_SortBy);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(10, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 171);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboBox_SortBy
            // 
            this.comboBox_SortBy.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.comboBox_SortBy.ForeColor = System.Drawing.Color.Black;
            this.comboBox_SortBy.FormattingEnabled = true;
            this.comboBox_SortBy.Items.AddRange(new object[] {
            "\'lastLag\'",
            "\'averageLag\'",
            "\'lastElapsed\'",
            "\'averageElapsed\'",
            "\'lastTriggerTime\'",
            "\'averageTrigger\'",
            "\'successCount\'",
            "\'errorCount\'",
            "\'skipCount\'"});
            this.comboBox_SortBy.Location = new System.Drawing.Point(105, 105);
            this.comboBox_SortBy.Name = "comboBox_SortBy";
            this.comboBox_SortBy.Size = new System.Drawing.Size(220, 25);
            this.comboBox_SortBy.TabIndex = 18;
            this.comboBox_SortBy.DropDown += new System.EventHandler(this.SortBy_Changed);
            this.comboBox_SortBy.SelectedIndexChanged += new System.EventHandler(this.comboBox_SortBy_SelectedIndexChanged);
            this.comboBox_SortBy.SelectedValueChanged += new System.EventHandler(this.SortBy_Changed);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(326, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 24);
            this.button3.TabIndex = 17;
            this.button3.Text = "Test Connection";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Testconnection);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabHome);
            this.tabControl1.Location = new System.Drawing.Point(11, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(863, 517);
            this.tabControl1.TabIndex = 18;
            // 
            // tabHome
            // 
            this.tabHome.Controls.Add(this.radioButton2);
            this.tabHome.Controls.Add(this.radioButton1);
            this.tabHome.Controls.Add(this.tablequeryresults);
            this.tabHome.Controls.Add(this.fieldsReturn);
            this.tabHome.Controls.Add(this.label3);
            this.tabHome.Controls.Add(this.label2);
            this.tabHome.Controls.Add(this.queryAFSearchbox);
            this.tabHome.Controls.Add(this.exportCSV);
            this.tabHome.Controls.Add(this.button1);
            this.tabHome.Controls.Add(this.button3);
            this.tabHome.Controls.Add(this.MaxCount);
            this.tabHome.Controls.Add(this.LMaxCount);
            this.tabHome.Controls.Add(this.LSortBy);
            this.tabHome.Controls.Add(this.AnalysisRunningStatus);
            this.tabHome.Controls.Add(this.LAnalysisStatus);
            this.tabHome.Controls.Add(this.Path);
            this.tabHome.Controls.Add(this.LAnalysisPath);
            this.tabHome.Controls.Add(this.AnalysisName);
            this.tabHome.Controls.Add(this.LAnalysisName);
            this.tabHome.Controls.Add(this.AFServerName);
            this.tabHome.Controls.Add(this.LAFServer);
            this.tabHome.Controls.Add(this.groupBox1);
            this.tabHome.Controls.Add(this.groupBox2);
            this.tabHome.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabHome.Location = new System.Drawing.Point(4, 22);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(855, 491);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(378, 63);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(115, 21);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Text = "Advanced Filter";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(10, 63);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(87, 21);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Basic Filter";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // tablequeryresults
            // 
            this.tablequeryresults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablequeryresults.Location = new System.Drawing.Point(10, 268);
            this.tablequeryresults.Name = "tablequeryresults";
            this.tablequeryresults.Size = new System.Drawing.Size(820, 210);
            this.tablequeryresults.TabIndex = 25;
            // 
            // fieldsReturn
            // 
            this.fieldsReturn.ForeColor = System.Drawing.Color.Silver;
            this.fieldsReturn.Location = new System.Drawing.Point(510, 138);
            this.fieldsReturn.Name = "fieldsReturn";
            this.fieldsReturn.Size = new System.Drawing.Size(309, 25);
            this.fieldsReturn.TabIndex = 22;
            this.fieldsReturn.Text = "name path status lastLag lastTriggerTime id";
            this.fieldsReturn.Enter += new System.EventHandler(this.fieldsReturn_Enter);
            this.fieldsReturn.Leave += new System.EventHandler(this.fieldsReturn_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(387, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Fields to Return:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(387, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Query (AFSearch):";
            // 
            // queryAFSearchbox
            // 
            this.queryAFSearchbox.ForeColor = System.Drawing.Color.Silver;
            this.queryAFSearchbox.Location = new System.Drawing.Point(510, 107);
            this.queryAFSearchbox.Name = "queryAFSearchbox";
            this.queryAFSearchbox.Size = new System.Drawing.Size(309, 25);
            this.queryAFSearchbox.TabIndex = 19;
            this.queryAFSearchbox.Text = "status: \'Running\' lastLag:> 5000 maxCount: 5";
            this.queryAFSearchbox.Enter += new System.EventHandler(this.queryAFSearchbox_Enter);
            this.queryAFSearchbox.Leave += new System.EventHandler(this.queryAFSearchbox_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(378, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(452, 105);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // form1BindingSource1
            // 
            this.form1BindingSource1.DataSource = typeof(AFUtility_UI01.Form1);
            // 
            // programBindingSource2
            // 
            this.programBindingSource2.DataSource = typeof(AFUtility_UI01.Program);
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(AFUtility_UI01.Form1);
            // 
            // programBindingSource
            // 
            this.programBindingSource.DataSource = typeof(AFUtility_UI01.Program);
            // 
            // form1BindingSource2
            // 
            this.form1BindingSource2.DataSource = typeof(AFUtility_UI01.Form1);
            // 
            // form1BindingSource3
            // 
            this.form1BindingSource3.DataSource = typeof(AFUtility_UI01.Form1);
            // 
            // programBindingSource1
            // 
            this.programBindingSource1.DataSource = typeof(AFUtility_UI01.Program);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 541);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "AnalysisSearch";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.tabHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablequeryresults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LAFServer;
        private System.Windows.Forms.TextBox AFServerName;
        private System.Windows.Forms.Label LAnalysisName;
        private System.Windows.Forms.TextBox AnalysisName;
        private System.Windows.Forms.TextBox Path;
        private System.Windows.Forms.Label LAnalysisPath;
        private System.Windows.Forms.TextBox AnalysisRunningStatus;
        private System.Windows.Forms.Label LAnalysisStatus;
        private System.Windows.Forms.Label LSortBy;
        private System.Windows.Forms.TextBox MaxCount;
        private System.Windows.Forms.Label LMaxCount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button exportCSV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.ComboBox comboBox_SortBy;
        private System.Windows.Forms.BindingSource form1BindingSource1;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox queryAFSearchbox;
        private System.Windows.Forms.TextBox fieldsReturn;
        private System.Windows.Forms.BindingSource form1BindingSource2;
        private System.Windows.Forms.BindingSource programBindingSource;
        private System.Windows.Forms.BindingSource form1BindingSource3;
        private System.Windows.Forms.BindingSource programBindingSource2;
        private System.Windows.Forms.BindingSource programBindingSource1;
        private System.Windows.Forms.DataGridView tablequeryresults;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

