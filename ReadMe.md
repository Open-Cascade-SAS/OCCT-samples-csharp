OCCT .NET sample
================== 

This sample demonstrates how to use OCCT libraries in <b>.NET</b> application written in **CSharp**
and using **Windows Forms** or **Windows Presentation Foundation** (WPF).

The connection between .NET and OCCT (C++) level is provided by proxy library **OCCProxy**, written in C++/CLI.
The proxy library contains a single *ref* class encapsulating OCCT viewer and providing the functionality to manipulate this viewer
and to import / export OCCT shapes from / to several supported CAD file formats (IGES, STEP, BREP).

The sample implements two approaches to the development of a user interface with .NET.
Both applications provide the same functionality as the standard OCCT Import/Export sample.
The first project is called *IE_WinForms* and uses Windows Forms for GUI.
The second application is called *IE_WPF_WinForms* and uses Windows Presentation Foundation.

Note a few important details:

- OCCT template class *NCollection_Haft* is used to encapsulate C++ class into a field of *ref* class.

- It is necessary to explicitly set the target platform for C# assemblies to *x86*
  in project **Properties - Build** to work consistently on 64-bit systems with OCCT libraries built in 32-bit mode.

- This sample demonstrates indirect method of wrapping C++ to C# using a manually created proxy library.
  There is an alternative method of wrapping individual OCCT classes to C# equivalents to make their full API available to a C# user
  and to let the code be programmed on C# level similarly to C++ one.
  See the description of **OCCT C# Wrapper** in **Advanced Samples and Tools** at
  http://www.opencascade.org/support/products/advsamples

- In WPF sample, **WinForms** control is used to encapsulate OCC viewer since WPF does not provide the necessary interface to embed OpenGL view.
  Other possible solution could be to render OpenGL scene in an off-screen buffer and to map it
  to WPF control as an image. That approach would allow using all WPF features to control the OCCT viewer.

Run *msvc.bat* to start MS Visual Studio for building the sample.
Note that project files are provided only for VS 2010, you can open them in
newer versions of Visual Studio the using automatic converter.

After conversion check option **Target framework** in the properties of C# projects
(tab **Application**) to make sure that it corresponds to the version set in
the properties of C++ projects (e.g. <b>.Net Framework 4.0</b> for VS 2010).

Run *run_winforms.bat* or *run_wpf.bat* to launch the corresponding sample.

Note that all batch scripts use the configuration defined in OCCT *custom.bat* file
as default; you can provide arguments specifying VS version, bitness, and mode to override these settings, e.g.:

	> msvc.bat vc10 win64 Debug

Direct3D .NET sample
==================

This sample demonstrates how to use OCCT and DirectX libraries in <b>.NET</b> application
written using **CSharp** and **Windows Presentation Foundation** (WPF).

The proxy library **D3DProxy** contains helper methods for rendering via DirectX.  

The user interface in this sample is based on Windows Presentation Foundation (WPF).
It has the same functionality as the standard OCCT Import/Export sample.
The project is called *IE_WPF_D3D*.

Run *msvc_D3D.bat* to start MS Visual Studio for building the sample.
Run *run_wpf-D3D.bat* to launch the corresponding sample.
