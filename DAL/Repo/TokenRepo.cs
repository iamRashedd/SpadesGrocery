using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class TokenRepo : ISalesRepo<Token, string, Token>
    {
        SpadesGroceryEntities db;
        public TokenRepo(SpadesGroceryEntities db)
        {
            this.db = db;
        }

        public Token Create(Token obj)
        {
            db.Tokens.Add(obj);
            db.SaveChanges();
            return obj;
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<Token> GetAll()
        {
            throw new NotImplementedException();
        }

        public Token GetById(string token)
        {
            return db.Tokens.FirstOrDefault(t => t.Token1.Equals(token));
        }

        public bool Update(Token obj)
        {
            var exst = db.Tokens.FirstOrDefault(x => x.Token1.Equals(obj.Token1));
            if (exst != null)
            {
                db.Entry(exst).CurrentValues.SetValues(obj);
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
