using LojaWeb.Entidades;
using LojaWeb.Infra;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaWeb.DAO
{
    public class UsuarioDAO
    {
        private ISession _session;

        public UsuarioDAO(ISession session)
        {
            this._session = session;
        }

        public void Adiciona(Usuario usuario)
        {
            ITransaction transaction = _session.BeginTransaction();

            _session.Save(usuario);

            transaction.Commit();
        }

        public Usuario BuscaPorId(int id)
        {
            return _session.Get<Usuario>(id);
        }
    }
}
