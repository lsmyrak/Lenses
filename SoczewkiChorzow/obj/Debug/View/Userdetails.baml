   M S B A M L   `   `   `  ����J  FSoczewkiChorzow, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:SoczewkiChorzow.ViewSoczewkiChorzow.View  5   	   E'clr-namespace:SoczewkiChorzow.ModelViewSoczewkiChorzow.ModelView  5   	   &     SoczewkiChorzow.View.Userdetails   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:SoczewkiChorzow.View     5   	   6vm'clr-namespace:SoczewkiChorzow.ModelView     5   	   -   5        $��Window��5	   	     � Title$  Uzytkownicy��5
   	   $	��350��6   $	��270��6*    � DataContext 5      .   (SoczewkiChorzow.ModelView.UserDetalissMV  5   
   .��5      � $��Center=�6   $��Center=�6(    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      $	��150 �6   .+�5"   
   �� $��Imię : ��6   $��0��6"   $��0��62   �� 5#   
   $��1��6   $��0��6#   ��60   �� *Name+�� 5$   
   $��Nazwisko : ��6   $��0��6&   $��1��66   �� 5%   
   $��1��6   $��1��6"   ��6/   �� *	Surname+�� 5&   
   $��Login : ��6   $��0��6#   $��2��63   �� 5'   
   $��2��6   $��2��6#   ��61   �� *Login+�� 5(   
   $��	Hasło : ��6   $��0��6#   $��3��63   �� 5)   
   $��1��6   $��3��6#   ��60   �� *
Password+�� 5*   
   $��
Aktywny : ��6   $��0��6%   $��4��65   �� 5+   
   $��1��6   $��4��6$    d� 	IsChecked 61   �� *Status+�� 5,   
   $��Rola : ��6   $��0��6"   $��5��62   �� 5-   
   $��1��6   $��5��6$   ��61   �� *
RoleList+ �� SelectedItem 6R   �� *Rola+ �� Mode$ TwoWay=��� 5.   
   $��Uprawnienie : ��6   $��0��6)   $��6��69   �� 5/   
   $��1��6   $��6��6$   ��61   �� *UprawnieniaList+ 6Y   �� *Uprawnienia+$ TwoWay=��� 50   
   $��	Miasto : ��6   $��0��6$   $��7��64   �� 51   
   $��1��6   $��7��6#   ��60   �� *Miasto+�� 52   
   $��Ulica : ��6   $��0��6#   $��8��63   �� 53   
   $��1��6   $��8��6#   ��60   �� *Ulica+�� 54   
   $��Numer : ��6   $��0��6#   $��9��63   �� 55   
   $��1��6   $��9��6#   ��60   �� *	NumerDomu+�� 56   
   $��Zapisz��6   $��0��6"   $��10��62   ��6@   �� *	CmdSave+�� 57   
   $��Anuluj��6   $��1��6"   $��10��62   ��6@   �� *
CmdCanncel+��6_   ��  �� ElementName$ Window��59      5:      