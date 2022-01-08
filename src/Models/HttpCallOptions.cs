﻿using System.Collections.Immutable;

namespace MyNihongo.HttpService;

public sealed record HttpCallOptions
{
	public string[] PathSegments { get; init; } = Array.Empty<string>();

	public IImmutableDictionary<string, string> Headers { get; init; } = ImmutableDictionary<string, string>.Empty;
}