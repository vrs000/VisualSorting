   M S B A M L   `   `   `  ����F  BWPF_sandobx, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WPF_sandobxWPF_sandobx  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089I2clr-namespace:System.Collections;assembly=mscorlibSystem.Collections 5   	   1&clr-namespace:System;assembly=mscorlibSystem 5   	       WPF_sandobx.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:WPF_sandobx     5   	   Bcol2clr-namespace:System.Collections;assembly=mscorlib     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	   -   5          � Title$  VisualSorting��5
   	   $	��400��6   $	��400��6,    � WindowStartupLocation$ CenterScreen=�6�    � Icon$ 
106740.ico��6�    � 	Resources 5         ButtonStyle �� 
TargetType �� Property �� Value  TextBoxStyle  n K� Variants  n2��%E  &	        &	 p     &	     &	     �� 5   
   " ��6$   .�5      ��  � ��$ 25(�6)   �� 5       � ��$ Medium"�6+   5      �� 5   
   " ��6   .�5      ��  � ��$
 auto��6'   �� 5       � ��$ 50��6&   �� 5       � ��$ Center=�6;   5      �� 5   
   " ��6   .�5      ��  �@�ToolTip 5      �� 5      $��Palatino Linotype)�6    �� 5      .�6   O(N6#    �� 5      $ Superscript=�6   .�6@   26C    �� 5       .�6   )6!   5!      5#      5$      �� 5&   
   " ��6   .�5'      ��  �@�ToolTip 5(      �� 5)      $��Palatino Linotype)�6    �� 5*      .�6   O(N6#    �� 5+      $ Superscript=�6   .�6@   2.716F    �� 5,      .�6   )6!   5-      5/      50      52      .��54      � -   5        $��grid1��54       � RowDefinitions 55   
   �� 56      $��23 �6   �� 57      $��* �6   �� 58      $��0.25* �6   	 � ColumnDefinitions	 5:   
   �� 5;      $	��109 �6   �� 5<      �� 5=      �� 5>      .+�5B   
   �� $��1��6   $��1��6$   $
��Auto=�64   $��Disabled=�6Y   $��3��6�   .��5C      �� -   5        $��panel��5C   E   
���   �
 �� Orientation$
 
Horizontal=�6,   $	��260��6R   $	��Top=�6_   .+�5E      �� $��52��6   $��52��6'   
���   �
���  ��$��3��6M   $��Bottom=�6a   �� 5F      $��52��6   $��7��6'   
���   �
���  ��$��3��6L   $��Bottom=�6`   �� 5G      $��52��6   $��25��6'   
���   �
���  ��$��3��6M   $��Bottom=�6a   �� 5H      $��52��6   $��78��6'   
���   �
���  ��$��3��6M   $��Bottom=�6a   �� 5I      $��52��6   $��29��6'   
���   �
���  ��$��3��6M   $��Bottom=�6a   �� 5J      $��52��6   $	��150��6'   
���   �
���  ��$��3��6N   $��Bottom=�6b   5L      5M      o� 5O   
   $��4��6   .@�5P      m� $
��auto��6   $��Elements��6%   $��15(�67   .@�5Q      m� -   5        $��Options��5Q      6,   5R      m� 5T      $��Figure��6   $��15(�6'   .@�5U      	� -   5        $��TrRadioButton��5U      $��Triangle��63    	� 	GroupName$	 loc��6F    d� 	IsChecked$
 TrueY�6V   6g   	� 5V      -   5        $��RectRadioButton��5V      $��	Rectangle��65   $	 loc��6I   6Y   5Y      5[      �� 5]   
   
�������$��2��6'   $��1��68   .+�5^      �� $��Number of elements��6    �� TextAlignment$ Center=�62   �� 5_      -   5        $��NumberValue��5_      #��[ 6)   6O   �� 5`      $��Width of elements��6   $ Center=�61   �� 5a      -   5        $��
WidthValue��5a      #��[ 6(   6N   �� 5b      $��Width of stroke��6   $ Center=�6/   �� 5c      -	   5        $��WidthStrokeValue��5c      #��[ 6.   6T   �� 5d      -
   5        $��ListOfSorts��5d      $��1,0,-1,0q�6*   .@�5e      �� -   5        $��CombBoxBubbleSort��5e      $��
BubbleSort��68    �� 
IsSelected . #��[ 6_   �� 5f      -   5        $��CombBoxCocktailSort��5f      $��CocktailSort��6:   #��[ 6Q   �� 5g      -   5        $��CombBoxInsertionSort��5g      $��InsertionSort��6;   #��[ 6S   �� 5h      -   5        $��ComboBoxSelectionSort��5h      $��SelectionSort��6<   #��[ 6T   �� 5i      -   5        $��ComboBoxGnomeSort��5i      $��	GnomeSort��68   #��[ 6L   �� 5j      -   5        $��ComboBoxShellSort��5j      $��	ShellSort��68   #��[ 6L   �� 5k      -   5        $��CombBoxQuickSort��5k      $��	QuickSort��67    � ToolTip$ O(N*log(N))��6K   �� 5l      -   5        $��ComboBoxMergeSort��5l      $��	MergeSort��68   $ O(N*log(N))��6L   �� 5m      -   5        $��ComboBoxCombSort��5m      $��CombSort��67   #��[ 6J   �� 5n      -   5        $��ComboBoxPyramidSort��5n      $��PyramidSort��6:   $ O(N*log(N))��6P   �� 5o      -   5        $��ComboBoxStoogeSort��5o      $��
StoogeSort��69   #��[ 6N   �� 5p      -   5        $��ComboBoxBogoSort��5p      $��BogoSort��67   $ O(N*N!)��6J   �� 5q      -   5        $��ComboBoxIntroSort��5q      $��	IntroSort��68   $ O(N*log(N))��6L   �� 5r      -   5        $��ComboBoxPuncakeSort��5r      $��PuncakeSort��6:   $
 O(N)��6P   5s      �� 5t      -   5         ��Name$ swaps��5t      $
��auto��6#   $��Swaps: 0��61   6D   �� 5v      -   5        $��
StopButton��5v      $��Restart��6'   69   �� 5w      $��Delay��6   �� 5x      -   5        $��SpeedSlider��5x       � Minimum$ 0Q�6(    � Maximum$	 100Q�64    � Value$ 0Q�6B   6L   �� 5y      -   5        $
��Skip��5y      $
��Skip��6#   6I   5z      �� 5|   
   -   5        $��SortAscButton��5|      $��2��6,   $��1��69   $��Sort+��6I   #��[  6Y   6~   �� 5}   
   -   5        $��
RandButton��5}      $��2��6*   $��2��67   $��Random��6G   #��[  6X   6}   �� 5~   
   -   5        $��SortDescButton��5~      $��2��6-   $��3��6:   $��Sort-��6J   #��[  6Z   6   5      5�      