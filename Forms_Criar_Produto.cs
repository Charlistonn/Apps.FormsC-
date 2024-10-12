using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula_app.form
{
    public partial class Forms_Criar_Produto : Form
    {
        public string nomeProduto { get { return this.textBoxNome.Text; } }
        public string nomeFabricante { get { return this.TextBoxFabricante.Text; } }
        public decimal precoCompra { get { return (decimal)this.inputPrecoCompra.Value; } }
        public decimal precoVenda { get { return (decimal)this.inputPrecoVenda.Value; } }
        public Forms_Criar_Produto()
        {
            InitializeComponent();
        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
