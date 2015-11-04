//===================================================================================
//联想智慧医疗研究院 & Net 开发组
//=================================================================================== 
// Domain Entity 与Data Transfer Object 适配器（互相转换）具体实现类
// 使用AutoMapper类库实现
// 
//===================================================================================
// .Net Framework 4.5
// Created By liuj
// Creat Time 2015-09-17
//===================================================================================


using AutoMapper;
using System;
using TeamCollaboration.CrossCutting.Adapter;

namespace TeamCollaboration.CrossCutting.NetFramework.Adapter
{
    public class AutomapperTypeAdapter : ITypeAdapter
    {
        public TTarget Adapter<TTarget>(object source) where TTarget : class, new()
        {
            return Mapper.Map<TTarget>(source);
        }

        public TTarget Adapter<TSource, TTarget>(TSource souce)
            where TSource : class
            where TTarget : class, new()
        {
            return Mapper.Map<TSource, TTarget>(souce);
        }
    }
}
