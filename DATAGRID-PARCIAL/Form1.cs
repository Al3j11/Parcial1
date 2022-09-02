using System.Drawing.Printing;
using System.Security.Cryptography.X509Certificates;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Linq;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
namespace DATAGRID_PARCIAL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int columna0=0;
        int fila0=0;
        int columna1=0;
        int fila1=0; 
        int columna2=0;
        int fila2=0;
        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region inicializacion

        private int[,] Grid2Mat ( DataGridView X)
        {
            int nf = X.RowCount;
            int nc = X.ColumnCount;
            int[,] resu = new int[nf, nc];
            
            for (int i =0; i < nf; i++)
            {
                for(int j =0; j < nc; j++)
                {
                    resu[i, j] = int.Parse(s: X.Rows[i].Cells[j].Value.ToString());

                }
            }
            return resu;

        }
        private void Mat2grid(int[,] B, DataGridView d)
        {
            int nf = B.GetLength(0);
            int nc = B.GetLength(1);
            d.RowCount = nf;
            d.ColumnCount = nc;

            for (int i = 0; i < nf; i++)
            {
                for (int j = 0; j < nc; j++)
                {
                    d.Rows[i].Cells[j].Value = B[i, j].ToString();

                }
            }
        }
        #endregion inicializacion

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if (textFilasMA.Text =="" & textColmMA.Text == "")
            {
                MessageBox.Show("Hay campos vacios *RELLENA TODOS LOS CAMPOS");
                textFilasMA.Focus();

            }
            if (textFilasMA.Text != "" & textColmMA.Text != "")
            {
                fila1= Convert.ToInt32(textFilasMA.Text);
                columna1 = Convert.ToInt32(textColmMA.Text);

                matrizA.RowCount = fila1;
                matrizA.ColumnCount = columna1;
                textColmMA.Text = "";
                textFilasMA.Text = "";

            }
            if (textFilasMB.Text == "" & textColmMB.Text == "")
            {
                MessageBox.Show("Hay campos vacios *RELLENA TODOS LOS CAMPOS");
                textFilasMA.Focus();

            }
            if (textFilasMB.Text != "" & textColmMB.Text != "")
            {
                fila2 = Convert.ToInt32(textFilasMB.Text);
                columna2 = Convert.ToInt32(textColmMB.Text);

                matrizB.RowCount = fila2;
                matrizB.ColumnCount = columna2;
                textColmMB.Text = "";
                textFilasMB.Text = "";

            }

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonMultiplicar_Click(object sender, EventArgs e)
        {
            int[,] Mat = Grid2Mat(matrizA);
            int[,] Mat2 = Grid2Mat(matrizB);
            int FILA = Mat.GetLength(0);
            int COL1 = Mat.GetLength(1);
            int FILA2 = Mat.GetLength(0);
            int COL2 = Mat.GetLength(1);

            if(FILA > FILA2)
            {
                columna0 = FILA;
            }
            else
            {
                columna0 = FILA2;
            }
            if(COL1 > COL2)
            {
                fila0 = COL1;
            }
            else
            {
                fila0 = COL2;
            }
            if(COL1 ==FILA2)
            {
                int multiplicación, resultado = 0;
                int[,] A = new int[columna0, fila0];
                
                
                    for (int j = 0; j < COL2; j++)
                    {
                    multiplicación = 0;
                        for (int i = 0; i < COL1; i++)
                        {
                        resultado = Mat[j,i] * Mat2[j,i];
                        multiplicación = resultado;
                            A[j, i] = multiplicación;
                        }
                        
                        Mat2grid(A,matrizRAB);
                    }
                
            }
            if (FILA > FILA2)
            {
                columna0 = FILA;
            }
            else
            {
                columna0 = FILA2;
            }
            if (COL1 > COL2)
            {
                fila0 = COL1;
            }
            else
            {
                fila0 = COL2;
            }
            if (COL1 == FILA)
            {
                int multiplicación, resultado = 0;
                int[,] A = new int[columna0, fila0];


                for (int x = 0; x < FILA; x++)
                {
                    multiplicación = 0;
                    for (int y = 0; y < COL1; y++)
                    {
                        resultado = Mat[x, y] * Mat2[x, y];
                        multiplicación =  resultado;
                        A[y, x] = multiplicación;
                    }
                    Mat2grid(A, matrizRBA);

                
               
                    
                }

            }
            else
            {
                MessageBox.Show("Matriz invalida");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
