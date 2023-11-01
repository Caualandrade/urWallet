using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using urWallet.DAL.DBContext;
using urWallet.MODEL;

namespace urWallet.BLL
{
    public class UserFinancaRepository
    {
        public static void Add(UserFinanca uf)
        {
            using (var dbContext = new CUsersCaualSourceReposUrwallet01UrwalletDalDatabaseDatabaseMdfContext())
            {
                dbContext.Add(uf);
                dbContext.SaveChanges();
            }
        }

        public static void delete(UserFinanca userfina)
        {
            using (var dbContext = new CUsersCaualSourceReposUrwallet01UrwalletDalDatabaseDatabaseMdfContext())
            {
                var userFinanca = dbContext.UserFinancas.Single(p => p.Id == userfina.Id);
                dbContext.Remove(userFinanca);
                dbContext.SaveChanges();
            }
        }

        public static List<UserFinanca> GetAll()
        {
            using (var dbContext = new CUsersCaualSourceReposUrwallet01UrwalletDalDatabaseDatabaseMdfContext())
            {
                var userFinanca = dbContext.UserFinancas.ToList();
                return userFinanca;
            }
        }

        public static UserFinanca GetByID(int Id)
        {
            using (var dbContext = new CUsersCaualSourceReposUrwallet01UrwalletDalDatabaseDatabaseMdfContext())
            {
                var usuarioFinanca = dbContext.UserFinancas.Single(p => p.Id == Id);
                return usuarioFinanca;
            }
        }

        
    }
}
