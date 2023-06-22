using Moazeb.DAL.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moazeb.DAL.UnitOfWork
{
    public interface IRepositoryManager
    {
        IParentRepository Parents { get; }
        ITeacherRepository Teachers { get; }
        IStudentRepository Students { get; }
        IClassRepository Classes { get; }
        ISubjectRepository Subjects { get; }
        IAttendanceStateRepository AttendanceStates { get; }
        ILogRepository Logs { get; }
        IStudyingPeriodRepository StudyingPeriods { get; }
        IReaderRepository Readers { get; }

        Task<int> SaveAsync();
    }
}
