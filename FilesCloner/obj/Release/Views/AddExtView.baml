   M S B A M L   `   `   `  ���� F  BFilesCloner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:FilesCloner.ViewsFilesCloner.Views  ^ ZCaliburn.Micro.Platform, Version=4.0.0.0, Culture=neutral, PublicKeyToken=8e5891231f2ed21fP=clr-namespace:Caliburn.Micro;assembly=Caliburn.Micro.PlatformCaliburn.Micro "    FilesCloner.Views.AddExtView   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     1localclr-namespace:FilesCloner.Views     Mcal=clr-namespace:Caliburn.Micro;assembly=Caliburn.Micro.Platform     D @ModernWpf, Version=0.9.4.0, Culture=neutral, PublicKeyToken=nullM IModernWpf.Controls, Version=0.9.4.0, Culture=neutral, PublicKeyToken=null,ui!http://schemas.modernwpf.com/2019   -   0  *ModernWpf.Controls.Primitives.WindowHelper    UseModernWindowStyle  . $��1q� &  "SystemControlPageTextBaseHighBrush#���    � SizeToContent$ WidthAndHeight=� � WindowStartupLocation$ CenterScreen=� � Title$ Extension Manager��.��� $��Center=�$��Center=� � ColumnDefinitions �� $��20 ��� $
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
��auto ��� $��20 �.+��� -    ��Name$ 	ListOfEXT��$��1��$��2��$��1��$��1q�$	��200��$	��300�� �� SelectedItem ��  �� Path$ SelectedExt�	 �� Mode$	 TwoWay=�
 �� UpdateSourceTrigger$
 PropertyChanged=��� $��1��$��2��$��2��$��0 10 0 0q�$��5q�$	��100������ $ 
NewExtText�$	 TwoWay=�$
 PropertyChanged=��� -    ��Name$ AddExt��$��1��$��3��$��0 15 0 5q�$��Center=�$	��100��.��Add�� -   $ DelExt��$��2��$��3��$��0 15 0 5q�$��Center=�$	��100��.��Delete