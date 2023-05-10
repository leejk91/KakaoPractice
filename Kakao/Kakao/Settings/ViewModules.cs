using Jamesnet.Wpf.Controls;
using Kakao.Core.Names;
using Kakao.Friends.UI.Views;
using Kakao.Login.UI.Views;
using Prism.Ioc;
using Prism.Modularity;

namespace Kakao.Settings
{
    internal class ViewModules : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // 프리즘을 통해 UI객체를 등록한뒤 참조를 걸지않고 다른 뷰를 사용하겠다 선언
            // 등록하는 방법에는 RegisterSingleton, RegisterInstance 두가지 방법이 있는데
            // 싱글톤의 경우에는 사용할때 생성되기만 Instance는 이곳에 선언과 함께 생성
            containerRegistry.RegisterSingleton<IViewable, LoginContent>(ContentNameManager.Login);
            containerRegistry.RegisterSingleton<IViewable, FriendsContent>(ContentNameManager.Friends);
        }
    }
}
