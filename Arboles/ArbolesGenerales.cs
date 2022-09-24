using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles
{
    public class ArbolesGenerales
    {
        private readonly Nodo raiz;

        public ArbolesGenerales(string valor)
        {
            raiz = new Nodo(valor);
        }

        public Nodo Raiz
        { 
            get 
            {
                return raiz;
            } 
        }
        public Nodo Insertar(string valor, Nodo padre)
        {
            if (string.IsNullOrWhiteSpace(valor))
            {
                throw new Exception("No se puede Insertar un valor vacio");

            }
            if (padre == null)
            {
                throw new Exception("No se puede insertar un nodo sin especificar a padre");

            }
            if (padre.Hijo == null)
            {
                padre.Hijo = new Nodo(valor);
                return padre.Hijo;
            }
            else
            {
                Nodo hijoActual = padre.Hijo;
                while(hijoActual.Hermano != null)
                {
                    hijoActual = hijoActual.Hermano;
                }
                hijoActual.Hermano = new Nodo(valor);
                return hijoActual.Hermano;
            }

        }
        private void Recorrer(Nodo nodo, ref int posicion, ref string datos)
        {
            if (nodo != null)
            {
                string dato = nodo.Valor;
                int cantidadGuiones = dato.Length + posicion;
                string datoConGuiones = dato.PadLeft(cantidadGuiones, '-');
                datos += $"{datoConGuiones}\n";
                if (nodo.Hijo != null)
                {
                    posicion++;
                    Recorrer(nodo.Hijo, ref posicion, ref datos);
                    posicion--;
                }
                if (nodo.Hermano != null && posicion != 0)
                {
                    Recorrer(nodo.Hermano, ref posicion, ref datos);
                }
            }        }
    }
}
