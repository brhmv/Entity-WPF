   M S B A M L   `   `   `  ����B  >Entity3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Entity3.ViewsEntity3.Views  5   	   !    Entity3.Views.DriverAddView   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Entity3.Views     5   	     � Title$  DriverAddView��5   	    � WindowStartupLocation$ CenterScreen=�6   $	��450��6D   $	��600��6Q   
������.��5	      �� .+�5
   
   �� $��20(�6   $
��Bold"�6   $��	FirstName��60   $��Center=�6D    �� Left$ 50��6a   $	��Top=�6r   
 �� Top$ 3��6�   �� 5   
   $��20(�6   $
��Bold"�6   $��Username��60   $��Center=�6C   $	 333��6`   $	��Top=�6r   $ -3��6�   �� 5   
   $��20(�6   $
��Bold"�6   $��Password��60   $
��Left=�6C   $	 330��6^   $��Center=�6p   $ 69��6�   �� 5   
   $��30��67   $	��200��6C   $ 50��6O   $ 34��6`   $��Center=�6p   $	��Top=�6�   ��6   �� *NewDriver.FirstName+6�   �� 5   
   $��30��68   $	��200��6D   $	 333��6P   $	 245��6b   $��Center=�6s   $	��Top=�6�   ��6   �� *NewDriver.HomeAdress+6�   �� 5   
   $��30��66   $	��200��6B   $	 333��6N   $ 34��6`   $��Center=�6p   $	��Top=�6�   ��6   �� *NewDriver.Username+6�   �� 5   
   $��30��65   $	��200��6A   $	 333��6M   $	 172��6_   $��Center=�6p   $	��Top=�6�   ��6   �� *NewDriver.License+6�   �� 5   
   $��30��66   $	��200��6B   $	 333��6N   $	 102��6`   $��Center=�6q   $	��Top=�6�   ��6   �� *NewDriver.Password+6�   �� 5   
   $��20(�6   $
��Bold"�6   $��LastName��60   $ 47��6C   $ 73��6T   $��Center=�6d   $	��Top=�6�   �� 5   
   $��20(�6   $
��Bold"�6   $��Lisence��60   $	 328��6B   $	 139��6T   $��Center=�6e   $	��Top=�6�   �� 5   
   $��20(�6   $
��Bold"�6   $��Adress��60   $	 331��6A   $	 208��6S   $
��Left=�6d   $��Center=�6   �� 5   
   $��30��66   $	��200��6B   $ 50��6N   $	 109��6_   $��Center=�6p   $	��Top=�6�   ��6   �� *NewDriver.LastName+6�   �� 5   
   $��20(�6   $
��Bold"�6   $��Phone��60   $ 49��6@   $	 146��6Q   $��Center=�6b   $	��Top=�6   �� 5   
   $��30��63   $	��200��6?   $ 50��6K   $	 183��6\   $��Center=�6m   $	��Top=�6�   ��6   �� *NewDriver.Phone+6�   �� 5   
   $	��250��67   $	��100��6C   $ 46��6P   $	 289��6a   $��Center=�6�   $	��Top=�6�    �� SelectedItem 6   �� *SelectedCar+��6r   �� *CarListboxSource+��5      �� 5      .R�5      �  � ColumnDefinitions 5      �� 5      $	��300 �6/   �� 5       $	��110 �6/   .+�5"      �� $��0��6$   $��16(�6J   $��Center=�6X   $��Center=�6s    �� TextAlignment$ Center=�6�   ��64   �� *Name+6�   �� 5#      $��1��6$   $��16(�6L   $��Center=�6Z   $��Center=�6u   ��64   �� *Number+6u   5$      5%      5'      �� 5)   
   $ 47��6   $	 241��6'    �� Orientation$ 
Horizontal=�68   
�������$��Center=�6c   $	��Top=�6�   $	��250��6�   .+�5*      �� $��DemiBold"�6   $��25(�6*   $	��116��68   $��50��6D   $
��Name��6P   $��Center=�6_   $��Center=�6�   �� 5+      $��DemiBold"�6   $��25(�6*   $	��106��68   $��50��6D   $��Number��6P   $��Center=�6a   $��Center=�6�   5,      �� 5/   
   
�������$	��Add��6F   $��20(�6T   $
��Bold"�6b   $	��106��6t   $��30��6�   $	 367��6�   $	 325��6�   $
��Left=�6�   $	��Top=�6�   ��6   �� *
Add_Button+6�   50      51      