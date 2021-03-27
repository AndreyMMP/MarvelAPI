namespace MarvelAPI.Business.Models
{
    public class Thumbnail : Entity
    {
        public string Path { get; set; }
        public string Extension { get; set; }        
        public int CharacterInformationId { get; set; }
        public CharacterInformation CharacterInformation { get; set; }
    }
}
