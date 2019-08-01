using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace OtaTicketing.Pages
{
    public class Index_Tests : OtaTicketingWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
