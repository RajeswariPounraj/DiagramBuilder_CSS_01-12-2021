// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebApplicationDiagramBuilder
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\DiagramBuilder-1-10-2021\DB-1-10-2021-Changes(8-10)\DB-CSS-25-10-2021\DB_TESTING_ISSUES\Diagram-Builder-Publish\WebApplication\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DiagramBuilder-1-10-2021\DB-1-10-2021-Changes(8-10)\DB-CSS-25-10-2021\DB_TESTING_ISSUES\Diagram-Builder-Publish\WebApplication\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\DiagramBuilder-1-10-2021\DB-1-10-2021-Changes(8-10)\DB-CSS-25-10-2021\DB_TESTING_ISSUES\Diagram-Builder-Publish\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\DiagramBuilder-1-10-2021\DB-1-10-2021-Changes(8-10)\DB-CSS-25-10-2021\DB_TESTING_ISSUES\Diagram-Builder-Publish\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\DiagramBuilder-1-10-2021\DB-1-10-2021-Changes(8-10)\DB-CSS-25-10-2021\DB_TESTING_ISSUES\Diagram-Builder-Publish\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\DiagramBuilder-1-10-2021\DB-1-10-2021-Changes(8-10)\DB-CSS-25-10-2021\DB_TESTING_ISSUES\Diagram-Builder-Publish\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\DiagramBuilder-1-10-2021\DB-1-10-2021-Changes(8-10)\DB-CSS-25-10-2021\DB_TESTING_ISSUES\Diagram-Builder-Publish\WebApplication\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\DiagramBuilder-1-10-2021\DB-1-10-2021-Changes(8-10)\DB-CSS-25-10-2021\DB_TESTING_ISSUES\Diagram-Builder-Publish\WebApplication\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\DiagramBuilder-1-10-2021\DB-1-10-2021-Changes(8-10)\DB-CSS-25-10-2021\DB_TESTING_ISSUES\Diagram-Builder-Publish\WebApplication\_Imports.razor"
using WebApplicationDiagramBuilder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\DiagramBuilder-1-10-2021\DB-1-10-2021-Changes(8-10)\DB-CSS-25-10-2021\DB_TESTING_ISSUES\Diagram-Builder-Publish\WebApplication\_Imports.razor"
using WebApplicationDiagramBuilder.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\DiagramBuilder-1-10-2021\DB-1-10-2021-Changes(8-10)\DB-CSS-25-10-2021\DB_TESTING_ISSUES\Diagram-Builder-Publish\WebApplication\Pages\DiagramToolBar.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DiagramBuilder-1-10-2021\DB-1-10-2021-Changes(8-10)\DB-CSS-25-10-2021\DB_TESTING_ISSUES\Diagram-Builder-Publish\WebApplication\Pages\DiagramToolBar.razor"
using Syncfusion.Blazor.Buttons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\DiagramBuilder-1-10-2021\DB-1-10-2021-Changes(8-10)\DB-CSS-25-10-2021\DB_TESTING_ISSUES\Diagram-Builder-Publish\WebApplication\Pages\DiagramToolBar.razor"
using Syncfusion.Blazor.SplitButtons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\DiagramBuilder-1-10-2021\DB-1-10-2021-Changes(8-10)\DB-CSS-25-10-2021\DB_TESTING_ISSUES\Diagram-Builder-Publish\WebApplication\Pages\DiagramToolBar.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\DiagramBuilder-1-10-2021\DB-1-10-2021-Changes(8-10)\DB-CSS-25-10-2021\DB_TESTING_ISSUES\Diagram-Builder-Publish\WebApplication\Pages\DiagramToolBar.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
    public partial class DiagramToolBar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 190 "D:\DiagramBuilder-1-10-2021\DB-1-10-2021-Changes(8-10)\DB-CSS-25-10-2021\DB_TESTING_ISSUES\Diagram-Builder-Publish\WebApplication\Pages\DiagramToolBar.razor"
       



    internal DiagramMain Parent;

    SfToolbar Toolbar;
    
    string toolbarClassName { get; set; } = "db-toolbar-container";
    private SfDropDownButton dropdownBtn;
     private SfDropDownButton dropdownBtn1;
    string MenuHideIconCss = "sf-icon-Collapse tb-icons";
    ToolbarItem UndoItem;
    ToolbarItem RedoItem;
    ToolbarItem ZoomInItem;
    ToolbarItem ZoomItem;
    SfDropDownButton ZoomItemDropdown;
    public string ZoomItemDropdownContent = "100%";
    ToolbarItem ZoomOutItem;
    ToolbarItem PanItem;
    string PanItemCssClass = "tb-item-start";
    string fill { get; set; } = "tb-item-start tb-item-fill";
    string stroke { get; set; } = "tb-item-end tb-item-stroke";
    ToolbarItem PointerItem;
    string ShapeItem = "e-control e-dropdown-btn e-lib e-btn e-icon-btn";
    string ConnectorItem = "e-control e-dropdown-btn e-lib e-btn e-icon-btn";
    string PointerItemCssClass = "tb-item-middle tb-item-selected";
    ToolbarItem DrawShapeItem;
    string DrawShapeItemCssClass = "tb-item-middle tb-drawtools-dropdown-btn tb-custom-diagram-disable";
    ToolbarItem DrawConnectorItem;
    string DrawConnectorItemCssClass = "tb-item-middle tb-drawtools-dropdown-btn tb-custom-diagram-disable";
    ToolbarItem Fill;
    ToolbarItem Stroke;
    public string NodeFillColor { get; set; }
    ToolbarItem GroupItem;
    ToolbarItem UngroupItem;
    ToolbarItem LockItem;
    ToolbarItem DeleteItem;
    //DiagramLayerDialog LayerItemDialog;
    ToolbarItem AlignLeftItem;
    ToolbarItem AlignCenterItem;
    ToolbarItem AlignRightItem;
    ToolbarItem AlignTopItem;
    ToolbarItem AlignMiddleItem;
    ToolbarItem AlignBottomItem;
    ToolbarItem AlignVerticalItem;
    ToolbarItem AlignHorizontalItem;

    protected override void OnAfterRender(bool firstRender)
    {
        base.OnAfterRender(firstRender);
        if (firstRender)
        {
            
          

#line default
#line hidden
#nullable disable
#nullable restore
#line 247 "D:\DiagramBuilder-1-10-2021\DB-1-10-2021-Changes(8-10)\DB-CSS-25-10-2021\DB_TESTING_ISSUES\Diagram-Builder-Publish\WebApplication\Pages\DiagramToolBar.razor"
               
    }
    }
    private void ClickHandler(BeforeOpenCloseEventArgs e)
    {
        dropdownBtn.Toggle();
    }
    private void ClickHandler1(BeforeOpenCloseEventArgs e)
    {
        dropdownBtn1.Toggle();
    }
    public void OnFillColorChange(ColorPickerEventArgs args)
        {
            Parent.DiagramPropertyPanel.OnUpdateNodeProperties("Fill", (args.CurrentValue).Hex);
            Parent.DiagramPropertyPanel.UpdatePropertyPanel();
            dropdownBtn.Toggle();
        }
    public void OnStrokeColorChange(ColorPickerEventArgs args)
    {
        
        Parent.DiagramPropertyPanel.OnUpdateNodeProperties("StrokeColor", (args.CurrentValue).Hex);
        Parent.DiagramPropertyPanel.OnUpdateConnectorProperties("StrokeColor", (args.CurrentValue).Hex);
        Parent.DiagramPropertyPanel.UpdatePropertyPanel();
        dropdownBtn1.Toggle();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591