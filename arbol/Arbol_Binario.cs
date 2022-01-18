using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Collections;

namespace arbol
{
    class Arbol_Binario
    {

        public Nodo_Arbol Raiz;
        public Nodo_Arbol aux;
        // Constructor por defecto
        public Arbol_Binario()
        {
            aux = new Nodo_Arbol();
        }

        // Constructor con parámetros
        public Arbol_Binario(Nodo_Arbol nueva_raiz)
        {
            Raiz = nueva_raiz;
        }
        // Función para agregar un nuevo nodo (valor) al Árbol Binario.
        public void Insertar(int x)
        {

            if (Raiz == null)
            {
                Raiz = new Nodo_Arbol(x, null, null, null);
                Raiz.nivel = 0;
                Raiz.altura = 0;
            }
            else
                
                Raiz = Raiz.Insertar(x, Raiz, Raiz.nivel);
                Raiz.altura += 1;
        }
        // Función para eliminar un nodo (valor) del Árbol Binario.
        public void Eliminar(int x)
        {
            if (Raiz == null)
                Raiz = new Nodo_Arbol(x, null, null, null);
            else
                Raiz.Eliminar(x, ref Raiz);
        }

        

        //Funcion para buscar un nodo
        public Nodo_Arbol Buscar(int x )
        {
            Nodo_Arbol t = Raiz;
            if (Raiz != null) { 

             t=  Raiz.buscar(x, Raiz);
            }
            if (t == null)
            {
                return  null;
            }
            return t;
        }

        public Nodo_Arbol menor()
        {
            Nodo_Arbol t = Raiz;
            if (Raiz != null) {  
                t = Raiz.Menor(Raiz);
            }
            return t;
        }

        public Nodo_Arbol padre(Nodo_Arbol t)
        {
            if (t != null)
            {
                t = Raiz.Padre;
            }
            return t;
        }

        public Nodo_Arbol mayor()
        {
            Nodo_Arbol t = Raiz;
            if (Raiz != null)
            {
                t = Raiz.mayor(Raiz);
            }
            return t;
        }

        public ArrayList inorden()
        {
            ArrayList lista = new ArrayList();
            lista = Raiz.recorrer(Raiz, lista);
            return lista;
        }

        public ArrayList PreOrden()
        {
            ArrayList lista = new ArrayList();
            lista = Raiz.PreOrden(Raiz, lista);
            return lista;
        }

        public ArrayList PostOrden()
        {
            ArrayList lista = new ArrayList();
            lista = Raiz.PostOrden(Raiz, lista);
            return lista;
        }

        public int altura()
        {
            int x = 0;
            int c = 0;
            Nodo_Arbol t = Raiz;
            if (Raiz != null)
            {
               x = Raiz.AlturaIz(Raiz);
                c = Raiz.AlturaD(Raiz);
                if (c> x)
                {
                    return c;
                }
            }
            else
            {
                return 0;
            }
            return x;
        }

        public int Nsiguiente(int x)
        {
            Nodo_Arbol t = Raiz;

            if (Raiz != null)
            {
                x = Raiz.Nsiguiente(Raiz,x);
            }
            return x;
        }


        public Nodo_Arbol Enorden(int x)
        {
            Nodo_Arbol t = Raiz;
            if (Raiz != null)
            {
                if(x == Raiz.info)
                {
                    x = t.Derecho.info;
                    t = Raiz.buscar(x,t);
                    //t = Raiz.Menor1(Raiz,x);
                }
                else
                {
                    t = Raiz.Menor1(t, x);
                }
                
            }
            return t;
        }




        // ******** Funciones para el dibujo del Árbol Binario en el Formulario **************
        // Función que dibuja el Árbol Binario
        public void DibujarArbol(Graphics grafo, Font fuente, Brush Relleno, Brush
        RellenoFuente, Pen Lapiz, Brush encuentro)
        {
            int x = 400; // Posiciones de la raíz del árbol
            int y = 75;
            if (Raiz == null) return;
            Raiz.PosicionNodo(ref x, y); //Posicion de todos los Nodos
            Raiz.DibujarRamas(grafo, Lapiz); //Dibuja los Enlaces entre nodos
                                             //Dibuja todos los Nodos

            Raiz.DibujarNodo(grafo, fuente, Relleno, RellenoFuente, Lapiz, encuentro);
        }


        // Función que dibuja el Árbol Binario
        public void DibujarArbolBusqueda(Graphics grafo, Font fuente, Brush Relleno, Brush
        RellenoFuente, Pen Lapiz, Brush encuentro,Nodo_Arbol t)
        {
            int x = 400; // Posiciones de la raíz del árbol
            int y = 75;
            if (Raiz == null) return;
            Raiz.PosicionNodo(ref x, y); //Posicion de todos los Nodos
            Raiz.DibujarRamas(grafo, Lapiz); //Dibuja los Enlaces entre nodos
                                             //Dibuja todos los Nodos

            Raiz.DibujarNodoBuscar(grafo, fuente, Relleno, RellenoFuente, Lapiz, encuentro,t);
        }


        public int x1 = 400; // Posiciones iniciales de la raíz del árbol
        public int y2 = 75;


        // Función para Colorear los nodos
        public void colorear(Graphics grafo, Font fuente, Brush Relleno, Brush RellenoFuente,
        Pen Lapiz, Nodo_Arbol Raiz, bool post, bool inor, bool preor)
        {
            Brush entorno = Brushes.Red;
            if (inor == true)
            {
                if (Raiz != null)
                {
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Izquierdo, post, inor,
                    preor);
                    Raiz.colorear(grafo, fuente, entorno, RellenoFuente, Lapiz);
                    Thread.Sleep(1000); // pausar la ejecución 1000 milisegundos
                    Raiz.colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz);
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Derecho, post, inor,
                    preor);
                }
            }
            else if (preor == true)
            {
                if (Raiz != null)
                {
                    Raiz.colorear(grafo, fuente, entorno, RellenoFuente, Lapiz);
                    Thread.Sleep(1000); // pausar la ejecución 1000 milisegundos
                    Raiz.colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz);
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Izquierdo, post,
                    inor, preor);
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Derecho, post,
                    inor, preor);
                }
            }
            else if (post == true)
            {
                if (Raiz != null)
                {
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Izquierdo, post,
                    inor, preor);
                    colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Derecho, post,
                    inor, preor);
                    Raiz.colorear(grafo, fuente, entorno, RellenoFuente, Lapiz);
                    Thread.Sleep(1000); // pausar la ejecución 1000 milisegundos
                    Raiz.colorear(grafo, fuente, Relleno, RellenoFuente, Lapiz);
                }
            }
        }



    }

}
