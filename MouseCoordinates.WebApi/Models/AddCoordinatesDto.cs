using AutoMapper;
using MouseCoordinates.Application.Common.Mapping;
using MouseCoordinates.Application.Coords.Commands.AddCoordinates;

namespace MouseCoordinates.WebApi.Models
{
    public class AddCoordinatesDto : IMapWith<AddCoordinatesCommand>
    {
        public List<CoordinateData> Coords { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<AddCoordinatesDto, AddCoordinatesCommand>()
                .ForMember(coordCommand => coordCommand.Coords,
                    opt => opt.MapFrom(coordDto => coordDto.Coords));
        }
    }
}
