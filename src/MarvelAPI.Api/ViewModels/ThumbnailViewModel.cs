namespace MarvelAPI.Api.ViewModels
{
    public class ThumbnailViewModel
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public string Extension { get; set; }        
        public CharacterInformationViewModel CharacterInformation { get; set; }
    }
}
