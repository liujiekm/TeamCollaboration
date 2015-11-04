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
    public class FileRepository : Repository<File>, IFileRepository
    {
        public FileRepository(IEnumerableUnitOfWork unitOfWork)
            : base(unitOfWork)
        {

        }



        //按业务重载Repository方法




        //要扩展方法，首先在IFileRepository中添加契约，然后在当前类中实现

      
        public IEnumerable<File> GetSimilarFile(User user, string condition)
        {
            IEnumerable<Dictionary> dic = user.UserHaveDictionaries;
            List<File> file = new List<File>();
            foreach (var eachFolder in dic) { 
                IEnumerable<File> eachFile=eachFolder.File;
                eachFile.ToList();
                file.AddRange(eachFile);
            }
            return file.AsEnumerable();
        }

        public void EnableFile(File file, int status)
        {
            throw new NotImplementedException();
        }

        public void UpFileToTask(File file, Domain.Aggregates.Task task, Dictionary dictionary)
        {
            throw new NotImplementedException();
        }

        public void UpFileToMeeting(File file, Meeting meeting, Dictionary dictionary)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<File> GetTaskFile(Domain.Aggregates.Task task)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<File> GetMeetingFile(Meeting meeting)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<File> GetFileByDate(DateTime datatime)
        {
            throw new NotImplementedException();
        }

        public File findByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
