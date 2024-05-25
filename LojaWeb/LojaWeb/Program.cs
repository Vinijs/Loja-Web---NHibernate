using LojaWeb.DAO;
using LojaWeb.Entidades;
using LojaWeb.Infra;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Transform;

//NHibernateHelper.GeraSchema();

// ======================= AULA 08 - 24/05/2024  =====================

ISession session = NHibernateHelper.AbreSession();

ITransaction transacao = session.BeginTransaction();
 Venda venda = new Venda();
Usuario cliente = session.Get<Usuario>(1);
venda.Cliente = cliente;

Produto p1 = session.Get<Produto>(1);
Produto p2 = session.Get<Produto>(2);

venda.Produtos.Add(p1);
venda.Produtos.Add(p2);

session.Save(venda);

transacao.Commit();

session.Close();

Console.Read();