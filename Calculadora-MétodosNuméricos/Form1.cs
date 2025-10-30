using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_MétodosNuméricos
{
    public partial class Form1 : Form
    {
        int n=0;
        double[,] X;
        double[] Res;
        bool estatus = false;
        double delta;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Limpiar();
        }

        void Limpiar()
        {
            txtX11.Clear();
            txtX12.Clear();
            txtX13.Clear();
            txtR1.Clear();
            txtX21.Clear();
            txtX22.Clear();
            txtX23.Clear();
            txtR2.Clear();
            txtX31.Clear();
            txtX32.Clear();
            txtX33.Clear();
            txtR3.Clear();
            rb22.Checked = false;
            rb33.Checked = false;
            rbGauss.Checked = false;
            Bloqueo();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Gauss();
        }

        private void rb22_CheckedChanged(object sender, EventArgs e)
        {
            Bloqueo();
            txtX11.Enabled = true;
            txtX12.Enabled = true;
            txtX21.Enabled = true;
            txtX22.Enabled = true;
            txtR1.Enabled = true;
            txtR2.Enabled = true;
            n = 2;
        }
        private void rb33_CheckedChanged(object sender, EventArgs e)
        {
            txtX11.Enabled = true;
            txtX12.Enabled = true;
            txtX13.Enabled = true;
            txtX21.Enabled = true;
            txtX22.Enabled = true;
            txtX23.Enabled = true;
            txtX31.Enabled = true;
            txtX32.Enabled = true;
            txtX33.Enabled = true;
            txtR1.Enabled = true;
            txtR2.Enabled = true;
            txtR3.Enabled = true;
            n = 3;
        }

        void Procedimiento()
        {
            for (int k = 0; k < n; k++)
            {
                double pivote = X[k, k];
                if (pivote == 0)
                {
                    Console.WriteLine("No se puede dividir entre 0. Sistema sin solución única.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                for (int j = 0; j < n; j++)
                    X[k, j] /= pivote;
                Res[k] /= pivote;

                for (int i = 0; i < n; i++)
                {
                    if (i != k)
                    {
                        double factor = X[i, k];
                        for (int j = 0; j < n; j++)
                            X[i, j] -= factor * X[k, j];
                        Res[i] -= factor * Res[k];
                    }
                }
            }
        }

        void Bloqueo()
        {
            txtX11.Enabled = false;
            txtX12.Enabled = false;
            txtX13.Enabled = false;
            txtX21.Enabled = false;
            txtX22.Enabled = false;
            txtX23.Enabled = false;
            txtX31.Enabled = false;
            txtX32.Enabled = false;
            txtX33.Enabled = false;
            txtR1.Enabled = false;
            txtR2.Enabled = false;
            txtR3.Enabled = false;
        }
        void Verificador()
        {
            if (rb22.Checked)
            {
                if (txtX11.Text != "" && txtX12.Text != "" && txtX21.Text != "" && txtX22.Text != "" && txtR1.Text != "" && txtR2.Text != "")
                {
                    estatus = true;
                }
                else
                    MessageBox.Show("No se pueden dejar campos vacíos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (rb33.Checked)
            {
                if (txtX11.Text != "" && txtX12.Text != "" && txtX13.Text != "" && txtX21.Text != "" && txtX22.Text != "" && txtX23.Text != "" && txtX31.Text != "" && txtX32.Text != "" && txtX33.Text != "" && txtR1.Text != "" && txtR2.Text != "" && txtR3.Text != "")
                {
                    estatus = true;
                }
                else
                    MessageBox.Show("No se pueden dejar campos vacíos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Seleccione un tamaño de matriz", "Tamaño no especificado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        void DeltaDos()
        {
            delta = (X[0,0] * X[1,1]) - (X[0,1] * X[1,0]);
        }
        void DeltaTres()
        {
            delta = (X[0, 0] * ((X[1, 1] * X[2, 2]) - (X[1, 2] * X[2, 1]))) - (X[0, 1] * ((X[1, 0] * X[2, 2]) - (X[1, 2] * X[2, 0]))) + (X[0, 2] * ((X[1, 0] * X[2, 1]) - (X[1, 2] * X[2, 0])));
        }

        void Puente()
        {
            if (estatus == true)
            {
                if (rbGauss.Checked)
                {
                    if (rb22.Checked)
                    {
                        X = new double[n, n];
                        Res = new double[n];
                        X[0, 0] = double.Parse(txtX11.Text);
                        X[0, 1] = double.Parse(txtX12.Text);
                        Res[0] = double.Parse(txtR1.Text);
                        X[1, 0] = double.Parse(txtX21.Text);
                        X[1, 1] = double.Parse(txtX22.Text);
                        Res[1] = double.Parse(txtR2.Text);
                        DeltaDos();
                        if (delta != 0)
                            Procedimiento();
                        else
                            MessageBox.Show("La matriz tiene soluciones infinitas o no tiene una", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (rb33.Checked)
                    {
                        X = new double[n, n];
                        Res = new double[n];
                        X[0, 0] = double.Parse(txtX11.Text);
                        X[0, 1] = double.Parse(txtX12.Text);
                        X[0, 2] = double.Parse(txtX13.Text);
                        Res[0] = double.Parse(txtR1.Text);
                        X[1, 0] = double.Parse(txtX21.Text);
                        X[1, 1] = double.Parse(txtX22.Text);
                        X[1, 2] = double.Parse(txtX23.Text);
                        Res[1] = double.Parse(txtR2.Text);
                        X[2, 0] = double.Parse(txtX31.Text);
                        X[2, 1] = double.Parse(txtX32.Text);
                        X[2, 2] = double.Parse(txtX33.Text);
                        Res[2] = double.Parse(txtR3.Text);
                        DeltaTres();
                        if (delta != 0)
                            Procedimiento();
                        else
                            MessageBox.Show("La matriz tiene soluciones infinitas o no tiene una", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                    MessageBox.Show("Seleccione un método de resolución primero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void Resultado()
        {
            if (rbGauss.Checked)
            {
                string ResFinal = "";
                for (int i = 0; i < n; i++)
                {
                    ResFinal += $"\nX{i + 1}: {Res[i]}";
                }
                MessageBox.Show(ResFinal, "Resultado");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult Cerrar = MessageBox.Show("¿Realmente quieres cerrar el programa?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Cerrar == DialogResult.Yes)
                this.Close();
        }

        void Gauss()
        {
            Verificador();
            Puente();
            Resultado();
        }
    }
}