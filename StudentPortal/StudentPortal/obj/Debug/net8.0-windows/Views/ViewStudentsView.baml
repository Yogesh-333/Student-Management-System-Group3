   M S B A M L   `   `   `  ����  StudentPortal*    $StudentPortal.Views.ViewStudentsView   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  View Students��5   	   $	��450��6   $	��800��6,    � WindowState$ 	Maximized=�5   	    � 	Resources 5       �� 
TargetType �� Property �� Value �� 
TargetType �� RadiusX �� RadiusY	 �� Triggers
 P� Property P� Value&   System.Windows.Controls.DataGrid��%�  '��       '�� �    '��     '�� �    '  =    �� 5   
   " ��6   .�5	      ��  � ��$ 40��6'   �� 5
       � ��$	 100��6&   �� 5       � ��$ 5q�6'   �� 5       � ��$ 14(�6)   �� 5       � �� �	#FF007ACC6+   �� 5       � ��
 �����6+   �� 5       � ��
 ���� 6,   �� 5       �@�Cursor$
 Hand��6'   �� 5       � �� 5      �� 5      " ��6&   .R�5      � .+�5      �� #��z��6(   $ 10��6L   $ 10��6Y   �� 5      $��Center=�6/   $��Center=�6L   5      	 5      P� 5      
 �@J�IsMouseOver$
 True��6=   . �5   "   ��  � �� �	#FF005A9E6?   5      5      5      5       �� 5"   
   " ��6   .�5#      ��  � ��$ Center=�64   �� 5$       � ��$ Center=�62   5%      �� 5'   
   " ��6   .�5(      ��  � ��$ 16(�6)   �� 5)       � ��$ 5q�6'   �� 5*       � �� �	#FF007ACC6+   5+      �� 5-   
   " ��6   .�5.      ��  � ��$ 14(�6)   �� 5/       � ��$ 5q�6'   �� 50       � ��$	 200��6&   51      �� 53   
   "  6   .�54      ��  � ��$ 14(�6)   �� 55       � ��$ 10q�6'   56      57      .��5:      � ���	#FFE5E5E5.+�5;   
   �� $��20q�6   $��Center=�6!   .+�5<           AutoGenerateColumns$ False��68   $��10q�6T   $	��650��6`   $	��300��6l      CanUserAddRows$ False��6y   ��6   �� *
Students+   Columns 5=      0  *System.Windows.Controls.DataGridTextColumn  5>      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6L   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *Id+6L     5?      $
 Name��6)   $	 150 6P    67   �� *Name+6P     5@      $	 Age��6)   $	 100 6N    66   �� *Age+6N     5A      $ Course Name��6)   $	 150 6]    6>   �� *
CourseName+6]     5B      $ Contact Number��6)   $	 150 6c    6A   �� *ContactNumber+6c   4  .System.Windows.Controls.DataGridTemplateColumn  5C      $ Actions��6-   $	 250 6>      CellTemplate 5D      �� 5E      .R�5F   "   ��  �� Orientation$ 
Horizontal=�6-   .+�5G   &   �� $
��Edit��6-   $��5q�6�   ��6<   �� * DataContext.EditStudentCommand+ �� RelativeSource ��  �� AncestorType
 Window��6�   �� 6�   �� 5H   &   $��Delete��6-   $��5q�6�   ��6>   �� *" DataContext.DeleteStudentCommand+ �� 
 Window��6�   �� 6�   5I   #   5J      5L      5N      �� 5O      $��Export to CSV��6   $��10q�6T   $��Center=�6`   ��6-   �� *ExportToCsvCommand+6`   5P      5Q      5R      