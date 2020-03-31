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

        //Botón que nos lleva a un form con toda la pokedex para elegir
        private void button2_Click(object sender, EventArgs e)
        {
            TodaPokedex eligePokemon = new TodaPokedex();
            eligePokemon.ShowDialog();
            idActual = eligePokemon.idSeleccionado;
            misPokemons = miConexion.getPokemonPorId(eligePokemon.idSeleccionado);
            nombrePokemon.Text = misPokemons.Rows[0]["nombre"].ToString();
            pictureBox1.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
            alturaPokemon.Text = misPokemons.Rows[0]["altura"].ToString();
            pesoPokemon.Text = misPokemons.Rows[0]["peso"].ToString();
            especiePokemon.Text = misPokemons.Rows[0]["especie"].ToString();
            habilidadPokemon.Text = misPokemons.Rows[0]["habilidad"].ToString();


        }

    }
}
