using Microsoft.JSInterop;

namespace LearnBlazor.Helper
{
    public static class SweetAlert
    {
        public static async Task SweetMessageSuccess( this IJSRuntime _runtime, string message)
        {
            await _runtime.InvokeVoidAsync("alertSweet","success", message);
        }
        public static async Task SweetMessageError(this IJSRuntime _runtime, string message)
        {
            await _runtime.InvokeVoidAsync("alertSweet", "error", message);
        }
    }
}
