   M S B A M L   `   `   `  ����>  :IMS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:HospitalManagementSystem.Converters#HospitalManagementSystem.Converters  5      p lSystem.Windows.Controls.Input.Toolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35pTclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Input.ToolkitSystem.Windows.Controls 5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5          IMS.Views.InventoryReport   5      U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Clocal1clr-namespace:HospitalManagementSystem.Converters     5      iControlsTclr-namespace:System.Windows.Controls;assembly=System.Windows.Controls.Input.Toolkit     5      6sys&clr-namespace:System;assembly=mscorlib     5      $
��Auto��5	      $
��Auto��6   .��5
      � .+�5   
   ��    docborderstyle#��[  6   ._�5      �� .+�5      �� $
��Auto��6     stackpanelstyle2#��[ 6*   .+�5      ��   
labelstyle#��[ 6   $
��Auto��6A   $
��Left=�6P   .��6l   Inventory Details5      5      �� 5        savebuttonstyle#��[ 6   $
��Left=�6b   ��6B   �� *
cmdRefresh+.��5      ��   �� Orientation$  
Horizontal=�6!   .+�5      �� $��Refresh��6$   65   �� 5      $&�� /IMS;component/Images/reload.ico��6    $��UniformToFill=�6J   $��20��6b   6p   5      5      &   System.Windows.Controls.DataGrid  5      
�������   GridLinesVisibility$
 None=�6\      RowHeaderWidth$ 0Q�5         CanUserAddRows .   � Cursor$
 Hand��5   5      AutoGenerateColumns .  $��1q�5      "   VerticalScrollBarVisibility$ Visible=�6(   $	��500��6N   $��Center=�6[   ��5      �� *lstInventoryDetails+   	CellStyle 5"      �� 5#       �� 
TargetType*  $System.Windows.Controls.DataGridCell"  6    .�5$      �� 	 �� Property	 � ��
 �� Value$
 Center=�6K   �� 5%      	 � ��$
 Calibri)�6;   �� 5&      	 � ��$
 14(�69   6F   5'         ColumnHeaderStyle 5)      �� 5*      =  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6    .�5+      �� 	 � ��$
 Center=�6K   �� 5,      	 � ��$
 Calibri)�6;   �� 5-      	 � ��$
 14(�69   6F   5.         Columns 51      4  .System.Windows.Controls.DataGridTemplateColumn  52      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 10 62      CellTemplate 54      �� 55   "   .R�56   &   �� �� 61   .�6;   .�57   2   �� .F�58   !   �� -   5        .��58   ?   ...6D   59   !   65   5:   '   5;   #   5=      0  *System.Windows.Controls.DataGridTextColumn  5?         Header$ Product Name��6-   $	 400 6c      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 6C   �� *ProductName+6o     5A      $ Balance��61   $	 150 6B    5C      �� 5D   "   .R�5E   &   �� ��60   �� *
Quantity+��5F   *   �� 5G   .   " ��65    �� Triggers 5H   2   �� 5I   6    �� Binding 6B   �� *
Quantity+ �� ConverterParameter$ 0��  IsLowerThanConverter �� 	Converter# [  �� Value True6�   .a�5J   :   �� 	 � ��

 �����6X   �� 5K   :   	 � ��
 �#F080806X   5L   7   5N   /   5Q   '   5R   #   5T        5V      $	 Per��6-   $ 60 6V    .  6:   �� *	PerName+6a   5\      5]      5^      5_      5`      