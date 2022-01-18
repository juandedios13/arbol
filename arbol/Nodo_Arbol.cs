using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing; // Librería para dibujar figuras geométricas
using System.Windows.Forms;
using System.Threading;
using System.Collections;

namespace arbol
{
    class Nodo_Arbol
    {
        public int info;
        public Nodo_Arbol Izquierdo;
        public Nodo_Arbol Derecho; 
        public Nodo_Arbol Padre; 
        public int altura;
        public int nivel;
        public Rectangle nodo;
        public int Buscar;

        private Arbol_Binario arbol; // declarando un objeto de tipo Árbol Binario
        public Nodo_Arbol()
        {
        }
        // Constructor por defecto
        public Arbol_Binario Arbol
        {
            get { return arbol; }
            set { arbol = value; }
        }
        // Constructor por defecto para el objeto de tipo Arbol
        // Constructor con parámetros
        public Nodo_Arbol(int nueva_info, Nodo_Arbol izquierdo, Nodo_Arbol derecho,
        Nodo_Arbol padre)
        {
            info = nueva_info;
            Izquierdo = izquierdo;
            Derecho = derecho;
            Padre = padre;
            altura = 0;
        }

        public Nodo_Arbol Insertar(int x, Nodo_Arbol t, int Level)
        {
            
            if (t == null)
            {
                t = new Nodo_Arbol(x, null, null, null);
                t.nivel = Level;
                //t.altura = 0; 
            }
            else if (x < t.info)
            {
                Level++;
                t.Padre = t;
               // t.altura += 1;
                t.Izquierdo = Insertar(x, t.Izquierdo, Level);
                
            }
            else if (x > t.info)
            {
                Level++;
                t.Padre = t;
               // t.altura += 1;
                t.Derecho = Insertar(x, t.Derecho, Level);
               
            }
            else
            {
                MessageBox.Show("Dato Existente en el Arbol", "Error de Ingreso");
            }
            return t;
        }
        // Función para calcular la altura de un nodo en el Árbol Binario
        public  int Alturas(Nodo_Arbol t)
        {
            return t == null ? -1 : t.altura;
        }
        // Función para eliminar un nodo del Árbol Binario
        public void Eliminar(int x, ref Nodo_Arbol t)
        {
            if (t != null) // Si raíz es distinta de null
            {
                if (x < t.info) // Si el valor a insertar es menor que la raíz
                {
                    Eliminar(x, ref t.Izquierdo);
                }
                else
                {
                    if (x > t.info) // Si el valor a insertar es menor que la raíz
                    {
                        Eliminar(x, ref t.Derecho);
                    }
                    else
                    {
                        Nodo_Arbol NodoEliminar = t; // Ya se ubicó el nodo que se desea eliminar
                        if (NodoEliminar.Derecho == null) // Se verifica si tiene hijo derecho
                        {
                            t = NodoEliminar.Izquierdo;
                        }
                        else
                        {
                            if (NodoEliminar.Izquierdo == null) // Se verifica si tiene hijo izquierdo
                            {
                                t = NodoEliminar.Derecho;
                            }
                            else
                            {
                                if (Alturas(t.Izquierdo) - Alturas(t.Derecho) > 0)
                                // Para verificar que hijo pasa a ser nueva raíz del subárbol
                                {
                                    Nodo_Arbol AuxiliarNodo = null;
                                    Nodo_Arbol Auxiliar = t.Izquierdo;
                                    bool Bandera = false;
                                    while (Auxiliar.Derecho != null)
                                    {
                                        AuxiliarNodo = Auxiliar;
                                        Auxiliar = Auxiliar.Derecho;
                                        Bandera = true;
                                    }
                                    t.info = Auxiliar.info; // Se crea un nodo temporal
                                    NodoEliminar = Auxiliar;
                                    if (Bandera == true)
                                    {
                                        AuxiliarNodo.Derecho = Auxiliar.Izquierdo;
                                    }
                                    else
                                    {
                                        t.Izquierdo = Auxiliar.Izquierdo;
                                    }
                                }
                                else
                                {
                                    if (Alturas(t.Derecho) - Alturas(t.Izquierdo) > 0)
                                    {
                                        Nodo_Arbol AuxiliarNodo = null;
                                        Nodo_Arbol Auxiliar = t.Derecho;
                                        bool Bandera = false;
                                        while (Auxiliar.Izquierdo != null)
                                        {
                                            AuxiliarNodo = Auxiliar;
                                            Auxiliar = Auxiliar.Izquierdo;
                                            Bandera = true;
                                        }
                                        t.info = Auxiliar.info;
                                        NodoEliminar = Auxiliar;
                                        if (Bandera == true)
                                        {
                                            AuxiliarNodo.Izquierdo = Auxiliar.Derecho;
                                        }
                                        else
                                        {
                                            t.Derecho = Auxiliar.Derecho;
                                        }
                                    }
                                    else
                                    {
                                        if (Alturas(t.Derecho) - Alturas(t.Izquierdo) == 0)
                                        {
                                            Nodo_Arbol AuxiliarNodo = null;
                                            Nodo_Arbol Auxiliar = t.Izquierdo;
                                            bool Bandera = false;
                                            while (Auxiliar.Derecho != null)
                                            {
                                                AuxiliarNodo = Auxiliar;
                                                Auxiliar = Auxiliar.Derecho;
                                                Bandera = true;
                                            }
                                            t.info = Auxiliar.info;
                                            NodoEliminar = Auxiliar;
                                            if (Bandera == true)
                                            {
                                                AuxiliarNodo.Derecho = Auxiliar.Izquierdo;
                                            }
                                            else
                                            {
                                                t.Izquierdo = Auxiliar.Izquierdo;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Nodo NO Existente en el Arbol", "Error de Eliminacion");
            }
        }


        // Función para recorrer el Árbol Binario (búsqueda de un nodo)
        public Nodo_Arbol buscar(int x, Nodo_Arbol t)
        {

            //Nodo_Arbol aux;
            do
            {

                if (t != null)
                {
                    if (x < t.info)
                    {

                        t = t.Izquierdo;

                    }
                    else
                    {
                        if (x > t.info)
                        {
                            t = t.Derecho;
                        }
                    }
                    //return t.nivel;
                    // colorear()
                }
                else
                    MessageBox.Show("Nodo NO Encontrado en el Arbol", " Error de Busqueda");
                if (t == null)
                {
                    return null;
                }
            } while ( x != t.info);
            this.Buscar = x;
            return t;
        }

        public void encontrado(Nodo_Arbol t) {
            Rectangle rec = new Rectangle(t.CoordenadaX, t.CoordenadaY, 40, 40);
        }

        public Nodo_Arbol Menor(  Nodo_Arbol t) { 
            while (t.Izquierdo != null)
            {
                //t.Padre = t;
                t = t.Izquierdo;
                //Console.WriteLine(t.Padre.info);

            };
            return t;
        }

        public Nodo_Arbol mayor(Nodo_Arbol t)
        {
            while (t.Derecho != null)
            {
                //t.Padre = t;
                t = t.Derecho;
                //Console.WriteLine(t.Padre.info);

            };
            return t;
        }

        public int AlturaIz(Nodo_Arbol t)
        {
            int c = 1;
            while (t.Izquierdo != null)
            {
                c++;
                t = t.Izquierdo;

            };
            return c;
        }

        public int AlturaD(Nodo_Arbol t)
        {
            int c = 1;
            while (t.Derecho != null)
            {
                c++;
                t = t.Derecho;

            };
            return c;
        }

        public ArrayList recorrer(Nodo_Arbol t, ArrayList lista) {

            if (t.Izquierdo != null)
            {
                recorrer(t.Izquierdo,lista);
            }
            lista.Add(t.info);
            if (t.Derecho != null)
            {
                recorrer(t.Derecho,lista);
            }

            return lista;
        }

        public ArrayList PreOrden(Nodo_Arbol t, ArrayList lista)
        {
            lista.Add(t.info);
            if (t.Izquierdo != null)
            {
                PreOrden(t.Izquierdo, lista);
            }
            if (t.Derecho != null)
            {
                PreOrden(t.Derecho, lista);
            }

            return lista;
        }

        public ArrayList PostOrden(Nodo_Arbol t, ArrayList lista)
        {
            
            if (t.Izquierdo != null)
            {
                PostOrden(t.Izquierdo, lista);
            }
            if (t.Derecho != null)
            {
                PostOrden(t.Derecho, lista);
            }
            lista.Add(t.info);

            return lista;
        }




        public int Nsiguiente(Nodo_Arbol t,int x)
        {
            //Nodo_Arbol aux;


            do
            {

                if (t != null)
                {

                    if (x < t.info)
                    {
                        
                         if (x != t.Izquierdo.info)
                        {
                            if (t.Izquierdo.Derecho != null)
                            {
                                t = t.Izquierdo;
                            }
                            else
                            {
                                t = t.Izquierdo;
                            }
                            
                            
                        }
                        else{

                            
                            if (t.Izquierdo.Derecho == null)
                            {
                                t = t.Izquierdo;
                            }
                            else if (t.Izquierdo.Derecho != null)
                            {
                                if (x == t.Izquierdo.info)
                                {
                                    x = t.Izquierdo.Derecho.info;
                                }
                                else
                                {
                                    x = t.info;
                                }
                                
                            }
                            
                        }
                        

                    }
                    else
                    {
                        if (x > t.info)
                        {
                            if (x == t.info)
                            {
                                x = t.info;
                                break;
                            }

                            t = t.Derecho;
                        }
                        
                    }
                    //return t.nivel;
                    // colorear()
                }
                else
                    MessageBox.Show("Nodo NO Encontrado en el Arbol", " Error de Busqueda");

            } while (x != t.info);
            this.Buscar = x;
            return x;
        }


        public Nodo_Arbol Menor1(Nodo_Arbol t,int x)
        {
            do
            {

                if (t != null)
                {
                    if (x < t.info)
                    {
                        if (t.Izquierdo != null && t.Izquierdo.info == x)
                        {
                            break;
                        }

                        t = t.Izquierdo;

                    }
                    else
                    {
                        if (x > t.info)
                        {
                            if (x != this.Derecho.info && t.Derecho != null && t.Derecho.info == x)
                            {
                                break;
                            }
                            t = t.Derecho;
                        }
                    }
                    //return t.nivel;
                    // colorear()
                }
                else
                    MessageBox.Show("Nodo NO Encontrado en el Arbol", " Error de Busqueda");

            } while (x != t.info);
            this.Buscar = x;
            return t;
        }

        public Nodo_Arbol Enorden( Nodo_Arbol t)
        {
            if (t != null)
            {

                if (t.Padre != null) 
                {
                    if (t.Padre.info > t.info)
                    {
                        t = t.Padre;
                    }
                    else 
                    {
                        if (t.Izquierdo.info < t.info)
                        {

                            t = t.Izquierdo;

                        }
                        else
                        {
                            if (t.Derecho.info > t.info)
                            {
                                t = t.Derecho;
                            }
                        }
                    }
                    
                }
                else
                {
                    if (t.Izquierdo.info < t.info)
                    {

                        t = t.Izquierdo;

                    }
                    else
                    {
                        if (t.Derecho.info > t.info)
                        {
                            t = t.Derecho;
                        }
                    }
                }
                
                //return t.nivel;
                // colorear()
            }
            return t;
        }

        

        //// ***** Funciones para el dibujo de los nodos del Árbol Binario en el Formulario **********
        // variable que define el tamaño de los círculos que representarán los nodos del árbol
        private const int Radio = 30;
        private const int DistanciaH = 80; // variable para manejar distancia horizontal
        private const int DistanciaV = 10; // variable para manejar distancia vertical
        private int CoordenadaX; // variable para manejar posición Eje X
        private int CoordenadaY; // variable para manejar posición Eje Y
                                 //Función para encontrar la posición donde se creará (dibujará) el nodo
        public void PosicionNodo(ref int xmin, int ymin)
        {
            int aux1, aux2;
            CoordenadaY = (int)(ymin + Radio / 2);
            //obtiene la posicion del Sub-Arbol izquierdo.
            if (Izquierdo != null)
            {
                Izquierdo.PosicionNodo(ref xmin, ymin + Radio + DistanciaV);
            }
            if ((Izquierdo != null) && (Derecho != null))
            {
                xmin += DistanciaH;
            }
            //Si existe el nodo derecho y el nodo izquierdo deja un espacio entre ellos
            if (Derecho != null)
            {
                Derecho.PosicionNodo(ref xmin, ymin + Radio + DistanciaV);
            }
            if (Izquierdo != null && Derecho != null)
                CoordenadaX = (int)((Izquierdo.CoordenadaX + Derecho.CoordenadaX) / 2);
            else if (Izquierdo != null)
            {
                aux1 = Izquierdo.CoordenadaX;
                Izquierdo.CoordenadaX = CoordenadaX - 80;
                CoordenadaX = aux1;
            }
            else if (Derecho != null)
            {
                aux2 = Derecho.CoordenadaX;
                //no hay nodo izquierdo, centrar en nodo derecho.
                Derecho.CoordenadaX = CoordenadaX + 80;
                CoordenadaX = aux2;
            }
            else
            {
                CoordenadaX = (int)(xmin + Radio / 2);
                xmin += Radio;
            }
        }

        // Función para dibujar las ramas de los nodos izquierdo y derecho
        public void DibujarRamas(Graphics grafo, Pen Lapiz)
        {
            if (Izquierdo != null)
            {
                grafo.DrawLine(Lapiz, CoordenadaX, CoordenadaY, Izquierdo.CoordenadaX,
                Izquierdo.CoordenadaY);
                Izquierdo.DibujarRamas(grafo, Lapiz);
            }
            if (Derecho != null)
            {
                grafo.DrawLine(Lapiz, CoordenadaX, CoordenadaY, Derecho.CoordenadaX,
                Derecho.CoordenadaY);
                Derecho.DibujarRamas(grafo, Lapiz);
            }
        }


        // Función para dibujar el nodo en la posición especificada.
        public void DibujarNodo(Graphics grafo, Font fuente, Brush Relleno, Brush
        RellenoFuente, Pen Lapiz, Brush encuentro)
        {
           // Console.WriteLine("pintar");
            //Dibuja el contorno del nodo
            Rectangle rect = new Rectangle((int)(CoordenadaX - Radio / 2), (int)(CoordenadaY
            - Radio / 2), Radio, Radio);
            //prueba = new Rectangle((int)(CoordenadaX - Radio / 2), (int)(CoordenadaY - Radio
           // / 2), Radio, Radio);
            grafo.FillEllipse(encuentro, rect);
            grafo.FillEllipse(Relleno, rect);
            grafo.DrawEllipse(Lapiz, rect);
            // Para dibujar el nombre del nodo, es decir el contenido
            StringFormat formato = new StringFormat();
            formato.Alignment = StringAlignment.Center;
            formato.LineAlignment = StringAlignment.Center;
            grafo.DrawString(info.ToString(), fuente, RellenoFuente, CoordenadaX,
            CoordenadaY, formato);
            //Dibuja los nodos hijos derecho e izquierdo.
            if (Izquierdo != null)
            {
                Izquierdo.DibujarNodo(grafo, fuente, Relleno, RellenoFuente, Lapiz, encuentro);
            }
            if (Derecho != null)
            {
                Derecho.DibujarNodo(grafo, fuente, Relleno, RellenoFuente, Lapiz, encuentro);
            }
        }

        // Función para dibujar el nodo en la posición especificada.
        public void DibujarNodoBuscar(Graphics grafo, Font fuente, Brush Relleno, Brush
        RellenoFuente, Pen Lapiz, Brush encuentro,Nodo_Arbol t)
        {
            //Console.WriteLine("buscar");
            //Dibuja el contorno del nodo
            Rectangle rect = new Rectangle((int)(CoordenadaX - Radio / 2), (int)(CoordenadaY
            - Radio / 2), Radio, Radio);
            if (t.info == this.info)
            {
                Relleno = new SolidBrush(Color.Red);
               rect = new Rectangle((int)(t.CoordenadaX - Radio / 2), (int)(t.CoordenadaY
                - Radio / 2), Radio, Radio);
            }
            else
            {
                Relleno = new SolidBrush(Color.Blue);
            }
            //prueba = new Rectangle((int)(CoordenadaX - Radio / 2), (int)(CoordenadaY - Radio
            // / 2), Radio, Radio);
            grafo.FillEllipse(encuentro, rect);
            grafo.FillEllipse(Relleno, rect);
            grafo.DrawEllipse(Lapiz, rect);
            // Para dibujar el nombre del nodo, es decir el contenido
            StringFormat formato = new StringFormat();
            formato.Alignment = StringAlignment.Center;
            formato.LineAlignment = StringAlignment.Center;
            grafo.DrawString(info.ToString(), fuente, RellenoFuente, CoordenadaX,
            CoordenadaY, formato);
            //Dibuja los nodos hijos derecho e izquierdo.
            if (Izquierdo != null)
            {
                Izquierdo.DibujarNodoBuscar(grafo, fuente, Relleno, RellenoFuente, Lapiz, encuentro,t);
            }
            if (Derecho != null)
            {
                Derecho.DibujarNodoBuscar(grafo, fuente, Relleno, RellenoFuente, Lapiz, encuentro,t);
            }
        }

        // Función para dar color al nodo del Árbol Binario
        public void colorear(Graphics grafo, Font fuente, Brush Relleno, Brush
        RellenoFuente, Pen Lapiz)
        {
            //Dibuja el contorno del nodo.
            Rectangle rect = new Rectangle((int)(CoordenadaX - Radio / 2), (int)(CoordenadaY
            - Radio / 2), Radio, Radio);
            //prueba = new Rectangle((int)(CoordenadaX - Radio / 2), (int)(CoordenadaY - Radio
           // / 2), Radio, Radio);
            grafo.FillEllipse(Relleno, rect);
            grafo.DrawEllipse(Lapiz, rect);
            //Dibuja el nombre
            StringFormat formato = new StringFormat();
            formato.Alignment = StringAlignment.Center;
            formato.LineAlignment = StringAlignment.Center;
            grafo.DrawString(info.ToString(), fuente, RellenoFuente, CoordenadaX,
            CoordenadaY, formato);
        }


    }


}
