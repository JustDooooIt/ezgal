using Godot;
using System;

public partial class Start : Label
{
	Tween tween;

	[Export]
	public ColorRect Menu { get; set; }

	// 点击任意键开始游戏.
	public override void _Input(InputEvent @event)
	{
		if (@event is InputEventKey keyEvent)
		{
			if (keyEvent.Pressed)
			{
				InputKey();
			}
		}
		else if (@event is InputEventMouseButton mouseButtonEvent)
		{
			if (mouseButtonEvent.Pressed)
			{
				InputKey();
			}
		}
	}

	// 开始游戏的动画.
	private void InputKey()
	{
		//Hide();
		tween = Menu.CreateTween();
		tween.TweenProperty(Menu, "position", new Vector2(0, 0), 0.6f);
		ProcessMode = Node.ProcessModeEnum.Disabled;
	}
}
