   M S B A M L   `   `   `  ����  Library    Library.BookListView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	     � 	Resources  5	       �� 
TargetType �� Property �� Value��%�   '��       �� 5
   
   " ��6   .�5      ��  � ��$ Center=�62   �� 5       � ��
 ��  �6,   �� 5       � ��$ 1q�60   5      5      .��5      � -   5         �Name$ grdBookList��5       � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   `� -   5         `�Name$ toolbarBookList��5      .�5      c� .@�5      �� 
����  � �� CornerRadius$ 3��5      $��1q�5      $��2q�5      ._�5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      �� -   5        	 ��Name$	 cmbSearchType��5   #   $��80��5   @   
 �� SelectedIndex
 6   �� *
SearchType+.@�5      �� $��书名��6+    �� 
IsSelected . 68   �� 5       $��作者��6+   �� 5!      $��出版机构��6+   5"      �� 5#      -   5         ��Name$ 	txtSearch��5#   "   $	��150��5$      $��Center=�5%      ��5&      �� *
SearchText+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5'      5)      5*      �� 5+      �� 5,      -   5         ��Name$ 	btnAddNew��5,      $��添加��6,   ��69   �� *
AddCommand+�� 5-      -   5        $ 	btnRemove��5-      $��删除��6,   ��69   �� *DeleteCommand+�� 5.      -   5        $ btnSave��5.      $��保存��6*   ��67   �� *SaveCommand+5/      50      &   System.Windows.Controls.DataGrid  51   
   -   5          Name$ 
dgBookList��51      $��1��52         AutoGenerateColumns .     CanUserAddRows .  ��55      �� *
BookList+ �� SelectedItem 56      �� *SelectedBook+   Columns 58      0  *System.Windows.Controls.DataGridTextColumn  59      ,  &System.Windows.Controls.DataGridColumn   Header$ 书名��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 5* 5<   %   1  +System.Windows.Controls.DataGridBoundColumn   Binding 59   1   �� *Title+ �� ValidatesOnDataErrors .  �� NotifyOnValidationError . 5<   %     5=      $ 作者��6%   $ 3* 6L    61   �� *Author+6L     5>      $ 出版机构��6%   $ 90 6Q    63   �� *	Publisher+6Q     5?      $ 出版时间��6%   $ 3* 6S    63   �� *PublishDate+6S     5@      $ 语言��6%   $ 3* 6N    61   �� *
Language+6N     5A      $ 页数��6%   $ 3* 6K    61   �� *Pages+6K   5C      5D      5E      