
using ITStudyGroup_sample01;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestMethod_HogeAdd_OK()
        {
            var result = Hoge.Add(1, 2);
            var expect = 3;

            Assert.True(expect == result,"1+2=3");

        }
        [Fact]
        public void TestMethod_HogeAdd_NG()
        {
            var result = Hoge.Add(1, 2);
            var expect = 4;

            Assert.False(expect == result, $"1+2は4じゃないはず.expect={expect},result={result}");

        }
    }
}