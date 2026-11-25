using Tyuiu.TelminovMS.Sprint5.Task1.V22.Lib;

namespace Tyuiu.TelminovMS.Sprint5.Task1.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckValid()
        {
            DataService ds = new DataService();

            var str = ds.SaveToFileTextData(-5, 5);

            string path = @"C:\Users\Максим\AppData\Local\Temp\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);

            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
