   M S B A M L   `   `   `  ����B  >JBankCS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:JBankCSJBankCS  5   	   &     JBankCS.TransactionHistoryWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:JBankCS     5   	     � Title$  TransactionHistoryWindow��5   	   $	��450��6*   $	��800��67   .��5	      � .+�5
   
   �� -   5         ��Name$ appTitle��5
      $��C# Bank App��6"   $
��Left=�68   $��
500,30,0,0q�6S   $	��Top=�6g   $��34(�6   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ transactionsDataGrid��5         AutoGenerateColumns$
 True��61   
�������   SelectionMode$ Single=�6_      GridLinesVisibility$
 None=�6v      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6�      
IsReadOnly$
 True��6�      CanUserResizeRows$ False��6�   	   RowDetailsVisibilityMode$	 Visible=�6�   $
��Left=�6�   $	��247��6  $��38,0,0,0q�6  $��Center=�6*  $	��550��6E  (  "System.Windows.Controls.DatePicker  5   
   -   5        
  Name$

 From��5      $
��Left=�6#   $��30��6>   $��621,172,0,0q�6J   $	��Top=�6_   $	��155��6w      FirstDayOfWeek$ Monday=�6�   6�     5   
   -   5        $
 To��5      $
��Left=�6!   $��30��6<   $��621,240,0,0q�6H   $	��Top=�6]   $	��155��6u   $ Monday=�6�   6�   �� 5   
   $��From:��6   $
��Left=�6    $��25��6;   $��621,142,0,0q�6G   $	��Top=�6\   $	��155��6t   �� 5   
   $	��To:��6   $
��Left=�6   $��28��69   $��621,207,0,0q�6E   $	��Top=�6Z   $	��155��6r   �� 5   
   $��History range:��6   $
��Left=�6)   $��644,106,0,0q�6D   $	��Top=�6Y   $	��132��6q   $��16(�6}   �� 5   
   $��Total money:��6   $
��Left=�6'   $��
60,346,0,0q�6B   $	��Top=�6V   $��94��6n   �� 5   
   $!��Total number of operations:��6   $
��Left=�66   $��177,346,0,0q�6Q   $	��Top=�6f   $	��172��6~   �� 5   
   -   5        $��Back to the main page��5      $
��Left=�61   $��23��6L   $��621,385,0,0q�6X   $	��Top=�6m   $	��145��6�   6�   �� 5   
   -   5        $ 
totalMoney��5      $
��Left=�6$   $��
60,367,0,0q�6?   $	��Top=�6S   $��75��6k   �� 5   
   -   5        $ numOfOperations��5      $
��Left=�6)   $��177,367,0,0q�6D   $	��Top=�6Y   $��75��6q   5      5      