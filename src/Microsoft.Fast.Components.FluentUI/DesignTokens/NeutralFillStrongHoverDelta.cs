﻿using Microsoft.Extensions.Configuration;
using Microsoft.JSInterop;

namespace Microsoft.Fast.Components.FluentUI.DesignTokens;

/// <summary>
/// The NeutralFillStrongHoverDelta design token
/// </summary>
public sealed class NeutralFillStrongHoverDelta : DesignToken<int?>
{
    public NeutralFillStrongHoverDelta()
    {
        Name = Constants.NeutralFillStrongHoverDelta;
    }

    /// <summary>
    /// Constructs an instance of the NeutralFillStrongHoverDelta design token
    /// </summary>
    /// <param name="jsRuntime">IJSRuntime reference (from DI)</param>
    /// <param name="configuration">IConfiguration reference (from DI)</param>
    public NeutralFillStrongHoverDelta(IJSRuntime jsRuntime, IConfiguration configuration) : base(jsRuntime, configuration)
    {
        Name = Constants.NeutralFillStrongHoverDelta;
    }
}
