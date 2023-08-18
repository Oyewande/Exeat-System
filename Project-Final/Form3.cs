using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project_Final
{
    public partial class HomeExeatForm : Form
    {
        public HomeExeatForm()
        {
            InitializeComponent();
        }
        private bool IsInputValid()
        {
            if (DateBox2.Text == "" || NameBox2.Text == "" || MatricBox2.Text == "")
                return false;
            if (HallBox2.Text == "" || ProgrammeBox2.Text == "" || LevelBox2.Text == "")
                return false;
            if (PurposeBox2.Text == "" || DestinationBox2.Text == "" || LengthBox2.Text == "")
                return false;
            if (TOABox2.Text == "" || ParentBox2.Text == "" || SignatureBox2.Text == "")
                return false;
            return true;
        }
        private void submitbtn_Click(object a, EventArgs q)
        {
            if (IsInputValid())
            {
                string date = DateBox2.Text.Trim();
                string name = NameBox2.Text.Trim();
                string matno = MatricBox2.Text.Trim();
                string hall = HallBox2.Text.Trim();
                string programme = ProgrammeBox2.Text.Trim();
                string level = LevelBox2.Text.Trim();
                string purpose = PurposeBox2.Text.Trim();
                string destination = DestinationBox2.Text.Trim();
                string length = LengthBox2.Text;
                string TOA = TOABox2.Text.Trim();
                string parentno = ParentBox2.Text;
                string sign = SignatureBox2.Text.Trim();

                string info = "datasource=127.0.0.1;port=3306;username=root;password=;database=exeat;";
                string table = "INSERT INTO details2 (`Date`, `Name`, `Matric No`, `Hall/Room`, `Programme`, `Level`, " +
                                "`Purpose`, `Destination`, `Length of Stay`, `Time of Arrival`, `Parent/Guardian No`, `Official Signature`) " +
                               "VALUES (@Date, @Name, @MatricNo, @HallRoom, @Programme, @Level, @Purpose, " +
                               "@Destination, @LengthofStay, @TimeOfArrival, @ParentGuardianNo, @OfficialSignature)";

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
                prompt.Parameters.AddWithValue("@LengthofStay", length);
                prompt.Parameters.AddWithValue("@TimeofArrival", TOA);
                prompt.Parameters.AddWithValue("@ParentGuardianNo", parentno);
                prompt.Parameters.AddWithValue("@OfficialSignature", sign);

                try
                {
                    connect.Open();
                    if (prompt.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Successful Database entry");
                        DateBox2.Clear(); NameBox2.Clear(); MatricBox2.Clear();
                        HallBox2.Clear(); ProgrammeBox2.Clear(); LevelBox2.Clear();
                        PurposeBox2.Clear(); DestinationBox2.Clear(); LengthBox2.Clear();
                        TOABox2.Clear(); ParentBox2.Clear(); SignatureBox2.Clear();
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

        private void backbtn_Click(object a, EventArgs q)
        {
            Application_form back = Application.OpenForms.OfType<Application_form>().FirstOrDefault();

            if (back != null)
            {
                back.Show();
                this.Hide();
            }
        }
    }
}
