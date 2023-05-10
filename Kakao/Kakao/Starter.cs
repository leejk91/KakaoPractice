using System;

namespace Kakao
{
    internal class Starter
    {
        [STAThread]
        private static void Main(string[] args)
        {
            // Run이 Void 타입이 아니기 떄문에 _를 앞에 붙여 무시 처리
            _ = new App().Run();
        }
    }
}
