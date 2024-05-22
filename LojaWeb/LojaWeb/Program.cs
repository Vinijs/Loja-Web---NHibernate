using LojaWeb.DAO;
using LojaWeb.Entidades;
using LojaWeb.Infra;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Transform;

//NHibernateHelper.GeraSchema();

// ======================= AULA 06 - 22/05/2024  =====================

ISession session = NHibernateHelper.AbreSession();

IQuery query = session.CreateQuery("select distinct c from Categoria c join fetch c.Produtos");

IList<Categoria> categorias = query.List<Categoria>();

foreach (var categoria in categorias)
{
    Console.WriteLine(categoria.Nome + " - " + categoria.Produtos.Count());
}

session.Close();

Console.Read();

public class ProdutosPorCategoria
{
    public Categoria Categoria { get; set; }
    public long NumeroDePedidos { get; set; }
}