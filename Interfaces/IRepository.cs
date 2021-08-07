using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEntityFramework.Interfaces
{
    interface IRepository<T>: IDisposable where T : class 
    {
        IEnumerable<T> GetBookList();
        T GetBook(int id);
        void Input(T item);
        void Remove(T item);
    }
}
