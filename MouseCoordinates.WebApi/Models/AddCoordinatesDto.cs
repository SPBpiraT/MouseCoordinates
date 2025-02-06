using AutoMapper;
using MouseCoordinates.Application.Common.Mapping;
using MouseCoordinates.Application.Coords.Commands.AddCoordinates;

namespace MouseCoordinates.WebApi.Models
{
    public class AddCoordinatesDto : IMapWith<AddCoordinatesCommand>
    {
        public string X { get; set; }
        public string Y { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<AddCoordinatesDto, AddCoordinatesCommand>()
                .ForMember(coordCommand => coordCommand.X,
                    opt => opt.MapFrom(coordDto => coordDto.X))
                .ForMember(coordCommand => coordCommand.Y,
                    opt => opt.MapFrom(coordDto => coordDto.Y));
        }
    }
}
