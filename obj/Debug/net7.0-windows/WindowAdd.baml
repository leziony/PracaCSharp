   M S B A M L   `   `   `  ����D  @ToDoList3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ToDoList3	ToDoList3  5   	       ToDoList3.WindowAdd   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:ToDoList3     5   	     � Title$  Dodaj Zadanie��5   	   $	��200��6   $	��250��6,   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��157* �6   �� 5      $	��27* �6   .+�5   
   �� -   5         ��Name$ 
name_input��5      $
��Left=�6&   $��
22,45,0,65q�6A    �� TextWrapping$
 Wrap=�6U   $�� ��6i   $	��201��6q   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ 
date_input��5      $
��Left=�6)   $	��Top=�6D   $��
65,107,0,0q�6\   $��24��6p   $	��104��6|   �� 5   
   -   5        $��Dodaj��5      $
��Left=�6!   $��97,0,0,0q�6<   $��1��6N   $��Center=�6[   $��20��6�   $��40��6�   �� 5   
   $,��&Podaj nazwę i datę wykonania zadania��6   $
��Left=�6?   $��	11,10,0,0q�6Z   $	��Top=�6m   5      5      