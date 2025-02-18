using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessamentoImagens
{
    public class HSI
    {
        public float Hue { get; set; }
        public float Saturation { get; set; }
        public float Intensity { get; set; }

        public HSI(float hue, float saturation, float intensity)
        {
            Hue = hue;
            Saturation = saturation;
            Intensity = intensity;
        }
    }
}

