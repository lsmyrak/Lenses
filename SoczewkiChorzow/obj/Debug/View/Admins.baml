   M S B A M L   `   `   `  ����J  FSoczewkiChorzow, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:SoczewkiChorzow.ViewSoczewkiChorzow.View  5   	   E'clr-namespace:SoczewkiChorzow.ModelViewSoczewkiChorzow.ModelView  5   	   !    SoczewkiChorzow.View.Admins   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:SoczewkiChorzow.View     5   	   6vm'clr-namespace:SoczewkiChorzow.ModelView     5   	     � Title$B  <Prywatny Szpital Weiss Klinik - Administracja Użytkownikami��5   	   $	��450��6M   $	��800��6Z    � DataContext 5	      '   !SoczewkiChorzow.ModelView.UsersMV  5
   
   .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   c� .@�5      �� $
��Nowy��6   ��6$   �� *CmdAdd+�� 5      $��Edytuj��6   ��6&   �� *	CmdEdit+��6B   ��  �� ElementName$
 grid���� 5      $��Usuń��6   ��6%   �� *	CmdRemove+��6C   �� $
 grid���� 5      �� 5      5      &   System.Windows.Controls.DataGrid  5   
   -   5        $
��grid��5      $��1��6    $	��400��6K      AutoGenerateColumns .  ��6-   �� *Users+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Imie��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *Name+6N     5      $ Nazwisko��6%    67   �� *	Surname+6U     5      $ Login��6%    64   �� *Login+6P     5      $ Hasło��6%    64   �� *
Password+6S     5      $ Status��6%    65   �� *Status+6R     5       $
 Rola��6%    63   �� *Rola+6N     5!      $ Uprawnienia��6%    6:   �� *Uprawnienia+6\     5"      $ Adres��6%    5#      `� 5$       �� StringFormat$ 	{0} x {1}��6'   .1�5%      �� 	 �� Path$	 Address.Misto�6&   �� 5&      $	 Address.Ulica�6&   5'      5)      5+      5,      5-      