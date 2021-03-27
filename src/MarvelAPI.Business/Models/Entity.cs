using System.ComponentModel.DataAnnotations.Schema;

namespace MarvelAPI.Business.Models
{
    public abstract class Entity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
    }
}
