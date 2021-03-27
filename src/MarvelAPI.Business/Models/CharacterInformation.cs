using System.Collections.Generic;

namespace MarvelAPI.Business.Models
{
    public class CharacterInformation : Entity
    {
        public string MarvelId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Modified { get; set; }
        public string ResourceURI { get; set; }        
        public int CharacterId { get; set; }
        public Character Character { get; set; }
        public IEnumerable<Url> Urls { get; set; }
        public Thumbnail Thumbnail { get; set; }
        public Comics Comics { get; set; }
        public Stories Stories { get; set; }
        public Events Events { get; set; }
        public Series Series { get; set; }
    }
}
