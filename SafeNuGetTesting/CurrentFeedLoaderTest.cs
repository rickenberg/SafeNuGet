using Microsoft.VisualStudio.TestTools.UnitTesting;
using Owasp.SafeNuGet.Unsafe;
using System.IO;
using System.Linq;

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

            Assert.IsTrue(packages.Any(p => p.Id == "NServiceBus"));
        }
    }
}
