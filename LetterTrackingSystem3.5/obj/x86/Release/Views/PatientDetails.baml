   M S B A M L   `   `   `  ���� p  lSystem.Windows.Controls.Input.Toolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35pTclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Input.ToolkitSystem.Windows.Controls  > :LTS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:HospitalManagementSystem.Converters#HospitalManagementSystem.Converters 3   -HospitalManagementSystem.Views.PatientDetails   aControlsTclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Input.Toolkit  W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Clocal1clr-namespace:HospitalManagementSystem.Converters     $
��Auto��$
��Auto��  � 	Resources  C  =HospitalManagementSystem.Converters.BoolToVisibilityConverter   BoolToHiddenConverter   	TrueValue   
FalseValue@  :HospitalManagementSystem.Converters.StreamToImageConverter  imageConverter��%9   &	        &	         $ Visible=�$ Hidden=�  .���� $��4q� �� Orientation$ 
Horizontal=�$
��Auto��.+��� .+��� 
���   �$��1q�$��5q�._��� .+��� $��0��$��Stretch=�$
��Auto��$��1q�$��2�����	#FF48958C.+��� $
��Auto��$
��Left=�$��12(����	#FFF7F3F3.��Letter Details�  � ColumnDefinitions �� $	��80* ��� $
��485* ��� $��8* � � RowDefinitions �� �� �� �� �� �� �� �� �� .+��� $��1��$��0��  
labelstyle#��[ .��
Image Path�� $��2��$��0��#��[ .��Reference No�� $��3��$��0��#��[ .��	Subject�� $��4��$��0��#��[ .��Arrival Date�� $��5��$��0��#��[ .��From�� $��6��$��0��#��[ .��To�� $��7��$��0��#��[ .��
Comments�� $ 
Horizontal=�$��1��$��1��$��2��.+��� -   $��txtFileName��$
��Left=�  textboxstyle#��[ $	��392�� �� TextWrapping$
 Wrap=����� *	Imagepath+�� -     loginbuttonstyle#��[ $��7��$��1��$��Center=�$��0,0,0,0q�$��25��$��85��.��Upload Image�� $��2��$��1��$
��Left=�#��[ $	��392�� �� 	IsEnabled . $��1,3,0,2q����� *ReferenceNumber+�� $��3��$��1��$
��Left=�#��[ $	��392�� . $��1,2,0,3q����� *	Subject+�� $��4��$��1��$��Center=�$��1q�$ 
Horizontal=�$��2��.+�(  "System.Windows.Controls.DatePicker  $��25��$	��100��$��11(�   SelectedDate �� *RecivedDate+�� $��5��$��1��$
��Left=�#��[ $	��392�� . $��1,2,0,3q����� *From+�� $��6��$��1��$
��Left=�#��[ $	��392��$
 Wrap=� . $��1,3,0,2q����� *To+�� $��7��$��1��$
��Left=�#��[ $	��392��$��50��	 �� AcceptsReturn	 . $
 Wrap=� . $��1,1,0,1q����� *
Comments+�� $��1q�$ 
Horizontal=�.+��� #��[ $��Center=����� *	cmdsave+.���� $ 
Horizontal=�.+��� .��_Save�� $$��/LTS;component/Images/save.png��$��2q��� 
���   �$��1q�$��5q�._��� .+��� $��Stretch=�$
��Auto��$��1q����	#FF48958C.+��� $
��Auto��$
��Left=�$��12(����	#FFF7F3F3.��Search�� $ 
Horizontal=�.+��� #��[ .��
Key Word�� #��[ $	��200��$��2q� . ���� *	KeyWord+.��
 J� InputBindings
 �� 
 �� Key$ Enter�� �� Command ��  �� Path$ cmdSearchOnEnter�.���� $��5q� d� 	IsChecked �� *isCheckedRefNo+.��Ref No�� $��5q� �� *isCheckedSubject+.��	Subject�� $��5q� �� *isCheckedFrom+.��From�� $��5q� �� *isCheckedTo+.��To�� $��5q� �� *isCheckedComments+.��
Comments�� $ 
Horizontal=�$
��Auto��$��0,0,0,2q�.+��� #��[ .���� $�	From Date��  $��25�� �� *
FromDate+�� #��[ .���� $�To Date��  $��10,0,0,0q�$��24�� �� *ToDate+�� #��[ $
��Auto������ *	cmdSearch+.���� $ 
Horizontal=�.+��� $&�� /LTS;component/Images/search.png��$��2q��� $��30��$��25��$��4,4,0,0q�$y�Hidden=����� *	cmdexport+.���� $ 
Horizontal=�.+��� $#��/LTS;component/Images/xls.png��$��Uniform=�&   System.Windows.Controls.DataGrid  -   $	��400��   AlternatingRowBackground �	#FFDDE4E6
�������   RowHeaderWidth$ 0Q�   CanUserAddRows .   � Cursor$
 Hand��   AutoGenerateColumns .  $��2q����� *SearchResult+   ColumnHeaderStyle ��  �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  .���  �� Property � �� �� Value �	#FF48958C��  � ��
 �������  � ��$ Center=���  � ��$ 	Tangerine)���  � ��$ 11(���  � ��$ Medium"�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Reference No��   Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 1	  +System.Windows.Controls.DataGridBoundColumn 	  Binding �� *ReferenceNumber+  $ Subject��$
 Auto  �� *	Subject+  $ Arrival Date��$
 Auto  �� *RecivedDate+  $
 From��$
 Auto  �� *From+  $ To��$
 Auto  �� *To+  $ Comments��$
 Auto  �� *
Comments+�� $��Right=�$��0q�y��� *isfiledownloaded+ �� 	Converter# [  File Downloaded Successfully�� .+��� 
���   �$��1q�$��5q�._��� .+��� ���	#FF48958C$��1q�.+��� $
��Auto��$
��Left=�$��12(����	#FFF7F3F3.��Letter Content�� $
��Left=�.+��� -   $��txtLetterContent��#��[ $
��Auto��$
 Wrap=����� *LetterContent+���� *ScreenWidth+