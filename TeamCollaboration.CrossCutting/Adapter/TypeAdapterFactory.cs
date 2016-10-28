//===================================================================================
//Jay@self
//=================================================================================== 
// Domain Entity 与Data Transfer Object 适配器（互相转换）静态工厂方法
// 使用AutoMapper类库实现
// 提供统一的静态类来构造实现了ITypeAdapterFactory的实现类
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
    public class TypeAdapterFactory
    {
        private static  ITypeAdapterFactory _typeAdapterFactory = null;


        /// <summary>
        /// 设置当前要使用的实现类（依赖注入）
        /// </summary>
        /// <param name="current"></param>
        public static void SetCurrent(ITypeAdapterFactory current)
        {
            _typeAdapterFactory = current;
        }


        /// <summary>
        /// 创建具体的TypeAdapter实现类
        /// </summary>
        /// <returns></returns>
        public static  ITypeAdapter CreateAdapter()
        {
            return _typeAdapterFactory.CreatAdapter();
        }


    }
}
