   M S B A M L   `   `   `  ����E  AMVVMforWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:MVVMforWPF
MVVMforWPF  5   	   C&clr-namespace:MVVMforWPF.UserControlUIMVVMforWPF.UserControlUI  5   	       MVVMforWPF.AuthorWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:MVVMforWPF     5   	   5uc&clr-namespace:MVVMforWPF.UserControlUI     5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5
   	   _ [MaterialDesignThemes.Wpf, Version=4.6.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5        $��authorWindow��5   	     � Title$  AuthorWindow��5	   	   $	��500��6   $	��700��6+      MaterialDesignBody#���   5   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	     AuthorVM � DataContext# [ 5   	   .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      6   .+�5   
   � $��0��6   .+�5      +   %MVVMforWPF.UserControlUI.ControlBarUC  
 � Tag 6   �� *Title+	 �� ElementName$	 authorWindow��6P   5      � 5    
   $��1��6   
������� 5"      �� 5#      $
��auto �6    60   �� 5$      $
��auto �6    60   �� 5%      6"   .+�5(      � $��0��6   $��5q�5)      .+�5*      �� $��5 5 15 5q�6   )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$

 Name��5+       % !MaterialDesignFloatingHintTextBox#��[ 5,      ��5-      �� *Name+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=��� 5.      $��5 5 15 5q�6   $
 Address��5/      #��[ 50      ��51      �� *	Address+$ PropertyChanged=�$ TwoWay=��� 52      $��5 5 15 5q�6   $
 Phone��53      #��[ 54      ��55      �� *Phone+$ PropertyChanged=�$ TwoWay=��� 56      $��5 5 15 5q�6   $
 Email��57      #��[ 58      ��59      �� *Email+$ PropertyChanged=�$ TwoWay=��� 5:      $��5 5 15 5q�6   $
 MoreInfo��5;      #��[ 5<      ��5=      �� *
MoreInfo+$ PropertyChanged=�$ TwoWay=�5>      #  MaterialDesignThemes.Wpf.Card  5?      $��1��6"   $��5q�5@   "   .��5A      � .+�5B      ��   MaterialDesignRaisedButton#��[ 6   $	��100��5C       � ToolTip$/ )Resource name: MaterialDesignRaisedButton��5D      $	��ADD��5E      
���   �$��5q�5G      ��5H      �� *
AddCommand+�� 5I      #��[ 6   $	��100��5J      $/ )Resource name: MaterialDesignRaisedButton��5K      $��UPDATE��5L      
���   �$��5q�5N      ��5O      �� *UpdateCommand+�� 5P      #��[ 6   $	��100��5Q      $/ )Resource name: MaterialDesignRaisedButton��5R      $��DELETE��5S      
���   �$��5q�5U      ��5V      �� *DeleteCommand+5W      5X        5Z      $��2��6"   $��5q�5[   "   $��Stretch=�5\   "   .��5]      �� $
��Auto=�6   .��5^      �� ��6   �� *	Authors+ �� SelectedItem 5_      �� *Author+$ OneWayToSource=� �� View 5`      �� 5a      .P�5b   "   �� $��#��61    �� DisplayMemberBinding 5c   1   �� *Id+6W   �� 5d   "   $
��Name��61    5e   1   �� *Name+6Y   �� 5f   "   $��Address��61    5g   1   �� *	Address+6\   �� 5h   "   $��Phone��61    5i   1   �� *Phone+6Z   �� 5j   "   $��Email��61    5k   1   �� *Email+6Z   �� 5l   "   $��MoreInfo��61    5m   1   �� *
MoreInfo+6]   5n      5p      5q      5r      5s      5t      5u      