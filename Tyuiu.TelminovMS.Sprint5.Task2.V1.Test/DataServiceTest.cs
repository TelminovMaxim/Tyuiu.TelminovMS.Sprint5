using Tyuiu.TelminovMS.Sprint5.Task2.V1.Lib;

namespace Tyuiu.TelminovMS.Sprint5.Task2.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckValid()
        {
            DataService ds = new DataService();

            int[,] k = new int[3, 3] { { 2, 2, 3 }, { 2, 2, 3 },{ 1, 1, 2 } };

            var s = ds.SaveToFileTextData(k);

            string path = @"C:\Users\Максим\AppData\Local\Temp\OutPutFileTask1.csv";

            FileInfo fileInfo = new FileInfo(path);

            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
