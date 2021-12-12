using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApp.Core.Models;

namespace ToDoApp.Core.Interfaces
{
    interface IToDoItemService
    {
        IEnumerable<ToDoItem> GetToDoItems();
        ToDoItem GetById(int id);
        ToDoItem Add(ToDoItem toDoItem);
        ToDoItem Update(int id, ToDoItem toDoItem);
        void Delete(int id);
    }
}
