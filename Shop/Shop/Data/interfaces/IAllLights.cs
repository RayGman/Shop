﻿using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.interfaces
{
    public interface IAllLights
    {
        IEnumerable<Light> Lights { get; }
        IEnumerable<Light> getFavLights { get; }
        Light getObjectLight(int lightId);
    }
}
