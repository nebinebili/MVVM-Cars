   M S B A M L   `   `   `  ����D  @Wpf(MVVM), Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Wpf_MVVM_.ViewsWpf_MVVM_.Views  5   	   ;"clr-namespace:Wpf_MVVM_.ViewModelsWpf_MVVM_.ViewModels  5   	       Wpf_MVVM_.Views.MainView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Wpf_MVVM_.Views     5   	   9
ViewModels"clr-namespace:Wpf_MVVM_.ViewModels     5   	   Hi:http://schemas.microsoft.com/expression/2010/interactivity     5   	   *prismhttp://prismlibrary.com/     5	   	     � Title$  MainView��5   	   $	��500��6   $	��800��6'    � DataContext 5      (   "Wpf_MVVM_.ViewModels.MainViewModel  5   
   6%   .��5      �� $	��350��6   .+�5   
   �� -   5        $��cmbBox��5      $��28(�5      ��5      �� *Cars+5      �� 5   
   $��32(�6   .��6   Vendor6&   �� 5   
   $��32(�6   
���������6"   �� *
Car.Vendor+6R   �� 5   
   $��32(�6   .��6   Model6%   �� 5   
   $��32(�6   
���������6"   �� *	Car.Model+6Q   �� 5   
   $��32(�6   .��6   Year6$   �� 5   
   $��32(�6   
���������6"   �� *
Car.Year+6P   �� 5    
   $��32(�61   $��10q�6?   ��6   �� *ShowCommand+.��6K   Show6Q   �� 5!   
   $��32(�62   $��10q�6@   ��6   �� *EditCommand+.��6L   Edit6R   5#      5%      