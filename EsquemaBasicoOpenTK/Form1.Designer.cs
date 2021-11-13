
namespace EsquemaBasicoOpenTK
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.escenario1StripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EscenarioStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.objetosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.objeto1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.objeto2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.objeto1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.objeto2ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.escenario2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escenarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.objetosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.objeto1ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.carasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.objeto1ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elija una figura";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Rotacion";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(161, 352);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Escalar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(298, 352);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Traslacion";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Escenario",
            "Objeto",
            "Cara"});
            this.comboBox1.Location = new System.Drawing.Point(161, 80);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Text = "Elegir";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 274);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "0";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(165, 274);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "0";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(297, 274);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 8;
            this.textBox3.Text = "0";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Escenario1",
            "Escenario2",
            "Ambos"});
            this.comboBox2.Location = new System.Drawing.Point(12, 80);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 11;
            this.comboBox2.Text = "Elegir";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.escenario1StripMenuItem,
            this.escenario2ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(440, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // escenario1StripMenuItem
            // 
            this.escenario1StripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EscenarioStripMenuItem,
            this.objetosToolStripMenuItem,
            this.carasToolStripMenuItem});
            this.escenario1StripMenuItem.Name = "escenario1StripMenuItem";
            this.escenario1StripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.escenario1StripMenuItem.Text = "Escenario1";
            // 
            // EscenarioStripMenuItem
            // 
            this.EscenarioStripMenuItem.Name = "EscenarioStripMenuItem";
            this.EscenarioStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.EscenarioStripMenuItem.Text = "Escenario";
            // 
            // objetosToolStripMenuItem
            // 
            this.objetosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.objeto1ToolStripMenuItem,
            this.objeto2ToolStripMenuItem});
            this.objetosToolStripMenuItem.Name = "objetosToolStripMenuItem";
            this.objetosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.objetosToolStripMenuItem.Text = "Objetos";
            // 
            // objeto1ToolStripMenuItem
            // 
            this.objeto1ToolStripMenuItem.Name = "objeto1ToolStripMenuItem";
            this.objeto1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.objeto1ToolStripMenuItem.Text = "Objeto1";
            // 
            // objeto2ToolStripMenuItem
            // 
            this.objeto2ToolStripMenuItem.Name = "objeto2ToolStripMenuItem";
            this.objeto2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.objeto2ToolStripMenuItem.Text = "Objeto2";
            // 
            // carasToolStripMenuItem
            // 
            this.carasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.objeto1ToolStripMenuItem1,
            this.objeto2ToolStripMenuItem1});
            this.carasToolStripMenuItem.Name = "carasToolStripMenuItem";
            this.carasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.carasToolStripMenuItem.Text = "Caras";
            // 
            // objeto1ToolStripMenuItem1
            // 
            this.objeto1ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7});
            this.objeto1ToolStripMenuItem1.Name = "objeto1ToolStripMenuItem1";
            this.objeto1ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.objeto1ToolStripMenuItem1.Text = "Objeto1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "0";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem3.Text = "1";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem4.Text = "2";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem5.Text = "3";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem6.Text = "4";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem7.Text = "5";
            // 
            // objeto2ToolStripMenuItem1
            // 
            this.objeto2ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem8,
            this.toolStripMenuItem9,
            this.toolStripMenuItem10,
            this.toolStripMenuItem11});
            this.objeto2ToolStripMenuItem1.Name = "objeto2ToolStripMenuItem1";
            this.objeto2ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.objeto2ToolStripMenuItem1.Text = "Objeto2";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem8.Text = "0";
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem9.Text = "1";
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem10.Text = "2";
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem11.Text = "3";
            // 
            // escenario2ToolStripMenuItem
            // 
            this.escenario2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.escenarioToolStripMenuItem,
            this.objetosToolStripMenuItem1,
            this.carasToolStripMenuItem1});
            this.escenario2ToolStripMenuItem.Name = "escenario2ToolStripMenuItem";
            this.escenario2ToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.escenario2ToolStripMenuItem.Text = "Escenario2";
            // 
            // escenarioToolStripMenuItem
            // 
            this.escenarioToolStripMenuItem.Name = "escenarioToolStripMenuItem";
            this.escenarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.escenarioToolStripMenuItem.Text = "Escenario";
            // 
            // objetosToolStripMenuItem1
            // 
            this.objetosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.objeto1ToolStripMenuItem2});
            this.objetosToolStripMenuItem1.Name = "objetosToolStripMenuItem1";
            this.objetosToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.objetosToolStripMenuItem1.Text = "Objetos";
            // 
            // objeto1ToolStripMenuItem2
            // 
            this.objeto1ToolStripMenuItem2.Name = "objeto1ToolStripMenuItem2";
            this.objeto1ToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.objeto1ToolStripMenuItem2.Text = "Objeto1";
            // 
            // carasToolStripMenuItem1
            // 
            this.carasToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.objeto1ToolStripMenuItem3});
            this.carasToolStripMenuItem1.Name = "carasToolStripMenuItem1";
            this.carasToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.carasToolStripMenuItem1.Text = "Caras";
            // 
            // objeto1ToolStripMenuItem3
            // 
            this.objeto1ToolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem12,
            this.toolStripMenuItem13,
            this.toolStripMenuItem14,
            this.toolStripMenuItem15});
            this.objeto1ToolStripMenuItem3.Name = "objeto1ToolStripMenuItem3";
            this.objeto1ToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.objeto1ToolStripMenuItem3.Text = "Objeto1";
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem12.Text = "0";
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem13.Text = "1";
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem14.Text = "2";
            // 
            // toolStripMenuItem15
            // 
            this.toolStripMenuItem15.Name = "toolStripMenuItem15";
            this.toolStripMenuItem15.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem15.Text = "3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "X: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Y: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Z: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Objetos";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(59, 178);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 18;
            this.textBox4.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(199, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Caras";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(239, 178);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 20;
            this.textBox5.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 689);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem escenario1StripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EscenarioStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem objetosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem objeto1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem objeto2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem objeto1ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem objeto2ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem escenario2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escenarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem objetosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem objeto1ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem carasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem objeto1ToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem14;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem15;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
    }
}

