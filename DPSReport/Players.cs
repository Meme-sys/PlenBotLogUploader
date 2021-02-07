﻿using System;

namespace PlenBotLogUploader.DPSReport
{
    public static class Players
    {
        public static string ResolveSpecName(int profession, int eliteSpec)
        {
            return Enum.IsDefined(typeof(EliteSpecs), eliteSpec) ? ((EliteSpecs)eliteSpec).ToString() : $"Base {(Professions)profession}";
        }
    }
}
