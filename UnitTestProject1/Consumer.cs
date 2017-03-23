//===================================================================================
// Jay
//===================================================================================
// 类库说明
//
//
//===================================================================================
// .Net Framework 4.6
// CLR版本： 4.0.30319.42000
// 创建人：  Jay
// 创建时间：2017/3/23 11:09:47
// 版本号：  V1.0.0.0
//===================================================================================




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TC_ToDo;

namespace UnitTestProject1
{
    public class Consumer
    {
        public Consumer(ToDo todo)
        {
            todo.Updated += Todo_Updated;
        }

        public String Temp { get; set; }

        private void Todo_Updated(object sender, ToDoEventArgs args)
        {
            Temp = args.Id + "" + args.State + "" + args.Category;
        }
    }
}
