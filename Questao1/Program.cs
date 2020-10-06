using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Helpers;

/*
 *  Questão 1
 *  Faça um programa que liste na console todos os pedidos de venda (SalesOrder) de todos os usuários (User). 
 * 
 * Output esperado
 * User 1
 * -- SalesOrderNumber, TotalValue, ItensCount
 * -- SalesOrderNumber, TotalValue, ItensCount
 * -- SalesOrderNumber, TotalValue, ItensCount
 * User 2
 * -- SalesOrderNumber, TotalValue, ItensCount
 * User N
 * -- SalesOrderNumber, TotalValue, ItensCount
 * -- SalesOrderNumber, TotalValue, ItensCount
 * 
 * Onde "User N" pode ser substituído pelo campo Name da tabela User e SalesOrderNumber, TotalValue, ItensCount os campos da tabela SalesOrder.
 *
 */
namespace Questao1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Questão 1 - Listagem de pedidos de vendas de todos os usuários: ");

            using (SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.AppSettings["Questao1.Properties.Settings.DatabaseConnectionString"]))
            {
                SqlCommand sqlCommand = new SqlCommand("select * from ");
            }

            Console.ReadKey();

        }
    }
}
