   M S B A M L   `   `   `  ���� D  @ToDoList3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ToDoList3	ToDoList3      ToDoList3.MainWindow   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     )localclr-namespace:ToDoList3     -     � Title$  Lista Zadan��$	��500��$	��600��.���  � ColumnDefinitions �� .+��� $��Center=�$��0��$��	0,113,0,0q�$	��Top=�$	��600�� J� RenderTransformOrigin$ 0.5,0.5&�z�V� .~���  �� ScaleY$ -1Q��� �� T� &   System.Windows.Controls.DataGrid  -     Name$ Results��$��0,103,10,10q�   
IsReadOnly$
 True��   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ ID��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *ID+  $ Nazwa�� �� *Name+  $ Termin�� �� *
Deadline+	 �� StringFormat$	 d���� -   
 ��Name$

 btn1��$��Dodaj Zadanie��$
��Left=�$��	54,24,0,0q�$	��Top=�$��22��$��90���� -   $

 btn2��$��Edytuj Zadanie��$��Center=�$��0,24,0,0q�$	��Top=�$��22��$	��102��(  "System.Windows.Controls.DatePicker  -     Name$ date_select��$
��Left=�$��
108,79,0,0q�$	��Top=�   FirstDayOfWeek$ Monday=��� -   $

 btn3��$��Usuń Zadanie��$
��Left=�$��
480,24,0,0q�$	��Top=�$��22��$��83���� $��Zadania z dnia:��$
��Left=�$��0,77,0,0q�$	��Top=��� -   $

 btn4��$��Pokaż wszystkie zadania��$
��Left=�$��
249,77,0,0q�$	��Top=�$��22��$	��134���� -   $

 btn5��$��Sprawdzenie zadań��$
��Left=�$��
401,77,0,0q�$	��Top=�$��22��$	��170��