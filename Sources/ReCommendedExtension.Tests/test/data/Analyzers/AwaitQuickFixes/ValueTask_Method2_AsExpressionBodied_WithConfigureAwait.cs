﻿using System;
using System.Threading.Tasks;

namespace ReCommendedExtension.Tests.test.data.Analyzers.AwaitQuickFixes
{
    public static class Test
    {
        public static async ValueTask Delay() => await Task.Delay(10);

        public static async ValueTask<T> Calc<T>(T x)
        {
            await Task.Delay(10);
            return x;
        }
    }

    public class AwaitForMethods
    {
        async{caret} ValueTask<int> Method2_AsExpressionBodied_WithConfigureAwait() => await Test.Calc(3).ConfigureAwait(false);
    }
}