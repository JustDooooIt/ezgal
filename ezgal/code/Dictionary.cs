using Godot;
using System;

public partial class Dictionary : Control
{
	[Export]
	public RichTextLabel Text { get; set; }
	public Dictionary self;

	public override void _Ready()
	{
		Hide();
	}

	// 隐藏对话框
	public new void Hide()
	{
		Text.Text = "";
		base.Hide();
	}

	// 显示对话框
	public new void Show()
	{
		base.Show();
	}

	public void _on_text_meta_clicked(Variant meta)
	{
		Global.LoadDictionary(self, meta);
	}

	public void _on_button_pressed()
	{
		Hide();
	}
}
