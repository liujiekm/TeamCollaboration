//===================================================================================
//联想智慧医疗研究院 & Net 开发组
//=================================================================================== 
// 仓储基类
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
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TeamCollaboration.Domain;

namespace TeamCollaboration.Data
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {


        private IEnumerableUnitOfWork _unitOfWork;


        public Repository(IEnumerableUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

            

        public IUnitOfWork UnitOfWork
        {
            get
            {
                return this._unitOfWork;
            }
        }

        private IDbSet<TEntity> GetSet()
        {
            return this._unitOfWork.GetSet<TEntity>();
        }



        public virtual  void Add(TEntity item)
        {
            if(item!=(TEntity)null)
            {
                GetSet().Add(item);
            }
        }

        public void Dispose()
        {
            if(this._unitOfWork!=null)
            {
                this._unitOfWork.Dispose();
            }
        }


        /// <summary>
        /// Find有性能优势
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual TEntity Get(Guid id)
        {
            if (id != Guid.Empty)
            {
                return GetSet().Find(id);
            }
            else
            {
                return null;
            }
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return GetSet();
        }

        public virtual IEnumerable<TEntity> GetPaged<TKProperty>(int pageIndex, int pageCount, System.Linq.Expressions.Expression<Func<TEntity, TKProperty>> orderByExpression, bool ascending)
        {
            if(ascending)
            {
                return GetSet().OrderBy(orderByExpression).Skip(pageIndex * pageCount).Take(pageCount);
            }
            else
            {
                return GetSet().OrderByDescending(orderByExpression).Skip(pageIndex * pageCount).Take(pageCount);
            }
        }

        public virtual void Merge(TEntity persisted, TEntity current)
        {
            this._unitOfWork.ApplyCurrentValues(persisted, current);
        }

        public virtual void Modify(TEntity item)
        {
            if(item!=(TEntity)null)
            {
                this._unitOfWork.SetModified(item);
            }
        }

        public virtual void Remove(TEntity item)
        {
            if(item != (TEntity)null)
            {
                this._unitOfWork.Attach(item);
                GetSet().Remove(item);
            }
        }

        public virtual void TrackItem(TEntity item)
        {
            if (item != (TEntity)null)
            {
                this._unitOfWork.Attach<TEntity>(item);
                
            }
        }

        public IEnumerable<TEntity> GetFilted(Expression<Func<TEntity, bool>> filter)
        {
            return GetSet().Where(filter);
        }
    }
}
