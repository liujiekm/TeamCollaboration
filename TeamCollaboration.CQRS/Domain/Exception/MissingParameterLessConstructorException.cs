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
    public class MissingParameterLessConstructorException : System.Exception
    {
        public MissingParameterLessConstructorException(Type type)
            : base(string.Format("{0} has no constructor without paramerters. This can be either public or private", type.FullName))
        {
        }
    }
}