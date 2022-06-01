using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoDaIsaEWill
{
    class controlProduto
    {
        produto prod;//Conectando a model e a control
        private int opcao;
        public controlProduto()
        {
            prod = new produto();
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
            Console.WriteLine("\n\n ~~~~~~~~~~~~~~~~~~~~~ MENU PRODUTO ~~~~~~~~~~~~~~~~~~~~~~~~ \n\n");
            Console.WriteLine("\n\nEscolha uma das opções abaixo:\n\n" +
            "1. Cadastrar Produto\n" +
            "2. Consultar\n" +
            "3. Atualizar Descriçao\n" +
            "4. Atualizar Quantidade\n" +
            "5. Atualizar Unidade de Medida\n" +
            "6. Atualizar Valor Unitario\n" +
            "7. Atualizar Data de Fabricaçao\n" +
            "8. Atualizar Data de Validade\n" +
            "9. Atualizar Tipo de Produto \n" +
            "10. Atualiazar Valor Unitario \n" +
            "11. excluir\n" +
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
                        Console.WriteLine("Obrigado! Você saiu do Menu Produto");
                        break;


                    case 1:
                        //Coletando o dado
                        Console.WriteLine("Informe um código: ");
                        int codigo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe uma descriçao: ");
                        string descricao = Console.ReadLine();
                        Console.WriteLine("Informe uma quantidade: ");
                        string quantidade = Console.ReadLine();
                        Console.WriteLine("Informe uma unidade de medida: ");
                        string unidadedemedida = Console.ReadLine();
                        Console.WriteLine("Informe um valor unitario: ");
                        string valorunitario = Console.ReadLine();
                        Console.WriteLine("Informe uma data de fabricaçao: ");
                        DateTime datadefabricacao = new DateTime();
                        Console.WriteLine("Informe uma data de validade: ");
                        DateTime datadevalidade = new DateTime();
                        Console.WriteLine("Informe um tipo de produto: ");
                        string tipodeproduto = Console.ReadLine();
                        

                        //Passei o dado por parâmetro para o método
                        prod.CadastrarProduto(codigo, descricao, quantidade, unidadedemedida, valorunitario, datadefabricacao, datadevalidade, tipodeproduto);

                        //Mostro o dado em tela
                        Console.WriteLine("Cadastrado com Sucesso!");
                        break;


                    case 2:

                        //Pedir para o usuário digitar um código
                        Console.WriteLine("Informe um código: ");
                        codigo = Convert.ToInt32(Console.ReadLine());

                        //Mostrar o resultado da operação
                        Console.WriteLine(prod.Consultar(codigo));
                        Console.ReadLine();//Manter o prompt aberto
                        break;


                    case 3:
                        //Pedir para o usuário digitar o código e o novo nome
                        Console.WriteLine("Informe um código: ");
                        codigo = Convert.ToInt32(Console.ReadLine());



                        Console.WriteLine("Informe uma descricao: ");
                        descricao = Console.ReadLine();
                        //Utilizar o método da classe model
                        Console.WriteLine(prod.AtualizarDescricao(codigo, descricao));
                        break;


                    case 4:
                        //Pedir para o usuário digitar o código e o novo nome
                        Console.WriteLine("Informe um código: ");
                        codigo = Convert.ToInt32(Console.ReadLine());



                        Console.WriteLine("Informe um cpf: ");
                        quantidade = Console.ReadLine();
                        //Utilizar o método da classe model
                        Console.WriteLine(prod.AtualizarQuantidade(codigo, quantidade));
                        break;


                    case 5:
                        //Pedir para o usuário digitar o código e o novo nome
                        Console.WriteLine("Informe um código: ");
                        codigo = Convert.ToInt32(Console.ReadLine());



                        Console.WriteLine("Informe uma unidade de medida: ");
                        unidadedemedida = Console.ReadLine();
                        //Utilizar o método da classe model
                        Console.WriteLine(prod.AtualizarUnidadeDeMedida(codigo, unidadedemedida));
                        break;


                    case 6:
                        //Pedir para o usuário digitar o código e o novo nome
                        Console.WriteLine("Informe um código: ");
                        codigo = Convert.ToInt32(Console.ReadLine());



                        Console.WriteLine("Informe um valor unitario: ");
                        valorunitario = Console.ReadLine();
                        //Utilizar o método da classe model
                        Console.WriteLine(prod.AtualizarValorUnitario(codigo, valorunitario));
                        break;

                    case 7:

                        //Pedir para o usuário digitar o código e o novo nome
                        Console.WriteLine("Informe um código: ");
                        codigo = Convert.ToInt32(Console.ReadLine());



                        Console.WriteLine("Informe uma data de fabricaçao: ");
                        datadefabricacao = new DateTime();
                        //Utilizar o método da classe model
                        Console.WriteLine(prod.AtualizarDataDeFabricacao(codigo, datadefabricacao));
                        break;

                    case 8:

                        //Pedir para o usuário digitar o código e o novo nome
                        Console.WriteLine("Informe um código: ");
                        codigo = Convert.ToInt32(Console.ReadLine());



                        Console.WriteLine("Informe uma data de validade: ");
                        datadevalidade = new DateTime();
                        //Utilizar o método da classe model
                        Console.WriteLine(prod.AtualizarDataDeValidade(codigo, datadevalidade));
                        break;

                    case 9:

                        //Pedir para o usuário digitar o código e o novo nome
                        Console.WriteLine("Informe um código: ");
                        codigo = Convert.ToInt32(Console.ReadLine());



                        Console.WriteLine("Informe um tipo de produto: ");
                        tipodeproduto = Console.ReadLine();
                        //Utilizar o método da classe model
                        Console.WriteLine(prod.AtualizarTipoDeProduto(codigo, tipodeproduto));
                        break;

                    case 10:

                        //Pedir para o usuário digitar o código e o novo valor total gasto
                        Console.WriteLine("Informe um código: ");
                        codigo = Convert.ToInt32(Console.ReadLine());



                        Console.WriteLine("Informe o valor unitario : ");
                        valorunitario = Console.ReadLine();
                        //Utilizar o método da classe model
                        Console.WriteLine(prod.AtualizarValorUnitario(codigo, valorunitario));
                        break;

                    case 11:
                        //Pedir para o usuário digitar o código e o novo nome
                        Console.WriteLine("Informe um código: ");
                        codigo = Convert.ToInt32(Console.ReadLine());

                        //Utiliza o método
                        Console.WriteLine(prod.Excluir(codigo));
                        break;


                    default:
                        Console.WriteLine("Opção escolhida não é válida! Tente novamente!");
                        break;
                }//fim do switch
            } while (AcessarOpcao != 0);

        }//fim do executar
    }
}
