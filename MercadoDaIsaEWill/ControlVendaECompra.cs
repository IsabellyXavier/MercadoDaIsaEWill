using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoDaIsaEWill
{
    class ControlVendaECompra
    {
        vendaEcompra vendaEcompra;//Conectando a model e a control
        private int opcao;
        public ControlVendaECompra()
        {
            vendaEcompra = new vendaEcompra();
        }//fim do construtor



        public int AcessarOpcao
        {
            get
            {
                return opcao;
            }
            set
            {
                this.opcao = value;
            }
        }//fim do acessarOpcao
        public void Menu()
        {
            Console.Clear();//Limpar a tela do console
            Console.WriteLine("\n\nEscolha uma das opções abaixo:\n\n" +
            "1. Cadastrar Venda\n" +
            "2. Consultar\n" +
            "3. Atualizar Quantidade\n" +
            "4. Atualizar Valor Total\n" +
            "5. Excluir\n" +
            "0. Sair ");
            AcessarOpcao = Convert.ToInt32(Console.ReadLine());

        }//fim do método menu



        public void Executar()
        {
            do
            {
                Menu();
                //Executar a ação
                switch (AcessarOpcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;


                    case 1:
                        //Coletando o dado
                        Console.WriteLine("Informe um código: ");
                        int codigo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe uma quantidade: ");
                        string quantidade = Console.ReadLine();
                        Console.WriteLine("Informe um valor total: ");
                        string valortotal = Console.ReadLine();


                        //Passei o dado por parâmetro para o método
                        vendaEcompra.CadastrarVenda(codigo, quantidade, valortotal);

                        //Mostro o dado em tela
                        Console.WriteLine("Cadastrado com Sucesso!");
                        break;


                    case 2:

                        //Pedir para o usuário digitar um código
                        Console.WriteLine("Informe um código: ");
                        codigo = Convert.ToInt32(Console.ReadLine());

                        //Mostrar o resultado da operação
                        Console.WriteLine(vendaEcompra.Consultar(codigo));
                        Console.ReadLine();//Manter o prompt aberto
                        break;


                    case 3:
                        //Pedir para o usuário digitar o código e o novo nome
                        Console.WriteLine("Informe um código: ");
                        codigo = Convert.ToInt32(Console.ReadLine());



                        Console.WriteLine("Informe uma quantidade: ");
                        quantidade = Console.ReadLine();
                        //Utilizar o método da classe model
                        Console.WriteLine(vendaEcompra.AtualizarQuantidade(codigo, quantidade));
                        break;


                    case 4:
                        //Pedir para o usuário digitar o código e o novo nome
                        Console.WriteLine("Informe um código: ");
                        codigo = Convert.ToInt32(Console.ReadLine());



                        Console.WriteLine("Informe um valor total: ");
                        valortotal = Console.ReadLine();
                        //Utilizar o método da classe model
                        Console.WriteLine(vendaEcompra.AtualizarValorTotal(codigo, valortotal));
                        break;


                    case 5:
                        //Pedir para o usuário digitar o código e o novo nome
                        Console.WriteLine("Informe um código: ");
                        codigo = Convert.ToInt32(Console.ReadLine());

                        //Utiliza o método
                        Console.WriteLine(vendaEcompra.Excluir(codigo));
                        break;


                    default:
                        Console.WriteLine("Opção escolhida não é válida! Tente novamente!");
                        break;
                }//fim do switch
            } while (AcessarOpcao != 0);

        }//fim do executar
    }
}
