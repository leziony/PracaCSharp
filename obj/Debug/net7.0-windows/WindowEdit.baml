   M S B A M L   `   `   `  ����D  @ToDoList3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ToDoList3	ToDoList3  5   	       ToDoList3.WindowEdit   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:ToDoList3     5   	     � Title$  Edytuj Zadanie��5   	   $	��280��6    $	��400��6-   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��51* �6   �� 5      $
��149* �6    � RowDefinitions 5   
   �� 5      $	��19* �6   �� 5      $��3* �6   .+�5   
   �� -   5         ��Name$ name_input2��5      $
��Left=�6'   $��
10,110,0,0q�6B    �� TextWrapping$
 Wrap=�6V   $�� ��6j   $	��Top=�6r   $	��378��6�   $��32��6�   $��2��6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ 
date_input��5      $
��Left=�6)   $	��Top=�6D   $��
26,173,0,0q�6\   $��1��6p   $��24��6�   $	��104��6�   �� 5   
   -   5        $��Edytuj��5      $
��Left=�6"   $��46,0,0,0q�6=   $��Center=�6O    J� RenderTransformOrigin$ 0.505,0.697&�6   $��1��6�   $��1��6�   $��56��6�   $��20��6�   �� 5   
   -   5        $ ID_input��5      $
��Left=�6$   $��	10,40,0,0q�6?   $
 Wrap=�6R   $	��Top=�6�   $	��120��6�   $��1��6�   $��18��6�   �� 5   
   $!��Podaj ID Zadania do zamiany��6   $
��Left=�66   $��	82,14,0,0q�6Q   $	��Top=�6d   $��2��6|   $��26��6�   $	��169��6�   �� 5   
   $I��CPodaj nową nazwę zadanie (pozostaw puste by zostawić poprzednie)��6   $
��Left=�6[   $��9,84,0,0q�6v   $	��Top=�6�   $��2��6�   $��26��6�   $	��373��6�   �� 5   
   $K��EPodaj nową datę wykonania (pozostaw puste by zostawić poprzednią)��6   $
��Left=�6\   $��	9,142,0,0q�6w   $	��Top=�6�   $��2��6�   $��26��6�   $	��379��6�   5      5      