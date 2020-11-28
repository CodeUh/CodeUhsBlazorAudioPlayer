// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    public partial class AudioPlayer : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "C:\dev\CodeUhSite\CodeUhSite\Pages\AudioPlayer.razor"
       

    [Parameter] public List<AudioTrackData> AudioTracks { get; set; }

    public AudioTrackData CurrentTrack { get; set; }

    public bool IsPlaying { get; set; } = false;

    public bool IsEventListenersAdded { get; set; }

    protected override void OnInitialized()
    {
        AudioTracks[0].IsSelected = true;
        CurrentTrack = AudioTracks[0];
    }

    public async Task PlayAudioFile(string audioFile)
    {
        await js.InvokeVoidAsync("PlayAudioFile", new object[] { audioFile });
        if (!IsEventListenersAdded)
        {
            var audioPlayer = DotNetObjectReference.Create(this);
            await js.InvokeVoidAsync("AddAudioEventListeners", audioPlayer);
            IsEventListenersAdded = true;
        }
    }

    public async Task StopAudioFile()
    {
        await js.InvokeVoidAsync("StopAudioFile");
    }

    public string GetPlayPauseCss()
    {
        return IsPlaying ? "oi oi-play-circle playingSpin" : "oi oi-play-circle";
    }

    public string GetPlayPauseTitle()
    {
        return IsPlaying ? "Stop" : "Play";
    }

    public async Task ClickPlayPause()
    {
        if (IsPlaying)
        {
            await StopAudioFile();
        }
        else
        {
            await PlayAudioFile(CurrentTrack.TrackFile);
        }

        IsPlaying = !IsPlaying;

        StateHasChanged();
    }

    [JSInvokable("AudioEnded")]
    public async Task AudioEnded()
    {
        CurrentTrack.IsSelected = false;
        var currentTrackIndex = AudioTracks.IndexOf(CurrentTrack);
        if((currentTrackIndex + 1) == AudioTracks.Count)
        {
            AudioTracks[0].IsSelected = true;
            CurrentTrack = AudioTracks[0];
        }
        else
        {
            AudioTracks[currentTrackIndex + 1].IsSelected = true;
            CurrentTrack = AudioTracks[currentTrackIndex + 1];
        }
        await ClickPlayPause();
        if (!IsPlaying)
            await ClickPlayPause();
        StateHasChanged();
    }

    [JSInvokable("AudioStopped")]
    public void AudioStopped()
    {
        IsPlaying = false;
        StateHasChanged();
    }

    [JSInvokable("AudioStarted")]
    public void AudioStarted()
    {
        IsPlaying = true;
        StateHasChanged();
    }

    public async Task OnTrackSelected(AudioTrackData track)
    {
        foreach(var t in AudioTracks)
        {
            t.IsSelected = false;
        }
        track.IsSelected = true;

        CurrentTrack = track;
        await StopAudioFile();
        await ClickPlayPause();
        if (!IsPlaying)
            await ClickPlayPause();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
    }
}
#pragma warning restore 1591
