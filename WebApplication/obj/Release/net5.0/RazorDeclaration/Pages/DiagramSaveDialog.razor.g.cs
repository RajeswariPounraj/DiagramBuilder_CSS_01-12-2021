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
#line 2 "D:\DiagramBuilder-1-10-2021\DB-1-10-2021-Changes(8-10)\DB-CSS-25-10-2021\DB_TESTING_ISSUES\Diagram-Builder-Publish\WebApplication\Pages\DiagramSaveDialog.razor"
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
    public partial class DiagramSaveDialog : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "D:\DiagramBuilder-1-10-2021\DB-1-10-2021-Changes(8-10)\DB-CSS-25-10-2021\DB_TESTING_ISSUES\Diagram-Builder-Publish\WebApplication\Pages\DiagramSaveDialog.razor"
       
    internal DiagramMenuBar Parent;
    public string DiagramfileName = "Diagram1";
    public SfDialog SaveDialog;
    public bool SaveDialogVisible = false;

    private async Task BtnSave()
    {
        string fileName = await jsRuntime.InvokeAsync<string>("getDiagramFileName", "save");
        await Parent.Download(fileName);
        await SaveDialog.Hide();
    }
    private async Task btnCancelClick()
    {
        await SaveDialog.Hide();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
    }
}
#pragma warning restore 1591
