   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5   	    Library   Library.BookView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	     � 	Resources  5
       �� 
TargetType �� Property �� Value��%<  '��       '�� �     �� 5   
   " ��6   .�5      ��  � ��$ Right=�64   �� 5       � ��$ Center=�62   �� 5       � ��$ 3q�6'   5      �� 5   
   " ��6   .�5      ��  � ��$ Center=�62   �� 5       � ��$ 3q�6'   �� 5       � ��$ 1��6,   5      5      .��5      � -   5         �Name$ gridBook��5       � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5       $
��Auto �6   �� 5!      $��* �6    � ColumnDefinitions 5#   
   �� 5$      $
��Auto �6   �� 5%      $��* �6   .+�5'   
   �� $��书名:��6   $��0��6   �� 5(   
   $��0��5*      ��5(      �� *Title+ �� UpdateSourceTrigger$ PropertyChanged=� �� ValidatesOnDataErrors . 	 �� ValidatesOnExceptions	 . 
 �� NotifyOnValidationError
 . 5*      �� 5+   
   $��作者:��6   $��1��6   �� 5,   
   $��1��5-   G   ��5,      �� *Author+$ PropertyChanged=� . 	 . 
 . 5-   G   �� 5.   
   $��出版机构:��6   $��2��6!   �� 5/   
   $��2��50   G   ��5/      �� *	Publisher+$ PropertyChanged=� . 	 . 
 . 50   G   �� 51   
   $��出版时间:��6   $��3��6!   (  "System.Windows.Controls.DatePicker  52   
   $��3��54      $��1��6"   $��3q�62      Text 52      �� *PublishDate+$ PropertyChanged=� . 	 . 
 .  �� Mode$ TwoWay=�54   2   �� 55   
   $��语言:��6   $��5��6   �� 56   
   $��5��6,   ��6   �� *
Language+6,   �� 57   
   $��页数:��6   $��6��6   �� 58   
   $��6��6M   ��6   �� *Pages+$ PropertyChanged=�6M   59      5:      