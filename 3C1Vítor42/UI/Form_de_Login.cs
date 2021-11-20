using _3C1Vítor42.Code.BLL;
using _3C1Vítor42.Code.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3C1Vítor42.UI
{
    public partial class Form_de_Login : Form
    {


        RiHappyLoginBLL loginBLL = new RiHappyLoginBLL();
        RiHappyLoginDTO loginDTO = new RiHappyLoginDTO();

        public Form_de_Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            loginDTO.Email = txtemail.Text;
            loginDTO.Senha = txtsenha.Text;

            if (loginBLL.RealizarLogin(loginDTO) == true)
            {

                Form_RiHappy formRiHappy = new Form_RiHappy();
                formRiHappy.ShowDialog();

            }
            else
            {
                MessageBox.Show("Verifique o seu e-mail ou a sua senha.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkesqueci_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("vitorfonseca.231118@gmail.com", "lwkejdlxawtwpnjc"),
                EnableSsl = true
            };


            loginDTO.Email = txtemail.Text;
            string senha = loginBLL.RetornarSenha(loginDTO);



            client.Send("vitorfonseca.231118@gmail.com", $"{txtemail.Text}", "Redefinição de Senha", $"Seu email é {txtemail.Text} com senha {senha}");

            MessageBox.Show("E-mail e Senha enviados com sucesso.", "E-mail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
