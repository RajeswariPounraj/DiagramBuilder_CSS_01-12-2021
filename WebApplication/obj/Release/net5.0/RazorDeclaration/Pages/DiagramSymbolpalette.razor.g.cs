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
#line 1 "D:\DiagramBuilder-1-10-2021\DB-1-10-2021-Changes(8-10)\DB-CSS-25-10-2021\DB_TESTING_ISSUES\Diagram-Builder-Publish\WebApplication\Pages\DiagramSymbolpalette.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DiagramBuilder-1-10-2021\DB-1-10-2021-Changes(8-10)\DB-CSS-25-10-2021\DB_TESTING_ISSUES\Diagram-Builder-Publish\WebApplication\Pages\DiagramSymbolpalette.razor"
using Syncfusion.Blazor.Diagram;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\DiagramBuilder-1-10-2021\DB-1-10-2021-Changes(8-10)\DB-CSS-25-10-2021\DB_TESTING_ISSUES\Diagram-Builder-Publish\WebApplication\Pages\DiagramSymbolpalette.razor"
using Syncfusion.Blazor.Diagram.SymbolPalette;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\DiagramBuilder-1-10-2021\DB-1-10-2021-Changes(8-10)\DB-CSS-25-10-2021\DB_TESTING_ISSUES\Diagram-Builder-Publish\WebApplication\Pages\DiagramSymbolpalette.razor"
using System.Collections.ObjectModel;

#line default
#line hidden
#nullable disable
    public partial class DiagramSymbolpalette : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "D:\DiagramBuilder-1-10-2021\DB-1-10-2021-Changes(8-10)\DB-CSS-25-10-2021\DB_TESTING_ISSUES\Diagram-Builder-Publish\WebApplication\Pages\DiagramSymbolpalette.razor"
       

    internal DiagramLeftSideBar Parent;

        
        SfSymbolPaletteComponent PaletteInstance;
        DiagramSize SymbolPreview;
        SymbolMargin SymbolMargin = new SymbolMargin { Left = 10, Right = 10, Top = 10, Bottom = 10 };
        double symbolSizeWidth;
        double symbolSizeHeight;
        DiagramObjectCollection<Palette> Palettes { get; set; }
        public Palette FlowShapePalette { get; set; }
        public Palette BasicShapePalette { get; set; }
        public Palette BpmnShapePalette { get; set; }
        public Palette ConnectorPalette { get; set; }
        public Palette HtmlShapePalette { get; set; }
        public Palette NativeShapePalette { get; set; }
        public Palette ElectericalAudio { get; set; }
        public Palette NetworkShapes { get; set; }
        public Palette FloorPlaneShapes { get; set; }
        public DiagramObjectCollection<NodeBase> FlowShapeList { get; set; }
        public DiagramObjectCollection<NodeBase> BasicShapeList { get; set; }
        public DiagramObjectCollection<NodeBase> BpmnShapeList { get; set; }
        public DiagramObjectCollection<NodeBase> HTMLShapeList { get; set; }
        public DiagramObjectCollection<NodeBase> NativeShapeList { get; set; }
        public DiagramObjectCollection<NodeBase> ConnectorList { get; set; }
        public DiagramObjectCollection<NodeBase> NetworkShapesList { get; set; }
        public DiagramObjectCollection<NodeBase> FloorPlaneShapesList { get; set; }

        protected override void OnInitialized()
        {

        symbolSizeWidth = 50;
        symbolSizeHeight = 50;   
        SymbolPreview = new DiagramSize();
        SymbolPreview.Width = 100;
        SymbolPreview.Height = 100;
        InitializePalettes();
        FlowShapePalette = new Palette() { Symbols = FlowShapeList, Title = "Flow Shapes", ID = "Flow Shapes", IconCss = "e-ddb-icons e-flow" };
        BasicShapePalette = new Palette() { Symbols = BasicShapeList, Title = "Basic Shapes", ID = "Basic Shapes",  IconCss = "e-ddb-icons e-flow" };
        ConnectorPalette = new Palette() { Symbols = ConnectorList, Title = "Connectors", ID = "Connector Shapes",  IconCss = "e-ddb-icons e-connector" };
        Palettes = new DiagramObjectCollection<Palette>();
        Palettes.Add(FlowShapePalette);
        Palettes.Add(BasicShapePalette);
        Palettes.Add(ConnectorPalette);
      
        }
        protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        PaletteInstance.Targets = new DiagramObjectCollection<SfDiagramComponent>() { };
       
        PaletteInstance.Targets.Add(Parent.Parent.DiagramContent.Diagram);
        if (firstRender) {
            //InitializeElectricalShapes();
            //InitializeBPMNPalettes();
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 100 "D:\DiagramBuilder-1-10-2021\DB-1-10-2021-Changes(8-10)\DB-CSS-25-10-2021\DB_TESTING_ISSUES\Diagram-Builder-Publish\WebApplication\Pages\DiagramSymbolpalette.razor"
                                      
            InitializeHTMLPalettes();
            InitializeNativePalettes();
            await Task.Delay(1).ConfigureAwait(true);
        }
    }
     private SymbolInfo GetSymbolInfo(IDiagramObject symbol)
    {
        SymbolInfo SymbolInfo = new SymbolInfo();
        SymbolInfo.Fit = true;
        string text = null;
        if (symbol is Node)
        {
            text = ((symbol as Node).Shape as Shape).Type.ToString() + (symbol as Node).ID;

        }
        else
        {
            text = "connectors" + (symbol as Connector).ID;
        }
        //SymbolInfo.Description = new SymbolDescription() { Text = text };
        return SymbolInfo;
        }
        

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
