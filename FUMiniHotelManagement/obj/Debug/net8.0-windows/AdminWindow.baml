   M S B A M L   `   `   `  ����P  LFUMiniHotelManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:FUMiniHotelManagementFUMiniHotelManagement  5   	   '    !FUMiniHotelManagement.AdminWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:FUMiniHotelManagement     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ 
MainWindow��5	   	   $	��600��6   $
��1100��6)    � 	Resources 5
       �� Source�� 5   
   $ StyleResource.xaml?�6   %    .��5      �  � ColumnDefinitions 5   
   �� 5      $	��150 �6   �� 5      .+�5   
   �� -   5         ��Name$ NavBarContainer��5      $��0��6.   
����� �.+�5      ��  �� Orientation$ Vertical=�6   $��Center=�61   $��150px��6N   .+�5      �� -   5         ��Name$ btnDashboard��5   <      	btnStyle2#��[  6   $
��0 20q�6R   .��5      �� $��	Dashboard��6    $
��Wrap=�61    �� TextAlignment$ Center=�6E   5      �� 5      -   5        $ 
btnBooking��5   <   #��[  6   $
��0 20q�6P   .��5      �� $��Booking Management��6    $
��Wrap=�6:   $ Center=�6N   5      �� 5      -   5        $ btnCustomer��5   <   #��[  6   $
��0 20q�6Q   .��5      �� $��Customer Management��6    $
��Wrap=�6;   $ Center=�6O   5      �� 5      -   5        $ btnRoom��5   J   #��[  6   $��100px��6<   $
��0 20q�6[   $��40��6i   .��5       �� $��Room Management��6    $
��Wrap=�67   $ Center=�6K   5!      �� 5"      -   5        $ btnRoomType��5"   J   #��[  6   $��100px��6<   $
��0 20q�6_   $��40��6m   .��5#      �� $��Room Type Management��6    $
��Wrap=�6<   $ Center=�6P   5$      �� 5%      -   5        $ 	btnLogout��5%   J   #��[  6   $��100px��6<   $
��0 20q�6]   $��40��6k   .��5&      �� $��Logout��6!   $
��Wrap=�6/   $ Center=�6C   5'      �� 5(      -   5        $ btnQuit��5(   J   #��[  6   $��100px��6<   $
��0 20q�6[   $��40��6i   .��5)      �� $
��Quit��6!   $
��Wrap=�6-   $ Center=�6A   5*      5+      5,       � 5/   
   -	   5        	  �Name$	 
AdminFrame��5/   L   $��
10 0 10 10q�6   
�������$��1��6<   
  � NavigationUIVisibility$
 Hidden=�6`   51      52      