﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaSimplesT4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddContato_Click(object sender, EventArgs e)
        {
            // Criar nosso primeiro contato (um OBJETO da classe Contato).
            Contato objetoContato = new Contato();
            lstContatos.Items.Add(objetoContato.ToString());
        }
    }
}
