using BilgeAdam.Api.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgeAdam.Api.Pokemon
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lstPokemon.SmallImageList = img;
            lstPokemon.LargeImageList = img;
            lstPokemon.Columns.Add("Adı");
            lstPokemon.Columns.Add("Kimlik Numarası");
            var man = new ApiManager();
            var pokemons = man.GetAll();
            foreach (var pokemon in pokemons)
            {
                var item = new ListViewItem(pokemon.Name, 0);
                item.SubItems.Add(pokemon.Id.ToString());
                lstPokemon.Items.Add(item);
            }
        }

        private void lstPokemon_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = lstPokemon.SelectedItems[0];

        }
    }
}
