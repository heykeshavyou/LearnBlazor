using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace LearnBlazor.Helper
{
    public static class ToastR
    {
        public static async Task ToastRSuccess(this IJSRuntime _runtime,string message)
        {
            await _runtime.InvokeVoidAsync("showtoaster", "success", message);
        }
        public static async Task ToastRError(this IJSRuntime _runtime, string message)
        {
            await _runtime.InvokeVoidAsync("showtoaster", "error", message);
        }
        public static async Task ToastRWarning(this IJSRuntime _runtime, string message)
        {
            await _runtime.InvokeVoidAsync("showtoaster", "warning", message);
        }
    }
}
