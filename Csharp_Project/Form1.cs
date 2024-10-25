using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Csharp_Project
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            General_class General_class = new General_class();

            var lstStudents = new List<Class_linq_students>()
            {
                new  Class_linq_students {firstname="Hisham",lastname="Bakr" },
               new  Class_linq_students {firstname="Ali",lastname="Mohamed" }

            };

            var studnts = from stud in lstStudents
                          select stud;

            foreach (Class_linq_students item in studnts)
            {
                textBox1.Text += "First name = " +item.firstname + " last name = " + item.lastname;
                textBox1.Text += Environment.NewLine;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // create students and salary
            General_class General_class = new General_class();
            General_class.createfileStudents();
            General_class.createfileEmployee();
            General_class.copyStudents();
            //students
            textBox1.Text = EnumClass.dayworks.monday.ToString() +Environment.NewLine;
            textBox1.Text += General_class.readfileStudents();
            // salary
            int bonos = 0;
            int minus = 200;
            int total = (bonos + General_class.readfileEmployee()) - minus;
            if(total >=6300)
            {
                total += 300;
            }
            else if(total <=5500)
            {
                total -= 100;
            }
            textBox1.Text += "total salary is " + total;
            textBox1.Text += "Bonus salary is " + bonos;
            textBox1.Text += "Deduct from salary is " + minus;
            //return datatable 
            DataTable dtEmps = General_class.dtGetEmployees();
            foreach (DataRow dr in dtEmps.Rows)
            {
                textBox1.Text += " Employee name : " + dr["name"].ToString();
                textBox1.Text += " Country name : " + dr["Country"].ToString();
            }

            // return hashtable
            Hashtable hashEmp = General_class.gethash();
            foreach (DictionaryEntry item in hashEmp)
            {
                textBox1.Text += item.Key + " is : " + item.Value;
            }

        }
    }
}
