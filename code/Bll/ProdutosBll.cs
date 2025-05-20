using VendaEstorno.code.Dal;
using System.Data;

namespace VendaEstorno.code.Bll
{
    public class ProdutosBll
    {
        ProdutosDal dal = new ProdutosDal();
        public DataTable GetProdutos()
        {
            return dal.GetProdutos();
        }
    }
    public class MarcasBll
    {
        private readonly ProdutosDal _marcasDal = new ProdutosDal();

        public DataTable ObterMarcas(string descricao = "")
        {
            return _marcasDal.GetMarcas();
        }

        public void ExcluirMarca(string codMarca)
        {
            _marcasDal.DeletarMarca(codMarca);
        }

        public DataTable ObterMarcaPorCodigo(int codMarca)
        {
            return _marcasDal.ObterMarcaPorCodigo(codMarca);
        }

        // Ajustado para passar int ao invés de string para codMarca
        public void AtualizarMarca(int codMarca, string descricao)
        {
            _marcasDal.AtualizarMarca(codMarca, descricao);
        }

        public int InserirMarca(string descricao)
        {
            return _marcasDal.InserirMarca(descricao);
        }

        public bool DescricaoDuplicada(string descricao)
        {
            return _marcasDal.DescricaoDuplicadaMarca(descricao);
        }
    }
}