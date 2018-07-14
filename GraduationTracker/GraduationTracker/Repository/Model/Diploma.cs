namespace CarrerCruising.GraduationTracker.Repository.Model
{
    public class Diploma : EntityBase
    {
        public int Credits { get; set; }
        public int[] Requirements { get; set; }

    }
}
