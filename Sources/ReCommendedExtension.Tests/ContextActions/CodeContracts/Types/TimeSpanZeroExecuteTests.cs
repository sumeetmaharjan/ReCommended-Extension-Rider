using JetBrains.ReSharper.FeaturesTestFramework.Intentions;
using JetBrains.ReSharper.TestFramework;
using NUnit.Framework;
using ReCommendedExtension.ContextActions.CodeContracts;

namespace ReCommendedExtension.Tests.ContextActions.CodeContracts.Types
{
    [TestNetFramework4]
    [TestFixture]
    public sealed class TimeSpanZeroExecuteTests : CSharpContextActionExecuteTestBase<TimeSpanZero>
    {
        protected override string ExtraPath => "";

        protected override string RelativeTestDataPath => @"ContextActions\CodeContracts\Types\TimeSpanZero";

        [Test]
        public void TestExecute() => DoNamedTest2();
    }
}