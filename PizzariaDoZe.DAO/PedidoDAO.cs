﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.DAO
{
    public class Pedido
    {
        public Pedido(int id = 0, int IdCliente = 0, string status = "", bool entrega = false, decimal valorTotal = 0, List<Valor> listaValores = null!, List<Produto> listaProdutos = null!)
        {
            this.ID = id;
            this.IDCliente = IdCliente;
            this.Status = status;
            this.Entrega = entrega;
            this.ListaValores = listaValores;
            this.ListaProdutos = listaProdutos;
            this.ValorTotal = valorTotal;
            this.DataPedido = DateTime.Now;
        }
        public int ID { get; set; }
        public int IDCliente { get; set; }
        public string Status { get; set; }
        public bool Entrega { get; set; }
        public List<Valor> ListaValores { get; set; }
        public List<Produto> ListaProdutos { get; set; }
        public decimal ValorTotal { get; private set; }
        public DateTime DataPedido { get; set; }
    }
    public class PedidoDAO
    {
        private readonly DbProviderFactory factory;
        private string Provider { get; set; }
        private string StringConexao { get; set; }

        public PedidoDAO(string provider, string stringConexao)
        {
            Provider = provider;
            StringConexao = stringConexao;
            factory = DbProviderFactories.GetFactory(Provider);
        }

        public int Inserir(Pedido pedido)
        {
            using var conexao = factory.CreateConnection(); //Cria conexão
            conexao!.ConnectionString = StringConexao; //Atribui a string de conexão
            using var comando = factory.CreateCommand(); //Cria comando
            comando!.Connection = conexao; //Atribui conexão
            var IdCliente = comando.CreateParameter(); IdCliente.ParameterName = "@cliente_id";
            IdCliente.Value = pedido.IDCliente; comando.Parameters.Add(IdCliente);
            var Status = comando.CreateParameter(); Status.ParameterName = "@status";
            Status.Value = pedido.Status; comando.Parameters.Add(Status);
            var Entrega = comando.CreateParameter(); Entrega.ParameterName = "@entrega";
            Entrega.Value = pedido.Entrega; comando.Parameters.Add(Entrega);
            var ValorTotal = comando.CreateParameter(); ValorTotal.ParameterName = "@total";
            ValorTotal.Value = pedido.ValorTotal; comando.Parameters.Add(ValorTotal);
            var DataPedido = comando.CreateParameter(); DataPedido.ParameterName = "@data";
            DataPedido.Value = pedido.DataPedido; comando.Parameters.Add(DataPedido);
            conexao.Open();
            DbTransaction transacao = conexao.BeginTransaction();
            comando.Transaction = transacao;
            try
            {
                string auxSQL_ID = Provider.Contains("MySql") ? "SELECT LAST_INSERT_ID();" : "SELECT SCOPE_IDENTITY();";
                comando.CommandText = @"INSERT INTO tb_pedidos (cliente_id, status, entrega, valor_total, data_pedido) VALUES (@cliente_id, @status, @entrega, @total, @data);" + auxSQL_ID;
                var IdPedidoGerado = comando.ExecuteScalar();
                foreach (Valor valor in pedido.ListaValores)
                {
                    // salvar os ingredientes do sabor
                    comando.CommandText = @"INSERT INTO lista_pizzas(pedido_id, pizza_id) VALUES (" + Convert.ToInt32(IdPedidoGerado) + "," + valor.Id + ")";
                    var linhasRecebimentoComanda = comando.ExecuteNonQuery();
                }
                
                transacao.Commit();

                return Convert.ToInt32(IdPedidoGerado);
            }
            catch (Exception ex)
            {
                
                transacao.Rollback();

                
                throw new Exception(ex.Message);
            }
        }
    }
}
