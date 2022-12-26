﻿using System;

namespace Freedom.Utility.Helper
{
    public static class ThrowHelper
    {
        public static void ThrowIfNull(this object obj, string objName)
        {
            if (obj == null)
                throw new Exception(string.Format("{0} is null.", objName));
        }
    }
}