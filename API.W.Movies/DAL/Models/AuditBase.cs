namespace API.W.Movies.DAL.Models
{
    public class AuditBase
    {
        public virtual int id { get; set; }

        public virtual DateTime CreatedDate { get; set; }

        public virtual DateTime ModifiedDate { get; set; }
    }
}
