using Moazeb.DAL.DataContext;
using Moazeb.DAL.Entities;
using Moazeb.DAL.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moazeb.DAL.Repositories
{
    public class StudyingPeriodRepository : BaseRepository<StudyingPeriod>, IStudyingPeriodRepository
    {
        public StudyingPeriodRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
