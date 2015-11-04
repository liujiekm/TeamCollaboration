//===================================================================================
//联想智慧医疗研究院 & Net 开发组
//=================================================================================== 
// 日志记录实现，记录到系统日志中
// 
// 
//===================================================================================
// .Net Framework 4.5
// Created By liuj
// Creat Time 2015-09-17
//===================================================================================


using System;
using System.Diagnostics;
using System.Globalization;
using System.Security;
using TeamCollaboration.CrossCutting.Logging;

namespace TeamCollaboration.CrossCutting.NetFramework.Logging
{

    public sealed class TraceSourceLog : ILogger
    {


        private readonly TraceSource _source;



        public TraceSourceLog()
        {
            // 默认TRACER
            _source = new TraceSource("TRACER");
        }



        #region 私有方法


        private void TraceInternal(TraceEventType eventType, string message)
        {
            if (_source != null)
            {
                try
                {
                    _source.TraceEvent(eventType, (int) eventType, message);
                }
                catch (SecurityException)
                {

                }
            }
        }

        #endregion

        #region 实现的ILogger成员


        public void Info(string message, params object[] args)
        {
            if (!String.IsNullOrWhiteSpace(message))
            {
                var messageToTrace = string.Format(CultureInfo.InvariantCulture, message, args);

                TraceInternal(TraceEventType.Information, messageToTrace);
            }
        }

 
        public void Warning(string message, params object[] args)
        {
            if (!String.IsNullOrWhiteSpace(message))
            {
                var messageToTrace = string.Format(CultureInfo.InvariantCulture, message, args);

                TraceInternal(TraceEventType.Warning, messageToTrace);
            }
        }


        public void Error(string message, params object[] args)
        {
            if (!String.IsNullOrWhiteSpace(message))
            {
                var messageToTrace = string.Format(CultureInfo.InvariantCulture, message, args);

                TraceInternal(TraceEventType.Error, messageToTrace);
            }
        }


        public void Error(string message, Exception exception, params object[] args)
        {
            if (!String.IsNullOrWhiteSpace(message) && exception != null)
            {
                var messageToTrace = string.Format(CultureInfo.InvariantCulture, message, args);

                var exceptionData = exception.ToString();
            
                TraceInternal(TraceEventType.Error,
                              string.Format(CultureInfo.InvariantCulture, "{0} Exception:{1}", messageToTrace,
                                            exceptionData));
            }
        }


        public void Debug(string message, params object[] args)
        {
            if (!String.IsNullOrWhiteSpace(message))
            {
                var messageToTrace = string.Format(CultureInfo.InvariantCulture, message, args);

                TraceInternal(TraceEventType.Verbose, messageToTrace);
            }
        }

        public void Debug(string message, Exception exception, params object[] args)
        {
            if (!String.IsNullOrWhiteSpace(message) && exception != null)
            {
                var messageToTrace = string.Format(CultureInfo.InvariantCulture, message, args);

                var exceptionData = exception.ToString();
                TraceInternal(TraceEventType.Error, string.Format(CultureInfo.InvariantCulture, "{0} Exception:{1}", messageToTrace, exceptionData));
            }
        }


        public void Debug(object item)
        {
            if (item != null)
            {
                TraceInternal(TraceEventType.Verbose, item.ToString());
            }
        }


        public void Fatal(string message, params object[] args)
        {
            if (!String.IsNullOrWhiteSpace(message))
            {
                var messageToTrace = string.Format(CultureInfo.InvariantCulture, message, args);

                TraceInternal(TraceEventType.Critical, messageToTrace);
            }
        }


        public void Fatal(string message, Exception exception, params object[] args)
        {
            if (!String.IsNullOrWhiteSpace(message)
                &&
                exception != null)
            {
                var messageToTrace = string.Format(CultureInfo.InvariantCulture, message, args);

                var exceptionData = exception.ToString();


                TraceInternal(TraceEventType.Critical, string.Format(CultureInfo.InvariantCulture, "{0} Exception:{1}", messageToTrace, exceptionData));
            }
        }

        #endregion
    }
}