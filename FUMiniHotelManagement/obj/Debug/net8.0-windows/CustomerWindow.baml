   M S B A M L   `   `   `  ����P  LFUMiniHotelManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:FUMiniHotelManagementFUMiniHotelManagement  5   	   *    $FUMiniHotelManagement.CustomerWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:FUMiniHotelManagement     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ CustomerWindow��5	   	   $	��600��6    $
��1100��6-    � 	Resources 5
       �� Source�� 5   
   $ StyleResource.xaml?�6   %    .��5      �  � ColumnDefinitions 5   
   �� 5      $	��150 �6   �� 5      .+�5   
   �� -   5         ��Name$ NavBarContainer��5      $��0��6.   
����� �.+�5      ��  �� Orientation$ Vertical=�6   $��Center=�61   $��150px��6N   .+�5      �� -   5         ��Name$ btnRoom��5   <      	btnStyle2#��[  6   $
��0 20q�6M   .��5      �� $
��Home��6    $
��Wrap=�6,    �� TextAlignment$ Center=�6@   5      �� 5      -   5        $ 
btnProfile��5   <   #��[  6   $
��0 20q�6P   .��5      �� $��Profile��6    $
��Wrap=�6/   $ Center=�6C   5      �� 5      -   5        $ 
btnHistory��5   <   #��[  6   $
��0 20q�6P   .��5      �� $��Booking History��6    $
��Wrap=�67   $ Center=�6K   5      �� 5      -   5        $ 	btnLogout��5   J   #��[  6   $��100px��6<   $
��0 20q�6]   $��40��6k   .��5       �� $��Logout��6!   $
��Wrap=�6/   $ Center=�6C   5!      �� 5"      -   5        $ btnQuit��5"   J   #��[  6   $��100px��6<   $
��0 20q�6[   $��40��6i   .��5#      �� $
��Quit��6!   $
��Wrap=�6-   $ Center=�6A   5$      5%      5&       � 5)   
   -   5        	  �Name$	 CustomerFrame��5)   L   $��
10 0 10 10q�6   
�������$��1��6<   
  � NavigationUIVisibility$
 Hidden=�6c   5+      5,      