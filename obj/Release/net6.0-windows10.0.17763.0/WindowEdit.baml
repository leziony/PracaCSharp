   M S B A M L   `   `   `  ���� D  @ToDoList3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ToDoList3	ToDoList3      ToDoList3.WindowEdit   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     )localclr-namespace:ToDoList3       � Title$  Edytuj Zadanie��$	��280��$	��400��.���  � ColumnDefinitions �� $	��51* ��� $
��149* � � RowDefinitions �� $	��19* ��� $��3* �.+��� -    ��Name$ name_input2��$
��Left=�$��
10,110,0,0q� �� TextWrapping$
 Wrap=�$�� ��$	��Top=�$	��378��$��32��$��2��(  "System.Windows.Controls.DatePicker  -     Name$ 
date_input��$
��Left=�$	��Top=�$��
26,173,0,0q�$��1��$��24��$	��104���� -   $��Edytuj��$
��Left=�$��46,0,0,0q�$��Center=� J� RenderTransformOrigin$ 0.505,0.697&�$��1��$��1��$��56��$��20���� -   $ ID_input��$
��Left=�$��	10,40,0,0q�$
 Wrap=�$	��Top=�$	��120��$��1��$��18���� $!��Podaj ID Zadania do zamiany��$
��Left=�$��	82,14,0,0q�$	��Top=�$��2��$��26��$	��169���� $I��CPodaj nową nazwę zadanie (pozostaw puste by zostawić poprzednie)��$
��Left=�$��9,84,0,0q�$	��Top=�$��2��$��26��$	��373���� $K��EPodaj nową datę wykonania (pozostaw puste by zostawić poprzednią)��$
��Left=�$��	9,142,0,0q�$	��Top=�$��2��$��26��$	��379��