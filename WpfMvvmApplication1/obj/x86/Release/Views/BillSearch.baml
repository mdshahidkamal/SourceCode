   M S B A M L   `   `   `  ����   IMS    IMS.Views.BillSearch   U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006       � Title$  Bill Search�� � WindowStartupLocation$ CenterScreen=�$��675.265�� � 
ResizeMode$ NoResize=�.���� .+��� 
������ $��1q�$��5q�._��� .+��� ���	#FF48958C$��1q�$��1q�._��� .+���  �� Orientation$ 
Horizontal=�$y�Visible=�.+��  � RowDefinitions �� �� �� ��  � ColumnDefinitions �� $	��25* ��� $	��25* ��� $	��25* ��� $	��25* �.+��� $��0��$��0��   
labelstyle#��[  .��Bill Number�� $��3��$��0��#��[  .��	From Date�� $��3��$��2��#��[  .��	To Date�� $��0��$��1��  textboxstyle#��[ $	��283�� �� 	IsEnabled . ���� *BillNo+(  "System.Windows.Controls.DatePicker  $��3��$��1��$	��100��$
��Left=�$��25��   SelectedDate �� *
dtFromDate+  $��3��$��3��$	��100��$
��Left=�$��25�� �� *
dtToDate+�� $ 
Horizontal=�$
��Auto��$��Center=�.+���   loginbuttonstyle#��[ $
��Left=�$��67������ *	cmdSearch+.���� $ 
Horizontal=�$
��Left=�.+��� $��Search���� $&�� /IMS;component/Images/Search.png��$��UniformToFill=�$��20��&   System.Windows.Controls.DataGrid  -   
�������   GridLinesVisibility$
 None=�	   RowHeaderWidth$	 0Q�
   CanUserAddRows
 .   � Cursor$
 Hand��   AutoGenerateColumns .  $��1q�"   VerticalScrollBarVisibility$ Visible=�$
��Auto��$��Center=����� *lstBillDetailEntity+   	CellStyle ��  �� 
TargetType*  $System.Windows.Controls.DataGridCell"  .���  �� Property � �� �� Value$ Center=�   Columns 4  .System.Windows.Controls.DataGridTemplateColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ ID��   Width5  /System.Windows.Controls.DataGridLengthConverter$ 30    CellTemplate �� .R��� �� .�.��� .F��� ���� *BillId+0  *System.Windows.Controls.DataGridTextColumn  $ Bill No��$ 80    
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *BillNo+  $ 	Bill Date��$ 80  .  �� *InvoiceDate+  $ Customer Details��$	 150  .  �� *SupplierName+  $ Total Amount��$ 80  .  �� *TotalAmount+  $ Discount��$ 80  .  �� *
Discount+  $ Amount Recieveable��$	 120  .  �� *TotalofTotalAmount+