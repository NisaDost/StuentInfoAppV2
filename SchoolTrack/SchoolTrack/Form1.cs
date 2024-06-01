using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SchoolTrack.Models;

namespace SchoolTrack
{
    public partial class Form1 : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void ListStudentsButton_Click(object sender, EventArgs e)
        {
            studentTableAdapter3.Fill(newSchoolDBDataSet12.STUDENT);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'newSchoolDBDataSet11.STUDENT' table. You can move, or remove it, as needed.


        }

    }
}
