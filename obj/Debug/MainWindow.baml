   M S B A M L   `   `   `  ����G  CFinalProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:FinalProjectFinalProject  5   	       FinalProject.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:FinalProject     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   
�������.��5
      �  � RowDefinitions 5      �� 5      $��* �6    �� 5      $��* �6    �� 5      $��* �6    �� 5      $��* �6    �� 5      $��* �6    �� 5      $��* �6    �� 5      $��* �6    �� 5      $��* �6    �� 5      $��* �6     � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��* �6#   �� 5      $��* �6#   �� 5       $��* �6   .+�5$      �� -   5        $��BtnLendMedia��5-      $��0��5%      $��0��5&      $��2��5'      $��18(�5(      
�������$��Comic Sans MS)�5*      $
��Bold"�5+      $��
Lend Media��5,      5.   
   �� 50   
   -   5        $��BtnReturnMedia��59      $��1��51      $��0��52      $��2��53      $��18(�54      $��Return Media��55      
�������$��Comic Sans MS)�57      $
��Bold"�58      5:   
   �� 5<      -   5        $��BtnMediaInfo��5E      $��2��5=      $��0��5>      $��2��5?      $��
Media Info��5@      $��18(�5A      
�������$��Comic Sans MS)�5C      $
��Bold"�5D      5F      �� 5H      -   5        $��BtnMemberInfo��5Q      $��3��5I      $��2��5J      $��0��5K      $��Member Info��5L      $��18(�5M      
�������$��Comic Sans MS)�5O      $
��Bold"�5P      5R      �� 5T      -   5        $��BtnModifyMember��5]      $��7��5U      $��0��5V      $��2��5W      $��Modify Member��5X      $��18(�5Y      
�������$��Comic Sans MS)�5[      $
��Bold"�5\      5^      �� 5_      -   5        $��BtnModifyMedia��5h      $��8��5`      $��0��5a      $��2��5b      $��Modify Media��5c      $��18(�5d      
�������$
��Bold"�5f      $��Comic Sans MS)�5g      5i   
   &   System.Windows.Controls.DataGrid  5k   
   -   5        $��
MemberName��5k      $��4��5l      $��0��5m      $��2��5n      $��3��5o      $��15(�5p      
�������$��Comic Sans MS)�5r         AutoGenerateColumns .     Columns 5v      0  *System.Windows.Controls.DataGridTextColumn  5w      ,  &System.Windows.Controls.DataGridColumn   Header$ Name:��6"      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 5y         FontSize$ 18Q�5z         
FontFamily$ Comic Sans MS)�5{      1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 5x      �� *Name+
 �� Mode$
 OneWay=�5{      5}        5~   
   -   5        $��
BookRecord��5~      $��0��5      $��2��5�      $��6��5�      $��7��5�      
�������$��15(�5�      $��Comic Sans MS)�5�       .   5�   
     5�      $ Title��6#   $ * 5�      $ 15Q�5�      $ Comic Sans MS)�5�      	 5�      �� *Title+$
 OneWay=�5�        5�      $
 Type��6#   $ * 5�      $ 15Q�5�      $ Comic Sans MS)�5�      	 5�      �� *Type+$
 OneWay=�5�      4  .System.Windows.Controls.DataGridCheckBoxColumn  5�      $ Availablity��6#   $ * 5�      	 5�      �� *Availability+$
 OneWay=�5�        5�      $ Borrower��6   $ * 5�      $ 15Q�5�      $ Comic Sans MS)�5�      	 5�      �� *
Borrower+$
 OneWay=�5�      5�      5�      5�      