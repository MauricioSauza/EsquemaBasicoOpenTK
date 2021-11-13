using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Escenario;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace HelloCara
{
    class Cara
    {
        public Dictionary<int, Vector> ListaDeVertices { get; set; }
        public Color Color;
        public Vector Centro;
        public Vector movement = new Vector(0, 0, 0);

        Matrix3 matriz1 = Matrix3.Identity;
        Matrix3 matriz2 = Matrix3.Identity;
        


        public Cara(Dictionary<int, Vector> listaDeVertices, Color color, Vector centro)
        {
            this.ListaDeVertices = listaDeVertices;
            this.Color = color;
            this.Centro = centro;            
        }

        public void setCentro(Vector centro)
        {
            this.Centro = centro;
        }

        public Vector getCentro()
        {
            return Centro;
        }

        public Vector getVertice(int clave)
        {
            return ListaDeVertices[clave];
        }

        public  void insertar(int clave, Vector vertex)
        {
            ListaDeVertices.Add(clave, vertex);
        }

        public void eliminar(int clave)
        {
            ListaDeVertices.Remove(clave);
        }

        public void Dibujar()
        {
            GL.Color4(Color);
            GL.Begin(PrimitiveType.Polygon);

            foreach (var vertice in this.ListaDeVertices)
            {
                Vector vertex = vertice.Value * matriz1 * matriz2;
                vertex += Centro + movement;
                GL.Vertex3(vertice.Value.X + Centro.X, vertice.Value.Y + Centro.Y, vertice.Value.Z + Centro.Z);
            }
            GL.End();
        }

        public void rotar(float angX, float angY, float angZ)
        {
            angX = MathHelper.DegreesToRadians(angX);
            angY = MathHelper.DegreesToRadians(angY);
            angZ = MathHelper.DegreesToRadians(angZ);
            foreach(var vertice in this.ListaDeVertices)
            {
                vertice.Value.setVector(rotationX(vertice.Value, angX));
                vertice.Value.setVector(rotationY(vertice.Value, angY));
                vertice.Value.setVector(rotationZ(vertice.Value, angZ));
            }
        }

        public Vector rotationX(Vector vertice, float angulo)
        {
            Matrix3 matriz = Matrix3.CreateRotationX(angulo);
            return vertice * matriz;
        }

        public Vector rotationY(Vector vertice, float angulo)
        {
            Matrix3 matriz = Matrix3.CreateRotationY(angulo);
            return vertice * matriz;
        }

        public Vector rotationZ(Vector vertice, float angulo)
        {
            Matrix3 matriz = Matrix3.CreateRotationZ(angulo);
            return vertice * matriz;
        }

        public void traslacion(float x, float y, float z)
        {
            movement += new Vector(x, y, z);
            //GL.Translate(x, y, z);
        }

        public void escalar(float x, float y, float z)
        {
            Matrix3 matriz = Matrix3.CreateScale(x, y, z);
            foreach(var vertice in ListaDeVertices)
            {
                vertice.Value.setVector(vertice.Value * matriz);
                //GL.Scale(x, y, z);
            }
        }



    }
}
