   M S B A M L   `   `   `  ���� O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem   IMS   IMS.Views.PaymentDetails   U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     6sys&clr-namespace:System;assembly=mscorlib     $	��170��$	��675��  � 
ResizeMode$  NoResize=� � WindowStartupLocation$ CenterScreen=� � Title$ Payment Details��.���� .+���    docborderstyle#��[  ._��� .+��� .+��  � ColumnDefinitions �� $	��110 ��� $	��110 ��� $	��110 ��� $	��110 ��� $	��110 ��� $	��150 � � RowDefinitions �� �� �� �� .+��� $��0��$��0��  
labelstyle#��[ .��Payment Type�� $��0��$��2��#��[ .��Payment Mode�� $��0��$��4��#��[ .��Payment Date�� $��1��$��0��#��[ .��Payment Amount�� -   $��cmbPaymentType��$��0��$��1��  comboboxstyle#��[ $ �� IsSynchronizedWithCurrentItem$
 TrueY� �� DisplayMemberPath$ 
StaticName�� �� SelectedValuePath$ StaticID��$	��100������ *lstPaymentType+ �� SelectedItem �� *SelectedPaymentType+	 �� UpdateSourceTrigger$	 PropertyChanged=�
 �� Mode$
 TwoWay=��� -   $��cmbPaymentMode��$��0��$��3��#��[ $
 TrueY�$ 
StaticName��$ StaticID��$	��100������ *lstPaymentMode+ �� *SelectedPaymentMode+$	 PropertyChanged=�$
 TwoWay=�(  "System.Windows.Controls.DatePicker  $��0��$��5��$	��100��$
��Left=�$��25��   SelectedDate �� *PaymentDate+�� -   $��txtPaymentAmout��$��1��$��1��$
��Left=�  textboxstyle#��[  �� 	MaxLength$ 10��$	��100������ *PaymentAmount+ �� Empty �� TargetNullValue# Z �� $��2��$��0��#��[ .��
Comments�� -   $��txtComment1��$��2��$��1��$��3�� �� TextWrapping$
 Wrap=� �� AcceptsReturn . $��40��$	 200��$	��Top=�$
��Left=�$
��Left=�#��[ ���� *
Comment1+�� .+��� -     loginbuttonstyle#��[ $��Center=�$
��Auto������ *cmdAddNewPayment+.����  �� Orientation$ 
Horizontal=�$
��Left=�.+��� $	��Add���� $&�� /IMS;component/Images/AddRed.png��$��UniformToFill=�$��2q�