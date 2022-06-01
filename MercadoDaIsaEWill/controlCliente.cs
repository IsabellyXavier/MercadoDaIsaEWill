using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoDaIsaEWill
{
    class controlCliente
    {
        cliente cliente;//Conectando a model e a control
        private int opcao;
        public controlCliente()
        {
            cliente = new cliente();
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
            Console.WriteLine("\n\n ~~~~~~~~~~~~~~~~~~~~~ MENU CLIENTE ~~~~~~~~~~~~~~~~~~~~~~~~ \n\n");
            Console.WriteLine("\n\nEscolha uma das opções abaixo:\n\n" +
            "1. Cadastrar Cliente\n" +
            "2. Consultar\n" +
            "3. Atualizar Nome\n" +
            "4. Atualizar CPF\n" +
            "5. Atualizar Telefone\n" +
            "6. Atualizar Endereço\n" +
            "7. Atualizar Sexo Biológico\n" +
            "8. Atualizar E-mail\n" +
            "9. Atualizar Quantidade de Compras\n" +
            "10. Atualizar Valor Total Gasto\n" +
            "11. Excluir\n" +
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
                        Console.WriteLine("Obrigado! Você saiu do Menu Cliente");
                        break;


                    case 1:
                        //Coletando o dado
                        Console.WriteLine("Informe um código: ");
                        int codigo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe um nome: ");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Informe um cpf: ");
                        string cpf = Console.ReadLine();
                        Console.WriteLine("Informe um telefone: ");
                        string telefone = Console.ReadLine();
                        Console.WriteLine("Informe um endereço: ");
                        string endereco = Console.ReadLine();
                        Console.WriteLine("Informe um sexo biologico: ");
                        string sexobiologico = Console.ReadLine();
                        Console.WriteLine("Informe um email: ");
                        string email = Console.ReadLine();
                        Console.WriteLine("Informe a quantidade de compra: ");
                        string quantidadedecompras = Console.ReadLine();
                        Console.WriteLine("Informe um valor total gasto: ");
                        string valortotalgasto = Console.ReadLine();


                        //Passei o dado por parâmetro para o método
                        cliente.CadastrarCliente(codigo, nome , cpf , telefone, endereco, sexobiologico, email, quantidadedecompras, valortotalgasto);

                        //Mostro o dado em tela
                        Console.WriteLine("Cadastrado com Sucesso!");
                        break;


                    case 2:

                        //Pedir para o usuário digitar um código
                        Console.WriteLine("Informe um código: ");
                        codigo = Convert.ToInt32(Console.ReadLine());

                        //Mostrar o resultado da operação
                        Console.WriteLine(cliente.Consultar(codigo));
                        Console.ReadLine();//Manter o prompt aberto
                        break;


                    case 3:
                        //Pedir para o usuário digitar o código e o novo nome
                        Console.WriteLine("Informe um código: ");
                        codigo = Convert.ToInt32(Console.ReadLine());



                        Console.WriteLine("Informe um nome: ");
                        nome = Console.ReadLine();
                        //Utilizar o método da classe model
                        Console.WriteLine(cliente.AtualizarNome(codigo, nome));
                        break;


                    case 4:
                        //Pedir para o usuário digitar o código e o novo nome
                        Console.WriteLine("Informe um código: ");
                        codigo = Convert.ToInt32(Console.ReadLine());



                        Console.WriteLine("Informe um cpf: ");
                        cpf = Console.ReadLine();
                        //Utilizar o método da classe model
                        Console.WriteLine(cliente.AtualizarCPF(codigo, cpf));
                        break;


                    case 5:
                        //Pedir para o usuário digitar o código e o novo nome
                        Console.WriteLine("Informe um código: ");
                        codigo = Convert.ToInt32(Console.ReadLine());



                        Console.WriteLine("Informe um telefone: ");
                        telefone = Console.ReadLine();
                        //Utilizar o método da classe model
                        Console.WriteLine(cliente.AtualizarTelefone(codigo, telefone));
                        break;


                    case 6:
                        //Pedir para o usuário digitar o código e o novo nome
                        Console.WriteLine("Informe um código: ");
                        codigo = Convert.ToInt32(Console.ReadLine());



                        Console.WriteLine("Informe um Endereço: ");
                        endereco = Console.ReadLine();
                        //Utilizar o método da classe model
                        Console.WriteLine(cliente.AtualizarEndereco(codigo, endereco));
                        break;

                    case 7:

                        //Pedir para o usuário digitar o código e o novo nome
                        Console.WriteLine("Informe um código: ");
                        codigo = Convert.ToInt32(Console.ReadLine());



                        Console.WriteLine("Informe um sexo biologico: ");
                        sexobiologico = Console.ReadLine();
                        //Utilizar o método da classe model
                        Console.WriteLine(cliente.AtualizarSexoBiologico(codigo, sexobiologico));
                        break;

                    case 8:

                        //Pedir para o usuário digitar o código e o novo nome
                        Console.WriteLine("Informe um código: ");
                        codigo = Convert.ToInt32(Console.ReadLine());



                        Console.WriteLine("Informe um email: ");
                        email = Console.ReadLine();
                        //Utilizar o método da classe model
                        Console.WriteLine(cliente.AtualizarEmail(codigo, email));
                        break;

                    case 9:

                        //Pedir para o usuário digitar o código e o novo nome
                        Console.WriteLine("Informe um código: ");
                        codigo = Convert.ToInt32(Console.ReadLine());



                        Console.WriteLine("Informe uma quantidade de compras: ");
                        quantidadedecompras = Console.ReadLine();
                        //Utilizar o método da classe model
                        Console.WriteLine(cliente.AtualizarQuantidadeDeCompras(codigo, quantidadedecompras));
                        break;

                    case 10:

                        //Pedir para o usuário digitar o código e o novo valor total gasto
                        Console.WriteLine("Informe um código: ");
                        codigo = Convert.ToInt32(Console.ReadLine());



                        Console.WriteLine("Informe o valor total gasto : ");
                        valortotalgasto = Console.ReadLine();
                        //Utilizar o método da classe model
                        Console.WriteLine(cliente.AtualizarValorTotalGasto(codigo, valortotalgasto));
                        break;

                    case 11 :
                        //Pedir para o usuário digitar o código e o novo nome
                        Console.WriteLine("Informe um código: ");
                        codigo = Convert.ToInt32(Console.ReadLine());
                        
                        //Utiliza o método
                        Console.WriteLine(cliente.Excluir(codigo));
                        break;


                    default:
                        Console.WriteLine("Opção escolhida não é válida! Tente novamente!");
                        break;
                }//fim do switch
            } while (AcessarOpcao != 0);

        }//fim do executar
    
}// fim do control
}
