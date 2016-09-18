//===================================================================================
// JayPrim's Project
//===================================================================================
// 类库说明
//
//
//===================================================================================
// .Net Framework 4.5
// CLR版本： 4.0.30319.42000
// 创建人：  Jay
// 创建时间：2015-09-15 13:20:09
// 版本号：  V1.0.0.0
//===================================================================================


using System;

namespace TeamCollaboration.Domain  
{

    /// <summary>
    /// 所有实体的基类
    /// </summary>
    public abstract class Entity
    {

        private Guid _id;
        public virtual Guid Id
        {
            get
            {
                return this._id;
            }
            protected set //不允许直接修改
            {
                this._id = value;
            }
        }

        //有生命周期的实体id不为空、换言之值临时的无id
        private bool IsTransient()
        {
            return this.Id == Guid.Empty;
        }


        protected void GenerateNewIdentity()
        {
            if (IsTransient())
            {
                this.Id = IdentityGenerator.NewSequentialGuid();
            }
                
        }


        public void ChangeCurrentIdentity(Guid identity)
        {
            if(identity!=Guid.Empty)
            {
                this.Id = identity;
            }
        }



        #region override 一致性、相等性
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Entity))
            {
                return false;
            }

            var item = (Entity)obj;

            if(item.IsTransient() || this.IsTransient())
            {
                return false;
            }
            else
            {
                return item.Id == this.Id;
            }
            
            
        }


        private int? _requestedHashCode;

        public override int GetHashCode()
        {
            if(!IsTransient())
            {
                if(!_requestedHashCode.HasValue)
                {
                    _requestedHashCode = this.Id.GetHashCode() ^ 31;
                }
                return _requestedHashCode.Value;
            }

            return base.GetHashCode();
        }

        #endregion

    }
}
