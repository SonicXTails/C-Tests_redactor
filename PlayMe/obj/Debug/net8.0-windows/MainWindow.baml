   M S B A M L   `   `   `  ����A  =PlayMe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PlayMePlayMe  5   	       PlayMe.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	    localclr-namespace:PlayMe  5   	     � Title$  
MainWindow��5	   	   $	��500��6   $	��350��6)   ���	#FF071A52.��5
      �  � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!    � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   .+�5    
   G� -   5         G�Name$ Password_for_Admin��5!      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Floating Password��5"         
Foreground
 � � �.  (MaterialDesignThemes.Wpf.TextFieldAssist   UnderlineBrush
 � � � )  %MaterialDesignFloatingHintPasswordBox#��[  5%      $��3��5&      $��8��6!   $��Center=�5'      $	��Top=�5(      �� 5*   
   -   5         7 3MaterialDesignFloatingActionMiniSecondaryDarkButton#��[ 5+       � ToolTip$9 3MaterialDesignFloatingActionMiniSecondaryDarkButton��5,      $��4��5.      $��8��6   $
��Left=�5/      $	��Top=�50      {�5-      �� *DataContext.ControlsEnabled+ �� RelativeSource �� *FindAncestor+	 �� AncestorType
	 Window.��51      '  !MaterialDesignThemes.Wpf.PackIcon  
   Kind$
 ArchiveEdit=�6&   52      �� 54   
   $��0��55      $��1��6   $��5��6*   $-��'Hi user! Choose what do you want to do:��56      $��Center=�57      $��Center=�58      $��15(�59      �� 5;   
   -   5          MaterialDesignRaisedButton#��[ 5<      +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��5=      $3 -MaterialDesignRaisedButton with Round Corners��5>      $��1��5@      $��3��6   $��3��5A      ���	#FF79B700
���   �
���   �{�5?      �� *DataContext.ControlsEnabled+ �� *FindAncestor+
	 Window.��5B      �� $��I want to take the test��6   5C      5D      5E      