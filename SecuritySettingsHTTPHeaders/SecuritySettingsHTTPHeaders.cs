using System;
using TechTalk.SpecFlow;
using Xunit;

namespace Specs
{
    [Binding]
    public class SecuritySettingsHTTPHeaders
    {   
        
        [Then(@"the X-Frame-Options header is either SAMEORIGIN or DENY")]
        public void theXFrameOptionsHeaderIsEitherSAMEORIGINOrDENY()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the HTTP X-XSS-Protection header has the value: '(.*)'  ; mode=block")]
        public void theHTTPXXSSProtectionHeaderHasTheValue1ModeBlock()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the Strict-Transport-Security header is set")]
        public void theStrictTransportSecurityHeaderIsSet()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the Access-Control-Allow-Origin header must not be: *")]
        public void theAccessControlAllowOriginHeaderMustNotBe()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the HTTP X-Content-Type-Options header has the value: nosniff")]
        public void theHTTPXContentTypeOptionsHeaderHasTheValueNosniff()
        {
            ScenarioContext.Current.Pending();
        }
        
    }
}
