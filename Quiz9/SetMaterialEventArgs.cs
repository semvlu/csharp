﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uB10933001_Mid
{
    public class SetMaterialEventArgs:EventArgs
    {
        private string mType;
        public ShapeType.Material MType { get; set; }
    }
}
