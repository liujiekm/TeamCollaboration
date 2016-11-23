//===================================================================================
// 北京联想智慧医疗信息技术有限公司 & 上海研发中心
//===================================================================================
// Sagas 仓储
//
//
//===================================================================================
// .Net Framework 4.5
// CLR版本： 4.0.30319.42000
// 创建人：  Jay
// 创建时间：2016/11/23 13:49:33
// 版本号：  V1.0.0.0
//===================================================================================




using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TeamCollaboration.CQRS.Processes
{
    public interface IProcessManagerRepository<T> :IDisposable where T: class ,IProcessManager
    {
        T Find(Guid id);

        void Save(T processManager);


        T Find(Expression<Func<T,bool>>predicate,bool includeCompleted =false);
    }
}
