<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128644973/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2589)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/WpfApplication17/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/WpfApplication17/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/WpfApplication17/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/WpfApplication17/MainWindow.xaml.vb))
<!-- default file list end -->
# How to show/hide a custom button in an editor


<p><em><strong>Update:<br /></strong>Starting with version 10.2.10, you can use the ButtonInfo.Visibility property to hide/show a custom button.</em><br /><br />This sample illustrates how to show/hide a custom button in the ComboBoxEdit. Inherit from the ButtonInfo, and implement the ButtonInfoVisibility dependency property. Implement the ButtonInfo template, and bind the Button.Visibility property to the ButtonInfoVisibility property. We plan to implement this property: <a href="https://www.devexpress.com/Support/Center/p/S35955">S35955</a></p>

<br/>


