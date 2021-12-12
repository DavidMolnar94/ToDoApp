using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApp.Core.Interfaces;
using ToDoApp.Core.Models;

namespace ToDoApp.Core.Services
{
    public class TmpToDoItemService : IToDoItemService
    {
        public ToDoItem Add(ToDoItem toDoItem)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ToDoItem GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ToDoItem> GetToDoItems()
        {
            throw new NotImplementedException();
        }

        public ToDoItem Update(int id, ToDoItem toDoItem)
        {
            throw new NotImplementedException();
        }
    }
}
