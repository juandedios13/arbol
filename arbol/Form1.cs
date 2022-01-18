using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arbol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Declaración de variables a utilizar
        int Dato = 0;
        int cont = 0;
        int n = 0;
        int m = 0;
        int b = 0;
        Nodo_Arbol aux;
        Arbol_Binario mi_Arbol = new Arbol_Binario(null); // Creación del objeto Árbol
        Graphics g;
        SolidBrush color = new SolidBrush(Color.Blue);

        

        // Evento que permitirá insertar un nodo al Árbol (código del botón “Insertar Nodo” del
        //formulario mostrado en la figura
       
        private void btnInsertar_Click_1(object sender, EventArgs e)
        {
            if (txtDato.Text == "")
            {
                MessageBox.Show("Debe Ingresar un Valor");
            }
            else
            {
                Dato = int.Parse(txtDato.Text);
                if (Dato <= 0 || Dato >= 100)
                    MessageBox.Show("Solo Recibe Valores desde 1 hasta 99", "Error de Ingreso");
                else
                {
                    mi_Arbol.Insertar(Dato);
                    txtDato.Clear();
                    txtDato.Focus();
                    cont++;
                    color = new SolidBrush(Color.Blue);
                    Refresh();
                    Refresh();
                }
            }
        }

        private void Form1_Paint_1(object sender, PaintEventArgs en)
        {
            en.Graphics.Clear(this.BackColor);
            en.Graphics.TextRenderingHint =
            System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            en.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g = en.Graphics;

            if (n == 1)
            {
                mi_Arbol.DibujarArbolBusqueda(g, this.Font, color, Brushes.White, Pens.Black,
            Brushes.White,aux);

            }else
            {
                mi_Arbol.DibujarArbol(g, this.Font, color, Brushes.White, Pens.Black,
                Brushes.White);
            }
            
            
        }

        private void Button_eliminar_Click(object sender, EventArgs e)
        {
            if (txtDatoEliminar.Text == "")
            {
                MessageBox.Show("Debe Ingresar un Valor");
            }
            else
            {
                Dato = int.Parse(txtDatoEliminar.Text);
                if (Dato <= 0 || Dato >= 100)
                    MessageBox.Show("Solo Recibe Valores desde 1 hasta 99", "Error de Ingreso");
                else
                {
                    
                    mi_Arbol.Eliminar(Dato);
                    txtDato.Clear();
                    txtDato.Focus();
                    color = new SolidBrush(Color.Blue);
                    Refresh();
                    Refresh();
                }
            }
        }

        private void Button_Buscar_Click(object sender, EventArgs e)
        {
            if (txtDatoBuscar.Text == "")
            {
                MessageBox.Show("Debe Ingresar un Valor");
            }
            else
            {
                Dato = int.Parse(txtDatoBuscar.Text);
                if (Dato <= 0 || Dato >= 100)
                    MessageBox.Show("Solo Recibe Valores desde 1 hasta 99", "Error de Ingreso");
                else
                {

                    
                    aux = mi_Arbol.Buscar(Dato);
                    if (aux != null)
                    {
                        // mi_Arbol.colorear(g, this.Font, color, Brushes.White, Pens.Black,t,true,true,true);
                        txtDato.Clear();
                        txtDato.Focus();
                        cont++;
                        //color = new SolidBrush(Color.Red);
                        n = 1;
                        Refresh();
                        Refresh();
                        n = 0;
                    }
                    else
                    {
                        MessageBox.Show("numero no enconctrado");
                    }
                   
                }
            }
        }


        private void Enorden_Click(object sender, EventArgs e) 
        {

            n = 1;
            int x;
            ArrayList lista = new ArrayList();
            lista = mi_Arbol.inorden();
            foreach (var item in lista)
            {
                aux = mi_Arbol.Buscar(Convert.ToInt32(item));
                Refresh();
                Refresh();
                Thread.Sleep(2000);
            }
            n = 0;
        }

        private void Preorden_Click(object sender, EventArgs e)
        {
            n = 1;
            int x;
            ArrayList lista = new ArrayList();
            lista = mi_Arbol.PreOrden();
            foreach (var item in lista)
            {
                aux = mi_Arbol.Buscar(Convert.ToInt32(item));
                Refresh();
                Refresh();
                Thread.Sleep(2000);
            }
            n = 0;
        }

        private void PostOrden_Click(object sender, EventArgs e)
        {
            n = 1;
            int x;
            ArrayList lista = new ArrayList();
            lista = mi_Arbol.PostOrden();
            foreach (var item in lista)
            {
                aux = mi_Arbol.Buscar(Convert.ToInt32(item));
                Refresh();
                Refresh();
                Thread.Sleep(2000);
            }
            n = 0;
        }

        private void Menor_Click(object sender, EventArgs e)
        {
            n = 1;
            aux = mi_Arbol.menor();
            Refresh();
            Refresh();
            n = 0;
        }

        private void Mayor_Click(object sender, EventArgs e)
        {
            n = 1;
            aux = mi_Arbol.mayor();
            Refresh();
            Refresh();
            n = 0;
        }

        private void Suma_Click(object sender, EventArgs e)
        {
            ArrayList lista = new ArrayList();
            lista = mi_Arbol.inorden();
            int suma = 0;
            foreach (var item in lista)
            {
                suma = suma + Convert.ToInt32(item);
            }

            sumatxt.Text = suma.ToString();
        }

        private void m2_Click(object sender, EventArgs e)
        {
            ArrayList lista = new ArrayList();
            lista = mi_Arbol.inorden();
            int suma = 0;
            foreach (var item in lista)
            {
                if (Convert.ToInt32(item) % 2 == 0)
                {
                    suma = suma + Convert.ToInt32(item);
                }
            }

            m2txt.Text = suma.ToString();
        }

        private void M3_Click(object sender, EventArgs e)
        {
            ArrayList lista = new ArrayList();
            lista = mi_Arbol.inorden();
            int suma = 0;
            foreach (var item in lista)
            {
                if (Convert.ToInt32(item) % 3 == 0)
                {
                    suma = suma + Convert.ToInt32(item);
                }
            }

            m3txt.Text = suma.ToString();
        }

        private void M5_Click(object sender, EventArgs e)
        {
            ArrayList lista = new ArrayList();
            lista = mi_Arbol.inorden();
            int suma = 0;
            foreach (var item in lista)
            {
                if (Convert.ToInt32(item) % 5 == 0)
                {
                    suma = suma + Convert.ToInt32(item);
                }
            }

            m5txt.Text = suma.ToString();
        }

        private void Altura_Click(object sender, EventArgs e)
        {
            int a = 0;
            a = mi_Arbol.altura();
            alturaxtx.Text = a.ToString();
        }

        private void alturaxtx_ReadOnlyChanged(object sender, EventArgs e)
        {

        }
    }
}
