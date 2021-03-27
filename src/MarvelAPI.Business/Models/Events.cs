using System.Collections.Generic;

namespace MarvelAPI.Business.Models
{
    public class Events : Collection
    {              
        public int CharacterInformationId { get; set; }
        public CharacterInformation CharacterInformation { get; set; }
        public IEnumerable<EventsItem> Items { get; set; }
    }
}
