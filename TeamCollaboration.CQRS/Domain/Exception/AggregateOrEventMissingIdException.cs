//===================================================================================
// Jay@self
//===================================================================================
// �Զ����쳣
//
//
//===================================================================================
// .Net Framework 4.5
// CLR�汾�� 4.0.30319.42000
// �����ˣ�  Jay
// ����ʱ�䣺2016/10/31 15:32:09
// �汾�ţ�  V1.0.0.0
//===================================================================================

using System;

namespace TeamCollaboration.CQRS.Domain.Exception
{
    public class AggregateOrEventMissingIdException : System.Exception
    {
        public AggregateOrEventMissingIdException(Type aggregateType, Type eventType)
            : base(string.Format("An event of type {0} was tried to save from {1} but no id where set on either", eventType.FullName,aggregateType.FullName))
        {
            
        }
    }
}