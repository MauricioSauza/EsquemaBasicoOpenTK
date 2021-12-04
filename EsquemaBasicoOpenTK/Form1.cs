using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using HelloEscenario;


namespace EsquemaBasicoOpenTK
{
   
    public partial class Form1 : Form
    {
        private Escenario escenario;
        private Escenario escenario1;
        Game game;
        float x;
        float y;
        float z;
        public Form1()
        {
            InitializeComponent();
        }    

        private void Form1_Shown(object sender, EventArgs e)
        {
            Objeto test11 = JLoader.load("../../Objetos/objeto.json");
            Objeto test22 = JLoader.load("../../Objetos/objeto1.json");
            escenario = new Escenario(new Vector(100, 80, 100));
            escenario.ListaDeObjetos.Add(1, test11);
            escenario.ListaDeObjetos.Add(2, test22);
            Objeto test33 = JLoader.load("../../Objetos/objeto2.json");
            escenario1 = new Escenario(new Vector(-220, -120, -120));
            escenario1.ListaDeObjetos.Add(1, test33);
            Thread hilo = new Thread(init);
            hilo.Start();
            //game.Run(60.0);
        }

        private void init()
        {
            game = new Game(800, 600, "LearnOpenTK");
            game.escenario = this.escenario;
            game.escenario1 = this.escenario1;
            game.Run();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            switch (comboBox2.Text)
            {
                case "Escenario1":
                    switch (comboBox1.Text)
                    {
                        case "Escenario":
                            escenario.rotar(x, y, z);
                            break;
                        case "Objeto":
                            int objeto = int.Parse(textBox4.Text);
                            if (escenario.ListaDeObjetos.ContainsKey(objeto))
                            {
                                escenario.getObjeto(objeto).rotar(x, y, z);
                            }
                            else
                            {
                                MessageBox.Show("El objeto no existe");
                            }             
                            break;
                        case "Cara":
                            int cara = int.Parse(textBox5.Text);
                            objeto = int.Parse(textBox4.Text);
                            Objeto temp;

                            if (escenario.ListaDeObjetos.ContainsKey(objeto))
                            {
                                temp = escenario.getObjeto(objeto);
                                if (temp.ListaDeCaras.ContainsKey(cara))
                                {
                                    temp.getCara(cara).rotar(x, y, z);
                                }
                                else
                                {
                                    MessageBox.Show("La cara no existe");
                                }


                            }
                            else
                            {
                                MessageBox.Show("La cara no existe");
                            }

                            break;
                    }
                    break;
                case "Escenario2":
                    switch (comboBox1.Text)
                    {
                        case "Escenario":
                            escenario1.rotar(x, y, z);
                            break;
                        case "Objeto":
                            int objeto = int.Parse(textBox4.Text);
                            if (escenario1.ListaDeObjetos.ContainsKey(objeto))
                            {
                                escenario1.getObjeto(objeto).rotar(x, y, z);
                            }
                            else
                            {
                                MessageBox.Show("El objeto no existe");
                            }
                            break;
                        case "Cara":
                            int cara = int.Parse(textBox5.Text);
                            objeto = int.Parse(textBox4.Text);
                            Objeto temp;
                            if (escenario1.ListaDeObjetos.ContainsKey(objeto))
                            {
                                temp = escenario1.getObjeto(objeto);
                                if (temp.ListaDeCaras.ContainsKey(cara))
                                {
                                    temp.getCara(cara).rotarCara(x, y, z);
                                }
                                else
                                {
                                    MessageBox.Show("La cara no existe");
                                }
                                break;
                            }
                            else
                            {
                                MessageBox.Show("La cara no existe");
                            }
                            break;

                    }
                    break;
                case "Ambos":
                    switch (comboBox1.Text)
                    {
                        case "Escenario":
                            escenario.rotar(x, y, z);
                            escenario1.rotar(x, y, z);
                            break;
                    }
                    break;
            }
            x = float.Parse(textBox1.Text);
            y = float.Parse(textBox2.Text);
            z = float.Parse(textBox3.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            switch (comboBox2.Text)
            {
                case "Escenario1":
                    switch (comboBox1.Text)
                    {
                        case "Escenario":
                            escenario.traslacion(x, y, z);
                            break;
                        case "Objeto":
                            int objeto = int.Parse(textBox4.Text);
                            if (escenario.ListaDeObjetos.ContainsKey(objeto))
                            {
                                escenario.getObjeto(objeto).traslacion(x, y, z);
                            }
                            else
                            {
                                MessageBox.Show("El objeto no existe");
                            }
                            break;
                        case "Cara":
                            int cara = int.Parse(textBox5.Text);
                            objeto = int.Parse(textBox4.Text);
                            Objeto temp;

                            if (escenario.ListaDeObjetos.ContainsKey(objeto))
                            {
                                temp = escenario.getObjeto(objeto);
                                if (temp.ListaDeCaras.ContainsKey(cara))
                                {
                                    temp.getCara(cara).traslacion(x, y, z);
                                }
                                else
                                {
                                    MessageBox.Show("La cara no existe");
                                }


                            }
                            else
                            {
                                MessageBox.Show("La cara no existe");
                            }

                            break;
                    }
                    break;
                case "Escenario2":
                    switch (comboBox1.Text)
                    {
                        case "Escenario":
                            escenario1.traslacion(x, y, z);
                            break;
                        case "Objeto":
                            int objeto = int.Parse(textBox4.Text);
                            if (escenario1.ListaDeObjetos.ContainsKey(objeto))
                            {
                                escenario1.getObjeto(objeto).traslacion(x, y, z);
                            }
                            else
                            {
                                MessageBox.Show("El objeto no existe");
                            }
                            break;
                        case "Cara":
                            int cara = int.Parse(textBox5.Text);
                            objeto = int.Parse(textBox4.Text);
                            Objeto temp;
                            if (escenario1.ListaDeObjetos.ContainsKey(objeto))
                            {
                                temp = escenario1.getObjeto(objeto);
                                if (temp.ListaDeCaras.ContainsKey(cara))
                                {
                                    temp.getCara(cara).traslacion(x, y, z);
                                }
                                else
                                {
                                    MessageBox.Show("La cara no existe");
                                }
                                break;
                            }
                            else
                            {
                                MessageBox.Show("La cara no existe");
                            }
                            break;

                    }
                    break;
                case "Ambos":
                    switch (comboBox1.Text)
                    {
                        case "Escenario":
                            escenario.traslacion(x, y, z);
                            escenario1.traslacion(x, y, z);
                            break;
                    }
                    break;
            }

            x = float.Parse(textBox1.Text);
            y = float.Parse(textBox2.Text);
            z = float.Parse(textBox3.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (comboBox2.Text)
            {
                case "Escenario1":
                    switch (comboBox1.Text)
                    {
                        case "Escenario":
                            escenario.escalar(x, y, z);
                            break;
                        case "Objeto":
                            int objeto = int.Parse(textBox4.Text);
                            if (escenario.ListaDeObjetos.ContainsKey(objeto))
                            {
                                escenario.getObjeto(objeto).escalar(x, y, z);
                            }
                            else
                            {
                                MessageBox.Show("El objeto no existe");
                            }
                            break;
                        case "Cara":
                            int cara = int.Parse(textBox5.Text);
                            objeto = int.Parse(textBox4.Text);
                            Objeto temp;

                            if (escenario.ListaDeObjetos.ContainsKey(objeto))
                            {
                                temp = escenario.getObjeto(objeto);
                                if (temp.ListaDeCaras.ContainsKey(cara))
                                {
                                    temp.getCara(cara).escalar(x, y, z);
                                }
                                else
                                {
                                    MessageBox.Show("La cara no existe");
                                }


                            }
                            else
                            {
                                MessageBox.Show("La cara no existe");
                            }

                            break;
                    }
                    break;
                case "Escenario2":
                    switch (comboBox1.Text)
                    {
                        case "Escenario":
                            escenario1.escalar(x, y, z);
                            break;
                        case "Objeto":
                            int objeto = int.Parse(textBox4.Text);
                            if (escenario1.ListaDeObjetos.ContainsKey(objeto))
                            {
                                escenario1.getObjeto(objeto).escalar(x, y, z);
                            }
                            else
                            {
                                MessageBox.Show("El objeto no existe");
                            }
                            break;
                        case "Cara":
                            int cara = int.Parse(textBox5.Text);
                            objeto = int.Parse(textBox4.Text);
                            Objeto temp;
                            if (escenario1.ListaDeObjetos.ContainsKey(objeto))
                            {
                                temp = escenario1.getObjeto(objeto);
                                if (temp.ListaDeCaras.ContainsKey(cara))
                                {
                                    temp.getCara(cara).escalar(x, y, z);
                                }
                                else
                                {
                                    MessageBox.Show("La cara no existe");
                                }
                                break;
                            }
                            else
                            {
                                MessageBox.Show("La cara no existe");
                            }
                            break;

                    }
                    break;
                case "Ambos":
                    switch (comboBox1.Text)
                    {
                        case "Escenario":
                            escenario.escalar(x, y, z);
                            escenario1.escalar(x, y, z);
                            break;
                    }
                    break;
            }

            x = float.Parse(textBox1.Text);
            y = float.Parse(textBox2.Text);
            z = float.Parse(textBox3.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void escenarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
