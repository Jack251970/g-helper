using GHelper.UI;
using System.Windows.Forms.DataVisualization.Charting;

namespace GHelper
{
    partial class Fans
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
            ChartArea chartArea1 = new ChartArea();
            Title title1 = new Title();
            ChartArea chartArea2 = new ChartArea();
            Title title2 = new Title();
            ChartArea chartArea3 = new ChartArea();
            Title title3 = new Title();
            ChartArea chartArea4 = new ChartArea();
            Title title4 = new Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fans));
            panelFans = new Panel();
            labelTip = new Label();
            tableFanCharts = new TableLayoutPanel();
            chartGPU = new Chart();
            chartCPU = new Chart();
            chartXGM = new Chart();
            chartMid = new Chart();
            panelTitleFans = new Panel();
            buttonRename = new RButton();
            buttonRemove = new RButton();
            buttonAdd = new RButton();
            comboModes = new RComboBox();
            picturePerf = new PictureBox();
            labelFans = new Label();
            panelApplyFans = new Panel();
            buttonCalibrate = new RButton();
            labelFansResult = new Label();
            checkApplyFans = new RCheckBox();
            buttonReset = new RButton();
            panelSliders = new Panel();
            panelAdvanced = new Panel();
            panelAdvancedAlways = new Panel();
            checkApplyUV = new RCheckBox();
            panelAdvancedApply = new Panel();
            buttonApplyAdvanced = new RButton();
            labelRisky = new Label();
            panelUViGPU = new Panel();
            labelUViGPU = new Label();
            labelLeftUViGPU = new Label();
            trackUViGPU = new TrackBar();
            panelUV = new Panel();
            labelUV = new Label();
            labelLeftUV = new Label();
            trackUV = new TrackBar();
            panelTitleAdvanced = new Panel();
            pictureUV = new PictureBox();
            labelTitleUV = new Label();
            panelTemperature = new Panel();
            labelTemp = new Label();
            labelLeftTemp = new Label();
            trackTemp = new TrackBar();
            panelTitleTemp = new Panel();
            pictureTemp = new PictureBox();
            labelTempLimit = new Label();
            panelDownload = new Panel();
            buttonDownload = new RButton();
            panelPower = new Panel();
            panelApplyPower = new Panel();
            checkApplyPower = new RCheckBox();
            panelCPU = new Panel();
            labelCPU = new Label();
            labelLeftCPU = new Label();
            trackCPU = new TrackBar();
            panelFast = new Panel();
            labelFast = new Label();
            labelLeftFast = new Label();
            trackFast = new TrackBar();
            panelSlow = new Panel();
            labelSlow = new Label();
            labelLeftSlow = new Label();
            trackSlow = new TrackBar();
            panelTotal = new Panel();
            labelTotal = new Label();
            labelLeftTotal = new Label();
            trackTotal = new TrackBar();
            panelGPU = new Panel();
            panelGPUTemp = new Panel();
            labelGPUTemp = new Label();
            labelGPUTempTitle = new Label();
            trackGPUTemp = new TrackBar();
            panelGPUBoost = new Panel();
            labelGPUBoost = new Label();
            labelGPUBoostTitle = new Label();
            trackGPUBoost = new TrackBar();
            panelGPUPower = new Panel();
            labelGPUPower = new Label();
            labelGPUPowerTitle = new Label();
            trackGPUPower = new TrackBar();
            panelGPUMemory = new Panel();
            labelGPUMemory = new Label();
            labelGPUMemoryTitle = new Label();
            trackGPUMemory = new TrackBar();
            panelGPUCore = new Panel();
            labelGPUCore = new Label();
            trackGPUCore = new TrackBar();
            labelGPUCoreTitle = new Label();
            panelGPUClockLimit = new Panel();
            labelGPUClockLimit = new Label();
            trackGPUClockLimit = new TrackBar();
            labelGPUClockLimitTitle = new Label();
            panelTitleGPU = new Panel();
            pictureGPU = new PictureBox();
            labelGPU = new Label();
            panelNav = new Panel();
            tableNav = new TableLayoutPanel();
            buttonAdvanced = new RButton();
            buttonGPU = new RButton();
            buttonCPU = new RButton();
            comboBoost = new RComboBox();
            panelBoost = new Panel();
            comboPowerMode = new RComboBox();
            panelPowerMode = new Panel();
            labelPowerModeTitle = new Label();
            picturePowerMode = new PictureBox();
            panelPowerModeTItle = new Panel();
            labelBoost = new Label();
            pictureBoost = new PictureBox();
            panelBoostTitle = new Panel();
            labelPowerLimits = new Label();
            pictureBoxCPU = new PictureBox();
            panelTitleCPU = new Panel();
            panelFans.SuspendLayout();
            tableFanCharts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartGPU).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartCPU).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartXGM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartMid).BeginInit();
            panelTitleFans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picturePerf).BeginInit();
            panelApplyFans.SuspendLayout();
            panelSliders.SuspendLayout();
            panelAdvanced.SuspendLayout();
            panelAdvancedAlways.SuspendLayout();
            panelAdvancedApply.SuspendLayout();
            panelUViGPU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackUViGPU).BeginInit();
            panelUV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackUV).BeginInit();
            panelTitleAdvanced.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureUV).BeginInit();
            panelTemperature.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackTemp).BeginInit();
            panelTitleTemp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureTemp).BeginInit();
            panelDownload.SuspendLayout();
            panelPower.SuspendLayout();
            panelApplyPower.SuspendLayout();
            panelCPU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackCPU).BeginInit();
            panelFast.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackFast).BeginInit();
            panelSlow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackSlow).BeginInit();
            panelTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackTotal).BeginInit();
            panelGPU.SuspendLayout();
            panelGPUTemp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackGPUTemp).BeginInit();
            panelGPUBoost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackGPUBoost).BeginInit();
            panelGPUPower.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackGPUPower).BeginInit();
            panelGPUMemory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackGPUMemory).BeginInit();
            panelGPUCore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackGPUCore).BeginInit();
            panelGPUClockLimit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackGPUClockLimit).BeginInit();
            panelTitleGPU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureGPU).BeginInit();
            panelNav.SuspendLayout();
            tableNav.SuspendLayout();
            panelBoost.SuspendLayout();
            panelPowerMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picturePowerMode).BeginInit();
            panelPowerModeTItle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoost).BeginInit();
            panelBoostTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCPU).BeginInit();
            panelTitleCPU.SuspendLayout();
            SuspendLayout();
            // 
            // panelFans
            // 
            panelFans.AutoSize = true;
            panelFans.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelFans.Controls.Add(labelTip);
            panelFans.Controls.Add(tableFanCharts);
            panelFans.Controls.Add(panelTitleFans);
            panelFans.Controls.Add(panelApplyFans);
            panelFans.Dock = DockStyle.Fill;
            panelFans.Location = new Point(398, 0);
            panelFans.Margin = new Padding(0);
            panelFans.MinimumSize = new Size(612, 0);
            panelFans.Name = "panelFans";
            panelFans.Padding = new Padding(0, 0, 8, 0);
            panelFans.Size = new Size(614, 1570);
            panelFans.TabIndex = 12;
            // 
            // labelTip
            // 
            labelTip.AutoSize = true;
            labelTip.BackColor = SystemColors.ControlLightLight;
            labelTip.Location = new Point(513, 69);
            labelTip.Name = "labelTip";
            labelTip.Padding = new Padding(3);
            labelTip.Size = new Size(82, 31);
            labelTip.TabIndex = 40;
            labelTip.Text = "500,300";
            // 
            // tableFanCharts
            // 
            tableFanCharts.AutoSize = true;
            tableFanCharts.ColumnCount = 1;
            tableFanCharts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableFanCharts.Controls.Add(chartGPU, 0, 1);
            tableFanCharts.Controls.Add(chartCPU, 0, 0);
            tableFanCharts.Controls.Add(chartXGM, 0, 2);
            tableFanCharts.Controls.Add(chartMid, 0, 2);
            tableFanCharts.Dock = DockStyle.Fill;
            tableFanCharts.Location = new Point(0, 50);
            tableFanCharts.Name = "tableFanCharts";
            tableFanCharts.Padding = new Padding(8, 0, 8, 4);
            tableFanCharts.RowCount = 2;
            tableFanCharts.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableFanCharts.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableFanCharts.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableFanCharts.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableFanCharts.Size = new Size(606, 1433);
            tableFanCharts.TabIndex = 36;
            // 
            // chartGPU
            // 
            chartArea1.Name = "ChartArea1";
            chartGPU.ChartAreas.Add(chartArea1);
            chartGPU.Dock = DockStyle.Fill;
            chartGPU.Location = new Point(10, 365);
            chartGPU.Margin = new Padding(2, 8, 2, 8);
            chartGPU.Name = "chartGPU";
            chartGPU.Size = new Size(586, 341);
            chartGPU.TabIndex = 17;
            chartGPU.Text = "chartGPU";
            title1.Name = "Title1";
            chartGPU.Titles.Add(title1);
            // 
            // chartCPU
            // 
            chartArea2.Name = "ChartArea1";
            chartCPU.ChartAreas.Add(chartArea2);
            chartCPU.Dock = DockStyle.Fill;
            chartCPU.Location = new Point(10, 8);
            chartCPU.Margin = new Padding(2, 8, 2, 8);
            chartCPU.Name = "chartCPU";
            chartCPU.Size = new Size(586, 341);
            chartCPU.TabIndex = 14;
            chartCPU.Text = "chartCPU";
            title2.Name = "Title1";
            chartCPU.Titles.Add(title2);
            // 
            // chartXGM
            // 
            chartArea3.Name = "ChartAreaXGM";
            chartXGM.ChartAreas.Add(chartArea3);
            chartXGM.Dock = DockStyle.Fill;
            chartXGM.Location = new Point(10, 1079);
            chartXGM.Margin = new Padding(2, 8, 2, 8);
            chartXGM.Name = "chartXGM";
            chartXGM.Size = new Size(586, 342);
            chartXGM.TabIndex = 14;
            chartXGM.Text = "chartXGM";
            title3.Name = "Title4";
            chartXGM.Titles.Add(title3);
            chartXGM.Visible = false;
            // 
            // chartMid
            // 
            chartArea4.Name = "ChartArea3";
            chartMid.ChartAreas.Add(chartArea4);
            chartMid.Dock = DockStyle.Fill;
            chartMid.Location = new Point(10, 722);
            chartMid.Margin = new Padding(2, 8, 2, 8);
            chartMid.Name = "chartMid";
            chartMid.Size = new Size(586, 341);
            chartMid.TabIndex = 14;
            chartMid.Text = "chartMid";
            title4.Name = "Title3";
            chartMid.Titles.Add(title4);
            chartMid.Visible = false;
            // 
            // panelTitleFans
            // 
            panelTitleFans.Controls.Add(buttonRename);
            panelTitleFans.Controls.Add(buttonRemove);
            panelTitleFans.Controls.Add(buttonAdd);
            panelTitleFans.Controls.Add(comboModes);
            panelTitleFans.Controls.Add(picturePerf);
            panelTitleFans.Controls.Add(labelFans);
            panelTitleFans.Dock = DockStyle.Top;
            panelTitleFans.Location = new Point(0, 0);
            panelTitleFans.Name = "panelTitleFans";
            panelTitleFans.Size = new Size(606, 50);
            panelTitleFans.TabIndex = 42;
            // 
            // buttonRename
            // 
            buttonRename.Activated = false;
            buttonRename.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonRename.BackColor = SystemColors.ControlLight;
            buttonRename.Badge = false;
            buttonRename.BorderColor = Color.Transparent;
            buttonRename.BorderRadius = 2;
            buttonRename.FlatStyle = FlatStyle.Flat;
            buttonRename.Image = Properties.Resources.icons8_edit_32;
            buttonRename.Location = new Point(283, 8);
            buttonRename.Margin = new Padding(3, 2, 3, 2);
            buttonRename.Name = "buttonRename";
            buttonRename.Secondary = true;
            buttonRename.Size = new Size(39, 34);
            buttonRename.TabIndex = 45;
            buttonRename.UseVisualStyleBackColor = false;
            // 
            // buttonRemove
            // 
            buttonRemove.Activated = false;
            buttonRemove.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonRemove.BackColor = SystemColors.ControlLight;
            buttonRemove.Badge = false;
            buttonRemove.BorderColor = Color.Transparent;
            buttonRemove.BorderRadius = 2;
            buttonRemove.FlatStyle = FlatStyle.Flat;
            buttonRemove.Image = Properties.Resources.icons8_remove_64;
            buttonRemove.Location = new Point(242, 8);
            buttonRemove.Margin = new Padding(3, 2, 3, 2);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Secondary = true;
            buttonRemove.Size = new Size(39, 34);
            buttonRemove.TabIndex = 44;
            buttonRemove.UseVisualStyleBackColor = false;
            // 
            // buttonAdd
            // 
            buttonAdd.Activated = false;
            buttonAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAdd.BackColor = SystemColors.ControlLight;
            buttonAdd.Badge = false;
            buttonAdd.BorderColor = Color.Transparent;
            buttonAdd.BorderRadius = 2;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Image = Properties.Resources.icons8_add_64;
            buttonAdd.Location = new Point(559, 8);
            buttonAdd.Margin = new Padding(3, 2, 3, 2);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Secondary = true;
            buttonAdd.Size = new Size(39, 34);
            buttonAdd.TabIndex = 43;
            buttonAdd.UseVisualStyleBackColor = false;
            // 
            // comboModes
            // 
            comboModes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboModes.BorderColor = Color.White;
            comboModes.ButtonColor = Color.FromArgb(255, 255, 255);
            comboModes.FlatStyle = FlatStyle.Flat;
            comboModes.FormattingEnabled = true;
            comboModes.Location = new Point(328, 10);
            comboModes.Margin = new Padding(0);
            comboModes.Name = "comboModes";
            comboModes.Size = new Size(228, 33);
            comboModes.TabIndex = 42;
            // 
            // picturePerf
            // 
            picturePerf.BackgroundImage = Properties.Resources.icons8_fan_32;
            picturePerf.BackgroundImageLayout = ImageLayout.Zoom;
            picturePerf.InitialImage = null;
            picturePerf.Location = new Point(14, 14);
            picturePerf.Margin = new Padding(3, 2, 3, 2);
            picturePerf.Name = "picturePerf";
            picturePerf.Size = new Size(24, 24);
            picturePerf.TabIndex = 41;
            picturePerf.TabStop = false;
            // 
            // labelFans
            // 
            labelFans.AutoSize = true;
            labelFans.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelFans.Location = new Point(40, 13);
            labelFans.Name = "labelFans";
            labelFans.Size = new Size(68, 25);
            labelFans.TabIndex = 40;
            labelFans.Text = "Profile";
            // 
            // panelApplyFans
            // 
            panelApplyFans.Controls.Add(buttonCalibrate);
            panelApplyFans.Controls.Add(labelFansResult);
            panelApplyFans.Controls.Add(checkApplyFans);
            panelApplyFans.Controls.Add(buttonReset);
            panelApplyFans.Dock = DockStyle.Bottom;
            panelApplyFans.Location = new Point(0, 1483);
            panelApplyFans.Name = "panelApplyFans";
            panelApplyFans.Size = new Size(606, 87);
            panelApplyFans.TabIndex = 43;
            // 
            // buttonCalibrate
            // 
            buttonCalibrate.Activated = false;
            buttonCalibrate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonCalibrate.BackColor = SystemColors.ControlLight;
            buttonCalibrate.Badge = false;
            buttonCalibrate.BorderColor = Color.Transparent;
            buttonCalibrate.BorderRadius = 2;
            buttonCalibrate.FlatStyle = FlatStyle.Flat;
            buttonCalibrate.Location = new Point(206, 30);
            buttonCalibrate.Margin = new Padding(3, 2, 3, 2);
            buttonCalibrate.Name = "buttonCalibrate";
            buttonCalibrate.Secondary = true;
            buttonCalibrate.Size = new Size(106, 38);
            buttonCalibrate.TabIndex = 43;
            buttonCalibrate.Text = "Calibrate";
            buttonCalibrate.UseVisualStyleBackColor = false;
            // 
            // labelFansResult
            // 
            labelFansResult.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelFansResult.ForeColor = Color.Red;
            labelFansResult.Location = new Point(14, 2);
            labelFansResult.Name = "labelFansResult";
            labelFansResult.Size = new Size(578, 24);
            labelFansResult.TabIndex = 42;
            labelFansResult.Visible = false;
            // 
            // checkApplyFans
            // 
            checkApplyFans.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            checkApplyFans.AutoSize = true;
            checkApplyFans.BackColor = SystemColors.ControlLight;
            checkApplyFans.Location = new Point(337, 31);
            checkApplyFans.Margin = new Padding(0);
            checkApplyFans.Name = "checkApplyFans";
            checkApplyFans.Padding = new Padding(12, 4, 12, 4);
            checkApplyFans.Size = new Size(258, 37);
            checkApplyFans.TabIndex = 19;
            checkApplyFans.Text = Properties.Strings.ApplyFanCurve;
            checkApplyFans.UseVisualStyleBackColor = false;
            // 
            // buttonReset
            // 
            buttonReset.Activated = false;
            buttonReset.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonReset.BackColor = SystemColors.ControlLight;
            buttonReset.Badge = false;
            buttonReset.BorderColor = Color.Transparent;
            buttonReset.BorderRadius = 2;
            buttonReset.FlatStyle = FlatStyle.Flat;
            buttonReset.Location = new Point(11, 30);
            buttonReset.Margin = new Padding(3, 2, 3, 2);
            buttonReset.Name = "buttonReset";
            buttonReset.Secondary = true;
            buttonReset.Size = new Size(189, 38);
            buttonReset.TabIndex = 18;
            buttonReset.Text = Properties.Strings.FactoryDefaults;
            buttonReset.UseVisualStyleBackColor = false;
            // 
            // panelSliders
            // 
            panelSliders.Controls.Add(panelAdvanced);
            panelSliders.Controls.Add(panelPower);
            panelSliders.Controls.Add(panelGPU);
            panelSliders.Controls.Add(panelNav);
            panelSliders.Dock = DockStyle.Left;
            panelSliders.Location = new Point(0, 0);
            panelSliders.Margin = new Padding(0);
            panelSliders.MinimumSize = new Size(398, 0);
            panelSliders.Name = "panelSliders";
            panelSliders.Padding = new Padding(8, 0, 0, 0);
            panelSliders.Size = new Size(398, 1570);
            panelSliders.TabIndex = 13;
            // 
            // panelAdvanced
            // 
            panelAdvanced.AutoSize = true;
            panelAdvanced.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelAdvanced.Controls.Add(panelAdvancedAlways);
            panelAdvanced.Controls.Add(panelAdvancedApply);
            panelAdvanced.Controls.Add(labelRisky);
            panelAdvanced.Controls.Add(panelUViGPU);
            panelAdvanced.Controls.Add(panelUV);
            panelAdvanced.Controls.Add(panelTitleAdvanced);
            panelAdvanced.Controls.Add(panelTemperature);
            panelAdvanced.Controls.Add(panelTitleTemp);
            panelAdvanced.Controls.Add(panelDownload);
            panelAdvanced.Dock = DockStyle.Top;
            panelAdvanced.Location = new Point(8, 1330);
            panelAdvanced.Margin = new Padding(2);
            panelAdvanced.Name = "panelAdvanced";
            panelAdvanced.Size = new Size(390, 749);
            panelAdvanced.TabIndex = 14;
            panelAdvanced.Visible = false;
            // 
            // panelAdvancedAlways
            // 
            panelAdvancedAlways.AutoSize = true;
            panelAdvancedAlways.Controls.Add(checkApplyUV);
            panelAdvancedAlways.Dock = DockStyle.Top;
            panelAdvancedAlways.Location = new Point(0, 704);
            panelAdvancedAlways.Margin = new Padding(2);
            panelAdvancedAlways.Name = "panelAdvancedAlways";
            panelAdvancedAlways.Padding = new Padding(12, 0, 12, 11);
            panelAdvancedAlways.Size = new Size(390, 45);
            panelAdvancedAlways.TabIndex = 46;
            // 
            // checkApplyUV
            // 
            checkApplyUV.BackColor = SystemColors.ControlLight;
            checkApplyUV.Dock = DockStyle.Top;
            checkApplyUV.Enabled = false;
            checkApplyUV.Location = new Point(12, 0);
            checkApplyUV.Margin = new Padding(11, 11, 0, 0);
            checkApplyUV.Name = "checkApplyUV";
            checkApplyUV.Padding = new Padding(12, 4, 12, 4);
            checkApplyUV.Size = new Size(366, 34);
            checkApplyUV.TabIndex = 51;
            checkApplyUV.Text = "Auto Apply";
            checkApplyUV.TextAlign = ContentAlignment.MiddleCenter;
            checkApplyUV.UseVisualStyleBackColor = false;
            // 
            // panelAdvancedApply
            // 
            panelAdvancedApply.AutoSize = true;
            panelAdvancedApply.Controls.Add(buttonApplyAdvanced);
            panelAdvancedApply.Dock = DockStyle.Top;
            panelAdvancedApply.Location = new Point(0, 644);
            panelAdvancedApply.Margin = new Padding(2);
            panelAdvancedApply.Name = "panelAdvancedApply";
            panelAdvancedApply.Padding = new Padding(11);
            panelAdvancedApply.Size = new Size(390, 60);
            panelAdvancedApply.TabIndex = 47;
            // 
            // buttonApplyAdvanced
            // 
            buttonApplyAdvanced.Activated = false;
            buttonApplyAdvanced.BackColor = SystemColors.ControlLight;
            buttonApplyAdvanced.Badge = false;
            buttonApplyAdvanced.BorderColor = Color.Transparent;
            buttonApplyAdvanced.BorderRadius = 2;
            buttonApplyAdvanced.Dock = DockStyle.Top;
            buttonApplyAdvanced.FlatStyle = FlatStyle.Flat;
            buttonApplyAdvanced.Location = new Point(11, 11);
            buttonApplyAdvanced.Margin = new Padding(3, 2, 11, 11);
            buttonApplyAdvanced.Name = "buttonApplyAdvanced";
            buttonApplyAdvanced.Secondary = true;
            buttonApplyAdvanced.Size = new Size(368, 38);
            buttonApplyAdvanced.TabIndex = 49;
            buttonApplyAdvanced.Text = "Apply";
            buttonApplyAdvanced.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonApplyAdvanced.UseVisualStyleBackColor = false;
            // 
            // labelRisky
            // 
            labelRisky.BackColor = Color.IndianRed;
            labelRisky.Dock = DockStyle.Top;
            labelRisky.ForeColor = SystemColors.ControlLightLight;
            labelRisky.Location = new Point(0, 462);
            labelRisky.Margin = new Padding(0);
            labelRisky.Name = "labelRisky";
            labelRisky.Padding = new Padding(8, 8, 8, 4);
            labelRisky.Size = new Size(390, 182);
            labelRisky.TabIndex = 46;
            labelRisky.Text = resources.GetString("labelRisky.Text");
            // 
            // panelUViGPU
            // 
            panelUViGPU.AutoSize = true;
            panelUViGPU.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelUViGPU.Controls.Add(labelUViGPU);
            panelUViGPU.Controls.Add(labelLeftUViGPU);
            panelUViGPU.Controls.Add(trackUViGPU);
            panelUViGPU.Dock = DockStyle.Top;
            panelUViGPU.Location = new Point(0, 369);
            panelUViGPU.MaximumSize = new Size(0, 93);
            panelUViGPU.Name = "panelUViGPU";
            panelUViGPU.Size = new Size(390, 93);
            panelUViGPU.TabIndex = 49;
            // 
            // labelUViGPU
            // 
            labelUViGPU.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelUViGPU.Location = new Point(260, 7);
            labelUViGPU.Name = "labelUViGPU";
            labelUViGPU.Size = new Size(111, 24);
            labelUViGPU.TabIndex = 13;
            labelUViGPU.Text = "UV";
            labelUViGPU.TextAlign = ContentAlignment.TopRight;
            // 
            // labelLeftUViGPU
            // 
            labelLeftUViGPU.AutoSize = true;
            labelLeftUViGPU.Location = new Point(8, 8);
            labelLeftUViGPU.Name = "labelLeftUViGPU";
            labelLeftUViGPU.Size = new Size(50, 25);
            labelLeftUViGPU.TabIndex = 12;
            labelLeftUViGPU.Text = "iGPU";
            // 
            // trackUViGPU
            // 
            trackUViGPU.Location = new Point(4, 36);
            trackUViGPU.Margin = new Padding(3, 2, 3, 2);
            trackUViGPU.Maximum = 0;
            trackUViGPU.Minimum = -40;
            trackUViGPU.Name = "trackUViGPU";
            trackUViGPU.Size = new Size(381, 69);
            trackUViGPU.TabIndex = 11;
            trackUViGPU.TickFrequency = 5;
            trackUViGPU.TickStyle = TickStyle.TopLeft;
            // 
            // panelUV
            // 
            panelUV.AutoSize = true;
            panelUV.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelUV.Controls.Add(labelUV);
            panelUV.Controls.Add(labelLeftUV);
            panelUV.Controls.Add(trackUV);
            panelUV.Dock = DockStyle.Top;
            panelUV.Location = new Point(0, 276);
            panelUV.MaximumSize = new Size(0, 93);
            panelUV.Name = "panelUV";
            panelUV.Size = new Size(390, 93);
            panelUV.TabIndex = 46;
            // 
            // labelUV
            // 
            labelUV.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelUV.Location = new Point(260, 10);
            labelUV.Name = "labelUV";
            labelUV.Size = new Size(111, 24);
            labelUV.TabIndex = 13;
            labelUV.Text = "UV";
            labelUV.TextAlign = ContentAlignment.TopRight;
            // 
            // labelLeftUV
            // 
            labelLeftUV.AutoSize = true;
            labelLeftUV.Location = new Point(8, 8);
            labelLeftUV.Name = "labelLeftUV";
            labelLeftUV.Size = new Size(45, 25);
            labelLeftUV.TabIndex = 12;
            labelLeftUV.Text = "CPU";
            // 
            // trackUV
            // 
            trackUV.Location = new Point(4, 36);
            trackUV.Margin = new Padding(3, 2, 3, 2);
            trackUV.Maximum = 0;
            trackUV.Minimum = -40;
            trackUV.Name = "trackUV";
            trackUV.Size = new Size(381, 69);
            trackUV.TabIndex = 11;
            trackUV.TickFrequency = 5;
            trackUV.TickStyle = TickStyle.TopLeft;
            // 
            // panelTitleAdvanced
            // 
            panelTitleAdvanced.Controls.Add(pictureUV);
            panelTitleAdvanced.Controls.Add(labelTitleUV);
            panelTitleAdvanced.Dock = DockStyle.Top;
            panelTitleAdvanced.Location = new Point(0, 226);
            panelTitleAdvanced.Margin = new Padding(2);
            panelTitleAdvanced.Name = "panelTitleAdvanced";
            panelTitleAdvanced.Size = new Size(390, 50);
            panelTitleAdvanced.TabIndex = 48;
            // 
            // pictureUV
            // 
            pictureUV.BackgroundImage = Properties.Resources.icons8_voltage_32;
            pictureUV.BackgroundImageLayout = ImageLayout.Zoom;
            pictureUV.InitialImage = null;
            pictureUV.Location = new Point(8, 14);
            pictureUV.Margin = new Padding(3, 2, 3, 8);
            pictureUV.Name = "pictureUV";
            pictureUV.Size = new Size(24, 24);
            pictureUV.TabIndex = 48;
            pictureUV.TabStop = false;
            // 
            // labelTitleUV
            // 
            labelTitleUV.AutoSize = true;
            labelTitleUV.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelTitleUV.Location = new Point(32, 13);
            labelTitleUV.Name = "labelTitleUV";
            labelTitleUV.Size = new Size(125, 25);
            labelTitleUV.TabIndex = 47;
            labelTitleUV.Text = "Undervolting";
            // 
            // panelTemperature
            // 
            panelTemperature.AutoSize = true;
            panelTemperature.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelTemperature.Controls.Add(labelTemp);
            panelTemperature.Controls.Add(labelLeftTemp);
            panelTemperature.Controls.Add(trackTemp);
            panelTemperature.Dock = DockStyle.Top;
            panelTemperature.Location = new Point(0, 133);
            panelTemperature.MaximumSize = new Size(0, 93);
            panelTemperature.Name = "panelTemperature";
            panelTemperature.Size = new Size(390, 93);
            panelTemperature.TabIndex = 51;
            // 
            // labelTemp
            // 
            labelTemp.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelTemp.Location = new Point(260, 10);
            labelTemp.Name = "labelTemp";
            labelTemp.Size = new Size(111, 24);
            labelTemp.TabIndex = 13;
            labelTemp.Text = "T";
            labelTemp.TextAlign = ContentAlignment.TopRight;
            // 
            // labelLeftTemp
            // 
            labelLeftTemp.AutoSize = true;
            labelLeftTemp.Location = new Point(8, 8);
            labelLeftTemp.Name = "labelLeftTemp";
            labelLeftTemp.Size = new Size(136, 25);
            labelLeftTemp.TabIndex = 12;
            labelLeftTemp.Text = "CPU Temp Limit";
            // 
            // trackTemp
            // 
            trackTemp.Location = new Point(4, 36);
            trackTemp.Margin = new Padding(3, 2, 3, 2);
            trackTemp.Maximum = 0;
            trackTemp.Minimum = -40;
            trackTemp.Name = "trackTemp";
            trackTemp.Size = new Size(381, 69);
            trackTemp.TabIndex = 11;
            trackTemp.TickFrequency = 5;
            trackTemp.TickStyle = TickStyle.TopLeft;
            // 
            // panelTitleTemp
            // 
            panelTitleTemp.Controls.Add(pictureTemp);
            panelTitleTemp.Controls.Add(labelTempLimit);
            panelTitleTemp.Dock = DockStyle.Top;
            panelTitleTemp.Location = new Point(0, 83);
            panelTitleTemp.Margin = new Padding(2);
            panelTitleTemp.Name = "panelTitleTemp";
            panelTitleTemp.Size = new Size(390, 50);
            panelTitleTemp.TabIndex = 50;
            // 
            // pictureTemp
            // 
            pictureTemp.BackgroundImage = Properties.Resources.icons8_temperature_32;
            pictureTemp.BackgroundImageLayout = ImageLayout.Zoom;
            pictureTemp.InitialImage = null;
            pictureTemp.Location = new Point(8, 14);
            pictureTemp.Margin = new Padding(3, 2, 3, 8);
            pictureTemp.Name = "pictureTemp";
            pictureTemp.Size = new Size(24, 24);
            pictureTemp.TabIndex = 48;
            pictureTemp.TabStop = false;
            // 
            // labelTempLimit
            // 
            labelTempLimit.AutoSize = true;
            labelTempLimit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelTempLimit.Location = new Point(34, 13);
            labelTempLimit.Name = "labelTempLimit";
            labelTempLimit.Size = new Size(105, 25);
            labelTempLimit.TabIndex = 47;
            labelTempLimit.Text = "Temp Limit";
            // 
            // panelDownload
            // 
            panelDownload.AutoSize = true;
            panelDownload.Controls.Add(buttonDownload);
            panelDownload.Dock = DockStyle.Top;
            panelDownload.Location = new Point(0, 0);
            panelDownload.Margin = new Padding(2);
            panelDownload.Name = "panelDownload";
            panelDownload.Padding = new Padding(15);
            panelDownload.Size = new Size(390, 83);
            panelDownload.TabIndex = 52;
            panelDownload.Visible = false;
            // 
            // buttonDownload
            // 
            buttonDownload.Activated = false;
            buttonDownload.AutoSize = true;
            buttonDownload.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonDownload.BackColor = SystemColors.ControlLight;
            buttonDownload.Badge = false;
            buttonDownload.BorderColor = Color.Transparent;
            buttonDownload.BorderRadius = 2;
            buttonDownload.Dock = DockStyle.Top;
            buttonDownload.FlatStyle = FlatStyle.Flat;
            buttonDownload.Location = new Point(15, 15);
            buttonDownload.Margin = new Padding(15);
            buttonDownload.Name = "buttonDownload";
            buttonDownload.Padding = new Padding(8);
            buttonDownload.Secondary = true;
            buttonDownload.Size = new Size(360, 53);
            buttonDownload.TabIndex = 19;
            buttonDownload.Text = "Download Advanced Settings Plugin";
            buttonDownload.UseVisualStyleBackColor = false;
            // 
            // panelPower
            // 
            panelPower.AutoSize = true;
            panelPower.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelPower.Controls.Add(panelApplyPower);
            panelPower.Controls.Add(panelCPU);
            panelPower.Controls.Add(panelFast);
            panelPower.Controls.Add(panelSlow);
            panelPower.Controls.Add(panelTotal);
            panelPower.Controls.Add(panelTitleCPU);
            panelPower.Controls.Add(panelBoost);
            panelPower.Controls.Add(panelBoostTitle);
            panelPower.Controls.Add(panelPowerMode);
            panelPower.Controls.Add(panelPowerModeTItle);
            panelPower.Dock = DockStyle.Top;
            panelPower.Location = new Point(8, 668);
            panelPower.Name = "panelPower";
            panelPower.Size = new Size(390, 662);
            panelPower.TabIndex = 43;
            // 
            // panelApplyPower
            // 
            panelApplyPower.AutoSize = true;
            panelApplyPower.Controls.Add(checkApplyPower);
            panelApplyPower.Dock = DockStyle.Top;
            panelApplyPower.Location = new Point(0, 606);
            panelApplyPower.Margin = new Padding(2);
            panelApplyPower.Name = "panelApplyPower";
            panelApplyPower.Padding = new Padding(11);
            panelApplyPower.Size = new Size(390, 56);
            panelApplyPower.TabIndex = 47;
            // 
            // checkApplyPower
            // 
            checkApplyPower.BackColor = SystemColors.ControlLight;
            checkApplyPower.Dock = DockStyle.Top;
            checkApplyPower.Location = new Point(11, 11);
            checkApplyPower.Margin = new Padding(0);
            checkApplyPower.Name = "checkApplyPower";
            checkApplyPower.Padding = new Padding(12, 4, 12, 4);
            checkApplyPower.Size = new Size(368, 34);
            checkApplyPower.TabIndex = 45;
            checkApplyPower.Text = "Apply Power Limits";
            checkApplyPower.UseVisualStyleBackColor = false;
            // 
            // panelCPU
            // 
            panelCPU.AutoSize = true;
            panelCPU.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelCPU.Controls.Add(labelCPU);
            panelCPU.Controls.Add(labelLeftCPU);
            panelCPU.Controls.Add(trackCPU);
            panelCPU.Dock = DockStyle.Top;
            panelCPU.Location = new Point(0, 513);
            panelCPU.MaximumSize = new Size(0, 93);
            panelCPU.Name = "panelCPU";
            panelCPU.Size = new Size(390, 93);
            panelCPU.TabIndex = 41;
            // 
            // labelCPU
            // 
            labelCPU.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelCPU.Location = new Point(298, 6);
            labelCPU.Name = "labelCPU";
            labelCPU.Size = new Size(87, 24);
            labelCPU.TabIndex = 13;
            labelCPU.Text = "CPU";
            labelCPU.TextAlign = ContentAlignment.TopRight;
            // 
            // labelLeftCPU
            // 
            labelLeftCPU.AutoSize = true;
            labelLeftCPU.Location = new Point(8, 6);
            labelLeftCPU.Name = "labelLeftCPU";
            labelLeftCPU.Size = new Size(45, 25);
            labelLeftCPU.TabIndex = 12;
            labelLeftCPU.Text = "CPU";
            // 
            // trackCPU
            // 
            trackCPU.Location = new Point(4, 33);
            trackCPU.Margin = new Padding(3, 2, 3, 2);
            trackCPU.Maximum = 85;
            trackCPU.Minimum = 5;
            trackCPU.Name = "trackCPU";
            trackCPU.Size = new Size(381, 69);
            trackCPU.TabIndex = 11;
            trackCPU.TickFrequency = 5;
            trackCPU.TickStyle = TickStyle.TopLeft;
            trackCPU.Value = 80;
            // 
            // panelFast
            // 
            panelFast.AutoSize = true;
            panelFast.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelFast.Controls.Add(labelFast);
            panelFast.Controls.Add(labelLeftFast);
            panelFast.Controls.Add(trackFast);
            panelFast.Dock = DockStyle.Top;
            panelFast.Location = new Point(0, 420);
            panelFast.MaximumSize = new Size(0, 93);
            panelFast.Name = "panelFast";
            panelFast.Size = new Size(390, 93);
            panelFast.TabIndex = 45;
            // 
            // labelFast
            // 
            labelFast.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelFast.Location = new Point(297, 6);
            labelFast.Name = "labelFast";
            labelFast.Size = new Size(86, 24);
            labelFast.TabIndex = 13;
            labelFast.Text = "FPPT";
            labelFast.TextAlign = ContentAlignment.TopRight;
            // 
            // labelLeftFast
            // 
            labelLeftFast.AutoSize = true;
            labelLeftFast.Location = new Point(8, 6);
            labelLeftFast.Name = "labelLeftFast";
            labelLeftFast.Size = new Size(50, 25);
            labelLeftFast.TabIndex = 12;
            labelLeftFast.Text = "FPPT";
            // 
            // trackFast
            // 
            trackFast.Location = new Point(4, 36);
            trackFast.Margin = new Padding(3, 2, 3, 2);
            trackFast.Maximum = 85;
            trackFast.Minimum = 5;
            trackFast.Name = "trackFast";
            trackFast.Size = new Size(381, 69);
            trackFast.TabIndex = 11;
            trackFast.TickFrequency = 5;
            trackFast.TickStyle = TickStyle.TopLeft;
            trackFast.Value = 80;
            // 
            // panelSlow
            // 
            panelSlow.AutoSize = true;
            panelSlow.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelSlow.Controls.Add(labelSlow);
            panelSlow.Controls.Add(labelLeftSlow);
            panelSlow.Controls.Add(trackSlow);
            panelSlow.Dock = DockStyle.Top;
            panelSlow.Location = new Point(0, 327);
            panelSlow.MaximumSize = new Size(0, 93);
            panelSlow.Name = "panelSlow";
            panelSlow.Size = new Size(390, 93);
            panelSlow.TabIndex = 51;
            // 
            // labelSlow
            // 
            labelSlow.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelSlow.Location = new Point(297, 8);
            labelSlow.Name = "labelSlow";
            labelSlow.Size = new Size(87, 24);
            labelSlow.TabIndex = 12;
            labelSlow.Text = "SPPT";
            labelSlow.TextAlign = ContentAlignment.TopRight;
            // 
            // labelLeftSlow
            // 
            labelLeftSlow.AutoSize = true;
            labelLeftSlow.Location = new Point(8, 8);
            labelLeftSlow.Name = "labelLeftSlow";
            labelLeftSlow.Size = new Size(51, 25);
            labelLeftSlow.TabIndex = 11;
            labelLeftSlow.Text = "SPPT";
            // 
            // trackSlow
            // 
            trackSlow.Location = new Point(4, 36);
            trackSlow.Margin = new Padding(3, 2, 3, 2);
            trackSlow.Maximum = 180;
            trackSlow.Minimum = 10;
            trackSlow.Name = "trackSlow";
            trackSlow.Size = new Size(381, 69);
            trackSlow.TabIndex = 10;
            trackSlow.TickFrequency = 5;
            trackSlow.TickStyle = TickStyle.TopLeft;
            trackSlow.Value = 125;
            // 
            // panelTotal
            // 
            panelTotal.AutoSize = true;
            panelTotal.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelTotal.Controls.Add(labelTotal);
            panelTotal.Controls.Add(labelLeftTotal);
            panelTotal.Controls.Add(trackTotal);
            panelTotal.Dock = DockStyle.Top;
            panelTotal.Location = new Point(0, 234);
            panelTotal.MaximumSize = new Size(0, 93);
            panelTotal.Name = "panelTotal";
            panelTotal.Size = new Size(390, 93);
            panelTotal.TabIndex = 40;
            // 
            // labelTotal
            // 
            labelTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelTotal.Location = new Point(297, 8);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(87, 24);
            labelTotal.TabIndex = 12;
            labelTotal.Text = "SPL";
            labelTotal.TextAlign = ContentAlignment.TopRight;
            // 
            // labelLeftTotal
            // 
            labelLeftTotal.AutoSize = true;
            labelLeftTotal.Location = new Point(8, 8);
            labelLeftTotal.Name = "labelLeftTotal";
            labelLeftTotal.Size = new Size(40, 25);
            labelLeftTotal.TabIndex = 11;
            labelLeftTotal.Text = "SPL";
            // 
            // trackTotal
            // 
            trackTotal.Location = new Point(4, 36);
            trackTotal.Margin = new Padding(3, 2, 3, 2);
            trackTotal.Maximum = 180;
            trackTotal.Minimum = 10;
            trackTotal.Name = "trackTotal";
            trackTotal.Size = new Size(381, 69);
            trackTotal.TabIndex = 10;
            trackTotal.TickFrequency = 5;
            trackTotal.TickStyle = TickStyle.TopLeft;
            trackTotal.Value = 125;
            // 
            // panelGPU
            // 
            panelGPU.AutoSize = true;
            panelGPU.Controls.Add(panelGPUTemp);
            panelGPU.Controls.Add(panelGPUBoost);
            panelGPU.Controls.Add(panelGPUPower);
            panelGPU.Controls.Add(panelGPUMemory);
            panelGPU.Controls.Add(panelGPUCore);
            panelGPU.Controls.Add(panelGPUClockLimit);
            panelGPU.Controls.Add(panelTitleGPU);
            panelGPU.Dock = DockStyle.Top;
            panelGPU.Location = new Point(8, 50);
            panelGPU.Name = "panelGPU";
            panelGPU.Padding = new Padding(0, 0, 0, 14);
            panelGPU.Size = new Size(390, 618);
            panelGPU.TabIndex = 44;
            panelGPU.Visible = false;
            // 
            // panelGPUTemp
            // 
            panelGPUTemp.AutoSize = true;
            panelGPUTemp.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelGPUTemp.Controls.Add(labelGPUTemp);
            panelGPUTemp.Controls.Add(labelGPUTempTitle);
            panelGPUTemp.Controls.Add(trackGPUTemp);
            panelGPUTemp.Dock = DockStyle.Top;
            panelGPUTemp.Location = new Point(0, 511);
            panelGPUTemp.MaximumSize = new Size(0, 93);
            panelGPUTemp.Name = "panelGPUTemp";
            panelGPUTemp.Size = new Size(390, 93);
            panelGPUTemp.TabIndex = 47;
            // 
            // labelGPUTemp
            // 
            labelGPUTemp.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelGPUTemp.Location = new Point(284, 10);
            labelGPUTemp.Name = "labelGPUTemp";
            labelGPUTemp.Size = new Size(93, 24);
            labelGPUTemp.TabIndex = 44;
            labelGPUTemp.Text = "87C";
            labelGPUTemp.TextAlign = ContentAlignment.TopRight;
            // 
            // labelGPUTempTitle
            // 
            labelGPUTempTitle.AutoSize = true;
            labelGPUTempTitle.Location = new Point(8, 10);
            labelGPUTempTitle.Name = "labelGPUTempTitle";
            labelGPUTempTitle.Size = new Size(128, 25);
            labelGPUTempTitle.TabIndex = 43;
            labelGPUTempTitle.Text = "Thermal Target";
            // 
            // trackGPUTemp
            // 
            trackGPUTemp.Location = new Point(4, 42);
            trackGPUTemp.Margin = new Padding(3, 2, 3, 2);
            trackGPUTemp.Maximum = 87;
            trackGPUTemp.Minimum = 75;
            trackGPUTemp.Name = "trackGPUTemp";
            trackGPUTemp.Size = new Size(372, 69);
            trackGPUTemp.TabIndex = 42;
            trackGPUTemp.TickFrequency = 5;
            trackGPUTemp.TickStyle = TickStyle.TopLeft;
            trackGPUTemp.Value = 87;
            // 
            // panelGPUBoost
            // 
            panelGPUBoost.AutoSize = true;
            panelGPUBoost.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelGPUBoost.Controls.Add(labelGPUBoost);
            panelGPUBoost.Controls.Add(labelGPUBoostTitle);
            panelGPUBoost.Controls.Add(trackGPUBoost);
            panelGPUBoost.Dock = DockStyle.Top;
            panelGPUBoost.Location = new Point(0, 418);
            panelGPUBoost.MaximumSize = new Size(0, 93);
            panelGPUBoost.Name = "panelGPUBoost";
            panelGPUBoost.Size = new Size(390, 93);
            panelGPUBoost.TabIndex = 46;
            // 
            // labelGPUBoost
            // 
            labelGPUBoost.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelGPUBoost.Location = new Point(280, 10);
            labelGPUBoost.Name = "labelGPUBoost";
            labelGPUBoost.Size = new Size(93, 24);
            labelGPUBoost.TabIndex = 44;
            labelGPUBoost.Text = "25W";
            labelGPUBoost.TextAlign = ContentAlignment.TopRight;
            // 
            // labelGPUBoostTitle
            // 
            labelGPUBoostTitle.AutoSize = true;
            labelGPUBoostTitle.Location = new Point(8, 10);
            labelGPUBoostTitle.Name = "labelGPUBoostTitle";
            labelGPUBoostTitle.Size = new Size(132, 25);
            labelGPUBoostTitle.TabIndex = 43;
            labelGPUBoostTitle.Text = "Dynamic Boost";
            // 
            // trackGPUBoost
            // 
            trackGPUBoost.Location = new Point(4, 36);
            trackGPUBoost.Margin = new Padding(3, 2, 3, 2);
            trackGPUBoost.Maximum = 25;
            trackGPUBoost.Minimum = 5;
            trackGPUBoost.Name = "trackGPUBoost";
            trackGPUBoost.Size = new Size(372, 69);
            trackGPUBoost.TabIndex = 42;
            trackGPUBoost.TickFrequency = 5;
            trackGPUBoost.TickStyle = TickStyle.TopLeft;
            trackGPUBoost.Value = 25;
            // 
            // panelGPUPower
            // 
            panelGPUPower.AutoSize = true;
            panelGPUPower.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelGPUPower.Controls.Add(labelGPUPower);
            panelGPUPower.Controls.Add(labelGPUPowerTitle);
            panelGPUPower.Controls.Add(trackGPUPower);
            panelGPUPower.Dock = DockStyle.Top;
            panelGPUPower.Location = new Point(0, 325);
            panelGPUPower.MaximumSize = new Size(0, 93);
            panelGPUPower.Name = "panelGPUPower";
            panelGPUPower.Size = new Size(390, 93);
            panelGPUPower.TabIndex = 49;
            // 
            // labelGPUPower
            // 
            labelGPUPower.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelGPUPower.Location = new Point(280, 10);
            labelGPUPower.Name = "labelGPUPower";
            labelGPUPower.Size = new Size(93, 24);
            labelGPUPower.TabIndex = 44;
            labelGPUPower.Text = "105W";
            labelGPUPower.TextAlign = ContentAlignment.TopRight;
            // 
            // labelGPUPowerTitle
            // 
            labelGPUPowerTitle.AutoSize = true;
            labelGPUPowerTitle.Location = new Point(8, 10);
            labelGPUPowerTitle.Name = "labelGPUPowerTitle";
            labelGPUPowerTitle.Size = new Size(99, 25);
            labelGPUPowerTitle.TabIndex = 43;
            labelGPUPowerTitle.Text = "GPU Power";
            // 
            // trackGPUPower
            // 
            trackGPUPower.Location = new Point(4, 36);
            trackGPUPower.Margin = new Padding(3, 2, 3, 2);
            trackGPUPower.Maximum = 25;
            trackGPUPower.Minimum = 5;
            trackGPUPower.Name = "trackGPUPower";
            trackGPUPower.Size = new Size(372, 69);
            trackGPUPower.TabIndex = 42;
            trackGPUPower.TickFrequency = 5;
            trackGPUPower.TickStyle = TickStyle.TopLeft;
            trackGPUPower.Value = 25;
            // 
            // panelGPUMemory
            // 
            panelGPUMemory.AutoSize = true;
            panelGPUMemory.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelGPUMemory.Controls.Add(labelGPUMemory);
            panelGPUMemory.Controls.Add(labelGPUMemoryTitle);
            panelGPUMemory.Controls.Add(trackGPUMemory);
            panelGPUMemory.Dock = DockStyle.Top;
            panelGPUMemory.Location = new Point(0, 232);
            panelGPUMemory.MaximumSize = new Size(0, 93);
            panelGPUMemory.Name = "panelGPUMemory";
            panelGPUMemory.Size = new Size(390, 93);
            panelGPUMemory.TabIndex = 45;
            // 
            // labelGPUMemory
            // 
            labelGPUMemory.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelGPUMemory.Location = new Point(258, 10);
            labelGPUMemory.Name = "labelGPUMemory";
            labelGPUMemory.Size = new Size(120, 24);
            labelGPUMemory.TabIndex = 44;
            labelGPUMemory.Text = "2000 MHz";
            labelGPUMemory.TextAlign = ContentAlignment.TopRight;
            // 
            // labelGPUMemoryTitle
            // 
            labelGPUMemoryTitle.AutoSize = true;
            labelGPUMemoryTitle.Location = new Point(8, 10);
            labelGPUMemoryTitle.Name = "labelGPUMemoryTitle";
            labelGPUMemoryTitle.Size = new Size(181, 25);
            labelGPUMemoryTitle.TabIndex = 43;
            labelGPUMemoryTitle.Text = "Memory Clock Offset";
            // 
            // trackGPUMemory
            // 
            trackGPUMemory.LargeChange = 100;
            trackGPUMemory.Location = new Point(4, 36);
            trackGPUMemory.Margin = new Padding(3, 2, 3, 2);
            trackGPUMemory.Maximum = 300;
            trackGPUMemory.Name = "trackGPUMemory";
            trackGPUMemory.Size = new Size(372, 69);
            trackGPUMemory.SmallChange = 10;
            trackGPUMemory.TabIndex = 42;
            trackGPUMemory.TickFrequency = 50;
            trackGPUMemory.TickStyle = TickStyle.TopLeft;
            // 
            // panelGPUCore
            // 
            panelGPUCore.AutoSize = true;
            panelGPUCore.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelGPUCore.Controls.Add(labelGPUCore);
            panelGPUCore.Controls.Add(trackGPUCore);
            panelGPUCore.Controls.Add(labelGPUCoreTitle);
            panelGPUCore.Dock = DockStyle.Top;
            panelGPUCore.Location = new Point(0, 139);
            panelGPUCore.MaximumSize = new Size(0, 93);
            panelGPUCore.Name = "panelGPUCore";
            panelGPUCore.Size = new Size(390, 93);
            panelGPUCore.TabIndex = 44;
            // 
            // labelGPUCore
            // 
            labelGPUCore.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelGPUCore.Location = new Point(244, 12);
            labelGPUCore.Name = "labelGPUCore";
            labelGPUCore.Size = new Size(132, 24);
            labelGPUCore.TabIndex = 29;
            labelGPUCore.Text = "1500 MHz";
            labelGPUCore.TextAlign = ContentAlignment.TopRight;
            // 
            // trackGPUCore
            // 
            trackGPUCore.LargeChange = 100;
            trackGPUCore.Location = new Point(4, 36);
            trackGPUCore.Margin = new Padding(3, 2, 3, 2);
            trackGPUCore.Maximum = 300;
            trackGPUCore.Name = "trackGPUCore";
            trackGPUCore.RightToLeft = RightToLeft.No;
            trackGPUCore.Size = new Size(372, 69);
            trackGPUCore.SmallChange = 10;
            trackGPUCore.TabIndex = 18;
            trackGPUCore.TickFrequency = 50;
            trackGPUCore.TickStyle = TickStyle.TopLeft;
            // 
            // labelGPUCoreTitle
            // 
            labelGPUCoreTitle.AutoSize = true;
            labelGPUCoreTitle.Location = new Point(8, 12);
            labelGPUCoreTitle.Name = "labelGPUCoreTitle";
            labelGPUCoreTitle.Size = new Size(151, 25);
            labelGPUCoreTitle.TabIndex = 17;
            labelGPUCoreTitle.Text = "Core Clock Offset";
            // 
            // panelGPUClockLimit
            // 
            panelGPUClockLimit.AutoSize = true;
            panelGPUClockLimit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelGPUClockLimit.Controls.Add(labelGPUClockLimit);
            panelGPUClockLimit.Controls.Add(trackGPUClockLimit);
            panelGPUClockLimit.Controls.Add(labelGPUClockLimitTitle);
            panelGPUClockLimit.Dock = DockStyle.Top;
            panelGPUClockLimit.Location = new Point(0, 46);
            panelGPUClockLimit.MaximumSize = new Size(0, 93);
            panelGPUClockLimit.Name = "panelGPUClockLimit";
            panelGPUClockLimit.Size = new Size(390, 93);
            panelGPUClockLimit.TabIndex = 48;
            // 
            // labelGPUClockLimit
            // 
            labelGPUClockLimit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelGPUClockLimit.Location = new Point(244, 12);
            labelGPUClockLimit.Name = "labelGPUClockLimit";
            labelGPUClockLimit.Size = new Size(132, 24);
            labelGPUClockLimit.TabIndex = 29;
            labelGPUClockLimit.Text = "1500 MHz";
            labelGPUClockLimit.TextAlign = ContentAlignment.TopRight;
            // 
            // trackGPUClockLimit
            // 
            trackGPUClockLimit.LargeChange = 100;
            trackGPUClockLimit.Location = new Point(4, 36);
            trackGPUClockLimit.Margin = new Padding(3, 2, 3, 2);
            trackGPUClockLimit.Maximum = 3000;
            trackGPUClockLimit.Name = "trackGPUClockLimit";
            trackGPUClockLimit.RightToLeft = RightToLeft.No;
            trackGPUClockLimit.Size = new Size(372, 69);
            trackGPUClockLimit.SmallChange = 10;
            trackGPUClockLimit.TabIndex = 18;
            trackGPUClockLimit.TickFrequency = 50;
            trackGPUClockLimit.TickStyle = TickStyle.TopLeft;
            // 
            // labelGPUClockLimitTitle
            // 
            labelGPUClockLimitTitle.AutoSize = true;
            labelGPUClockLimitTitle.Location = new Point(8, 12);
            labelGPUClockLimitTitle.Name = "labelGPUClockLimitTitle";
            labelGPUClockLimitTitle.Size = new Size(140, 25);
            labelGPUClockLimitTitle.TabIndex = 17;
            labelGPUClockLimitTitle.Text = "Core Clock Limit";
            // 
            // panelTitleGPU
            // 
            panelTitleGPU.AutoSize = true;
            panelTitleGPU.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelTitleGPU.Controls.Add(pictureGPU);
            panelTitleGPU.Controls.Add(labelGPU);
            panelTitleGPU.Dock = DockStyle.Top;
            panelTitleGPU.Location = new Point(0, 0);
            panelTitleGPU.Name = "panelTitleGPU";
            panelTitleGPU.Size = new Size(390, 46);
            panelTitleGPU.TabIndex = 43;
            // 
            // pictureGPU
            // 
            pictureGPU.BackgroundImage = Properties.Resources.icons8_video_card_32;
            pictureGPU.BackgroundImageLayout = ImageLayout.Zoom;
            pictureGPU.ErrorImage = null;
            pictureGPU.InitialImage = null;
            pictureGPU.Location = new Point(8, 14);
            pictureGPU.Margin = new Padding(3, 2, 3, 8);
            pictureGPU.Name = "pictureGPU";
            pictureGPU.Size = new Size(24, 24);
            pictureGPU.TabIndex = 41;
            pictureGPU.TabStop = false;
            // 
            // labelGPU
            // 
            labelGPU.AutoSize = true;
            labelGPU.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelGPU.Location = new Point(34, 13);
            labelGPU.Name = "labelGPU";
            labelGPU.Size = new Size(123, 25);
            labelGPU.TabIndex = 40;
            labelGPU.Text = "GPU Settings";
            // 
            // panelNav
            // 
            panelNav.AutoSize = true;
            panelNav.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelNav.Controls.Add(tableNav);
            panelNav.Dock = DockStyle.Top;
            panelNav.Location = new Point(8, 0);
            panelNav.Name = "panelNav";
            panelNav.Size = new Size(390, 50);
            panelNav.TabIndex = 45;
            // 
            // tableNav
            // 
            tableNav.ColumnCount = 3;
            tableNav.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableNav.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableNav.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableNav.Controls.Add(buttonAdvanced, 0, 0);
            tableNav.Controls.Add(buttonGPU, 0, 0);
            tableNav.Controls.Add(buttonCPU, 0, 0);
            tableNav.Dock = DockStyle.Top;
            tableNav.Location = new Point(0, 0);
            tableNav.Margin = new Padding(2);
            tableNav.MinimumSize = new Size(0, 46);
            tableNav.Name = "tableNav";
            tableNav.Padding = new Padding(0, 2, 0, 1);
            tableNav.RowCount = 1;
            tableNav.RowStyles.Add(new RowStyle());
            tableNav.Size = new Size(390, 50);
            tableNav.TabIndex = 42;
            // 
            // buttonAdvanced
            // 
            buttonAdvanced.Activated = false;
            buttonAdvanced.BackColor = SystemColors.ControlLight;
            buttonAdvanced.Badge = false;
            buttonAdvanced.BorderColor = Color.Transparent;
            buttonAdvanced.BorderRadius = 2;
            buttonAdvanced.Dock = DockStyle.Fill;
            buttonAdvanced.FlatStyle = FlatStyle.Flat;
            buttonAdvanced.Location = new Point(261, 4);
            buttonAdvanced.Margin = new Padding(3, 2, 3, 2);
            buttonAdvanced.Name = "buttonAdvanced";
            buttonAdvanced.Secondary = true;
            buttonAdvanced.Size = new Size(126, 44);
            buttonAdvanced.TabIndex = 51;
            buttonAdvanced.Text = "Advanced";
            buttonAdvanced.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonAdvanced.UseVisualStyleBackColor = false;
            // 
            // buttonGPU
            // 
            buttonGPU.Activated = false;
            buttonGPU.BackColor = SystemColors.ControlLight;
            buttonGPU.Badge = false;
            buttonGPU.BorderColor = Color.Transparent;
            buttonGPU.BorderRadius = 2;
            buttonGPU.Dock = DockStyle.Fill;
            buttonGPU.FlatStyle = FlatStyle.Flat;
            buttonGPU.Location = new Point(132, 4);
            buttonGPU.Margin = new Padding(3, 2, 3, 2);
            buttonGPU.Name = "buttonGPU";
            buttonGPU.Secondary = true;
            buttonGPU.Size = new Size(123, 44);
            buttonGPU.TabIndex = 52;
            buttonGPU.Text = "GPU";
            buttonGPU.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonGPU.UseVisualStyleBackColor = false;
            // 
            // buttonCPU
            // 
            buttonCPU.Activated = false;
            buttonCPU.BackColor = SystemColors.ControlLight;
            buttonCPU.Badge = false;
            buttonCPU.BorderColor = Color.Transparent;
            buttonCPU.BorderRadius = 2;
            buttonCPU.Dock = DockStyle.Fill;
            buttonCPU.FlatStyle = FlatStyle.Flat;
            buttonCPU.Location = new Point(3, 4);
            buttonCPU.Margin = new Padding(3, 2, 3, 2);
            buttonCPU.Name = "buttonCPU";
            buttonCPU.Secondary = true;
            buttonCPU.Size = new Size(123, 44);
            buttonCPU.TabIndex = 50;
            buttonCPU.Text = "CPU";
            buttonCPU.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonCPU.UseVisualStyleBackColor = false;
            // 
            // comboBoost
            // 
            comboBoost.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboBoost.BorderColor = Color.White;
            comboBoost.ButtonColor = Color.FromArgb(255, 255, 255);
            comboBoost.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoost.FormattingEnabled = true;
            comboBoost.Items.AddRange(new object[] { "Disabled", "Enabled", "Aggressive", "Efficient Enabled", "Efficient Aggressive", "Aggressive at Guaranteed", "Efficient at Guaranteed" });
            comboBoost.Location = new Point(10, 9);
            comboBoost.Name = "comboBoost";
            comboBoost.Size = new Size(248, 33);
            comboBoost.TabIndex = 42;
            // 
            // panelBoost
            // 
            panelBoost.Controls.Add(comboBoost);
            panelBoost.Dock = DockStyle.Top;
            panelBoost.Location = new Point(0, 140);
            panelBoost.Name = "panelBoost";
            panelBoost.Size = new Size(390, 48);
            panelBoost.TabIndex = 13;
            // 
            // comboPowerMode
            // 
            comboPowerMode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            comboPowerMode.BorderColor = Color.White;
            comboPowerMode.ButtonColor = Color.FromArgb(255, 255, 255);
            comboPowerMode.DropDownStyle = ComboBoxStyle.DropDownList;
            comboPowerMode.FormattingEnabled = true;
            comboPowerMode.Items.AddRange(new object[] { "Disabled", "Enabled", "Aggressive", "Efficient Enabled", "Efficient Aggressive", "Aggressive at Guaranteed", "Efficient at Guaranteed" });
            comboPowerMode.Location = new Point(10, 9);
            comboPowerMode.Name = "comboPowerMode";
            comboPowerMode.Size = new Size(248, 33);
            comboPowerMode.TabIndex = 42;
            // 
            // panelPowerMode
            // 
            panelPowerMode.Controls.Add(comboPowerMode);
            panelPowerMode.Dock = DockStyle.Top;
            panelPowerMode.Location = new Point(0, 46);
            panelPowerMode.Name = "panelPowerMode";
            panelPowerMode.Size = new Size(390, 48);
            panelPowerMode.TabIndex = 49;
            // 
            // labelPowerModeTitle
            // 
            labelPowerModeTitle.AutoSize = true;
            labelPowerModeTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelPowerModeTitle.Location = new Point(34, 14);
            labelPowerModeTitle.Name = "labelPowerModeTitle";
            labelPowerModeTitle.Size = new Size(201, 25);
            labelPowerModeTitle.TabIndex = 39;
            labelPowerModeTitle.Text = "Windows Power Mode";
            // 
            // picturePowerMode
            // 
            picturePowerMode.BackgroundImage = Properties.Resources.icons8_gauge_32;
            picturePowerMode.BackgroundImageLayout = ImageLayout.Zoom;
            picturePowerMode.InitialImage = null;
            picturePowerMode.Location = new Point(8, 14);
            picturePowerMode.Margin = new Padding(3, 2, 3, 8);
            picturePowerMode.Name = "picturePowerMode";
            picturePowerMode.Size = new Size(24, 24);
            picturePowerMode.TabIndex = 40;
            picturePowerMode.TabStop = false;
            // 
            // panelPowerModeTItle
            // 
            panelPowerModeTItle.AutoSize = true;
            panelPowerModeTItle.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelPowerModeTItle.Controls.Add(picturePowerMode);
            panelPowerModeTItle.Controls.Add(labelPowerModeTitle);
            panelPowerModeTItle.Dock = DockStyle.Top;
            panelPowerModeTItle.Location = new Point(0, 0);
            panelPowerModeTItle.Name = "panelPowerModeTItle";
            panelPowerModeTItle.Size = new Size(390, 46);
            panelPowerModeTItle.TabIndex = 50;
            // 
            // labelBoost
            // 
            labelBoost.AutoSize = true;
            labelBoost.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelBoost.Location = new Point(34, 14);
            labelBoost.Name = "labelBoost";
            labelBoost.Size = new Size(101, 25);
            labelBoost.TabIndex = 39;
            labelBoost.Text = "CPU Boost";
            // 
            // pictureBoost
            // 
            pictureBoost.BackgroundImage = Properties.Resources.icons8_rocket_32;
            pictureBoost.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoost.InitialImage = null;
            pictureBoost.Location = new Point(8, 14);
            pictureBoost.Margin = new Padding(3, 2, 3, 8);
            pictureBoost.Name = "pictureBoost";
            pictureBoost.Size = new Size(24, 24);
            pictureBoost.TabIndex = 40;
            pictureBoost.TabStop = false;
            // 
            // panelBoostTitle
            // 
            panelBoostTitle.AutoSize = true;
            panelBoostTitle.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelBoostTitle.Controls.Add(pictureBoost);
            panelBoostTitle.Controls.Add(labelBoost);
            panelBoostTitle.Dock = DockStyle.Top;
            panelBoostTitle.Location = new Point(0, 94);
            panelBoostTitle.Name = "panelBoostTitle";
            panelBoostTitle.Size = new Size(390, 46);
            panelBoostTitle.TabIndex = 48;
            // 
            // labelPowerLimits
            // 
            labelPowerLimits.AutoSize = true;
            labelPowerLimits.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelPowerLimits.Location = new Point(34, 12);
            labelPowerLimits.Name = "labelPowerLimits";
            labelPowerLimits.Size = new Size(119, 25);
            labelPowerLimits.TabIndex = 39;
            labelPowerLimits.Text = "Power Limits";
            // 
            // pictureBoxCPU
            // 
            pictureBoxCPU.BackgroundImage = Properties.Resources.icons8_processor_32;
            pictureBoxCPU.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxCPU.InitialImage = null;
            pictureBoxCPU.Location = new Point(8, 14);
            pictureBoxCPU.Margin = new Padding(3, 2, 3, 8);
            pictureBoxCPU.Name = "pictureBoxCPU";
            pictureBoxCPU.Size = new Size(24, 24);
            pictureBoxCPU.TabIndex = 40;
            pictureBoxCPU.TabStop = false;
            // 
            // panelTitleCPU
            // 
            panelTitleCPU.AutoSize = true;
            panelTitleCPU.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelTitleCPU.Controls.Add(pictureBoxCPU);
            panelTitleCPU.Controls.Add(labelPowerLimits);
            panelTitleCPU.Dock = DockStyle.Top;
            panelTitleCPU.Location = new Point(0, 188);
            panelTitleCPU.Name = "panelTitleCPU";
            panelTitleCPU.Size = new Size(390, 46);
            panelTitleCPU.TabIndex = 42;
            // 
            // Fans
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1012, 1570);
            Controls.Add(panelFans);
            Controls.Add(panelSliders);
            Margin = new Padding(3, 2, 3, 2);
            MinimizeBox = false;
            MinimumSize = new Size(25, 839);
            Name = "Fans";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Text = "Fans and Power";
            panelFans.ResumeLayout(false);
            panelFans.PerformLayout();
            tableFanCharts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartGPU).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartCPU).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartXGM).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartMid).EndInit();
            panelTitleFans.ResumeLayout(false);
            panelTitleFans.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picturePerf).EndInit();
            panelApplyFans.ResumeLayout(false);
            panelApplyFans.PerformLayout();
            panelSliders.ResumeLayout(false);
            panelSliders.PerformLayout();
            panelAdvanced.ResumeLayout(false);
            panelAdvanced.PerformLayout();
            panelAdvancedAlways.ResumeLayout(false);
            panelAdvancedApply.ResumeLayout(false);
            panelUViGPU.ResumeLayout(false);
            panelUViGPU.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackUViGPU).EndInit();
            panelUV.ResumeLayout(false);
            panelUV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackUV).EndInit();
            panelTitleAdvanced.ResumeLayout(false);
            panelTitleAdvanced.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureUV).EndInit();
            panelTemperature.ResumeLayout(false);
            panelTemperature.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackTemp).EndInit();
            panelTitleTemp.ResumeLayout(false);
            panelTitleTemp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureTemp).EndInit();
            panelDownload.ResumeLayout(false);
            panelDownload.PerformLayout();
            panelPower.ResumeLayout(false);
            panelPower.PerformLayout();
            panelApplyPower.ResumeLayout(false);
            panelCPU.ResumeLayout(false);
            panelCPU.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackCPU).EndInit();
            panelFast.ResumeLayout(false);
            panelFast.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackFast).EndInit();
            panelSlow.ResumeLayout(false);
            panelSlow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackSlow).EndInit();
            panelTotal.ResumeLayout(false);
            panelTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackTotal).EndInit();
            panelGPU.ResumeLayout(false);
            panelGPU.PerformLayout();
            panelGPUTemp.ResumeLayout(false);
            panelGPUTemp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackGPUTemp).EndInit();
            panelGPUBoost.ResumeLayout(false);
            panelGPUBoost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackGPUBoost).EndInit();
            panelGPUPower.ResumeLayout(false);
            panelGPUPower.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackGPUPower).EndInit();
            panelGPUMemory.ResumeLayout(false);
            panelGPUMemory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackGPUMemory).EndInit();
            panelGPUCore.ResumeLayout(false);
            panelGPUCore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackGPUCore).EndInit();
            panelGPUClockLimit.ResumeLayout(false);
            panelGPUClockLimit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackGPUClockLimit).EndInit();
            panelTitleGPU.ResumeLayout(false);
            panelTitleGPU.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureGPU).EndInit();
            panelNav.ResumeLayout(false);
            tableNav.ResumeLayout(false);
            panelBoost.ResumeLayout(false);
            panelPowerMode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picturePowerMode).EndInit();
            panelPowerModeTItle.ResumeLayout(false);
            panelPowerModeTItle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoost).EndInit();
            panelBoostTitle.ResumeLayout(false);
            panelBoostTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCPU).EndInit();
            panelTitleCPU.ResumeLayout(false);
            panelTitleCPU.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panelFans;
        private Panel panelSliders;
        private TableLayoutPanel tableFanCharts;
        private Chart chartGPU;
        private Chart chartCPU;
        private Chart chartMid;
        private Chart chartXGM;
        private Label labelTip;
        private Panel panelPower;
        private RCheckBox checkApplyPower;
        private Panel panelTitleFans;
        private Panel panelApplyFans;
        private Label labelFansResult;
        private RCheckBox checkApplyFans;
        private RButton buttonReset;
        private PictureBox picturePerf;
        private Label labelFans;
        private RComboBox comboModes;
        private RButton buttonAdd;
        private RButton buttonRemove;
        private RButton buttonRename;
        private Panel panelUV;
        private Label labelUV;
        private Label labelLeftUV;
        private TrackBar trackUV;
        private PictureBox pictureUV;
        private Label labelTitleUV;
        private RButton buttonApplyAdvanced;
        private Panel panelApplyPower;
        private Panel panelAdvanced;
        private Panel panelAdvancedApply;
        private Panel panelTitleAdvanced;
        private Panel panelUViGPU;
        private Label labelUViGPU;
        private Label labelLeftUViGPU;
        private TrackBar trackUViGPU;
        private Panel panelNav;
        private TableLayoutPanel tableNav;
        private RButton buttonCPU;
        private RButton buttonGPU;
        private RButton buttonAdvanced;
        private Label labelBoostTitle;
        private Label labelRisky;
        private Panel panelTitleTemp;
        private PictureBox pictureTemp;
        private Label labelTempLimit;
        private Panel panelTemperature;
        private Label labelTemp;
        private Label labelLeftTemp;
        private TrackBar trackTemp;
        private Panel panelAdvancedAlways;
        private RCheckBox checkApplyUV;
        private RButton buttonCalibrate;
        private Panel panelSlow;
        private Label labelSlow;
        private Label labelLeftSlow;
        private Panel panelDownload;
        private RButton buttonDownload;
        private Panel panelCPU;
        private Label labelCPU;
        private Label labelLeftCPU;
        private TrackBar trackCPU;
        private Panel panelFast;
        private Label labelFast;
        private Label labelLeftFast;
        private TrackBar trackFast;
        private TrackBar trackSlow;
        private Panel panelTotal;
        private Label labelTotal;
        private Label labelLeftTotal;
        private TrackBar trackTotal;
        private Panel panelGPU;
        private Panel panelGPUTemp;
        private Label labelGPUTemp;
        private Label labelGPUTempTitle;
        private TrackBar trackGPUTemp;
        private Panel panelGPUBoost;
        private Label labelGPUBoost;
        private Label labelGPUBoostTitle;
        private TrackBar trackGPUBoost;
        private Panel panelGPUPower;
        private Label labelGPUPower;
        private Label labelGPUPowerTitle;
        private TrackBar trackGPUPower;
        private Panel panelGPUMemory;
        private Label labelGPUMemory;
        private Label labelGPUMemoryTitle;
        private TrackBar trackGPUMemory;
        private Panel panelGPUCore;
        private Label labelGPUCore;
        private TrackBar trackGPUCore;
        private Label labelGPUCoreTitle;
        private Panel panelGPUClockLimit;
        private Label labelGPUClockLimit;
        private TrackBar trackGPUClockLimit;
        private Label labelGPUClockLimitTitle;
        private Panel panelTitleGPU;
        private PictureBox pictureGPU;
        private Label labelGPU;
        private Panel panelTitleCPU;
        private PictureBox pictureBoxCPU;
        private Label labelPowerLimits;
        private Panel panelBoost;
        private RComboBox comboBoost;
        private Panel panelBoostTitle;
        private PictureBox pictureBoost;
        private Label labelBoost;
        private Panel panelPowerMode;
        private RComboBox comboPowerMode;
        private Panel panelPowerModeTItle;
        private PictureBox picturePowerMode;
        private Label labelPowerModeTitle;
    }
}