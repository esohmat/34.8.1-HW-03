using System.Collections.Generic;
using System.Linq;
using FluentValidation;
using HomeApi.Contracts.Models.Devices;

namespace HomeApi.Contracts.Validation
{
    /// <summary>
    /// Класс-валидатор запросов подключения
    /// </summary>
    public class DeleteDeviceRequestValidator : AbstractValidator<DeleteDeviceRequest>
    {
        /// <summary>
        /// Метод, конструктор, устанавливающий правила
        /// </summary>
        public DeleteDeviceRequestValidator() 
        {
            /* Зададим правила валидации */ 
            RuleFor(x => x.Name).NotEmpty(); // Проверим на null и на пустое свойство
        }
    }
}