//===================================================================================
//  Jay@self
//===================================================================================
// 启用事件源的实体对象，基类
//
//
//===================================================================================
// .Net Framework 4.5
// CLR版本： 4.0.30319.42000
// 创建人：  Jay
// 创建时间：2016/11/22 15:46:24
// 版本号：  V1.0.0.0
//===================================================================================




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamCollaboration.CQRS.Event;

namespace TeamCollaboration.CQRS.EventSourced
{
    public abstract class EventSourced : IEventSourced
    {



        /// <summary>
        /// 针对每种类型，提供对应的处理程序
        /// </summary>
        private readonly Dictionary<Type, Action<IEvent>> handlers = new Dictionary<Type, Action<IEvent>>();


        /// <summary>
        /// 实体加载后发生的事件有序集合
        /// </summary>
        private readonly List<IEvent> pendingEvents = new List<IEvent>();



        /// <summary>
        /// 实体的标识
        /// 
        /// </summary>
        private readonly Guid id;

        /// <summary>
        /// 初始化版本为-1
        /// </summary>
        private int version = -1;



        protected EventSourced(Guid id)
        {
            this.id = id;
        }




        public IEnumerable<IEvent> Events
        {
            get
            {
                return this.pendingEvents;
            }
        }

        public Guid Id
        {
            get
            {
                return this.id;
            }
        }

        public int Version
        {
            get
            {
                return this.version;
            }

            protected set
            {
                this.version = value;
            }


        }



        /// <summary>
        /// 增加事件类型与事件处理之间的映射
        /// </summary>
        /// <typeparam name="TEvent"></typeparam>
        /// <param name="handler"></param>
        protected void Handles<TEvent>(Action<TEvent> handler) where TEvent:IEvent
        {
            this.handlers.Add(typeof(TEvent),@event=>handler((TEvent)@event));
        }

        /// <summary>
        ///根据历史事件 重塑实体
        /// </summary>
        /// <param name="pastEvents"></param>
        protected void LoadFrom(IEnumerable<IEvent> pastEvents)
        {
            foreach (var e in pastEvents)
            {
                this.handlers[e.GetType()].Invoke(e);
                this.version = e.Version;
            }
        }



        protected void Update(IEvent @event)
        {
            @event.Id = this.Id;
            @event.Version = this.version + 1;   //并发情况，需要锁

            this.handlers[@event.GetType()].Invoke(@event);  //处理事件
            this.version = @event.Version; //跟新版本
            this.pendingEvents.Add(@event); //记录事件
        }


    }
}
