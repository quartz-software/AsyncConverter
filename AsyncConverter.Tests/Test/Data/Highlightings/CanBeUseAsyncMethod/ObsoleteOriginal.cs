﻿using System;
using System.Threading.Tasks;

namespace AsyncConverter.Tests.Test.Data.FixReturnValueToTaskTests
{
    public class Class
    {
        public async Task TestAsync()
        {
            await Task.Delay(1000).ConfigureAwait(false);
            Method();
        }

        [Obsolete]
        public void Method()
        {
        }

        public Task MethodAsync()
        {
            return Task.CompletedTask;
        }
    }
}
