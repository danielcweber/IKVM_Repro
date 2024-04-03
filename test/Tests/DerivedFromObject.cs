using System;
using VerifyTests;
using Xunit;

namespace Tests
{
    public class DerivedFromObject
    {
        [Fact]
        public void Works_when_no_failing_test_has_run_before()
        {
            new org.apache.commons.configuration2.BaseConfiguration();
        }

        [Fact]
        public void Fails_always()
        {
            new VerifySettings();
            new org.apache.commons.configuration2.BaseConfiguration();
        }

        [Fact]
        public void Fails_always_even_VerifySettings_is_not_even_constructed()
        {
            if (DateTime.Now.Month == 13)
                new VerifySettings();

            new org.apache.commons.configuration2.BaseConfiguration();
        }
    }
}
