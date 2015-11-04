//===================================================================================
//联想智慧医疗研究院 & Net 开发组
//=================================================================================== 
// Domain Entity 与Data Transfer Object 适配器 工厂接口
// 创建具体适配器类
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
    public interface ITypeAdapterFactory
    {
        ITypeAdapter CreatAdapter();
    }
}
