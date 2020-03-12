using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double attendance, quiz1, quiz2, quiz3, project, assignment, final, finalmarks;
        double attendanceP, quiz1P, quiz2P, quiz3P, projectP, assignmentP, finalP;
        public Form1()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCaculate_Click(object sender, EventArgs e)
        {
           

                 attendance = double.Parse(txtAttendance.Text);
            quiz1 = double.Parse(txtQuiz1.Text);
            quiz2 = double.Parse(txtQuiz2.Text);
            quiz3 = double.Parse(txtQuiz3.Text);
            project = double.Parse(txtProject.Text);
            assignment = double.Parse(txtAssignment.Text);
            final = double.Parse(txtFinal.Text);

            attendanceP = (attendance / 20) * 5;
            quiz1P = (quiz1 / 100) * 5;
            quiz2P = (quiz2 / 100) * 5;
            quiz3P = (quiz3 / 100) * 5;
            projectP = (project / 100) * 15;
            assignmentP = (assignment / 100) * 5;
            finalP = (final / 100) * 60;

            finalmarks = attendanceP + quiz1P + quiz2P + quiz3P + projectP + assignmentP + finalP;

            txtFinalMark.Text = finalmarks.ToString();
            txtFinalMark.Visible = true;

            if (finalmarks >= 89.5)
                txtGrade.Text = "A";
            else if (finalmarks >= 79.5)
                txtGrade.Text = "B";
            else if (finalmarks >= 69.5)
                txtGrade.Text = "C";
            else if (finalmarks >= 59.5)
                txtGrade.Text = "D";
            else
                txtGrade.Text = "F";

            txtGrade.Visible = true;



        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            report newform = new report(txtId.Text, txtName.Text,
                txtProgram.Text,txtModule.Text, txtstDate.Text,
                txtEndDate.Text, txtInstructor.Text, finalmarks, txtGrade.Text);
            newform.ShowDialog();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtName.Clear();
            txtProgram.Clear();
            txtModule.Clear();
            txtstDate.Clear();
            txtEndDate.Clear();
            txtInstructor.Clear();
            txtFinalMark.Clear();
            txtGrade.Clear();
            txtAttendance.Clear();
            txtQuiz1.Clear();
            txtQuiz2.Clear();
            txtQuiz3.Clear();
            txtProject.Clear();
            txtAssignment.Clear();
            txtFinal.Clear();

        }
    }
}
