   M S B A M L   `   `   `  ����   SMS0    *HospitalManagementSystem.Views.StaffSearch   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     .��� .+��� 
������ $��1q�$��5q�._��� .+��� $��Stretch=�$
��Auto��$��1q����	#FF48958C.+��� $
��Auto��$
��Left=�$��15(����	#FFF7F3F3.��Search�� ���	#FF48958C$��1q�$��1q�._��� .+���   �� Orientation$  
Horizontal=�.+��  � RowDefinitions �� �� �� ��  � ColumnDefinitions �� $	��25* ��� $	��25* ��� $	��25* ��� $	��25* �.+��� $��0��$��0��   
labelstyle#��[  .��Name�� $��0��$��2��#��[  .��Email Address�� $��0��$��1��  textboxstyle#��[ $	��283�� �� 	IsEnabled . ���� *Name+�� $��0��$��4��#��[ $	��283�� . ���� *EmailAddress+�� $  
Horizontal=�$
��Auto��$��Center=�.+���   loginbuttonstyle#��[ $
��Left=�$��67������ *	cmdSearch+.���� $  
Horizontal=�$
��Left=�.+��� $��Search���� $&�� /SMS;component/Images/Search.png��$��UniformToFill=�$��20���� -   #��[ $��Center=�$
��Auto��.���� $  
Horizontal=�$
��Left=�.+��� $��Add New Staff���� $&�� /SMS;component/Images/AddRed.png��$��UniformToFill=�$��2q�&   System.Windows.Controls.DataGrid  -   
�������   RowHeaderWidth$ 0Q�   CanUserAddRows .   � Cursor$
 Hand��   AutoGenerateColumns .  $��2q�"   VerticalScrollBarVisibility$ Visible=�$	��300��$��Center=����� *StaffDetailCollection+	   ColumnHeaderStyle	 �� 
 �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"
  .���  �� Property � �� �� Value �	#FF48958C��  � ��
 �������  � ��$ Center=���  � ��$ 	Tangerine)���  � ��$ 15(���  � ��$ Medium"�   	CellStyle �� *  $System.Windows.Controls.DataGridCell"
  .���  � ��$ Center=�   Columns 4  .System.Windows.Controls.DataGridTemplateColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ StaffID��   CellTemplate �� .R��� ��  �� Command �� *cmdSearchWithID+ �� CommandParameter �� *	StaffID+.��� .F��� ���� *	StaffID+0  *System.Windows.Controls.DataGridTextColumn  $
 Name��   Width5  /System.Windows.Controls.DataGridLengthConverter$	 200    
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *Name+  $ EmailAddress��$	 250  .  �� *EmailAddress+  $ Designation��$	 100  .  �� *Designation+  $ ContactNumber��$	 150  .  �� *ContactNumber+  $ Gender��$	 100  .  �� *Gender+  $ Address��$	 100  .  �� *	Address+  $ Image�� �� .R��� $��imgPhoto��$��80��$	��100������ *ImageSource+