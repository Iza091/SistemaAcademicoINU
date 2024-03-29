﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAcademico
{
    public partial class Matricula : Form
    {
        public Matricula()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Matriculas frm = new Matriculas();
            frm.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Matriculas frm = new Matriculas();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                frm.txtCodigo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                frm.txtName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                frm.txtApellido.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
               // frm.txtEspecialidad.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
               // frm.txtSeccion.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
               // frm.txtModalidad.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                frm.ShowDialog();

            }
            else
                MessageBox.Show("DEBE SELECCIONAR UNA FILA PARA EDITAR");
        }

        private void Matricula_Load(object sender, EventArgs e)
        {
            
            // TODO: esta línea de código carga datos en la tabla 'dataSet.Estudiante' Puede moverla o quitarla según sea necesario.
            this.estudianteTableAdapter.Fill(this.dataSet.Estudiante);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Falta el cuadro de busqueda");
        }

       // private void button2_Click(object sender, EventArgs e)
       // {
           
       // }

        private void button2_Click_1(object sender, EventArgs e)
        {
            InformeMatricula matriculas = new InformeMatricula();
            matriculas.ShowDialog();
        }
    }
}
