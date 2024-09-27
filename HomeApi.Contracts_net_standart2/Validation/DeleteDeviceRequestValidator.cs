using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using HomeApi.Contracts_net_standart2.Models.Devices;

namespace HomeApi.Contracts_net_standart2.Validation
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
