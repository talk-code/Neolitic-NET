﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Neolitic
{
    public interface IContextFactory
    {
		IExecutionContext CreateContext(IServiceInfo serviceInfo, Object contextCreationParams);
    }
}
