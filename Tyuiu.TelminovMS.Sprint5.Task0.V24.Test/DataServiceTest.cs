using Tyuiu.TelminovMS.Sprint5.Task0.V24.Lib;

namespace Tyuiu.TelminovMS.Sprint5.Task0.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckValid()
        {
            DataService ds = new DataService();

            string path = @"C:\Users\Максим\AppData\Local\Temp\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);

            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);

        }
    }
}
