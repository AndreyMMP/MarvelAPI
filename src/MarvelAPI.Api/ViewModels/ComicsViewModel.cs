using System.Collections.Generic;

namespace MarvelAPI.Api.ViewModels
{
    public class ComicsViewModel
    {
        public int Id { get; set; }
        public string Available { get; set; }
        public string CollectionURI { get; set; }
        public int CharacterInformationId { get; set; }
        public CharacterInformationViewModel CharacterInformation { get; set; }
        public IEnumerable<ComicsItemViewModel> Items { get; set; }
    }
}
