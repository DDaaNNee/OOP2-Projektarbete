using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repositories
{   // Satte "AuthorRepository" till <T, Tid> för att matcha "IRepository<T, Tid>"
    class AuthorRepository<T, Tid> : IRepository<T, Tid>
    {
        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> All()
        {
            throw new NotImplementedException();
        }

        public void Edit(T item)
        {
            throw new NotImplementedException();
        }

        public T Find(Tid id)
        {
            throw new NotImplementedException();
        }

        public void Remove(T item)
        {
            throw new NotImplementedException();
        }
    }
}
