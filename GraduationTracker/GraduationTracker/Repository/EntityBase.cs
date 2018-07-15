namespace CarrerCruising.GraduationTracker.Repository.Model
{
    public abstract class EntityBase
    {
        public EntityBase(int Id)
        {
            this.Id = Id;
        }
        public int Id { get; private set; }
    }
}
