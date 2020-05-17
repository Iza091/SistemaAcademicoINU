﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SistemaAcademico
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
            
            if (this.Opacity < 1) this.Opacity += 0.05;
         
            //Circular
            for (int i = 0; i < 100; i++)
            {
                circularProgressBar1.Value = i;
                circularProgressBar1.Update();
                if (circularProgressBar1.Value == 100)
                {
                    timer1.Stop();
                    timer2.Start();
                   
                }
            }
            
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                timer2.Stop();
                this.Close();
            }
        }
        private void PanelBarraTitulo_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
          
            circularProgressBar1.Value = 0;
            circularProgressBar1.Minimum = 0;
            circularProgressBar1.Maximum = 100;
            timer1.Start();
            





        }
    }
}
