﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Luta3
{
    public partial class Form1 : Form
    {
        int player;
        public Form1(int player)
        {
            InitializeComponent();
            this.player = player;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            labelTitulo.Text = string.Format("Player {0} - Escolha seu personagem", this.player);
        }

        private void btn_general_Click(object sender, EventArgs e)
        {
            MessageBox.Show("General!");
        }

        private void btn_general_Click_1(object sender, EventArgs e)
        {

        }

        
    }
}
