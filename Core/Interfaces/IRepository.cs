using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interfaces
{
    public interface IRepository<T>
    {
        List<T> FetchAll();
        T GetById(int id);
        bool AddItem(T newItem);
        bool EditItem(T itemToEdit);
        bool Delete(int id);
    }
}
