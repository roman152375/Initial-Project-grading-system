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
    public partial class report : Form
    {
        string _Id;
        string _Studentname;
        String _Programname;
        string _Module;
        string _Sdate;
        string _Edate;
        string _Instructor;
        double _finalmarks;
        string _grade;
        public report()
        {
            InitializeComponent();
        }
        public report(string Id, string studentname, string programname, 
            string module, string sdate, 
            string edate, string instructor,
            double finalmarks, string grade)
        {
            _Id = Id;
            _Studentname = studentname;
            _Programname = programname;
            _Module = module;
            _Sdate = sdate;
            _Edate = edate;
            _Instructor = instructor;
            _finalmarks = finalmarks;
            _grade = grade ;

            InitializeComponent();
        }

        private void report_Load(object sender, EventArgs e)
        {
            txtId.Text = _Id.ToString();
            txtId.Visible = true;

            txtName.Text = _Studentname.ToString();
            txtName.Visible = true;

            txtProgram.Text = _Programname.ToString();
            txtProgram.Visible = true;

            txtModule.Text = _Module.ToString();
            txtModule.Visible = true;

            txtstDate.Text = _Sdate.ToString();
            txtFinalMark.Visible = true;

            txtEndDate.Text = _Edate.ToString();
            txtEndDate.Visible = true;

            txtInstructor.Text = _Instructor.ToString();
            txtInstructor.Visible = true;

            txtFinalMark.Text = _finalmarks.ToString();
            txtFinalMark.Visible = true;

            txtGrade.Text = _grade.ToString();
            txtGrade.Visible = true;
        }
    }
}
