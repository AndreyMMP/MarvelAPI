using System.Collections.Generic;

namespace MarvelAPI.Business.Models
{
    public class Comics : Collection
    {            
        public int CharacterInformationId { get; set; }
        public CharacterInformation CharacterInformation { get; set; }
        public IEnumerable<ComicsItem> Items { get; set; }
    }
}
