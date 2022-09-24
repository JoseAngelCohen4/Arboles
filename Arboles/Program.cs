using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ArbolesGenerales arbol=new ArbolesGenerales("A");
                Nodo nodoB = arbol.Insertar("B", arbol.Raiz);
                Nodo nodoC = arbol.Insertar("C", arbol.Raiz);
                Nodo nodoD = arbol.Insertar("D", nodoB);
                Nodo nodoE = arbol.Insertar("E", nodoB);
                Nodo nodoF = arbol.Insertar("F", nodoB);
                Nodo nodoI = arbol.Insertar("I", nodoD);
                Nodo nodoJ = arbol.Insertar("J", nodoF);
                Nodo nodoK = arbol.Insertar("K", nodoF);
                Nodo nodoG = arbol.Insertar("G", nodoC);
                Nodo nodoH = arbol.Insertar("H", nodoC);
                Nodo nodoL = arbol.Insertar("L", nodoH);
                string miArbol = arbol.ObtenerArbol();
                Console.WriteLine(miArbol);
                Console.ReadKey();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
