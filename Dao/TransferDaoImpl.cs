﻿using System.Threading.Tasks;
using insecure_bank_net.Data;
using insecure_bank_net.Bean;
using Microsoft.EntityFrameworkCore;

namespace insecure_bank_net.Dao
{
    public class TransferDaoImpl : ITransferDao
    {
        private ApplicationDbContext dbContext;

        public TransferDaoImpl(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public int InsertTransfer(Transfer transfer)
        {
var sql = "INSERT INTO transfer (fromAccount, toAccount, description, amount, fee, username, date) " +
          "VALUES (@p0, @p1, @p2, @p3, @p4, @p5, @p6)";
return dbContext.Database.ExecuteSqlRaw(sql, 
    transfer.FromAccount, transfer.ToAccount, transfer.Description, 
    transfer.Amount, transfer.Fee, transfer.Username, transfer.Date);
        }
    }
}
