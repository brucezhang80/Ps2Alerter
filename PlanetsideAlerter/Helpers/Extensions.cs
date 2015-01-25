﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetsideAlerter.Helpers
{
    public static class Extension
    {
        public static string ToServerName(this int value)
        {
            switch (value)
            {
                case 25:
                    return "Briggs";
                case 19:
                    return "Jaeger";
                case 10:
                    return "Miller";
                case 1:
                    return "Connery";
                case 13:
                    return "Cobalt";
                case 17:
                    return "Emerald";
                default:
                    return "Vanu GAYTRAIN";
            }
        }

        public static string ToContinentName(this int value)
        {
            switch (value)
            {
                case 1:
                    return "Indar";
                case 2:
                    return "Esamir";
                case 3:
                    return "Amerish";
                case 4:
                    return "Hossin";
                default:
                    return "I have absolutely zero matches in Tinder";
            }
        }

        public static string ToContinentMessage(this int value)
        {
            switch (value)
            {
                case 1:
                    return "SEEING GREEN";
                case 2:
                    return "COLD WAR";
                case 3:
                    return "MARSH MADNESS";
                case 4:
                    return "FEELING THE HEAT";
                default:
                    return "I have absolutely zero matches in Tinder";
            }
        }
    }
}
