   M S B A M L   `   `   `  ????A  =Examen, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ExamenExamen  5          Examen.Client   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      &localclr-namespace:Examen     5      -   5          N? Title$  Client??5	      .??5      ? 
??????? ? RowDefinitions 5   
   ?? 5      $??50 ?6   ?? 5      ?? 5      $??50 ?6   .+?5   
   ??  ?? Orientation$ 
Horizontal=?6   .+?5      ?? 	Gender:6!   ?? 5      -   5        $??	CmbGender??5       ?? DisplayMemberPath$
 Name??5      62   ?? 5      Name:6   ?? 5      -   5        $??TxtFirstName??5   !   $??50??6   6Y   ?? 5      -   5        $??ClearBtn??5      $??50??6)   $??Сбросить??64   6`   5      &   System.Windows.Controls.DataGrid  5   
   -   5        $??DTGridClient??5       $??1??6      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 64      
IsReadOnly .    AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 	FirstName??6%   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 68   ?? *	FirstName+6X     5      $ LastName??6%   	 67   ?? *
LastName+6V     5      $ 
GenderCode??6%   	 69   ?? *Gender.Name+6[   4  .System.Windows.Controls.DataGridTemplateColumn  5       
   Width$

 auto 6)      CellTemplate 5!      ?? 5"      .R?5#      ?? $??BtnEdit??6=   -   5        $ ??Редактировать??5#   %   6d   5$      5&      5)      ?? 5+   
   -   5        $??BtnAdd??5+   K   $	??5pxq?6   $??Добавить??6   $??2??61   $
??75px??6>   6p   ?? 5,   
   -   5        $??BtnDel??5,   e   $	??5pxq?6   $??Удалить??6   $??2??60   $
??75px??6=   $
??Left=?6J   6?   5.      5/      