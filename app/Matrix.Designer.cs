namespace GHelper
{
    partial class Matrix
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
            pictureMatrix = new PictureBox();
            trackZoom = new TrackBar();
            buttonPicture = new UI.RButton();
            panelPicture = new Panel();
            panelMain = new Panel();
            panelButtons = new Panel();
            buttonReset = new UI.RButton();
            panelGamma = new Panel();
            labelGamma = new Label();
            labelGammaTitle = new Label();
            trackGamma = new TrackBar();
            panelContrast = new Panel();
            labelContrast = new Label();
            labelContrastTitle = new Label();
            trackContrast = new TrackBar();
            panelRotation = new Panel();
            comboRotation = new UI.RComboBox();
            labelRotation = new Label();
            panelScaling = new Panel();
            comboScaling = new UI.RComboBox();
            labelScaling = new Label();
            panelZoom = new Panel();
            labelZoom = new Label();
            labelZoomTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureMatrix).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackZoom).BeginInit();
            panelPicture.SuspendLayout();
            panelMain.SuspendLayout();
            panelButtons.SuspendLayout();
            panelGamma.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackGamma).BeginInit();
            panelContrast.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackContrast).BeginInit();
            panelRotation.SuspendLayout();
            panelScaling.SuspendLayout();
            panelZoom.SuspendLayout();
            SuspendLayout();
            // 
            // pictureMatrix
            // 
            pictureMatrix.BackColor = Color.Black;
            pictureMatrix.Cursor = Cursors.SizeAll;
            pictureMatrix.Location = new Point(548, 20);
            pictureMatrix.Margin = new Padding(2, 2, 2, 2);
            pictureMatrix.Name = "pictureMatrix";
            pictureMatrix.Size = new Size(61, 55);
            pictureMatrix.TabIndex = 0;
            pictureMatrix.TabStop = false;
            // 
            // trackZoom
            // 
            trackZoom.LargeChange = 50;
            trackZoom.Location = new Point(12, 39);
            trackZoom.Margin = new Padding(2, 2, 2, 2);
            trackZoom.Maximum = 200;
            trackZoom.Minimum = 10;
            trackZoom.Name = "trackZoom";
            trackZoom.Size = new Size(586, 69);
            trackZoom.SmallChange = 10;
            trackZoom.TabIndex = 2;
            trackZoom.TickFrequency = 20;
            trackZoom.TickStyle = TickStyle.TopLeft;
            trackZoom.Value = 100;
            // 
            // buttonPicture
            // 
            buttonPicture.Activated = false;
            buttonPicture.BackColor = SystemColors.ControlLight;
            buttonPicture.Badge = false;
            buttonPicture.BorderColor = Color.Transparent;
            buttonPicture.BorderRadius = 5;
            buttonPicture.FlatAppearance.BorderSize = 0;
            buttonPicture.FlatStyle = FlatStyle.Flat;
            buttonPicture.Image = Properties.Resources.icons8_matrix_32;
            buttonPicture.Location = new Point(12, 14);
            buttonPicture.Margin = new Padding(2, 2, 2, 2);
            buttonPicture.Name = "buttonPicture";
            buttonPicture.Secondary = true;
            buttonPicture.Size = new Size(194, 42);
            buttonPicture.TabIndex = 3;
            buttonPicture.Text = "Picture / Gif";
            buttonPicture.TextAlign = ContentAlignment.MiddleRight;
            buttonPicture.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonPicture.UseVisualStyleBackColor = false;
            // 
            // panelPicture
            // 
            panelPicture.BackColor = Color.Black;
            panelPicture.Controls.Add(pictureMatrix);
            panelPicture.Dock = DockStyle.Top;
            panelPicture.Location = new Point(0, 0);
            panelPicture.Margin = new Padding(2, 2, 2, 2);
            panelPicture.Name = "panelPicture";
            panelPicture.Size = new Size(628, 314);
            panelPicture.TabIndex = 4;
            // 
            // panelMain
            // 
            panelMain.AutoSize = true;
            panelMain.Controls.Add(panelButtons);
            panelMain.Controls.Add(panelGamma);
            panelMain.Controls.Add(panelContrast);
            panelMain.Controls.Add(panelRotation);
            panelMain.Controls.Add(panelScaling);
            panelMain.Controls.Add(panelZoom);
            panelMain.Controls.Add(panelPicture);
            panelMain.Dock = DockStyle.Top;
            panelMain.Location = new Point(15, 15);
            panelMain.Margin = new Padding(2, 2, 2, 2);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(628, 830);
            panelMain.TabIndex = 5;
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(buttonReset);
            panelButtons.Controls.Add(buttonPicture);
            panelButtons.Dock = DockStyle.Top;
            panelButtons.Location = new Point(0, 760);
            panelButtons.Margin = new Padding(2, 2, 2, 2);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(628, 70);
            panelButtons.TabIndex = 6;
            // 
            // buttonReset
            // 
            buttonReset.Activated = false;
            buttonReset.BackColor = SystemColors.ControlLight;
            buttonReset.Badge = false;
            buttonReset.BorderColor = Color.Transparent;
            buttonReset.BorderRadius = 5;
            buttonReset.FlatAppearance.BorderSize = 0;
            buttonReset.FlatStyle = FlatStyle.Flat;
            buttonReset.Image = Properties.Resources.icons8_refresh_32;
            buttonReset.Location = new Point(218, 14);
            buttonReset.Margin = new Padding(2, 2, 2, 2);
            buttonReset.Name = "buttonReset";
            buttonReset.Secondary = true;
            buttonReset.Size = new Size(194, 42);
            buttonReset.TabIndex = 4;
            buttonReset.Text = "Reset";
            buttonReset.TextAlign = ContentAlignment.MiddleRight;
            buttonReset.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonReset.UseVisualStyleBackColor = false;
            // 
            // panelGamma
            // 
            panelGamma.AutoSize = true;
            panelGamma.Controls.Add(labelGamma);
            panelGamma.Controls.Add(labelGammaTitle);
            panelGamma.Controls.Add(trackGamma);
            panelGamma.Dock = DockStyle.Top;
            panelGamma.Location = new Point(0, 650);
            panelGamma.Margin = new Padding(2, 2, 2, 2);
            panelGamma.Name = "panelGamma";
            panelGamma.Size = new Size(628, 110);
            panelGamma.TabIndex = 7;
            // 
            // labelGamma
            // 
            labelGamma.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelGamma.Font = new Font("Segoe UI", 9F);
            labelGamma.Location = new Point(507, 13);
            labelGamma.Margin = new Padding(2, 0, 2, 0);
            labelGamma.Name = "labelGamma";
            labelGamma.Size = new Size(94, 24);
            labelGamma.TabIndex = 4;
            labelGamma.Text = "Brightness";
            labelGamma.TextAlign = ContentAlignment.TopRight;
            // 
            // labelGammaTitle
            // 
            labelGammaTitle.AutoSize = true;
            labelGammaTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelGammaTitle.Location = new Point(12, 13);
            labelGammaTitle.Margin = new Padding(2, 0, 2, 0);
            labelGammaTitle.Name = "labelGammaTitle";
            labelGammaTitle.Size = new Size(102, 25);
            labelGammaTitle.TabIndex = 3;
            labelGammaTitle.Text = "Brightness";
            // 
            // trackGamma
            // 
            trackGamma.LargeChange = 50;
            trackGamma.Location = new Point(12, 39);
            trackGamma.Margin = new Padding(2, 2, 2, 2);
            trackGamma.Maximum = 100;
            trackGamma.Minimum = -100;
            trackGamma.Name = "trackGamma";
            trackGamma.Size = new Size(586, 69);
            trackGamma.SmallChange = 10;
            trackGamma.TabIndex = 2;
            trackGamma.TickFrequency = 20;
            trackGamma.TickStyle = TickStyle.TopLeft;
            // 
            // panelContrast
            // 
            panelContrast.AutoSize = true;
            panelContrast.Controls.Add(labelContrast);
            panelContrast.Controls.Add(labelContrastTitle);
            panelContrast.Controls.Add(trackContrast);
            panelContrast.Dock = DockStyle.Top;
            panelContrast.Location = new Point(0, 540);
            panelContrast.Margin = new Padding(2, 2, 2, 2);
            panelContrast.Name = "panelContrast";
            panelContrast.Size = new Size(628, 110);
            panelContrast.TabIndex = 6;
            // 
            // labelContrast
            // 
            labelContrast.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelContrast.Font = new Font("Segoe UI", 9F);
            labelContrast.Location = new Point(528, 13);
            labelContrast.Margin = new Padding(2, 0, 2, 0);
            labelContrast.Name = "labelContrast";
            labelContrast.Size = new Size(77, 24);
            labelContrast.TabIndex = 4;
            labelContrast.Text = "Contrast";
            labelContrast.TextAlign = ContentAlignment.TopRight;
            // 
            // labelContrastTitle
            // 
            labelContrastTitle.AutoSize = true;
            labelContrastTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelContrastTitle.Location = new Point(12, 13);
            labelContrastTitle.Margin = new Padding(2, 0, 2, 0);
            labelContrastTitle.Name = "labelContrastTitle";
            labelContrastTitle.Size = new Size(84, 25);
            labelContrastTitle.TabIndex = 3;
            labelContrastTitle.Text = "Contrast";
            // 
            // trackContrast
            // 
            trackContrast.LargeChange = 50;
            trackContrast.Location = new Point(12, 39);
            trackContrast.Margin = new Padding(2, 2, 2, 2);
            trackContrast.Maximum = 200;
            trackContrast.Minimum = 10;
            trackContrast.Name = "trackContrast";
            trackContrast.Size = new Size(586, 69);
            trackContrast.SmallChange = 10;
            trackContrast.TabIndex = 2;
            trackContrast.TickFrequency = 20;
            trackContrast.TickStyle = TickStyle.TopLeft;
            trackContrast.Value = 100;
            // 
            // panelRotation
            // 
            panelRotation.Controls.Add(comboRotation);
            panelRotation.Controls.Add(labelRotation);
            panelRotation.Dock = DockStyle.Top;
            panelRotation.Location = new Point(0, 482);
            panelRotation.Margin = new Padding(2, 2, 2, 2);
            panelRotation.Name = "panelRotation";
            panelRotation.Size = new Size(628, 58);
            panelRotation.TabIndex = 8;
            // 
            // comboRotation
            // 
            comboRotation.BorderColor = Color.White;
            comboRotation.ButtonColor = Color.FromArgb(255, 255, 255);
            comboRotation.Font = new Font("Segoe UI", 9F);
            comboRotation.FormattingEnabled = true;
            comboRotation.ItemHeight = 25;
            comboRotation.Items.AddRange(new object[] { "Straight", "Diagonal" });
            comboRotation.Location = new Point(209, 13);
            comboRotation.Margin = new Padding(3, 8, 3, 6);
            comboRotation.Name = "comboRotation";
            comboRotation.Size = new Size(242, 33);
            comboRotation.TabIndex = 17;
            // 
            // labelRotation
            // 
            labelRotation.AutoSize = true;
            labelRotation.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelRotation.Location = new Point(12, 15);
            labelRotation.Margin = new Padding(2, 0, 2, 0);
            labelRotation.Name = "labelRotation";
            labelRotation.Size = new Size(144, 25);
            labelRotation.TabIndex = 4;
            labelRotation.Text = "Image Rotation";
            // 
            // panelScaling
            // 
            panelScaling.Controls.Add(comboScaling);
            panelScaling.Controls.Add(labelScaling);
            panelScaling.Dock = DockStyle.Top;
            panelScaling.Location = new Point(0, 424);
            panelScaling.Margin = new Padding(2, 2, 2, 2);
            panelScaling.Name = "panelScaling";
            panelScaling.Size = new Size(628, 58);
            panelScaling.TabIndex = 7;
            // 
            // comboScaling
            // 
            comboScaling.BorderColor = Color.White;
            comboScaling.ButtonColor = Color.FromArgb(255, 255, 255);
            comboScaling.Font = new Font("Segoe UI", 9F);
            comboScaling.FormattingEnabled = true;
            comboScaling.ItemHeight = 25;
            comboScaling.Items.AddRange(new object[] { "Default", "Low", "High", "Bilinear", "Bicubic", "NearestNeighbor", "HighQualityBilinear", "HighQualityBicubic" });
            comboScaling.Location = new Point(209, 13);
            comboScaling.Margin = new Padding(3, 8, 3, 6);
            comboScaling.Name = "comboScaling";
            comboScaling.Size = new Size(242, 33);
            comboScaling.TabIndex = 17;
            // 
            // labelScaling
            // 
            labelScaling.AutoSize = true;
            labelScaling.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelScaling.Location = new Point(12, 15);
            labelScaling.Margin = new Padding(2, 0, 2, 0);
            labelScaling.Name = "labelScaling";
            labelScaling.Size = new Size(140, 25);
            labelScaling.TabIndex = 4;
            labelScaling.Text = "Scaling Quality";
            // 
            // panelZoom
            // 
            panelZoom.AutoSize = true;
            panelZoom.Controls.Add(labelZoom);
            panelZoom.Controls.Add(labelZoomTitle);
            panelZoom.Controls.Add(trackZoom);
            panelZoom.Dock = DockStyle.Top;
            panelZoom.Location = new Point(0, 314);
            panelZoom.Margin = new Padding(2, 2, 2, 2);
            panelZoom.Name = "panelZoom";
            panelZoom.Size = new Size(628, 110);
            panelZoom.TabIndex = 5;
            // 
            // labelZoom
            // 
            labelZoom.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelZoom.AutoSize = true;
            labelZoom.Font = new Font("Segoe UI", 9F);
            labelZoom.Location = new Point(550, 13);
            labelZoom.Margin = new Padding(2, 0, 2, 0);
            labelZoom.Name = "labelZoom";
            labelZoom.Size = new Size(60, 25);
            labelZoom.TabIndex = 4;
            labelZoom.Text = "Zoom";
            // 
            // labelZoomTitle
            // 
            labelZoomTitle.AutoSize = true;
            labelZoomTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelZoomTitle.Location = new Point(12, 13);
            labelZoomTitle.Margin = new Padding(2, 0, 2, 0);
            labelZoomTitle.Name = "labelZoomTitle";
            labelZoomTitle.Size = new Size(61, 25);
            labelZoomTitle.TabIndex = 3;
            labelZoomTitle.Text = "Zoom";
            // 
            // Matrix
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            ClientSize = new Size(658, 856);
            Controls.Add(panelMain);
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(680, 56);
            Name = "Matrix";
            Padding = new Padding(15, 15, 15, 15);
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "Matrix";
            ((System.ComponentModel.ISupportInitialize)pictureMatrix).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackZoom).EndInit();
            panelPicture.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            panelButtons.ResumeLayout(false);
            panelGamma.ResumeLayout(false);
            panelGamma.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackGamma).EndInit();
            panelContrast.ResumeLayout(false);
            panelContrast.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackContrast).EndInit();
            panelRotation.ResumeLayout(false);
            panelRotation.PerformLayout();
            panelScaling.ResumeLayout(false);
            panelScaling.PerformLayout();
            panelZoom.ResumeLayout(false);
            panelZoom.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureMatrix;
        private TrackBar trackZoom;
        private UI.RButton buttonPicture;
        private Panel panelPicture;
        private Panel panelMain;
        private Panel panelZoom;
        private Label labelZoom;
        private Label labelZoomTitle;
        private Panel panelButtons;
        private UI.RButton buttonReset;
        private Panel panelScaling;
        private Label labelScaling;
        private UI.RComboBox comboScaling;
        private Panel panelRotation;
        private UI.RComboBox comboRotation;
        private Label labelRotation;
        private Panel panelContrast;
        private Label labelContrast;
        private Label labelContrastTitle;
        private TrackBar trackContrast;
        private Panel panelGamma;
        private Label labelGamma;
        private Label labelGammaTitle;
        private TrackBar trackGamma;
    }
}