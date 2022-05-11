using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoDaIsaEWill
{
    class funcionario
    {
        private int codigo;
        private string nome;
        private string endereco;
        private string cpf;
        private string telefone;
        private string sexobiologico;
        private string salario;
        private string cargo;
        

        //_______________________________________________________________________________________________________________________________________________________


        public funcionario()
        {
            //Instanciando as variáveis

            AcessarCodigo = 0;
            AcessarNome = "";
            AcessarEndereco = "";
            AcessarCPF = "";
            AcessarTelefone = "";
            AcessarSexoBiologico = "";
            AcessarSalario = "";
            AcessarCargo= "";
            




        }// fim do construtor


        //_____________________________________________________________________________________________________________________________________________________


        public int AcessarCodigo
        {
            get
            {
                return codigo;
            }
            set
            {
                this.codigo = value;
            }
        }//fim do método de acesso de código



        public string AcessarNome
        {
            get
            {
                return nome;
            }
            set
            {
                this.nome = value;
            }
        }//fim do método de AcessarNome



        public string AcessarEndereco
        {
            get
            {
                return endereco;
            }
            set
            {
                this.endereco = value;
            }

        }//fim do acessarEndereco

        public string AcessarCPF
        {
            get
            {
                return cpf;
            }
            set
            {
                this.cpf = value;
            }
        }//fim do acessarCPF


        public string AcessarTelefone
        {
            get
            {
                return telefone;
            }
            set
            {
                this.telefone = value;
            }
        }//fim do acessarTelefone



        public string AcessarSexoBiologico
        {
            get
            {
                return sexobiologico;
            }
            set
            {
                this.sexobiologico = value;
            }
        }//fim do acessarSexoBiologico



        public string AcessarSalario
        {
            get
            {
                return salario;
            }
            set
            {
                this.salario = value;
            }

        }//fim do AcessarSalario



        public string AcessarCargo
        {
            get
            {

                return cargo;
            }
            set
            {
                this.cargo = value;
            }

        }//fim do AcessarCargo


        //_______________________________________________________________________________________________________________________________________________________


        public void CadastrarFuncionario(int codigo, string nome, string endereco, string cpf, string telefone, string sexobiologico, string salario, string cargo)
        {
            AcessarCodigo = codigo;
            AcessarNome = nome;
            AcessarEndereco = endereco;
            AcessarCPF = cpf;
            AcessarTelefone = telefone;
            AcessarSexoBiologico = sexobiologico;
            AcessarSalario = salario;
            AcessarCargo = cargo;
            

        }// fim do cadastrar.


        //_______________________________________________________________________________________________________________________________________________________             

        public string Consultar(int codigo)
        {
            if (AcessarCodigo == codigo)
            {
                return "Código: " + AcessarCodigo +
                "\nNome Completo: " + AcessarNome +
                "\nEndereço: " + AcessarEndereco +
                "\nCPF:" + AcessarCPF +
                "\nTelefone: " + AcessarTelefone +
                "\nSexo Biológico: " + AcessarSexoBiologico +
                "\nsalario :" + AcessarSalario +
                "\nCargo :" + AcessarCargo;
            }

            else
            {
                return "Código Informado Não é Valido!";
            }

        }//fim do método consultar


        //_______________________________________________________________________________________________________________________________________________________


        public string AtualizarNome(int codigo, string nome)
        {
            if (AcessarCodigo == codigo)
            {
                AcessarNome = nome;
                return "Dado Atualizado com Sucesso!";
            }
            else
            {
                return "Código digitado não é válido!";
            }

        }//fim do método atualizar nome.

        public string AtualizarEndereco(int codigo, string endereco)
        {
            if (AcessarCodigo == codigo)
            {
                AcessarEndereco = endereco;
                return "Endereço atualizado com sucesso!";
            }
            else
            {
                return "Código informado não é válido!";
            }

        }//fim do método Atualizar Endereço



        public string AtualizarCPF(int codigo, string cpf)
        {
            if (AcessarCodigo == codigo)
            {
                AcessarCPF = cpf;
                return "Dado Atualizado com Sucesso!";
            }
            else
            {
                return "Código digitado não é válido!";
            }

        }//fim do método atualizar cpf.



        public string AtualizarTelefone(int codigo, string telefone)
        {
            if (AcessarCodigo == codigo)
            {
                AcessarTelefone = telefone;
                return "Dado Atualizado com Sucesso!";
            }
            else
            {
                return "Código digitado não é válido!";
            }

        }//fim do método atualizar telefone




        public string AtualizarSexoBiologico(int codigo, string sexobiologico)
        {
            if (AcessarCodigo == codigo)
            {
                AcessarSexoBiologico = sexobiologico;
                return "E-mail atualizado com sucesso!";
            }
            else
            {
                return "Código informado não é válido!";
            }
        }//fim do método Atualizar sexo biologico



        public string AtualizarSalario(int codigo, string salario)
        {
            if (AcessarCodigo == codigo)
            {
                AcessarSalario = salario;
                return "E-mail atualizado com sucesso!";
            }
            else
            {
                return "Código informado não é válido!";
            }
        }//fim do método Atualizar Salario 



        public string AtualizarCargo(int codigo, string cargo)
        {
            if (AcessarCodigo == codigo)
            {
                AcessarCargo = cargo;
                return "Dado Atualizado com Sucesso!";
            }
            else
            {
                return "Código informado não é valido!";
            }
        }//Fim do método Atualizar Cargo





        //__________________________________________________________________________________________________________________________________________________


        public string Excluir(int codigo)
        {
            if (AcessarCodigo == codigo)
            {
                AcessarCodigo = 0;
                AcessarNome = "";
                AcessarEndereco = "";
                AcessarCPF = "";
                AcessarTelefone = "";
                AcessarSexoBiologico = "";
                AcessarSalario = "";
                AcessarCargo = "";
                
                return "Dados excluídos com sucesso!";
            }
            else
            {
                return "Código informado não é válido!";
            }
        }//fim do excluir

        //________________________________________________________________________________________________________________________________________________

    }
}
