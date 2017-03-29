//===================================================================================
// Jay
//===================================================================================
// 待办事项清单
//
//
//===================================================================================
// .Net Framework 4.6
// CLR版本： 4.0.30319.42000
// 创建人：  Jay
// 创建时间：2017/3/24 10:05:22
// 版本号：  V1.0.0.0
//===================================================================================




using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TC_ToDo
{
    public class ToDoList 
    {
        
        private List<ToDo> toDoList;

        public ToDoList()
        {
            toDoList = new List<ToDo>();
        }


        public List<ToDo> Items { get {
                return this.toDoList;
            } 
        }


        public void Add(ToDo todo)
        {
            todo.Updated += Todo_Updated;
            this.toDoList?.Add(todo);
        }

        private void Todo_Updated(object sender, ToDoEventArgs args)
        {
            Sort(p => p.Category == ToDoCategory.Urgency&&p.Category==ToDoCategory.Important);
        }

        public bool Remove(ToDo todo)
        {
            return this.toDoList?.Remove(todo)??false;
        }

        public IEnumerable<ToDo> Sort(Func<ToDo,bool> predict)
        {
            return this.toDoList?.OrderBy(predict);
        }




    }
}
