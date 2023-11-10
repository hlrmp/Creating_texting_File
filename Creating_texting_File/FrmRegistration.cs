using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Creating_texting_File
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
            gender();
            program();
        }

        private void gender()
        {
            ArrayList gnder = new ArrayList();

            gnder.Add("Male");
            gnder.Add("Female");

            foreach (string items in gnder)
            {
                cbgender.Items.Add(items);
            }

        }

        private void program()
        {
            string[] ListOfProgram = new string[]
             {
            "BS Information Technology",
            "BS Computer Science",
            "BS Information Systems",
            "BS in Accountancy",
            "BS in Hospitality Management",
            "BS in Tourism Management"
             };

            for (int i = 0; i < 6; i++)
            {
                cbprogram.Items.Add(ListOfProgram[i].ToString());
            }


        }

        public void writer()
        {



            string docPath =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                string sn = "Student No : 0000" + txtstudentno.Text;
                string name = "Full Name :" + txtfname.Text + ", " + txtmname.Text + " " + txtlanme.Text;
                string program = "Program : " + cbprogram.Text;
                string Gender = "Gender : " +  cbgender.Text;
                string age = "Age : " + txtage.Text;
                string birthday = "Birthday : " + datebday.Text;
                string contact = "contact No :" + txtcontactno.Text;



                StreamWriter sw = new StreamWriter(Path.Combine(docPath, FrmFileName.SetFileName));

                sw.WriteLine(" ");
                sw.WriteLine(sn);
                sw.WriteLine(name);
                sw.WriteLine(program);
                sw.WriteLine(Gender);
                sw.WriteLine(age);
                sw.WriteLine(birthday);
                sw.WriteLine(contact);

                sw.Flush();



            MessageBox.Show("Succesfully Registered" , " Thank you ", MessageBoxButtons.OK);


        }

        private void button1_Click(object sender, EventArgs e)
        {
              writer();

        }
    }
}
