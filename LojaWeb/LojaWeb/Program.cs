using LojaWeb.DAO;
using LojaWeb.Entidades;
using LojaWeb.Infra;
using NHibernate;
using NHibernate.Cfg;

// ======================= AULA 01 - 15/05/2024 ======================

//Configuration cfg = NHibernateHelper.RecuperaConfiguracao();

//ISessionFactory sessionFactory = cfg.BuildSessionFactory();

//ISession session = sessionFactory.OpenSession();

//Usuario usuario = new Usuario();

//usuario.Nome = "Vinicius";

//ITransaction transaction = session.BeginTransaction();

//session.Save(usuario);

//transaction.Commit();

//session.Close();
// ===================================================================

// ======================= AULA 02 - 16/05/2024  =====================

//ISession session = NHibernateHelper.AbreSession();

//UsuarioDAO usuarioDAO = new UsuarioDAO(session);

//Usuario usuario = new Usuario();

//usuario.Nome = "Natalia";

//usuarioDAO.Adiciona(usuario);

//session.Close();
// ===================================================================

// ======================= AULA 03 - 17/05/2024  =====================

//NHibernateHelper.GeraSchema();

//Categoria umaCategoria = new Categoria();
//umaCategoria.Nome = "Nova Categoria";

//Produto produto = new Produto();

//produto.Nome = "Calça";
//produto.Preco = 20;



//produto.Categoria = umaCategoria;

//ISession session = NHibernateHelper.AbreSession();

//ITransaction transaction = session.BeginTransaction();

//session.Save(umaCategoria);

//session.Save(produto);

//transaction.Commit();

//session.Close();
// ===================================================================

// ======================= AULA 04 - 19/05/2024  =====================

//ISession session = NHibernateHelper.AbreSession();

//ITransaction transaction = session.BeginTransaction();

//Categoria categoria = session.Load<Categoria>(1);

//IList<Produto> produtos = categoria.Produtos;

//Console.WriteLine(categoria.Produtos.Count);

//transaction.Commit();
// ===================================================================

// ======================= AULA 05 - 20/05/2024  =====================

ISession session = NHibernateHelper.AbreSession();

String hql = "from Produto p where p.Categoria.Nome = :categoria";

IQuery query = session.CreateQuery(hql);

query.SetParameter("categoria", "Nova Categoria");

IList<Produto> produtos = query.List<Produto>();

foreach (Produto produto in produtos)
{
    Console.WriteLine(produto.Nome);
}

session.Close();

Console.Read();