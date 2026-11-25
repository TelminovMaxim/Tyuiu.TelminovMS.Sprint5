using Tyuiu.TelminovMS.Sprint5.Task7.V12.Lib;

namespace Tyuiu.TelminovMS.Sprint5.Task7.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckValid()   
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint5\InPutDataFileTask7V12.txt";



            string s = ds.LoadDataAndSave(path);

            FileInfo fileInfo = new FileInfo(path);

            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    
    }
}
