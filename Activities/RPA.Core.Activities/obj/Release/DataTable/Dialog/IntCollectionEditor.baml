   M S B A M L   `   `   `  ���� Q  MPlugins.Shared.Library, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulluOclr-namespace:Plugins.Shared.Library.Converters;assembly=Plugins.Shared.Library!Plugins.Shared.Library.Converters   RPA.Core.ActivitiesF   @RPA.Core.Activities.DataTableActivity.Dialog.IntCollectionEditor   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     _srcOclr-namespace:Plugins.Shared.Library.Converters;assembly=Plugins.Shared.Library       � 	Resources     CollectionElements �� Source �� Path �� ElementName �� ModeF   @Plugins.Shared.Library.Converters.IntCollectionToStringConverter " intCollectionToStringConverter  DownArrowGeometry  AddPath �� StrokeStartLineCap �� StrokeEndLineCap �� Stretch �� RelativeSource	 E� 
StartPoint
 �� Point  ButtonStyle �� 
TargetType �� Property �� Value��%�  &	        &	 K     &	 P     &	 o     &	 M    ��  �� $ CollectionElements�$ CollectionEditor��$ TwoWay=�  �M 0 0 L 3.5 4 L 7 0 Z�F� $	��1.5��$ Square=�$ Square=�$ Uniform=�$��Center=�$��Center=�����  �� *Self+$ (TextElement.Foreground)���B� ��E� $		 0,0&�.���� $
 25,25&�E� $
	 0,25&�.���� $

 25,0&��� " ��.���  � ��$ 1q���  � ��$ 23��.���  � RowDefinitions �� $��* ��� $��0 �.+�]� ��. $��0��.+��� -   $��ComboboxInputBox��$
��Left=� �� MaxLines$ 1������ *ItemsSource+$ CollectionEditor��$ TwoWay=� �� UpdateSourceTrigger$ 	LostFocus=� �� 	Converter# [ �� -   $��PropertiesComboBox��$��1��$
��Left=� �� StaysOpenOnEdit .  �� MaxDropDownHeight$	 200��$
��Auto=�$��Disabled=����� *BorderBrush+$ ComboboxInputBox����-  'System.Windows.Data.CompositeCollection  ��  �� 
Collection ��  �� Source# [  �� -   $��NewValueElement������ .R�]� ��. $��5,2,0,2q����� *ActualWidth+$ ComboboxInputBox��$ OneWay=�.+��� $��Right=�$��16��$��2,0,10,0q�#��[ #��[ ���� *BorderBrush+$ ComboboxInputBox���� $��NewValueTextBox��$
��Left=����� *
NewValue+$ CollectionEditor��$ TwoWay=�$ PropertyChanged=����� .R�]� ��. ���� *ActualWidth+$ ComboboxInputBox��$ OneWay=�.+��� $��Right=�$��16��$��2,0,10,0q����� " �� �� BasedOn# [  �� Triggers ��  �� Binding �� *IsMouseOver+ �� *FindAncestor+ �� AncestorType" �� �� Value True.a���  � y�$ Visible=�.���  � y�$ Hidden=�.��F� $	��1.5q�$	��1.5��$ Square=�$ Square=�$ Uniform=�$��Center=�$��Center=�����  �� *Self+$ (TextElement.Foreground)���B� ��E� $		 0,0&�.���� $
 25,25&�E� $
	 0,25&�.���� $

 25,0&��� $
��Left=����� *Value+$ TwoWay=����� .R�� $��
ItemsPanel������ *ActualWidth+$ ComboboxInputBox��$ OneWay=�