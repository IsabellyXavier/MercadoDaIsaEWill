using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoDaIsaEWill
{
    class ControlMenuPrincipal
    {

        menuPrincipal conexao;//Criando a variável conexão
        menuPrincipal menuPrincipal;
        public int opcao;
        public ControlMenuPrincipal()
        {
            conexao = new menuPrincipal();
            menuPrincipal = new menuPrincipal();

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
            Console.Clear();

            Console.WriteLine("\n\n ~~~~~~~~~~~~~~~~~~~~~ MENU PRINCIPAL ~~~~~~~~~~~~~~~~~~~~~~~~ \n\n");

            Console.WriteLine("\n\nEscolha uma das opções abaixo:\n\n" +

                "1. Cliente\n" +
                "2. Produto\n" +
                "3. Compra\n" +
                "4. Funcionario \n" +                
                "0. Sair");

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
                        Console.WriteLine("Obrigado! Você saiu do Menu Pricipal");
                        break;


                    case 1:
                        //Coletando o dado

                        controlCliente controlCliente = new controlCliente();
                        controlCliente.Executar();//Estou usando o método executar
                        Console.ReadLine();//Manter o prompt aberto

                        break;


                    case 2:

                        controlProduto controlProduto = new controlProduto();
                        controlProduto.Executar();//Estou usando o método executar
                        Console.ReadLine();//Manter o prompt aberto


                        break;


                    case 3:

                        ControlVendaECompra controlVendaEcompra = new ControlVendaECompra();
                        controlVendaEcompra.Executar();//Estou usando o método executar
                        Console.ReadLine();//Manter o prompt aberto

                        break;


                    case 4:

                        controlFuncionario controlFuncionario = new controlFuncionario();
                        controlFuncionario.Executar();//Estou usando o método executar
                        Console.ReadLine();//Manter o prompt aberto

                        break;



                    default:
                        Console.WriteLine("Opção escolhida não é válida! Tente novamente!");
                        break;

                }//fim do switch

            } while (AcessarOpcao != 0);

        }//fim do executar
    }// fim da control menu principal


}// fim do projeto
