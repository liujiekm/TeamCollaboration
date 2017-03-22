//===================================================================================
// Jay
//===================================================================================
// 待办事项类别
//
//
//===================================================================================
// .Net Framework 4.6
// CLR版本： 4.0.30319.42000
// 创建人：  Jay
// 创建时间：2017/3/22 17:04:29
// 版本号：  V1.0.0.0
//===================================================================================




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TC_ToDo
{
    [Flags]
    public enum ToDoCategory:byte
    {
        Important = 0x01,
        Urgency = 0x02,
        NotImportant = 0x04,
        NotUrgency = 0x08

    }
}
