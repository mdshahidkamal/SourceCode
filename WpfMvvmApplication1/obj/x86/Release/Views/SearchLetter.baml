   M S B A M L   `   `   `  ���� p  lSystem.Windows.Controls.Input.Toolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35pTclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Input.ToolkitSystem.Windows.Controls  > :SMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:HospitalManagementSystem.Converters#HospitalManagementSystem.Converters O,clr-namespace:HospitalManagementSystem.ViewsHospitalManagementSystem.Views -   'LetterTrackingSystem.Views.SearchLetter   aControlsTclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Input.Toolkit  W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     Clocal1clr-namespace:HospitalManagementSystem.Converters     =view,clr-namespace:HospitalManagementSystem.Views     $
��Auto��$
��Auto��  � 	Resources  C  =HospitalManagementSystem.Converters.BoolToVisibilityConverter   BoolToHiddenConverter   	TrueValue   
FalseValue��%*   &	          $ Visible=�$ Hidden=�.��� .+��� 
������ $��1q�$��5q�._��� $	��584��.+��� $��Stretch=�$
��Auto��$��1q����	#FF48958C.+��� $
��Auto��$
��Left=�$��15(����	#FFF7F3F3.��Search�� ���	#FF48958C$��1q�$��1q�._��� .+���  �� Orientation$ 
Horizontal=�.+���   
labelstyle#��[ .��
Key Word��   textboxstyle#��[ $	��200��$��2q� �� 	IsEnabled . ���� *	KeyWord+.�� J� InputBindings �� 
 �� Key$ Enter�� �� Command ��  �� Path$ cmdSearchOnEnter�.���� $��5q�$��15(�	 d� 	IsChecked	 �� *isCheckedRefNo+.��Ref No�� $��5q�$��15(�	 �� *isCheckedSubject+.��	Subject�� $��5q�$��15(�	 �� *isCheckedFrom+.��From�� $��5q�$��15(�	 �� *isCheckedTo+.��To�� $��5q�$��15(�	 �� *isCheckedComments+.��
Comments�� $ 
Horizontal=�$
��Auto��$��0,0,0,2q�.+��� #��[ .���� $�	From Date��(  "System.Windows.Controls.DatePicker  $��25��$��15(�
   SelectedDate
 �� *
FromDate+�� #��[ .���� $�To Date��  $��10,0,0,0q�$��25��$��15(�
 �� *ToDate+��   loginbuttonstyle#��[ $
��Auto������ *	cmdSearch+.���� $ 
Horizontal=�.+��� $&�� /SMS;component/Images/search.png��$��2q��� $��30��$��25��$��4,4,0,0q�$y�Hidden=����� *	cmdexport+.���� $ 
Horizontal=�.+��� $#��/SMS;component/Images/xls.png��$��Uniform=�&   System.Windows.Controls.DataGrid  -   $	��400��   AlternatingRowBackground �	#FFDDE4E6
�������   RowHeaderWidth$ 0Q�   CanUserAddRows .   � Cursor$
 Hand��   AutoGenerateColumns .  $��2q����� *SearchResult+   ColumnHeaderStyle ��  �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  .���  �� Property � �� �� Value �	#FF48958C��  � ��
 �������  � ��$ Center=���  � ��$ 	Tangerine)���  � ��$ 15(���  � ��$ Medium"�   Columns 4  .System.Windows.Controls.DataGridTemplateColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Sr No��   CellTemplate �� .R��� ��  �� Command �� *cmdSearchWithID+ �� CommandParameter �� *ID+.��� .F��� ���� *ID+0  *System.Windows.Controls.DataGridTextColumn  $
 SrNo��   Width5  /System.Windows.Controls.DataGridLengthConverter$ 50    
IsReadOnly .    
Visibility$ 	Collapsed=�1	  +System.Windows.Controls.DataGridBoundColumn 	  Binding �� *ID+  $ Reference No��$	 150  .  �� *ReferenceNumber+  $ Arrival Date��$	 100  .  �� *RecivedDate+  $ Subject��$	 200  .  �� *	Subject+  $
 From��$	 150  .  �� *From+  $ To��$	 150  .  �� *To+  $ Comments��$	 300  .  �� *
Comments+�� $��Right=�$��0q�y��� *isfiledownloaded+ �� 	Converter# [  File Downloaded Successfully