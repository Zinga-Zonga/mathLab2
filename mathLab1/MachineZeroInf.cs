using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathLab1
{
    internal class MachineZeroInf
    {
        //Обычная точность
        public float GetMachineZero(float n)
        {
            float machZero = n;
            while(machZero / 2 != 0)
            {
                machZero /= 2;
            }
            return machZero;
        }
       //Повышенная точность
        public double GetMachineZero(double n)
        {
            double machZero = n;
            while (machZero / 2 != 0)
            {
                machZero /= 2;
                
            }
            return machZero;
        }
        public double GetMachineInf(double factor)
        {
            double machInf = 1;
            int iteration = 0;
            while (!double.IsInfinity(machInf * 2))
            {
                machInf *= 2;
                iteration++;
            }
            return machInf;
        }
        public float GetMachineInf(float factor)
        {
            float machInf = 1f;
            int iteration = 0;
            while (!double.IsInfinity(machInf * 2))
            {
                machInf *= 2;
                iteration++;
            }
            return machInf;
        }
    }
}
