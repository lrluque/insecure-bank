using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using insecure_bank_net.Data;
using insecure_bank_net.Bean;
using Microsoft.EntityFrameworkCore;

namespace insecure_bank_net.Dao
{
    public class CreditAccountDaoImpl : ICreditAccountDao
    {
        private ApplicationDbContext dbContext;

        public CreditAccountDaoImpl(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        
        public List<CreditAccount> FindCreditAccountsByUsername(string username) {
            var str = "select * from creditaccount where username = {0}";
            return dbContext.Creditaccount.FromSqlRaw(str, username).ToList();
        }
        }

        public int UpdateCreditAccount(int cashAccountId, double round) {
            var sql = "UPDATE creditAccount SET availablebalance = {0} WHERE cashaccountid = {1}";
            return dbContext.Database.ExecuteSqlRaw(sql, round, cashAccountId);
        }
        }
        
    }
}
