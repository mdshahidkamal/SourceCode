   M S B A M L   `   `   `  ���� p  lSystem.Windows.Controls.Input.Toolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35pTclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Input.ToolkitSystem.Windows.Controls   SMS2   ,HospitalManagementSystem.Views.StudentSearch   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     iControlsTclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Input.Toolkit     .��� .+��� 
������ $��1q�$��5q�._��� .+��� $��Stretch=�$
��Auto��$��1q����	#FF48958C.+��� $
��Auto��$
��Left=�$��15(����	#FFF7F3F3.��Search�� ���	#FF48958C$��1q�$��1q�._��� .+���   �� Orientation$  
Horizontal=�$y�	Collapsed=�.+��  � RowDefinitions �� �� �� ��  � ColumnDefinitions �� $	��25* ��� $	��25* ��� $	��25* ��� $	��25* �.+��� $��0��$��0��   
labelstyle#��[  .��
First Name�� $��0��$��2��#��[  .��Middle Name�� $��1��$��0��#��[  .��	Last Name�� $��1��$��2��#��[  .��Enrollment Number�� $��2��$��0��#��[  .��Father's Name�� $��2��$��2��#��[  .��Mother's Name�� $��3��$��0��#��[  .��Date of Birth�� $��3��$��2��#��[  .��Date of Leaving�� $��0��$��1��  textboxstyle#��[ $	��283�� �� 	IsEnabled . ���� *	FirstName+�� $��0��$��4��#��[ $	��283�� . ���� *
MiddleName+�� $��1��$��1��#��[ $	��283�� . ���� *
LastName+�� $��1��$��4��#��[ $	��283�� . ���� *EnrollmentNo+�� $��2��$��1��#��[ $	��283�� . ���� *
FatherName+�� $��2��$��4��#��[ $	��283�� . ���� *
MotherName+(  "System.Windows.Controls.DatePicker  $��3��$��1��$	��100��$
��Left=�$��25��   SelectedDate �� *DateOfBirth1+  $��3��$��3��$	��100��$
��Left=�$��25�� �� *LeavingDate1+�� ���	#FF48958C$��1q�$��1q�._��� $��	0,10,0,10q�$��0��$��1��$  
Horizontal=�$��Center=�.+��� #��[  .��Search-   'System.Windows.Controls.AutoCompleteBox  -   $��txtMedicine��$��2q�$��30��   ValueMemberPath$ 	FirstName��   IsTextCompletionEnabled .    
FilterMode$ Contains=�  autocompleteboxstyle#��[ $	��300��$
��Left=�   ItemsSource �� *lstStudentDetails+	   SelectedItem	 �� *SelectedStudentNew+
 �� Mode$
 TwoWay=�   
ItemFilter �� *StudentFilter+   ItemTemplate �� AutoCompleteBoxItemTemplate��.R��� $  
Horizontal=�.+��� #��[  $
��Auto������ *	FirstName+�� #��[  $��Italic$�
����������� *EnrollmentNo+��   loginbuttonstyle#��[ $��30��$��30������ *	cmdSearch+.���� .+��� $&�� /SMS;component/Images/Search.png��$��UniformToFill=��� $  
Horizontal=�$
��Auto��$��Center=�.+��� #��[ $
��Left=�$��67������ *	cmdSearch+.���� $  
Horizontal=�$
��Left=�.+��� $��Search���� $&�� /SMS;component/Images/Search.png��$��UniformToFill=�$��20���� -   #��[ $
��Left=�$
��Auto��.���� $  
Horizontal=�$
��Left=�.+��� $��Add New Student���� $&�� /SMS;component/Images/AddRed.png��$��UniformToFill=�$��2q�&   System.Windows.Controls.DataGrid  -   
�������   GridLinesVisibility$
 None=�   RowHeaderWidth$ 0Q�   CanUserAddRows .   � Cursor$
 Hand��   AutoGenerateColumns .  $��2q�"   VerticalScrollBarVisibility$ Visible=�$
��Auto��$��Center=����� *StudentDetailCollection+   ColumnHeaderStyle ��  �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  .���  �� Property � �� �� Value �	#FF48958C��  � ��
 �������  � ��$ Center=���  � ��$ 	Tangerine)���  � ��$ 15(���  � ��$ Medium"�   	CellStyle �� *  $System.Windows.Controls.DataGridCell"  .���  � ��$ Center=�   Columns 4  .System.Windows.Controls.DataGridTemplateColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Enrollment No��   CellTemplate �� .R��� ��  �� Command �� *cmdSearchWithID+ �� CommandParameter �� *EnrollmentNo+.��� .F��� ���� *EnrollmentNo+0  *System.Windows.Controls.DataGridTextColumn  $ 	StudentId��   Width5	  /System.Windows.Controls.DataGridLengthConverter$ 50	    
IsReadOnly .    
Visibility$ 	Collapsed=�1
  +System.Windows.Controls.DataGridBoundColumn  
  Binding  �� *	StudentId+  $ StudentName��$	 250	  .   �� *	FirstName+  $ 
FatherName��$	 150	  .   �� *
FatherName+  $ DateOfBirth��$	 100	  .   �� *DateOfBirth+  $ LeavingDate��$	 100	  .   �� *LeavingDate+  $ Image�� �� .R��� $��imgPhoto��$��40��$��50������ *ImageSource+