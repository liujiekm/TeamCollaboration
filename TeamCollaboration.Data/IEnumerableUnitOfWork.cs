//===================================================================================
//联想智慧医疗研究院 & Net 开发组
//=================================================================================== 
// Unit Of Work 接口   针对EF实现的一个扩展接口
// 
// 
//===================================================================================
// .Net Framework 4.5
// Created By liuj
// Creat Time 2015-09-16
//===================================================================================

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamCollaboration.Domain;

namespace TeamCollaboration.Data
{
    public interface IEnumerableUnitOfWork : IUnitOfWork,ISql
    {

        /// <summary>
        /// 从给定上下文（context）中获取DbSet实例
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <returns></returns>
        DbSet<TEntity> GetSet<TEntity>() where TEntity : class;

        /// <summary>
        /// 将给定实体加入ObjectStateManager中
        /// 可以让上下文跟踪内存中的实体
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        void Attach<TEntity>(TEntity item) where TEntity : class;


        /// <summary>
        /// 把实体状态改为modified
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="item"></param>
        void SetModified<TEntity>(TEntity item) where TEntity : class;



        /// <summary>
        ///    修改数据库实体
        /// </summary>
        /// <typeparam name="TEntity">The type of entity</typeparam>
        /// <param name="original">数据库实体</param>
        /// <param name="current">当前内存中实体</param>
        void ApplyCurrentValues<TEntity>(TEntity original, TEntity current) where TEntity : class;
    }
}
