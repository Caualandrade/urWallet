using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using urWallet.DAL.DBContext;
using urWallet.MODEL;

namespace urWallet.BLL
{
    public class FinancaRepository
    {
        
        public static void Add(Financa financa)
        {
            using (var dbContext = new CUsersCaualSourceReposUrwallet01UrwalletDalDatabaseDatabaseMdfContext())
            {
                dbContext.Add(financa);
                dbContext.SaveChanges();
            }
        }

        public static Financa GetByID(int Id)
        {
            using (var dbContext = new CUsersCaualSourceReposUrwallet01UrwalletDalDatabaseDatabaseMdfContext())
            {
                var financa = dbContext.Financas.Single(p => p.Id == Id);
                return financa;
            }
        }
    }
}
