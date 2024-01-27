using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using HomeApi.Contracts.Models.Devices;

namespace HomeApi.Contracts.Validation
{
    public class DeleteDeviceRequestValidator : AbstractValidator<DeleteDeviceRequest>
    {
        public DeleteDeviceRequestValidator() 
        { 
            //не нужно
            //RuleFor(x => x.Name).NotEmpty();
        }
    }
}
