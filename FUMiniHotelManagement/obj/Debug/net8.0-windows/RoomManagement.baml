   M S B A M L   `   `   `  ����P  LFUMiniHotelManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:FUMiniHotelManagementFUMiniHotelManagement  5      *    $FUMiniHotelManagement.RoomManagement   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:FUMiniHotelManagement     5      -   5          N� Title$  RoomManagement��5	       � 	Resources 5       �� Source�� 5   
   $ StyleResource.xaml?�6   %    .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $	��150 �6    � RowDefinitions 5   
   �� 5      $��80 �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��6"    �� Orientation$ 
Horizontal=�62   $��Right=�6K   .+�5      �� $��From: ��6   $��Center=�6%   
����� �$��DemiBold"�6[   �� 5      -   5         ��Name$ txtMin��5      $��30��6&   $	��100��62   $��Center=�6>   6b   �� 5      $
��To: ��6   $��Center=�6#   
����� �$��DemiBold"�6Y   �� 5      -   5        $ txtMax��5      $��30��6&   $	��100��62   $��Center=�6>   6b   �� 5      -   5         ��Name$ 	btnSearch��5   8      	btnStyle1#��[  6   $��Search by price��6c   $��30��6}   $	��100��6�   $��20 0 0 0q�6�   5      &   System.Windows.Controls.DataGrid  5"   
   -   5          Name$ 
dgvDisplay��5"   0   $��0��6   $��1��6#   	   AutoGenerateColumns$	 False��6D   
   CanUserAddRows$
 False��6`      
IsReadOnly$
 True��6w      Columns 5#      0  *System.Windows.Controls.DataGridTextColumn  5$      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6%      Header$ ID��62   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6>   �� *RoomId+  5%      $
 Auto 6%   $ Number��62    6B   �� *
RoomNumber+  5&      $
 Auto 6%   $ Description��62    6G   �� *RoomDetailDescription+  5'      $
 Auto 6%   $ MaxCapacity��62    6G   �� *RoomMaxCapacity+  5)      $
 Auto 6%   $ PricePerDay��62    6G   �� *RoomPricePerDay+  5*      $
 Auto 6%   $ RoomType��62    6D   �� *RoomType.RoomTypeName+5,      �� 5.   
   $ Vertical=�6   $��1��6,   $��1��6<   .+�5/      �� -   5        $ 	btnCreate��5/   8   #��[  6   $��Create��6K   $	��100��6\   $
��0 20q�6h   $��40��6v   6�   �� 50      -   5        $ btnEdit��50   8   #��[  6   $
��Edit��6I   $	��100��6X   $
��0 20q�6e   $��40��6s   6   �� 51      -   5        $ 	btnDelete��51   8   #��[  6   $��Delete��6K   $	��100��6\   $
��0 20q�6i   $��40��6w   6�   52      54      55      