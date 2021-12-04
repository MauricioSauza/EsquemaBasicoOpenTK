using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace EsquemaBasicoOpenTK
{
    class Game : GameWindow
    {
        Dictionary<int, Objeto> listaObj = new Dictionary<int, Objeto>();
        Dictionary<int, Objeto> listaObj1 = new Dictionary<int, Objeto>();
        public Escenario escenario;
        public Escenario escenario1;
        public Objeto objeto;
        public Objeto objeto1;
        public Cara cara;
        public Cara cara1;
        public Game(int width, int height, string title) : base(width, height, GraphicsMode.Default, title) { }
        //public Vector Vector;
        protected override void OnLoad(EventArgs e)
        {
            //OnResize(null);
            GL.ClearColor(Color4.DarkOliveGreen);
            GL.MatrixMode(MatrixMode.Projection);
            //GL.LoadIdentity();

            GL.Ortho(-300, 300, -300, 300, -300, 300);

            ////Piramide2
            //Dictionary<int, Vector> vertices = new Dictionary<int, Vector>();
            //vertices.Add(01, new Vector(-50f, 0f, 0f));
            //vertices.Add(02, new Vector(0f, 100f, 0f));
            //vertices.Add(03, new Vector(0f, 0f, -50f));

            //Dictionary<int, Vector> vertices2 = new Dictionary<int, Vector>();
            //vertices2.Add(04, new Vector(50f, 0f, 0f));
            //vertices2.Add(05, new Vector(0f, 100f, 0f));
            //vertices2.Add(06, new Vector(0f, 0f, 50f));

            //Dictionary<int, Vector> vertices3 = new Dictionary<int, Vector>();
            //vertices3.Add(07, new Vector(-50f, 0f, 0f));
            //vertices3.Add(08, new Vector(0f, 100f, 0f));
            //vertices3.Add(09, new Vector(0f, 0f, 50f));

            //Dictionary<int, Vector> vertices4 = new Dictionary<int, Vector>();
            //vertices4.Add(10, new Vector(0f, 0f, -50f));
            //vertices4.Add(11, new Vector(50f, 0f, 0f));
            //vertices4.Add(12, new Vector(0f, 100f, 0f));







            ////CUBO
            //Dictionary<int, Vector> vertices5 = new Dictionary<int, Vector>();
            //vertices5.Add(01, new Vector(-50f, 50f, -50f));
            //vertices5.Add(02, new Vector(50f, 50f, -50f));
            //vertices5.Add(03, new Vector(50f, -50f, -50f));
            //vertices5.Add(04, new Vector(-50f, -50f, -50f));

            //Dictionary<int, Vector> vertices6 = new Dictionary<int, Vector>();
            //vertices6.Add(05, new Vector(-50f, 50f, 50f));
            //vertices6.Add(06, new Vector(-50f, 50f, -50f));
            //vertices6.Add(07, new Vector(-50f, -50f, -50f));
            //vertices6.Add(08, new Vector(-50f, -50f, 50f));

            //Dictionary<int, Vector> vertices7 = new Dictionary<int, Vector>();
            //vertices7.Add(09, new Vector(50f, 50f, 50f));
            //vertices7.Add(10, new Vector(50f, 50f, -50f));
            //vertices7.Add(11, new Vector(50f, -50f, -50f));
            //vertices7.Add(12, new Vector(50f, -50f, 50f));

            //Dictionary<int, Vector> vertices8 = new Dictionary<int, Vector>();
            //vertices8.Add(13, new Vector(-50f, 50f, 50f));
            //vertices8.Add(14, new Vector(50f, 50f, 50f));
            //vertices8.Add(15, new Vector(50f, -50f, 50f));
            //vertices8.Add(16, new Vector(-50f, -50f, 50f));

            //Dictionary<int, Vector> vertices9 = new Dictionary<int, Vector>();
            //vertices9.Add(17, new Vector(-50f, 50f, 50f));
            //vertices9.Add(18, new Vector(50f, 50f, 50f));
            //vertices9.Add(19, new Vector(50f, 50f, -50f));
            //vertices9.Add(20, new Vector(-50f, 50f, -50f));

            //Dictionary<int, Vector> vertices10 = new Dictionary<int, Vector>();
            //vertices10.Add(21, new Vector(-50f, -50f, 50f));
            //vertices10.Add(22, new Vector(50f, -50f, 50f));
            //vertices10.Add(23, new Vector(50f, -50f, -50f));
            //vertices10.Add(24, new Vector(-50f, -50f, -50f));

            //Dictionary<int, Cara> Piramide2 = new Dictionary<int, Cara>();
            //Piramide2.Add(0, new Cara(vertices, Color.Black, new Vector(0f, 0f, 0f)));
            //Piramide2.Add(1, new Cara(vertices2, Color.FloralWhite, new Vector(0f, 0f, 0f)));
            //Piramide2.Add(2, new Cara(vertices3, Color.LightSeaGreen, new Vector(0f, 0f, 0f)));
            //Piramide2.Add(3, new Cara(vertices4, Color.Blue, new Vector(0f, 0f, 0f)));
            //Objeto test3 = new Objeto(Piramide2, new Vector(-100, -120, 0));

            //Dictionary<int, Cara> Piramide = new Dictionary<int, Cara>();
            //Piramide.Add(0, new Cara(vertices5, Color.DarkGreen, new Vector(0f, 0f, 0f)));
            //Piramide.Add(1, new Cara(vertices6, Color.White, new Vector(0f, 0f, 0f)));
            //Piramide.Add(2, new Cara(vertices7, Color.DarkBlue, new Vector(0f, 0f, 0f)));
            //Piramide.Add(3, new Cara(vertices8, Color.OrangeRed, new Vector(0f, 0f, 0f)));
            //Piramide.Add(4, new Cara(vertices9, Color.BlueViolet, new Vector(0f, 0f, 0f)));
            //Piramide.Add(5, new Cara(vertices10, Color.Black, new Vector(0f, 0f, 0f)));
            //Objeto test1 = new Objeto(Piramide, new Vector(0, 0, 0));

            //Dictionary<int, Cara> cubo = new Dictionary<int, Cara>();
            //cubo.Add(0, new Cara(vertices, Color.DarkGreen, new Vector(0f, 0f, 0f)));
            //cubo.Add(1, new Cara(vertices2, Color.DarkBlue, new Vector(0f, 0f, 0f)));
            //cubo.Add(2, new Cara(vertices3, Color.OrangeRed, new Vector(0f, 0f, 0f)));
            //cubo.Add(3, new Cara(vertices4, Color.BlueViolet, new Vector(0f, 0f, 0f)));
            //Objeto test2 = new Objeto(cubo, new Vector(100, 80, 0));


            //JLoader.save("../../Objetos/objeto.json", test1);
            //JLoader.save("../../Objetos/objeto1.json", test2);
            //JLoader.save("../../Objetos/objeto2.json", test3);


            //Objeto test11 = JLoader.load("../../Objetos/objeto.json");
            //Objeto test22 = JLoader.load("../../Objetos/objeto1.json");

            //listaObj.Add(1, test11);
            //listaObj.Add(2, test22);
            //escenario = new Escenario(listaObj, new Vector(100, 80, 100));


            //Objeto test33 = JLoader.load("../../Objetos/objeto2.json");
            //listaObj1.Add(1, test33);
            ////-220, -120, -120
            //escenario1 = new Escenario(listaObj1, new Vector(-220, -120, -120));
            ////escenario1.escalar(3, 2, 1);


            base.OnLoad(e);
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.Enable(EnableCap.DepthTest);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.MatrixMode(MatrixMode.Modelview);
            escenario.Dibujar();
            escenario1.Dibujar();
            SwapBuffers();
            base.OnRenderFrame(e);
        }

        protected override void OnResize(EventArgs e)
        {
            GL.Viewport(0, 0, Width, Height);
            base.OnResize(e);
        }
    }
}
