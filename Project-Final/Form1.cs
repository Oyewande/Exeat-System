using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Final
{
    public partial class Application_form : Form
    {
        public Application_form()
        {
            InitializeComponent();
        }

        private void dayexeat_Click(object a, EventArgs q)
        {
            DayExeatForm day = new DayExeatForm();

            day.Show();
        }

        private void homeexeat_Click(object a, EventArgs q)
        {
            HomeExeatForm home = new HomeExeatForm();

            home.Show();
        }

        private void exitbtn_Click(object a, EventArgs q)
        {
            Application.Exit();
        }

        private void Application_form_Load(object a, EventArgs q)
        {

        }
    }
}
