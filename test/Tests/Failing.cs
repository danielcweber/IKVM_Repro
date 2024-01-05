using VerifyXunit;

using Xunit;

namespace Tests
{
    public class Failing : VerifyBase
    {
        public Failing() : base()
        {

        }

        [Fact]
        public void Always()
        {
            new java.lang.Object();
        }
    }
}
