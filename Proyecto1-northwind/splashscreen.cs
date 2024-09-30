using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using CircularProgressBar;

namespace Proyecto1_northwind
{
    public partial class splashscreen : Form
    {
        public splashscreen()
        {
            InitializeComponent();
            ConfigurarCircularProgressBar();
        }

        private void splashscreen_Load(object sender, EventArgs e)
        {
            
            CargarProgreso();
        }

        private async void CargarProgreso()
        {
            for (int i = 0; i <= 100; i++)
            {
                ActualizarProgreso(i);
                await Task.Delay(50); 
            }

            
            MainMenu mainMenu = new MainMenu();
            this.Hide();
            mainMenu.Show();
            
        }

        private void ActualizarProgreso(int valor)
        {
            ProgressBar1.Value = valor;  
            ProgressBar1.Text = $"{valor}%";  
        }

        private void ConfigurarCircularProgressBar()
        {
            
            ProgressBar1.Value = 0;
            ProgressBar1.Maximum = 100;
            ProgressBar1.Minimum = 0;

            
            ProgressBar1.ProgressColor = System.Drawing.Color.Blue;
        }
    }
}

