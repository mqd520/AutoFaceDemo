﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AutoFacUtils;
using AutoFacDemo.IService;

namespace AutoFacDemo.WinForm
{
    public partial class Form1 : Form
    {
        private IUserService MyService { get { return AutoFacHelper.Resolve<IUserService>(); } }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MyService.MyService1();
        }
    }
}
