﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpBook
{
    public partial class TableOfQuizesForm : Form
    {
        public TableOfQuizesForm()
        {
            InitializeComponent();
        }

        private void labelOverview_Click(object sender, EventArgs e)
        {
            Form form = new QuizeForm1();
            form.Show();
            this.Hide();
        }


        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
