using System.ComponentModel.DataAnnotations;

namespace API.W.Movies.DAL.Models
{
    public class Category : AuditBase
    {
       
        public required string Name { get; set; }
    }
}
