//===================================================================================
//联想智慧医疗研究院 & Net 开发组
//=================================================================================== 
//  IBoardRepository 接口
// 
// 
//===================================================================================
// .Net Framework 4.5
// Created By 徐旺琥
// Creat Time 2015-09-20
//===================================================================================




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamCollaboration.Domain.Aggregates;

namespace TeamCollaboration.Domain.Repository
{
    public interface IBoardRepository:IRepository<Board>
    {
        ///// <summary>
        ///// 要在公告板上显示的公告
        ///// </summary>
        ///// <param name="needBoards">需要展示的公告数</param>
        ///// <returns></returns>
        //IEnumerable<Board> GetBoards(int needBoards);

        /// <summary>
        /// 删除公告
        /// </summary>
        /// <param name="board">公告</param>
        /// <param name="enable">布尔值</param>
        void EnableBoard(Board board, int enable);

        /// <summary>
        /// 发布公告
        /// </summary>
        /// <param name="board"></param>
        void PublishBoard(Board board, User AuthorUser);

        /// <summary>
        /// 获取有效公告
        /// </summary>
        /// <param name="status"></param>
        /// <returns></returns>
        IEnumerable<Board> GetBoards(int status);
        
        /// <summary>
        /// 根据时间获取用户发布的公告
        /// </summary>
        /// <param name="user">用户</param>
        /// <param name="dateTime">发布时间</param>
        /// <returns></returns>
        IEnumerable<Board> GetAuthorBoard(User user, DateTime dateTime);
        //Board GetAuthorBoard(User user, DateTime dateTime);

        /// <summary>
        /// 获取用户发布的公告
        /// </summary>
        /// <param name="user">用户</param>
        /// <returns></returns>
        IEnumerable<Board> GetAuthorBoards(User user);

        /// <summary>
        /// 根据公告获取发布者信息
        /// </summary>
        /// <param name="board"></param>
        /// <returns></returns>
        User GetAuthor(Board board);
    }
}
