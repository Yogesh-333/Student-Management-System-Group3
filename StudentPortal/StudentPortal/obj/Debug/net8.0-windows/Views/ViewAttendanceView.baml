   M S B A M L   `   `   `  ����  StudentPortal,    &StudentPortal.Views.ViewAttendanceView   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  View Attendance��5   	   $	��450��6!   $	��800��6.    � WindowState$ 	Maximized=�5   	    � 	Resources 5       �� 
TargetType �� Property �� Value �� 
TargetType �� RadiusX �� RadiusY	 �� Triggers
 P� Property P� Value&   System.Windows.Controls.Calendar&   System.Windows.Controls.DataGrid��%.  '��       '�� �    '��     '�� �    '  >    '  �    �� 5   
   " ��6   .�5	      ��  � ��$ 40��6'   �� 5
       � ��$	 150��6&   �� 5       � ��$ 10q�6'   �� 5       � ��$ 14(�6)   �� 5       � �� �	#FF007ACC6+   �� 5       � ��
 �����6+   �� 5       � ��
 ���� 6,   �� 5       �@�Cursor$
 Hand��6'   �� 5       � �� 5      �� 5      " ��6&   .R�5      � .+�5      �� #��z��6(   $ 10��6L   $ 10��6Y   �� 5      $��Center=�6/   $��Center=�6L   5      	 5      P� 5      
 �@J�IsMouseOver$
 True��6=   . �5   "   ��  � �� �	#FF005A9E6?   5      5      5      5       �� 5"   
   " ��6   .�5#      ��  � ��$ Center=�64   �� 5$       � ��$ Center=�62   5%      �� 5'   
   " ��6   .�5(      ��  � ��$ 16(�6)   �� 5)       � ��$ 5q�6'   �� 5*       � �� �	#FF007ACC6+   5+      �� 5-   
   " ��6   .�5.      ��  � ��$ 14(�6)   �� 5/       � ��$ 5q�6'   �� 50       � ��$	 200��6&   51      �� 53   
   "  6   .�54      ��  � ��$ 10q�6'   55      �� 57   
   "  6   .�58      ��  � ��$ 14(�6)   �� 59       � ��$ 10q�6'   5:      5;      .��5>      � ���	#FFE5E5E5.+�5?   
   �� $��20q�6   $��Center=�6!   .+�5@        -   5          Name$ attendanceCalendar��5@         SelectedDate 63   �� *SelectedDate+6Y     5A         AutoGenerateColumns$ False��6A   $��10q�6]   $	��550��6i   $	��200��6u      CanUserAddRows$ False��6�   ��6   �� *AttendanceRecords+   Columns 5B      0  *System.Windows.Controls.DataGridTextColumn  5C      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Student ID��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6[   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *	StudentId+6[     5D      $
 Name��6)   $ * 6P    67   �� *Name+6P   5F      5G      5H      5I      