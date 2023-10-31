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
                    }
                }
                return false;
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
    }
}