   M S B A M L   `   `   `  ����F  BWPF_sandobx, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WPF_sandobxWPF_sandobx  5   	   !    WPF_sandobx.ConfColorWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:WPF_sandobx     5   	     � Title$  Settings��5   	   $	��600��6   $	��600��6'    � WindowStartupLocation$ CenterScreen=�63    � 
ResizeMode$ NoResize=�6X   .��5      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $��BackgroundColor��6   .��5      �  5      �� 5       $��* �6$   �� 5!      $
��0.2* �6$    5#      �� 5$      $
��0.4* �6'   �� 5%      $
��0.4* �6'   �� 5&      $
��0.4* �6'   �� 5'      $��* �6'   .+�5)      �� -   5        $��
Rectangle1��5)      ���#000000$��3��6=   $��2��6M   �� 5*      -   5        $��BackgroudRedSlider��5*       �� IsSnapToTickEnabled .  �� TickFrequency$ 1Q�6O    �� Orientation$ Vertical=�6�    � Minimum$ 0Q�6�   	 � Maximum$		 255Q�6�   $��Center=�6�   �� 5+      -   5        $��BackgroundGreenSlider��5+       . $ 1Q�6Q   $ Vertical=�6�   $ 0Q�6�   $		 255Q�6�   $��Center=�6�   $��1��6�   �� 5,      -   5        $��BackgroundBlueSlider��5,       . $ 1Q�6P   $ Vertical=�6�   $ 0Q�6�   $		 255Q�6�   $��Center=�6�   $��2��6�   �� 5-      -   5        $��textbox1��5-      $��1��6*   $��Center=�6r   $��Center=�6�   ��67   �� 
 �� ElementName$
 BackgroudRedSlider�� �� Path$ Value�6�   �� 5.      -   5        $��textbox2��5.      $��1��6*   $��1��67   $��Center=�6�   $��Center=�6�   ��6G   �� $
 BackgroundGreenSlider��$ Value�6�   �� 5/      -   5        $��textbox3��5/      $��1��6*   $��2��67   $��Center=�6�   $��Center=�6�   ��6G   �� $
 BackgroundBlueSlider��$ Value�6�   50      51      �� 53   
   $��1��6   $��FillingColor��6#   .��54      �  55      �� 56      $��* �6$   �� 57      $
��0.2* �6$    59      �� 5:      $
��0.4* �6'   �� 5;      $
��0.4* �6'   �� 5<      $
��0.4* �6'   �� 5=      $��* �6'   .+�5?      �� -   5        $��
Rectangle2��5?      ���#FFFFFF$��3��6=   $��2��6M   �� 5@      -	   5        $��ForegroudRedSlider��5@       . $ 1Q�6N    � Value$	 255Q�6`   $ Vertical=�6�   $ 0Q�6�   $		 255Q�6�   $��Center=�6�   �� 5A      -
   5        $��ForegroundGreenSlider��5A       . $ 1Q�6Q   $	 255Q�6c   $ Vertical=�6�   $ 0Q�6�   $		 255Q�6�   $��Center=�6�   $��1��6�   �� 5B      -   5        $��ForegroundBlueSlider��5B       . $ 1Q�6P   $	 255Q�6b   $ Vertical=�6�   $ 0Q�6�   $		 255Q�6�   $��Center=�6�   $��2��6�   �� 5C      -   5        $��textbox4��5C      $��1��6M   $��Center=�6�   $��Center=�6�   ��6Z   �� $
 ForegroudRedSlider��$ Value�6�   �� 5D      -   5        $��textbox5��5D      $��1��6N   $��1��6[   $��Center=�6�   $��Center=�6�   ��6k   �� $
 ForegroundGreenSlider��$ Value�6�   �� 5E      -   5        $��textbox6��5E      $��1��6M   $��2��6Z   $��Center=�6�   $��Center=�6�   ��6j   �� $
 ForegroundBlueSlider��$ Value�6�   5F      5G      �� 5I   
   $��0��6   $��1��6#   $��StrokeColor��60   .��5J      �  5K      �� 5L      $��* �6$   �� 5M      $
��0.2* �6$    5O      �� 5P      $
��0.4* �6'   �� 5Q      $
��0.4* �6'   �� 5R      $
��0.4* �6'   �� 5S      $��* �6'   .+�5U      �� -   5        $��
Rectangle3��5U      
���   �$��3��6;   $��2��6K   �� 5V      -   5        $��StrokeRedSlider��5V       . $ 1Q�6K   $ 0Q�6]   $ Vertical=�6�   $ 0Q�6�   $		 255Q�6�   $��Center=�6�   �� 5W      -   5        $��StrokeGreenSlider��5W       . $ 1Q�6M   $ 0Q�6_   $ Vertical=�6�   $ 0Q�6�   $		 255Q�6�   $��Center=�6�   $��1��6�   �� 5X      -   5        $��StrokeBlueSlider��5X       . $ 1Q�6L   $ 0Q�6^   $ Vertical=�6�   $ 0Q�6�   $		 255Q�6�   $��Center=�6�   $��2��6�   �� 5Y      -   5        $��textbox7��5Y      $��1��6M   $��Center=�6�   $��Center=�6�   ��6Z   �� $
 StrokeRedSlider��$ Value�6�   �� 5Z      -   5        $��textbox8��5Z      $��1��6M   $��1��6Z   $��Center=�6�   $��Center=�6�   ��6j   �� $
 StrokeGreenSlider��$ Value�6�   �� 5[      -   5        $��textbox9��5[      $��1��6M   $��2��6Z   $��Center=�6�   $��Center=�6�   ��6j   �� $
 StrokeBlueSlider��$ Value�6�   5\      5]      �� 5_   
   $��1��6   $��1��6#   $��SelectColor��60   .��5`      �  5a      �� 5b      $��* �6$   �� 5c      $
��0.2* �6$    5e      �� 5f      $
��0.4* �6'   �� 5g      $
��0.4* �6'   �� 5h      $
��0.4* �6'   �� 5i      $��* �6'   .+�5k      �� -   5        $��
Rectangle4��5k      
���  ��$��3��69   $��2��6I   �� 5l      -   5        $��SelectRedSlider��5l       . $ 1Q�6K   $	 255Q�6]   $ Vertical=�6�   $ 0Q�6�   $		 255Q�6�   $��Center=�6�   �� 5m      -   5        $��SelectGreenSlider��5m       . $ 1Q�6M   $ 0Q�6_   $ Vertical=�6�   $ 0Q�6�   $		 255Q�6�   $��Center=�6�   $��1��6�   �� 5n      -   5        $��SelectBlueSlider��5n       . $ 1Q�6L   $ 0Q�6^   $ Vertical=�6�   $ 0Q�6�   $		 255Q�6�   $��Center=�6�   $��2��6�   �� 5o      -   5        $��	textbox10��5o      $��1��6O   $��Center=�6�   $��Center=�6�   ��6\   �� $
 SelectRedSlider��$ Value�6�   �� 5p      -   5        $��	textbox11��5p      $��1��6O   $��1��6\   $��Center=�6�   $��Center=�6�   ��6l   �� $
 SelectGreenSlider��$ Value�6�   �� 5q      -   5        $��	textbox12��5q      $��1��6O   $��2��6\   $��Center=�6�   $��Center=�6�   ��6l   �� $
 SelectBlueSlider��$ Value�6�   5r      5s      �� 5x   
   -   5        $��OkButton��5x      $��3��6"    �� 	IsDefault . $��Ok��6@   $��35q�6d   �� 5y   
   -   5        $��CancelButton��5y   .   $��1��6   $��3��6!    �� IsCancel . $��Cancel��6R   $��35q�6c   6o   5{      5~      