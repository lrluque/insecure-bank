using System.Collections.Generic;
using System.Linq;
using insecure_bank_net.Bean;
using insecure_bank_net.Data;
using Microsoft.EntityFrameworkCore;

namespace insecure_bank_net.Dao
{
    public class AccountDaoImpl : IAccountDao
    {
        private ApplicationDbContext dbContext;

        public AccountDaoImpl(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Account> FindUsersByUsernameAndPassword(string username, string password)
        {
var str = "SELECT * FROM account WHERE username = @p0 AND password = @p1";
return dbContext.Account.FromSqlRaw(str, username, password).ToList();

public List<Account> FindUsersByUsername(string username)
{
    var str = "SELECT * FROM account WHERE username = @p0";
    return dbContext.Account.FromSqlRaw(str, username).ToList();
}
        }

        public List<Account> FindAllUsers()
        {
            var str =  "select * from account";
            return dbContext.Account.FromSqlRaw(str).ToList();
        }
    }
}
