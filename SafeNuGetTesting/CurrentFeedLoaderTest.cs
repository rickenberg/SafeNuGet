using Microsoft.VisualStudio.TestTools.UnitTesting;
using Owasp.SafeNuGet.Unsafe;
using System.IO;

namespace Owasp.SafeNuGetTesting
{
    [TestClass]
    public class CurrentFeedLoaderTest
    {
        [TestMethod]
        public void TestLoad()
        {
            var stream = File.OpenRead(@"..\..\..\feed\unsafepackages.xml");
            var loader = new PackageListLoader();
            var packages = loader.LoadPackages(stream);
            Assert.IsTrue(packages.Count > 5);

        }
    }
}
