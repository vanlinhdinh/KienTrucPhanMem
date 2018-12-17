using System;
using System.Collections.Generic;
using QuanLyQuanAn.DAL.IRepository;
using QuanLyQuanAn.DAL.Model;
using QuanLyQuanAn.DAL.Repository;
using QuanLyQuanAn.BLL.IService;

namespace QuanLyQuanAn.BLL
{
    public class AccountService :IAccountService
    {
        private IAccountRepository accountRepository;
        public AccountService()
        {
            this.accountRepository = new AccountRepository(new QuanLyQuanAnModel());
        }

        public bool AddAccount(string userName, bool type)
        {
            return accountRepository.AddAccount(userName, type);
        }

        public bool DeleteAccount(string userName)
        {
            return accountRepository.DeleteAccount(userName);
        }

        public Account GetAccountByUserName(string userName)
        {
            return accountRepository.GetAccountByUserName(userName);
        }

        public IEnumerable<Account> GetAccounts()
        {
            return accountRepository.GetAccounts();
        }

        

        public bool Login(string userName, string password)
        {
            return accountRepository.Login(userName,password);
        }

        public bool UpdateAccount(string userName, string newPassword)
        {
            return accountRepository.UpdateAccount(userName, newPassword);
        }

        public bool UpdateAccountFormAdmin(string userName, bool type)
        {
            return accountRepository.UpdateAccountFormAdmin(userName, type);
        }
    }

}
