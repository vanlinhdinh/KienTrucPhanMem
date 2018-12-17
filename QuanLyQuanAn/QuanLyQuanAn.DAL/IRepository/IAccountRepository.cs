using QuanLyQuanAn.DAL.Model;
using System;
using System.Collections.Generic;

namespace QuanLyQuanAn.DAL.IRepository
{
    public interface IAccountRepository: IDisposable
    {
        IEnumerable<Account> GetAccounts();
        bool Login(string userName, string password);
        Account GetAccountByUserName(string userName);
        bool UpdateAccount(string userName, string newPassword);
        bool UpdateAccountFormAdmin(string userName, bool type);
        bool AddAccount(string userName, bool type);
        bool DeleteAccount(string userName);
    }
}
