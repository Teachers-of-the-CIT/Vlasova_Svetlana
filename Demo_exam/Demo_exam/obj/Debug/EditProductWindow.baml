   M S B A M L   `   `   `  ????D  @Demo_exam, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Demo_exam	Demo_exam  5   	   !    Demo_exam.EditProductWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Demo_exam     5   	     ? Title$/  )Редактирование заказа??5   	   $	??450??6'   $	??800??64   $	??450??6@   $	??800??6P   .??5	      ?  ? RowDefinitions 5
   
   ?? 5      $??* ?6   ?? 5      $??* ?6   ?? 5      $??* ?6   ?? 5      $??* ?6   ?? 5      $??* ?6   ?? 5      $??* ?6   ?? 5      $??* ?6   ?? 5      $??* ?6   ?? 5      $??* ?6    ? ColumnDefinitions 5   
   ?? 5      $??* ?6   6+   ?? 5      $??* ?6   6+   .+?5   
   ?? -   5         ??Name$ TBNumber??5   1   $??0??6   $??0??6!   $??
Номер??6C   $??15(?6P   6`   ?? 5   
   -   5        $ 
TBCompound??5   1   $??1??6   $??0??6!   $??Описание??6E   $??15(?6U   6e   ?? 5   
   -   5        $ TBDateOfOrder??5   1   $??2??6   $??0??6!   $??Дата заказа??6H   $??15(?6[   6k   ?? 5   
   -   5        $ TBDateOfDelievery??5   1   $??3??6   $??0??6!   $??Дата доставки??6L   $??15(?6a   6q   ?? 5   
   -   5        $ TBPointOfIssue??5   1   $??4??6   $??0??6!   $??Пункт выдачи??6I   $??15(?6]   6m   ?? 5   
   -   5        $ TBClientSNP??5   1   $??5??6   $??0??6!   $??Фио клиента??6F   $??15(?6Y   6i   ?? 5   
   -   5        $ TBCodeOfRecieving??5   1   $??6??6   $??0??6!   $??Код получения??6L   $??15(?6a   6q   ?? 5    
   -   5        $ 	TBtStatus??5    1   $??7??6   $??0??6!   $??Статус??6D   $??15(?6R   6b   ?? 5#   
   -	   5         ??Name$ 	TeBNumber??5#   U   $??0??6*   $??1??67   $??15(?6G   $	??250??6h   ??6   ?? *Number+6v   ?? 5$   
   -
   5        $ TeBCompound??5$   W   $??1??6,   $??1??69   $??15(?6I   $	??250??6l   ??6   ?? *
Compound+6z   ?? 5%   
   -   5        $ TeBDateOfOrder??5%   Z   $??2??6/   $??1??6<   $??15(?6L   $	??250??6r   ??6   ?? *DateOfOrder+6?   ?? 5&   
   -   5        $ TeBDateOfDelievery??5&   ^   $??3??63   $??1??6@   $??15(?6P   $	??250??6z   ??6   ?? *DateOfDelievery+6?   ?? 5'   
   -   5        $ TeBPointOfIssue??5'   [   $??4??60   $??1??6=   $??15(?6M   $	??250??6t   ??6   ?? *PointOfIssue+6?   ?? 5(   
   -   5        $ TeBClientSNP??5(   X   $??5??6-   $??1??6:   $??15(?6J   $	??250??6n   ??6   ?? *	ClientSNP+6|   ?? 5)   
   -   5        $ TeBCodeOfRecieving??5)   ^   $??6??63   $??1??6@   $??15(?6P   $	??250??6z   ??6   ?? *CodeOfRecieving+6?   ?? 5*   
   -   5        $ 
TeBtStatus??5*   U   $??7??6*   $??1??67   $??15(?6G   $	??250??6i   ??6   ?? *Status+6w   ?? 5,   
   -   5         ??Name$ BtnSave??5,   F   $??8??6   $??2??6   $??Сохранить??62   $??15(?6W   6}   5-      5.      