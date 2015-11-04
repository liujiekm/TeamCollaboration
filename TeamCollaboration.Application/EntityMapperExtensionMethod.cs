//===================================================================================
//联想智慧医疗研究院 & Net 开发组
//=================================================================================== 
// Domain Entity 与Data Transfer Object 适配器（互相转换）
// 封装扩展方法：对任何领域实体都可调用此方法来转换成DTO对象
// 
//===================================================================================
// .Net Framework 4.5
// Created By liuj
// Creat Time 2015-09-17
//===================================================================================




using System.Collections.Generic;
using TeamCollaboration.CrossCutting.Adapter;
using TeamCollaboration.Domain;

namespace TeamCollaboration.Application
{
    public static class EntityMapperExtensionMethod
    {

        /// <summary>
        /// 当前实例转换为目标实例
        /// </summary>
        /// <typeparam name="TTarget">目标实例</typeparam>
        /// <param name="item">当前实例</param>
        /// <returns></returns>
        public static TTarget Transfer<TTarget>(this Entity item) where TTarget :class ,new()
        {
            var typeAdapter = TypeAdapterFactory.CreateAdapter();
            return typeAdapter.Adapter<TTarget>(item);
        }


        public static List<TTarget> TransferCollection<TTarget>(this IEnumerable<Entity> items)
        {
            var typeAdapter = TypeAdapterFactory.CreateAdapter();

            return typeAdapter.Adapter<List<TTarget>>(items);
        }
    }
}
