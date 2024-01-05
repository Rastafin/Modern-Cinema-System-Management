using Backend.Model;
using Backend.Services;
using Org.BouncyCastle.Asn1.Crmf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI
{
    public partial class AdminPanelStatistics : Form
    {
        private readonly User _user;
        public AdminPanelStatistics(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void AdminPanelStatistics_Load(object sender, EventArgs e)
        {
            AdminPanelStatistics_Load(sender, e, Controls);

            CreateChartSexCount();
        }

        private void AdminPanelStatistics_Load(object sender, EventArgs e, Control.ControlCollection controls)
        {
            buttonStatistics.Enabled = false;
            buttonStatistics.BackColor = Color.SlateGray;

        }

        private void CreateChartSexCount()
        {
            // Tworzenie nowego obszaru wykresu
            ChartArea chartArea = new ChartArea();
            chartArea.Name = "PieChartArea";
            chartArea.Position.Auto = false;
            chartArea.Position.Width = 80; // Szerokość obszaru w procentach
            chartArea.Position.Height = 80; // Wysokość obszaru w procentach
            chartArea.Position.X = 10; // Ustawienie położenia X

            chartArea.Position.Y = 10; // Ustawienie położenia Y
            chartArea.BackColor = Color.FromArgb(14, 14, 14);

            chartSex.ChartAreas.Add(chartArea);

            try
            {
                var (malePercentage, femalePercentage, otherPercentage) = ChartDataCalculator.GetUsersSexDataCounts();

                // Tworzenie serii danych
                Series series = new Series("Sex count");
                series.ChartType = SeriesChartType.Pie;
                series.Points.AddXY("Males", malePercentage);
                series.Points.AddXY("Females", femalePercentage);
                series.Points.AddXY("Others", otherPercentage);
                series.Font = new Font("Arial", 12f, FontStyle.Bold);

                chartSex.Series.Add(series);
                series.ChartArea = "PieChartArea";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while trying to load chart data. " + ex.Message);
            }

            // Ustawienie pozycji legendy wykresu
            chartSex.Legends.Add(new Legend("Legend"));
            chartSex.Legends[0].Docking = Docking.Bottom;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            UserMainMenu? userMainMenu = Application.OpenForms.OfType<UserMainMenu>().FirstOrDefault();

            if (userMainMenu != null) { userMainMenu.Show(); }

            this.Close();
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            AdminPanelMainMenu? adminPanelMainMenu = Application.OpenForms.OfType<AdminPanelMainMenu>().FirstOrDefault();

            if (adminPanelMainMenu != null) { adminPanelMainMenu.Show(); }

            this.Close();
        }

        private void chartSex_MouseClick(object sender, MouseEventArgs e)
        {
            resetChartSexFonts();

            var results = chartSex.HitTest(e.X, e.Y, false, ChartElementType.DataPoint);

            foreach (var result in results)
            {
                if (result.ChartElementType == ChartElementType.DataPoint)
                {
                    var dataPoint = chartSex.Series[result.Series.Name].Points[result.PointIndex];
                    labelMessage.Text = $"{dataPoint.AxisLabel} make up {dataPoint.YValues[0]:F2} percent \nof all app users";
                    dataPoint.Font = new Font(dataPoint.Font.FontFamily, dataPoint.Font.Size + 4, dataPoint.Font.Style);
                    //MessageBox.Show($"Cliecked: {dataPoint.AxisLabel} - Value: {dataPoint.YValues[0]}");
                }
            }
        }

        private void resetChartSexFonts()
        {
            foreach (var series in chartSex.Series)
            {
                foreach (var point in series.Points)
                {
                    point.Font = new Font("Arial", 12f, FontStyle.Bold);
                }
            }
        }
    }
}
