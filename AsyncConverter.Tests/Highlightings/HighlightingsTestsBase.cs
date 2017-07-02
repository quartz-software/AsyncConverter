using System.IO;
using System.Linq;
using JetBrains.ReSharper.FeaturesTestFramework.Daemon;
using JetBrains.ReSharper.TestFramework;
using NUnit.Framework;

namespace AsyncConverter.Tests.Highlightings
{
    [TestFixture]
    [TestNetFramework46]
    public abstract class HighlightingsTestsBase : CSharpHighlightingTestBase
    {
        [TestCaseSource(nameof(FileNames))]
        public void Test(string fileName)
        {
            DoTestSolution(fileName);
        }

        protected abstract string Folder { get; }

        protected override string RelativeTestDataPath => "Highlightings\\" + Folder;

        protected TestCaseData[] FileNames()
        {
            return Directory
                .GetFiles(@"..\..\Test\Data\" + RelativeTestDataPath, "*.cs")
                .Select(x => new TestCaseData(Path.GetFileName(x)))
                .ToArray();
        }
    }
}