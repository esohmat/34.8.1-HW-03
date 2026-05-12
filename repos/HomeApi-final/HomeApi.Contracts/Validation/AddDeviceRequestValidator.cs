using System.Collections.Generic;
using System.Linq;
using FluentValidation;
using HomeApi.Contracts.Models.Devices;

namespace HomeApi.Contracts.Validation
{
    public class AddDeviceRequestValidator : AbstractValidator<AddDeviceRequest>
    {

        public AddDeviceRequestValidator() 
        {

            RuleFor(x => x.Name).NotEmpty(); 

            RuleFor(x => x.Manufacturer).NotEmpty();
            RuleFor(x => x.Model).NotEmpty();
            RuleFor(x => x.SerialNumber).NotEmpty();
            RuleFor(x => x.CurrentVolts).NotEmpty().InclusiveBetween(120, 220); // Проверим, что значение в заданном диапазоне
            RuleFor(x => x.GasUsage).NotNull();
            RuleFor(x => x.RoomLocation).NotEmpty().Must(BeSupported).WithMessage($"Please choose one of the following locations: {string.Join(", ", Values.ValidRooms)}");
        }
        
        /// <summary>
        ///  Метод кастомной валидации для свойства location
        /// </summary>
        private bool BeSupported(string location)
        {
            // Проверим, содержится ли значение в списке допустимых
            return Values.ValidRooms.Any(e => e == location);
        }
    }
}