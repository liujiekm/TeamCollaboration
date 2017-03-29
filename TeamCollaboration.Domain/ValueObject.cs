//===================================================================================
// JayPrim's Project
//===================================================================================
// 领域内所有值类型的基类
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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamCollaboration.Domain
{

    /// <summary>
    ///领域内所有值类型的基类
    /// </summary>
    /// <typeparam name="TValueObject"></typeparam>
    public abstract class ValueObject<TValueObject> : IEquatable<TValueObject> where TValueObject : ValueObject<TValueObject>
    {
        public bool Equals(TValueObject other)
        {
            if((object)other ==null)
            {
                return false;
            }
            if(ReferenceEquals(this,other))//引用相等直接相等
            {
                return true;
            }

            //对比公共属性内的值是否相等
            var publicProperties = this.GetType().GetProperties();
            if ((object)publicProperties != null && publicProperties.Any())
            {
                return publicProperties.All(
                    p =>
                    {

                        var left = p.GetValue(this, null);
                        var right = p.GetValue(other, null);
                        //同一类型比较引用
                        if(typeof(TValueObject).IsAssignableFrom(left.GetType()))
                        {
                            return ReferenceEquals(left, right);
                        } 
                        else
                        {
                            return left.Equals(right);
                        }   
                    }
                    
                    );
            }
            else
            {
                return true;
            }




        }


        public static bool operator ==(ValueObject<TValueObject> left,ValueObject<TValueObject> right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(ValueObject<TValueObject> left, ValueObject<TValueObject> right)
        {
            return !(left == right);
        }


        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
