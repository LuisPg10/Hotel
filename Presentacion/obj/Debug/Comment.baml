   M S B A M L   `   `   `  ????G  CPresentacion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:PresentacionPresentacion  5   	       Presentacion.Comment   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Presentacion     5   	   -   5        $	??350??5   	   $	??800??6     ? WindowStyle$
  None=?6"    ? AllowsTransparency .  ? 
ResizeMode$ NoResize=?5	   	    ? ShowInTaskbar .  $??2q?5   	    ? WindowStartupLocation$ CenterOwner=?6   .??5      ? .+?5   
   ?? ???#908E8E$??3q?6'   ???#FFFFFF._?5      ?  ? ColumnDefinitions 5      ?? 5      $	??369 ?6'   ?? 5      .+?5      ?? $??0??6    ?? Padding$ 20, 0, 20, 0q?6)   ._?5      ?? $??Imagenes/Foto.png??6   5      ?? 5      $??1??6   $ 0, 17, 0, 0q?6)   ._?5      ?  ? RowDefinitions 5      ?? 5      $??60 ?6,   ?? 5      ?? 5       $??80 ?6,   ?? 5!      $??80 ?6,   .+?5$      ?? -   5         ??Name$ tituloHabitacion??5$       $??0??6:   $??30(?6G   ?? 5&      -   5        	 ??Name$	 textComentario??5&   "   $??1??6:      placeHolder#??[  6G   

 ? Tag$
 Inserte comentario??5'   "   $??10q?5(   &    ?? TextWrapping$
 Wrap=?5)   &   $??15(?6:   $
??Left=?5*   &   $	??Top=?5+   &    ?? TextAlignment$ Justify=?5,   &   ???#000000$??0, 0, 20, 0q?5.   &   $	??100??6;   .??6H   5/      ?? 51      $??2??6'   $
??Auto=?64   $??Disabled=?6Y   $??0,10,0,0q?6?   .??52      ??  ?? Orientation$ 
Horizontal=?6)   .+?53   "   ?? -   5        $ idHabitacion??53   (   $??20(?6>   ?? 54   "   -   5        $ NumHabitacion??54   (   $??20(?6?   $
??auto??55      ?? 56   "   -   5        $ tipoHabitacion??56   (   $??20(?6@   $
??auto??57      ?? 58   "   -   5        $ precioHabitacion??58   (   $??20(?6B   59      5:      ?? 5<      $??3??6!   ._?5=      ?? $??3??6)   $ 
Horizontal=?66   $??RightToLeft=?6O   .+?5>   "   ?? -   5         ??Name$ 	btnCancel??5>   )     btnActionBox#??[ 6<   $	??100??5?   %     enterCloseButton#??[ 5@   )   $??30, 0, 10, 0q?5A   %   .??6S   
Cancelar5C   #   ?? 5D   "   -	   5        $ 
btnComment??5D   )   #??[ 6=   .??5E   B   
Comentar5G   #   5H      5I      5J      5K      5L      5M      5N      5O      