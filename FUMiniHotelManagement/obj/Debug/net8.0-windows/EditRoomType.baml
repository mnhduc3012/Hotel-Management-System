   M S B A M L   `   `   `  ����P  LFUMiniHotelManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:FUMiniHotelManagementFUMiniHotelManagement  5   	   (    "FUMiniHotelManagement.EditRoomType   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:FUMiniHotelManagement     5   	   -   5          � Title$  EditRoomType��5   	   $	��400��6   $	��550��6+    � WindowStartupLocation$ CenterScreen=�67   
������� � 	Resources 5	       �� Source�� 5
   
   $ StyleResource.xaml?�6   %    .��5      �� $��20q�6    �� Orientation$ Vertical=�6   .+�5   
   �� $ 
Horizontal=�6   $
��0 10q�6.   .+�5      �� $��Room Type Id��6   $	��150��6+   �� 5      -   5         ��Name$ txtId��5      $	��200��6%    �� 
IsReadOnly$
 True��61   5      �� 5   
   $ 
Horizontal=�6   $
��0 10q�6.   .+�5      �� $��Room Type Name��6   $	��150��6-   �� 5      -   5        $ txtName��5      $	��200��6'   5      �� 5   
   $ 
Horizontal=�6   $
��0 10q�6.   .+�5      �� $��Type Description��6   $	��150��6/   �� 5      -   5        $ txtDescription��5      $	��200��6.   5      �� 5   
   $ 
Horizontal=�6   $
��0 10q�6.   .+�5      �� $��	Type Note��6   $	��150��6(   �� 5       -   5        $ txtNote��5       $	��200��6'   5!      �� 5'   
   $ 
Horizontal=�6   $
��0 20q�6.   .+�5(      �� -   5         ��Name$ btnQuit��5(   8      	btnStyle1#��[  6   $
��Quit��6_   $	��100��6n   $��40��6z   $��Center=�6�   �� 5)      -   5        $ btnEdit��5)   8   #��[  6   $
��Edit��6_   $	��100��6n   $��40��6z   $��40 0 0 0q�6�   $��Center=�6�   5*      5+      5,      