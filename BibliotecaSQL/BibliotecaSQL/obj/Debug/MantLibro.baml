   M S B A M L   `   `   `  ����H  DBibliotecaSQL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:BibliotecaSQLBibliotecaSQL  5   	       BibliotecaSQL.MantLibro   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:BibliotecaSQL     5   	     � Title$  	MantLibro��5   	   $��454.297��6   $��868.656��6,   .��5	      �  � RowDefinitions 5
   
   �� 5      .+�5   
   �� $
��ISBN��6   $
��Left=�6   $��	27,88,0,0q�6:   $	��Top=�6M   �� 5   
   -   5        $��txt_isbn��5      $
��Left=�6"   $��26��6=   $��
104,88,0,0q�6I    �� TextWrapping$
 Wrap=�6]   $�� ��6q   $	��Top=�6y   $	��195��6�   �� 5   
   $��Titulo��6   $
��Left=�6"   $��
27,119,0,0q�6=   $	��Top=�6Q   �� 5   
   -   5        $��
txt_titulo��5      $
��Left=�6$   $��26��6?   $��104,119,0,0q�6K   $
 Wrap=�6`   $�� ��6t   $	��Top=�6|   $	��195��6�   �� 5   
   $��	Editorial��6   $
��Left=�6$   $��
27,150,0,0q�6?   $	��Top=�6S   �� 5   
   -   5        $��txt_editorial��5      $
��Left=�6'   $��26��6B   $��104,150,0,0q�6N   $
 Wrap=�6c   $�� ��6w   $	��Top=�6   $	��195��6�   �� 5   
   $��Descripcion��6   $
��Left=�6&   $��
27,181,0,0q�6A   $	��Top=�6U   �� 5   
   -   5        $��txt_descripcion��5      $
��Left=�6)   $	��121��6D   $��104,181,0,0q�6Q   $
 Wrap=�6f   $�� ��6z   $	��Top=�6�   $	��268��6�   �� 5   
   -   5        $��btn_registrar��5      $��	Registrar��6&   $
��Left=�6:   $��109,317,0,0q�6U   $	��Top=�6j   $��58��6�   6�   �� 5   
   -   5        $��btn_modificar��5      $��	Modificar��6&   $
��Left=�6:   $��174,317,0,0q�6U   $	��Top=�6j   $��56��6�   6�   �� 5   
   -   5        $��btn_eliminar��5      $��Eliminar��6%   $
��Left=�68   $��237,317,0,0q�6S   $	��Top=�6h   $��62��6�   6�   �� 5   
   $��
Ejemplares��6   $
��Left=�6%   $��
387,70,0,0q�6@   $	��Top=�6T   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgEjemplares��5         AutoGenerateColumns .  $
��Left=�6F   $	��201��6a   $��394,101,0,0q�6n   $	��Top=�6�   $	��355��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Codigo Libro��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   ��  �� Path$ CodigoLibro�  5      $ Num Ejemplar��6%    6;   �� $ NumeroEjemplar�  5      $ Fecha publicacion��6%    6@   �� $ FechaPublicacion�  5      $ Estado��6%    65   �� $ Estado�5       �� 5!   
   $��Fecha de Publicacion:��6   $
��Left=�60   $��407,316,0,0q�6K   $	��Top=�6`   (  "System.Windows.Controls.DatePicker  5"   
   -	   5        $��dp_FechaPublicacion��5"      $
��Left=�60   $��540,316,0,0q�6K   $	��Top=�6`   $��26��6x   �� 5#   
   -
   5        $��btn_GuardarEjemplar��5#      $��Guardar Ejemplar��6,   $
��Left=�6G   $��407,377,0,0q�6b   $	��Top=�6w   $	��105��6�   6�   �� 5$   
   $��Numero de ejemplar:��6   $
��Left=�6.   $��407,342,0,0q�6I   $	��Top=�6^   �� 5%   
   -   5        $��txt_numEjemplar��5%      $
��Left=�6)   $��20��6D   $��540,348,0,0q�6P   $
 Wrap=�6e   $�� ��6y   $	��Top=�6�   $	��145��6�   �� 5&   
   -   5        $��btn_buscarLibro��5&      $
��Left=�6)   $��
394,27,0,0q�6D   $	��Top=�6X   $��37��6p   $��22��6�   .��5'      �� -   5        	 ��Name$	 ImageBuscar��5'      $��/imagenes/Search.png��6)   5(      �� 5)   
   -   5        
 ��Name$
 cbCampos��5)      $
��Left=�6%   $��	21,27,0,0q�6@   $	��Top=�6S   $	��120��6k   6w   �� 5*   
   -   5         ��Name$ 
tbBusqueda��5*      $
��Left=�6&   $��22��6A   $��
147,27,0,0q�6M   $
 Wrap=�6a   $�� ��6u   $	��Top=�6}   $	��225��6�   �� 5+   
   -   5         ��Name$ label��5+      $��Buscar Por:��6   $
��Left=�65   $��27��6P   $��21,0,0,0q�6\   $	��Top=�6n   $	��126��6�   �� 5,   
   -   5         ��Name$ btNuevo��5,      $��Nuevo��6"   $
��Left=�62   $��20��6M   $��
42,317,0,0q�6Y   $	��Top=�6m   $��57��6�   6�   5-      5.      