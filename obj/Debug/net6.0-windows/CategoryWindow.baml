   M S B A M L   `   `   `  ����E  AMVVMforWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:MVVMforWPF
MVVMforWPF  5   	   C&clr-namespace:MVVMforWPF.UserControlUIMVVMforWPF.UserControlUI  5   	       MVVMforWPF.CategoryWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:MVVMforWPF     5   	   5uc&clr-namespace:MVVMforWPF.UserControlUI     5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5
   	   _ [MaterialDesignThemes.Wpf, Version=4.6.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5        $��categoryWindow��5   	     � Title$  CategoryWindow��5	   	   $	��500��6    $	��400��6-      MaterialDesignBody#���   5   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	     
CategoryVM � DataContext# [ 5   	   .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      6   .+�5   
   � $��0��6   .+�5      +   %MVVMforWPF.UserControlUI.ControlBarUC  
 � Tag 6   �� *Title+	 �� ElementName$	 categoryWindow��6R   5      � 5    
   $��1��6   
������� 5!      �� 5"      $
��auto �6    60   �� 5#      $
��auto �6    60   �� 5$      6"   .+�5&      #  MaterialDesignThemes.Wpf.Card  $��0��6"   $��5q�5'   "   .��5(      �� $��5q�6   )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$

 Name��6%    % !MaterialDesignFloatingHintTextBox#��[ 5)      ��5*      �� *Name+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�5+        5,      $��1��6"   $��5q�5-   "   .��5.      � .+�5/      ��   MaterialDesignRaisedButton#��[ 6   $	��100��50       � ToolTip$/ )Resource name: MaterialDesignRaisedButton��51      $	��ADD��52      
���   �$��5q�54      ��55      �� *
AddCommand+�� 56      #��[ 6   $	��100��57      $/ )Resource name: MaterialDesignRaisedButton��58      $��UPDATE��59      
���   �$��5q�5;      ��5<      �� *UpdateCommand+�� 5=      #��[ 6   $	��100��5>      $/ )Resource name: MaterialDesignRaisedButton��5?      $��DELETE��5@      
���   �$��5q�5B      ��5C      �� *DeleteCommand+5D      5E        5G      $��2��6"   $��5q�5H   "   $��Stretch=�5I   "   .��5J      �� $
��Auto=�6   .��5K      �� ��6   �� *
Categories+ �� SelectedItem 5L      �� *
Category+$ OneWayToSource=� �� View 5M      �� 5N      .P�5O   "   �� $��#��61    �� DisplayMemberBinding 5P   1   �� *Id+6W   �� 5Q   "   $
��Name��61    5R   1   �� *Name+6Y   5S      5U      5V      5W      5X      5Y      5Z      