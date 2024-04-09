﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RelogioDigital
{
    public partial class Form1 : Form
    {
        public int Horas { get; set; }

        public int Minutos { get; set; }

        public int Segundos { get; set; }

        public Form1()
        {
            InitializeComponent();

            Horas = DateTime.Now.Hour;
            Minutos = DateTime.Now.Minute;
            Segundos = DateTime.Now.Second;

            lblHoras.Text = Convert.ToString(Horas).PadLeft(2, '0');
            lblMinutos.Text = Convert.ToString(Minutos).PadLeft(2, '0');
            lblSegundos.Text = Convert.ToString(Segundos).PadLeft(2, '0');
        }

        private void btnConfigurar_Click(object sender, EventArgs e)
        {
            timerRelogioDigital.Stop();
            btnHorasMais.Visible = true;
            btnHorasMenos.Visible = true;
            btnMinutosMais.Visible = true;
            btnMinutosMenos.Visible = true;
            btnSegundosMais.Visible = true;
            btnSegundosMenos.Visible = true;
            btnOK.Visible = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            btnHorasMais.Visible = false;
            btnHorasMenos.Visible = false;
            btnMinutosMais.Visible = false;
            btnMinutosMenos.Visible = false;
            btnSegundosMais.Visible = false;
            btnSegundosMenos.Visible = false;
            btnOK.Visible = false;
            timerRelogioDigital.Start();
        }

        private void btnHorasMais_Click(object sender, EventArgs e)
        {
            if (Horas == 23)
            {
                Horas = 0;
            }
            else
            {
                Horas++;   
            }

            lblHoras.Text = Convert.ToString(Horas).PadLeft(2, '0');
        }

        private void btnHorasMenos_Click(object sender, EventArgs e)
        {
            if (Horas == 0)
            {
                Horas = 23;
            }
            else
            { 
                Horas--;  
            }

            lblHoras.Text = Convert.ToString(Horas).PadLeft(2, '0');
        }

        private void btnMinutosMais_Click(object sender, EventArgs e)
        {
            if (Minutos == 59)
            { 
                Minutos = 0;
            }
            else
            {
               Minutos++;
            }

            lblMinutos.Text = Convert.ToString(Minutos).PadLeft(2, '0');
        }

        private void btnMinutosMenos_Click(object sender, EventArgs e)
        {
            if (Minutos == 0)
            {
                Minutos = 59;
            }
            else
            {
                Minutos--;
            }
            lblMinutos.Text = Convert.ToString(Minutos).PadLeft(2, '0');
        }

        private void btnSegundosMais_Click(object sender, EventArgs e)
        {
            if (Segundos == 59)
            {
                Segundos = 0;
            }
            else
            {
                Segundos++;
            }
            lblSegundos.Text = Convert.ToString(Segundos).PadLeft(2, '0');
        }

        private void btnSegundosMenos_Click(object sender, EventArgs e)
        {
            if (Segundos == 0)
            {
                Segundos = 59;
            }
            else
            {
                Segundos--;
            }
            lblSegundos.Text = Convert.ToString(Segundos).PadLeft(2, '0');
        }

        private void timerRelogioDigital_Tick(object sender, EventArgs e)
        {

            if (Segundos == 59) 
            {
                Segundos = 0;

                if (Minutos == 59)
                {
                    if (Horas == 23) 
                    { 
                        Horas = 0;
                    }
                    else
                    {
                        Horas++;
                        Minutos = 0;
                    }
                }
                else
                {
                    Minutos++;
                }
            }
            else
            {
                Segundos++;
            }

            lblHoras.Text = Convert.ToString(Horas).PadLeft(2, '0');
            lblMinutos.Text = Convert.ToString(Minutos).PadLeft(2, '0');
            lblSegundos.Text = Convert.ToString(Segundos).PadLeft(2, '0');
        }
    }
}
