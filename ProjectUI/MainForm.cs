﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjectUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void tsb_CreateUser_Click(object sender, EventArgs e)
        {
            CreateUserDlg myDlg = new CreateUserDlg();
            myDlg.ShowDialog();
        }
    }
}
