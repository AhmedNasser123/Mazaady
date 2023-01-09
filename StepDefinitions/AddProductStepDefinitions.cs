using Mazaady_task.Base;
using Mazaady_task.PageObject;
using Xunit;

namespace Mazaady_task.StepDefinitions
{
    [Binding]
    public class AddProductStepDefinitions : BasePage
    {
        AddProuduct addProuduct = new AddProuduct();
        data dt = new data();
        public AddProductStepDefinitions()
        {

        }

        [Given(@"that an User on the login page")]
        public void GivenThatAnUserOnTheLoginPage()
        {
            driver.Navigate().GoToUrl("https://staging.mazaady.com/login");
        }

        [When(@"he enter the following data:")]
        public void WhenHeenterTheFollowingData(Table tabledata)
        {
            //dynamic datatable = tabledata.CreateDynamicInstance();
            //addProuduct.EntersTheFollowingData(email: datatable.Email,password: datatable.Password);
            addProuduct.EntersTheFollowingData(email: dt.Email, password: dt.Password);
        }

        [Then(@"clicks on the login button")]
        public void ThenClicksOnTheLoginButton()
        {
            addProuduct.btn_Login.Click();
        }

        [Then(@"Appear home page")]
        public void ThenAppearHomePage()
        {
            Assert.True(addProuduct.Tab_Myprofile.Enabled);
        }

        [Given(@"choose from menu of profile pic add product")]
        public void GivenChooseFromMenuOfProfilePicAddProduct()
        {
            addProuduct.link_addprouduct.Click();
        }

        [Given(@"Select single product")]
        public void GivenSelectSingleProduct()
        {
            addProuduct.CheckSelectSingleProduct();
        }

        [When(@"fill all element including\(main image, auction details , policy\)")]
        public void WhenFillAllElementIncludingMainImageAuctionDetailsPolicy()
        {
            addProuduct.FillAllElementIncludingMainImageAuctionDetailsPolicy(AuctionName: dt.AuctionName, Quantity: dt.Quantity, AuctionDetails: dt.AuctionDetails, ExchangeAndReturnPolicy: dt.ExchangeAndReturnPolicy, file: dt.folderPath + dt.img);
        }

        [Then(@"choose selling type \(estimation value\)")]
        public void ThenChooseSellingTypeEstimationValue()
        {
            addProuduct.ChooseSellingTypeEstimationValue(InstantSale: dt.InstantSale, BidIncrementValue: dt.BidIncrementValue, startingbid: dt.startingbid, estimatedvalue: dt.estimatedvalue);
        }

        [Then(@"Click save")]
        public void ThenClickSave()
        {
            addProuduct.ClickSave();
        }
    }
}
