   M S B A M L   `   `   `  ����P  LFUMiniHotelManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:FUMiniHotelManagementFUMiniHotelManagement  5   	   #    FUMiniHotelManagement.AddRoom   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:FUMiniHotelManagement     5   	   -   5          � Title$  AddRoom��5   	   $	��550��6   $	��550��6&    � WindowStartupLocation$ CenterScreen=�62    � 
ResizeMode$ CanMinimize=�6W   
������� � 	Resources 5	       �� Source�� 5
   
   $ StyleResource.xaml?�6   %    .��5      �� $��20q�6    �� Orientation$ Vertical=�6   .+�5   
   �� $ 
Horizontal=�6   $
��0 10q�6.   .+�5      �� $��Room Number��6   $	��150��6+   �� 5      -   5         ��Name$ txtRoomNumber��5      $	��200��6-   5      �� 5   
   $ 
Horizontal=�6   $
��0 10q�6.   .+�5      �� $��Room Description��6   $	��150��60   �� 5      -   5        $ txtRoomDescription��5      $	��200��62   $	��100��6>    �� TextWrapping$
 Wrap=�6K    �� AcceptsReturn$
 True��6_   5      �� 5   
   $ 
Horizontal=�6   $
��0 10q�6.   .+�5      �� $��Max Capacity��6   $	��150��6,   �� 5      -   5        $ txtRoomMaxCapacity��5      $	��200��62   5      �� 5   
   $ 
Horizontal=�6   $
��0 10q�6.   .+�5      �� $��Room Status��6   $	��150��6*   �� 5      -   5        	 ��Name$	 cbxRoomStatus��5      $	��200��6.   5      5      �� 5    
   $ 
Horizontal=�6   $
��0 10q�6.   .+�5!      �� $��Price Per Day��6   $	��150��6-   �� 5"      -   5        $ txtRoomPricePerDay��5"      $	��200��62   5#      �� 5$   
   $ 
Horizontal=�6   $
��0 10q�6.   .+�5%      �� $��	Room Type��6   $	��150��6(   �� 5&      -   5        $	 cbxRoomType��5&      $	��200��6,   5(      5)      �� 5*   
   $ 
Horizontal=�6   $
��0 20q�6.   .+�5,      �� -   5        
 ��Name$
 btnQuit��5,   8      	btnStyle1#��[  6   $
��Quit��6_   $	��100��6n   $��40��6z   $��Center=�6�   �� 5-      -	   5        $
 btnAdd��5-   9   #��[  6   $	��Add��6^   $	��100��6l   $��40��6x   $��	40 0 0 0 q�6�   $��Center=�6�   5.      5/      50      