using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Creating_texting_File
{
    public partial class frmlab : Form
    {
        public frmlab()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FrmFileName frmfname = new FrmFileName();
            frmfname.ShowDialog();

            string getInput = txtInput.Text;

            string docPath =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath,
            FrmFileName.SetFileName)))

            {
                outputFile.WriteLine(getInput);
                Console.WriteLine(getInput);
            }

           
        }
    }
}
