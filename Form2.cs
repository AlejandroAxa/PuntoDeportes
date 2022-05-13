using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto.Modelo;
using Proyecto.Logica;

namespace PuntoDeportes
{
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            mostrar_personas();

        }


        public void limpiar()
        {

            txtidProducto.Text = "";
            txtnombreProducto.Text = "";
            txtprecio.Text = "";
            txtcategoria.Text = "";
            txtnombreProducto.Focus();
        }
        public void mostrar_personas()
        {
            sgvProducto.DataSource = null;
            sgvProducto.DataSource = ProductoLogica.Instancia.Listar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Producto objeto = new Producto()
            {

                nombreProducto = txtnombreProducto.Text,
                precio = txtprecio.Text,
                categoria = txtcategoria.Text
            };

            bool respuesta = ProductoLogica.Instancia.Guardar(objeto);

            if (respuesta)
            {

                limpiar();
                mostrar_personas();
            }
        }

        private void buscarProducto_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void idProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void eliminarProducto_Click(object sender, EventArgs e)
        {
            Producto objeto = new Producto()
            {
                IdProducto = int.Parse(txtidProducto.Text)
            };

            bool respuesta = ProductoLogica.Instancia.Eliminar(objeto);

            if (respuesta)
            {
                limpiar();
                mostrar_personas();
            }
        }

        private void actProducto_Click(object sender, EventArgs e)
        {
            Producto objeto = new Producto()
            {
                IdProducto = int.Parse(txtidProducto.Text),
                nombreProducto = txtnombreProducto.Text,
                precio = txtprecio.Text,
                categoria= txtcategoria.Text
            };

            bool respuesta = ProductoLogica.Instancia.Editar(objeto);

            if (respuesta)
            {
                limpiar();
                mostrar_personas();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Inicio frm = new Inicio();

            frm.Show(); // mostramos el segun formulario

            this.Hide();
        }

        private void sgvProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
