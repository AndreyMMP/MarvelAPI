using System.Collections.Generic;

namespace MarvelAPI.Business.Models
{
    public class Events : Entity
    {
        public string Available { get; set; }
        public string Returned { get; set; }
        public string CollectionURI { get; set; }        
        /* EF Relations */
        public int CharacterInformationId { get; set; }
        public CharacterInformation CharacterInformation { get; set; }
        public IEnumerable<Item> Items { get; set; }
    }
}
