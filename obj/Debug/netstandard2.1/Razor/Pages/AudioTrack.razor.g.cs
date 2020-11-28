#pragma checksum "C:\dev\CodeUhSite\CodeUhSite\Pages\AudioTrack.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7254b989e73ccc7573ed93f045509e16ad443b43"
// <auto-generated/>
#pragma warning disable 1591
namespace CodeUhSite.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\dev\CodeUhSite\CodeUhSite\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\dev\CodeUhSite\CodeUhSite\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\dev\CodeUhSite\CodeUhSite\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\dev\CodeUhSite\CodeUhSite\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\dev\CodeUhSite\CodeUhSite\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\dev\CodeUhSite\CodeUhSite\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\dev\CodeUhSite\CodeUhSite\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\dev\CodeUhSite\CodeUhSite\_Imports.razor"
using CodeUhSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\dev\CodeUhSite\CodeUhSite\_Imports.razor"
using CodeUhSite.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\dev\CodeUhSite\CodeUhSite\_Imports.razor"
using CodeUhSite.Models;

#line default
#line hidden
#nullable disable
    public partial class AudioTrack : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "li");
            __builder.AddAttribute(1, "style", "cursor:pointer;");
            __builder.AddAttribute(2, "class", 
#nullable restore
#line 1 "C:\dev\CodeUhSite\CodeUhSite\Pages\AudioTrack.razor"
                                    GetTrackCss()

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 1 "C:\dev\CodeUhSite\CodeUhSite\Pages\AudioTrack.razor"
                                                             ClickTrack

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(4, 
#nullable restore
#line 1 "C:\dev\CodeUhSite\CodeUhSite\Pages\AudioTrack.razor"
                                                                         AudioTrackData.TrackName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 3 "C:\dev\CodeUhSite\CodeUhSite\Pages\AudioTrack.razor"
       
    [Parameter] public AudioTrackData AudioTrackData { get; set; }
    [Parameter] public EventCallback<AudioTrackData> TrackSelected { get; set; }

    string GetTrackCss()
    {
        return AudioTrackData.IsSelected ? "list-group-item  alert-primary" : "list-group-item ";
    }

    async Task ClickTrack()
    {
        await TrackSelected.InvokeAsync(AudioTrackData);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
