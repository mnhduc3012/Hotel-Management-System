   M S B A M L   `   `   `  ����P  LFUMiniHotelManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:FUMiniHotelManagementFUMiniHotelManagement  5   	   /    )FUMiniHotelManagement.BookingDetailWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:FUMiniHotelManagement     5   	   -   5          � Title$  BookingDetailWindow��5   	   $	��600��6%   $	��900��62   
������� � WindowStartupLocation$ CenterScreen=�6l   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��120 �6   �� 5      �� 5      $	��100 �6   .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      �� 5      .+�5      �� $��0��6    �� Orientation$ Vertical=�6)   .+�5      �� $ 
Horizontal=�6   .+�5      �� $��15(�6!   $
��Bold"�6/   
����� �$��7q�6\   $��Booking Reservation Id: ��6g   �� 5      -   5         ��Name$ txtBookingId��5   g   $��15(�6!   $
��Bold"�6/   
����� �$��7q�6\   6g   5      �� 5      $ 
Horizontal=�6   .+�5      �� $��15(�6    $
��Bold"�6.   
����� �$��7q�6[   $��Booking Date: ��6f   �� 5      -   5        $ txtBookingDate��5   g   $��15(�6!   $
��Bold"�6/   
����� �$��7q�6\   6g   5       �� 5!      $ 
Horizontal=�6   .+�5"      �� $��15(�6    $
��Bold"�6.   
����� �$��7q�6[   $��Booking Status: ��6f   �� 5#      -   5        $ 	txtStatus��5#   g   $��15(�6!   $
��Bold"�6/   
����� �$��7q�6\   6g   5$      5%      �� 5'      $��1��6   $ Vertical=�6)   .+�5(      �� $ 
Horizontal=�6   .+�5)      �� $��15(�6    $
��Bold"�6.   
����� �$��7q�6[   $��Customer FullName: ��6f   �� 5*      -   5        $ txtCustomerName��5*   g   $��15(�6!   $
��Bold"�6/   
����� �$��7q�6\   6g   5+      �� 5,      $ 
Horizontal=�6   .+�5-      �� $��15(�6    $
��Bold"�6.   
����� �$��7q�6[   $��Telephone: ��6f   �� 5.      -   5        $ txtPhone��5.   g   $��15(�6!   $
��Bold"�6/   
����� �$��7q�6\   6g   5/      �� 50      $ 
Horizontal=�6   .+�51      �� $��15(�6    $
��Bold"�6.   
����� �$��7q�6[   $��Email Address: ��6f   �� 52      -   5        $ txtEmail��52   g   $��15(�6!   $
��Bold"�6/   
����� �$��7q�6\   6g   53      54      55      &   System.Windows.Controls.DataGrid  57   
   -   5          Name$ 
dgvDisplay��57   !   $��1��6      AutoGenerateColumns$ False��65      CanUserAddRows$ False��6Q   	   
IsReadOnly$
	 True��6h   
   Columns
 58      0  *System.Windows.Controls.DataGridTextColumn  59      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6%      Header$ RoomId��6/   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   �� *RoomId+  5:      $ * 6%   $ 
RoomNumber��6/    6C   �� *Room.RoomNumber+  5;      $ * 6%   $ 	StartDate��6/    6B   �� *	StartDate+  5<      $ * 6%   $ EndDate��6/    6@   �� *	EndDate+  5=      $ * 6%   $ ActualPrice��6/    6D   �� *ActualPrice+  5>      $ * 6%   $ SubTotal��6/    6A   �� *
SubTotal+5@      � 5B   
   $��2��6    5C      �� 5D      $��2* �6#   �� 5E      $��* �6#   .+�5H      �� $ 
Horizontal=�6   $��1��62   .+�5I      �� $��Grand Total:��6   $��10q�60   
����� �$��20(�6W   $
��Bold"�6e   �� 5J      -	   5        $ txtGrandTotal��5J      $��10q�63   
����� �$��20(�6Z   $
��Bold"�6h   5K      5L      5M      5N      