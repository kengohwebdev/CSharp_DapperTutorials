using Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Repository : IRepository<MyStack>
    {
        private LinkedList<T> list = new LinkedList<E>();
        public void Add(T item)
        {
            list.AddLast(item);
        };

        void Remove(T item)
        {
            return list.RemoveLast(item);
        };

        void Save(T item)
        {
            var save;
            foreach (T _item in list)
            {
                if (_item == item)
                    save = item;
            }
            return save;
        };

        IEnumerable<T> GetAll()
        {
            return list;
        };

        T GetById(int id)
        {

        };

    }
}
