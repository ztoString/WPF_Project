   M S B A M L   `   `   `  ����B  >Library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:LibraryLibrary  5   	       Library.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   &Viewclr-namespace:Library     5   	     � Title$  
MainWindow��5   	   $	��500��6   $	��850��6)   .��5      �� -   5         ��Name$ bdMain��5      
��� ���$��2q�5      ._�5
   
   � -   5         �Name$ gridMain��5
       � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $��* �6    .+�5      � -   5        $ gridContent��5      $��1��5       � ColumnDefinitions 5      �� 5      $
��5.5* �6'   �� 5      $
��Auto �6'   �� 5      $��3* �6'   .+�5         Library.BookListView   � DataContext 6$   �� *BookListViewModel+�� 5      $��2��6   $��1��5      
��� ���$��Stretch=�5      $��Center=�5         Library.BookView  5      $��2��6     60   �� * BookListViewModel.SelectedBook+5      5      5       5!      