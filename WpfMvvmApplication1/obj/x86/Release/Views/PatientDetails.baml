   M S B A M L   `   `   `  ���� p  lSystem.Windows.Controls.Input.Toolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35pTclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Input.ToolkitSystem.Windows.Controls  > :LTS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:HospitalManagementSystem.Converters#HospitalManagementSystem.Converters 3   -HospitalManagementSystem.Views.PatientDetails   aControlsTclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Input.Toolkit  W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Clocal1clr-namespace:HospitalManagementSystem.Converters     $
��Auto��$
��Auto��  � 	Resources  C  =HospitalManagementSystem.Converters.BoolToVisibilityConverter   BoolToHiddenConverter   	TrueValue   
FalseValue@  :HospitalManagementSystem.Converters.StreamToImageConverter  imageConverter��%9   &	        &	         $ Visible=�$ Hidden=�  .���� $��4q� �� Orientation$ 
Horizontal=�$
��Auto��.+��� .+��� 
������ $��1q�$��5q�._��� .+��� $��0��$��Stretch=�$
��Auto��$��1q�$��2�����	#FF48958C.+��� $
��Auto��$
��Left=�$��15(����	#FFF7F3F3.��Letter Details�  � ColumnDefinitions �� $	��80* ��� $
��485* ��� $��8* � � RowDefinitions �� �� �� �� �� �� �� �� �� .+��� $��1��$��0��  
labelstyle#��[ .��Reference No�� $��2��$��0��#��[ .��	Subject�� $��3��$��0��#��[ .��Arrival Date�� $��4��$��0��#��[ .��From�� $��5��$��0��#��[ .��To�� $��6��$��0��#��[ .��
Comments�� $��7��$��0��#��[ .��Letter Content�� $��1��$��1��$
��Left=�  textboxstyle#��[ $	��500�� �� 	IsEnabled . $��5q����� *ReferenceNumber+�� $��2��$��1��$
��Left=�#��[ $	��500�� . $��5q����� *	Subject+�� $��3��$��1��$��Center=�$��5q�$ 
Horizontal=�$��2��.+�(  "System.Windows.Controls.DatePicker  $��30��$	��152��$��15(�   SelectedDate �� *RecivedDate+�� $��4��$��1��$
��Left=�#��[ $	��500�� . $��5q����� *From+�� $��5��$��1��$
��Left=�#��[ $	��500�� �� TextWrapping$
 Wrap=� . $��5q����� *To+�� $��6��$��1��	 �� TextAlignment$
	 Left=�$
��Left=�#��[ $	��500��$	��100��$	��Top=�
 �� AcceptsReturn
 . $
 Wrap=� . $��5q����� *
Comments+�� $ Vertical=�$��7��$��1��$��2��$��5q�.+��� -   $��txtLetterContent��#��[ $	��150��$	��500��$
 Wrap=�$	��Top=����� *LetterContent+�� $ 
Horizontal=�.+��� -     loginbuttonstyle#��[ $��7��$��1��$
��Left=�$��0,0,0,0q�$��25��$��85��.��Upload Image�� -   $��txtFileName��$
��Left=�$	��200��$
��Wrap=�$y�Hidden=����� *	Imagepath+�� $��1q�$ 
Horizontal=�$��Center=�.+��� #��[ $��Center=�$��50�� � ToolTip$
 Save������ *	cmdsave+.���� $ Vertical=�.+��� $$��/LTS;component/Images/save.png��$��45���� $y�	Collapsed=�#��[ $��Center=�$��50��$ Add New������ *cmdadd+.���� $ 
Horizontal=�.+��� $#��/LTS;component/Images/add.png��$��40���� $y�	Collapsed=�.+��� 
���  ��$��1q�$��5q�._��� $	��584��.+��� $��Stretch=�$
��Auto��$��1q����	#FF48958C.+��� $
��Auto��$
��Left=�$��15(����	#FFF7F3F3.��Search�� $ 
Horizontal=�.+��� #��[ .��
Key Word�� #��[ $	��200��$��2q� . ���� *	KeyWord+.�� J� InputBindings �� 
 �� Key$ Enter�� �� Command ��  �� Path$ cmdSearchOnEnter�.���� $��5q�$��15(� d� 	IsChecked �� *isCheckedRefNo+.��Ref No�� $��5q�$��15(� �� *isCheckedSubject+.��	Subject�� $��5q�$��15(� �� *isCheckedFrom+.��From�� $��5q�$��15(� �� *isCheckedTo+.��To�� $��5q�$��15(� �� *isCheckedComments+.��
Comments�� $ 
Horizontal=�$
��Auto��$��0,0,0,2q�.+��� #��[ .���� $�	From Date��  $��25��$��15(� �� *
FromDate+�� #��[ .���� $�To Date��  $��10,0,0,0q�$��25��$��15(� �� *ToDate+�� #��[ $
��Auto������ *	cmdSearch+.���� $ 
Horizontal=�.+��� $&�� /LTS;component/Images/search.png��$��2q��� $��30��$��25��$��4,4,0,0q�$y�Hidden=����� *	cmdexport+.���� $ 
Horizontal=�.+��� $#��/LTS;component/Images/xls.png��$��Uniform=�&   System.Windows.Controls.DataGrid  -   $	��400��   AlternatingRowBackground �	#FFDDE4E6
�������   RowHeaderWidth$ 0Q�   CanUserAddRows .   � Cursor$
 Hand��   AutoGenerateColumns .  $��2q����� *SearchResult+   ColumnHeaderStyle ��  �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  .���  �� Property � �� �� Value �	#FF48958C��  � ��
 �������  � ��$ Center=���  � ��$ 	Tangerine)���  � ��$ 15(���  � ��$ Medium"�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Id��   Width5  /System.Windows.Controls.DataGridLengthConverter$ 30 1	  +System.Windows.Controls.DataGridBoundColumn 	  Binding �� *ID+  $ Reference No��$	 100  �� *ReferenceNumber+  $ Subject��$	 200  �� *	Subject+  $ Arrival Date��$	 100  �� *RecivedDate+  $
 From��$	 100  �� *From+  $ To��$	 100  �� *To+  $ Comments��$	 100  �� *
Comments+�� $��Right=�$��0q�y��� *isfiledownloaded+ �� 	Converter# [  File Downloaded Successfully