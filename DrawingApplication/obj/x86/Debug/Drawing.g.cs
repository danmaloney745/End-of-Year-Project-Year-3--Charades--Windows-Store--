﻿

#pragma checksum "C:\Users\Dan\Desktop\Charades (Windows Store)\DrawingApplication\Drawing.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "AABF65D9F9C662E00ABDFF2722BA0821"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DrawingApplication
{
    partial class Drawing : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 39 "..\..\..\Drawing.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.backButton_Click;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 41 "..\..\..\Drawing.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.penbtn_Click;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 42 "..\..\..\Drawing.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.linebtn_Click;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 43 "..\..\..\Drawing.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.circlebtn_Click;
                 #line default
                 #line hidden
                break;
            case 5:
                #line 44 "..\..\..\Drawing.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.rectbtn_Click;
                 #line default
                 #line hidden
                break;
            case 6:
                #line 45 "..\..\..\Drawing.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.erasebtn_Click;
                 #line default
                 #line hidden
                break;
            case 7:
                #line 47 "..\..\..\Drawing.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.Selector)(target)).SelectionChanged += this.cbChangeColour_SelectionChanged;
                 #line default
                 #line hidden
                break;
            case 8:
                #line 62 "..\..\..\Drawing.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.Selector)(target)).SelectionChanged += this.cbFillColour_SelectionChanged;
                 #line default
                 #line hidden
                break;
            case 9:
                #line 76 "..\..\..\Drawing.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.stopbtn_Click;
                 #line default
                 #line hidden
                break;
            case 10:
                #line 77 "..\..\..\Drawing.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.clearbtn_Click;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}

