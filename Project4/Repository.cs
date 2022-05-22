using Project4.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4.Repository
{
    public class Repository : IRepository<Department>
    {
        List<Department> _list;

        public Repository()
        {
            _list = new List<Department>();
        }
        public void Add(Department item)
        {
            _list.Add(item);
        }

        public void Remove(Department item)
        {
            _list.Remove(item);
        }


        public void Save()
        {
            throw new NotImplementedException();
        }
        public IEnumerable<Department> GetAll()
        {
            return _list;
        }

        public Department GetById(int id)
        {
            foreach (Department d in _list)
            {
                if (d.Id == id) { return d; }
            }
            return null;
        }
    }
}
