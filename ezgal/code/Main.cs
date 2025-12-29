using Godot;
using System;

public partial class Main : Node2D
{
	[Export]
	public AudioStreamPlayer Sounds { get; set; }

	[Export]
	public TextureRect StartTexture { get; set; }

	[Export(PropertyHint.FilePath)]
	public string GameScenePath { get; set; }

	public override void _Ready()
	{
		InitStartTexture();
	}

	private void InitStartTexture()
	{
		Tools.SetTexture(StartTexture,"start_texture");
	}

	void _on_box_container_mouse_entered()
	{
		Sounds.Play();
	}

	void _on_exit_mouse_entered()
	{
		Sounds.Play();
	}

	// 开始游戏
	void _on_game_start_pressed()
	{
		Global.intptr = 0;
		GetTree().ChangeSceneToFile(GameScenePath);
	}

	// 读取字典
	void _on_dictionary_pressed()
	{
		/*
		Global.intptr = 0;
		GetTree().ChangeSceneToFile("res://scene/game.tscn");
		*/
	}

	void _on_exit_pressed()
	{
		GetTree().Quit();
	}
}
