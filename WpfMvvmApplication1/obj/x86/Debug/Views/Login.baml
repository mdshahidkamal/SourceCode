   M S B A M L   `   `   `  ����  IMS*    $HospitalManagementSystem.Views.Login   5   	   U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Login��5   	   $	��400��6   $	��250��6#    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�6    � Icon$) #/IMS;component/Images/AppitLogo.png��5   	    � Topmost . .��5      � ��5	   
   �� 5
       �� ImageSource$* $/IMS;component/Images/MoskitHome.png��6    j� Stretch$
 Fill=�6L   6]    � ColumnDefinitions 5   
   �� 5      �� 5      $��0* �6   .+�5   
   ��  �� Orientation$ Vertical=�6   $��Center=�6.   .+�5      �� $��Center=�6   .+�5      �� -   5        $��stkLogin��5   2   $y�Visible=�6   .+�5      �� $��Center=�6!   .+�5      �  5      �� 5   "   $	��30* �63   6A   �� 5   "   $	��70* �63   6A   	 � RowDefinitions	 5      �� 5   "   62   �� 5   "   62   �� 5   "   62   .+�5       �� $��0��6$   $��0��61      
labelstyle#��[  6A   
�������.��6x   
Login ID6�   �� 5!      $��1��6$   $��0��61   #��[  6A   
�������.��6x   
Password6�   �� 5#      $��0��6&   $��1��63     textboxstyle#��[ 6C   $	��200��6�   $��2q�6�   $��25��6�   ��6i   �� *EmailAddress+6�   G� 5$      -   5        $��txtPassword��5$   *   $��1��6=   $��1��6J     passwordboxstyle#��[ 6Z   $	��200��6�   $��2q�6�   $��25��6�   6�   5%      5&      �� 5'      $��Center=�6"   .+�5(      ��   loginbuttonstyle#��[ 6"   $��Login��5*   X   $��45��6i   ��5)   #   �� *
cmdlogin+��5*   #   �� 
 �� ElementName$
 txtPassword��6i   5,      5-      5/      53      55      56      