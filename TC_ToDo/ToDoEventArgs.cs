//===================================================================================
// Jay
//===================================================================================
// ToDo 事件内容
//
//
//===================================================================================
// .Net Framework 4.6
// CLR版本： 4.0.30319.42000
// 创建人：  Jay
// 创建时间：2017/3/23 10:23:50
// 版本号：  V1.0.0.0
//===================================================================================




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TC_ToDo
{
    public class ToDoEventArgs:EventArgs
    {


        public Guid Id { get; set; }

        public ToDoState State { get; set; }

        public ToDoCategory Category { get; set; }
    }
}
