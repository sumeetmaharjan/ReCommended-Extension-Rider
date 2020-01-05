﻿using System.Collections.Generic;

namespace ReCommendedExtension.Tests.test.data
{
    internal sealed class UnconstrainedGenericClass<T>
    {
        private readonly ICollection<T> field;

        public UnconstrainedGenericClass(ICollection<T> parameter) => field = parameter;

        public T[] GetArray()
        {
            var array = new T[field.Count];

            var i = 0;
            foreach (var item in field)
            {
                array[i++] = item;
            }

            return array;
        }
    }
}