using GHelper.AnimeMatrix;
using GHelper.UI;

namespace GHelper
{
    public partial class Matrix : RForm
    {
        #region Properties

        public AniMatrixControl matrixControl = Program.settingsForm.matrixControl;

        private bool Dragging;
        private int xPos;
        private int yPos;

        private int baseX;
        private int baseY;

        private float uiScale;

        private Image picture;
        private MemoryStream ms = new();

        #endregion

        public Matrix()
        {
            InitializeComponent();
            InitTheme(true);

            #region Strings

            Text = Properties.Strings.AnimeMatrix;
            labelZoomTitle.Text = Properties.Strings.Zoom;
            labelScaling.Text = Properties.Strings.ScalingQuality;
            labelRotation.Text = Properties.Strings.ImageRotation;
            labelContrastTitle.Text = Properties.Strings.Contrast;
            labelGammaTitle.Text = Properties.Strings.Brightness;
            buttonPicture.Text = Properties.Strings.PictureGif;
            buttonReset.Text = Properties.Strings.Reset;

            #endregion

            Shown += Matrix_Shown;
            FormClosing += Matrix_FormClosed;

            uiScale = panelPicture.Width / matrixControl.deviceMatrix.MaxColumns / 3;

            #region Panel Pictures

            panelPicture.Height = (int)(matrixControl.deviceMatrix.MaxRows * uiScale);

            pictureMatrix.MouseUp += PictureMatrix_MouseUp;
            pictureMatrix.MouseMove += PictureMatrix_MouseMove;
            pictureMatrix.MouseDown += PictureMatrix_MouseDown;

            #endregion

            #region Zoom

            trackZoom.MouseUp += TrackZoom_MouseUp;
            trackZoom.ValueChanged += TrackZoom_Changed;
            trackZoom.Value = Math.Min(trackZoom.Maximum, AppConfig.Get("matrix_zoom", 100));

            #endregion

            #region Scaling Quality

            comboScaling.DropDownStyle = ComboBoxStyle.DropDownList;
            comboScaling.SelectedIndex = AppConfig.Get("matrix_quality", 0);
            comboScaling.SelectedValueChanged += ComboScaling_SelectedValueChanged;

            #endregion

            #region Image Rotation

            comboRotation.DropDownStyle = ComboBoxStyle.DropDownList;
            comboRotation.SelectedIndex = AppConfig.Get("matrix_rotation", 0);
            comboRotation.SelectedValueChanged += ComboRotation_SelectedValueChanged;

            #endregion

            #region Contrast

            trackContrast.MouseUp += TrackMatrix_MouseUp;
            trackContrast.ValueChanged += TrackMatrix_ValueChanged;
            trackContrast.Value = Math.Min(trackContrast.Maximum, AppConfig.Get("matrix_contrast", 100));

            #endregion

            #region Brightness

            trackGamma.MouseUp += TrackMatrix_MouseUp;
            trackGamma.ValueChanged += TrackMatrix_ValueChanged;
            trackGamma.Value = Math.Min(trackGamma.Maximum, AppConfig.Get("matrix_gamma", 0));

            #endregion

            #region Panel Buttons

            buttonPicture.Click += ButtonPicture_Click;
            buttonReset.Click += ButtonReset_Click;

            #endregion

            VisualiseMatrix();
        }

        #region Click Events

        private void ButtonReset_Click(object? sender, EventArgs e)
        {
            AppConfig.Set("matrix_gamma", 0);
            AppConfig.Set("matrix_contrast", 100);
            AppConfig.Set("matrix_zoom", 100);
            AppConfig.Set("matrix_x", 0);
            AppConfig.Set("matrix_y", 0);

            trackZoom.Value = 100;
            trackContrast.Value = 100;
            trackGamma.Value = 0;

            SetMatrixPicture();

        }

        private void ButtonPicture_Click(object? sender, EventArgs e)
        {
            matrixControl.OpenMatrixPicture();
        }

        #endregion

        #region Other

        private void TrackMatrix_ValueChanged(object? sender, EventArgs e)
        {
            VisualiseMatrix();
        }

        private void TrackMatrix_MouseUp(object? sender, MouseEventArgs e)
        {
            AppConfig.Set("matrix_contrast", trackContrast.Value);
            AppConfig.Set("matrix_gamma", trackGamma.Value);
            SetMatrixPicture(false);
        }

        private void ComboRotation_SelectedValueChanged(object? sender, EventArgs e)
        {
            AppConfig.Set("matrix_rotation", comboRotation.SelectedIndex);
            SetMatrixPicture(false);
        }

        private void ComboScaling_SelectedValueChanged(object? sender, EventArgs e)
        {
            AppConfig.Set("matrix_quality", comboScaling.SelectedIndex);
            SetMatrixPicture(false);
        }

        private void Matrix_FormClosed(object? sender, FormClosingEventArgs e)
        {
            if (picture is not null) picture.Dispose();
            if (ms is not null) ms.Dispose();

            pictureMatrix.Dispose();

            GC.Collect(GC.MaxGeneration, GCCollectionMode.Forced);
        }

        private void TrackZoom_MouseUp(object? sender, EventArgs e)
        {
            AppConfig.Set("matrix_zoom", trackZoom.Value);
            SetMatrixPicture();
        }

        private void TrackZoom_Changed(object? sender, EventArgs e)
        {
            VisualiseMatrix();
        }

        private void PictureMatrix_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Dragging = true;
                xPos = e.X;
                yPos = e.Y;
            }
        }

        private void PictureMatrix_MouseMove(object? sender, MouseEventArgs e)
        {
            Control c = sender as Control;
            if (Dragging && c != null)
            {
                c.Top = e.Y + c.Top - yPos;
                c.Left = e.X + c.Left - xPos;
            }
        }

        private void PictureMatrix_MouseUp(object? sender, MouseEventArgs e)
        {
            Dragging = false;

            Control c = sender as Control;

            int matrixX = (int)((baseX - c.Left) / uiScale);
            int matrixY = (int)((baseY - c.Top) / uiScale);

            AppConfig.Set("matrix_x", matrixX);
            AppConfig.Set("matrix_y", matrixY);

            SetMatrixPicture(false);
        }

        private void Matrix_Shown(object? sender, EventArgs e)
        {
            FormPosition();
            SetMatrixPicture();
        }

        private void SetMatrixPicture(bool visualise = true)
        {
            matrixControl.SetMatrixPicture(AppConfig.GetString("matrix_picture"), visualise);
        }

        #endregion

        #region Other

        private void VisualiseMatrix()
        {
            labelZoom.Text = trackZoom.Value + "%";
            labelContrast.Text = trackContrast.Value + "%";
            labelGamma.Text = trackGamma.Value + "%";
        }

        public void FormPosition()
        {
            if (Height > Program.settingsForm.Height)
            {
                Top = Program.settingsForm.Top + Program.settingsForm.Height - Height;
            }
            else
            {
                Height = Program.settingsForm.Height;
                Top = Program.settingsForm.Top;
            }

            Left = Program.settingsForm.Left - Width - 5;
        }

        public void VisualiseMatrix(string fileName)
        {
            if (picture is not null) picture.Dispose();

            using (var fs = new FileStream(fileName, FileMode.Open))
            {

                ms.SetLength(0);
                fs.CopyTo(ms);
                ms.Position = 0;
                fs.Close();

                picture = Image.FromStream(ms);

                int width = picture.Width;
                int height = picture.Height;

                int matrixX = AppConfig.Get("matrix_x", 0);
                int matrixY = AppConfig.Get("matrix_y", 0);
                int matrixZoom = AppConfig.Get("matrix_zoom", 100);

                float scale = Math.Min((float)panelPicture.Width / (float)width, (float)panelPicture.Height / (float)height) * matrixZoom / 100;

                pictureMatrix.Width = (int)(width * scale);
                pictureMatrix.Height = (int)(height * scale);

                baseX = panelPicture.Width - pictureMatrix.Width;
                baseY = 0;

                pictureMatrix.Left = baseX - (int)(matrixX * uiScale);
                pictureMatrix.Top = baseY - (int)(matrixY * uiScale);

                pictureMatrix.SizeMode = PictureBoxSizeMode.Zoom;
                pictureMatrix.Image = picture;
            }
        }

        #endregion
    }
}
