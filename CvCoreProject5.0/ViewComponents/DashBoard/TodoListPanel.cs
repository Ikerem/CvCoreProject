using BusinesLayer.Concrete;
using DataAcsesLayer.EntityFreamwork;
using Microsoft.AspNetCore.Mvc;

namespace CvCoreProject5._0.ViewComponents.DashBoard
{
    public class TodoListPanel:ViewComponent
    {
        ToDoListManager _toDoListManager=new ToDoListManager(new EFTodoList());
        public IViewComponentResult Invoke()
        {
            var values = _toDoListManager.GetList();
            return View(values);
        }
    }
}
