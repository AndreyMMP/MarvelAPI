using System.Collections.Generic;

namespace MarvelAPI.Business.Models
{
    public class Series : Collection
    {              
        public int CharacterInformationId { get; set; }
        public CharacterInformation CharacterInformation { get; set; }
        public IEnumerable<SeriesItem> Items { get; set; }
    }
}
