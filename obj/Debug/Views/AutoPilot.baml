   M S B A M L   `   `   `  ����J  FFlightSimulator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:FlightSimulator.ViewsFlightSimulator.Views  5      %    FlightSimulator.Views.AutoPilot   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:FlightSimulator.Views     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $
��350* �6   6,   �� 5      $
��100* �6   6,    � ColumnDefinitions 5   
   �� 5      $
��225* �6   6.   �� 5      $
��225* �6   6.   .+�5   
   (� $��0��6   $��2��6"   $��0��66   .��5      �� -   5        $��myBox��5      $	��400��6#   $	��350��6/    �� AcceptsReturn . ��6<   �� *CurrBackground+ �� UpdateSourceTrigger$ PropertyChanged=���5      �� *	Content+$ PropertyChanged=�.��6h   5      5      (� 5   
   $��0��6   $��1��6"   $��Right=�6/   $��40��6K   $��45��6V   .��5      �� -   5        $��OK��5      $��40��6!   $��45��6,   $��OK��68   $��3q�6E   $
��Bold"�6P   ��5      �� *	OkCommand+5      5      (� 5   
   $��1��6   $��1��6"   $
��Left=�6/   $��40��6J   $��45��6U   .��5      �� -   5        $��Clear��5      $��40��6$   $��45��6/   $��Clear��6;   $��3q�6K   $
��Bold"�6V   ��5      �� *ClearCommand+5!      5"      5#      5$      