﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stigespill
{
    public class Ladder
    {
        public int PositionFrom { get; }
        public int PositionTo { get; }

        public Ladder( int positionFrom, int positionTo)
        {
            PositionFrom = positionFrom;
            PositionTo = positionTo;
        }
    }
}
