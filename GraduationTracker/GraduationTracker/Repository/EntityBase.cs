using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrerCruising.GraduationTracker.Repository.Model
{
    public abstract class EntityBase
    {
        public int Id { get; internal set; }
    }
}
