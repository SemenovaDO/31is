﻿using System;
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
    public partial class ИнвентаризацияСкладТкани : Form
    {
        public static ИнвентаризацияСкладТкани inventory;
        public ИнвентаризацияСкладТкани()
        {
            InitializeComponent();
        }

        private void Инвентаризация_Load(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Form1.fa == 3)
            {
                dataGridView1.AllowUserToAddRows = true;
                dataGridView1.AllowUserToDeleteRows = true;
                dataGridView1.ReadOnly = false;
            }
            else
            {
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AllowUserToDeleteRows = false;
                dataGridView1.ReadOnly = true;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Storekeeper.stor.Show();
            this.Close();
        }
    }
}
