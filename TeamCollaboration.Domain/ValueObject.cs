//===================================================================================
//联想智慧医疗研究院 & Net 开发组
//=================================================================================== 
// 领域内所有值类型的基类
// 
// 
//===================================================================================
// .Net Framework 4.5
// Created By liuj
// Creat Time 2015-09-15
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
    public class ValueObject<TValueObject> : IEquatable<TValueObject> where TValueObject : ValueObject<TValueObject>
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
    }
}
