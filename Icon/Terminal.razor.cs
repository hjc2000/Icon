using Microsoft.AspNetCore.Components;

namespace Icon;

/// <summary>
///		终端图标
/// </summary>
public partial class Terminal
{
	/// <summary>
	///		在捕获 Parameter 的最后，捕获所有之前未捕获的 html 标签属性。
	/// </summary>
	[Parameter(CaptureUnmatchedValues = true)]
	public Dictionary<string, object>? CaptureUnmatchedValues { get; set; }
}
