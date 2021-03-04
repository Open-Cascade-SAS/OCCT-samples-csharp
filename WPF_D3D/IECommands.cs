// Copyright (c) 2021 OPEN CASCADE SAS
//
// This file is part of the examples of the Open CASCADE Technology software library.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE
// include required OCCT headers

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace IE_WPF_D3D
{
    public class IECommands
    {
        public static RoutedUICommand New { get; private set; }
        public static RoutedUICommand Close { get; private set; }
        public static RoutedUICommand Quit { get; private set; }
        public static RoutedUICommand About { get; private set; }
        public static RoutedUICommand AboutOk { get; private set; }

        static IECommands()
        {
            #region menu

            InputGestureCollection inputsNew = new InputGestureCollection();
            inputsNew.Add( new KeyGesture( Key.N, ModifierKeys.Control, "Ctrl + N" ) );
            New = new RoutedUICommand( "New", "New", typeof(IECommands), inputsNew );
            
            Close = new RoutedUICommand( "Close", "Close", typeof(IECommands) );

            InputGestureCollection inputsQuit = new InputGestureCollection();
            inputsQuit.Add( new KeyGesture( Key.F4, ModifierKeys.Alt, "Alt + F4" ) );
            Quit = new RoutedUICommand( "Quit", "Quit", typeof(IECommands), inputsQuit );

            InputGestureCollection inputsAbout = new InputGestureCollection();
            inputsAbout.Add( new KeyGesture( Key.F1 ) );
            About = new RoutedUICommand( "About", "About", typeof(IECommands), inputsAbout );

            #endregion

            #region aboutDlg
            InputGestureCollection inputsAboutOk = new InputGestureCollection();
            inputsAboutOk.Add( new KeyGesture( Key.Enter ) );
            AboutOk = new RoutedUICommand( "AboutOk", "AboutOk", typeof(IECommands), inputsAboutOk );
            #endregion
        }
    }
}
