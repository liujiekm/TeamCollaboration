//===================================================================================
// Jay@self
//===================================================================================
// 命令或者事件传递到总线上的包装对象
//
//
//===================================================================================
// .Net Framework 4.5
// CLR版本： 4.0.30319.42000
// 创建人：  Jay
// 创建时间：2016/11/22 13:59:03
// 版本号：  V1.0.0.0
//===================================================================================




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamCollaboration.CQRS.Message
{
    /// <summary>
    /// <see cref="Envelope{T}"/> 的静态工厂类
    /// </summary>
    public abstract class Envelope
    {
        public static Envelope<T> Create<T>(T body)
        {
            return new Envelope<T>(body);
        }
    }



    /// <summary>
    /// 对要发送给总线的对象提供Envelope包装
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Envelope<T> :Envelope
    {


        public T Body { get; private set; }
        public Envelope(T body)
        {
            this.Body = body;
        }


        /// <summary>
        /// 设置发送、入队列、处理消息体的延迟时间
        /// </summary>
        public TimeSpan Delay { get; set; }


        /// <summary>
        /// 设置队列钟消息体的存活时间
        /// </summary>
        public TimeSpan TimeToLive { get; set; }


        /// <summary>
        /// 实体关联标识
        /// </summary>
        public String  CorrelationId { get; set; }

        /// <summary>
        /// 消息关联标识
        /// </summary>
        public String MessageId { get; set; }



        public static implicit operator Envelope<T>(T body)
        {
            return Envelope.Create<T>(body);
        }
    }
}
