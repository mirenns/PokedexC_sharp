using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokedexC_sharp
{
    public partial class Ventana2 : Form
    {
       
        public Ventana2()
        {
            InitializeComponent();
        }

        public void datosPokemon(String nombrePokemon, String especiePokemon, String habitatPokemon, String alturaPokemon, String pesoPokemon,
                                String tipo1Pokemon, String tipo2Kodemon, String movimiento1Pokemon,
                                String movimiento2Pokemon, String movimiento3Pokemon, String movimiento4Pokemon,
                                Image imagenPokemon, String descripcionPokemon, String habilidadPokemon)
        {
            nombre.Text = nombrePokemon;
            especie.Text = especiePokemon;
            habitat.Text = habitatPokemon;
            altura.Text = alturaPokemon;
            peso.Text = pesoPokemon;
            tipo1.Text = tipo1Pokemon;
            tipo2.Text = tipo2Kodemon;
            movimiento1.Text = movimiento1Pokemon;
            movimiento2.Text = movimiento2Pokemon;
            movimiento3.Text = movimiento3Pokemon;
            movimiento4.Text = movimiento4Pokemon;
            pictureBox1.Image = imagenPokemon;
            descripcion.Text = descripcionPokemon;
            habilidad.Text = habilidadPokemon;
        }
    }
}
