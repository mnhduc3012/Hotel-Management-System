   M S B A M L   `   `   `  ����P  LFUMiniHotelManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:FUMiniHotelManagementFUMiniHotelManagement  5      #    FUMiniHotelManagement.Profile   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:FUMiniHotelManagement     5      -   5          N� Title$  Profile��5	       � 	Resources 5       �� Source�� 5   
   $ StyleResource.xaml?�6   %    .��5      �� 
������� �� Orientation$ Vertical=�6)   .+�5   
   �� $��20q�6   $ Vertical=�6!   .+�5      �� $��20(�6   $
��0 10q�6"   $
��Bold"�60   $��Profile information��6B   
����� �6`   �� 5      $ 
Horizontal=�6   $
��0 10q�62   .+�5      �� $��	Full Name��6   $	��150��6,   
����� �68   �� 5      -   5         ��Name$ txtCustomerFullName��5      $	��250��67   5      �� 5      $ 
Horizontal=�6   $
��0 10q�62   .+�5      �� $��	Telephone��6   $	��150��6,   
����� �68   �� 5      -   5        $ txtTelephone��5      $	��250��60   5      �� 5      $ 
Horizontal=�6   $
��0 10q�62   .+�5      �� $��Email Address��6   $	��150��60   
����� �6<   �� 5       -   5        $ txtEmailAddress��5       $	��250��63    �� 
IsReadOnly$
 True��6?   5!      �� 5$      $ 
Horizontal=�6   $
��0 10q�62   .+�5%      �� $��Birthday��6   $	��150��6+   
����� �67   (  "System.Windows.Controls.DatePicker  5&      -   5          Name$ dpCustomerBirthday��5&      $	��250��69   5'      �� 5*      $ 
Horizontal=�6   $
��0 10q�62   .+�5+      �� $��Password��6   $	��150��6+   
����� �67   �� 5,      -   5        $ txtPassword��5,      $	��250��6/   5-      �� 50      $ 
Horizontal=�6   $
��0 20q�62   .+�52      �� -   5         ��Name$ 	btnUpdate��52   <      	btnStyle1#��[  6   $��Update��6g   $	��100��6x   $��40��6�   $��Center=�6�   53      54      55      57      