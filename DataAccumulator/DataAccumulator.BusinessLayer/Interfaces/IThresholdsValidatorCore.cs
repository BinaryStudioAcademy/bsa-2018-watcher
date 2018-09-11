using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DataAccumulator.Shared.Interfaces;

namespace DataAccumulator.BusinessLayer.Interfaces
{
    public interface IThresholdsValidatorCore<TDto> where TDto : ICollectedDataDto
    {
        Task Validate(TDto dataDto);
    }
}
