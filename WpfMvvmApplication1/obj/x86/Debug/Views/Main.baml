   M S B A M L   `   `   `  ����q  mSystem.Windows.Controls.Layout.Toolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35qUclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Layout.ToolkitSystem.Windows.Controls  5   	   > :IMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:HospitalManagementSystem.ViewModels#HospitalManagementSystem.ViewModels 5   	   O,clr-namespace:HospitalManagementSystem.ViewsHospitalManagementSystem.Views 5   	   )   #HospitalManagementSystem.Views.Main   5   	   bControlsUclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Layout.Toolkit  U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   H
viewModels1clr-namespace:HospitalManagementSystem.ViewModels     5   	   >views,clr-namespace:HospitalManagementSystem.Views     5   	   $
��Auto��5   	     � WindowStartupLocation$  CenterScreen=�5   	    � WindowState$ 	Maximized=�5	   	    � Icon$) #/IMS;component/Images/AppitLogo.png��5
   	    � Title 5   	   �� *
SchoolName+.��5      ]� ���#E9EBEE.+�5   
   �� $	��Top=�6   ._�5      �� ���#3B5998$��1q�6/   .+�5      �  � ColumnDefinitions 5      �� 5      $	��30* �6+   �� 5      $	��70* �6+    � RowDefinitions 5      �� 5      6*   .+�5      �� $��0��6    
�������$��Center=�6C   $
��Left=�6^   ��6y   �� *
UserName+6�   �� 5        �� Orientation$ 
Horizontal=�6!   $��1��6:   .+�5!      �� $��0,0,20,0q�6!   $
��Left=�63   $��Center=�6N   $��40��6�   ��6i   �� *ImageSource+6�   �� 5"         header0#��[  6!   ��6C   �� *
SchoolName+6d   �� 5#        header1#��[ 6!   ��6C   �� *AcademicYear+6g   5%      5'      5)      5*      �� 5+   
   $��Bottom=�6   ._�5,      �� $��1q�6   $��15��6$   $��Center=�60   ���#3B5998.+�5-      �  5.      �� 5/      $��* �6+   �� 50      $��* �6+    52      �� 53      6*   .+�56      �� $��1��6    $��9(�60   $��Right=�6=   $��Center=�6Y   ���	#FFF9F9F9$��1q�6�   ><MoskIT-Services | Ph:+91-9167113122 | Mail:support@moskit.in6�   �� 57      $��0��6    $��9(�60   $
��Left=�6=   $	��Top=�6X   ���	#FFF9F9F9$��1q�6�   ��6�   �� *ConnectedTo+6�   58      59      5=      �� 5>   
     docborderstyle#��[ 6   $
��Left=�69   ._�5?      �� $��1q�6   .+�5@      �� .+�5A      �� ��6#   �� *MyData+��5B      �� 5C      .R�5D   "   �� $
��Left=�6-   .+�5F   &   �� $��Center=�5G   .   $
��Left=�5H   .   $	��120��5I   .   $��25��5J   .    � Cursor$
 Hand��5K   .   $��1q�5L   .     menubuttonstyle#��[ 5M   .   ��5F   .   �� *	Command+��6J   �� *	Parameter+.��5P   *   �� $ 
Horizontal=�65   $
��Left=�6N   .+�5Q   .   �� $��UniformToFill=�6W   $��20��6o   $��20��6z   ��64   �� *buttonimagepath+6�   �� 5R   .   $��Center=�69   .+�5S   2   �� ��6<   �� *	Content+6X   5T   /   5U   +   5V   '   5X   #   5Y      5[      5\      5]      5^      �� 5_   
   #��[ 6   $��Right=�69   ._�5`      �� $
��Auto=�6   $
��Auto=�6@   $��1,0,0,0q�6c   .��5a      �� $
��Left=�6   $
��Auto��69   .+�5b      �� $��2q�5e      $
��Auto��5f      $��1,1,2,2q�5g      ���#999966��5c      �� *TabItemSource+ �� SelectedIndex 5d      �� *
tabindex+	 �� Mode$	 TwoWay=���5k      �� 5l      .R�5m   "   �� $ 
Horizontal=�6-   .+�5n   &   �� $��14(�6G   ��60   �� *Title+6G   �� 5o   &   
�������
���  ��$
 Hand��6�   $��10,0,0,0q�6�   $��0q�6�   
������ $��14(�6�   ��6.   �� *
cmdClose+��6K   �� *	Parameter+.��6�   x6�   5p   #   5q      
 �� ContentTemplate
 5s      �� 5t      .R�5u   "   �� $
��Auto��6T   ��61   �� *contentcontrol+6d   5v      5x      5y      5z      5{      5|      5      