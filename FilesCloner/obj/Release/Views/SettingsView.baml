   M S B A M L   `   `   `  ���� F  BFilesCloner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:FilesCloner.ViewsFilesCloner.Views  ^ ZCaliburn.Micro.Platform, Version=4.0.0.0, Culture=neutral, PublicKeyToken=8e5891231f2ed21fP=clr-namespace:Caliburn.Micro;assembly=Caliburn.Micro.PlatformCaliburn.Micro $    FilesCloner.Views.SettingsView   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     1localclr-namespace:FilesCloner.Views     Mcal=clr-namespace:Caliburn.Micro;assembly=Caliburn.Micro.Platform     D @ModernWpf, Version=0.9.4.0, Culture=neutral, PublicKeyToken=nullM IModernWpf.Controls, Version=0.9.4.0, Culture=neutral, PublicKeyToken=null,ui!http://schemas.modernwpf.com/2019   -   0  *ModernWpf.Controls.Primitives.WindowHelper    UseModernWindowStyle  . $��1q� &  "SystemControlPageTextBaseHighBrush#���    � SizeToContent$ WidthAndHeight=� � WindowStartupLocation$ CenterScreen=� � Title$ Settings��.��� $��Center=�$��Center=� � ColumnDefinitions �� $��20 ��� $
��auto ��� $
��auto ��� $
��auto ��� $��* ��� $
��auto ��� $
��auto ��� $
��auto ��� $��20 � � RowDefinitions �� $��20 ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $��* ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $��20 �.+��� $��1��$��1��Please Select Theme Mode:�� $��1��$��2��$
��0 10q� �� SelectedItem ��  �� Path$ SelectedTheme� �� Mode$ TwoWay=�	 �� UpdateSourceTrigger$	 PropertyChanged=����� $ ListOfThemes�$ TwoWay=�$	 PropertyChanged=��� -   
 ��Name$
 subHeaderText��$��1��$��5��$��3��$	��300��$
��0 20q�$
��Wrap=�About:�� ��FilesCloner is a simple program for copying specific files into main or subfolders. I wrote this app because i needed to copy all JPG and BMP files from projects in one computer to another without including other types of files.�� -   $
 License��$��1��$��5��$��4��$	��300��$
��0 20q�$
��Wrap=�License: MIT License�� Copyright (c) 2021 Fahd Daher�� ��Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions: The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.�� ��THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.�� $��1��$��5��$��5��$	��300��$
��0 20q�$
��Wrap=�Version: 0.3.4�� 