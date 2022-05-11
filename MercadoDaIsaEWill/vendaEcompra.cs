using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoDaIsaEWill
{
    class vendaEcompra
    {
        private int codigo;
        private string quantidade;
        private string valortotal;
        

        //_______________________________________________________________________________________________________________________________________________________



        public vendaEcompra()
        {
            //Instanciando as variáveis

            AcessarCodigo = 0;
            AcessarQuantidade = "";
            AcessarValorTotal = "";
          

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
        }//fim do método de AcessarCodigo





        public string AcessarQuantidade
        {
            get
            {
                return quantidade;
            }
            set
            {
                this.quantidade = value;
            }
        }//fim do método de AcessarQuantidade




        public string AcessarValorTotal
        {
            get
            {
                return valortotal;
            }
            set
            {
                this.valortotal = value;
            }
        }//fim do AcessarValorTotal


 //_______________________________________________________________________________________________________________________________________________________




        public void CadastrarVenda(int codigo, string quantidade, string valortotal)
        {
            AcessarCodigo = codigo;
            AcessarQuantidade = quantidade;
            AcessarValorTotal = valortotal;
          

        }// fim do cadastrar.




        //_______________________________________________________________________________________________________________________________________________________

        public string Consultar(int codigo)
        {
            if (AcessarCodigo == codigo)
            {
                return "Código: " + AcessarCodigo +
                "\nQuantidade: " + AcessarQuantidade +
                "\nValor Total: " + AcessarValorTotal ;
            }

            else
            {
                return "Código Informado Não é Valido!";
            }



        }//fim do método consultar




        //_______________________________________________________________________________________________________________________________________________________


        public string AtualizarQuantidade(int codigo, string quantidade)
        {
            if (AcessarCodigo == codigo)
            {
                AcessarQuantidade = quantidade;
                return "Dado Atualizado com Sucesso!";
            }
            else
            {
                return "Código digitado não é válido!";
            }



        }//fim do método atualizar quantidade.





        public string AtualizarValorTotal(int codigo, string valortotal)
        {
            if (AcessarCodigo == codigo)
            {
                AcessarValorTotal = valortotal;
                return "Dado Atualizado com Sucesso!";
            }
            else
            {
                return "Código digitado não é válido!";
            }



        }//fim do método atualizar valor total


//__________________________________________________________________________________________________________________________________________________


        public string Excluir(int codigo)
        {
            if (AcessarCodigo == codigo)
            {
                AcessarCodigo = 0;
                AcessarQuantidade = "";
                AcessarValorTotal = "";
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
