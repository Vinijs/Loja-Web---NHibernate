using LojaWeb.DAO;
using LojaWeb.Entidades;
using LojaWeb.Infra;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Transform;

//NHibernateHelper.GeraSchema();

// ======================= AULA 09 - 26/05/2024  =====================

ISession session = NHibernateHelper.AbreSession();

PessoaFisica Vinicius = new PessoaFisica();
Vinicius.Nome = "Vinicius";
Vinicius.CPF = "123.456.789-00";

PessoaJuridica TorneseUmProgramador = new PessoaJuridica();
TorneseUmProgramador.Nome = "Torne-se Um Programador";
TorneseUmProgramador.CNPJ = "123.456/0001-11";

UsuarioDAO usuarioDAO = new UsuarioDAO(session);

usuarioDAO.Adiciona(Vinicius);
usuarioDAO.Adiciona(TorneseUmProgramador);

session.Close();

Console.Read();