<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128658348/21.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T211373)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WPF Dock Layout Manager - Use Services That Implement the IDocumentManagerService Interface

Our <a href="https://documentation.devexpress.com/WPF/CustomDocument15112.aspx">MVVM Framework</a> includes a the following services that implement the <a href="https://documentation.devexpress.com/WPF/clsDevExpressMvvmIDocumentManagerServicetopic.aspx">IDocumentManagerService</a> interface:<br> 1. <a href="https://documentation.devexpress.com/WPF/CustomDocument18275.aspx">DockingDocumentUIService</a> <br>2. <a href="https://documentation.devexpress.com/WPF/CustomDocument18172.aspx">FrameDocumentUIService</a> <br>3. <a href="https://documentation.devexpress.com/WPF/CustomDocument18173.aspx">TabbedDocumentUIService</a> <br>4. <a href="https://documentation.devexpress.com/WPF/CustomDocument18174.aspx">WindowedDocumentUIService</a> <br>5. <a href="https://documentation.devexpress.com/WPF/CustomDocument114043.aspx">TabbedWindowDocumentUIService</a>

![image](https://user-images.githubusercontent.com/12169834/174018853-908d505f-63df-4de7-b1bc-330ad1331490.png)

<!-- default file list -->
## Files to Look At:

* [MainWindow.xaml](./CS/DXDocumentUIServiceSample/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/DXDocumentUIServiceSample/MainWindow.xaml))
* [DetailedView.xaml](./CS/DXDocumentUIServiceSample/View/DetailedView.xaml) (VB: [DetailedView.xaml](./VB/DXDocumentUIServiceSample/View/DetailedView.xaml))
* [MainView.xaml](./CS/DXDocumentUIServiceSample/View/MainView.xaml) (VB: [MainView.xaml](./VB/DXDocumentUIServiceSample/View/MainView.xaml))
* [MainViewModel.cs](./CS/DXDocumentUIServiceSample/ViewModel/MainViewModel.cs) (VB: [MainViewModel.vb](./VB/DXDocumentUIServiceSample/ViewModel/MainViewModel.vb))
* [UserViewModel.cs](./CS/DXDocumentUIServiceSample/ViewModel/UserViewModel.cs) (VB: [UserViewModel.vb](./VB/DXDocumentUIServiceSample/ViewModel/UserViewModel.vb))
<!-- default file list end -->

## Documentation

- [MVVM Support - Bind to a Collection of Dock Panels](https://docs.devexpress.com/WPF/11386/controls-and-libraries/layout-management/dock-windows/bind-to-a-collection-of-dock-panels#tabbed-panels-in-document-group)

## More Examples

- [WPF Dock Layout Manager - Bind the View Model Collection with IMVVMDockingProperties](https://github.com/DevExpress-Examples/wpf-docklayoutmanager-bind-view-model-collection-with-IMVVMDockingProperties)
- [WPF Dock Layout Manager - Bind the View Model Collection with LayoutAdapters](https://github.com/DevExpress-Examples/wpf-docklayoutmanager-bind-view-model-collection-with-layoutadapters)
- [WPF Dock Layout Manager - Populate a DockLayoutManager LayoutGroup with the ViewModels collection](https://github.com/DevExpress-Examples/wpf-docklayoutmanager-display-viewmodels-collection-in-layoutgroup)
