   M S B A M L   `   `   `  ����   SMS1    +HospitalManagementSystem.Views.StaffDetails   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     .���� $��4q�  �� Orientation$  
Horizontal=�.+��� .+�� $
��0,10q� � ColumnDefinitions �� $	��33* ��� $	��33* ��� $	��33* � � RowDefinitions �� �� �� �� �� �� �� �� �� �� �� �� �� �� �� �� �� �� �� �� �� �� .+��� $��0��$��0��$��Center=�$��1,0,0,0q�$��3�����	#FF48958C.+���    
labelstyle#��[  $��Center=�$	��515��$
��Bold"�$��16(����	#FFF7F3F3.��Staff Details�� $��1��$��0��#��[  .��	Full Name�� $��2��$��0��#��[  .��Userid�� $��3��$��0��#��[  .��Email Address�� $��4��$��0��#��[  .��Date of Joining�� $��5��$��0��#��[  .��Designation�� $��6��$��0��#��[  .��Gender�� $��7��$��0��#��[  .��
Contact No�� $��8��$��0��#��[  .��Full Address�� $��9��$��0��#��[  .��Date of Leaving�� $��1��$��1��$
��Left=�  textboxstyle#��[ $	��283������ *Name+ �� UpdateSourceTrigger$ 	LostFocus=��� $��2��$��1��$
��Left=�#��[ $	��283�� �� 
IsReadOnly . ���� *UserID+�� $��3��$��1��$
��Left=�#��[ $	��283������ *EmailAddress+�� $��2��$��1��$��4��$��2��.+��� -   $��imgPhoto��$	��100��$	��150������ *ImageSource+�� -     loginbuttonstyle#��[ $��Center=�.��Upload(  "System.Windows.Controls.DatePicker  $��4��$��1��$	��100��$
��Left=�$��25��   SelectedDate �� *DateOfJoining+�� $��5��$��1��$
��Left=�#��[ $	��283������ *Designation+�� $��6��$��1��$��Center=�$  
Horizontal=�.+�	�  	� 	GroupName$ Gender�� d� 	IsChecked �� *
GenderMale+.��Male	� $ Gender��$��4,0,0,0q� �� *GenderFemale+.��Female�� $��7��$��1��$
��Left=�#��[ $	��283������ *ContactNumber+�� $��8��$��1��$
��Left=�#��[ $	��283�� �� TextWrapping$
 Wrap=�	 �� AcceptsReturn	 . $��60������ *	Address+  $��9��$��1��$	��100��$
��Left=�$��25�� �� *DateofLeaving+�� $	��400��$  
Horizontal=�$��Center=�.+��� #��[ $��Center=����� *	cmdsave+.���� $  
Horizontal=�.+��� $*��$/SMS;component/Images/save-icon2.png��$��UniformToFill=�$��20���� $
��Save���� -   #��[ $
��Left=�$��67��$y�Hidden=�.���� $  
Horizontal=�$
��Left=�.+��� $&�� /SMS;component/Images/Search.png��$��UniformToFill=�$��20���� $��Search��