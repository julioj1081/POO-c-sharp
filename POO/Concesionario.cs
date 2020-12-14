using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Concesionario
    {
        //array
        private Coche[] _coches;
        private int _limite;
        private int _numCoches;

        public Concesionario(int limite)
        {
            this._coches = new Coche[limite]; //limite del array cada ve< que aya uno nuevo
            _limite = limite;
            _numCoches = 0; //contador
        }

        public void añadirCoche(Coche c)
        {
            //si esta vacio el arreglo y si hay espacio agrega
            if(c != null && _numCoches < _coches.Length)
            {
                _coches[_numCoches] = c;
                _numCoches++; 
            }
        }
        public void mostrarCoches()
        {
            //recorre todos los coches
            for(int i=0; i<_numCoches; i++)
            {
                Console.WriteLine(_coches[i].ToString());
            }
        }
        //vaciamos todo desde 0
        public void vaciarCoches()
        {
            this._coches = new Coche[_limite];
            _numCoches = 0;
        }
        public void eliminarCoches(Coche c)
        {
            if (c != null && _numCoches != 0)
            {
                
                int posicion = -1;
                for (int i = 0; i < _numCoches; i++)
                {
                    if(c.id == _coches[i].id)
                    {
                        posicion = i;
                    }
                }

                //si no existe
                if(posicion == -1)
                {
                    Console.WriteLine("No existe el coche");
                }
                else
                {
                    //movemos a la derecha
                    //y moveremos todos los elementos
                    _coches[posicion] = null;

                    for(int i = posicion; i<_numCoches; i++)
                    {
                        _coches[i] = _coches[i + 1];
                    }
                    _numCoches--;
                }
            }
        }
    }
}
