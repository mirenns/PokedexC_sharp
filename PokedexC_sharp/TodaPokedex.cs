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
    public partial class TodaPokedex : Form
    {
        Conexion conexionPokedex = new Conexion();

        public TodaPokedex()
        {
            InitializeComponent();
            dataGridView1.DataSource = conexionPokedex.getTodosPokemons();
            //Para ajustar las dimensiones de la tabla
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }
    }
}
