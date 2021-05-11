using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseSchedule
{
    public partial class Form1 : Form
    {
        Dictionary<string, int> CourseRoom = new Dictionary<string, int>()
        {
            { "CS101", 3004 }, {"CS102", 4501},
            {"CS103", 6755}, {"NT110", 1244}, {"CM241", 1411}
        };
        Dictionary<string, string> CourseInstructor = new Dictionary<string, string>()
        {
            {"CS101", "Haynes"}, {"CS102", "Alvarado"},
            {"CS103", "Rich"}, {"NT110", "Burke"}, {"CM241", "Lee"}
        };
        Dictionary<string, string> CourseTime = new Dictionary<string, string>()
        {
            {"CS101", "8:00 AM"}, {"CS102", "9:00 AM"},
            {"CS103", "10:00 AM"}, {"NT110", "11:00 AM"}, {"CM241", "1:00 PM"}
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void courseInfoBtn_Click(object sender, EventArgs e)
        {
            try 
            {
                string course = courseIn.Text;
                course = course.ToUpper();
                int roomNum;
                string instructor;
                string time;

                courseLbl.Text = course;
                roomNum = CourseRoom[course];
                instructor = CourseInstructor[course];
                time = CourseTime[course];

                courseLbl.Text = course;
                roomLbl.Text = roomNum.ToString();
                instrutorLbl.Text = instructor;
                timeLbl.Text = time;

            }
            catch(Exception ex)
            {
                MessageBox.Show("Unknown Course Number: Course Room Is Entered In Correct Format");
            }
            
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            courseIn.Text = "";
            courseLbl.Text = "";
            roomLbl.Text = "";
            instrutorLbl.Text = "";
            timeLbl.Text = "";
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
