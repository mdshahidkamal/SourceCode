   M S B A M L   `   `   `  ���� >  :SMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:HospitalManagementSystem.Converters#HospitalManagementSystem.Converters  p lSystem.Windows.Controls.Input.Toolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35pTclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Input.ToolkitSystem.Windows.Controls 3    -HospitalManagementSystem.Views.StudentDetails   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     Clocal1clr-namespace:HospitalManagementSystem.Converters     iControlsTclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Input.Toolkit     $
��Auto��$
��Auto��  � 	Resources     savebuttonstyle �� 
TargetType �� BasedOn �� Property �� Value �� Triggers �� Binding �� ElementName �� Path	 �� Value��%�  &	        7���� " ��8   .���  � ��$ Normal$���  � ��$ 60����  � ��$ 25����  � ��$ 1q���  �@�Cursor$
 Hand����  � {� .  ��  �� $ txtFirstName��$
 Text�	  .a���  � {� .  ��  �� $ txtMiddleName��$
 Text�	  .a���  � {� .  ��  �� $ txtLastName��$
 Text�	  .a���  � {� .  ��  �� $ txtAge��$
 Text�	  .a���  � {� .  ��  �� $ txtEnrollmentNo��$
 Text�	  .a���  � {� .  ��  �� $ txtFathersName��$
 Text�	  .a���  � {� .  ��  �� $ txtMothersName��$
 Text�	  .a���  � {� .  ��  �� $ cmbFathersOccupation��$ SelectedItem�	 
--Select--.a���  � {� .  ��  �� $ cmbMotherOccupation��$ SelectedItem�	 
--Select--.a���  � {� .  ��  �� $ cmbReligion��$ SelectedItem�	 
--Select--.a���  � {� .  ��  �� $ txtCaste��$
 Text�	  .a���  � {� .  ��  �� $ txtNationality��$
 Text�	  .a���  � {� .  ��  �� $ txtEmailAddress��$
 Text�	  .a���  � {� .  ��  �� $ txtContactNo��$
 Text�	  .a���  � {� .  ��  �� $ 
txtAddress��$
 Text�	  .a���  � {� .  ��  �� $ cmbClassRoom��$ SelectedItem�	 
--Select--.a���  � {� .  ��  �� $ cmbClassRoom��$ SelectedItem�	 
--Select--.a���  � {� .  .���� $��4q�
 �� Orientation$
 
Horizontal=�.+��� .+��� $��Stretch=�$
��Auto��$��2q����	#FF48958C.+���   
labelstyle#��[ $��Center=�$
��Bold"�$��16(����	#FFF7F3F3.��Student Details�� ���	#FF48958C$��1q�$��1q�._��� .+��� $
 
Horizontal=�$y�	Collapsed=�.+��  � RowDefinitions �� �� �� ��  � ColumnDefinitions �� $	��25* ��� $	��25* ��� $	��25* ��� $	��25* �.+��� $��0��$��0��#��[ .��
First Name�� $��0��$��2��#��[ .��Middle Name�� $��1��$��0��#��[ .��	Last Name�� $��1��$��2��#��[ .��Enrollment Number�� $��2��$��0��#��[ .��Father's Name�� $��2��$��2��#��[ .��Mother's Name�� $��3��$��0��#��[ .��Date of Birth�� $��3��$��2��#��[ .��Date of Leaving�� $��0��$��1��  textboxstyle#��[ $	��283�� �� 	IsEnabled . ���� *	FirstName+�� $��0��$��4��#��[ $	��283�� . ���� *
MiddleName+�� $��1��$��1��#��[ $	��283�� . ���� *
LastName+�� $��1��$��4��#��[ $	��283�� . ���� *EnrollmentNo+�� $��2��$��1��#��[ $	��283�� . ���� *
FatherName+�� $��2��$��4��#��[ $	��283�� . ���� *
MotherName+(  "System.Windows.Controls.DatePicker  $��3��$��1��$	��100��$
��Left=�$��25��   SelectedDate �� *DateOfBirth1+  $��3��$��3��$	��100��$
��Left=�$��25�� �� *LeavingDate1+�� $��	0,10,0,10q�$��0��$��1��$
 
Horizontal=�$��Center=�.+��� #��[ .��Search-  'System.Windows.Controls.AutoCompleteBox  -   $��txtMedicine��$��2q�$��30��   ValueMemberPath$ 	FirstName��   IsTextCompletionEnabled .    
FilterMode$ Contains=�  autocompleteboxstyle#��[ $	��500��$
��Left=�   ItemsSource �� *lstStudentDetails+   SelectedItem �� *SelectedStudentNew+ �� Mode$ TwoWay=�   
ItemFilter �� *StudentFilter+   ItemTemplate �� AutoCompleteBoxItemTemplate��.R��� $
 
Horizontal=�.+��� #��[ $
��Auto������ *	FirstName+�� #��[ $��Italic$�
����������� *EnrollmentNo+��   loginbuttonstyle#��[ $��30��$��30������ *	cmdSearch+.���� .+��� $&�� /SMS;component/Images/Search.png��$��UniformToFill=��� #��[ $
��Left=�$��30��$��30������ *cmdClearFormField+.���� $
 
Horizontal=�$
��Left=�.+��� $&�� /SMS;component/Images/AddRed.png��$��UniformToFill=�$��2q��� $��2q����	#FF48958C$��1q�._�� $��2q� �� $
��148* ��� $
��289* ��� $
��168* ��� $
��208* � �� �� �� �� �� �� �� �� �� �� �� �� �� �� �� �� �� �� �� �� �� �� .+��� $��1��$��0��#��[ $��	1,1,1,0.6q�.��First Name *�� $��2��$��0��#��[ $��1,1.4,1,0.2q�.��Middle Name *�� $��3��$��0��#��[ $��1,0.8q�.��Last Name *�� $��4��$��2��#��[ $�� ��$��1,1.2,1,0.4q��� $��5��$��0��#��[ $��	1,0.6,1,1q�.��Date of Birth *�� $��6��$��0��#��[ .��Date of Admission *�� $��7��$��2��#��[ .��Enrollment No *�� $��4��$��0��#��[ $��1,1.2,1,0.4q�.��Age *�� $��7��$��0��#��[ .��
Gender *�� $��8��$��0��#��[ .��Father's Name *�� $��8��$��2��#��[ .��Father's Occupation *�� $��9��$��0��#��[ .��Mother's Name *�� $��9��$��2��#��[ .��Mother's Occupation *�� $��10��$��0��#��[ .��
Religion *�� $��10��$��2��#��[ .��	Caste *�� $��11��$��0��#��[ .��Nationality *�� $��11��$��2��#��[ .��Email Address *�� $��12��$��0��#��[ .��Contact No *�� $��12��$��2��#��[ .��Emergency Contact No�� $��13��$��0��#��[ .��Full Address *�� $��13��$��2��#��[ .��Date of Leaving�� $��14��$��0��#��[ .��Class Admitted *�� -   $��txtFirstName��$��1��$��1��$
��Left=�#��[ $	��283��$��2q� �� 	MaxLength$ 30������ *	FirstName+�� -   $��txtMiddleName��$��2��$��1��$
��Left=�#��[ $	��283��$��2q�$ 30������ *
MiddleName+�� -   $��txtLastName��$��3��$��1��$
��Left=�#��[ $	��283��$��2q�$ 30������ *
LastName+�� -   $��txtAge��$��4��$��1��$
��Left=�#��[ $	��283��$��2q�$ 2������ *Age+�� $��2��$��1��$��5��$��2��$��2q�.+��� -   $��imgPhoto��$	��100��$	��150������ *ImageSource+�� -   #��[ $��Center=�.��Upload  $��5��$��1��$	��100��$
��Left=�$��25��$��2q� �� *DateOfBirth+  $��6��$��1��$	��100��$
��Left=�$��25��$��2q� �� *DateOfAdmission+�� -   $��txtEnrollmentNo��$��7��$��3��$
��Left=�#��[ $	��283��$��2��$��2q�$ 30��{�.  ���� *EnrollmentNo+�� $��7��$��1��$��Center=�$
 
Horizontal=�$��2q�.+�	�  	� 	GroupName$ Gender�� d� 	IsChecked �� *
GenderMale+.��Male	� $ Gender��$��4,0,0,0q� �� *GenderFemale+.��Female�� -	   $��txtFathersName��$��8��$��1��$
��Left=�#��[ $	��283��$��2q�$ 30������ *
FatherName+�� -
   $��cmbFathersOccupation��$��8��$��3��$��2q�$ �� IsSynchronizedWithCurrentItem$
 TrueY� �� DisplayMemberPath$ 
StaticName�� �� SelectedValuePath$ StaticID������ *lstFathersOccupation+ �� SelectedItem �� *SelectedOccupationFather+ �� UpdateSourceTrigger$ PropertyChanged=�$ TwoWay=��� -   $��txtMothersName��$��9��$��1��$
��Left=�#��[ $	��283��$��2q�$ 30������ *
MotherName+�� -   $��cmbMothersOccupation��$��9��$��3��$��2q�$
 TrueY�$ 
StaticName��$ StaticID������ *lstMothersOccupation+ �� *SelectedOccupationMother+$ PropertyChanged=�$ TwoWay=��� -   $��cmbReligion��$��10��$��1��$��2q�$
 TrueY�$ 
StaticName��$ StaticID������ *lstReligion+ �� *SelectedReligion+$ PropertyChanged=�$ TwoWay=��� -   $��txtCaste��$��10��$��3��$
��Left=�#��[ $	��283��$��2��$��2q�$ 30������ *Caste+�� -   $��txtNationality��$��11��$��1��$
��Left=�#��[ $	��283��$��2q�$ 30������ *Nationality+�� -   $��txtEmailAddress��$��11��$��3��$
��Left=�#��[ $	��283��$��2��$��2q�$	 200������ *EmailAddress+�� -   $��txtMobileNumber��$��12��$��1��$
��Left=�#��[ $	��283��$��2q�$ 11������ *MobileNumber+�� -   $��txtEmergencyContactNumber��$��12��$��3��$
��Left=�#��[ $	��283��$��2��$��2q�$ 20������ *EmergencyContactNo1+�� -   $��
txtAddress��$��13��$��1��$
��Left=�#��[ $	��283�� �� TextWrapping$
 Wrap=�  �� AcceptsReturn  . $��60��$��2q�$	 500������ *	Address+  $��13��$��3��$	��100��$
��Left=�$��25��$��2q� �� *LeavingDate+�� -   $��cmbClassRoom��$��14��$��1��$��2q�$
 TrueY�$ 
StaticName��$ StaticID������ *lstClassRoom+ �� *SelectedClass+$ PropertyChanged=�$ TwoWay=��� $��80��$
 
Horizontal=�.+��� #��[  $��Center=����� *	cmdsave+.���� $
 
Horizontal=�.+��� $
��Save���� $*��$/SMS;component/Images/save-icon2.png��$��UniformToFill=�$��20���� #��[ $
��Left=�$��67��$y�Hidden=����� *
cmdprint+.���� $
 
Horizontal=�$
��Left=�.+��� $��Print���� $,��&/SMS;component/Images/printer-blue.png��$��UniformToFill=�$��20���� -   #��[ $
��Left=�$��67��$y�Hidden=�.���� $
 
Horizontal=�$
��Left=�.+��� $��Search���� $&�� /SMS;component/Images/Search.png��$��UniformToFill=�$��20��