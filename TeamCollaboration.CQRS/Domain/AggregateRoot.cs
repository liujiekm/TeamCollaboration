//===================================================================================
// Jay@self
//===================================================================================
// 支持读写分离的领域对象基类
//
//
//===================================================================================
// .Net Framework 4.5
// CLR版本： 4.0.30319.42000
// 创建人：  Jay
// 创建时间：2016/10/31 15:32:09
// 版本号：  V1.0.0.0
//===================================================================================




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamCollaboration.CQRS.Domain.Exception;
using TeamCollaboration.CQRS.Event;

namespace TeamCollaboration.CQRS.Domain
{
    public abstract class AggregateRoot
    {
        //当前领域对象上发生的事件
        private readonly List<IEvent> _changes = new List<IEvent>();

        public Guid Id { get; protected set; }

        public Int32 Version { get; protected set; }


        /// <summary>
        /// 获得所有未提交修改
        /// </summary>
        /// <returns></returns>
        public IEnumerable<IEvent> GetUncommittedChanges()
        {
            lock(_changes)
            {
                return _changes.AsEnumerable();
            }
        }


        /// <summary>
        /// 改变所有修改为已提交
        /// </summary>
        public void MarkChangesAsCommitted()
        {
            lock(_changes)
            {
                Version = Version + _changes.Count;
                _changes.Clear();
            }
        }



        /// <summary>
        /// 从历史记录中加载事件并运用到领域实体上
        /// </summary>
        /// <param name="history"></param>
        public void LoadFromHistory(IEnumerable<IEvent> history)
        {
            foreach (var item in history)
            {
                if(item.Version!=Version+1)
                {
                    throw new EventsOutOfOrderException(item.Id);
                }
                ApplyChange(item, false);
            }
        }



        protected void ApplyChange(IEvent @event)
        {
            ApplyChange(@event, true);
        }





        /// <summary>
        /// 子类去各自实现处理事件逻辑
        /// </summary>
        /// <param name="event"></param>
        public abstract void Apply(IEvent @event);


        private void ApplyChange(IEvent @event,Boolean isNew)
        {
            lock(_changes)
            {
                //对继承类调用Apply方法，发生的变化固化到类实例上
                this.Apply(@event);
                if (isNew)
                {
                    _changes.Add(@event);
                }
                else
                {
                    Id = @event.Id;
                    Version++;

                }
            }
        }



    }
}
