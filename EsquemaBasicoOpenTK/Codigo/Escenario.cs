using System;
using System.Collections.Generic;
using System.Text;
using Escenario;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace HelloEscenario
{
    class Escenario
    {
        public Dictionary<int, Objeto> ListaDeObjetos;
        public Vector centro;

        public Escenario(Dictionary<int, Objeto> listaDeObjetos, Vector centro)
        {
            this.ListaDeObjetos = listaDeObjetos;
            this.centro = centro;
            foreach(var obj in this.ListaDeObjetos)
            {
                Vector vertex = new Vector(obj.Value.Centro.X + this.centro.X, obj.Value.Centro.Y + this.centro.Y, obj.Value.Centro.Z + this.centro.Z);
                obj.Value.Centro = vertex;
                foreach(var cara in obj.Value.ListaDeCaras)
                {
                    Vector faceVertex = new Vector(cara.Value.Centro.X + vertex.X, cara.Value.Centro.Y + vertex.Y, cara.Value.Centro.Z + vertex.Z);
                    cara.Value.Centro = vertex;
                }
            }
        }

        public void setCentro(Vector centro)
        {
            this.centro = centro;
            foreach(var obj in this.ListaDeObjetos)
            {
                Vector exCentro = obj.Value.getCentro();
                obj.Value.setCentro(centro + exCentro);
            }
        }

        public void insertar(int clave, Objeto obj)
        {
            ListaDeObjetos.Add(clave, obj);
        }

        public void eliminar(int clave)
        {
            ListaDeObjetos.Remove(clave);
        }

        public Vector getCentro()
        {
            return centro;
        }


        public Objeto getObjeto(int clave)
        {
            return ListaDeObjetos[clave];
        }

        public void rotar(float x, float y, float z)
        {
            foreach(var obj in this.ListaDeObjetos)
            {
                obj.Value.rotar(x, y, z);
            }
        }

        public void traslacion(float x, float y, float z)
        {
            foreach (var obj in this.ListaDeObjetos)
            {
                Objeto obj1 = obj.Value;
                obj1.traslacion(x, y, z);
                //obj.Value.traslacion(x, y, z);
            }
        }

        public void escalar(float x, float y, float z)
        {
            foreach(var obj in ListaDeObjetos)
            {
                Objeto obj1 = obj.Value;
                obj1.escalar(x, y, z);
            }
        }

        public void Dibujar()
        {
            foreach (var objeto in this.ListaDeObjetos)
            {
                objeto.Value.Dibujar();
            }
        }

    }
}
