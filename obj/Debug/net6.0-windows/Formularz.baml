   M S B A M L   `   `   `  ����E  AColorModes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:ColorModes
ColorModes  5   	   ;"clr-namespace:ColorModes.ViewModelColorModes.ViewModel  60   ;"clr-namespace:ColorModes.ViewModelColorModes.ViewModel  5   	   3clr-namespace:ColorModes.ModelColorModes.Model  5	   	       ColorModes.Formularz   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:ColorModes     5   	   8	viewmodel"clr-namespace:ColorModes.ViewModel     60   5local1"clr-namespace:ColorModes.ViewModel     5   	   1modelsclr-namespace:ColorModes.Model     5	   	     � Title$  	Formularz��5
   	   $	��550��6   $	��400��6(      WindowStyle#��[  5   	    � 	Resources 5      -   'ColorModes.ViewModel.PracownikViewModel  data  validationTemplate �� ElementName �� Path ��Name  textBoxInError �� 
TargetType �� Triggers P� Property P� Value	 �� Property
 �� Value �� Self �� RelativeSource��%F  &	       &	      &	 7      5   
   6$   �� 5   
   .R�5      �� .+�5      � .+�5      �� 
�������
���   �$��1��6<   �� 5      
���  ��$��12(�62   ��6@   �� $ placeholder��$8 2AdornedElement.(Validation.Errors)[0].ErrorContent�5      �� 5      $ placeholder��6,   5      5      �� 5   
   " ��6'    5      P� 5       �@=�HasError$
 true��69   . �5      �� 	 �@�ToolTip
 5      �� # Z $) #(Validation.Errors)[0].ErrorContent��� 5      	 � ��$
 0q�5       5!      5#      5&       � DataContext 5'        5(   
   .��5*      �  � RowDefinitions 5+   
   �� 5,      $	��100 �6   6+   �� 5-      6   �� 5.      6   �� 5/      6   �� 50      6   �� 51      6   �� 52      6   �� 53      6   �� 54      6   �� 55      6   �� 56      6    � ColumnDefinitions 5:   
   �� 5;      $	��100 �6   6-   �� 5<      6!   �� 5=      6!   .+�5A   
   �� -   5         ��Name$ Tytul��5A      $��Przykładowy tutuł��6#   $��30(�6<   $��Center=�6J   $��Center=�6e   $��0��6�   $��0��6�   $��3��6�   6�   �� 5B   
   $��1��6   $��0��6   $��Imie:��6-   6?   �� 5C   
   $��2��6   $��0��6   $��	Nazwisko:��6-   6C   �� 5D   
   $��3��6   $��0��6   $��Plec:��6-   6?   �� 5E   
   $��4��6   $��0��6   $��Miasto:��6-   6A   �� 5F   
   $��5��6   $��0��6   $��Ulica:��6-   6@   �� 5G   
   $��6��6   $��0��6   $��Numer telefonu��6-   6H   �� 5H   
   $��7��6   $��0��6   $��Email:��6-   6@   �� 5I   
   $��8��6   $��0��6   $��Pesel:��6-   6@   �� 5J   
   $��1��6   $��1��6   $��3��6/   $��5q�6C    =� ErrorTemplate# [ 5K      .��6P   ��5L      �� 5M      $ PracownikImie�6    �� UpdateSourceTrigger$ PropertyChanged=�6/    �� ValidationRules 5N      5  /System.Windows.Controls.DataErrorValidationRule  5P      5R      .��5S      5T      �� 5U   
   $��2��6   $��1��6   $��3��6/   $��5q�6C   # [ 6N   .��6�   ��5V      �� 5W      $ PracownikNazwisko�6   $ PropertyChanged=�63    5X        5Y      5[      .��5\      5]      	� 5_   
    	� 	GroupName$ GenderGroup��6   $��3��6W   $��1��6d   $��5q�6t   $��Mężczyzna��6   $��Center=�6�   $��Center=�6�    d� 	IsChecked 6.   �� $ PracownikPlec� � LayoutTransform 5a      �� 5b       �� ScaleX$	 1.6Q�6!    �� ScaleY$	 1.6Q�6.   5d      5f      	� 5g   
   $ GenderGroup��6   $��3��6W   $��2��6d   $��5q�6t   $��Kobieta��6   $��Center=�6�   $��Center=�6�    6.   �� $ PracownikPlec� 5i      �� 5j      $	 1.6Q�6!   $	 1.6Q�6.   5l      5n      �� 5o   
   $��4��6   $��1��6   $��3��6/   $��5q�6C   # [ 6N   .��6�   ��5p      �� 5q      $ PracownikAdresMiasto�6   $ PropertyChanged=�66    5r        5s      5u      .��5v      5w      �� 5x   
   $��5��6   $��1��6   $��3��6/   $��5q�6C   # [ 6N   .��6�   ��5y      �� 5z      $ PracownikAdresUlica�6   $ PropertyChanged=�65    5{        5|      5~      .��5      5�      �� 5�   
   $��6��6   $��1��6   $��3��6/   $��5q�6C   # [ 6N   .��6�   ��5�      �� 5�      $ PracownikNumerTelefonu�6   $ PropertyChanged=�68    5�        5�      5�      .��5�      5�      �� 5�   
   $��7��6   $��1��6   $��3��6/   $��5q�6C   # [ 6N   .��6�   ��5�      �� 5�      $ PracownikEmail�6   $ PropertyChanged=�60    5�        5�      5�      .��5�      5�      �� 5�   
   $��8��6   $��1��6   $��3��6/   $��5q�6C   # [ 6N   .��6�   ��5�      �� 5�      $ PracownikPesel�6   $ PropertyChanged=�60    5�        5�      5�      .��5�      5�      �� 5�   
   $��10��6   $��0��6   $��Wróć��6/   6@   �� 5�   
   -   5         ��Name$ cmdAddPracownik��5�   |   $��10��6   $��1��6    $��2��60   $��
Zatwierdź��6D   ��6X   �� *cmdAddPracownik+6�   5�      5�      