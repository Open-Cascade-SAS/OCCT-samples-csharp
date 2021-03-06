﻿// Copyright (c) 2021 OPEN CASCADE SAS
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
using System.Windows;
using System.Windows.Media;
using System.Windows.Interop;
using System.Runtime.InteropServices;

namespace IE_WPF_D3D
{
  /// <summary>
  /// Tool object for output OCCT rendering with Direct3D.
  /// </summary>
  class D3DViewer
  {
    /// <summary> Direct3D output image. </summary>
    private D3DImage myD3DImage = new D3DImage ();

    /// <summary> Direct3D color surface. </summary>
    private IntPtr myColorSurf;

    public OCCViewer Viewer;

    /// <summary> Creates new Direct3D-based OCCT viewer. </summary>
    public D3DViewer ()
    {
      myD3DImage.IsFrontBufferAvailableChanged
        += new DependencyPropertyChangedEventHandler (OnIsFrontBufferAvailableChanged);

      BeginRenderingScene ();
    }

    /// <summary> Creates new Direct3D-based OCCT viewer. </summary>
    private void OnIsFrontBufferAvailableChanged (object sender, DependencyPropertyChangedEventArgs e)
    {
      // If the front buffer is available, then WPF has just created a new
      // Direct3D device, thus we need to start rendering our custom scene
      if (myD3DImage.IsFrontBufferAvailable)
      {
        BeginRenderingScene ();
      }
      else
      {
        // If the front buffer is no longer available, then WPF has lost Direct3D
        // device, thus we need to stop rendering until the new device is created
        StopRenderingScene ();
      }
    }

    private bool myIsFailed = false;

    /// <summary> Initializes Direct3D-OCCT rendering. </summary>
    private void BeginRenderingScene ()
    {
      if (myIsFailed)
      {
        return;
      }

      if (myD3DImage.IsFrontBufferAvailable)
      {
        Viewer = new OCCViewer();

        if (!Viewer.InitViewer())
        {
          MessageBox.Show ("Failed to initialize OpenGL-Direct3D interoperability!",
            "Error", MessageBoxButton.OK, MessageBoxImage.Error);

          myIsFailed = true;
          return;
        }

        // Leverage the Rendering event of WPF composition
        // target to update the our custom Direct3D scene
        CompositionTarget.Rendering += OnRendering;
      }
    }

    /// <summary> Releases Direct3D-OCCT rendering. </summary>
    public void StopRenderingScene ()
    {
      // This method is called when WPF loses its Direct3D device,
      // so we should just release our custom Direct3D scene
      CompositionTarget.Rendering -= OnRendering;
      myColorSurf = IntPtr.Zero;
    }

    /// <summary> Performs Direct3D-OCCT rendering. </summary>
    private void OnRendering (object sender, EventArgs e)
    {
      UpdateScene ();
    }

    /// <summary> Performs Direct3D-OCCT rendering. </summary>
    private void UpdateScene ()
    {
      if (!myIsFailed
        && myD3DImage.IsFrontBufferAvailable
        && myColorSurf != IntPtr.Zero
        && (myD3DImage.PixelWidth != 0 && myD3DImage.PixelHeight != 0))
      {
        myD3DImage.Lock ();
        {
          // Update the scene (via a call into our custom library)
          Viewer.View.RedrawView ();

          // Invalidate the updated region of the D3DImage
          myD3DImage.AddDirtyRect(new Int32Rect(0, 0, myD3DImage.PixelWidth, myD3DImage.PixelHeight));
        }
        myD3DImage.Unlock ();
      }
    }

    /// <summary> Resizes Direct3D surfaces and OpenGL FBO. </summary>
    public void Resize (int theSizeX, int theSizeY)
    {
      if (!myIsFailed && myD3DImage.IsFrontBufferAvailable)
      {
        // Set the back buffer for Direct3D WPF image
        myD3DImage.Lock ();
        {
          myD3DImage.SetBackBuffer (D3DResourceType.IDirect3DSurface9, IntPtr.Zero);
          myColorSurf = Viewer.View.ResizeBridgeFBO (theSizeX, theSizeY);
          myD3DImage.SetBackBuffer (D3DResourceType.IDirect3DSurface9, myColorSurf);
        }
        myD3DImage.Unlock ();
      }
    }

    public D3DImage Image
    {
      get
      {
        return myD3DImage;
      }
    }
  }
}
