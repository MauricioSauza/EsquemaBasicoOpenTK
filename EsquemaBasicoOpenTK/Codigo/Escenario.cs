using System;
using System.Collections.Generic;
using System.Text;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace EsquemaBasicoOpenTK
{
    class Escenario
    {
        public Dictionary<int, Objeto> ListaDeObjetos;
        public Vector centro;

        public Escenario(Dictionary<int, Objeto> listaDeObjetos, Vector centro)
        {
            this.ListaDeObjetos = listaDeObjetos;
            this.centro = centro;
            foreach (var obj in this.ListaDeObjetos)
            {
                Vector vertex = new Vector(obj.Value.Centro.X + this.centro.X, obj.Value.Centro.Y + this.centro.Y, obj.Value.Centro.Z + this.centro.Z);
                Vector center = obj.Value.Centro + centro;
                obj.Value.Centro = center;
                foreach (var cara in obj.Value.ListaDeCaras)
                {
                    Vector faceVertex = new Vector(cara.Value.Centro.X + center.X, cara.Value.Centro.Y + center.Y, cara.Value.Centro.Z + center.Z);
                    cara.Value.Centro = center;
                }
            }
        }

        public Escenario(Vector centro)
        {
            this.centro = centro;
            ListaDeObjetos = new Dictionary<int, Objeto>();
        }

        public void setCentro(Vector centro)
        {
            this.centro = centro;
            foreach (var obj in this.ListaDeObjetos)
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
