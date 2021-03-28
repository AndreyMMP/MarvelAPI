namespace MarvelAPI.Api.ViewModels
{
    public class UrlViewModel
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Uri { get; set; }        
        public CharacterInformationViewModel CharacterInformation { get; set; }
    }
}
