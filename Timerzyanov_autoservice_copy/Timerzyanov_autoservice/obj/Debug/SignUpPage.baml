   M S B A M L   `   `   `  ����R  NTimerzyanov_autoservice, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Timerzyanov_autoserviceTimerzyanov_autoservice  5      (    "Timerzyanov_autoservice.SignUpPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:Timerzyanov_autoservice     5        N� Title$  
SignUpPage��5	       N� 
FontFamily$ 	Tw Cen MT)�6   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $+��%Наименование услуги��6   $��15(�6/   $��0��6=   $��0��6M   $
��Left=�5      $��Center=�6/   $��5q�6J   6W   �� 5   
   $'��!Длительность, мин.��6   $��15(�6.   $��0��6<   $��1��6L   $
��Left=�5      $��Center=�6/   $��5q�6J   6W   �� 5   
   $��ФИО Клиента��6   $��15(�6'   $��0��65   $��2��6E   $
��Left=�5      $��Center=�6/   $��5q�6J   6W   �� 5   
   $��Дата��6   $��15(�6    $��0��6.   $��3��6>   $
��Left=�5      $��Center=�6/   $��5q�6J   6W   �� 5    
   $��Время начала:��6   $��15(�6)   $��0��67   $��4��6G   $
��Left=�5!      $��Center=�6/   $��5q�6J   6W   �� 5"   
   -   5        $��TBTitle��5"      $��1��6!   $��0��61   $��30��6>   $��20(�6J   {�.  ��6X   �� *Title+6�   �� 5#   
   -   5        $��
TBDuration��5#      {�.  $��1��6P   $��1��6`   $��30��6m   $	��200��6y   $��20(�5$      $
��Left=�6    ��5#   $   �� *
Duration+5$   =   �� 5%   
   -   5        $��ComboClient��5%      $��1��6&   $��2��66   $��30��6C   $	��300��6O   $��15(�5&      $
��Left=�6!   ��5'      �� 5(      .R�5)      ��  �� Orientation$ 
Horizontal=�6!   .+�5*      �� ��6    �� *Imya+6;   �� 5+      ��6    �� *
Familiya+6?   �� 5,      ��6    �� *	Otchestvo+6@   5-      5.      50      (  "System.Windows.Controls.DatePicker  51   
   -   5        $��	StartDate��52      $��1��51      $��3��6%   $��30��62   $	��200��6>   $��20(�6J   $
��Left=�52   &   6C   �� 53   
   $��1��6   $��4��6%   $ 
Horizontal=�62   .+�54      �� -   5        $��TBStart��54      $��30��6%   $	��200��61   $��20(�6=   6�   �� 55      $$��Время окончания:��6   $��15(�60   $��30��6>   $��20q�6J   6X   �� 56      -   5        $��TBEnd��56      $��30��6#   $	��200��6/   $��20(�6;   6K   57      �� 58   
   -   5        $��
SaveButton��58      $��Сохранить��6#   $��5��67   $��0��59      $��2��6!   6P   5;      5<      