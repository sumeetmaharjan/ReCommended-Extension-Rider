﻿using System.Threading.Tasks;

namespace Test
{
    internal class Execute
    {
        async Task AsyncIterator(IAsyncEnumerable<int> sequence)
        {
            aw{caret}ait foreach (var item in sequence) { }
        }
    }
}