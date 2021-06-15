using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SREDEN_USPEH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        double BEL, Math, Foreign, Phys, Informatics, Bio;

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            Form form2 = new Form();
            form2.Show();
        }

        List<Student> students = new List<Student>();

        private void buttonAverage_Click(object sender, EventArgs e)
        {
             textBoxAverage.Text = ((double.Parse(textBoxBEL.Text) + double.Parse(textBoxMath.Text) + double.Parse(textBoxInformatics.Text) + double.Parse(textBoxPhys.Text) + double.Parse(textBoxBio.Text) + double.Parse(textBoxForeign.Text)) / 6).ToString();
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            textBoxCLas.Clear();
            textBoxID.Clear();
            textBoxName.Clear();
            textBoxBEL.Clear();
            textBoxForeign.Clear();
            textBoxMath.Clear();
            textBoxInformatics.Clear();
            textBoxPhys.Clear();
            textBoxBio.Clear();
            textBoxAverage.Clear();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {  
            Student student = new Student(textBoxName.Text, int.Parse(textBoxID.Text),
                                            textBoxCLas.Text, double.Parse(textBoxBEL.Text),
                                            double.Parse(textBoxMath.Text),
                                            double.Parse(textBoxForeign.Text), double.Parse(textBoxPhys.Text),
                                            double.Parse(textBoxInformatics.Text), double.Parse(textBoxBio.Text), double.Parse(textBoxAverage.Text));
            students.Add(student);
            StreamWriter A = new StreamWriter(Application.StartupPath + "\\form\\." + "custdetails.txt");
            A.WriteLine(label1.Text + " " + textBoxCLas.Text);
            A.WriteLine(label2.Text + " " + textBoxID.Text);
            A.WriteLine (label3.Text + " " + textBoxName.Text);
            A.WriteLine(label4.Text + " " + textBoxBEL.Text);
            A.WriteLine(label5.Text + " " + textBoxForeign.Text);
            A.WriteLine(label6.Text + " " + textBoxMath.Text);
            A.WriteLine(label7.Text + " " + textBoxInformatics.Text);
            A.WriteLine(label8.Text + " " + textBoxPhys.Text);
            A.WriteLine(label9.Text + " " + textBoxBio.Text);
            A.WriteLine(labelAverage.Text + " " + textBoxAverage.Text);


            A.Close();




        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            foreach (Student student in students)
            {
                if (student.Id == int.Parse(textBoxID.Text) && student.Clas == textBoxCLas.Text)
                {
                    textBoxName.Text = student.Name;
                    textBoxBEL.Text = student.BEL.ToString();
                    textBoxMath.Text = student.Mathematik.ToString();
                    textBoxPhys.Text = student.Phys.ToString();
                    textBoxInformatics.Text = student.Informatics.ToString();
                    textBoxForeign.Text = student.Foreign.ToString();
                    textBoxBio.Text = student.Bio.ToString();
                    textBoxAverage.Text = student.Avg.ToString();
                }
            }
        }
        



        
    }
}
