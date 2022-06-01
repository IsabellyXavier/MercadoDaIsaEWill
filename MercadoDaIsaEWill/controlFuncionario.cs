using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoDaIsaEWill
{
    class controlFuncionario
    {
        funcionario funcionario;//Conectando a model e a control
        private int opcao;
        public controlFuncionario()
        {
            funcionario = new funcionario();
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
            Console.WriteLine("\n\n ~~~~~~~~~~~~~~~~~~~~~ MENU FUNCIONÁRIO ~~~~~~~~~~~~~~~~~~~~~~~~ \n\n");
            Console.WriteLine("\n\nEscolha uma das opções abaixo:\n\n" +
            "1. Cadastrar Funcionário\n" +
            "2. Consultar\n" +
            "3. Atualizar Nome\n" +
            "4. Atualizar Endereço\n" +
            "5. Atualizar CPF\n" +
            "6. Atualizar Telefone\n" +
            "7. Atualizar Sexo Biológico\n" +
            "8. Atualizar Salário\n" +
            "9. Atualizar Cargo\n" +
            "10. Excluir\n" +
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
                        Console.WriteLine("Obrigado! Você saiu do Menu Funcionário");
                        break;


                    case 1:
                        //Coletando o dado
                        Console.WriteLine("Informe um código: ");
                        int codigo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Informe um Nome: ");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Informe um Endereço: ");
                        string cpf = Console.ReadLine();
                        Console.WriteLine("Informe um CPF: ");
                        string telefone = Console.ReadLine();
                        Console.WriteLine("Informe um Telefone: ");
                        string endereco = Console.ReadLine();
                        Console.WriteLine("Informe um sexo biologico: ");
                        string sexobiologico = Console.ReadLine();
                        Console.WriteLine("Informe um salário: ");
                        string salario = Console.ReadLine();
                        Console.WriteLine("Informe um cargo: ");
                        string cargo = Console.ReadLine();




                        //Passei o dado por parâmetro para o método
                        funcionario.CadastrarFuncionario(codigo, nome, cpf, telefone, endereco, sexobiologico, salario, cargo);

                        //Mostro o dado em tela
                        Console.WriteLine("Cadastrado com Sucesso!");
                        break;


                    case 2:

                        //Pedir para o usuário digitar um código
                        Console.WriteLine("Informe um código: ");
                        codigo = Convert.ToInt32(Console.ReadLine());

                        //Mostrar o resultado da operação
                        Console.WriteLine(funcionario.Consultar(codigo));
                        Console.ReadLine();//Manter o prompt aberto
                        break;


                    case 3:
                        //Pedir para o usuário digitar o código e o novo nome
                        Console.WriteLine("Informe um código: ");
                        codigo = Convert.ToInt32(Console.ReadLine());



                        Console.WriteLine("Informe um nome: ");
                        nome = Console.ReadLine();
                        //Utilizar o método da classe model
                        Console.WriteLine(funcionario.AtualizarNome(codigo, nome));
                        break;


                    case 4:
                        //Pedir para o usuário digitar o código e o novo Endereço
                        Console.WriteLine("Informe um código: ");
                        codigo = Convert.ToInt32(Console.ReadLine());



                        Console.WriteLine("Informe um cpf: ");
                        endereco = Console.ReadLine();
                        //Utilizar o método da classe model
                        Console.WriteLine(funcionario.AtualizarEndereco(codigo, endereco));
                        break;


                    case 5:
                        //Pedir para o usuário digitar o código e o novo cpf
                        Console.WriteLine("Informe um código: ");
                        codigo = Convert.ToInt32(Console.ReadLine());



                        Console.WriteLine("Informe um CPF: ");
                        cpf = Console.ReadLine();
                        //Utilizar o método da classe model
                        Console.WriteLine(funcionario.AtualizarCPF(codigo, cpf));
                        break;


                    case 6:
                        //Pedir para o usuário digitar o código e o novo telefone
                        Console.WriteLine("Informe um código: ");
                        codigo = Convert.ToInt32(Console.ReadLine());



                        Console.WriteLine("Informe um Telefone: ");
                        telefone = Console.ReadLine();
                        //Utilizar o método da classe model
                        Console.WriteLine(funcionario.AtualizarTelefone(codigo, telefone));
                        break;

                    case 7:

                        //Pedir para o usuário digitar o código e o novo nome
                        Console.WriteLine("Informe um código: ");
                        codigo = Convert.ToInt32(Console.ReadLine());



                        Console.WriteLine("Informe um sexo biologico: ");
                        sexobiologico = Console.ReadLine();
                        //Utilizar o método da classe model
                        Console.WriteLine(funcionario.AtualizarSexoBiologico(codigo, sexobiologico));
                        break;

                    case 8:

                        //Pedir para o usuário digitar o código e o novo nome
                        Console.WriteLine("Informe um código: ");
                        codigo = Convert.ToInt32(Console.ReadLine());



                        Console.WriteLine("Informe um Salário: ");
                        salario = Console.ReadLine();
                        //Utilizar o método da classe model
                        Console.WriteLine(funcionario.AtualizarSalario(codigo, salario));
                        break;

                    case 9:

                        //Pedir para o usuário digitar o código e o novo nome
                        Console.WriteLine("Informe um código: ");
                        codigo = Convert.ToInt32(Console.ReadLine());



                        Console.WriteLine("Informe um Cargo: ");
                        cargo = Console.ReadLine();
                        //Utilizar o método da classe model
                        Console.WriteLine(funcionario.AtualizarEndereco(codigo, cargo));
                        break;



                    case 11:
                        //Pedir para o usuário digitar o código e o novo nome
                        Console.WriteLine("Informe um código: ");
                        codigo = Convert.ToInt32(Console.ReadLine());

                        //Utiliza o método
                        Console.WriteLine(funcionario.Excluir(codigo));
                        break;


                    default:
                        Console.WriteLine("Opção escolhida não é válida! Tente novamente!");
                        break;
                }//fim do switch
            } while (AcessarOpcao != 0);

        }//fim do executar

    }// fim da control
}// fim do projeto
