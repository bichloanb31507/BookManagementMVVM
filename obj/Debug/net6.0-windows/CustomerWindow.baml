   M S B A M L   `   `   `  ����E  AMVVMforWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:MVVMforWPF
MVVMforWPF  5   	   C&clr-namespace:MVVMforWPF.UserControlUIMVVMforWPF.UserControlUI  5   	       MVVMforWPF.CustomerWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:MVVMforWPF     5   	   5uc&clr-namespace:MVVMforWPF.UserControlUI     5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5
   	   _ [MaterialDesignThemes.Wpf, Version=4.6.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5        $��customerWindow��5   	     � Title$  CustomerWindow��5	   	   $	��500��6    $	��750��6-      MaterialDesignBody#���   5   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	     
CustomerVM � DataContext# [ 5   	   .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      6   .+�5   
   � $��0��6   .+�5      +   %MVVMforWPF.UserControlUI.ControlBarUC  
 � Tag 6   �� *Title+	 �� ElementName$	 customerWindow��6R   5      � 5    
   $��1��6   
������� 5"      �� 5#      $
��auto �6    60   �� 5$      $
��auto �6    60   �� 5%      6"   .+�5(      � $��0��6   $��5q�5)      .+�5*      �� $��5 5 15 5q�6   )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$

 Name��5+       % !MaterialDesignFloatingHintTextBox#��[ 5,      ��5-      �� *Name+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=��� 5.      $��5 5 15 5q�6   $
 Address��5/      #��[ 50      ��51      �� *	Address+$ PropertyChanged=�$ TwoWay=��� 52      $��5 5 15 5q�6   $
 Phone��53      #��[ 54      ��55      �� *Phone+$ PropertyChanged=�$ TwoWay=��� 56      $��5 5 15 5q�6   $
 Email��57      #��[ 58      ��59      �� *Email+$ PropertyChanged=�$ TwoWay=��� 5:      $��5 5 15 5q�6   $
 	More Info��5;      #��[ 5<      ��5=      �� *
MoreInfo+$ PropertyChanged=�$ TwoWay=�(  "System.Windows.Controls.DatePicker  5>      $��5 5 15 5q�6   $��Center=�60   $
��Left=�5?   -   $	��100��5@   -   $
 Contract Date��5A   -    ( $MaterialDesignFloatingHintDatePicker#��[ 5B   -      SelectedDate 5C      �� *ContractDate+$ PropertyChanged=�$ TwoWay=�5D      #  MaterialDesignThemes.Wpf.Card  5E      $��1��6"   $��5q�5F   "   .��5G      � .+�5H      ��   MaterialDesignRaisedButton#��[ 6   $	��100��5I       � ToolTip$/ )Resource name: MaterialDesignRaisedButton��5J      $	��ADD��5K      
���   �$��5q�5M      ��5N      �� *
AddCommand+�� 5O      #��[ 6   $	��100��5P      $/ )Resource name: MaterialDesignRaisedButton��5Q      $��UPDATE��5R      
���   �$��5q�5T      ��5U      �� *UpdateCommand+�� 5V      #��[ 6   $	��100��5W      $/ )Resource name: MaterialDesignRaisedButton��5X      $��DELETE��5Y      
���   �$��5q�5[      ��5\      �� *DeleteCommand+5]      5^        5`      $��2��6"   $��5q�5a   "   $��Stretch=�5b   "   .��5c      �� $
��Auto=�6   .��5d      �� ��6   �� *	Customers+ �� SelectedItem 5e      �� *
Customer+$ OneWayToSource=� �� View 5f      �� 5g      .P�5h   "   �� $��Id��61    �� DisplayMemberBinding 5i   1   �� *Id+6W   �� 5j   "   $
��Name��61    5k   1   �� *Name+6Y   �� 5l   "   $��Address��61    5m   1   �� *	Address+6\   �� 5n   "   $��Phone��61    5o   1   �� *Phone+6Z   �� 5p   "   $��Email��61    5q   1   �� *Email+6Z   �� 5r   "   $��	More Info��61    5s   1   �� *
MoreInfo+6]   �� 5t   "   $��Contract Date��61    5u   1   �� *ContractDate+ �� StringFormat$ 
dd/MM/yyyy��6|   5v      5x      5y      5z      5{      5|      5}      