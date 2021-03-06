﻿using System;
using Exercism.CSharp.Output;

namespace Exercism.CSharp.Exercises.Generators
{
    public class Wordy : GeneratorExercise
    {
        protected override void UpdateTestMethod(TestMethod testMethod)
        {
            if (!(testMethod.Expected is int))
                testMethod.ExceptionThrown = typeof(ArgumentException);
        }
    }
}