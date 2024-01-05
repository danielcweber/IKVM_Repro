using VerifyXunit;

using Xunit;

namespace Tests
{
    public class DerivedFromVerifyBase : VerifyBase
    {
        public DerivedFromVerifyBase() : base()
        {

        }

        [Fact]
        public void Fails_always()
        {
            new java.lang.Object();
        }
    }
}
