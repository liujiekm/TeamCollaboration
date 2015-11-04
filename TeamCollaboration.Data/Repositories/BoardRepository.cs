using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamCollaboration.Data.UnitOfWork;
using TeamCollaboration.Domain;
using TeamCollaboration.Domain.Aggregates;
using TeamCollaboration.Domain.Repository;

namespace TeamCollaboration.Data.Repositories
{
    public class BoardRepository : Repository<Board>, IBoardRepository
    {
        public BoardRepository(IEnumerableUnitOfWork unitOfWork)
            : base(unitOfWork)
        {

        }



        //按业务重载Repository方法




        //要扩展方法，首先在IBoardRepository中添加契约，然后在当前类中实现

        public IEnumerable<Board> GetBoards(int needBoards)
        {
            IEnumerable<Board> boards = GetAll().Take(needBoards);
            return boards;
        }

        public void EnableBoard(Board board, int enable)
        {
            throw new NotImplementedException();
        }

        public void PublishBoard(Board board, User AuthorUser)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Board> GetAuthorBoard(User user, DateTime dateTime)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Board> GetAuthorBoards(User user)
        {
            throw new NotImplementedException();
        }

        public User GetAuthor(Board board)
        {
            throw new NotImplementedException();
        }
    }
}
