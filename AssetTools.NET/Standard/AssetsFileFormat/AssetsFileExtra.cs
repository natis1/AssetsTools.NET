﻿using System.Collections.Generic;

namespace AssetsTools.NET
{
    public class AssetsFileExtra
    {
        public static bool HasName(uint type)
        {
            if (type > 0x122)
		        return false;
            if (type == 0x122)
                return true;
            if ((int)type > ~0x110) //-monos aren't limited to ~0x110 right?
		        return false;
            HashSet<uint> allowed = new HashSet<uint>
            {
                0x00, 0x06, 0x07, 0x16, 0x1B, 0x1C, 0x29, 0x33, 0x35, 0x3E, 0x3F,
                0x44, 0x45, 0x46, 0x48, 0x58, 0x5E, 0x60, 0x64, 0x6B, 0x71, 0x79,
                0x81, 0x83, 0x87, 0x89, 0x96, 0xA3, 0xA4, 0xA5, 0xAD, 0xB3, 0xBA,
                0xC0, 0xC8, 0xCD, 0xCF, 0xD8, 0xD9, 0xDB, 0xED, 0xFA, 0xFB, 0xFC
            };
            if (allowed.Contains(type))
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}