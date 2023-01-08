using Mazaady_task.Base;
using Xunit;

namespace Mazaady_task.PageObject
{
    public class AddProuduct : BasePage
    {


        public AddProuduct()
        {

        }

        #region Find Elements

        [FindsBy(How = How.CssSelector, Using = "button.btn.btn-buy.continue")]
        IWebElement btn_submitcontinue; // زر الانتقال للخطوه التاليه 

        #region Login page 
        [FindsBy(How = How.Id, Using = "email")]
        IWebElement txt_Email;
        [FindsBy(How = How.Id, Using = "password")]
        IWebElement txt_password;
        [FindsBy(How = How.XPath, Using = "//*[@id=\"app\"]//*[@class=\"btn btn-lg btn-login btn-block\"]")]
        public IWebElement btn_Login;
        #endregion

        #region Home Page 
        [FindsBy(How = How.XPath, Using = "//*[@id=\"top-header-main\"]/div/div/div[2]/div/div/div[2]/a/span")]
        public IWebElement Tab_Myprofile;
        [FindsBy(How = How.XPath, Using = "//*[@id=\"top-header- main\"]/div/div/div[2]/div/div/div[2]/div/ul/li[5]/a")]
        public IWebElement link_addprouduct;
        #endregion

        #region Form Step 1 
        [FindsBy(How = How.Id, Using = "opt-single_product")]
        IWebElement checkbox_singleproduct;
        #endregion

        #region Form step 2
        [FindsBy(How = How.Name, Using = "title")]
        IWebElement txt_AuctionName;
        [FindsBy(How = How.XPath, Using = "//*[@id=\"vs3__combobox\"]/div[1]/input")]
        IWebElement dropdownlist_MainClassification;
        [FindsBy(How = How.XPath, Using = "//*[@id=\"vs4__combobox\"]/div[1]/input")]
        IWebElement dropdownlist_Subcategory;
        [FindsBy(How = How.Name, Using = "quantity")]
        IWebElement txt_Quantity;
        [FindsBy(How = How.Id, Using = "mceu_30")]
        IWebElement txt_AuctionDetails;
        [FindsBy(How = How.Id, Using = "mceu_65")]
        IWebElement txt_ExchangeAndReturnPolicy;
        [FindsBy(How = How.XPath, Using = "//input[@type='file']")]
        IWebElement BrowserUpload;
        #endregion

        #region Form Step 3 
        [FindsBy(How = How.Name, Using = "selling_type")]
        SelectElement dropdownlist_SellingType;
        [FindsBy(How = How.Name, Using = "value")]
        IWebElement txt_InstantSale;
        [FindsBy(How = How.Name, Using = "bid_increase")]
        IWebElement txt_bidincrease;
        [FindsBy(How = How.Name, Using = "starting_bid")]
        IWebElement txt_startingbid;
        [FindsBy(How = How.Name, Using = "estimated_value")]
        IWebElement txt_estimatedvalue;
        [FindsBy(How = How.Id, Using = "vue-button-to-open-date")]
        IWebElement txt_date;
        [FindsBy(How = How.XPath, Using = "//*[@id=\"mddtp-date__current\"]//*[@class=\"mddtp-picker__cell\"][1]")]
        IWebElement Popup_selectDate;
        [FindsBy(How = How.Id, Using = "mddtp-date__ok")]
        IWebElement btn_submitDate;
        [FindsBy(How = How.Id, Using = "vue-button-to-open-time")]
        IWebElement txt_Time;
        [FindsBy(How = How.Id, Using = "mddtp-time__ok")]
        IWebElement button_SubmitTime;
        [FindsBy(How = How.XPath, Using = "//*[@id=\"step-3\"]/span/div/div[9]/span/div[1]/label/span[2]")]
        IWebElement radiobutton_displayVoice;

        #endregion

        #region Form Step 4 
        [FindsBy(How = How.CssSelector, Using = "button.swal-button.swal-button--ok")]
        IWebElement POpup_ConfirmAdd;

        #endregion

        #endregion









        #region Action 

        #region insert login data
        public void EntersTheFollowingData(string email, string password)
        {
            txt_Email.SendKeys(email);
            txt_password.SendKeys(password);
        }
        #endregion

        #region Fill form step 1 
        public void CheckSelectSingleProduct()
        {
            if (checkbox_singleproduct.Selected) // لو منتج واحد تم اختياره 
            {
                btn_submitcontinue.Click(); // الضغط على الخطوه التاليه 
            }
            else
            {
                checkbox_singleproduct.Click(); // لو لم يتم اختيار  منتج واحد سيتم الضغط عليه 
                btn_submitcontinue.Click(); // الضغط على الخطوه التاليه 
            }
        }
        #endregion

        #region Fill form step 2 
        public void FillAllElementIncludingMainImageAuctionDetailsPolicy(string AuctionName, string Quantity, string AuctionDetails, string ExchangeAndReturnPolicy, string file)
        {
            txt_AuctionName.SendKeys(AuctionName); // ادخل اسم المزاد 
            dropdownlist_MainClassification.Click(); // الضغط على حقل التصنيف الرئيسي 
            action.KeyDown(Keys.ArrowDown + Keys.Enter).Build().Perform(); // اختيار اول تصنيف ثم الضغط على Enter
            dropdownlist_Subcategory.Click(); // الضغط على التصنيف الفرعى 
            action.KeyDown(Keys.ArrowDown + Keys.Enter).Build().Perform(); // اختيار اول تصنيف ثم الضغط على Enter
            txt_Quantity.SendKeys(Quantity); // ادخل الكميه 
            txt_AuctionDetails.SendKeys(AuctionDetails); // ادخل تفاصيل المزاد 
            txt_ExchangeAndReturnPolicy.SendKeys(ExchangeAndReturnPolicy); // ادخل سياسة الاستبدال والاسترجاع
            BrowserUpload.SendKeys(file); // ارفاق صوره 
            btn_submitcontinue.Click(); // الضغط على الخطوهخ التاليه 
        }
        #endregion

        #region Fill form step 3 
        public void ChooseSellingTypeEstimationValue(string InstantSale, string BidIncrementValue, string startingbid, string estimatedvalue)
        {
            dropdownlist_SellingType.SelectByValue("estimation_value"); // اختيار القيمه التقريبيه
            txt_InstantSale.SendKeys(InstantSale); // ادخل قيمة البيع الفورى 
            txt_bidincrease.SendKeys(BidIncrementValue); // ادخل قيمة الزياده 
            txt_startingbid.SendKeys(startingbid); // ادخل القيمه الابتدائيه للمزاد 
            txt_estimatedvalue.SendKeys(estimatedvalue); // ادخل القيمه التقريبيه للسلعه
            txt_date.Click(); // الضغط على حقل التاريخ 
            Popup_selectDate.Click(); // اختيار تاريخ غدا 
            btn_submitDate.Click(); // الموافقه على التاريخ 
            txt_Time.Click(); // الضغط على حقل الوقت 
            button_SubmitTime.Click(); // الضغط على موافقة الوقت 
            radiobutton_displayVoice.Click(); // اختيار عرض الصوت 
            btn_submitcontinue.Click();
        }
        #endregion

        #region Fill Form Step 4 
        public void ClickSave()
        {
            btn_submitcontinue.Click();
            Assert.True(POpup_ConfirmAdd.Enabled);
        }
        #endregion



        #endregion





    }
}


