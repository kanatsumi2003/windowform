   M S B A M L   `   `   `  ����K  GTresuareOceanWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:TresuareOceanWPFTresuareOceanWPF  5   	   !    TresuareOceanWPF.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:TresuareOceanWPF     5   	   -   5          � Title$  LoginWindow��5   	   $	��450��6   $	��800��6*    � WindowStartupLocation$ CenterScreen=�5	   	    � WindowStyle$
 None=�5
   	   
������  � AllowsTransparency$
 True��5   	   .��5      � .+�5   
   ��  �� CornerRadius$ 10��6   $��2q�5   	    J� Opacity$
 0.95Q�5   	   $	��450��6   $	��Top=�6%    J� RenderTransformOrigin$ 0.5,0.5&�6=   z�5      V� 5      .~�5      �� �� 5       �� AngleX$ -0.361Q�6$   �� 5      T� 5       T� X$ -1.418Q�6)   5      ��5      �� 5      	 �� 
StartPoint$		 0,0&�6&   
 �� EndPoint$	
 1,1&�67   .��5      �  � Color$ #0099FF��6#    � Offset$ 0Q�63   � 5      $ #DA34AE��6#   $
 0.75Q�63   � 5      $ 	#FF60B1E7��6#   $ 1Q�65   � 5      $ 	#FF596FDD��6#   $ 0.309Q�65   � 5      $ 	#FF8C57CA��6#   $ 0.484Q�65   5       ��5"      �� 5#      $		 0,1&�6&   $	
 1,0&�67   .��5$      � $ #060531��6#   $ 1Q�63   � 5%      $ 	#FF472FDE��6#   $ 0.343Q�65   5&      ._�5)      �� -   5         ��Name$ txtSeaID��5)       �� TextWrapping$
 Wrap=�6(   $��126,48,100,370q�6<   5+      �� 5,   
   $��Sea ID��6   $��23,49,702,366q�6!   �� 5-   
   $��Sea Name��6   $��23,89,687,326q�6#   �� 5.   
   $��Treasure��6   $��23,132,702,283q�6#   �� 5/   
   $	��Fee��6   $��23,167,687,248q�6   �� 50   
   $��Country ��6   $��23,207,702,208q�6#   �� 51   
   -   5        $ txtTreasure��51      $
 Wrap=�6'   $��128,130,103,291q�6;   �� 52   
   -   5        $ txtFee��52      $
 Wrap=�6"   $��128,172,103,248q�66   �� 53   
   $��Treasure Management��6   $��30(�6.   $��236,0,211,368q�6<   
�������$
��Bold"�6f   �� 54   
   -   5        $��Create��54      $��152,393,541,5q�6"   ���	#FF00B3FF6P   �� 55   
   -   5         ��Name$ 	btnUpdate��55      $��Update��6$   $��278,393,415,5q�65   ���	#FF5AFF006c   �� 56   
   -   5        $ 	btnDelete��56      $��Delete��6$   $��400,393,293,5q�65   ���	#FFDCFD1B6c   �� 57   
   -   5        $ btnClear��57      $��Clear��6#   $��526,393,167,5q�63   ���	#FFFF69006J   �� 58   
   -	   5        $ 
txtSeaName��58      $
 Wrap=�6&   $��128,89,103,332q�6:   �� 59   
   -
   5         ��Name$ 
txtCountry��59      $��128,218,103,200q�6'   &   System.Windows.Controls.DataGrid  5:   
   -   5          Name$ dgv_seaAreas��5:      $��128,264,103,62q�6*   6B   �� 5;   
   -   5        $ 	btn_close��5;      $��Close��6$   $��666,393,27,5q�64   ���	#FFFF69006a   5<      5>      