   M S B A M L   `   `   `  ����P  LFUMiniHotelManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:FUMiniHotelManagementFUMiniHotelManagement  5   	   $    FUMiniHotelManagement.Register   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:FUMiniHotelManagement     5   	     � Title$  Register��5   	   $	��550��6   $	��550��6'    � WindowStartupLocation$ CenterScreen=�63    � 	Resources 5	       �� Source�� 5
   
   $ StyleResource.xaml?�6   %    .��5      � 
������� � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      .+�5   
   �� $��Register��6   $��Center=�6$   $��Center=�6?   $��24(�6\   $��	ExtraBold"�6j   
����� �6�   �� 5   
   $��1��6   $��20q�6"    �� Orientation$ Vertical=�6.   $��Center=�6E   $	��Top=�6b   .+�5      �� $ 
Horizontal=�6   $
��0 10q�62   .+�5      �� $��Email Address��6   $	��150��60   �� 5      -   5         ��Name$ txtEmailAddress��5      $	��200��63   5      �� 5      $ 
Horizontal=�6   $
��0 10q�62   .+�5      �� $��Password��6   $	��150��6+   G� 5      -   5         G�Name$ txtPassword��5      $	��200��63   5      �� 5!      $ 
Horizontal=�6   $
��0 10q�62   .+�5"      �� $��Confirm Password��6   $	��150��63   G� 5#      -   5        $ txtConfirmPassword��5#      $	��200��6:   5$      �� 5&      $ 
Horizontal=�6   $
��0 10q�62   .+�5'      �� $��	Full Name��6   $	��150��6,   �� 5(      -   5        $ txtCustomerFullName��5(      $	��200��67   5)      �� 5+      $ 
Horizontal=�6   $
��0 10q�62   .+�5,      �� $��	Telephone��6   $	��150��6,   �� 5-      -   5        $ txtTelephone��5-      $	��200��60   5.      �� 50      $ 
Horizontal=�6   $
��0 10q�62   .+�51      �� $��Birthday��6   $	��150��6+   (  "System.Windows.Controls.DatePicker  52      -   5          Name$ dpCustomerBirthday��52      $	��200��69   53      �� 56      $ 
Horizontal=�6   $
��0 20q�62   $��Center=�6@   .+�57      �� -   5        	 ��Name$	 btnQuit��57   <      	btnStyle1#��[  6   $
��Quit��6c   $	��100��6r   $��40��6~   $��Center=�6�   �� 58      -   5        $	 btnRegister��58   <   #��[  6   $��Register��6k   $	��100��6~   $��40��6�   $��40 0 0 0q�6�   $��Center=�6�   59      5:      5;      5<      