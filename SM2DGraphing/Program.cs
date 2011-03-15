﻿// 
// Monobjc : a .NET/Objective-C bridge
// Copyright (C) 2007-2009  Laurent Etiemble
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301  USA
// 
using System;
using Monobjc.AppKit;
using Monobjc.Foundation;

namespace Monobjc.Samples.SM2DGraphing
{
    internal class Program
    {
        private static void Main(String[] args)
        {
            ObjectiveCRuntime.LoadFramework("Cocoa");
            ObjectiveCRuntime.LoadFramework("SM2DGraphView");
            ObjectiveCRuntime.Initialize();

            NSApplication.Bootstrap();
            NSApplication.LoadNib("GraphingAppMain.nib");
            NSApplication.RunApplication();
        }
    }
}