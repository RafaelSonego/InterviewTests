namespace CarrerCruising.GraduationTracker.Repository.Model
{
    public abstract class EntityBase
    {
        public int Id { get; private set; }

        public EntityBase(int Id)
        {
            this.Id = Id;
        }

        public EntityBase()
        {

        }
    }
}
