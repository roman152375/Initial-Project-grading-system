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
        double _finalmarks;
        string _grade;
        public report()
        {
            InitializeComponent();
        }
        public report(double finalmarks, string grade)
        {
            _finalmarks = finalmarks;
            _grade = grade ;
            InitializeComponent();
        }

        private void report_Load(object sender, EventArgs e)
        {

            txtFinalMark.Text = _finalmarks.ToString();
            txtFinalMark.Visible = true;

            txtGrade.Text = _grade.ToString();
            txtGrade.Visible = true;
        }
    }
}
