   M S B A M L   `   `   `  ����D  @ToDoList3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ToDoList3	ToDoList3  5   	       ToDoList3.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:ToDoList3     5   	   -   5          � Title$  Lista Zadan��5   	   $	��500��6   $	��600��6*   .��5	      �  � ColumnDefinitions 5
   
   �� 5      .+�5   
   �� $��Center=�6   $��0��64   $��	0,113,0,0q�6?   $	��Top=�6R   $	��600��6j    J� RenderTransformOrigin$ 0.5,0.5&�6v   z�5      V� 5      .~�5      ��  �� ScaleY$ -1Q�6%   �� 5      �� 5      T� 5      5      5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ Results��5      $��0,103,10,10q�6%      
IsReadOnly$
 True��6:      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *ID+  5      $ Nazwa��6%    64   �� *name+  5      $ Termin��6%    65   �� *
Deadline+	 �� StringFormat$	 d��5      �� 5   
   -   5        
 ��Name$

 btn1��5      $��Dodaj Zadanie��6   $
��Left=�67   $��	54,24,0,0q�6R   $	��Top=�6e   $��22��6�   $��90��6�   �� 5   
   -   5        $

 btn2��5      $��Edytuj Zadanie��6   $��Center=�68   $��0,24,0,0q�6U   $	��Top=�6g   $��22��6�   $	��102��6�   (  "System.Windows.Controls.DatePicker  5    
   -   5          Name$ date_select��5       $
��Left=�6*   $��
108,79,0,0q�6E   $	��Top=�6Y      FirstDayOfWeek$ Monday=�6q   6�   �� 5!   
   -   5        $

 btn3��5!      $��Usuń Zadanie��6   $
��Left=�66   $��
480,24,0,0q�6Q   $	��Top=�6e   $��22��6�   $��83��6�   �� 5"   
   $��Zadania z dnia:��6   $
��Left=�6*   $��0,77,0,0q�6E   $	��Top=�6W   5$      5%      