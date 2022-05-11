using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoDaIsaEWill
{
    class produto
    {
        private int codigo;
        private string descricao;
        private string quantidade;
        private string unidadedemedida;
        private string valorunitario;
        private DateTime datadefabricacao;
        private DateTime datadevalidade;
        private string tipodeproduto;





        //_______________________________________________________________________________________________________________________________________________________





        public produto()
        {
            //Instanciando as variáveis





            AcessarCodigo = 0;
            AcessarDescricao = "";
            AcessarQuantidade = "";
            AcessarUnidadeDeMedida = "";
            AcessarValorUnitario = "";
            AcessarDataDeFabricacao = new DateTime();
            AcessarDataDeValidade = new DateTime();
            AcessarTipoDeProduto = "";








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







        public string AcessarDescricao
        {
            get
            {
                return descricao;
            }
            set
            {
                this.descricao = value;
            }
        }//fim do método de acesso de código







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
        }//fim do acessarQuantidade






        public string AcessarUnidadeDeMedida
        {
            get
            {
                return unidadedemedida;
            }
            set
            {
                this.unidadedemedida = value;
            }
        }//fim do AcessarUnidadeDemedida







        public string AcessarValorUnitario
        {
            get
            {
                return valorunitario;
            }
            set
            {
                this.valorunitario = value;
            }


        }//fim do AcessarValorUnitario







        public DateTime AcessarDataDeFabricacao
        {
            get
            {
                return datadefabricacao;
            }
            set
            {
                this.datadefabricacao = value;
            }

        }//fim do AcessarDatadeFabricacao







        public DateTime AcessarDataDeValidade
        {
            get
            {
                return datadevalidade;
            }
            set
            {
                this.datadevalidade = value;
            }





        }//fim do AcessarDataDeValidade







        public string AcessarTipoDeProduto
        {
            get
            {
                return tipodeproduto;
            }
            set
            {
                this.tipodeproduto = value;
            }





        }//fim do AcessarTipodeProduto






        //_______________________________________________________________________________________________________________________________________________________






        
        public void CadastrarProduto(int codigo, string descricao, string quantidade, string unidadedemedida, string valorunitario, DateTime datadefabricacao, DateTime datadevalidade, string tipodeproduto)
        {
            AcessarCodigo = codigo;
            AcessarDescricao = descricao;
            AcessarQuantidade = quantidade;
            AcessarUnidadeDeMedida = unidadedemedida;
            AcessarValorUnitario = valorunitario;
            AcessarDataDeFabricacao = datadefabricacao;
            AcessarDataDeValidade = datadevalidade;
            AcessarTipoDeProduto = tipodeproduto;

        }// fim do cadastrar.




        //_______________________________________________________________________________________________________________________________________________________



        public string Consultar(int codigo)
        {
            if (AcessarCodigo == codigo)
            {
                return "Código: " + AcessarCodigo +
                "\nDescrição: " + AcessarDescricao +
                "\nQuantidade:" + AcessarQuantidade +
                "\nUnidadeDeMedida " + AcessarUnidadeDeMedida +
                "\nValor Unitário: " + AcessarValorUnitario +
                "\nData de Fabricação " + AcessarDataDeFabricacao +
                "\nData de Validade:" + AcessarDataDeValidade +
                "\nTipo de Produto:" + AcessarTipoDeProduto;

            }

            else
            {
                return "Código Informado Não é Valido!";
            }





        }//fim do método consultar



        //_______________________________________________________________________________________________________________________________________________________




        public string AtualizarDescricao(int codigo, string descricao)
        {
            if (AcessarCodigo == codigo)
            {
                AcessarDescricao = descricao;
                return "Descricao Atualizado com Sucesso!";
            }
            else
            {
                return "Código digitado não é válido!";
            }

        }//fim do método AtualizarDescricao.




        public string AtualizarQuantidade(int codigo, string quantidade)
        {
            if (AcessarCodigo == codigo)
            {
                AcessarQuantidade = quantidade;
                return "quantidade Atualizado com Sucesso!";
            }
            else
            {
                return "Código digitado não é válido!";
            }


        }//fim do método AtualizarQuantidade.







        public string AtualizarUnidadeDeMedida(int codigo, string unidadedemedida)
        {
            if (AcessarCodigo == codigo)
            {
                AcessarUnidadeDeMedida = unidadedemedida;
                return "unidade Atualizado com Sucesso!";
            }
            else
            {
                return "Código digitado não é válido!";
            }


        }//fim do método  AtualizarUnidadeDeMedida







        public string AtualizarValorUnitario(int codigo, string valorunitario)
        {
            if (AcessarCodigo == codigo)
            {
                AcessarValorUnitario = valorunitario;
                return "valor unitario atualizado com sucesso!";
            }
            else
            {
                return "Código informado não é válido!";
            }


        }//fim do método AtualizarValorUnitario




        public string AtualizarDataDeFabricacao(int codigo, DateTime datadefabricacao)
        {
            if (AcessarCodigo == codigo)
            {
                AcessarDataDeFabricacao = datadefabricacao;
                return "data atualizado com sucesso!";
            }
            else
            {
                return "Código informado não é válido!";
            }
        }//fim do método AtualizarDataDeFabricacao







        public string AtualizarDataDeValidade(int codigo, DateTime datadevalidade)
        {
            if (AcessarCodigo == codigo)
            {
                AcessarDataDeValidade = datadevalidade;
                return "data atualizado com sucesso!";
            }
            else
            {
                return "Código informado não é válido!";
            }
        }//fim do método AtualizarDataDeValidade







        public string AtualizarTipoDeProduto(int codigo, string tipodeproduto)
        {
            if (AcessarCodigo == codigo)
            {
                AcessarTipoDeProduto = tipodeproduto;
                return "Dado Atualizado com Sucesso!";
            }
            else
            {
                return "Código informado não é valido!";
            }
        }//Fim do método AtualizarTipoDeProduto




        //__________________________________________________________________________________________________________________________________________________




        public string Excluir(int codigo)
        {
            if (AcessarCodigo == codigo)
            {

                AcessarCodigo = 0;
                AcessarDescricao = "";
                AcessarQuantidade = "";
                AcessarUnidadeDeMedida = "";
                AcessarValorUnitario = "";
                AcessarDataDeFabricacao = new DateTime();
                AcessarDataDeValidade = new DateTime();
                AcessarTipoDeProduto = "";
                return "Dados excluídos com sucesso!";
            }

            else
            {
                return "Código informado não é válido!";
            }

        }//fim do excluir



 //________________________________________________________________________________________________________________________________________________
    
    }// fim da class

}// fim do projeto
