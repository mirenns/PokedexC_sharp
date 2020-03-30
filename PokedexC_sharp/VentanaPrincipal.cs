using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokedexC_sharp
{
    public partial class VentanaPrincipal : Form
    {
        Conexion miConexion = new Conexion();
        DataTable misPokemons = new DataTable();
        int idActual = 1; //Pokemon que vemos

        public VentanaPrincipal()
        {
            InitializeComponent();
            dataGridView1.DataSource = miConexion.getTodosPokemons();
            //Para ajustar las dimensiones de la tabla
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private Image convierteBlobAImagen(byte[] img) 
        {
            MemoryStream ms = new System.IO.MemoryStream(img);
            return (Image.FromStream(ms));
        }

        private void izq_Click(object sender, EventArgs e)
        {
            idActual--;
            if (idActual <= 0)
            {
                idActual = 1;
            }

            misPokemons = miConexion.getPokemonPorId(idActual);
            nombrePokemon.Text = misPokemons.Rows[0]["nombre"].ToString();
            pictureBox1.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
            alturaPokemon.Text = misPokemons.Rows[0]["altura"].ToString();
            pesoPokemon.Text = misPokemons.Rows[0]["peso"].ToString();
            especiePokemon.Text = misPokemons.Rows[0]["especie"].ToString();
            habilidadPokemon.Text = misPokemons.Rows[0]["habilidad"].ToString();
        }

        private void der_Click(object sender, EventArgs e)
        {
            idActual++;
            if (idActual >= 151)
            {
                idActual = 151;
            }

            misPokemons = miConexion.getPokemonPorId(idActual);
            nombrePokemon.Text = misPokemons.Rows[0]["nombre"].ToString();
            pictureBox1.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
            alturaPokemon.Text = misPokemons.Rows[0]["altura"].ToString();
            pesoPokemon.Text = misPokemons.Rows[0]["peso"].ToString();
            especiePokemon.Text = misPokemons.Rows[0]["especie"].ToString();
            habilidadPokemon.Text = misPokemons.Rows[0]["habilidad"].ToString();
        }

        //Botón que nos lleva a un form con toda la información del Pokemon
        private void button1_Click(object sender, EventArgs e)
        {
            Ventana2 v = new Ventana2();
            v.datosPokemon(nombrePokemon.Text, especiePokemon.Text, misPokemons.Rows[0]["habitat"].ToString(), 
                            alturaPokemon.Text, pesoPokemon.Text, misPokemons.Rows[0]["tipo1"].ToString(),
                            misPokemons.Rows[0]["tipo2"].ToString(), misPokemons.Rows[0]["movimiento1"].ToString(),
                            misPokemons.Rows[0]["movimiento2"].ToString(), misPokemons.Rows[0]["movimiento3"].ToString(),
                            misPokemons.Rows[0]["movimiento4"].ToString(), convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]),
                            misPokemons.Rows[0]["descripcion"].ToString(), habilidadPokemon.Text);
            v.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TodaPokedex v = new TodaPokedex();
            v.Show();

        }

        //Método para que si pulsas en cualquier elemento del data grid view, te aparezca
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            nombrePokemon.Text = dataGridView1.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
            pictureBox1.Image = convierteBlobAImagen((byte[])dataGridView1.Rows[e.RowIndex].Cells["imagen"].Value);
            alturaPokemon.Text = dataGridView1.Rows[e.RowIndex].Cells["altura"].Value.ToString();
            pesoPokemon.Text = dataGridView1.Rows[e.RowIndex].Cells["peso"].Value.ToString();
            especiePokemon.Text = dataGridView1.Rows[e.RowIndex].Cells["especie"].Value.ToString();
            habilidadPokemon.Text = dataGridView1.Rows[e.RowIndex].Cells["habilidad"].Value.ToString();

        }

        //Método para poder escribir en la tabla y que se actualice con lo escrito
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //Sabes qué celda ha sido pulsada
            String nombre = dataGridView1.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
            String id = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
            MessageBox.Show(miConexion.actualizaPokemon(id, nombre));
            
        }
    }
}
