   M S B A M L   `   `   `  ????G  CPresentacion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Presentacion.ViewModelsPresentacion.ViewModels  5          Presentacion.Login   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      <
viewModels%clr-namespace:Presentacion.ViewModels     5      @d2http://schemas.microsoft.com/expression/blend/2008     5        ? DataContext  5	      ,   &Presentacion.ViewModels.LoginViewModel  5
   
   .??5      ?? $
??Auto=?6   .??5   
   ? ???#FFFFFF ? ColumnDefinitions 5      ?? 5      $??* ?6#    ? RowDefinitions 5      ?? 5      ?? 5      $??48 ?6    .+?5      ?? $??0??6   $??Center=?6"   ._?5      ??  ?? Orientation$ Vertical=?6   $	??340??64   $??
0, 0, 0, 0q?5      .+?5      ??    labelTitular#??[  6   $??55(?6B   .??6P   Iniciar Sesión5      ?? 5       -   5         ??Name$
 user??5         placeHolder#??[ 6-   $??0, 50, 0, 0q?5!      
 ? Tag$ Usuario??5"   /   ??6   ?? *
UserName+.??6=   5#      ?? 5$      $??0, 15, 0, 18q?6   #??[ 64   $ Contraseña??5%   /   ??6   ?? *
Password+.??6@   5&      ?? 5(      $??Center=?6   $??15(?5)      $??0, 15, 0, 15q?6&   $??30??5*      
???  ????5+   )   ?? *ErrorMessage+5,      ?? 5.        btnMain#??[ 6   $??50(?5/      $??0, 0, 0, 12q?6#   ??50      ?? *ShowPersonViewModel+.??6=   Entrar52      ?? 54      -   5         ??Name$ btnRegister??54        labelButton#??[ 56      $??
0, 5, 0, 0q?57      ??55      ?? *ShowRegisterCommand+.??57   )   Crear Cuenta59      5:      5;      ?? 5=      $??1??6   $??RightToLeft=?6&   $ 
Horizontal=?5>      $??Bottom=?5?      $??0,0,0,10q?61   .+?5@      ?? $??Imagenes/facebook.png??6   $??30??5A      $??15, 5, 5, 0q?6'    ? Cursor$
 Hand??5B      5C      ?? 5D      $??Imagenes/tiktok.png??6   $??30??5E      $??
0, 5, 5, 0q?6'   $
 Hand??5F      5G      ?? 5H      $??Imagenes/twitter.png??6   $??30??5I      $??
0, 5, 0, 0q?6'   $
 Hand??5J      5K      5L      5M      5N      5O      