using VerifyTests;
using Xunit;

namespace Tests
{
    public class DerivedFromObject
    {
        [Fact]
        public void Works_when_no_failing_test_has_run_before()
        {
            new java.lang.Object();
        }

        [Fact]
        public void Fails_always()
        {
            new VerifySettings();
            new java.lang.Object();
        }
    }
}
