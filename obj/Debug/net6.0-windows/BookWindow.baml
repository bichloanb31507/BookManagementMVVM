   M S B A M L   `   `   `  ����E  AMVVMforWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:MVVMforWPF
MVVMforWPF  5   	   C&clr-namespace:MVVMforWPF.UserControlUIMVVMforWPF.UserControlUI  5   	       MVVMforWPF.BookWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:MVVMforWPF     5   	   5uc&clr-namespace:MVVMforWPF.UserControlUI     5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5
   	   _ [MaterialDesignThemes.Wpf, Version=4.6.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5        $��authorWindow��5   	     � Title$  
BookWindow��5	   	   $	��500��6   $	��820��6)      MaterialDesignBody#���   5   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    
 BookVM � DataContext# [ 5   	   .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      6   .+�5   
   � $��0��6   .+�5      +   %MVVMforWPF.UserControlUI.ControlBarUC  
 � Tag 6   �� *Title+	 �� ElementName$	 authorWindow��6P   5      � 5    
   $��1��6   
������� 5"      �� 5#      $
��auto �6    60   �� 5$      $
��auto �6    60   �� 5%      6"   .+�5(      � $��0��6   $��5q�5)      .+�5*      �� $��5 5 15 5q�6   )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 Id��5+       % !MaterialDesignFloatingHintTextBox#��[ 5,      ��5-      �� *Id+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=��� 5.      $��5 5 15 5q�6   $

 Name��5/      #��[ 50      ��51      �� *Name+$ PropertyChanged=�$ TwoWay=��� 52      $
 Author��6   $��5 5 15 5q�53       �� DisplayMemberPath$
 Name��55       �� 
IsEditable$
 True��57       & "MaterialDesignFloatingHintComboBox#��[ 58      ��54      �� *	Authors+ �� SelectedValue 56      �� *Author+$ PropertyChanged=�$ TwoWay=�5:      �� 5;      $
 Category��6   $��5 5 15 5q�5<      $
 Name��5>      $
 True��5@      #��[ 5A      ��5=      �� *
Categories+ 5?      �� *
Category+$ PropertyChanged=�$ TwoWay=�5C      �� 5D      $
 Supplier��6   $��5 5 15 5q�5E      $
 Name��5G      $
 True��5I      #��[ 5J      ��5F      �� *	Suppliers+ 5H      �� *
Supplier+$ PropertyChanged=�$ TwoWay=�5L      �� 5M      $��5 5 15 5q�6   $
 Publishing Year��5N      #��[ 5O      ��5P      �� *PublishingYear+$ PropertyChanged=�$ TwoWay=��� 5Q      $��5 5 15 5q�6   $
 Number Of Pages��5R      #��[ 5S      ��5T      �� *NumberOfPages+$ PropertyChanged=�$ TwoWay=�5U      #  MaterialDesignThemes.Wpf.Card  5V      $��1��6"   $��5q�5W   "   .��5X      � .+�5Y      ��   MaterialDesignRaisedButton#��[ 6   $	��100��5Z       � ToolTip$/ )Resource name: MaterialDesignRaisedButton��5[      $	��ADD��5\      
���   �$��5q�5^      ��5_      �� *
AddCommand+�� 5`      #��[ 6   $	��100��5a      $/ )Resource name: MaterialDesignRaisedButton��5b      $��UPDATE��5c      
���   �$��5q�5e      ��5f      �� *UpdateCommand+�� 5g      #��[ 6   $	��100��5h      $/ )Resource name: MaterialDesignRaisedButton��5i      $��DELETE��5j      
���   �$��5q�5l      ��5m      �� *DeleteCommand+5n      5o        5q      $��2��6"   $��5q�5r   "   $��Stretch=�5s   "   .��5t      �� $
��Auto=�6   .��5u      �� ��6   �� *Books+ �� SelectedItem 5v      �� *Book+$ OneWayToSource=� �� View 5w      �� 5x      .P�5y   "   �� $��Id��61    �� DisplayMemberBinding 5z   1   �� *Id+6W   �� 5{   "   $
��Name��61    5|   1   �� *Name+6Y   �� 5}   "   $��Author��61    5~   1   �� *Author.Name+6`   �� 5   "   $��Category��61    5�   1   �� *Category.Name+6b   �� 5�   "   $��Supplier��61    5�   1   �� *Supplier.Name+6b   �� 5�   "   $��Publishing Year��61    5�   1   �� *PublishingYear+6c   �� 5�   "   $��Number Of Pages��61    5�   1   �� *NumberOfPages+6b   5�      5�      5�      5�      5�      5�      5�      