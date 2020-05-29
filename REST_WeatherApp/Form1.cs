using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using REST_WinformDEMO;
using REST_WinformDEMO.Controllers;
using REST_WinformDEMO.Models;

namespace REST_WeatherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            REST_WinformDEMO.Controllers.WeatherController controller = new WeatherController();
            List<WeatherInfo> get = controller.Get();
            StringBuilder sb = new StringBuilder(
                );
            foreach (WeatherInfo itemInfo in get)
            {
                sb.Append(itemInfo.Location);
                sb.Append(Environment.NewLine);
                sb.Append(itemInfo.Degree);
                sb.Append(Environment.NewLine);
                sb.Append(itemInfo.DateTime);
            }

            this.richTextBox1.Text = sb.ToString();
        }
    }
}
