﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DTO;
using BUS;

namespace ProjectWedding
{
    public partial class FSanh : Form
    {
        public FSanh()
        {
            InitializeComponent();
        }

        private void btsReturn_Click(object sender, EventArgs e)
        {
            FMain main = new FMain();
            this.Hide();
            this.Close();
            main.Show();
        }

        private FSanh_BUS sanhBUS;
        private FSanh_DTO sanhDTO = new FSanh_DTO();

        private void FSanh_Load(object sender, EventArgs e)
        {

            sanhBUS = new FSanh_BUS();
            gridSanh.DataSource = sanhBUS.LoadData();
        }

        private void ptAdd_Click(object sender, EventArgs e)
        {
        }

        private void gridSanh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
