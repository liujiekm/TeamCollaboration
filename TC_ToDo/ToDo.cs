//===================================================================================
// Jay
//===================================================================================
// 待办事项
//
//
//===================================================================================
// .Net Framework 4.6
// CLR版本： 4.0.30319.42000
// 创建人：  Jay
// 创建时间：2017/3/22 16:56:16
// 版本号：  V1.0.0.0
//===================================================================================




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TC_ToDo
{
    public class ToDo
    {

        public Guid Id { get; set; }
        public String Content { get; set; }

        public String Tag { get; set; }


        public String Owner { get; set; }

        public DateTime  CreateTime { get; set; }

        /// <summary>
        /// 截止时间
        /// </summary>
        public DateTime Deadline { get; set; }


        /// <summary>
        /// 实际完成时间
        /// </summary>
        public DateTime DoneTime { get; set; }

        public ToDoState State { get; set; }

        public ToDoCategory Category { get; set; }

        /// <summary>
        /// 距离Deadline多长时间，ToDo变为Urgency
        /// </summary>
        public TimeSpan UrgencyInterval { get; set; }


        /// <summary>
        /// 检查当前 ToDo是否紧急
        /// </summary>
        public void CheckUrgent()
        {
            if((Deadline-DateTime.Now)<UrgencyInterval)
            {
                Category = ToDoCategory.Urgency;
            }
            Updated?.Invoke(this, new ToDoEventArgs { Id = this.Id, Category = this.Category, State = this.State });
        }

        /// <summary>
        /// 调整ToDo 的紧急 重要程度
        /// </summary>
        public void ChangeCategory(ToDoCategory category)
        {
            Category = category;

            Updated?.Invoke(this, new ToDoEventArgs { Id = this.Id, Category = this.Category, State = this.State });

        }

        public event ToDoUpdateEvantHanlder Updated;

        /// <summary>
        /// Wrap event invocations inside a protected virtual method to 
        /// allow derived classes to override the event invocation behavior
        /// </summary>
        /// <param name="args"></param>
        protected virtual void OnToDoUpdated(ToDoEventArgs args)
        {
            // Make a temporary copy of the event to avoid possibility of
            // a race condition if the last subscriber unsubscribes
            // immediately after the null check and before the event is raised.
            ToDoUpdateEvantHanlder updated = Updated;
            Updated?.Invoke(this, args);
        }


        
    }





    //ToDo 状态跟新以及 紧急重要程度更新事件
    public delegate void ToDoUpdateEvantHanlder(object sender,ToDoEventArgs args);



}
