   M S B A M L   `   `   `  ����J  FFlightSimulator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:FlightSimulator.ViewsFlightSimulator.Views  5   	   *    $FlightSimulator.Views.SettingsWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:FlightSimulator.Views     5   	     � Title$  Settings��5   	   $	��300��6   $	��400��6'   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��150* �6   6.   �� 5      $	��50* �6   6-   �� 5      $
��100* �6   6.    � RowDefinitions 5   
   �� 5      $	��60* �6   6+   �� 5      $	��60* �6   6+   �� 5      $	��60* �6   6+   �� 5      $	��60* �6   6+   �� 5      $	��60* �6   6+   .+�5   
   (� .��5      �� $��Flight Server IP:��6   $
��Bold"�62   6G   5      (� 5   
   $��1��6   .��5      �� $��Flight Info Port:��6   $
��Bold"�61   6E   5      (� 5   
   $��2��6   $��0��6   $��2��6/   .��5      �� $��Flight Command Port:��6   $
��Bold"�64   6H   5      (� 5   
   $��1��6   $��2��6"   $��0��66   .��5       �� $	��125��6   $��20��6"   $��5q�6.   $��Italic$�69   ��6L   �� *FlightServerIP+6o   5!      (� 5"   
   $��1��6   $��2��6"   $��1��66   .��5#      �� $	��125��6   $��20��6"   $��5q�6.   $��Italic$�69   ��6L   �� *FlightInfoPort+6p   5$      (� 5%   
   $��2��6   $��2��6#   .��5&      �� $	��125��6   $��20��6"   $��5q�6.   $��Italic$�69   ��6L   �� *FlightCommandPort+6r   5'      (� 5(   
   $��1��6   $��2��6"   $��3��66   $
��Left=�6D   .��5)      �� -   5        $��Cancel��5)      $��15(�6&   $��20��64   $��60��6@   $��4q�6K   $
��Bold"�6V   ��6h   �� *CancelCommand+6�   5*      (� 5+   
   $��0��6   $��3��6#   $��Right=�61   .��5,      �� -   5        $��ok��5,      $��15(�6"   $��20��60   $��60��6<   $��4q�6G   $
��Bold"�6R   ��6d   �� *ClickCommand+6�   5-      5.      5/      