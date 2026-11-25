using Tyuiu.TelminovMS.Sprint5.Task6.V3.Lib;

namespace Tyuiu.TelminovMS.Sprint5.Task6.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V3.txt";

            FileInfo fileInfo = new FileInfo(path);

            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }

        [TestMethod]
        public void CheckCount()
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint5\InPutDataFileTask6V3.txt";
            int res = ds.LoadFromDataFile(path);
            int wait = 21;
            Assert.AreEqual(wait, res);
        }
    }
}
