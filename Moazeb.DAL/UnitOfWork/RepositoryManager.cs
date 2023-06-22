using Moazeb.DAL.DataContext;
using Moazeb.DAL.IRepository;
using Moazeb.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moazeb.DAL.UnitOfWork
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly ApplicationDbContext _context;
        private readonly Lazy<IParentRepository> _parentRepository;
        private readonly Lazy<ITeacherRepository> _teacherRepository;
        private readonly Lazy<IStudentRepository> _studentRepository;
        private readonly Lazy<IClassRepository> _classRepository;
        private readonly Lazy<ISubjectRepository> _subjectRepository;
        private readonly Lazy<IAttendanceStateRepository> _attendanceStateRepository;
        private readonly Lazy<ILogRepository> _logRepository;
        private readonly Lazy<IStudyingPeriodRepository> _studyingPeriodRepository;
        private readonly Lazy<IReaderRepository> _readerRepository;

        public RepositoryManager(ApplicationDbContext context)
        {
            _context = context;
            _parentRepository = new Lazy<IParentRepository>(() => new ParentRepository(context));
            _teacherRepository = new Lazy<ITeacherRepository>(() => new TeacherRepository(context));
            _studentRepository = new Lazy<IStudentRepository>(() => new StudentRepository(context));
            _classRepository = new Lazy<IClassRepository>(() => new ClassRepository(context));
            _subjectRepository = new Lazy<ISubjectRepository>(() => new SubjectRepository(context));
            _attendanceStateRepository = new Lazy<IAttendanceStateRepository>(() => new AttendanceStateRepository(context));
            _logRepository = new Lazy<ILogRepository>(() => new LogRepository(context));
            _studyingPeriodRepository = new Lazy<IStudyingPeriodRepository>(() => new StudyingPeriodRepository(context));
            _readerRepository = new Lazy<IReaderRepository>(() => new ReaderRepository(context));
        }

        public IParentRepository Parents => _parentRepository.Value;
        public ITeacherRepository Teachers => _teacherRepository.Value;
        public IStudentRepository Students => _studentRepository.Value;
        public IClassRepository Classes => _classRepository.Value;
        public ISubjectRepository Subjects => _subjectRepository.Value;
        public IAttendanceStateRepository AttendanceStates => _attendanceStateRepository.Value;
        public ILogRepository Logs => _logRepository.Value;
        public IStudyingPeriodRepository StudyingPeriods => _studyingPeriodRepository.Value;
        public IReaderRepository Readers => _readerRepository.Value;


        public async Task<int> SaveAsync() => await _context.SaveChangesAsync();
    }
}
