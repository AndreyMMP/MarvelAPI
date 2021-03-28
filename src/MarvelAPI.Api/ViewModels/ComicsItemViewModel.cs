namespace MarvelAPI.Api.ViewModels
{
    public class ComicsItemViewModel
    {
        public int Id { get; set; }
        public string ResourceURI { get; set; }
        public string Name { get; set; }
        public ComicsViewModel Comics { get; set; }
    }
}
