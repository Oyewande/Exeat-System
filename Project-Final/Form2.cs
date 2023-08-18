using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_Final
{
    public partial class DayExeatForm : Form
    {
        public DayExeatForm()
        {
            InitializeComponent();
        }
        private bool IsInputValid()
        {
            if (DateBox.Text == "" || NameBox.Text == "" || MatricBox.Text == "")
                return false;
            if (HallBox.Text == "" || ProgrammeBox.Text == "" || LevelBox.Text == "")
                return false;
            if (PurposeBox.Text == "" || DestinationBox.Text == "" || TOABox.Text == "")
                return false;
            if (SignatureBox.Text == "")
                return false;
            return true;
        }
        private void submitbutton_Click(object a, EventArgs q)
        {
            if (IsInputValid())
            {
                string date = DateBox.Text.Trim();
                string name = NameBox.Text.Trim();
                string matno = MatricBox.Text.Trim();
                string hall = HallBox.Text.Trim();
                string programme = ProgrammeBox.Text.Trim();
                string level = LevelBox.Text.Trim();
                string purpose = PurposeBox.Text.Trim();
                string destination = DestinationBox.Text.Trim();
                string TOA = TOABox.Text.Trim();
                string sign = SignatureBox.Text.Trim();

                string info = "datasource=127.0.0.1;port=3306;username=root;password=;database=exeat;";
                string table = "INSERT INTO details (`Date`, `Name`, `Matric No`, `Hall/Room`, `Programme`, `Level`, " +
                                "`Purpose`, `Destination`, `Time of Arrival`, `Official Signature`) " +
                               "VALUES (@Date, @Name, @MatricNo, @HallRoom, @Programme, @Level, @Purpose, " +
                               "@Destination, @TimeOfArrival, @OfficialSignature)";

                MySqlConnection connect = new MySqlConnection(info);
                MySqlCommand prompt = new MySqlCommand(table, connect);
                prompt.Parameters.AddWithValue("@Date", date);
                prompt.Parameters.AddWithValue("@Name", name);
                prompt.Parameters.AddWithValue("@MatricNo", matno);
                prompt.Parameters.AddWithValue("@HallRoom", hall);
                prompt.Parameters.AddWithValue("@Programme", programme);
                prompt.Parameters.AddWithValue("@Level", level);
                prompt.Parameters.AddWithValue("@Purpose", purpose);
                prompt.Parameters.AddWithValue("@Destination", destination);
                prompt.Parameters.AddWithValue("@TimeofArrival", TOA);
                prompt.Parameters.AddWithValue("@OfficialSignature", sign);

                try
                {
                    connect.Open();
                    if (prompt.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Successful Database entry");
                        DateBox.Clear(); NameBox.Clear(); MatricBox.Clear();
                        HallBox.Clear(); ProgrammeBox.Clear(); LevelBox.Clear();
                        PurposeBox.Clear(); DestinationBox.Clear(); TOABox.Clear();
                        SignatureBox.Clear();
                    }
                    else
                        MessageBox.Show("Unsuccessful Database entry");
                    connect.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("An error occurred, details as follows: " + ex.Message);
                }
            }
            else
                MessageBox.Show("Check all the text fields, none should be empty");
        }

        private void backbutton_Click(object a, EventArgs q)
        {
            Application_form back = Application.OpenForms.OfType<Application_form>().FirstOrDefault();

            if (back != null)
            {
                back.Show();
                this.Hide();
            }
        }

        private void textBox5_TextChanged(object a, EventArgs q)
        {

        }
    }
}
