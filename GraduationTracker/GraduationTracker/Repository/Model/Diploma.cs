namespace CarrerCruising.GraduationTracker.Repository.Model
{
    public class Diploma : EntityBase
    {
        public Diploma(int Id) : base(Id)
        {
        }

        public int Credits { get; set; }
        public int[] Requirements { get; set; }

    }
}
