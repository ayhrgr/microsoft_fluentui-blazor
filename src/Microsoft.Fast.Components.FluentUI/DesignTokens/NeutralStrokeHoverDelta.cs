﻿using Microsoft.Extensions.Configuration;
using Microsoft.JSInterop;

namespace Microsoft.Fast.Components.FluentUI.DesignTokens;

/// <summary>
/// The NeutralStrokeHoverDelta design token
/// </summary>
public sealed class NeutralStrokeHoverDelta : DesignToken<int?>
{
    public NeutralStrokeHoverDelta()
    {
        Name = Constants.NeutralStrokeHoverDelta;
    }

    /// <summary>
    /// Constructs an instance of the NeutralStrokeHoverDelta design token
    /// </summary>
    /// <param name="jsRuntime">IJSRuntime reference (from DI)</param>
    /// <param name="configuration">IConfiguration reference (from DI)</param>
    public NeutralStrokeHoverDelta(IJSRuntime jsRuntime, IConfiguration configuration) : base(jsRuntime, configuration)
    {
        Name = Constants.NeutralStrokeHoverDelta;
    }
}
