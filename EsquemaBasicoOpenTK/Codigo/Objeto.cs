using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Escenario;
using HelloCara;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace HelloEscenario
{
    class Objeto
    {
        public Dictionary<int, Cara> ListaDeCaras;
        public Vector Centro;

        public Objeto(Dictionary<int, Cara> listaDeCaras, Vector centro)
        {
            this.ListaDeCaras = listaDeCaras;
            this.Centro = centro;
            //setCentro(centro);
            
        }

        public void setCentro(Vector centro)
        {
            this.Centro = centro;
            foreach (var obj in ListaDeCaras)
            {
                obj.Value.Centro = Centro;
            }
        }

        public Vector getCentro()
        {
            return Centro;
        }

        public Cara getCara(int clave)
        {
            return ListaDeCaras[clave];
        }

        public void insertar(int clave, Cara cara)
        {
            ListaDeCaras.Add(clave, cara);
        }

        public void eliminar(int clave)
        {
            ListaDeCaras.Remove(clave);
        }   

        public void rotar(float x, float y, float z)
        {
            foreach(var cara in this.ListaDeCaras)
            {
                cara.Value.rotar(x, y, z);
            }
        }

        public void traslacion(float x, float y, float z)
        {
            foreach(var cara in this.ListaDeCaras)
            {
                Cara cara1 = cara.Value;
                cara1.traslacion(x, y, z);
                //cara.Value.traslacion(x, y, z);
            }
        }

        public void escalar(float x, float y, float z)
        {
            foreach (var cara in this.ListaDeCaras) {
                Cara cara1 = cara.Value;
                cara1.escalar(x, y, z);
            }
        }

        public void Dibujar()
        {
            foreach (var cara in this.ListaDeCaras)
            {
                cara.Value.Dibujar();
            }
        }
    }
}
