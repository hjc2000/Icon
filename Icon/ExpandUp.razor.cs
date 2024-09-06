﻿using Microsoft.AspNetCore.Components;

namespace Icon;

/// <summary>
///		展开按钮。方向向上。
/// </summary>
public partial class ExpandUp
{
	/// <summary>
	///		颜色。默认值：inherit
	/// </summary>
	[Parameter]
	public string Color { get; set; } = "inherit";
}
