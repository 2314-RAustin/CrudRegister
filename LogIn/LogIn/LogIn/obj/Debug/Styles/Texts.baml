   M S B A M L   `   `   `  ����@  <LogIn, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:LogInLogIn  5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=null  �� 
TargetType   
HeaderText  BaseTextBlockStyle �� BasedOn �� Property  ForegroundMainBrush �� Value �� RelativeSource �� AncestorLevel �� AncestorType  MaterialDesignTextBoxBorder.   (MaterialDesignThemes.Wpf.TextFieldAssist  PrimaryHueMidBrush-  'System.Windows.Input.KeyboardNavigation �� 
TargetType m� Command	 m� Icon'  !MaterialDesignThemes.Wpf.PackIcon�  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=null]]
   Kind �� Triggers ]� 
Conditions �� Property �� Value�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      localclr-namespace:LogIn  5      FmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      %?  &	        7  7  '�� �     �� 5      "  ��6   8   .�5   
   ��  � ��8  6'   �� 5   
    � ��$ Center=�6.   �� 5	   
    � ��$ Center=�60   �� 5
   
    � ��$	 0 6q�6#   5      �� 5      "  ��6   .�5   
   ��  � �� 6'   �� *(TextElement.Foreground)+ �� *FindAncestor+$ 1��" ��� 5   
    � ��# �  6(   �� 5   
    � ��$ 0,0,0,1q�6,   �� 5   
    �@  TextBoxViewMargin$ 0,0,1,0q�6M   �� 5   
    � ��
 ���� 6'   �� 5   
    �@��
CaretBrush# �  6'   �� 5   
    �@ TabNavigation$
 None=�6=   �� 5   
    � ��$ Stretch=�67   �� 5   
    � ��$ Bottom=�65   �� 5   
    �@�FocusVisualStyle 6-   Z� �� 5   
    �@J�	AllowDrop . 6&   �� 5   
    �@��PanningMode$ VerticalFirst=�65   �� 5   
    �@��IsFlicksEnabled .  63   �� 5       �@=�ErrorTemplate 5      �� 5      " ��6"   5      5      �� 5    
   " �@  IncludeSpellingSuggestions 6V   �� *(SpellCheck.IsEnabled)+ �� *Self+�� 5!   
   " �@  NewSpecHighlightingEnabled .  6V   �� 5"   
    �@  RippleOnFocusEnabled .  6P   �� 5#   
    �@�ContextMenu 5$      �� 5%      .@�5&      m� $ ApplicationCommands.Cut��6   	 5'        5(      $

 Clip=�66   5*      m� 5+      $ ApplicationCommands.Copy��6   	 5,        5-      $
 ContentCopy=�66   5/      m� 50      $ ApplicationCommands.Paste��6   	 51        52      $
 ContentPaste=�66   54      55      57       58   
   ]� 59       5:      �� 5;      + �@��#IsInactiveSelectionHighlightEnabled . 6O   �� 5<       �@��IsSelectionActive .  6=   ./�5>      ��  �@��SelectionBrush# � /�63   5?      5A      5B      