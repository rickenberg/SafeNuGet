using Microsoft.VisualStudio.TestTools.UnitTesting;
using Owasp.SafeNuGet;

namespace Owasp.SafeNuGetTesting
{
    [TestClass]
    public class PackageVersionTest
    {
        private PackageVersion _packageVersion;
        private const string Version = "2.0.0";
        private const string PriorVersion = "1.0.0";
        private const string EqualVersion = "2.0.0";

        [TestInitialize]
        public void SetUp()
        {
            _packageVersion = new PackageVersion(Version);
        }

        [TestMethod]
        public void GetHashCodeTest()
        {
            var result = _packageVersion.GetHashCode();
            Assert.IsTrue(result.NotNull());
        }
        [TestMethod]
        public void EqualsTest ()
        {
            var result = _packageVersion.Equals(new PackageVersion(Version));
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void  GreaterThanOperatorTest()
        {
            var priorVersionPackage = new PackageVersion(PriorVersion);
            var result = _packageVersion > priorVersionPackage;
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void LessThanOperatorTest()
        {
            var priorVersionPackage = new PackageVersion(PriorVersion);
            var result =   priorVersionPackage < _packageVersion;
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void LessorEqualOperatorTest()
        {
            var priorVersionPackage = new PackageVersion(EqualVersion);
            var result = priorVersionPackage <= _packageVersion;
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void GreaterorEqualOperatorTest()
        {
            var priorVersionPackage = new PackageVersion(EqualVersion);
            var result = _packageVersion >= priorVersionPackage;
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void EqualOperatorTest()
        {
            var priorVersionPackage = new PackageVersion(EqualVersion);
            var result = _packageVersion == priorVersionPackage;
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void DifferentOperatorTest()
        {
            var priorVersionPackage = new PackageVersion(PriorVersion);
            var result = _packageVersion != priorVersionPackage;
            Assert.IsTrue(result);
        }
    }
}
