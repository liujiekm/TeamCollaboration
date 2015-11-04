//===================================================================================
//联想智慧医疗研究院 & Net 开发组
//=================================================================================== 
// 执行纯SQL接口方法
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

namespace TeamCollaboration.Data
{
    public interface ISql
    {
        IEnumerable<TEntity> ExecuteQuery<TEntity>(string sqlQuery, params object[] parameters);

        int ExecuteCommand(string sqlCommand, params object[] parameters);
    }
}
