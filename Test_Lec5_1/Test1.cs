using Lecture5_1;

namespace Test_Lec5_1;

using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public sealed class Test1
{
    [TestMethod]
    public void TestMethod1()
    {
        int[] list = [99, 2, 44, 13, 45, 25, 58];
        int[] result = [2, 13, 25, 44, 45, 58, 99];
        SortUtil.BubbleSort(list);
        CollectionAssert.AreEqual(list, result);
    }
}