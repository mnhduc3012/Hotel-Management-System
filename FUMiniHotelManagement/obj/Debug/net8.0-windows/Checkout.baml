   M S B A M L   `   `   `  ����P  LFUMiniHotelManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:FUMiniHotelManagementFUMiniHotelManagement  5   	   $    FUMiniHotelManagement.Checkout   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:FUMiniHotelManagement     5   	     � Title$  Checkout��5   	   $
��Auto��6   $	��600��6(    � 
ResizeMode$ CanMinimize=�64   
������� � WindowStartupLocation$ CenterScreen=�6d    � 	Resources 5	       �� Source�� 5
   
   $ StyleResource.xaml?�6   %    .��5      �� .��5   
   �� .+�5      �� $3��-Choose start date and end date for each room:��6   
����� �$
��Bold"�6h   $��10q�6z   $��18(�6�   �� 5      -   5         ��Name$ RoomItemsControl��5      ��5      �� 5      .R�5      ��  �� Orientation$ Vertical=�6%   $��5q�6<   .+�5      �� $1��+-------------------------------------------��6(   $��15(�6[   $
��Bold"�6i   
����� �$��7q�6�   �� 5      $ 
Horizontal=�6)   .+�5   "   �� $��RoomNumber:��6,   $��15(�6?   $
��Bold"�6M   
����� �$��7q�6z   �� 5   "   $��15(�6H   $
��Bold"�6V   
����� �$��7q�6�   ��6,   �� *
RoomNumber+6�   5      �� 5      $ 
Horizontal=�6)   .+�5   "   �� $��RoomMaxCapacity:��6,   $��15(�6D   $
��Bold"�6R   
����� �$��7q�6   �� 5   "   $��15(�6M   $
��Bold"�6[   
����� �$��7q�6�   ��6,   �� *RoomMaxCapacity+6�   5      �� 5      $ 
Horizontal=�6)   .+�5   "   �� $��RoomPricePerDay:��6,   $��15(�6D   $
��Bold"�6R   
����� �$��7q�6   �� 5   "   $��15(�6M   $
��Bold"�6[   
����� �$��7q�6�   ��6,   �� *RoomPricePerDay+6�   5       �� 5!      $ 
Horizontal=�6)   .+�5"   "   �� $��RoomTypeName:��6,   $��15(�6A   $
��Bold"�6O   
����� �$��7q�6|   �� 5#   "   $��15(�6S   $
��Bold"�6a   
����� �$��7q�6�   ��6,   �� *RoomType.RoomTypeName+6�   5$      �� 5%      $ 
Horizontal=�6)   $��0,5,0,5q�6B   .+�5&   "   �� $��Start Date:��6,   $��15(�6?   $
��Bold"�6M   
����� �$��7q�6z   (  "System.Windows.Controls.DatePicker  5'   "   $	��100��6.      SelectedDate 6:   �� *	StartDate+ �� Mode$ OneWayToSource=�5(      �� 5)      $ 
Horizontal=�6)   $��0,5,0,5q�6B   .+�5*   "   �� $��	End Date:��6,   $��15(�6=   $
��Bold"�6K   
����� �$��7q�6x     5+   "   $	��100��6.    6:   �� *	EndDate+$ OneWayToSource=�5,      5-      5.      50      �� 51      -   5        	 ��Name$	 
btnConfirm��51   R      	btnStyle1#��[  6   $��Confirm Booking��68   $��10q�6   52      53      54      