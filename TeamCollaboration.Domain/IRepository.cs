//===================================================================================
// JayPrim's Project
//===================================================================================
// 仓储 接口 实现了仓储模式
// 确实，IDbSet已经是一个通用的仓储，可能我们并不需要
// 但使用这个接口可以对领域模型使用 PI
//===================================================================================
// .Net Framework 4.5
// CLR版本： 4.0.30319.42000
// 创建人：  Jay
// 创建时间：2015-09-15 13:20:09
// 版本号：  V1.0.0.0
//===================================================================================


using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TeamCollaboration.Domain
{
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity
    {

        IUnitOfWork UnitOfWork { get; }


        void Add(TEntity item);

        void Remove(TEntity item);


        /// <summary>
        /// 标识实体为修改状态
        /// </summary>
        /// <param name="item"></param>
        void Modify(TEntity item);


        /// <summary>
        /// 把指定实体加入到跟踪状态
        /// DbSet.Attach方法
        /// </summary>
        /// <param name="item"></param>
        void TrackItem(TEntity item);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="persisted">数据库实体</param>
        /// <param name="current">当前实体</param>
        void Merge(TEntity persisted, TEntity current);


        TEntity Get(Guid id);


        IEnumerable<TEntity> GetAll();


        IEnumerable<TEntity> GetPaged<TKProperty>(int pageIndex,int pageCount,
            Expression<Func<TEntity,TKProperty>> orderByExpression,bool ascending);


        IEnumerable<TEntity> GetFilted(Expression<Func<TEntity,bool>> filter);

    }
}
