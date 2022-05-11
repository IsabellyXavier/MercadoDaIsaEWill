using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoDaIsaEWill
{
    class Program
    {
        static void Main(string[] args)
        {
            controlCliente controlCliente = new controlCliente();
            controlCliente.Executar();//Estou usando o método executar
            Console.ReadLine();//Manter o prompt aberto

            controlFuncionario controlFuncionario = new controlFuncionario();
            controlFuncionario.Executar();//Estou usando o método executar
            Console.ReadLine();//Manter o prompt aberto

            controlProduto controlProduto = new controlProduto();
            controlProduto.Executar();//Estou usando o método executar
            Console.ReadLine();//Manter o prompt aberto

            ControlVendaECompra controlVendaEcompra = new ControlVendaECompra();
            controlVendaEcompra.Executar();//Estou usando o método executar
            Console.ReadLine();//Manter o prompt aberto
        }// fim do metodo main
    }// fim da classe
}// fim do programa
