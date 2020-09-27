using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AKashi
{
    public partial class AddFavorites : Form
    {
        String url;
        public String favName, favFile;

        public AddFavorites(String url)
        {
            this.url = url;
            InitializeComponent();
        }

        private void AddFavorites_Load(object sender, EventArgs e)
        {
            textBox1.Text = url;
            comboBox1.Text = comboBox1.Items[0].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            favName = textBox1.Text;
            favFile = comboBox1.SelectedItem.ToString();
        }
    }
}
