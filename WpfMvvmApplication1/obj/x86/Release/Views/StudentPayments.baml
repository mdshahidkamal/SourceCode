   M S B A M L   `   `   `  ���� p  lSystem.Windows.Controls.Input.Toolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35pTclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Input.ToolkitSystem.Windows.Controls   SMS4   .HospitalManagementSystem.Views.StudentPayments   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     iControlsTclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Input.Toolkit     R NMvvmDialogs, Version=2.0.1.0, Culture=neutral, PublicKeyToken=3d3b9708589bc73e8md/https://github.com/fantasticfiasco/mvvm-dialogs  $  MvvmDialogs.DialogServiceViews    IsRegistered  .  � 	Resources    savebuttonstyle_validation �� 
TargetType �� BasedOn �� Property �� Value �� Triggers �� Binding �� ElementName	 �� Path
 �� Value ^� 
Conditions �� Binding �� Value  trglabelstyle  showhidestackpanel  printbuttonstyle_validation��%�  &	        7��&	 �    7��&	 a    &	 �    �� " ��8   .���  � ��$ Normal$���  � ��$ 25����  � ��$ 1q���  �@�Cursor$
 Hand����  � {� .  ��  �� $ cmbFeesType��$
	 Text�
 
--Select--.a���  � {� .  ��  �� $ 	txtAmount��$
	 Text�
  .a���  � {� .  ^�  ��  �� $ cmbFeesType��$
	 Text� Reversal��  �� $ 
txtComment��$
	 Text�  .0���  � {� .  �� " ��8   .���  � ��$ Normal$���  � ��$ 25����  � y�$ Hidden=� ��  �� $ cmbFeesType��$
	 Text�
 Reversal.a���  � y�$ Visible=��� " ��.���  � y�$ 	Collapsed=� ��  �� $ 	rdbCheque��$	 	IsChecked�
 True.a���  � y�$ Visible=��� " ��.���  �@�Cursor$
 Hand�� ��  �� $ 	dg_Result��$	 PrintingChecked�
 Hold.a���  � {� . .��� .+��� .+��� $��Stretch=�$
��Auto��$��1q����	#FF48958C.+��� $
��Auto��$
��Left=�$��15(����	#FFF7F3F3.��Payment Details�� ���	#FF48958C$��1q�$��1q�._��� $��	0,10,0,10q�$��0��$��1�� �� Orientation$ 
Horizontal=�$��Center=�.+���   
labelstyle#��[ .��Search-   'System.Windows.Controls.AutoCompleteBox  -   $��txtMedicine��$��2q�$��30��   ValueMemberPath$ 	FirstName��   IsTextCompletionEnabled .    
FilterMode$ Contains=�  autocompleteboxstyle#��[ $	��300��$
��Left=�   ItemsSource �� *lstStudentDetails+   SelectedItem �� *SelectedStudentNew+ �� Mode$ TwoWay=�   
ItemFilter �� *StudentFilter+   ItemTemplate �� AutoCompleteBoxItemTemplate��.R��� $ 
Horizontal=�.+��� #��[ $
��Auto������ *	FirstName+�� #��[ $��Italic$�
����������� *EnrollmentNo+��   loginbuttonstyle#��[ $��30��$��30������ *cmdGetStudentDetails+.���� .+��� $&�� /SMS;component/Images/Search.png��$��UniformToFill=��� $��Stretch=�$
��Auto��$��1q����#F1C272.+��� $
��Auto��$
��Left=�#��[ .��Student Detail�� $ Vertical=�$
��Auto��.+��� ���	#FF48958C$��1q�$��1q�._�� $	��600��$
��Left=� � RowDefinitions �� �� �� �� �� �� �� ��  � ColumnDefinitions �� $	��25* ��� $	��50* ��� $	��25* �.+��� $��0��$��0��#��[ .��Academic Year�� $��1��$��0��#��[ .��Student Name�� $��2��$��0��#��[ .��EnrollMent No�� $��3��$��0��#��[ .��Fees Type *�� $��4��$��0��#��[ .��
Amount *�� $��5��$��0��#��[ .��Mode of Payment *�� $ 
Horizontal=�$��7��$��0��.+��� #��[ .��
Comments�� -   $��lblMandatoryComments��$��Center=�#��[ .��*�� $��2,2,0,2q�$
��Left=�$��0��$��1��  textboxstyle#��[ $	��250�� �� 
IsReadOnly . $
��Auto������ *AcademicYear+�� $��2,2,0,2q�$
��Left=�$��1��$��1��#��[ $	��250�� . $
��Auto������ *
FullName+�� $��2,2,0,2q�$
��Left=�$��2��$��1��#��[ $	��250�� . $
��Auto������ *EnrollmentNo+�� $��3��$��1��.+��� ���	#FF48958C$��0q�._��� ���� *lstFeesType+���� .R��� $��2q�$
��Left=�.+��� $��Center=�$ 
Horizontal=�.+���  d� 	IsChecked �� *IsCheckControl+ �� UpdateSourceTrigger$ PropertyChanged=�$ TwoWay=��� ���� *
StaticName+�� -   $��	txtAmount��$��2,2,0,2q�$��4��$��1��$	��250��#��[ $
��Left=�$
��Auto������ *Amount+�� $��5��$��1��$��Center=�$ 
Horizontal=�$��2q�.+�	�  	� 	GroupName$	 MOP�� �� *Cash+.��Cash	� -   $��	rdbCheque��$	 MOP�� �� *Cheque+.��Cheque�� $��2,2,0,2q�$��6��$��1��$��Center=�$ Vertical=�#��[ .+��  �� ��  �� $	��30* ��� $	��80* �.+��� $��0��$��0��.��	Cheque No�� $��1��$��0��$��2q�$	��150��#��[ $
��Left=�$
��Auto������ *
ChequeNo+�� $��0��$��1��.��Branch Details�� $��1��$��1��$
��Left=�$	��150��#��[  �� TextWrapping$
 Wrap=� �� AcceptsReturn . $��40��$	��Top=�$
��Left=����� *BankBranchDetails+�� $ Vertical=�$��7��$��1��.+��� -   $��
txtComment��$��2,2,0,2q�$
��Left=�$	��250��#��[ $
 Wrap=� . $��50��$	��Top=�$
��Left=����� *
Comments+�� #��[ 
���  ��$��11(�$��Italic$�.��(Please Fill Comments)�� $��2��$��0��$��4��$
��Left=�$	��100��.+��� -   $��imgPhoto��$	��100��$	��120������ *ImageSource+�� ���	#FF48958C$��1q�$��1q�._��� $
��Auto��$ 
Horizontal=�$��Center=�.+��� #��[  $��Center=�$
��Left=����� *	cmdsave+.���� $ 
Horizontal=�$
��Left=�.+��� $
��Save��$
��Left=��� $*��$/SMS;component/Images/save-icon2.png��$��UniformToFill=�$��20��$��5,0,0,0q��� -   #��[ $��Center=�$
��Left=����� *cmdGeneratePaymentReciept+.���� $ 
Horizontal=�$
��Left=�.+��� $��Print��$
��Left=��� $+��%/SMS;component/Images/PrinterIcon.png��$��UniformToFill=�$��20��$��5,0,0,0q��� $��Stretch=�$
��Auto��$��1q����#F1C272.+��� $
��Auto��$
��Left=�#��[ .��Payment History�� ���	#FF48958C$��1q�$��1q�._��� .+�&   System.Windows.Controls.DataGrid  -   $��	dg_Result��
�������   GridLinesVisibility$	 All=�    RowHeaderWidth$  0Q�!   CanUserAddRows! .  "   
IsReadOnly" . #   AutoGenerateColumns# .  $��2q�$��Center=����� *lstStudentPaymentDetails+$   ColumnHeaderStyle$ �� =  7System.Windows.Controls.Primitives.DataGridColumnHeader"  .���  � �� �#8ECACB��  � ��
 �   ���  � ��$ Center=���  � ��$ 	Tangerine)���  � ��$ 15(���  � ��$ Medium"�%   	CellStyle% �� *  $System.Windows.Controls.DataGridCell"  .���  � ��$ Center=�&   Columns& 4  .System.Windows.Controls.DataGridTemplateColumn  ,  &System.Windows.Controls.DataGridColumn'   Header$'  ��(   CellTemplate( �� .R�	� $ printingchecked�� �� *PrintingChecked+$ PropertyChanged=�$ TwoWay=�  $' 	Fees Type��( �� .R��� $��txtFeesType��$
��Left=�$��4��$��1��$	��250��$
��Wrap=�$
��Auto��$��2������ *PaymentType+0  *System.Windows.Controls.DataGridTextColumn  $' Amount��)   Width5	  /System.Windows.Controls.DataGridLengthConverter$	) 100	 *   
IsReadOnly* . 1
  +System.Windows.Controls.DataGridBoundColumn+ 
  Binding+ �� *Amount+  $' Payment Type��( �� .R��� $��txtPaymentType��$
��Left=�$��4��$��1��$	��250��$
��Wrap=�$
��Auto��$��2������ *ModeofPayment+  $' Comments��( �� .R��� $��
txtComment��$
��Left=�$��4��$��1��$	��250��$
��Wrap=�$
��Auto��$��2������ *
Comments+  $' Academic Year��$	) 150	 * . + �� *AcademicYear+  $
' Date��$	) 150	 * . + �� *CreatedDateTime+