using Godot;
using System;

public partial class Option : Button
{
    Game game;
    Options options;
    public string set_option;

    public override void _Ready()
	{
        options = GetNode<Options>("../../options");
        game = GetNode<Game>("../../../game");
	}

    private void _on_pressed()
    {
        game.Datas[Global.intptr + 1] = Global.SetBracesFunc2(set_option);
        Global.intptr++;
        options.Hide();
        game.Run();
    }
}
