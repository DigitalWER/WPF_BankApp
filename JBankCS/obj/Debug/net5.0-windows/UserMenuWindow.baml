   M S B A M L   `   `   `  ����B  >JBankCS, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:JBankCSJBankCS  5   	       JBankCS.UserMenuWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:JBankCS     5   	     � Title$  UserMenuWindow��5   	   $	��450��6    $	��800��6-   .��5	      � .+�5
   
   �� -   5         ��Name$ appTitle��5
      $��C# Bank App��6"   $
��Left=�68   $��
500,30,0,0q�6S   $	��Top=�6g   $��34(�6   �� 5   
   -   5        $ 	LabelName��5      $��Label��6#   $
��Left=�63   $��31��6N   $��	61,42,0,0q�6Z   $	��Top=�6m   $
��Auto��6�   �� 5   
   -   5        $ LastName��5      $��Label��6"   $
��Left=�62   $��31��6M   $��	61,73,0,0q�6Y   $	��Top=�6l   $
��Auto��6�   �� 5   
   -   5        $ Username��5      $��Label��6"   $
��Left=�62   $��31��6M   $��
61,135,0,0q�6Y   $	��Top=�6m   $
��Auto��6�   �� 5   
   -   5        $ Email��5      $��Label��6   $
��Left=�6/   $��31��6J   $��
61,104,0,0q�6V   $	��Top=�6j   $
��Auto��6�   �� 5   
   -   5        $ phoneNumber��5      $��Label��6%   $
��Left=�65   $��31��6P   $��
61,166,0,0q�6\   $	��Top=�6p   $
��Auto��6�   �� 5   
   -   5         ��Name$ OperationBox��5      $
��Left=�6)   $��31��6D   $��
70,298,0,0q�6P   $	��Top=�6d   $	��177��6|   �� 5   
   -   5         ��Name$ OperationButton��5      $$��Press to execute the operation��6*   $
��Left=�6S   $��25��6n   $��
70,342,0,0q�6z   $	��Top=�6�   $	��177��6�   6�   �� 5   
   -	   5         ��Name$ moneyAmountOperation��5       �� TextWrapping$
 Wrap=�60   $��25��6D   $��70,260,553,0q�6P   $	��Top=�6f   �� 5   
   -
   5        $ logOutButton��5      $��Log out��6'   $
��Left=�69   $��723,384,0,0q�6T   $	��Top=�6i   6�   �� 5   
   -   5        $ createNewAccountButton��5      $��Create new account��61   $
��Left=�6N   $��
318,94,0,0q�6i   $	��Top=�6}   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ accountListDataGrid��5         AutoGenerateColumns$
 True��60   
�������   SelectionMode$ Single=�6^   	   GridLinesVisibility$
	 None=�6u   
   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$
 * 6�      
IsReadOnly$
 True��6�      CanUserResizeRows$ False��6�      RowDetailsVisibilityMode$ Visible=�6�   $
��Left=�6�   $	��163��6
  $��400,151,0,0q�6  $	��Top=�6,  $	��305��6D  �� 5   
   -   5        $��Transcation History��5      $
��Left=�6/   $��25��6J   $��634,329,0,0q�6V   $	��Top=�6k   $	��111��6�   6�   �� 5   
   -   5        $ transferWinButton��5      $��Transfer money��6,   $
��Left=�6E   $��25��6`   $��500,329,0,0q�6l   $	��Top=�6�   $	��116��6�   6�   �� 5   
   -   5        $��Change user data��5      $
��Left=�6,   $��
61,197,0,0q�6G   $	��Top=�6[   $	��120��6s   6   5       5#      