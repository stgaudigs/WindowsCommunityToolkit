// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Threading.Tasks;
using Microsoft.Toolkit.Uwp.Connectivity;
using Windows.UI.Xaml.Controls;

namespace Microsoft.Toolkit.Uwp.SampleApp
{
    internal static class Tools
    {
        internal static async Task<bool> CheckInternetConnectionAsync()
        {
            if (!NetworkHelper.Instance.ConnectionInformation.IsInternetAvailable)
            {
                var dialog = new ContentDialog { Content = "Internet connection not detected. Please try again later.", CloseButtonText = "Close" };
                await dialog.ShowAsync();

                return false;
            }

            return true;
        }
    }
}
