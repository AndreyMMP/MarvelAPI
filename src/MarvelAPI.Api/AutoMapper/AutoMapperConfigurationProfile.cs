using AutoMapper;
using MarvelAPI.Api.ViewModels;
using MarvelAPI.Business.Models;

namespace MarvelAPI.Api.AutoMapper
{
    public class AutoMapperConfigurationProfile : Profile
    {
        public AutoMapperConfigurationProfile()
        {
            CreateMap<Character, CharacterViewModel>().ReverseMap();
            CreateMap<CharacterInformation, CharacterInformationViewModel>().ReverseMap();
            CreateMap<Url, UrlViewModel>().ReverseMap();
            CreateMap<Thumbnail, ThumbnailViewModel>().ReverseMap();
            CreateMap<Comics, ComicsViewModel>().ReverseMap();
            CreateMap<ComicsItem, ComicsItemViewModel>().ReverseMap();
            CreateMap<Stories, StoriesViewModel>().ReverseMap();
            CreateMap<StoriesItem, StoriesItemViewModel>().ReverseMap();
            CreateMap<Events, EventsViewModel>().ReverseMap();
            CreateMap<EventsItem, EventsItemViewModel>().ReverseMap();
            CreateMap<Series, SeriesViewModel>().ReverseMap();
            CreateMap<SeriesItem, SeriesItemViewModel>().ReverseMap();
        }
    }
}
