﻿using Microsoft.JSInterop;

namespace MartWeb_Client.Helper
{
    public static class IJSRuntimeExtension
    {
        public static async ValueTask ToastrSuccess(this IJSRuntime jsRuntime, string message)
        {
            await jsRuntime.InvokeVoidAsync("ShowToastr", "success", message);
        }

        public static async ValueTask ToastrError(this IJSRuntime jsRuntime, string message)
        {
            await jsRuntime.InvokeVoidAsync("ShowToastr", "error", message);
        }

        public static async ValueTask ToastrWarning(this IJSRuntime jsRuntime, string message)
        {
            await jsRuntime.InvokeVoidAsync("ShowToastr" , "warning", message );
        }

        public static async ValueTask ToastrInfo(this IJSRuntime jsRuntime, string message)
        {
            await jsRuntime.InvokeVoidAsync("ShowToastr", "info", message);
        }

        public static async ValueTask Alert(this IJSRuntime jsRuntime, string icon, string message)
        {
            await jsRuntime.InvokeVoidAsync("ShowAlert", icon, message);
        }
    }
}
