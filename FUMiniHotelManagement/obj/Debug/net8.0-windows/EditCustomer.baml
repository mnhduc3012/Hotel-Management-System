   M S B A M L   `   `   `  ����P  LFUMiniHotelManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:FUMiniHotelManagementFUMiniHotelManagement  5   	   (    "FUMiniHotelManagement.EditCustomer   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:FUMiniHotelManagement     5   	   -   5          � Title$  EditCustomer��5   	   $	��550��6   $	��550��6+    � WindowStartupLocation$ CenterScreen=�67   
������� � 	Resources 5	       �� Source�� 5
   
   $ StyleResource.xaml?�6   %    .��5      �� $��20q�6    �� Orientation$ Vertical=�6   .+�5   
   �� $ 
Horizontal=�6   $
��0 10q�6.   .+�5      �� $��Customer ID��6   $	��150��6*   �� 5      -   5         ��Name$ txtCustomerID��5      $	��200��6-    �� 
IsReadOnly$
 True��69   5      �� 5   
   $ 
Horizontal=�6   $
��0 10q�6.   .+�5      �� $��	Full Name��6   $	��150��6(   �� 5      -   5        $ txtCustomerFullName��5      $	��200��63   5      �� 5   
   $ 
Horizontal=�6   $
��0 10q�6.   .+�5      �� $��	Telephone��6   $	��150��6(   �� 5      -   5        $ txtTelephone��5      $	��200��6,   5      �� 5   
   $ 
Horizontal=�6   $
��0 10q�6.   .+�5       �� $��Email Address��6   $	��150��6,   �� 5!      -   5        $ txtEmailAddress��5!      $	��200��6/   $
 True��6;   5"      �� 5%   
   $ 
Horizontal=�6   $
��0 10q�6.   .+�5&      �� $��Birthday��6   $	��150��6'   (  "System.Windows.Controls.DatePicker  5'      -   5          Name$ dpCustomerBirthday��5'      $	��200��65   5(      �� 5+   
   $ 
Horizontal=�6   $
��0 10q�6.   .+�5,      �� $��Status��6   $	��150��6%   �� 5-      -   5         ��Name$ cbxCustomerStatus��5-      $	��200��62   5.      5/      �� 52   
   $ 
Horizontal=�6   $
��0 10q�6.   .+�53      �� $��Password��6   $	��150��6'   �� 54      -   5        $ txtPassword��54      $	��200��6+   55      �� 58   
   $ 
Horizontal=�6   $
��0 20q�6.   .+�59      �� -	   5        	 ��Name$	 btnQuit��59   8      	btnStyle1#��[  6   $
��Quit��6_   $	��100��6n   $��40��6z   $��Center=�6�   �� 5:      -
   5        $	 btnEdit��5:   8   #��[  6   $
��Edit��6_   $	��100��6n   $��40��6z   $��40 0 0 0q�6�   $��Center=�6�   5;      5<      5=      