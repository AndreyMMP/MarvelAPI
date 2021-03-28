namespace MarvelAPI.Api.ViewModels
{
    public class EventsItemViewModel
    {
        public int Id { get; set; }
        public string ResourceURI { get; set; }
        public string Name { get; set; }
        public EventsViewModel Events { get; set; }
    }
}
