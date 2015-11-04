//===================================================================================
//联想智慧医疗研究院 & Net 开发组
//=================================================================================== 
// Domain Entity 与Data Transfer Object 适配器（互相转换）自定义配置
// 定义两个实例属性之间的映射关系
// 
//===================================================================================
// .Net Framework 4.5
// Created By liuj
// Creat Time 2015-09-17
//===================================================================================

using System;
using AutoMapper;
using TeamCollaboration.Domain.Aggregates;
using TeamCollaboration.Application.DTO.Data_Transfer_Object;

namespace TeamCollaboration.Application.DTO.Profiles
{
    internal class TeamCollaborationEntityProfile:Profile
    {
        protected override  void Configure()
        {

            //配置示例
            //编写领域实体与DTO实例之间的转化映射关系
            var map = Mapper.CreateMap<User, UserDTO>();
            //UserDTO的属性NameCode由User的Name与Code凭借而成功
            map.ForMember(dto => dto.NameCode,m => m.MapFrom(e =>  e.Name + e.Code));

        }



        

    }
}
