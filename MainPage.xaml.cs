using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using comimportthingy;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace safe_exit
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    /// 
    
    public sealed partial class MainPage : Page
    {
        /*[DllImport("combase.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int RoGetActivationFactory([MarshalAs(UnmanagedType.HString)] string activatableClassId, [In] ref Guid iid, [Out, MarshalAs(UnmanagedType.IInspectable)] out object factory);

        [ComImport, Guid("F5F769AD-60E8-483C-9E60-460535819AE7"), InterfaceType(ComInterfaceType.InterfaceIsIInspectable)]
        internal interface IDevelopmentKitPropertiesStatics
        {
            [MethodImpl(MethodImplOptions.InternalCall)]
            IAsyncAction EnableDevelopmentModeExAsync([In] bool enable, [In] bool deleteDevStorage);
        }
        public Task EnableDevelopmentModeExAsync(bool enable, bool deleteDevStorage)
        {
            Guid guidIDevelopmentKitPropertiesStatics = typeof(IDevelopmentKitPropertiesStatics).GUID;
            RoGetActivationFactory("Windows.Xbox.System.Internal.DevelopmentKit.DevelopmentKitProperties", ref guidIDevelopmentKitPropertiesStatics, out object tempclass);
            IDevelopmentKitPropertiesStatics statics = (IDevelopmentKitPropertiesStatics)tempclass;
            return statics.EnableDevelopmentModeExAsync(enable, deleteDevStorage).AsTask();
        }*/

        public MainPage()
        {
            this.InitializeComponent();
            //var a = EnableDevelopmentModeExAsync(false, false);
            //a.Wait();
            var temp = new comimportthingy.Class1();
            var cool = temp.EnableDevelopmentModeAsync(false).AsTask();
            cool.Wait();
        }
    }
}
