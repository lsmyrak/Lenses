   M S B A M L   `   `   `  ����J  FSoczewkiChorzow, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:SoczewkiChorzowSoczewkiChorzow  5   	   E'clr-namespace:SoczewkiChorzow.ModelViewSoczewkiChorzow.ModelView  5   	        SoczewkiChorzow.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:SoczewkiChorzow     5   	   6vm'clr-namespace:SoczewkiChorzow.ModelView     5   	     � Title$.  (Prywatny Szpital Weiss Klinik - Soczewki��5	   	   $	��450��6:   $	��800��6G    � DataContext 5
      *   $SoczewkiChorzow.ModelView.SoczewkiMV  5   
   .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   c� .@�5      �� $��Wstaw��6   ��6%   �� *CmdAdd+�� 5      $��Edytuj��6   ��6&   �� *	CmdEdit+��6B   ��  �� ElementName$ 
ListLenses���� 5      $��Usuń��6   �� 5      �� 5      $��Archiwum zamówień��6   �� 5      �� 5      $��Administracja��6   
���  ��
���������6Q   �� *CmdADM+{�6l   �� *	CanEnable+5      &   System.Windows.Controls.DataGrid  5   
   -   5        $��
ListLenses��5      $��1��6%   $	��400��6K   ��62   �� 6K   5      5      