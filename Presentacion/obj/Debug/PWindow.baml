   M S B A M L   `   `   `  ????G  CPresentacion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:PresentacionPresentacion  5      A%clr-namespace:Presentacion.ViewModelsPresentacion.ViewModels  5          Presentacion.PWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:Presentacion     5      ;	viewModel%clr-namespace:Presentacion.ViewModels     5        ? DataContext  5
      -   'Presentacion.ViewModels.PersonViewModel  5   
   .??5      ? ???#FFFFFF ? ColumnDefinitions 5   
   ?? 5       ? RowDefinitions 5   
   ?? 5      $	??120 ?6   ?? 5      $??50 ?6   ?? 5      .+?5   
   ? $??0??6    5      ?? 5      $??1086* ?6#   ?? 5      $
??157* ?6#   .+?5      ?? -   5         ??Name$ labelTitulo??5      $
??auto??6)   $	??430??5       $	??110??5!      $
??Left=?6!   ???#FFFFFF$??55(?5#      $??0,5,0,5q?6>   ??6"   ?? *	Message+??5$      ?? 5%       ?? 
TargetType" ??6&   .R?5&      ??    primaryColor#??[  6!    ?? CornerRadius$ 0 , 40, 40, 0??5'   !   ._?5(      ?? $??Center=?6/   $??Center=?6L   5)      5*      5,      5-      ? 5/   
   $??1??6   $??RightToLeft=?50      .+?51      ??   labelButton#??[ 6   ???#000000$??20, 10, 20, 10q?52   *   $	??120??53      $??20(?6!   ??6/   ?? *ShowLoginViewCommand+.??6X   Cerrar Sesión55      ?? 56      -   5         ??Name$ btnRoom_Back??56      #??[ 6+   ???#000000$??20(?58   *   $??70??59      $
??auto??5:      ??57      ?? *	TextBtn+5;      5<      ? 5>   
   $??2??6    5?      ?? 5@      ?? 5A      $??29 ?6    .+?5D      ?? $??0??6   ???#908E8E$??
0, 2, 0, 2q?5E      ._?5F      ?? $
??Auto=?6   $??0, 0, 15, 0q?6O   .??5G      ?? -   5         ??Name$ contenedorPersonal??5G   !   $??0, 0, 0, 30q?6=   5H      5I      ?? 5J      $??1??6   ._?5K      ?? #??[  6   5L      5M      5N      5O      