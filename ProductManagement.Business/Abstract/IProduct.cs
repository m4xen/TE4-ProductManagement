﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Business.Abstract
{
    public interface IProduct
    {
        string Name { get; set; }
        decimal Price { get; set; }
    }
}
