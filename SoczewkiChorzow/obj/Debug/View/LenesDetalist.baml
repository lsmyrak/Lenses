   M S B A M L   `   `   `  ����J  FSoczewkiChorzow, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:SoczewkiChorzow.ViewSoczewkiChorzow.View  5   	   E'clr-namespace:SoczewkiChorzow.ModelViewSoczewkiChorzow.ModelView  5   	   (    "SoczewkiChorzow.View.LenesDetalist   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:SoczewkiChorzow.View     5   	   6vm'clr-namespace:SoczewkiChorzow.ModelView     5   	     � Title$  Soczewki Dodanie / Edycja��5	   	   $	��430��6+   $	��680��68    � DataContext 5
      .   (SoczewkiChorzow.ModelView.LensesDetalist  5   
   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��0��6   $��2��6#   $��Center=�67   .+�5      �� $��Soczewki Dodanie / Edycja��6   5      � 5   
   $��1��6   $��0��6   
����ح�$��	20,20,0,0q�6C    5      �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5      $
��auto �6    �� 5       $
��auto �6    �� 5!      $
��auto �6    �� 5"      $
��auto �6    �� 5#      $
��auto �6    �� 5$      $
��auto �6    �� 5%      $
��auto �6    �� 5&      $
��auto �6     5(      �� 5)      $
��auto �6#   �� 5*      $
��auto �6#   �� 5+      $
��auto �6#   .+�5-      �� $��Zrealizowazne��6   $��0��6/   $��0��6?   �� 5.      $��Nazwa Pacjenta��6   $��0��6/   $��1��6?   �� 5/      $��Nazwa Zabiegu��6   $��0��6.   $��2��6>   �� 50      $	��Oko��6   $��0��6$   $��3��64   �� 51      $
��Cena��6   $��0��6%   $��4��65   �� 52      $��Uwagi��6   $��0��6&   $��5��66   �� 53      $��Data Badania��6   $��0��6-   $��6��6=   �� 54      $��Lekarz Prowadzacy��6   $��0��62   $��7��6B   �� 55      $��Data Zabiegu��6   $��0��6-   $��8��6=   �� 56      $��Operator��6   $��0��6)   $��9��69   �� 57      $��Kartoteka Zaniesiona��6   $��0��65   $��10��6E   �� 59      $��1��67   $��0��6G   $	��200��6T    d� 	IsChecked 6   �� *Status+6T   �� 5:      $��1��65   $��1��6E   $	��200��6R   ��6   �� *PacjentName+6R   �� 5;      $��1��66   $��2��6F   $	��200��6S   ��6   �� *NazwaZabiegu+6S   �� 5<      $��1��6-   $��3��6=   $	��200��6J   ��6   �� *Oko+6J   �� 5=      $��1��6.   $��4��6>   $	��200��6K   ��6   �� *Cena+6K   �� 5>      $��1��6/   $��5��6?   $	��200��6L   ��6   �� *Uwagi+6L   :  4System.Windows.Controls.Primitives.DatePickerTextBox  5?      $��1��6?   $��6��6O   $	��200��6\   ��6    �� *DataBAdania+6\   �� 5@       �� 
IsEditable . $��1��6�   $��7��6�   $	��200��6�   ��6*   �� *LekarzProwadzacyList+ �� SelectedItem 6W   �� *LekarzProwadzacy+6�     5A      $��1��6?   $��8��6O   $	��200��6\   ��6    �� *DataZabiegu+6\   �� 5B       . $��1��6s   $��9��6�   $	��200��6�   ��6)   �� *OperatorList+ 6N   �� *	Operator_+6�   �� 5C      $��1��6C   $��10��6S   $	��200��6a    6   �� *KartotekaZaniesiona+6a   5D      � 5F   
   $��1��6   $��1��6   $��20,20,0,180q�6,   
������ 5G      �� 5H      $
��auto �6    �� 5I      $
��auto �6    �� 5J      $
��auto �6    �� 5K      $
��auto �6     5M      �� 5N      $
��auto �6#   �� 5O      $
��auto �6#   .+�5Q      �� $��Data Zamoienia��6   $��0��6/   $��0��6?   �� 5R      $��
Nazwa Moce��6   $��0��6+   $��1��6;   �� 5S      $��Data Dostawy��6   $��0��6-   $��2��6=   �� 5T      $��Uwagi��6   $��0��6&   $��3��66     5V      $��1��6C   $��0��6S   $	��200��6`   ��6    �� *DataZamowienia+6`   �� 5W      $��1��64   $��1��6D   $	��200��6Q   ��6   �� *
NazwaMoceE+6Q     5X      $��1��6?   $��2��6O   $	��200��6\   ��6    �� *DataDostawy+6\   �� 5Y      $��1��60   $��3��6@   $	��200��6M   ��6   �� *UwagiE+6M   5Z      � 5\   
   $��Center=�6   $��2��61   $��3��6E   $��Bottom=�6R   .+�5]      �� $��Anuluj��6   �� 5^      $��Zapisz��6   ��6&   �� *	CmdSave+5_      5a      5b      