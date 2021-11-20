using _3C1Vítor42.Code.DTO;
using _3C1Vítor42.Code.BLL;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_de_3_Camadas.Code.DAL;

namespace _3C1Vítor42.Code.BLL
{
    class ProdutosBLL
    {
        Acesso_BD conexao = new Acesso_BD();
        string tabela = "tbl_Produtos";


        public void Inserir(PreçosDTO preDto)
        {
            string inserir = $"insert into {tabela} values(null,'{preDto.Produtos}','{preDto.Precos}')";
            conexao.ExecutarComando(inserir);
        }

        public void Editar(PreçosDTO preDto)
        {
            string alterar = $"update {tabela} set produto = 'preDto.Produtos', Preços = '{preDto.Precos}' where id = '{preDto.ID}';";
            conexao.ExecutarComando(alterar);
        }

        public void Excluir(PreçosDTO preDto)
        {
            string excluir = $"delete from {tabela} where id = '{preDto.ID}';";
            conexao.ExecutarComando(excluir);
        }
        
        public DataTable Listar()
        {
            string sql = $"select * from {tabela} order by id;";
            return conexao.ExecutarGerenciamento(sql);
        }
    }
}
