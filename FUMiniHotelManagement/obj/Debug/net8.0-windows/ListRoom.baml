   M S B A M L   `   `   `  ����P  LFUMiniHotelManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:FUMiniHotelManagementFUMiniHotelManagement  5      $    FUMiniHotelManagement.ListRoom   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:FUMiniHotelManagement     5      -   5          N� Title$  ListRoom��5	       � 	Resources 5       �� Source�� 5   
   $ StyleResource.xaml?�6   %    .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��80 �6   �� 5      $��* �6   .+�5   
   � $��0��6   $��0��6    5      �� 5      $��* �6#   �� 5      $
��Auto �6#   .+�5      �� $��0��6    �� Orientation$ 
Horizontal=�6)   $
��Left=�6B   .+�5       �� $��From: ��6   $��Center=�6)   
����� �$��DemiBold"�6_   (  "System.Windows.Controls.DatePicker  5!      -   5          Name$ dpkFrom��5!      $��30��6.   $	��100��6:   $��Center=�6F   6j   �� 5"      $
��To: ��6   $��Center=�6'   
����� �$��DemiBold"�6]     5#      -   5        $ dpkTo��5#      $��30��6,   $	��100��68   $��Center=�6D   6h   �� 5$      $��Room Type: ��6   $��Center=�6.   
����� �$��DemiBold"�6d   �� 5%      -   5         ��Name$ cbxRoomType��5%      $��30��60   $	��100��6<   $��Center=�6H   6l   �� 5(      -   5         ��Name$ 	btnFilter��5(   <      	btnStyle1#��[  6   $��Find available room��6P   $��30��6n   $	��150��6z   $��20 0 0 0q�6�   6�   5)      �� 5+      -   5        $ btnBook��5+   d   $��Right=�6   $��1��61   #��[  6A   $
��Book��6v   $��30��6�   $	��100��6�   $��	20 0 20 0q�6�   6�   5-      &   System.Windows.Controls.DataGrid  5/   
   -   5        	  Name$	 
dgvDisplay��5/   0   $��0��6   $��1��6#   
   AutoGenerateColumns$
 False��6D      CanUserAddRows$ False��6`   ��6w   �� *Rooms+   Columns 50      4  .System.Windows.Controls.DataGridCheckBoxColumn  51      ,  &System.Windows.Controls.DataGridColumn   Header$ Select��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   �� *
IsSelected+0  *System.Windows.Controls.DataGridTextColumn  52         Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 6%   $ Number��62    6B   �� *
RoomNumber+  53      $
 Auto 6%   $ Description��62    6G   �� *RoomDetailDescription+  54      $
 Auto 6%   $ MaxCapacity��62    6G   �� *RoomMaxCapacity+  55      $
 Auto 6%   $ PricePerDay��62    6G   �� *RoomPricePerDay+  56      $
 Auto 6%   $ RoomType��62    6D   �� *RoomType.RoomTypeName+  57      $
 Auto 6%   $ RoomTypeDescription��62    6O   �� *RoomType.TypeDescription+  58      $
 Auto 6%   $ RoomTypeNote��62    6H   �� *RoomType.TypeNote+5:      5>      5?      