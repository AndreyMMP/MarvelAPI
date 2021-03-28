using System.Collections.Generic;

namespace MarvelAPI.Api.ViewModels
{
    public class CharacterViewModel
    {
        public int Id { get; set; }
        public string Copyright { get; set; }
        public string AttributionText { get; set; }
        public string AttributionHTML { get; set; }
        public string Etag { get; set; }
        public IEnumerable<CharacterInformationViewModel> CharacterInformations { get; set; }
    }
}
