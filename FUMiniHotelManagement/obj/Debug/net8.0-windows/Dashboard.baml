   M S B A M L   `   `   `  ����P  LFUMiniHotelManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:FUMiniHotelManagementFUMiniHotelManagement  5      %    FUMiniHotelManagement.Dashboard   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:FUMiniHotelManagement     5      -   5          N� Title$  	Dashboard��5	       � 	Resources 5       �� Source�� 5   
   $ StyleResource.xaml?�6   %    .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��80 �6   �� 5      $��* �6   �� 5      $	��100 �6   .+�5   
   �� $��0��6   $��0��6"    �� Orientation$ 
Horizontal=�62   $��Right=�6K   .+�5      �� $��From: ��6   $��Center=�6%   
����� �$��DemiBold"�6[   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ dpkFrom��5      $��30��6*   $	��100��66   $��Center=�6B   6f   �� 5      $
��To: ��6   $��Center=�6#   
����� �$��DemiBold"�6Y     5      -   5        $ dpkTo��5      $��30��6(   $	��100��64   $��Center=�6@   6d   �� 5      -   5         ��Name$ 	btnSearch��5   8      	btnStyle1#��[  6   $��Search��6c   $��30��6t   $	��100��6�   $��20 0 0 0q�6�   5      &   System.Windows.Controls.DataGrid  5"   
   -   5          Name$ 
dgvDisplay��5"   0   $��0��6   $��1��6#   	   AutoGenerateColumns$	 False��6D   
   CanUserAddRows$
 False��6`      
IsReadOnly$
 True��6w      Columns 5#      0  *System.Windows.Controls.DataGridTextColumn  5$      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6%      Header$ BookingReservationId��6/   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6M   �� *BookingReservationId+  5%      $ * 6%   $ 
RoomNumber��6/    6C   �� *Room.RoomNumber+  5&      $ * 6%   $ 	StartDate��6/    6B   �� *	StartDate+  5'      $ * 6%   $ EndDate��6/    6@   �� *	EndDate+  5(      $ * 6%   $ ActualPrice��6/    6D   �� *ActualPrice+  5)      $ * 6%   $ SubTotal��6/    6A   �� *
SubTotal+5+      �� 5-   
   $ 
Horizontal=�6   $��2��6.   $��Right=�6;   .+�5.      �� $��Total Revenue:��6   $��10q�6.   
����� �$��20(�6U   $
��Bold"�6c   �� 5/      -   5         ��Name$ txtTotal��5/      $��10q�6*   
����� �$��20(�6Q   $
��Bold"�6_   50      52      53      