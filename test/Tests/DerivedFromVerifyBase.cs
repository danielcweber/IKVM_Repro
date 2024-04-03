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
            new org.apache.commons.configuration2.BaseConfiguration();
        }
    }
}
