   M S B A M L   `   `   `  ����>  :IMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:HospitalManagementSystem.Converters#HospitalManagementSystem.Converters  5      p lSystem.Windows.Controls.Input.Toolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35pTclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Input.ToolkitSystem.Windows.Controls 5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5          IMS.Views.Billing   5      U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Clocal1clr-namespace:HospitalManagementSystem.Converters     5      iControlsTclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Input.Toolkit     5      6sys&clr-namespace:System;assembly=mscorlib     5      $��653.5��5	        � 	Resources  5      C   =HospitalManagementSystem.Converters.BoolToVisibilityConverter   BoolToHiddenConverter   	TrueValue   
FalseValue��%A   &	          5   
   $ Visible=�5   
   $ Hidden=�6   5      .��5      � .+�5   
   ��  �� Orientation$ Vertical=�6   .+�5      �� $ Vertical=�6   $��5q�60   .+�5      ��   simpleborder#��[ 6   ._�5      �� .+�5      �� $
��Auto��6%     stackpanelstyle2#��[ 62   .+�5      ��   
labelstyle#��[ 6$   $
��Auto��6I   $
��Left=�6X   .��6t   Product Details5      5      �� 5      .+�5      &   System.Windows.Controls.DataGrid  
�������   GridLinesVisibility$ Vertical=�6c      RowHeaderWidth$ 0Q�5!         CanUserAddRows .   � Cursor$
 Hand��5"   6      AutoGenerateColumns .  "	   VerticalScrollBarVisibility$	 Visible=�5$      $
��Auto��6C   $��Center=�6Q   ��5   )   �� *lstParticulars+
   	CellStyle
 5(   "   �� 5)   &    �� 
TargetType*  $System.Windows.Controls.DataGridCell"  6,   .�5*   *   ��  �� Property � �� �� Value$ Center=�6W   �� 5+   *    � ��$ Calibri)�6G   �� 5,   *    � ��$ 14(�6E   6R   5-   '      ColumnHeaderStyle 5/   "   �� 50   &   =  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6,   .�51   *   ��  � ��$ Center=�6W   �� 52   *    � ��$ Calibri)�6G   �� 53   *    � ��$ 14(�6E   6R   54   '      Columns 56   "   4  .System.Windows.Controls.DataGridTemplateColumn  57   &   ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 10 6>      CellTemplate 59   *   �� 5:   .   .R�5;   2   �� �� 6=   .�6G   .�5<   2   �� .F�5=   !   �� -   5        .��5=   ?   X6B   5>   !   65   5?   3   5@   /   5B   '   0  *System.Windows.Controls.DataGridTextColumn  5D   &      Header$ Product Name��69   $	 400 6o      
IsReadOnly . 1	  +System.Windows.Controls.DataGridBoundColumn 	  Binding 6O   �� *ProductName+6{     5E   &   $ Quantity��69   $ 60 6h    .  6K   �� *
Quantity+6s     5F   &   $
 Rate��69   $ 60 6`    .  6G   �� *Rate+6k     5G   &   $	 Per��69   $ 60 6b    .  6F   �� *	PerName+6m     5H   &   $ Amount��69   $ 90 6d    .  6I   �� *Amount+6o     5I   &   $ Other Charges��69   $ 90 6q    .    
Visibility$ 	Collapsed=�6�    6P   �� *OtherCharges+6�     5J   &   $ Taxable Amount��69   $ 90 6�    .  6Q   �� *TaxableAmount+ �� StringFormat$ {0:#.##}��6�     5K   &   $
 CGST��69   $ 30 6`    .  6G   �� *CGST+6k     5L   &   $
 SGST��69   $ 30 6`    .  6G   �� *SGST+6k     5M   &   $
 IGST��69   $ 30 6`    .  6G   �� *IGST+6k     5N   &   $	 Tax��69   $ 90 6c    .  6F   �� *
TotalTax+6n     5O   &   $ TotalAmount��69   $ 90 6�    .  6N   �� *TotalAmount+$ {0:#.##}��6�   5R      5S      �� 5T      .+�5U      ��   loginbuttonstyle#��[ 6%   $
��Bill��6t   $��1��6�   $
��Left=�5V   %   $
��Auto��6@   ��5U   O   �� *cmdOpenPopWindow+.��5W   "   �� $ 
Horizontal=�6-   $
��Left=�6F   .+�5X   &   �� .��61   _Add67   �� 5Y   &   $&�� /IMS;component/Images/AddRed.png��6,   $��UniformToFill=�6V   $��2q�6n   6{   5[   #   5]      5^      5_      5`      �� 5a      $��10��6   6+   �� 5b        docborderstyle#��[ 6   ._�5g      �� .+�5h      �� $ 
Horizontal=�6'   .+�5i      �� .+�5j   "   �  � ColumnDefinitions 5k   &   �� 5l   *   6=   �� 5m   *   6=   �� 5n   *   6=   �� 5o   *   6=    � RowDefinitions 5q   &   �� 5r   *   6:   �� 5s   *   6:   �� 5t   *   6:   .+�5v   &   �� $��0��6,   $��0��69   #��[ 6I   $y�	Collapsed=�6m   .��6�   
Discount6�   �� 5w   &   $��1��6,   $��0��69   #��[ 6I   .��6o   Customer Details6�   �� 5y   &   -   5        $��txtDiscount��5y   K   $��0��6.   $��1��6;   $y�	Collapsed=�6�   $
��Left=�5z   )     textboxstyle#��[ 6D    �� 	MaxLength$ 10��6j   $	��100��6y   ��5y   ^   �� *
Discount+ �� Empty �� TargetNullValue# Z 5z   �   �� 5|   &   -   5        $��
txtComment��5|   .   $��1��6^   $��1��6k    �� TextWrapping$
 Wrap=�5}       �� AcceptsReturn . $��60��6G   $	 200��6T   $	��Top=�5~      $
��Left=�6=   $
��Left=�5      #��[ 69   ��5|   @   �� *CustomerName+5   b   5�   #   5�      �� 5�      .+�5�   "   �  5�   &   �� 5�   *   $	��250 �6;   6I   �� 5�   *   $	��100 �6;   6I   �� 5�   *   $	��100 �6;   6I   �� 5�   *   $	��100 �6;   6I   �� 5�   *   $	��100 �6;   6I    5�   &   �� 5�   *   6:   �� 5�   *   6:   �� 5�   *   6:   �� 5�   *   6:   �� 5�   *   6:   �� 5�   *   6:   �� 5�   *   6:   .+�5�   &   �� #��[ 6,   $��0��6P   $��0��6]   $y�	Collapsed=�6m   .��6�   Total Invoice Amount6�   �� 5�   &   #��[ 6,   $��1��6P   $��0��6]   $y�	Collapsed=�6m   .��6�   
Discount6�   �� 5�   &   #��[ 6,   $��2��6P   $��0��6]   .��6m   Total Taxable Amount6�   �� 5�   &   #��[ 6,   $��3��6P   $��0��6]   .��6m   	Total Tax6x   �� 5�   &   #��[ 6,   $��4��6P   $��0��6]   .��6m   Total Bill Amount6�   �� 5�   &   $y�	Collapsed=�6.     amountreadonly#��[ 6E   $��0��6m   $��1��6z   ��6�   �� *TotalInvoiceAmount+$ {0:#.##}��6�   �� 5�   &   #��[ 6.   $��1��6V   $��1��6c   $y�	Collapsed=�6s   ��6�   �� *
Discount+$ {0:#.##}��6�   �� 5�   &   #��[ 6.   $��2��6V   $��1��6c   ��6s   �� *TotalInvoiceTaxableAmount+$ {0:#.##}��6�   �� 5�   &   #��[ 6.   $��3��6V   $��1��6c   ��6s   �� *TotalInvoiceTax+$ {0:#.##}��6�   �� 5�   &   #��[ 6.   $��4��6V   $��1��6c   ��6s   �� *TotalofTotalAmount+$ {0:#.##}��6�   5�   #   5�      5�      5�      5�      �� 5�      #��[ 6   ._�5�      �� $��Center=�6!   $ 
Horizontal=�6>   .+�5�      ��   formbuttonstyle#��[ 6!   $��Center=�6f   ��6J   �� *	cmdsave+.��5�      �� $ 
Horizontal=�6%   .+�5�   "   �� .��6-   _Print65   �� 5�   "   $+��%/IMS;component/Images/PrinterIcon.png��6(   $��UniformToFill=�6W   $��20��6o   $��5,0,0,0q�6z   6�   5�      5�      �� 5�      -   5        #��[ 5�   !   $��Center=�6b   .��5�      �� $ 
Horizontal=�6)   .+�5�   "   �� .��6-   	_Search66   �� 5�   "   $)��#/IMS;component/Images/SearchICO.ico��6(   $��UniformToFill=�6U   $��20��6m   6{   5�      5�      5�      5�      5�      �� 5�      $y�Hidden=�6   .+�5�      �� 
������ $��1q�63   $��5q�6G   ._�5�      �� .+�5�      �� $��Stretch=�6%   $
��Auto��6C   $��1q�6Q   ���	#FF48958C.+�5�      �� $
��Auto��6%   $
��Left=�64   $��15(�6P   ���	#FFF7F3F3.��6w   Search5�      5�      �� 5�      ���	#FF48958C$��1q�69   $��1q�6M   ._�5�      �� .+�5�   "   �� $ 
Horizontal=�6-   $y�Visible=�6F   .+�5�   &   �  5�   *   �� 5�   .   6>   �� 5�   .   6>   �� 5�   .   6>   �� 5�   .   6>    5�   *   �� 5�   .   $	��25* �6?   6M   �� 5�   .   $	��25* �6?   6M   �� 5�   .   $	��25* �6?   6M   �� 5�   .   $	��25* �6?   6M   .+�5�   *   �� $��0��60   $��0��6=   #��[ 6M   .��6q   Bill Number6~   �� 5�   *   $��3��60   $��0��6=   #��[ 6M   .��6q   	From Date6|   �� 5�   *   $��3��60   $��2��6=   #��[ 6M   .��6q   	To Date6z   �� 5�   *   $��0��62   $��1��6?   #��[ 6j   $	��283��6�    �� 	IsEnabled . ��6O   �� *	FirstName+6�   (
  "System.Windows.Controls.DatePicker
  5�   *   $��3��6Y   $��1��6f   $	��100��6v   $
��Left=�6�   $��25��6�    
  SelectedDate 65   �� *
dtFromDate+6�   
  5�   *   $��3��6W   $��3��6d   $	��100��6t   $
��Left=�6�   $��25��6�    65   �� *
dtToDate+6�   5�   '   5�   #   �� 5�   "   $ 
Horizontal=�6-   $
��Auto��6F   $��Center=�6T   .+�5�   &   �� #��[ 6-   $
��Left=�6u   $��67��6�   ��6W   �� *	cmdSearch+.��5�   *   �� $ 
Horizontal=�65   $
��Left=�6N   .+�5�   .   �� $��Search��68   6H   �� 5�   .   $&�� /IMS;component/Images/Search.png��64   $��UniformToFill=�6^   $��20��6v   6�   5�   +   5�   '   5�   #   5�      5�        5�      -   5        
�������$
 None=�5�   b   $ 0Q�5�       .  $
 Hand��5�   c    .  $��1q�5�      $	 Visible=�6(   $
��Auto��6N   $��Center=�6\   ��5�   %   �� *lstInvoiceDetails+ 5�      �� 5   "   "  6(   .�5  &   ��  � �� �	#FF48958C6C   �� 5  &    � ��
 �����6C   �� 5  &    � ��$ Center=�6S   �� 5  &    � ��$ 	Tangerine)�6C   �� 5  &    � ��$ 12(�6A   �� 5  &    � ��$ Medium"�6C   5  #   
 5
     �� 5  "   "  6(   .�5  &   ��  � ��$ Center=�6S   5  #    5       5  "   $ ID��69   $ 30 6E    5  &   �� 5  *   .R�5  .   �� �� 69   .�6C   .�5  2   �� .F�5  !   �� ��6+   �� *	InvoiceID+5  !   65   5  /   5  +   5  #     5  "   $ 
Invoice No��65   $ 60 6g    .  6I   �� *	InvoiceNo+6r     5  "   $ Invoice Date��65   $ 80 6k    .  6K   �� *InvoiceDate+6v     5   "   $ Supplier��65   $	 150 6h    .  6G   �� *SupplierName+6t     5!  "   $ Product��65   $	 200 6f    .  6F   �� *ProductName+6r     5"  "   $ Quantity��65   $ 50 6d    .  6G   �� *
Quantity+6o     5#  "   $
 Rate��65   $ 50 6\    .  6C   �� *Rate+6g     5$  "   $	 Per��65   $ 40 6^    .  6B   �� *	PerName+6i     5%  "   $ Amount��65   $ 60 6`    .  6E   �� *Amount+6k   5)     5+     5,     5-     5/     50     51     