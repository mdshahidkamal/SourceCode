   M S B A M L   `   `   `  ����>  :IMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:HospitalManagementSystem.Converters#HospitalManagementSystem.Converters  5      p lSystem.Windows.Controls.Input.Toolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35pTclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Input.ToolkitSystem.Windows.Controls 5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5          IMS.Views.InvoiceDetails   5      U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Clocal1clr-namespace:HospitalManagementSystem.Converters     5      iControlsTclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Input.Toolkit     5      6sys&clr-namespace:System;assembly=mscorlib     5      $
��Auto��5	      $
��Auto��6   .��5      �� .+�5      �� .+�5      ��    stackpanelstyle1#��[  6   .+�5      �� $
��Auto��6   $
��Left=�6,     header2#��[ 6H   .��6k   Invoice Details5      5      �� 5      .+�5      ��   simpleborder#��[ 6   ._�5      �   � ColumnDefinitions  5      �� 5   "   $��80 �63   6@   �� 5   "   $	��250 �63   6A   �� 5   "   $��80 �63   6@   �� 5   "   65    � RowDefinitions 5      �� 5   "   62   �� 5    "   62   .+�5#      �� $��0��6$     
labelstyle#��[ 64   .��6Y   
Invoice No6e   �� 5$      $��0��6$   $��2��61   #��[ 6A   .��6g   Invoice Date6u   �� 5%      $��2��6$   $��0��61   #��[ 6A   .��6g   
Supplier6q   �� 5'      -   5        $��txtInvoiceNo��5'   &   $��0��6U   $��1��6b   $
��Left=�5(   !     textboxstyle#��[ 6<   $	��100��6b    �� 	MaxLength$ 20��5)   !   ��5'   :   �� *	InvoiceNo+5)   !   (  "System.Windows.Controls.DatePicker  5*      $��0��6N   $��4��6[   $	��100��6k   $
��Left=�6w   $��25��6�      SelectedDate 6)   �� *InvoiceDate+6�   �� 5+      -   5        $��cmbSupplier��5+   '   $��2��6:   $��1��6G   $	��250��6W     comboboxstyle#��[ 5,   "   $ �� IsSynchronizedWithCurrentItem$
 TrueY�5/   "    �� DisplayMemberPath$ 
StaticName��50   "    �� SelectedValuePath$ StaticID��51   "   ��5-   "   �� *lstSuppliers+ �� SelectedItem 5.   "   �� *SelectedSuppliers+ �� UpdateSourceTrigger$ PropertyChanged=�	 �� Mode$	 TwoWay=�54      56      57      58      �� 5:      $��10��6   5<      �� 5=      #��[ 6   ._�5>      �� .+�5?      �� $
��Auto��6%     stackpanelstyle2#��[ 62   .+�5@      �� #��[ 6    $
��Auto��6E   $
��Left=�6T   .��6p   Product Details5B      5C      &   System.Windows.Controls.DataGrid  5D      -   5        
�������
   GridLinesVisibility$

 None=�5D   _      RowHeaderWidth$ 0Q�5F         CanUserAddRows .   � Cursor$
 Hand��5G   e      AutoGenerateColumns .  "   VerticalScrollBarVisibility$ Visible=�5I      $
��Auto��6C   $��Center=�6Q   ��5D   %   �� *lstParticulars+   	CellStyle 5M      �� 5N   "    �� 
TargetType*  $System.Windows.Controls.DataGridCell"  6(   .�5O   &   ��  �� Property � �� �� Value$ Center=�6S   �� 5P   &    � ��$ Calibri)�6C   �� 5Q   &    � ��$ 14(�6A   6N   5R   #      ColumnHeaderStyle 5T      �� 5U   "   =  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6(   .�5V   &   ��  � ��$ Center=�6S   �� 5W   &    � ��$ Calibri)�6C   �� 5X   &    � ��$ 14(�6A   6N   5Y   #      Columns 5\      4  .System.Windows.Controls.DataGridTemplateColumn  5]   "   ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 10 6:      CellTemplate 5_   &   �� 5`   *   .R�5a   .   �� �� 69   .�6C   .�5b   2   �� .F�5c   !   �� -   5        .��5c   ?   X6B   5d   !   65   5e   /   5f   +   5h   #   0  *System.Windows.Controls.DataGridTextColumn  5j   "      Header$ Product Name��65   $	 400 6k      
IsReadOnly . 1	  +System.Windows.Controls.DataGridBoundColumn 	  Binding 6K   �� *ProductName+6w     5k   "   $ Quantity��65   $ 60 6d    .  6G   �� *
Quantity+6o     5l   "   $
 Rate��65   $ 60 6\    .  6C   �� *Rate+6g     5m   "   $	 Per��65   $ 60 6^    .  6B   �� *	PerName+6i     5n   "   $ Amount��65   $ 90 6`    .  6E   �� *Amount+6k     5o   "   $ Other Charges��65   $ 90 6m    .    
Visibility$ 	Collapsed=�6�    6L   �� *OtherCharges+6�     5p   "   $ Taxable Amount��65   $ 90 6�    .  6M   �� *TaxableAmount+ �� StringFormat$ {0:#.##}��6�     5q   "   $
 CGST��65   $ 30 6\    .  6C   �� *CGST+6g     5r   "   $
 SGST��65   $ 30 6\    .  6C   �� *SGST+6g     5s   "   $
 IGST��65   $ 30 6\    .  6C   �� *IGST+6g     5t   "   $	 Tax��65   $ 90 6_    .  6B   �� *
TotalTax+6j     5u   "   $ TotalAmount��65   $ 90 6�    .  6J   �� *TotalAmount+$ {0:#.##}��6�   5x      �� 5y      .+�5z      ��   formbuttonstyle#��[ 6!   $��
Particular��6p   $
��Left=�5{      $
��Auto��68   ��5z   K   �� *cmdOpenPopWindow+.��5|      ��  �� Orientation$ 
Horizontal=�6)   $
��Left=�6B   .+�5}   "   �� $	��Add��6,   69   �� 5~   "   $&�� /IMS;component/Images/AddRed.png��6(   $��UniformToFill=�6R   $��2q�6j   6w   5      5�      5�      5�      5�      5�      �� 5�   
   $��10��6   5�      �� 5�   
   #��[ 6   ._�5�      �� .+�5�      �� $
��Auto��6%   #��[ 62   .+�5�      �� #��[ 6$   $
��Auto��6I   $
��Left=�6X   .��6v   Payment Details5�      5�        5�      -   5        
�������$

 None=�5�   a   $ 0Q�5�       .  $
 Hand��5�   e    .  $ Visible=�5�      $
��Auto��6C   $��Center=�6Q   ��5�   %   �� *lstPaymentDetail+ 5�      �� 5�   "   "  6(   .�5�   &   ��  � ��$ Center=�6S   5�   #    5�      �� 5�   "   "  6(   .�5�   &   ��  � ��$ Center=�6S   �� 5�   &    � ��$ Calibri)�6C   �� 5�   &    � ��$ 14(�6A   6N   5�   #    5�        5�   "   $ 10 6:    5�   &   �� 5�   *   .R�5�   .   �� �� 5�   2   .�6<   .�5�   2   �� .F�5�   !   �� -   5        .��5�   ?   X6B   5�   !   5�   3   5�   /   5�   +   5�   #     5�   "   $ Payment Type��65   $	 150 6k    .  6K   �� *PaymentType+6w     5�   "   $ Payment Mode��65   $	 150 6k    .  6K   �� *PaymentMode+6w     5�   "   $ Payment Date��65   $	 150 6k    .  6K   �� *PaymentDate+6w     5�   "   $ Amount��65   $ 60 6    .  6E   �� *PaymentAmount+$ {0:#.##}��6�     5�   "   $ Comment��65   $	 400 6d    .  6F   �� *
Comment1+6p   5�      �� 5�      .+�5�      �� #��[ 6   $��Payment��6l   $
��Left=�5�      $
��Auto��68   ��5�   G   �� *cmdOpenPopWindow+.��5�      �� $ 
Horizontal=�6%   $
��Left=�6>   .+�5�      �� $	��Add��6(   65   �� 5�      $&�� /IMS;component/Images/AddRed.png��6$   $��UniformToFill=�6N   $��2q�6f   6s   5�      5�      5�      5�      5�      �� 5�   
   $��10��6   5�      �� 5�   
   #��[ 6   ._�5�      �� .+�5�      �� $ 
Horizontal=�6'   .+�5�      �� .+�5�   "   �   5�   &   �� 5�   *   6=   �� 5�   *   6=   �� 5�   *   6=   �� 5�   *   6=    5�   &   �� 5�   *   6:   �� 5�   *   6:   �� 5�   *   6:   .+�5�   &   �� $��0��6,   $��0��69   #��[ 6I   .��6o   
Discount6y   �� 5�   &   $��1��6,   $��0��69   #��[ 6I   .��6o   
Comments6y   �� 5�   &   -   5        $��txtDiscount��5�   K   $��0��6.   $��1��6;   $
��Left=�5�   )   #��[ 6D   $ 10��6j   $	��100��6y   ��5�   ^   �� *
Discount+ �� Empty �� TargetNullValue# Z 5�   �   �� 5�   &   -   5        $��
txtComment��5�   .   $��1��6Y   $��1��6f     �� TextWrapping$
  Wrap=�5�      ! �� AcceptsReturn! . $��60��6G   $	 200��6T   $	��Top=�5�      $
��Left=�6=   $
��Left=�5�      #��[ 69   ��5�   @   �� *	Comment+5�   b   5�   #   5�      �� 5�      .+�5�   "   �   5�   &   �� 5�   *   $	��250 �6;   6I   �� 5�   *   $	��100 �6;   6I   �� 5�   *   $	��100 �6;   6I   �� 5�   *   $	��100 �6;   6I   �� 5�   *   $	��100 �6;   6I    5   &   �� 5  *   6:   �� 5  *   6:   �� 5  *   6:   �� 5  *   6:   �� 5  *   6:   �� 5  *   6:   �� 5  *   6:   .+�5
  &   �� #��[ 6,   $��0��6P   $��0��6]   .��6n   Total Invoice Amount6�   �� 5  &   #��[ 6,   $��1��6P   $��0��6]   .��6m   
Discount6w   �� 5  &   #��[ 6,   $��2��6P   $��0��6]   .��6m   Total Taxable Amount6�   �� 5  &   #��[ 6,   $��3��6P   $��0��6]   .��6m   	Total Tax6x   �� 5  &   #��[ 6,   $��4��6P   $��0��6]   .��6m   Total Payable Amount6�   �� 5  &   #��[ 6,   $��5��6P   $��0��6]   .��6m   Total Paid Amount6�   �� 5  &   #��[ 6,   $��6��6P   $��0��6]   .��6m   Total Outstanding Amount6�   �� 5  &     amountreadonly#��[ 6.   $��0��6V   $��1��6c   ��6s   �� *TotalInvoiceAmount+$ {0:#.##}��6�   �� 5  &   #��[ 6.   $��1��6V   $��1��6c   ��6s   �� *
Discount+$ {0:#.##}��6�   �� 5  &   #��[ 6.   $��2��6V   $��1��6c   ��6s   �� *TotalInvoiceTaxableAmount+$ {0:#.##}��6�   �� 5  &   #��[ 6.   $��3��6V   $��1��6c   ��6s   �� *TotalInvoiceTax+$ {0:#.##}��6�   �� 5  &   #��[ 6.   $��4��6V   $��1��6c   ��6s   �� *TotalofTotalAmount+$ {0:#.##}��6�   �� 5  &   #��[ 6.   $��5��6V   $��1��6c   ��6s   �� *TotalofTotalPaidAmount+$ {0:#.##}��6�   �� 5  &   #��[ 6.   $��6��6V   $��1��6c   
���  ����6s   �� *TotalOutStandingAmount+$ {0:#.##}��6�   5  #   5     5     5      5!     �� 5#  
   $��10��6   6#   �� 5$  
   $��Center=�6   $ 
Horizontal=�62   .+�5%     �� #��[ 6   $��Center=�6[   ��6?   �� *	cmdsave+.��5&     �� $ 
Horizontal=�6   .+�5'     �� $
��Save��6    6.   �� 5(     $'��!/IMS;component/Images/SaveICO.ico��6   $��UniformToFill=�6G   $��20��6_   6m   5)     5+     �� 5,     $��20��6   6&   �� 5-     -	   5        #��[ 5-     $��Center=�6V   .��5.     �� $ 
Horizontal=�6   .+�5/     �� $��Search��6    60   �� 50     $)��#/IMS;component/Images/SearchICO.ico��6   $��UniformToFill=�6I   $��20��6a   6o   51     53     54     57     5=     