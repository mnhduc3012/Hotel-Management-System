   M S B A M L   `   `   `  ����P  LFUMiniHotelManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:FUMiniHotelManagementFUMiniHotelManagement  5   	   '    !FUMiniHotelManagement.LoginWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:FUMiniHotelManagement     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � WindowStyle$
 None=�5	   	    � 
ResizeMode$ NoResize=�5
   	    � Title$ LoginWindow��5   	   $	��550��6   $	��800��6*    � 	Resources 5       �� Source�� 5   
   $ StyleResource.xaml?�6   %    6;   .��5      � 
������� � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��Center=�6   $��Center=�6+   $��0��6H   $��1��6U   $��LOGIN��6e   $��	ExtraBold"�6u   $
��40px(�6�   
����� �6�   �� 5   
   $��1��6    �� Orientation$ Vertical=�6"   $��Center=�69   .+�5      �� $ 
Horizontal=�6   $��Center=�62   $
��0 10q�6O   .+�5      �� $	��100��6   $��Email: ��6$   $��18(�66   
����� �6a   �� 5      -   5         ��Name$ txtEmail��5      $	��300��6,   $��Center=�68   6\   5      �� 5       $ 
Horizontal=�6   $��Center=�62   $
��0 10q�6O   .+�5!      �� $	��100��6   $��
Password: ��6%   $��18(�6:   
����� �6e   G� 5"      -   5        	 G�Name$	 pwbPassword��5"      $	��300��64   $��Center=�6@   6d   5#      5%      �� 5'   
   $��2��6   $ Vertical=�6"   $��Center=�69   .+�5)      �� $ 
Horizontal=�6   .+�5*      �� -   5        
 ��Name$
 btnRegister��5*   <      	btnStyle1#��[  6   $��Register��6Q   $
��20 0q�6d   6�   �� 5+      -   5        $
 btnLogin��5+   <   #��[  6   $��Login��6N   $
��20 0q�6^   6�   5,      �� 5-      -   5        $
 	btnForgot��5-   E   #��[  6   $	��240��69   $��Forgot password��6X   $��20 10q�6r   6�   �� 5.      -   5        $
 btnQuit��5.   V   #��[  6   
�������$	��240��6J   $
��Quit��6g   $��20 10q�6v   6�   51      54      55      