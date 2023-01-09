using System.Reflection;

namespace Mazaady_task
{
    public class data
    {
        public data()
        {


        }


        public string


           Email = "test22@gmail.com",
            Password = "123456789",
        AuctionName = "test cars",
        Quantity = "10",
        AuctionDetails = "لتفاصيل الاصناف يرجى التواصل معنا على رقم ************* ",
        ExchangeAndReturnPolicy = "يرجى اتباع اللائحة العامه للمزاد",
        folderPath = $@"{Directory.GetParent(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)).Parent.Parent}",
         img = $@"\Resources\image.jpg",
        InstantSale = "500",
            BidIncrementValue = "400",
            startingbid = "300",
            estimatedvalue = "200";











    }
}
