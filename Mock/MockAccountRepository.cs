using Core.Interfaces;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mock
{
    public class MockAccountRepository : IAccountRepository
    {
        public static IList<Account> Accounts = new List<Account>
        {
            new Account { Id = 1, Username = "mrossi@abc.it", Password = "1234", Role= Role.User},
            new Account { Id = 2, Username = "larisa@abc.it", Password = "5678",Role=Role.Administrator}
        };
        public bool AddItem(Account newItem)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool EditItem(Account itemToEdit)
        {
            throw new NotImplementedException();
        }

        public List<Account> FetchAll()
        {
            throw new NotImplementedException();
        }

        public Account GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Account GetByUsername(string username)
        {
            return Accounts.FirstOrDefault(a => a.Username.Equals(username));
        }
    }
}
