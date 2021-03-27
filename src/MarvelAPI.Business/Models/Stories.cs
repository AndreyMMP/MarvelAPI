using System.Collections.Generic;

namespace MarvelAPI.Business.Models
{
    public class Stories : Collection
    {                      
        public int CharacterInformationId { get; set; }
        public CharacterInformation CharacterInformation { get; set; }
        public IEnumerable<StoriesItem> Items { get; set; }
    }
}
