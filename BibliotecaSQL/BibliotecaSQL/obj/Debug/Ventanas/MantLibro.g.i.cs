﻿#pragma checksum "..\..\..\Ventanas\MantLibro.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41E236D0B42D241F2505246F5FFDDE2CE9E32907"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using BibliotecaSQL.Ventanas;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace BibliotecaSQL.Ventanas {
    
    
    /// <summary>
    /// MantLibro
    /// </summary>
    public partial class MantLibro : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\Ventanas\MantLibro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_isbn;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Ventanas\MantLibro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_titulo;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Ventanas\MantLibro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_editorial;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Ventanas\MantLibro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_descripcion;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Ventanas\MantLibro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_registrar;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Ventanas\MantLibro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_modificar;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Ventanas\MantLibro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_eliminar;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Ventanas\MantLibro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dp_FechaPublicacion;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Ventanas\MantLibro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_GuardarEjemplar;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Ventanas\MantLibro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txt_numEjemplar;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Ventanas\MantLibro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_buscarLibro;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Ventanas\MantLibro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ImageBuscar;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Ventanas\MantLibro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbCampos;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Ventanas\MantLibro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbBusqueda;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Ventanas\MantLibro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/BibliotecaSQL;component/ventanas/mantlibro.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Ventanas\MantLibro.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.txt_isbn = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txt_titulo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txt_editorial = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txt_descripcion = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.btn_registrar = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\Ventanas\MantLibro.xaml"
            this.btn_registrar.Click += new System.Windows.RoutedEventHandler(this.btn_registrar_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btn_modificar = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\Ventanas\MantLibro.xaml"
            this.btn_modificar.Click += new System.Windows.RoutedEventHandler(this.btn_modificar_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btn_eliminar = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\Ventanas\MantLibro.xaml"
            this.btn_eliminar.Click += new System.Windows.RoutedEventHandler(this.btn_eliminar_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.dp_FechaPublicacion = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 9:
            this.btn_GuardarEjemplar = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\Ventanas\MantLibro.xaml"
            this.btn_GuardarEjemplar.Click += new System.Windows.RoutedEventHandler(this.btn_GuardarEjemplar_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.txt_numEjemplar = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.btn_buscarLibro = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\Ventanas\MantLibro.xaml"
            this.btn_buscarLibro.Click += new System.Windows.RoutedEventHandler(this.btn_buscarLibro_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.ImageBuscar = ((System.Windows.Controls.Image)(target));
            return;
            case 13:
            this.cbCampos = ((System.Windows.Controls.ComboBox)(target));
            
            #line 31 "..\..\..\Ventanas\MantLibro.xaml"
            this.cbCampos.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbCampos_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 14:
            this.tbBusqueda = ((System.Windows.Controls.TextBox)(target));
            return;
            case 15:
            this.label = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

