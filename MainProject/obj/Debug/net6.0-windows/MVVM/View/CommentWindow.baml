   M S B A M L   `   `   `  ����F  BMainProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:MainProject.MVVM.ViewMainProject.MVVM.View  5   	   )    #MainProject.MVVM.View.CommentWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   5local#clr-namespace:MainProject.MVVM.View     5   	     � Title$  CommentWindow��5   	   $	��500��6   $	��500��6,    � WindowStartupLocation$ CenterScreen=�5	   	    � WindowStyle$
 None=�5
   	   
������  � AllowsTransparency$
 True��5   	   .��5      ��  �� CornerRadius$ 20��6   $��30q�6   
������� �� Padding$ 5q�6?   
������� J� Effect 5   
   3  -System.Windows.Media.Effects.DropShadowEffect  5         ShadowDepth$ 0Q�6      
BlurRadius$ 10Q�6/   	   Color$	 #333333��6?   
   Opacity$	
 0.4Q�6O   ._�5   
   �  � RowDefinitions 5      �� 5      $��* �6    �� 5      $
��Auto �6    .+�5      �� -   5        $��0��5      $��Hidden=�6(   .��5      �� .+�5      �� -   5        $��MyItemsControl��5   D   ��6#   �� *
Comments+��5%      �� 5&      .R�5'   "   �� $��10q�6)   ._�5(   &   �  � ColumnDefinitions 5)   *   �� 5*   .   $
��Auto �6?   �� 5+   .   $
��Auto �6?   .+�5-   *   �� $��0��5.   -   $��34��50   -   $��34��51   -   $��Right=�52   -   $	��0 3q�53   -   $��Bottom=�54   -   ��5/   -   �� *UserProfilePicture+ J� Clip 55   .   @� 56   2    @� Center$ 17,17&�6B    @� RadiusX$ 17Q�6Q    @� RadiusY$ 17Q�6^   58   +   �� 5:   '   $��1��6.   $
 10 0q�6>   ._�5;   +   �� .+�5<   /   �� ���#727EA8$��14(�5>   G   $��Medium"�5?   2   $��1��5@   2   $
��Left=�5A   2   $��Center=�5B   2   ��5=   2   �� *Name+5B   2   �� 5D   ,   ���#eeeeee$ 6q�6H   $ 5��6T   ._�5E   0   �� $��2��66   $
��Left=�5G   6   ��5F   6   �� *CommentMessage+5G   6   5H   -   5I   ,   5J   (   5M   '   5N   #   5O      5Q      5R      5S      �� 5T      -   5        $��Right=�5T      $	��Top=�61   $��10q�6I      Button-Close#��[  6U   .��5U      �� $��/Images/Close.png��6   $��37��63   6@   5V      � 5W      $��2��6   $��Bottom=�6     5X      �� 5Y      �� 5Z      $��80 �6'   .+�5\      �� -   5        $��senderTB��5\   *   $��0��6   $��16q�6:   $��10q�6G     TextBoxStyle#��[ 6o   
 � Tag$ Message��6�   ��6S   �� *
NewComment+6�   �� 5]      -   5        $��1��5]      $
��Send��6)   $��Center=�68   $��16q�6S   $��0 10  10 10 q�6`     Button-Fill#��[ 6�   ��6v   �� *AddCommentCommand+5_      5`      5a      5b      5c      