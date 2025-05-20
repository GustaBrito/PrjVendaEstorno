using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendaEstorno.code.Dto;
using VendaEstorno.code.Dal;
using VendaEstorno.code.Bll;
using System.Data.SQLite;
using System.IO;

namespace VendaEstorno.code.Dto
{
    public class Produto
    {
        public string CodProduto { get; set; } 
        public string Descricao { get; set; } 
        public int QtdEstoque { get; set; }  
        public decimal Preco { get; set; } 
        public DateTime DataVencto { get; set; } 
        public string CodMarca { get; set; }
        public string TipoRegistro { get; set; } // "M" para Manual, "I" para Importado
    }
    public class Venda
    {
        public int QtdEstoque { get; set; }
        public float Preco { get; set; }
    }
    public class VendaItem
    {
        public int CodProduto { get; set; }
        public float Qtdade { get; set; }
        public float Valor { get; set; }
    }
}
