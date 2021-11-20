using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3C1Vítor42.Code.BLL;
using _3C1Vítor42.Code.DTO;

namespace _3C1Vítor42
{
    public partial class Form_RiHappy : Form
    {

        ProdutosBLL probll = new ProdutosBLL();
        PreçosDTO predto = new PreçosDTO();
        

        public Form_RiHappy()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            predto.Produtos = txtproduto.Text;
            predto.Precos = txtpreco.Text;

            predto.Inserir(predto);

            MessageBox.Show("Cadastrado com sucesso!", "Produtos", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtID.Clear();
            txtproduto.Clear();
            txtpreco.Clear();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            predto.ID = int.Parse(txtID.Text);
            predto.Produtos = txtproduto.Text;
            predto.Precos = txtpreco.Text;

            probll.Editar(predto);

            MessageBox.Show("Editado com sucesso!", "Produtos", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtID.Clear();
            txtproduto.Clear();
            txtpreco.Clear();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            predto.ID = int.Parse(txtID.Text);

            probll.Excluir(predto);

            MessageBox.Show("Editado com sucesso!", "Vendedor", MessageBoxButtons.OK, MessageBoxIcon.Information);

            probll.Listar();

            txtID.Clear();
            txtproduto.Clear();
            txtpreco.Clear();
        }

        private void Forms_Funcionario_Load(object sender, EventArgs e)
        {
            dgvRiHappy.DataSource = probll.Listar();

        }

        private void dgvRiHappy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvRiHappy.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtproduto.Text = dgvRiHappy.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtpreco.Text = dgvRiHappy.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}
