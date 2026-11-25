using Tyuiu.TelminovMS.Sprint5.Task3.V15.Lib;

namespace Tyuiu.TelminovMS.Sprint5.Task3.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckValid()
        {
            DataService ds = new DataService();

            var str = ds.SaveToFileTextData(5);

            string path = @"C:\Users\Максим\AppData\Local\Temp\OutPutFileTask3.bin";

            FileInfo fileInfo = new FileInfo(path);

            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
