using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TeamCollaboration.Data.UnitOfWork;
using TeamCollaboration.Domain;
using TeamCollaboration.Domain.Aggregates;
using TeamCollaboration.Domain.Repository;

namespace TeamCollaboration.Data.Repositories
{
    public class DictionaryRepository : Repository<Dictionary>, IDictionaryRepository
    {
        public DictionaryRepository(IEnumerableUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }



        //按业务重载Repository方法
     

        //要扩展方法，首先在IDictionaryRepository中添加契约，然后在当前类中实现

        public IEnumerable<File> GetChildFile(Dictionary dictionary, string conditionExpression)
        {
            IEnumerable<File> childFile = dictionary.File.Where(file => file.FileName.Contains(conditionExpression));
            return childFile;
        }

        public IEnumerable<Dictionary> GetChildDic(User user, string conditionExpression)
        {
            IEnumerable<Dictionary> childDic = user.UserHaveDictionaries.Where(dic=>dic.FoldName.Contains(conditionExpression));
            return childDic;
        }


        public void EnableDictionary(Dictionary dictionary, int status)
        {
            throw new NotImplementedException();
        }
    }
}
