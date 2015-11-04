//===================================================================================
//联想智慧医疗研究院 & Net 开发组
//=================================================================================== 
// Domain Entity 与Data Transfer Object 适配器（互相转换）方法接口契约
// 
// 
//===================================================================================
// .Net Framework 4.5
// Created By liuj
// Creat Time 2015-09-17
//===================================================================================




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamCollaboration.CrossCutting.Adapter
{
    public interface ITypeAdapter
    {
        /// <summary>
        /// 转换TSource实例为TTarget实例
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <typeparam name="TTarget"></typeparam>
        /// <param name="souce"></param>
        /// <returns></returns>
        TTarget Adapter<TSource, TTarget>(TSource souce) where TTarget : class, new() where TSource : class;

        /// <summary>
        /// 转换无指定类型实例为TTarget实例
        /// </summary>
        /// <typeparam name="TTarget"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        TTarget Adapter<TTarget>(object source) where TTarget : class, new();
    }
}
