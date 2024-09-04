﻿using Microsoft.AspNetCore.Components;
using RazorUI.导航;
using System.Threading.Tasks;

namespace Test.Pages.普通;
public partial class Home
{
	protected override async Task OnParametersSetAsync()
	{
		await base.OnParametersSetAsync();
		Redirector.UpdateRedirectUri();
	}

	[Inject]
	private Redirector Redirector { get; set; } = default!;
}
