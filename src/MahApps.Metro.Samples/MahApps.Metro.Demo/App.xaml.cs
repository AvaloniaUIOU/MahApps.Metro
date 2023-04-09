// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Windows;
using AvaloniaUI.Xpf.WinApiShim;

namespace MetroDemo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        public App()
        {
            WinApiShimSetup.AutoEnable();
            this.InitializeComponent();
        }
    }
}