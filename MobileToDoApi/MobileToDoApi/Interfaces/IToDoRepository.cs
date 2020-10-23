using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MobileToDoApi.Models;

namespace MobileToDoApi.Interfaces
{
    public interface IToDoRepository
    {
        bool DoesItemExist(string id);
        IEnumerable<ToDoItem> All {get};
        ToDoItem Find(string id);
        void Insert(ToDoItem);
        void Update(ToDoItem);
        void Delete(string id);
    }
}
