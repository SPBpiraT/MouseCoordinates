using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MouseCoordinates.Application.Coords.Commands.AddCoordinates;
using MouseCoordinates.WebApi.Models;

namespace MouseCoordinates.WebApi.Controllers
{
    public class MouseTrackController : BaseController
    {
        private readonly IMapper _mapper;

        public MouseTrackController(IMapper mapper)
        {
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> Add([FromBody] AddCoordinatesDto createMessageDto)
        {
            var command = _mapper.Map<AddCoordinatesCommand>(createMessageDto);
            var messageId = await Mediator.Send(command);
            return Ok(messageId);
        }
    }
}
