using LojaWeb.DAO;
using LojaWeb.Entidades;
using LojaWeb.Infra;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Transform;

//NHibernateHelper.GeraSchema();

// ======================= AULA 07 - 23/05/2024  =====================

ISession session = NHibernateHelper.AbreSession();

ProdutoDAO produtoDAO = new ProdutoDAO(session);

IList<Produto> produtos = produtoDAO.BuscaPorNomePrecoMinimoECategoria("", 20, "");


foreach (Produto produto in produtos)
{
    Console.WriteLine("Nome: " + produto.Nome
                               + "\nPreco: " + produto.Preco.ToString()
                               + "\nCategoria: " + produto.Categoria.Nome
                               + "\n"
                               );
}

session.Close();

Console.Read();