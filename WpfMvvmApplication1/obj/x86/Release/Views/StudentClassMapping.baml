   M S B A M L   `   `   `  ���� p  lSystem.Windows.Controls.Input.Toolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35pTclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Input.ToolkitSystem.Windows.Controls   SMS8   2HospitalManagementSystem.Views.StudentClassMapping   aControlsTclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Input.Toolkit  W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     .��� .+��� 
������ $��1q�$��5q�._��� .+��� $��Stretch=�$
��Auto��$��1q����	#FF48958C.+��� $
��Auto��$
��Left=�$��15(����	#FFF7F3F3.��Search�� ���	#FF48958C$��1q�$��1q�._��� .+���   �� Orientation$  
Horizontal=�.+��  � RowDefinitions �� �� �� ��  � ColumnDefinitions �� $	��25* ��� $	��25* �.+��� $��0��$��0��   
labelstyle#��[  .��Class�� $��1��$��0��#��[  .��Student Name�� $��0��$��1��$	��3,3q�$ �� IsSynchronizedWithCurrentItem$
 TrueY����� *lstClassRoom+ �� SelectedItem �� *SelectedClassRoom+-   'System.Windows.Controls.AutoCompleteBox  -   $��txtMedicine��$��1��$��1��   IsTextCompletionEnabled .    
FilterMode$ Contains=�  autocompleteboxstyle#��[ $	��300��$
��Left=�$��4q�   ItemsSource �� *
lstStudent+   SelectedItem �� *StudentName+	 �� Mode$	 TwoWay=�
   Text
 �� *StudentName+�� $  
Horizontal=�$
��Auto��$��Center=�