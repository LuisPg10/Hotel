   M S B A M L   `   `   `  ????G  CPresentacion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Presentacion.ViewModelsPresentacion.ViewModels  5          Presentacion.Register   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;	viewModel%clr-namespace:Presentacion.ViewModels     5        ? DataContext  5
      /   )Presentacion.ViewModels.RegisterViewModel  5   
   .??5      ?? $
??Auto=?6   .??5   
   ? ???#FFFFFF ? ColumnDefinitions 5      ?? 5      $??* ?6#    ? RowDefinitions 5      ?? 5      ?? 5      $??48 ?6    .+?5      ?? $??0??6   $??Center=?6"   ._?5      ?? $??0??6    ?? Orientation$ Vertical=?6*   $	??400??6A   $??0, 10, 0, 0q?6M   .+?5      ??    labelTitular#??[  6   $??55(?6B   $	??276??5      .??6    Registrarse5      ?? 5!      $??0, 50, 0, 0q?6     placeHolder#???  5"      
 ? Tag$ Correo??5#      ??6'   ?? *Correo+.??6?   5$      ? 5&       5'      ?? 5(      ?? 5)      .+?5,      ?? $??0??6"   $??0, 15, 10, 0q?62   #???  5-      $??Center=?5.      $ Nombre??5/      ??6'   ?? *Nombre+.??6?   50      ?? 51      $??1??6#   $??0, 15, 0, 0q?63   #???  52      $??Center=?53      $ Usuario??54      ??6(   ?? *
UserName+.??6B   55      56      ?? 57      $??0, 15, 0, 12q?6   #???  58      $ Contraseña??59      ??6+   ?? *
Password+.??6E   5:      ?? 5<      $??Center=?6   $??15(?5=      $??0, 15, 0, 15q?6&   $??30??5>      
???  ????5?   )   ?? *ErrorMessage+5@      ?? 5B        btnMain#??[ 6   $??50(?5D      $??
0, 0, 0, 8q?6#   ??5C      ?? *ShowSuccessFullCommand+.??5D   7   	Registrar5F      ?? 5H      -   5         ??Name$ btnLogin??5H        labelButton#??[ 5J      $??
0, 5, 0, 0q?5K      ??5I      ?? *ShowLoginCommand+.??5K   )   Iniciar Sesión5M      5N      5O      ?? 5Q      $??1??6   $??RightToLeft=?6'   $ 
Horizontal=?5R      $??Bottom=?5S      $??0,0,0,10q?61   .+?5T      ?? $??Imagenes/facebook.png??6   $??30??5U      $??15, 5, 5, 0q?6'    ? Cursor$
 Hand??5V      5W      ?? 5X      $??Imagenes/tiktok.png??6   $??30??5Y      $??
0, 5, 5, 0q?6'   $
 Hand??5Z      5[      ?? 5\      $??Imagenes/twitter.png??6   $??30??5]      $??
0, 5, 0, 0q?6'   $
 Hand??5^      5_      5`      5a      5b      5c      