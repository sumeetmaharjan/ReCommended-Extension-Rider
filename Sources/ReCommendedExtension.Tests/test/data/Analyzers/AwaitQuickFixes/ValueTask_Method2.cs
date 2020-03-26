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
        async{caret} ValueTask<int> Method2()
        {
            if (Environment.UserInteractive)
            {
                Console.WriteLine();
            }

            return await Test.Calc(LocalFunction());

            int LocalFunction() => 3;
        }
    }
}