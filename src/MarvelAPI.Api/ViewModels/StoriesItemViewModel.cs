namespace MarvelAPI.Api.ViewModels
{
    public class StoriesItemViewModel
    {
        public int Id { get; set; }
        public string ResourceURI { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }        
        public StoriesViewModel Stories { get; set; }
    }
}
