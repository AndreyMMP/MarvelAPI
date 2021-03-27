namespace MarvelAPI.Business.Models
{
    public class Url : Entity
    {
        public string Type { get; set; }
        public string Uri { get; set; }
        public int CharacterInformationId { get; set; }
        public CharacterInformation CharacterInformation { get; set; }
    }
}
