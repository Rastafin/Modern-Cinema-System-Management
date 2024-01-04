using Backend.Model;
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

            CreateChart();
        }

        private void AdminPanelStatistics_Load(object sender, EventArgs e, Control.ControlCollection controls)
        {
            buttonStatistics.Enabled = false;
            buttonStatistics.BackColor = Color.SlateGray;

            // Stwórz wykres
            //LiveCharts.WinForms.CartesianChart cartesianChart = new LiveCharts.WinForms.CartesianChart();

        }

        private void CreateChart()
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

            chart1.ChartAreas.Add(chartArea);

            // Tworzenie serii danych
            Series series = new Series("Example Series");
            series.ChartType = SeriesChartType.Pie;
            series.Points.Add(20);
            series.Points.Add(40);
            series.Points.Add(30);
            series.Points.Add(10);
            chart1.Series.Add(series);
            series.ChartArea = "PieChartArea";

            // Ustawienie pozycji legendy wykresu
            chart1.Legends.Add(new Legend("Legend"));
            chart1.Legends[0].Docking = Docking.Bottom;
            //chart1.Legends[0].BackColor = Color.FromArgb(14, 14, 14);

            //chart1.BackColor = Color.FromArgb(14, 14, 14);


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
    }
}
