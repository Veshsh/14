   M S B A M L   `   `   `  ����N  J14Budget_accounting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:_14Budget_accounting_14Budget_accounting  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089I2clr-namespace:System.Collections;assembly=mscorlibSystem.Collections 5   	   %    _14Budget_accounting.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:_14Budget_accounting     5   	   JCollections2clr-namespace:System.Collections;assembly=mscorlib     5   	   -   5          � Title$  
MainWindow��5	   	   $	��450��6   $	��800��6)   .��5
      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5       � ColumnDefinitions 5   
   �� 5      $��3* �6   �� 5      .+�5   
   (  "System.Windows.Controls.DatePicker  -   5          Name$ Picin��5      $��2��6B   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$
 Grid��5      $��1��6!      AutoGenerateColumns .  ��6J   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Date��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 64   �� *Date+	 �� UpdateSourceTrigger$	 PropertyChanged=�
 �� StringFormat$
 {0:dd.MM.yy}��  5      $
 Name��6%    64   �� *Name+$	 PropertyChanged=�  5      $
 Mony��6%    64   �� *Mony+$	 PropertyChanged=�4  .System.Windows.Controls.DataGridCheckBoxColumn  5      $ Pluss��6)    69   �� *Pluss+$	 PropertyChanged=�4  .System.Windows.Controls.DataGridComboBoxColumn  5      -   5        TypeList��$	 Typ��5   ;      SelectedItemBinding 6H   �� *Typ+$	 PropertyChanged=�5      � 5   
   $��1��6   $��1��6    5      �� 5      �� 5       �� 5!      �� 5"      �� 5#       5%      �� 5&      .+�5(      �� -   5        $��0��5(      $$��Новый тип записи��6"   6=   �� 5)      -   5        $��1��5)      $��Новая запись��6"   69   �� 5*      -   5        $��2��5*      $+��%Сохранить изменения��6"   6@   �� 5+      -   5        $��3��5+      $!��Удалить запись��6"   6;   �� 5,      -	   5         ��Name$
 Cost��5,      $��4��6'   $��
Итог: ��64   
�������6B   5-      5.      5/      