   M S B A M L   `   `   `  ����P  LFUMiniHotelManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:FUMiniHotelManagementFUMiniHotelManagement  5      -    'FUMiniHotelManagement.BookingManagement   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:FUMiniHotelManagement     5      -   5          N� Title$  BookingManagement��5	       � 	Resources 5       �� Source�� 5   
   $ StyleResource.xaml?�6   %    .��5      �  � RowDefinitions 5   
   �� 5      $��80 �6   �� 5      $��* �6   .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��* �6#   .+�5      �� -   5         ��Name$ 	cbxFilter��5   �   $
��Bold"�6   
����� �$��Center=�6D   $��Center=�6f   $��12(�6�   $��40��6�   $��0��6�   $
��Left=�6�   $	��150��6�   6  �� 5       -   5         ��Name$ 	btnDetail��5    r   $��Right=�6   $
��20 0q�61   $��1��6?      	btnStyle1#��[  6O   $��Show Detail��6�   6�   5#      &   System.Windows.Controls.DataGrid  5%   
   -   5          Name$ 
dgvDisplay��5%   0   $��0��6   $��1��6#      AutoGenerateColumns$ False��6D   	   CanUserAddRows$	 False��6`   
   
IsReadOnly$

 True��6w      Columns 5&      0  *System.Windows.Controls.DataGridTextColumn  5'      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6%      Header$ BookingReservationId��6/   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6M   �� *BookingReservationId+  5(      $ * 6%   $ BookingDate��6/    6D   �� *BookingDate+  5)      $ * 6%   $ 
TotalPrice��6/    6C   �� *
TotalPrice+  5*      $ * 6%   $ Customer��6/    6A   �� *Customer.CustomerFullName+  5+      $ * 6%   $ Status��6/    6?   �� *Status+5-      5/      50      