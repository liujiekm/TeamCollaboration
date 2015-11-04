//===================================================================================
//联想智慧医疗研究院 & Net 开发组
//=================================================================================== 
// Domain Entity 与Data Transfer Object 适配器（互相转换）工厂方法
// 使用AutoMapper类库实现
// 创建AutomapperTypeAdapter
//===================================================================================
// .Net Framework 4.5
// Created By liuj
// Creat Time 2015-09-17
//===================================================================================

using AutoMapper;
using System;
using System.Linq;
using TeamCollaboration.CrossCutting.Adapter;


namespace TeamCollaboration.CrossCutting.NetFramework.Adapter
{
    public class AutomapperTypeAdapterFactory : ITypeAdapterFactory
    {

        /// <summary>
        /// 初始化AutoMapper配置（profile，configuration）
        /// </summary>
        public AutomapperTypeAdapterFactory()
        {
            //获得所有自定义的继承自profile的子类（自定义映射规则）
            var profiles = AppDomain.CurrentDomain.GetAssemblies().SelectMany(p => p.GetTypes()).Where(t => t.BaseType == typeof(Profile));

            Mapper.Initialize(configuration=>
                {
                    foreach (var item in profiles)
                    {
                        if(item.FullName!="AutoMapper.SeflProfiler`2")
                        {
                            configuration.AddProfile(Activator.CreateInstance(item) as Profile);
                        }
                        
                    }

                });
        }


        public ITypeAdapter CreatAdapter()
        {
            return new AutomapperTypeAdapter();
        }




    }
}
