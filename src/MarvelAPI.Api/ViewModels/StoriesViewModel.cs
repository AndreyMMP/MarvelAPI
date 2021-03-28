using System.Collections.Generic;

namespace MarvelAPI.Api.ViewModels
{
    public class StoriesViewModel
    {
        public int Id { get; set; }
        public string Available { get; set; }
        public string CollectionURI { get; set; }
        public CharacterInformationViewModel CharacterInformation { get; set; }
        public IEnumerable<StoriesItemViewModel> Items { get; set; }
    }
}
