   M S B A M L   `   `   `  ����>  :IMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:HospitalManagementSystem.Converters#HospitalManagementSystem.Converters  5      p lSystem.Windows.Controls.Input.Toolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35pTclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Input.ToolkitSystem.Windows.Controls 5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      !    IMS.Views.ParticularDetails   5   	   U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Clocal1clr-namespace:HospitalManagementSystem.Converters     5      iControlsTclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Input.Toolkit     5      6sys&clr-namespace:System;assembly=mscorlib     5      $	��540��5	      $	��200��6     � 
ResizeMode$  NoResize=�6'    � Title$ Particular Details��5
       � WindowStartupLocation$ CenterScreen=�5      .��5      �� .+�5   
   ��    docborderstyle#��[  6   ._�5      �� .+�5      �� .+�5      �  � ColumnDefinitions 5      �� 5      $��* �6/   6;   �� 5      $��* �6/   6;   �� 5      $��* �6/   6;   �� 5      $��* �6/   6;   �� 5      $��* �6/    � RowDefinitions 5      �� 5#      6.   5,      5-      �� 5.      .+�5/      �  50      �� 51      $��80 �6/   6<   �� 52      $��55 �6/   6<   �� 53      $��40 �6/   6<   �� 54      $��55 �6/   6<   �� 55      $��40 �6/   6<   �� 56      $��55 �6/   6<   �� 57      $��90 �6/   6<   �� 58      $	��100 �6/   6=    5<      �� 5=      6.   �� 5>      6.   �� 5?      6.   �� 5@      6.   �� 5A      6.   �� 5B      6.   .+�5E      �� $��0��6    $��0��6-     
labelstyle#��[ 6=   .��6c   	Product6l   �� 5F      $��0��6    $��6��6-   #��[ 6=   .��6c   
HSN Code6m   �� 5H      $��1��6    $��0��6-   #��[ 6=   .��6c   
Quantity6m   �� 5I      $��1��6    $��2��6-   #��[ 6=   .��6c   Rate6i   �� 5J      $��1��6    $��4��6-   #��[ 6=   .��6e   Per6j   �� 5K      $��1��6    $��6��6-   #��[ 6=   .��6e   Amount6m   �� 5M      $��2��6    $��0��6-   #��[ 6=   $y�Hidden=�6a   .��6w   Other Charges6�   �� 5N      $��2��6    $��6��6-   #��[ 6=   .��6e   Taxable Amount6u   �� 5P      $��3��6    $��0��6-   #��[ 6=   .��6d   CGST6j   �� 5Q      $��3��6    $��2��6-   #��[ 6=   .��6e   SGST6k   �� 5R      $��3��6    $��4��6-   #��[ 6=   .��6c   IGST6i   �� 5S      $��3��6    $��6��6-   #��[ 6=   .��6e   Tax6j   �� 5U      $��4��6    $��6��6-   #��[ 6=   .��6e   Total Amount6s   -  'System.Windows.Controls.AutoCompleteBox  5W      -   5        $��txtDescription��5X   %   $��0��5W   4   $��1��6A   $��4��6Q     autocompleteboxstyle#��[ 6e      ValueMemberPath$ ProductName��5[   %      IsTextCompletionEnabled .    
FilterMode$ Contains=�5]   %   $
��Left=�5_   %   $
��Auto��6@   $��1,1,0,1q�6N   $	��188��6_      ItemsSource 5Y   %   �� *lstProducts+	   SelectedItem	 5Z   %   �� *SelectedProduct+
 �� Mode$
 TwoWay=�   
ItemFilter 5^   %   �� *ProductFilter+   ItemTemplate 5b      �� 5c   "   ItemTemplateProducts��.R�5d   &   ��  �� Orientation$ 
Horizontal=�61   .+�5e   *   �� #��[ 60   $
��Auto��5g   1   ��5f   1   �� *	ProductId+5g   1   �� 5h   *   #��[ 60   $��Italic$�5j   1   
���������5i   1   �� *ProductName+5k   1   5l   '   5m   #   5q      �� 5s      -   5        $��
txtHSNCode��5s   "   $��0��6M   $��7��6Z   $	��100��6k   $
��Left=�5t        textboxstyle#��[ 69    �� 	MaxLength$ 30��6_   ��5s   4   �� *	HSNCode+5t   q   �� 5v      -   5        $��txtQuantity��5v   "   $��1��6O   $��1��6\   $
��Left=�5w      #��[ 69   $��50��6`   $ 4��5x      $��1,1,0,1q�6,   ��5v   5   �� *
Quantity+5x   ]   �� 5y      -   5        $��txtRate��5y   "   $��1��6s   $��3��6�   $
��Left=�5z      #��[ 69   $ 10��5{      $��50��5|      $��1,1,0,1q�6)   ��5y   1   �� *Rate+ �� Empty �� TargetNullValue# Z 5|   =   �� 5~      -   5        $��cmbPer��5~   #   $��1��61   $��5��6>     comboboxstyle#��[ 5      $ �� IsSynchronizedWithCurrentItem$
 TrueY�5�       �� DisplayMemberPath$ 
StaticName��5�       �� SelectedValuePath$ StaticID��5�      $��50��5�      $��1,1,0,1q�6*   ��5�      �� *lstPer+ �� SelectedItem 5�      �� *SelectedPer+ �� UpdateSourceTrigger$ PropertyChanged=�$
 TwoWay=�5�      �� 5�      -   5        $��	txtAmount��5�   "   $��1��6w   $��7��6�   
�������$
��Left=�5�      #��[ 69   $ 10��6_   $	��100��6n   $��1,1,0,1q�6z   ��5�   3   �� *Amount+# Z 5�   �   �� 5�      -   5        $��txtOtherCharges��5�   6   $y�Hidden=�6"   $��2��6�   $��1��6�   $
��Left=�5�      #��[ 69   $ 10��6_   $��50��6n   $��1,1,0,1q�6y   ��5�   M   �� *OtherCharges+# Z 5�   �   �� 5�      -   5        $��txtTaxableAmount��5�   "   $��2��6�   $��7��6�   
�������$
��Left=�5�      #��[ 69   $ 10��6_   $	��100��6n   $��1,1,0,1q�6z   ��5�   :   �� *TaxableAmount+# Z 5�   �   �� 5�      -	   5        $��txtCGST��5�   "   $��3��6t   $��1��6�   $
��Left=�5�      #��[ 69   $ 10��6_   $��50��6n   $��1,1,0,1q�6y   ��5�   1   �� *CGST+# Z 5�   �   �� 5�      -
   5        $��txtSGST��5�   "   $��3��6s   $��3��6�   $
��Left=�5�      #��[ 69   $ 10��6_   $��50��6n   $��1,1,0,1q�6y   ��5�   1   �� *SGST+# Z 5�   �   �� 5�      -   5        $��txtIGST��5�   "   $��3��6s   $��5��6�   $
��Left=�5�      #��[ 69   $ 10��6_   $��50��6n   $��1,1,0,1q�6y   ��5�   1   �� *IGST+# Z 5�   �   �� 5�      -   5        $��txtTotalTax��5�   "   $��3��6{   $��7��6�   
�������$
��Left=�5�      #��[ 69   $ 10��6_   $	��100��6n   $��1,1,0,1q�6z   ��5�   5   �� *
TotalTax+# Z 5�   �   �� 5�      -   5        $��txtTotalAmount��5�   "   $��4��6�   $��7��6�   
�������$
��Left=�5�      #��[ 69   $ 10��6_   $	��100��6n   $��1,1,0,1q�6z   ��5�   8   �� *TotalAmount+# Z 5�   �   5�      5�      5�      5�      �� 5�   
   .+�5�      �� -   5          loginbuttonstyle#��[ 5�      $��Center=�6   $
��Auto��6�   ��6V   �� *cmdAddNewParticular+.��5�      �� $ 
Horizontal=�6   $
��Left=�66   .+�5�      �� $	��Add��6    6-   �� 5�      $&�� /IMS;component/Images/AddRed.png��6   $��UniformToFill=�6F   $��2q�6^   6k   5�      5�      5�      5�      5�      