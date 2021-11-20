using _3C1Vítor42.Code.DTO;
using Projeto_de_3_Camadas.Code.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3C1Vítor42.Code.BLL
{
    class RiHappyLoginBLL
    {
        Acesso_BD conexao = new Acesso_BD();
        string tabela = "tbl_Login";
        private object update;

        public bool RealizarLogin(RiHappyLoginDTO login)
        {
            string sql = $"select * from {tabela} where email='{login.Email}' and senha='{login.Senha}'";
            DataTable dt = conexao.ExecutarGerenciamento(sql);

            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public string RetornarSenha(RiHappyLoginDTO login)
        {
            string sql = $"select * from {tabela} where email='{login.Email}'";
            DataTable dt = conexao.ExecutarGerenciamento(sql);

            if (dt.Rows.Count > 0)
                return dt.Rows[0]["senha"].ToString();
            else
                return "false";
        }
    }
}
