using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using eugenio.Models;

    public class ProdutoModel 
    {
        public List<Produto> Consultarproduto(string barcode)
        {
            List<Produto> lista = new List<Produto>();

            string conexao = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\eugenio_web_rev0f\\eugenio_web\\eugenio\\App_Data\\Natura.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection cn = new SqlConnection(conexao);
            SqlCommand cmd = new SqlCommand($"SELECT * FROM Produto WHERE barcode = {barcode}", cn);
            cn.Open();
              
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Produto produto = new Produto();
                produto.Name = (string)reader["name"];
                produto.Type = (string)reader["type"];
                lista.Add(produto);
            }
            return lista;

        }
    }
