using System.Threading.Tasks;
using ELAP.Models.TokenAuth;
using ELAP.Web.Controllers;
using Shouldly;
using Xunit;

namespace ELAP.Web.Tests.Controllers
{
    public class HomeController_Tests: ELAPWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}