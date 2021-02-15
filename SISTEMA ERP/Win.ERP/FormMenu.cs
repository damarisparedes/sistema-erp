﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.ERP
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }
        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void FormMenu_Load(object sender, EventArgs e)
        {
            Login();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login();
        }
        private void Login()
        {
            var FormLogin = new FormLogin();
            FormLogin.ShowDialog();
        }

        private void iniciarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormLogin = new FormLogin();
            FormLogin.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login();
        }
        private void cotizacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formCotizaciones = new FormCotizaciones();
            formCotizaciones.MdiParent = this;
            formCotizaciones.Show();
        }
        private void facturasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var formFacturas = new FormFacturas();
            formFacturas.MdiParent = this;
            formFacturas.Show();
        }

        private void pedidosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var formPedidos = new FormPedidos();
            formPedidos.MdiParent = this;
            formPedidos.Show();
        }
        private void reportesDeFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReportFacturas = new FormReporteFactura();
            formReportFacturas.MdiParent = this;
            formReportFacturas.Show();
        }

        private void reportesDePedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReportPedidos = new FormReportePedido();
            formReportPedidos.MdiParent = this;
            formReportPedidos.Show();
        }

        

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formInfo = new FormInfo();
            formInfo.MdiParent = this;
            formInfo.Show();
        }
    }
}

