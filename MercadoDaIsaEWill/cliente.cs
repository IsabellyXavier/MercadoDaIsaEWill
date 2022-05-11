using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoDaIsaEWill
{
    class cliente
    {
        private int codigo;
        private string nome;
        private string cpf;
        private string telefone;
        private string endereco;
        private string sexobiologico;
        private string email;
        private string quantidadedecompras;
        private string valortotalgasto;

//_______________________________________________________________________________________________________________________________________________________
      

        public cliente()
        {
            //Instanciando as variáveis

            AcessarCodigo = 0;
            AcessarNome = "";
            AcessarCPF = "";
            AcessarTelefone = "";
            AcessarEndereco = "";
            AcessarSexoBiologico = "";
            AcessarEmail = "";
            AcessarQuantidadeDeCompras = "";
            AcessarValorTotalGasto = "";




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
        }//fim do método de acesso de código



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



        public string AcessarEmail
        {
            get
            {
                return email;
            }
            set
            {
                this.email = value;
            }

        }//fim do acessarEmail



        public string AcessarQuantidadeDeCompras
        {
            get
            {
                return quantidadedecompras;
            }
            set
            {
                this.quantidadedecompras = value;
            }

        }//fim do acessarQuantidadeDeCompras



        public string AcessarValorTotalGasto
        {
            get
            {
                return valortotalgasto;
            }
            set
            {
                this.valortotalgasto = value;
            }

        }//fim do acessarValorTotalGasto


//_______________________________________________________________________________________________________________________________________________________


        public void CadastrarCliente(int codigo, string nome, string cpf, string telefone, string endereco, string sexobiologico, string email, string quantidadecompras, string valortotalgasto)
        {
            AcessarCodigo = codigo;
            AcessarNome = nome;
            AcessarCPF = cpf;
            AcessarTelefone = telefone;
            AcessarEndereco = endereco;
            AcessarSexoBiologico = sexobiologico; 
            AcessarEmail = email;
            AcessarQuantidadeDeCompras = quantidadecompras;
            AcessarValorTotalGasto = valortotalgasto;

        }// fim do cadastrar.

       
//_______________________________________________________________________________________________________________________________________________________             
       
        public string Consultar(int codigo)
        {
            if (AcessarCodigo == codigo)
            {
                return "Código: " + AcessarCodigo +
                "\nNome Completo: " + AcessarNome +
                "\nCPF:" + AcessarCPF +
                "\nTelefone: " + AcessarTelefone +
                "\nEndereço: " + AcessarEndereco +
                "\nSexo Biológico: " + AcessarSexoBiologico +
                "\nEmail:" + AcessarEmail +
                "\nQuantidade De Compras:" + AcessarQuantidadeDeCompras +
                "\nValor Total Gasto: " + AcessarValorTotalGasto;
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



        public string AtualizarEmail(int codigo, string email)
        {
            if (AcessarCodigo == codigo)
            {
                AcessarEmail = email;
                return "E-mail atualizado com sucesso!";
            }
            else
            {
                return "Código informado não é válido!";
            }
        }//fim do método Atualizar email



        public string AtualizarQuantidadeDeCompras(int codigo, string quantidadedecompras)
        {
            if (AcessarCodigo == codigo)
            {
                AcessarQuantidadeDeCompras = quantidadedecompras;
                return "Dado Atualizado com Sucesso!";
            }
            else
            {
                return "Código informado não é valido!";
            }
        }//Fim do método atualizarQuantidadeDeCompras



        public string AtualizarValorTotalGasto(int codigo, string valortotalgasto)
        {
            if (AcessarCodigo == codigo)
            {
                AcessarValorTotalGasto = valortotalgasto;
                return "Dado Atualizado com Sucesso!";
            }
            else
            {
                return "Código informado não é valido!";
            }
        }//Fim do método atualizarValorTotalGasto


//__________________________________________________________________________________________________________________________________________________
       
        
        public string Excluir(int codigo)
        {
            if (AcessarCodigo == codigo)
            {
                AcessarCodigo = 0;
                AcessarNome = "";
                AcessarCPF = "";
                AcessarTelefone = "";
                AcessarEndereco = "";
                AcessarSexoBiologico = "";
                AcessarEmail = "";
                AcessarQuantidadeDeCompras = "";
                AcessarValorTotalGasto = "";
                return "Dados excluídos com sucesso!";
            }
            else
            {
                return "Código informado não é válido!";
            }
        }//fim do excluir

//________________________________________________________________________________________________________________________________________________


    }// fim da ClassCliente
}// Fim do projeto
