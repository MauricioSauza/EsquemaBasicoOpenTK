using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HelloEscenario;


namespace EsquemaBasicoOpenTK
{
   
    public partial class Form1 : Form
    {
        Game game = new Game(800, 600, "LearnOpenTK");
        float x;
        float y;
        float z;
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            
            game.Run(60.0);
        }

        private void escenarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            switch (comboBox2.Text)
            {
                case "Escenario1":
                    switch (comboBox1.Text)
                    {
                        case "Escenario":
                            game.escenario.rotar(x, y, z);
                            break;
                        case "Objeto":
                            int objeto = int.Parse(textBox4.Text);
                            if (game.escenario.ListaDeObjetos.ContainsKey(objeto))
                            {
                                game.escenario.getObjeto(objeto).rotar(x, y, z);
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

                            if (game.escenario.ListaDeObjetos.ContainsKey(objeto))
                            {
                                temp = game.escenario.getObjeto(objeto);
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
                            game.escenario1.rotar(x, y, z);
                            break;
                        case "Objeto":
                            int objeto = int.Parse(textBox4.Text);
                            if (game.escenario1.ListaDeObjetos.ContainsKey(objeto))
                            {
                                game.escenario1.getObjeto(objeto).rotar(x, y, z);
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
                            if (game.escenario1.ListaDeObjetos.ContainsKey(objeto))
                            {
                                temp = game.escenario1.getObjeto(objeto);
                                if (temp.ListaDeCaras.ContainsKey(cara))
                                {
                                    temp.getCara(cara).rotar(x, y, z);
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
                            game.escenario.rotar(x, y, z);
                            game.escenario1.rotar(x, y, z);
                            break;
                    }
                    break;
            }

            




            x = float.Parse(textBox1.Text);
            y = float.Parse(textBox2.Text);
            z = float.Parse(textBox3.Text);
           


        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            game.escenario.escalar(x, y, z);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            switch (comboBox2.Text)
            {
                case "Escenario1":
                    switch (comboBox1.Text)
                    {
                        case "Escenario":
                            game.escenario.traslacion(x, y, z);
                            break;
                        case "Objeto":
                            int objeto = int.Parse(textBox4.Text);
                            if (game.escenario.ListaDeObjetos.ContainsKey(objeto))
                            {
                                game.escenario.getObjeto(objeto).traslacion(x, y, z);
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

                            if (game.escenario.ListaDeObjetos.ContainsKey(objeto))
                            {
                                temp = game.escenario.getObjeto(objeto);
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
                            game.escenario1.traslacion(x, y, z);
                            break;
                        case "Objeto":
                            int objeto = int.Parse(textBox4.Text);
                            if (game.escenario1.ListaDeObjetos.ContainsKey(objeto))
                            {
                                game.escenario1.getObjeto(objeto).traslacion(x, y, z);
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
                            if (game.escenario1.ListaDeObjetos.ContainsKey(objeto))
                            {
                                temp = game.escenario1.getObjeto(objeto);
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
                            game.escenario.traslacion(x, y, z);
                            game.escenario1.traslacion(x, y, z);
                            break;
                    }
                    break;
            }

            x = float.Parse(textBox1.Text);
            y = float.Parse(textBox2.Text);
            z = float.Parse(textBox3.Text);
        }
    }
}
