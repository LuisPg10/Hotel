   M S B A M L   `   `   `  ????G  CPresentacion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:PresentacionPresentacion  5   	   A%clr-namespace:Presentacion.ViewModelsPresentacion.ViewModels  5   	       Presentacion.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Presentacion     5   	   ;	viewModel%clr-namespace:Presentacion.ViewModels     5   	   -   5          ?Name$  ventanaPrincipal??5   	   $	??629??5	   	    ? WindowStartupLocation$ CenterScreen=?5
   	   
?????? $
??1000??5   "    ? Title$ Hotel??6/    ? WindowStyle$
 None=?6=    ? AllowsTransparency .  ? 	Resources 5       ?? DataType,   &Presentacion.ViewModels.LoginViewModel   Presentacion.Login/   )Presentacion.ViewModels.RegisterViewModel   Presentacion.Register??%?   (??       5      *, +)(?? 2     5      *, +)?? 5   
   "  6   .R?5        5      ?? 5   
   "  6   .R?5        5      5      .??5      ? -   5         ?Name$ panelPrincipal??5       ? ColumnDefinitions 5   
   ?? 5      $??* ?6   .+?5   
   ?? ???#FFFFFF$??0??6&   ._?5      ? 	 ? RowDefinitions	 5       ?? 5"      $??40 ?6$   ?? 5$      $??* ?6$   .+?5'      ? -   5        
 ?Name$
 barraTitulo??5'      $??0??61   $??RightToLeft=?6>   
?????? .+?5,      ?? -   5        $??btnClose??5,         
StyleClose#??[  5-      .??6A   X5/      ?? 50      -   5        $??btnMaximize??50        
StyleBasic#??[ 51      .??6A   M53      ?? 54      -   5        $??btnMinimize??54      #??[ 55      .??6A   --57      58      ?? 5:      -   5         ??Name$ panelContenedor??5:   "   $??1??6;   ??6H   ?? *CurrentChildView+5;      5<      5=      5>      