using FluentValidation;
using FluentValidation.Validators;
using HomeApi.Contracts.Models.Rooms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeApi.Contracts.Validation
{
    public class EditRoomRequestValidator : AbstractValidator<EditRoomRequest>
    {
        public EditRoomRequestValidator() 
        {
            RuleFor(x => x.Name).NotEmpty().Must(BeSupported)
                            .WithMessage($"Please choose one of the following locations: {string.Join(", ", Values.ValidRooms)}");
            RuleFor(x => x.Area).GreaterThan(0);
            RuleFor(x => x.Voltage).InclusiveBetween(120, 220);
            RuleFor(x => x.GasConnected).NotNull();
        }
        private bool BeSupported(string location)
        {
            return Values.ValidRooms.Any(e => e == location);
        }
    }
}
