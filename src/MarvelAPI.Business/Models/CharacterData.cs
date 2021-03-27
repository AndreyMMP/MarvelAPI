using System.Collections.Generic;

namespace MarvelAPI.Business.Models
{
    public class CharacterData : Entity
    {
        public string Offset { get; set; }
        public string Limit { get; set; }
        public string Total { get; set; }
        public string Count { get; set; }        

        /* EF Relation */
        public int CharacterId { get; set; }
        public Character Character { get; set; }
        public IEnumerable<CharacterInformation> CharacterInformations { get; set; }
    }
}
