using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSQL
{
    public abstract class Base : IPessoa
    {
        /// <summary>
        /// Construtor da classe
        /// </summary>
        /// <param name="nome">Para preencher o nome do objeto.</param>
        public Base(string nome, string CPF, string telefone)
        {
            this.Nome = nome;
            this.CPF = CPF;
            this.Telefone = telefone;
        }
        /// <summary>
        /// Construtor sem parametros
        /// </summary>
        public Base() { }

        public string Nome;
        public string Telefone;
        public string CPF;

        public void SetNome(string nome) { this.Nome = nome; }
        public void SetTelefone(string telefone) { this.Telefone = telefone; }
        public void SetCPF(string cpf) { this.CPF = cpf; }

        public void Gravar()
        {
            string connectionString = ConfigurationManager.AppSettings["sqlConnection"];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryString = "INSERT INTO tbl" + this.GetType().Name + "s (Nome, Telefone, CPF) VALUES('" + this.Nome + "', '" + this.Telefone + "', '" + this.CPF + "')";
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}