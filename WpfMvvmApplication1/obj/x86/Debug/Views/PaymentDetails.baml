   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5   	    IMS   IMS.Views.PaymentDetails   5   	   U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	   $	��170��6<   $	��675��6I     � 
ResizeMode$  NoResize=�6U    � WindowStartupLocation$ CenterScreen=�6k    � Title$ Payment Details��5   	   .��5      �� .+�5	   
   ��    docborderstyle#��[  6   ._�5
      �� .+�5      �� .+�5      �  � ColumnDefinitions 5      �� 5      $	��110 �6/   6=   �� 5      $	��110 �6/   6=   �� 5      $	��110 �6/   6>   �� 5      $	��110 �6/   6>   �� 5      $	��110 �6/   6>   �� 5      $	��150 �6/   6=    � RowDefinitions 5      �� 5      6.   �� 5      6.   �� 5      6.   �� 5      6.   .+�5      �� $��0��6    $��0��6-     
labelstyle#��[ 6=   .��6c   Payment Type6q   �� 5      $��0��6    $��2��6-   #��[ 6=   .��6c   Payment Mode6q   �� 5      $��0��6    $��4��6-   #��[ 6=   .��6c   Payment Date6q   �� 5      $��1��6    $��0��6-   #��[ 6=   .��6c   Payment Amount6s   �� 5!      -   5        $��cmbPaymentType��5!   #   $��0��69   $��1��6F     comboboxstyle#��[ 5"      $ �� IsSynchronizedWithCurrentItem$
 TrueY�5%       �� DisplayMemberPath$ 
StaticName��5&       �� SelectedValuePath$ StaticID��5'      $	��100��5(      ��5#      �� *lstPaymentType+ �� SelectedItem 5$      �� *SelectedPaymentType+	 �� UpdateSourceTrigger$	 PropertyChanged=�
 �� Mode$
 TwoWay=�5+      �� 5-      -   5        $��cmbPaymentMode��5-   #   $��0��69   $��3��6F   #��[ 5.      $
 TrueY�51      $ 
StaticName��52      $ StaticID��53      $	��100��54      ��5/      �� *lstPaymentMode+ 50      �� *SelectedPaymentMode+$	 PropertyChanged=�$
 TwoWay=�57      (  "System.Windows.Controls.DatePicker  59      $��0��6J   $��5��6W   $	��100��6g   $
��Left=�6s   $��25��6�      SelectedDate 6%   �� *PaymentDate+6�   �� 5;      -   5        $��txtPaymentAmout��5;   ?   $��1��6"   $��1��6/   $
��Left=�5<   )     textboxstyle#��[ 6D    �� 	MaxLength$ 10��6j   $	��100��6y   ��5;   V   �� *PaymentAmount+ �� Empty �� TargetNullValue# Z 5<   �   �� 5?      $��2��6    $��0��6-   #��[ 6=   .��6c   
Comments6m   �� 5A      -   5        $��txtComment1��5A   "   $��2��6O   $��1��6\   $��3��6m    �� TextWrapping$
 Wrap=�5B       �� AcceptsReturn . $��40��6G   $	 200��6T   $	��Top=�5C      $
��Left=�6=   $
��Left=�5D      #��[ 69   ��5A   5   �� *
Comment1+5D   b   5G      5H      �� 5I      .+�5J      �� -   5          loginbuttonstyle#��[ 5J      $��Center=�6�   $
��Auto��6�   ��6H   �� *cmdAddNewPayment+.��5K      ��  �� Orientation$ 
Horizontal=�6%   $
��Left=�6>   .+�5L      �� $	��Add��6(   65   �� 5M      $&�� /IMS;component/Images/AddRed.png��6$   $��UniformToFill=�6N   $��2q�6f   6s   5N      5O      5P      5Q      5R      5T      5U      