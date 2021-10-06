using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Circulo circulo = new Circulo();

            MessageBox.Show(circulo.dibujar(), "Información del círculo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(circulo.dibujar(" circulo ", " La computadora "),"Información del círculo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(circulo.establecerColor(),"Información del círculo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(circulo.establecerColor(" azul"," circulo"), "Información del círculo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(circulo.obtenerColor(),"Información del círculo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(circulo.obtenerColor("azul"), "Información del círculo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Triangulo triangulo = new Triangulo();

            MessageBox.Show(triangulo.dibujar(), "Información del triangulo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(triangulo.dibujar(" triangulo ", " La computadora "), "Información del triangulo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(triangulo.establecerColor(), "Información del triangulo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(triangulo.establecerColor(" rojo", " triangulo"), "Información del triangulo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(triangulo.obtenerColor(), "Información del triangulo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(triangulo.obtenerColor("rojo"), "Información del triangulo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Rectangulo rectangulo = new Rectangulo();

            MessageBox.Show(rectangulo.dibujar(), "Información del rectangulo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(rectangulo.dibujar(" rectangulo ", " La computadora "), "Información del rectangulo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(rectangulo.establecerColor(), "Información del rectangulo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(rectangulo.establecerColor(" ", " rectangulo"), "Información del rectangulo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(rectangulo.obtenerColor(), "Información del rectangulo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(rectangulo.obtenerColor("rojo"), "Información del rectangulo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
