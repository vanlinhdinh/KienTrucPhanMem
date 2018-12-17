using QuanLyQuanAn.DAL.IRepository;
using QuanLyQuanAn.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuanLyQuanAn.DAL.Repository
{
    public class AccountRepository : IAccountRepository, IDisposable
    {
        private readonly QuanLyQuanAnModel db;
        public AccountRepository(QuanLyQuanAnModel _db)
        {
            this.db = _db;
        }

        public IEnumerable<Account> GetAccounts()
        {
            return db.Accounts.ToList();
            
        }
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public bool Login(string userName, string password)
        {
            if (db.Accounts.FirstOrDefault(m => m.userName.Equals(userName) && m.passWordUser.Equals(password))!=null)
                return true;
            return false;
        }

        public Account GetAccountByUserName(string userName)
        {
            return db.Accounts.FirstOrDefault(m => m.userName.Equals(userName));
        }

        public bool UpdateAccount(string userName, string newPassword)
        {
            var result = db.Accounts.SingleOrDefault(m => m.userName==userName);
            if(result!=null)
            {
                result.passWordUser = newPassword;
                db.SaveChanges();
            }
            else
            {
                return false;
            }
            return true;
        }

        public bool UpdateAccountFormAdmin(string userName, bool type)
        {
            var result = db.Accounts.SingleOrDefault(m => m.userName == userName);
            if (result != null)
            {
                result.style = type;
                db.SaveChanges();
            }
            else
            {
                return false;
            }
            return true;
        }

        public bool AddAccount(string userName, bool type)
        {
            //kiểm tra có trùng tên đăng nhập hay không
            var result = db.Accounts.SingleOrDefault(m => m.userName == userName);
            if (result != null)
            {
                return false;
            }
            //kêt thúc kiêm tra
            Account X = new Account();
            X.userName = userName;
            X.style = type;
            X.passWordUser = "0";
            db.Accounts.Add(X);
            db.SaveChanges();
            return true;

        }

        public bool DeleteAccount(string userName)
        {
            //xóa tài khoản
            var result = db.Accounts.SingleOrDefault(m => m.userName == userName);
            if (result == null)//không tồn tại
            {
                return false;
            }

            db.Accounts.Remove(result);
            db.SaveChanges();
            return true;
        }
    }
}
