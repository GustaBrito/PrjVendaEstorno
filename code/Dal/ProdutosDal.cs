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
using System.Data;
using System.Drawing;
using System.Security.Cryptography.Pkcs;
using System.Data.SqlClient;

namespace VendaEstorno.code.Dal
{
    public class ProdutosDal
    {
        private readonly string strConn = "Data Source=C:\\Users\\Gustavo.abrito\\Desktop\\PrjVendaEstorno\\Database\\DBPRODUTOS;Version=3;";
        public string GetConnectionString()
        {
            return strConn;
        }
        /////////////////////////////////////// DAL DO PRODUTO ///////////////////////////////////////////////////////////////////////////////////////////////

        private string BuildSearchQuery(string categoria, string busca)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("SELECT * FROM TBLPRODUTOS");

            if (!string.IsNullOrEmpty(categoria) && !string.IsNullOrEmpty(busca))
            {
                sql.Append(" WHERE ");

                switch (categoria)
                {
                    case "CODIGO DO PRODUTO":
                        sql.Append("CODPRODUTO = @busca");
                        break;
                    case "QUANTIDADE EM ESTOQUE":
                        sql.Append("QTDESTOQUE = @busca");
                        break;
                    case "PRECO":
                        sql.Append("PRECO = @busca");
                        break;
                    case "CODIGO DA MARCA":
                        sql.Append("CODMARCA = @busca");
                        break;
                    default:
                        throw new ArgumentException("Categoria inválida.");
                }
            }

            return sql.ToString();
        }
        public DataTable ConsultarProdutosCmb(string categoria, string busca)
        {
            DataTable dt = new DataTable();
            try
            {
                // Defina a consulta SQL dependendo da categoria e do valor de busca
                string query = BuildSearchQuery(categoria, busca);

                using (SQLiteConnection cn = new SQLiteConnection(strConn))
                {
                    cn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(query, cn))
                    {
                        // Adicione parâmetros se necessário
                        if (categoria != null && busca != null)
                        {
                            cmd.Parameters.AddWithValue("@categoria", categoria);
                            cmd.Parameters.AddWithValue("@busca", busca);
                        }

                        using (var adapter = new SQLiteDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar produtos.", ex);
            }
            return dt;
        }

        public DataTable GetProdutos()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SQLiteConnection cn = new SQLiteConnection(strConn))

                {
                    cn.Open();

                    StringBuilder sql = new StringBuilder();

                    sql.Append("SELECT p.codproduto, p.descricao, p.qtdestoque, p.preco, ");
                    sql.Append("CAST(p.datavencto AS TEXT) AS datavencto, p.codmarca, p.tiporegistro, ");
                    sql.Append("m.descricao AS MARCA ");
                    sql.Append("FROM tblprodutos p ");
                    sql.Append("LEFT JOIN tblmarca m ON p.codmarca = m.codmarca");


                    using (SQLiteCommand cmd = new SQLiteCommand(cn))
                    {
                        SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = sql.ToString();
                        da.Fill(dt);
                    }
                }

            }
            catch (SQLiteException sqlEx)
            {

                throw new Exception("Erro ao consultar dados no banco de dados.", sqlEx);
            }


            return dt;

        }

        public int DeletarProduto(int codProduto)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("DELETE FROM TBLPRODUTOS ");
                sql.Append("WHERE CODPRODUTO = @CODPRODUTO;");

                using (SQLiteConnection cn = new SQLiteConnection(strConn))
                {
                    cn.Open();

                    using (SQLiteCommand cmd = new SQLiteCommand())
                    {
                        cmd.Connection = cn;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = sql.ToString();

                        cmd.Parameters.AddWithValue("@CODPRODUTO", codProduto);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir dados: " + ex.Message);
                //MessageBox.Show($"Erro ao excluir dados: {ex.Message}"); // ibterpolacao
                return -1;
            }
        }

        public DataTable GetMarcas()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SQLiteConnection cn = new SQLiteConnection(strConn))

                {
                    cn.Open();

                    StringBuilder sql = new StringBuilder();

                    sql.Append("SELECT CODMARCA, DESCRICAO FROM TBLMARCA");

                    using (SQLiteCommand cmd = new SQLiteCommand(cn))
                    {
                        SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = sql.ToString();
                        da.Fill(dt);
                    }
                }
            }
            catch (SQLiteException sqlEx)
            {
                throw new Exception("Erro ao carregar marcas.", sqlEx);
            }
            return dt;
        }

        public DataTable GetProdutoByCodigo(string codProduto)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SQLiteConnection cn = new SQLiteConnection(strConn))
                {
                    cn.Open();

                    // Corrija a construção da SQL
                    StringBuilder sql = new StringBuilder();
                    sql.Append("SELECT CODPRODUTO, DESCRICAO, QTDESTOQUE, PRECO, DATAVENCTO, CODMARCA, TIPOREGISTRO ");
                    sql.Append("FROM TBLPRODUTOS ");
                    sql.Append("WHERE CODPRODUTO = @codProduto");

                    using (SQLiteCommand cmd = new SQLiteCommand(sql.ToString(), cn))
                    {
                        // Adicione o parâmetro ao comando
                        cmd.Parameters.AddWithValue("@codProduto", codProduto);

                        using (SQLiteDataAdapter da = new SQLiteDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (SQLiteException sqlEx)
            {
                throw new Exception("Erro ao consultar dados no banco de dados. Verifique a integridade dos dados e a estrutura da tabela.", sqlEx);
            }
            return dt;
        }

        public int InsertProduto(string descricao, int qtdEstoque, float preco, DateTime dataVencto, int codMarca, string tipoRegistro)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("INSERT INTO TBLPRODUTOS (DESCRICAO, QTDESTOQUE, PRECO, DATAVENCTO, CODMARCA, TIPOREGISTRO) ");
                sql.Append("VALUES (@descricao, @qtdEstoque, @preco, @dataVencto, @codMarca, @tipoRegistro); ");
                sql.Append("SELECT last_insert_rowid();");

                using (SQLiteConnection cn = new SQLiteConnection(strConn))
                {
                    cn.Open();

                    using (SQLiteCommand cmd = new SQLiteCommand())
                    {
                        cmd.Connection = cn;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = sql.ToString();

                        // Adiciona os parâmetros
                        cmd.Parameters.AddWithValue("@descricao", descricao);
                        cmd.Parameters.AddWithValue("@qtdEstoque", qtdEstoque);
                        cmd.Parameters.AddWithValue("@preco", preco);
                        cmd.Parameters.AddWithValue("@dataVencto", dataVencto.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@codMarca", codMarca);
                        cmd.Parameters.AddWithValue("@tipoRegistro", tipoRegistro);

                        // Retorna o último ID inserido
                        int CODPRODUTO = Convert.ToInt32(cmd.ExecuteNonQuery());
                        return CODPRODUTO;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao gravar dados: " + ex.Message);
            }
        }


        public int UpdateProduto(int codProduto, string descricao, int qtdEstoque, float preco, DateTime dataVencto, int codMarca, string tipoRegistro)
        {
            try
            {
                using (SQLiteConnection cn = new SQLiteConnection(GetConnectionString()))
                {
                    cn.Open();

                    StringBuilder sql = new StringBuilder();
                    sql.Append("UPDATE TBLPRODUTOS SET ");
                    sql.Append("DESCRICAO = @descricao, ");
                    sql.Append("QTDESTOQUE = @qtdEstoque, ");
                    sql.Append("PRECO = @preco, ");
                    sql.Append("DATAVENCTO = @dataVencto, ");
                    sql.Append("CODMARCA = @codMarca, ");
                    sql.Append("TIPOREGISTRO = @tipoRegistro ");
                    sql.Append("WHERE CODPRODUTO = @codProduto");

                    using (SQLiteCommand cmd = new SQLiteCommand(sql.ToString(), cn))
                    {
                        cmd.Parameters.AddWithValue("@descricao", descricao);
                        cmd.Parameters.AddWithValue("@qtdEstoque", qtdEstoque);
                        cmd.Parameters.AddWithValue("@preco", preco);
                        cmd.Parameters.AddWithValue("@dataVencto", dataVencto.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@codMarca", codMarca);
                        cmd.Parameters.AddWithValue("@tipoRegistro", tipoRegistro);
                        cmd.Parameters.AddWithValue("@codProduto", codProduto);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar dados: " + ex.Message);
                return -1;
            }
        }

        public bool DescricaoDuplicada(string descricao)
        {
            StringBuilder sql = new StringBuilder();

            try
            {
                sql.Append("SELECT DESCRICAO FROM TBLPRODUTOS ");
                sql.Append("WHERE DESCRICAO = @descricao");

                using (SQLiteConnection cn = new SQLiteConnection(GetConnectionString()))
                {
                    cn.Open();

                    using (SQLiteCommand cmd = new SQLiteCommand(sql.ToString(), cn))
                    {
                        cmd.Parameters.AddWithValue("@descricao", descricao);

                        string resultado = Convert.ToString(cmd.ExecuteScalar());

                        if (resultado.Trim() == string.Empty)
                            return false;

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao verificar descrição duplicada.", ex);
            }
        }
        /////////////////////////////////////// DAL DO LOGIN ///////////////////////////////////////////////////////////////////////////////////////////////

        public bool ValidarCredenciais(string usuario, string senha)
        {
            StringBuilder sql = new StringBuilder();

            try
            {
                sql.Append("SELECT USUARIO FROM TBLUSUARIOS ");
                sql.Append("WHERE USUARIO = @usuario AND SENHA = @senha");

                using (SQLiteConnection cn = new SQLiteConnection(GetConnectionString()))
                {
                    {
                        cn.Open();

                        using (SQLiteCommand cmd = new SQLiteCommand(sql.ToString(), cn))
                        {
                            cmd.Parameters.AddWithValue("@usuario", usuario);
                            cmd.Parameters.AddWithValue("@senha", senha);

                            string resultado = Convert.ToString(cmd.ExecuteScalar());

                            if (resultado.Trim() == string.Empty)
                                return false;

                            return true;
                        }
                        ;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao validar credenciais.", ex);
            }
        }
        /////////////////////////////////////// DAL DA MARCA ///////////////////////////////////////////////////////////////////////////////////////////////

        public int DeletarMarca(string codMarca)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("DELETE FROM TBLMARCA ");
                sql.Append("WHERE CODMARCA = @CODMARCA;");

                using (SQLiteConnection cn = new SQLiteConnection(strConn))
                {
                    cn.Open();

                    using (SQLiteCommand cmd = new SQLiteCommand())
                    {
                        cmd.Connection = cn;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = sql.ToString();

                        cmd.Parameters.AddWithValue("@CODMARCA", codMarca);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir dados: " + ex.Message);
                //MessageBox.Show($"Erro ao excluir dados: {ex.Message}"); // ibterpolacao
                return -1;
            }
        }

        public DataTable ObterMarcaPorCodigo(int codMarca)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SQLiteConnection cn = new SQLiteConnection(strConn))
                {
                    cn.Open();

                    // Corrija a construção da SQL
                    StringBuilder sql = new StringBuilder();
                    sql.Append("SELECT CODMARCA, DESCRICAO ");
                    sql.Append("FROM TBLMARCA ");
                    sql.Append("WHERE CODMARCA = @CODMARCA");

                    using (SQLiteCommand cmd = new SQLiteCommand(sql.ToString(), cn))
                    {
                        // Adicione o parâmetro ao comando
                        cmd.Parameters.AddWithValue("@CODMARCA", codMarca);

                        using (SQLiteDataAdapter da = new SQLiteDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (SQLiteException sqlEx)
            {
                throw new Exception("Erro ao consultar dados no banco de dados.", sqlEx);
            }
            return dt;
        }

        public int AtualizarMarca(int codMarca, string descricao)
        {
            try
            {
                using (SQLiteConnection cn = new SQLiteConnection(GetConnectionString()))
                {
                    cn.Open();

                    StringBuilder sql = new StringBuilder();
                    sql.Append("UPDATE TBLMARCA SET ");
                    sql.Append("DESCRICAO = @descricao ");
                    sql.Append("WHERE CODMARCA = @codMarca");

                    using (SQLiteCommand cmd = new SQLiteCommand(sql.ToString(), cn))
                    {
                        cmd.Parameters.AddWithValue("@descricao", descricao);
                        cmd.Parameters.AddWithValue("@codMarca", codMarca); // Corrigido para int

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar dados: " + ex.Message);
                return -1;
            }
        }

        public int InserirMarca(string descricao)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("INSERT INTO TBLMARCA (DESCRICAO) ");
                sql.Append("VALUES (@descricao); ");
                sql.Append("SELECT last_insert_rowid();");

                using (SQLiteConnection cn = new SQLiteConnection(strConn))
                {
                    cn.Open();

                    using (SQLiteCommand cmd = new SQLiteCommand())
                    {
                        cmd.Connection = cn;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = sql.ToString();

                        // Adiciona os parâmetros
                        cmd.Parameters.AddWithValue("@descricao", descricao);

                        // Retorna o último ID inserido
                        int CODMARCA = Convert.ToInt32(cmd.ExecuteNonQuery());
                        return CODMARCA;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao gravar dados: " + ex.Message);
            }
        }

        public bool DescricaoDuplicadaMarca(string descricao)
        {
            StringBuilder sql = new StringBuilder();

            try
            {
                sql.Append("SELECT DESCRICAO FROM TBLMARCA ");
                sql.Append("WHERE DESCRICAO = @descricao");

                using (SQLiteConnection cn = new SQLiteConnection(GetConnectionString()))
                {
                    cn.Open();

                    using (SQLiteCommand cmd = new SQLiteCommand(sql.ToString(), cn))
                    {
                        cmd.Parameters.AddWithValue("@descricao", descricao);

                        string resultado = Convert.ToString(cmd.ExecuteScalar());

                        if (resultado.Trim() == string.Empty)
                            return false;

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao verificar descrição duplicada.", ex);
            }
        }
        /////////////////////////////////////// DAL DA IMPORTACAO ///////////////////////////////////////////////////////////////////////////////////////////////

        public int ImportarProduto(int codProduto, string descricao)
        {
            try
            {

                if (ProdutoExiste(codProduto))
                {
                    return 0;
                }

                StringBuilder sql = new StringBuilder();
                sql.Append("INSERT INTO TBLPRODUTOS (CodProduto, DESCRICAO) ");
                sql.Append("VALUES (@CodProduto, @descricao); ");

                using (SQLiteConnection cn = new SQLiteConnection(strConn))
                {
                    cn.Open();

                    using (SQLiteCommand cmd = new SQLiteCommand())
                    {
                        cmd.Connection = cn;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = sql.ToString();

                        // Adiciona os parâmetros
                        cmd.Parameters.AddWithValue("@descricao", descricao);
                        cmd.Parameters.AddWithValue("@CodProduto", codProduto);

                        int linhasAfetadas = cmd.ExecuteNonQuery();
                        return linhasAfetadas;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao gravar dados: " + ex.Message);
            }
        }

        public bool ProdutoExiste(int codProduto)
        {
            try
            {
                string sql = "SELECT COUNT(1) FROM TBLPRODUTOS WHERE CodProduto = @CodProduto;";

                using (SQLiteConnection cn = new SQLiteConnection(strConn))
                {
                    cn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@CodProduto", codProduto);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                }
            }
            catch (SQLiteException sqliteEx)
            {
                throw new Exception("Erro ao verificar existência do produto no banco de dados: " + sqliteEx.Message);
            }
            catch (Exception ex)
            {
                // Captura outros erros
                throw new Exception("Erro ao verificar existência do produto: " + ex.Message);
            }
        }
        /////////////////////////////////////// DAL DA VENDA ///////////////////////////////////////////////////////////////////////////////////////////////

        public void ProcessarVenda(int codVenda, DateTime data, List<VendaItem> itens)
        {
            using (var transaction = BeginTransaction())
            {
                try
                {
                    InsertVenda(transaction, codVenda, data);
                    foreach (var item in itens)
                    {
                        InsertProdutoItens(transaction, item.CodProduto, codVenda, item.Qtdade, item.Valor);
                        AtualizaEstoque(transaction, item.CodProduto, (int)item.Qtdade);
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception("Erro ao processar venda: " + ex.Message, ex);
                }
            }
        }

        public int GerarCodVenda()
        {
            int lastCodVenda = 0;

            using (SQLiteConnection conn = new SQLiteConnection(strConn))
            {
                conn.Open();
                string query = "SELECT MAX(CODVENDA) FROM TBLVENDA";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        lastCodVenda = Convert.ToInt32(result);
                    }
                }
            }

            return lastCodVenda + 1;
        }

        public int InsertVenda(SQLiteTransaction transaction, int codVenda, DateTime datavenda)
        {
            if (transaction == null) throw new ArgumentNullException(nameof(transaction));

            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("INSERT INTO TBLVENDA (CODVENDA, DATAVENDA) ");
                sql.Append("VALUES (@CODVENDA, @DATAVENDA); ");

                using (SQLiteCommand cmd = new SQLiteCommand(sql.ToString(), transaction.Connection as SQLiteConnection))
                {
                    cmd.Transaction = transaction;
                    cmd.Parameters.AddWithValue("@CODVENDA", codVenda);
                    cmd.Parameters.AddWithValue("@DATAVENDA", datavenda);
                    cmd.ExecuteNonQuery();
                    return codVenda;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao gravar venda: " + ex.Message, ex);
            }
        }

        public int InsertProdutoItens(SQLiteTransaction transaction, int codProduto, int codVenda, float qtdade, float valor)
        {
            if (transaction == null) throw new ArgumentNullException(nameof(transaction));

            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("INSERT INTO TBLITENS (CODPRODUTO, CODVENDA, QTDADE, VALOR) ");
                sql.Append("VALUES (@CODPRODUTO, @CODVENDA, @QTDADE, @VALOR); ");
                sql.Append("SELECT last_insert_rowid();");

                using (SQLiteCommand cmd = new SQLiteCommand(sql.ToString(), transaction.Connection as SQLiteConnection))
                {
                    cmd.Transaction = transaction;

                    cmd.Parameters.AddWithValue("@CODPRODUTO", codProduto);
                    cmd.Parameters.AddWithValue("@CODVENDA", codVenda);
                    cmd.Parameters.AddWithValue("@QTDADE", qtdade);
                    cmd.Parameters.AddWithValue("@VALOR", valor);

                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao gravar dados: " + ex.Message, ex);
            }
        }

        public bool AtualizaEstoque(SQLiteTransaction transaction, int codProduto, int qtd)
        {
            if (transaction == null) throw new ArgumentNullException(nameof(transaction));

            try
            {
                string query = "UPDATE TBLPRODUTOS SET QTDESTOQUE = QTDESTOQUE - @QTDADE WHERE CODPRODUTO = @codProduto AND QTDESTOQUE >= @QTDADE";

                using (SQLiteCommand cmd = new SQLiteCommand(query, transaction.Connection as SQLiteConnection))
                {
                    cmd.Transaction = transaction;
                    cmd.Parameters.AddWithValue("@QTDADE", qtd);
                    cmd.Parameters.AddWithValue("@codProduto", codProduto);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar estoque: " + ex.Message, ex);
            }
        }

        public int GetEstoqueProduto(int codProduto)
        {
            using (SQLiteConnection conn = new SQLiteConnection(strConn))
            {
                conn.Open();
                string query = "SELECT QTDESTOQUE FROM TBLPRODUTOS WHERE CODPRODUTO = @codProduto";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@codProduto", codProduto);
                    object result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : 0;
                }
            }
        }
        public Venda ProdPorCodVenda(int codProduto)
        {
            using (SQLiteConnection conn = new SQLiteConnection(strConn))
            {
                conn.Open();
                string query = "SELECT QTDESTOQUE, PRECO FROM TBLPRODUTOS WHERE CODPRODUTO = @codProduto";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@codProduto", codProduto);

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var qtdEstoqueValue = reader.GetValue(0);
                            var precoValue = reader.GetValue(1);
                            Console.WriteLine($"QTDESTOQUE: {qtdEstoqueValue} (Type: {qtdEstoqueValue.GetType()})");
                            Console.WriteLine($"PRECO: {precoValue} (Type: {precoValue.GetType()})");

                            return new Venda
                            {
                                QtdEstoque = reader.IsDBNull(0) ? 0 : Convert.ToInt32(qtdEstoqueValue),
                                Preco = reader.IsDBNull(1) ? 0.0f : Convert.ToSingle(precoValue)
                            };
                        }
                    }
                }
            }
            return null;
        }

        public SQLiteTransaction BeginTransaction()
        {
            SQLiteConnection cn = new SQLiteConnection(strConn);
            cn.Open();
            return cn.BeginTransaction();
        }
        /////////////////////////////////////// DAL DO ESTORNO ///////////////////////////////////////////////////////////////////////////////////////////////
        public DataTable GetItensPorCodigoVenda(int codVenda)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SQLiteConnection cn = new SQLiteConnection(strConn))
                {
                    cn.Open();
                    StringBuilder sql = new StringBuilder();

                    sql.Append("SELECT i.codvenda, i.codproduto, p.descricao, i.qtdade, i.valor ");
                    sql.Append("FROM tblitens i ");
                    sql.Append("LEFT JOIN tblprodutos p ON i.codproduto = p.codproduto ");
                    sql.Append("WHERE i.codvenda = @codVenda");

                    using (SQLiteCommand cmd = new SQLiteCommand(sql.ToString(), cn))
                    {
                        cmd.Parameters.Add("@codVenda", DbType.Int32).Value = codVenda;

                        using (SQLiteDataAdapter da = new SQLiteDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar itens da venda: " + ex.Message);
            }

            return dt;
        }
        public void AtualizaQuantidadeProduto(int codProduto, int qtdade)
        {
            try
            {
                using (SQLiteConnection cn = new SQLiteConnection(strConn))
                {
                    cn.Open();
                    StringBuilder sql = new StringBuilder();

                    sql.Append("UPDATE tblprodutos ");
                    sql.Append("SET qtdestoque = qtdestoque + @qtdade ");
                    sql.Append("WHERE codproduto = @codProduto");

                    using (SQLiteCommand cmd = new SQLiteCommand(sql.ToString(), cn))
                    {
                        cmd.Parameters.Add("@qtdade", DbType.Int32).Value = qtdade;
                        cmd.Parameters.Add("@codProduto", DbType.Int32).Value = codProduto;
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar a quantidade do produto: " + ex.Message);
            }
        }

        public void DeletaVendaEstorno(int codVenda)
        {
            try
            {
                using (SQLiteConnection cn = new SQLiteConnection(strConn))
                {
                    cn.Open();

                    StringBuilder sqlItens = new StringBuilder();
                    sqlItens.Append("DELETE FROM tblitens WHERE codvenda = @codVenda");

                    using (SQLiteCommand cmd = new SQLiteCommand(sqlItens.ToString(), cn))
                    {
                        cmd.Parameters.Add("@codVenda", DbType.Int32).Value = codVenda;
                        cmd.ExecuteNonQuery();
                    }

                    StringBuilder sqlVenda = new StringBuilder();
                    sqlVenda.Append("DELETE FROM tblvenda WHERE codvenda = @codVenda");

                    using (SQLiteCommand cmd = new SQLiteCommand(sqlVenda.ToString(), cn))
                    {
                        cmd.Parameters.Add("@codVenda", DbType.Int32).Value = codVenda;
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao deletar a venda e os itens: " + ex.Message);
            }
        }
        public DataTable GetVendasEntreDatas(DateTime dataInicio, DateTime dataFim)
        {
            DataTable vendas = new DataTable();
            try
            {
                using (SQLiteConnection cn = new SQLiteConnection(strConn))
                {
                    cn.Open();
                    StringBuilder sql = new StringBuilder();
                    sql.Append("SELECT codvenda, dataVenda FROM tblvenda ");
                    sql.Append("WHERE date(DataVenda) >= date(@DataInicio) AND date(DataVenda) <= date(@DataFim)");

                    using (SQLiteCommand cmd = new SQLiteCommand(sql.ToString(), cn))
                    {
                        cmd.Parameters.AddWithValue("@DataInicio", dataInicio.Date);
                        cmd.Parameters.AddWithValue("@DataFim", dataFim.Date);

                        using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                        {
                            adapter.Fill(vendas);
                        }
                    }
                }
            }
            catch (SQLiteException sqliteEx)
            {
                throw new Exception("Erro ao buscar as vendas: " + sqliteEx.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro inesperado: " + ex.Message);
            }

            return vendas;
        }
    }
}

