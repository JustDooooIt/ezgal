using Godot;
using System;

public partial class End : Control
{
	[Export]
	AudioStreamPlayer Music { get; set; }
	[Export]
	TextureRect EndTexture { get; set; }
	public override void _Ready()
	{
		Tools.SetTexture(EndTexture, "end_texture");
	}

	public override void _Process(double delta)
	{
	}
}
