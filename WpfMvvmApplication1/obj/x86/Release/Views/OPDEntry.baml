   M S B A M L   `   `   `  ���� p  lSystem.Windows.Controls.Input.Toolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35pTclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Input.ToolkitSystem.Windows.Controls  > :SMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:HospitalManagementSystem.Converters#HospitalManagementSystem.Converters 3   -HospitalManagementSystem.Views.PatientDetails   aControlsTclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Input.Toolkit  W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Clocal1clr-namespace:HospitalManagementSystem.Converters     $
��Auto��$
��Auto��  � 	Resources  ��%    .���� $��4q� �� Orientation$ 
Horizontal=�.+��� .+��  � ColumnDefinitions �� $	��25* ��� $	��25* ��� $	��25* ��� $	��25* � � RowDefinitions �� �� �� �� �� �� �� �� �� �� �� �� �� �� �� �� �� �� .+��� $��0��$��Center=�$	��867��$��1,0,0,0q�$��4�����	#FF48958C.+���    
labelstyle#��[  $��Center=�$
��Bold"�$��16(����	#FFF7F3F3.��Student Entry Form�� $��1��$��0��#��[  .��
First Name�� $��1��$��2��#��[  .��Middle Name�� $��2��$��0��#��[  .��	Last Name�� $��3��$��0��#��[  .��Date of Birth�� $��3��$��2��#��[  .��Date of Admission�� $��4��$��0��#��[  .��Age�� $��4��$��2��#��[  .��Gender�� $��5��$��0��#��[  .��Father's Name�� $��5��$��2��#��[  .��Father's Occupation�� $��6��$��0��#��[  .��Mother's Name�� $��6��$��2��#��[  .��Mother's Occupation�� $��7��$��0��#��[  .��Caste�� $��7��$��2��#��[  .��	Sub-Caste�� $��8��$��0��#��[  .��Nationality�� $��9��$��0��#��[  .��
Contact No�� $��9��$��2��#��[  .��Emergency Contact No�� $��8��$��2��#��[  .��Email Address�� $��11��$��0��#��[  .��Full Address�� $��12��$��0��#��[  .��Date of Leaving�� $��2��$��2��#��[  .��Previous School�� $��1��$��1��$
��Left=�  textboxstyle#��[ $	��283��$��4,4,4,0q����� *PatientName+�� $��1��$��3��$
��Left=�#��[ $	��283��$��4,4,4,0q����� *PatientName+�� $��2��$��1��$
��Left=�#��[ $	��283��$��4,4,4,0q����� *PatientName+�� -   $��4,4,4,0q�$��4��$��1�� �� 	MaxLength$ 2��$
��Left=�#��[ $��30������ *Age+�� $��4��$��3��$��Center=�$��4,4,4,0q�$ 
Horizontal=�.+�	�  	� 	GroupName$ Gender�� d� 	IsChecked �� *
GenderMale+.��Male	� $ Gender��$��4,0,0,0q� �� *GenderFemale+.��Female�� $��7��$��1��.+��� $ 
Horizontal=��� $	��400��$ 
Horizontal=�.+���   loginbuttonstyle#��[ $��Center=����� *	cmdsave+.���� $ 
Horizontal=�.+��� $
��Save���� $$��/SMS;component/Images/save.png��$��UniformToFill=�$��20���� #��[ $
��Left=�$��67������ *
cmdprint+.���� $ 
Horizontal=�$
��Left=�.+��� $��Print���� $+��%/SMS;component/Images/PrinterIcon.png��$��UniformToFill=�$��20��