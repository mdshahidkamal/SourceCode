   M S B A M L   `   `   `  ����  IMS    IMS.Views.BillSearch   5   	   U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Title$  Bill Search��5   	    � WindowStartupLocation$ CenterScreen=�5   	   $��675.265��6.    � 
ResizeMode$ NoResize=�5   	   .��5
      �� .+�5   
   �� 
������ $��1q�6+   $��5q�6?   ._�5      �� .+�5      �� ���	#FF48958C$��1q�61   $��1q�6E   ._�5      �� .+�5      ��  �� Orientation$ 
Horizontal=�6%   $y�Visible=�6>   .+�5      �  � RowDefinitions 5   "   �� 5   &   66   �� 5   &   66   �� 5   &   66   �� 5   &   66    � ColumnDefinitions 5   "   �� 5   &   $	��25* �67   6E   �� 5   &   $	��25* �67   6E   �� 5   &   $	��25* �67   6E   �� 5   &   $	��25* �67   6E   .+�5   "   �� $��0��6(   $��0��65      
labelstyle#��[  6E   .��6i   Bill Number6v   �� 5   "   $��3��6(   $��0��65   #��[  6E   .��6i   	From Date6t   �� 5    "   $��3��6(   $��2��65   #��[  6E   .��6i   	To Date6r   �� 5!   "   $��0��6*   $��1��67     textboxstyle#��[ 6_   $	��283��6�    �� 	IsEnabled . ��6G   �� *BillNo+6�   (  "System.Windows.Controls.DatePicker  5"   "   $��3��6Q   $��1��6^   $	��100��6n   $
��Left=�6z   $��25��6�      SelectedDate 6-   �� *
dtFromDate+6�     5#   "   $��3��6O   $��3��6\   $	��100��6l   $
��Left=�6x   $��25��6�    6-   �� *
dtToDate+6�   5$      5'      �� 5*      $ 
Horizontal=�6%   $
��Auto��6>   $��Center=�6L   .+�5+      ��   loginbuttonstyle#��[ 6%   $
��Left=�6m   $��67��6�   ��6O   �� *	cmdSearch+.��5,   "   �� $ 
Horizontal=�6-   .+�5-   &   �� $��Search��60   6@   �� 5.   &   $)��#/IMS;component/Images/SearchICO.ico��6,   $��UniformToFill=�6Y   $��20��6q   6   5/   #   50      52      53      54      &   System.Windows.Controls.DataGrid  55      -   5        
�������   GridLinesVisibility$
 None=�55   \   	   RowHeaderWidth$	 0Q�57      
   CanUserAddRows
 .   � Cursor$
 Hand��58   c      AutoGenerateColumns .  $��1q�5:      "   VerticalScrollBarVisibility$ Visible=�6(   $
��Auto��6N   $��Center=�6\   ��55      �� *lstBillDetailEntity+   	CellStyle 5=      �� 5>       �� 
TargetType*  $System.Windows.Controls.DataGridCell"  6    .�5?      ��  �� Property � �� �� Value$ Center=�6K   �� 5@       � ��$ Calibri)�6;   �� 5A       � ��$ 14(�69   6F   5B         ColumnHeaderStyle 5D      �� 5E      =  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6    .�5F      ��  � ��$ Center=�6K   �� 5G       � ��$ Calibri)�6;   �� 5H       � ��$ 14(�69   6F   5I         Columns 5K      4  .System.Windows.Controls.DataGridTemplateColumn  5L      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��61      Width5  /System.Windows.Controls.DataGridLengthConverter$ 30 6=      CellTemplate 5N      �� 5O   "   .R�5P   &   �� �� 5S   *   .�64   .�5T   2   �� .F�5U   !   �� ��6+   �� *BillId+5V   !   5W   +   5X   (   5Y   #   5[      0  *System.Windows.Controls.DataGridTextColumn  5]      $ Bill No��6-   $ 80 6Y      
IsReadOnly . 1	  +System.Windows.Controls.DataGridBoundColumn 	  Binding 6>   �� *BillNo+6d     5^      $ 	Bill Date��6-   $ 80 6}    .  6@   �� *
BillDate+ �� StringFormat$ {0:dd.MMM.yyyy}��6�     5_      $ Customer Details��6-   $	 250 6h    .  6G   �� *CustomerName+6t     5`      $ Total Amount��6-   $	 100 6c    .  6C   �� *TotalAmount+6o     5a      $ Discount��6-   $ 80 6\    .    
Visibility$ 	Collapsed=�6y    6?   �� *
Discount+6y     5b      $ Amount Recieveable��6-   $	 120 6p    . $ 	Collapsed=�6�    6I   �� *TotalofTotalAmount+6�   5h      5j      5k      5l      5m      