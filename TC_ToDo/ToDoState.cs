//===================================================================================
// Jay
//===================================================================================
// 待办事项状态
//
//
//===================================================================================
// .Net Framework 4.6
// CLR版本： 4.0.30319.42000
// 创建人：  Jay
// 创建时间：2017/3/22 16:57:13
// 版本号：  V1.0.0.0
//===================================================================================




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TC_ToDo
{
    public enum ToDoState
    {
        NotStarted =0,
        Processing=1,
        Pending =2,
        Abandon = 3,
        Transfering=4,
        Done=5

    }
}
