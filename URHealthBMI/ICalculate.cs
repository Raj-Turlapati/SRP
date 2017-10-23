using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URHealth.Service.BMI
{
    public interface ICalculate
    {
        float WeightInKg{get; set;}
        float HeightInMeters { get; set;}
        float Calculate();
    }
}
