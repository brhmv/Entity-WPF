   M S B A M L   `   `   `  ����B  >Entity3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Entity3.ViewModelsEntity3.ViewModels  5   	       Entity3.Views.MainView   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Entity3.ViewModels     5   	     � Title$  MainView��5   	    � WindowStartupLocation$ CenterScreen=�6   $	��500��6?   $	��900��6L   
���2͚�.��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��6* �6   .+�5   
   �� .+�5      �� $��50��64   $	��Car��6@   $��0q�6N   $��26(�6b   $
��Bold"�6p   
��������6   �� *
Car_Button+6�   �� 5      
������$��0,10,0,0q�6O   $��50��6a   $��Driver��6m   $��0q�6~   $��26(�6�   $
��Bold"�6�   ��6   �� *Driver_Button+6�   5      �� 5   
   -   5        $��Content_Control��5   �   $��1��6�   $��Center=�6�   $��Center=�6�   ��6   �� *CurrentView+ �� NotifyOnSourceUpdated$
 True�� �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�6�   5      5      