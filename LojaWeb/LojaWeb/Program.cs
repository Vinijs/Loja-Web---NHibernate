using LojaWeb.DAO;
using LojaWeb.Entidades;
using LojaWeb.Infra;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Transform;

//NHibernateHelper.GeraSchema();

// ======================= AULA 05 - 21/05/2024  =====================

ISession session = NHibernateHelper.AbreSession();

String hql = "select p.Categoria as Categoria, count(p) as NumeroDePedidos from Produto p group by p.Categoria";

IQuery query = session.CreateQuery(hql);

query.SetResultTransformer(Transformers.AliasToBean<ProdutosPorCategoria>());


// IList<Object[]> resultados = query.List<object[]>();

IList<ProdutosPorCategoria> relatorio = query.List<ProdutosPorCategoria>();

//foreach (Object[] resultado in resultados)
//{
//    ProdutosPorCategoria p = new ProdutosPorCategoria();
//    p.Categoria = (Categoria)resultado[0];
//    p.NumeroDePedidos = (long)resultado[1];
//    relatorio.Add(p);
//}

session.Close();

Console.Read();

public class ProdutosPorCategoria
{
    public Categoria Categoria { get; set; }
    public long NumeroDePedidos { get; set; }
}