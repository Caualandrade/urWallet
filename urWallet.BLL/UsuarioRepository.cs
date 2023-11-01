
using System.Data.Entity.Core.Mapping;
using urWallet.DAL.DBContext;
using urWallet.MODEL;

namespace urWallet.BLL
{
    public class UsuarioRepository
    {
        
        public static void Add(Usuario usuario)
        {
            using(var dbContext = new CUsersCaualSourceReposUrwallet01UrwalletDalDatabaseDatabaseMdfContext())
            {
                dbContext.Add(usuario);
                dbContext.SaveChanges();
            }
        }

        public static Boolean verificarUsuario(Usuario usuario)
        {
            using (var dbContext = new CUsersCaualSourceReposUrwallet01UrwalletDalDatabaseDatabaseMdfContext())
            {
                List<Usuario> list = new List<Usuario>();
                list = UsuarioRepository.getAll();
                foreach(Usuario usuarios in list)
                {
                    if(usuario.user == usuarios.user && usuario.Senha == usuarios.Senha)
                    {
                        return true;
                    }else if(usuario.user == usuarios.user)
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        public static int onlineUsuario(Usuario usuario)
        {
            using (var dbContext = new CUsersCaualSourceReposUrwallet01UrwalletDalDatabaseDatabaseMdfContext())
            {
                List<Usuario> list = new List<Usuario>();
                list = UsuarioRepository.getAll();
                foreach (Usuario usuarios in list)
                {
                    if (usuario.user == usuarios.user && usuario.Senha == usuarios.Senha)
                    {
                        return usuarios.Id;
                    }
                }
                return 0;
            }
        }

        public static List<Usuario> getAll()
        {
            using (var dbContext = new CUsersCaualSourceReposUrwallet01UrwalletDalDatabaseDatabaseMdfContext())
            {
                var usuario = dbContext.Usuarios.ToList();
                return usuario;
            }
        }
         
        public static void Update(Usuario user)
        {
            using (var dbContext = new CUsersCaualSourceReposUrwallet01UrwalletDalDatabaseDatabaseMdfContext())
            {
                var usuario = dbContext.Usuarios.Single(p => p.Id == user.Id);
                usuario.user = user.user;
                usuario.Senha = user.Senha;
                usuario.Saldo = user.Saldo;
                dbContext.SaveChanges();
            }
        }

        public static Usuario GetByID(int Id)
        {
            using (var dbContext = new CUsersCaualSourceReposUrwallet01UrwalletDalDatabaseDatabaseMdfContext())
            {
                var usuario = dbContext.Usuarios.Single(p => p.Id == Id);
                return usuario;
            }
        }


    }

}