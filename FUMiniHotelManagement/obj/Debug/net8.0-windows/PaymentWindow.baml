   M S B A M L   `   `   `  ����P  LFUMiniHotelManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:FUMiniHotelManagementFUMiniHotelManagement  5   	   )    #FUMiniHotelManagement.PaymentWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:FUMiniHotelManagement     5   	   -   5          � Title$  PaymentWindow��5   	   $	��600��6   $	��800��6,    � WindowStartupLocation$ CenterScreen=�68    � 	Resources 5	       �� Source�� 5
   
   $ StyleResource.xaml?�6   %    .��5      � 
������� � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      .+�5   
   �� $��0��6   .+�5      �� $��0��6   $��Order Detail��6%   $��22(�5      $
��Bold"�5      
����� �$��Center=�5      $��Center=�5      �� 5      -   5         ��Name$ 
txtDetails��5      $
��Wrap=�5      $	��Top=�5      $
��Left=�5      $��10q�5      
����� �$��16(�6;   5       �� 5"   
   $��1��6   $��	15,0,15,0q�6#   .+�5#      �� $��0��6   $��Payment Information��6%   $��22(�5$      $
��Bold"�5%      
����� �$��Center=�5'      $��Center=�5(      �� 5)       �� Orientation$ 
Horizontal=�6   $��10q�62   .+�5*      �� $	��200��6   $��Card Number:��6(   $
��Bold"�6<   �� 5+      -   5         ��Name$ txtCardNumber��5+      $	��300��61   $��30��6=   5,      �� 5-      $ 
Horizontal=�6   $��10q�62   .+�5.      �� $	��200��6   $��Cardholder Name:��6(   $
��Bold"�6@   �� 5/      -   5        $ txtCartHolder��5/      $	��300��61   $��30��6=   50      �� 51      $ 
Horizontal=�6   $��10q�62   .+�52      �� $	��200��6   $��Expiry Date:��6(   $
��Bold"�6<   $��Center=�6N   �� 53      -   5        $ txtDate��53      $��80��6+   $��30��66   54      �� 56      $ 
Horizontal=�6   $��Center=�62   $��20q�6O   .+�57      �� -   5         ��Name$ 	btnCancel��58   3   $��Cancel��57      
���  ��   	btnStyle1#��[  6;   $��Center=�58   	   $��10q�6&   6F   �� 59      -   5        $ 
btnConfirm��5:   >   $��Confirm��59      #��[  6+   $��Center=�5:      $��10q�62   6R   5;      5<      5=      5>      