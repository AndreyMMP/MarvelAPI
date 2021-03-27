namespace MarvelAPI.Business.Models
{
    public class Character : Entity
    {
        public string Code { get; set; }
        public string Status { get; set; }
        public string Copyright { get; set; }
        public string AttributionText { get; set; }
        public string AttributionHTML { get; set; }        
        public string Etag { get; set; }
        /* EF Relation */
        public CharacterData CharacterData { get; set; }
    }
}
