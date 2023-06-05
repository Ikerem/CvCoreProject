using BusinesLayer.Abstarct;
using DataAcsesLayer.Abstract;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLayer.Concrete
{
    public class ToDoListManager : ITodoListService
    {
        IToDoListDal _ToDoListDal;

        public ToDoListManager(IToDoListDal toDoListDal)
        {
            _ToDoListDal = toDoListDal;
        }

        public ToDoList GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<ToDoList> GetList()
        {
           return _ToDoListDal.GetList();
        }

        public List<ToDoList> GetListFiltre()
        {
            throw new NotImplementedException();
        }

        public void TAdd(ToDoList t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(ToDoList t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(ToDoList t)
        {
            throw new NotImplementedException();
        }
    }
}
