   M S B A M L   `   `   `  ���� p  lSystem.Windows.Controls.Input.Toolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35pTclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Input.ToolkitSystem.Windows.Controls   SMS6   0HospitalManagementSystem.Views.StaffClassMapping   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     iControlsTclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Input.Toolkit     $	��500��$	��800��.��� .+��� 
������ $��1q�._��� .+��� $��Stretch=�$
��Auto��$��1q����	#FF48958C.+��� $
��Auto��$
��Left=�$��15(����	#FFF7F3F3.��Search�� ���	#FF48958C$��1q�$��1q�._��� .+���   �� Orientation$  
Horizontal=�$	��500��.+��  � RowDefinitions �� $��30 ��� $
��Auto ��� $��30 ��� $
��Auto ��� $��30 � � ColumnDefinitions �� $	��25* ��� $	��25* �.+��� $��0��$��0��   
labelstyle#��[  .��Class�� $��1��$��0��#��[  .��
Staff Name�� $��0��$��1��$��2q�$	��300��$
��Left=�$ �� IsSynchronizedWithCurrentItem$
 TrueY� �� DisplayMemberPath$ 
StaticName�� �� SelectedValuePath$ StaticID������ *lstClassRoom+ �� SelectedItem �� *SelectedClassRoom+�� $��2��$��1��$  
Horizontal=�.+�-   'System.Windows.Controls.AutoCompleteBox  -   $��txtMedicine��$��2q�   IsTextCompletionEnabled .    
FilterMode$ Contains=�  autocompleteboxstyle#��[ $	��300��$
��Left=�	   ItemsSource	 �� *
lstStaff+
   SelectedItem
 �� *SelectedStaff+ �� Mode$ TwoWay=�   Text �� *SelectedStaff+$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=���   loginbuttonstyle#��[ $��25��$��25������ *cmdAddStaff+.���� .+��� $'��!/SMS;component/Images/AddGree.png��$��UniformToFill=��� $��2��$��2��$��Center=�$y�Hidden=�.+��� #��[  .��Assigned Staff�� $��1��$��1��.+��� ���	#FF48958C$��0q�._��� ���� *
AddedStaff+���� .R��� $��0,5,0,0q�$
��Left=�.+��� $��Center=�$	��350��$  
Horizontal=�.+��� $	��300��$��2q����� *	StaffName+�� $��Center=�$
��Left=�$��20�� � Cursor$
 Hand��$��20��#��[ ���� *	Command+���� *	Parameter+.���� .+��� $)��#/SMS;component/Images/DeleteRed.png��$��UniformToFill=��� $	��300��$��1�����	#FF48958C$
��Left=��� $  
Horizontal=�$
��Auto��$��Center=�