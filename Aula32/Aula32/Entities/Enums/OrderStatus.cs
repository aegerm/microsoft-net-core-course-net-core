﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Aula32.Entities.Enums
{
    public enum OrderStatus : int
    {
        PENDING_PAYMENT = 0,
        PROCESSING = 1,
        SHIPPED = 2,
        DELIVERED = 3
    }
}