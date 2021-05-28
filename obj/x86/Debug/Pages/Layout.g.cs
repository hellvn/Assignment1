﻿#pragma checksum "E:\Universal Windows Platform\Assignment1\Pages\Layout.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "DB2EC0EE532547E39C3E767C8DE9ED13"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Assignment1.Pages
{
    partial class Layout : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_AdaptiveTrigger_MinWindowWidth(global::Windows.UI.Xaml.AdaptiveTrigger obj, global::System.Double value)
            {
                obj.MinWindowWidth = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class Layout_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ILayout_Bindings
        {
            private global::Assignment1.Pages.Layout dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.AdaptiveTrigger obj10;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj10MinWindowWidthDisabled = false;

            public Layout_obj1_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 29 && columnNumber == 25)
                {
                    isobj10MinWindowWidthDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 10: // Pages\Layout.xaml line 28
                        this.obj10 = (global::Windows.UI.Xaml.AdaptiveTrigger)target;
                        break;
                    default:
                        break;
                }
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
            }

            public void Recycle()
            {
                return;
            }

            // ILayout_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::Assignment1.Pages.Layout)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Assignment1.Pages.Layout obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_NavigationViewControl(obj.NavigationViewControl, phase);
                    }
                }
            }
            private void Update_NavigationViewControl(global::Windows.UI.Xaml.Controls.NavigationView obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_NavigationViewControl_CompactModeThresholdWidth(obj.CompactModeThresholdWidth, phase);
                    }
                }
            }
            private void Update_NavigationViewControl_CompactModeThresholdWidth(global::System.Double obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Pages\Layout.xaml line 28
                    if (!isobj10MinWindowWidthDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_AdaptiveTrigger_MinWindowWidth(this.obj10, obj);
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Pages\Layout.xaml line 12
                {
                    this.NavigationViewControl = (global::Windows.UI.Xaml.Controls.NavigationView)(target);
                }
                break;
            case 3: // Pages\Layout.xaml line 14
                {
                    this.Home = (global::Windows.UI.Xaml.Controls.NavigationViewItem)(target);
                }
                break;
            case 4: // Pages\Layout.xaml line 15
                {
                    this.EatIn = (global::Windows.UI.Xaml.Controls.NavigationViewItem)(target);
                }
                break;
            case 5: // Pages\Layout.xaml line 16
                {
                    this.Collection = (global::Windows.UI.Xaml.Controls.NavigationViewItem)(target);
                }
                break;
            case 6: // Pages\Layout.xaml line 17
                {
                    this.Delivery = (global::Windows.UI.Xaml.Controls.NavigationViewItem)(target);
                }
                break;
            case 7: // Pages\Layout.xaml line 18
                {
                    this.TakeAway = (global::Windows.UI.Xaml.Controls.NavigationViewItem)(target);
                }
                break;
            case 8: // Pages\Layout.xaml line 19
                {
                    this.Payment = (global::Windows.UI.Xaml.Controls.NavigationViewItem)(target);
                }
                break;
            case 9: // Pages\Layout.xaml line 20
                {
                    this.Customers = (global::Windows.UI.Xaml.Controls.NavigationViewItem)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // Pages\Layout.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    Layout_obj1_Bindings bindings = new Layout_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

