   M S B A M L   `   `   `  ����@  <Popov, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PopovPopov  5          Popov.ViewPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      %localclr-namespace:Popov     5      -   5          N� Title$  ViewPage��5	      .��5      � 
������� � RowDefinitions 5   
   �� 5      $	��29* �6   �� 5      $
��196* �6   �� 5      $	��29* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DGridOrders��5         AutoGenerateColumns .     
IsReadOnly . $��1��6V      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Название��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6N   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� *Id+6Z     5      $ Пользователь��6%   $ * 6[    6;   �� *Users.Login+6g     5      $ Продукт��6%   $ * 6W    66   �� *Product.Name+6c     5      $ Имя��6%   $ * 6K    62   �� *Name+6W   4  .System.Windows.Controls.DataGridTemplateColumn  5      $
 auto 6)   	   CellTemplate	 5      �� 5      .R�5      �� $��BtnEdit��6=   -   5        $ ��Редактировать��5   %   6d   5      5       5$      �� 5%   
   -   5        
 ��Name$
 BtnDel��5%   $   $��Удалить��6   $	��150��6I   $��Right=�6U   $��2��6q   �� 5&   
   -   5        $
 BtnAdd��5&   $   $��Добавить��6   $	��150��6I   $
��Left=�6U   $��2��6p   �� 5*   
   $
��Left=�6   $��Продукт:��60   $��Center=�6@   �� 5+   
   -   5        $��
cmbProduct��5+   [    �� DisplayMemberPath$
 Name��6   $
��Left=�6m   $��60,0,0,0q�6�   $��Center=�6�   $��45��6�   $��80��6�   �� 5,   
   $
��Left=�6   $��	180,0,0,0q�6/   $��Пользователь:��6B   $��Center=�6W   �� 5-   
   -   5        $��txtName��5-      $��80��6   $��	260,0,0,0q�6N   $
��Left=�6a   �� 5.   
   -   5        $
 btnClear��5.   K   $	��120��6   $
��Left=�6   $��	360,0,0,0q�68   $��Очистить��6t   51      52      