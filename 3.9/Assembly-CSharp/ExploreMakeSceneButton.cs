using System;
using Cpp2IlInjected;
using TMPro;
using UnityEngine.EventSystems;

// Token: 0x020007F7 RID: 2039
[Token(Token = "0x20007F7")]
public class ExploreMakeSceneButton : TheButton
{
	// Token: 0x06002942 RID: 10562 RVA: 0x000DEEBC File Offset: 0x000DD0BC
	[Token(Token = "0x6002942")]
	[Address(RVA = "0x6931D0", Offset = "0x6917D0", VA = "0x1806931D0")]
	private void Start()
	{
		ExploreMakeMenu instance = ExploreMakeMenu.Instance;
		this.menu = instance;
		int num = (int)this.sceneType;
		TextMeshProUGUI textMeshProUGUI = this.sceneText;
		throw new NullReferenceException();
	}

	// Token: 0x06002943 RID: 10563 RVA: 0x000DEEEC File Offset: 0x000DD0EC
	[Token(Token = "0x6002943")]
	[Address(RVA = "0x693090", Offset = "0x691690", VA = "0x180693090", Slot = "11")]
	public override void OnPointerDown(PointerEventData eventData)
	{
		base.OnPointerDown(eventData);
		ExploreMakeSceneButton currentSelectScene = this.menu.currentSelectScene;
		int num = 0;
		if (currentSelectScene != num)
		{
			TextMeshProUGUI textMeshProUGUI = this.menu.currentSelectScene.sceneText;
		}
		this.menu.currentSelectScene = this;
		TextMeshProUGUI textMeshProUGUI2 = this.sceneText;
		LevelData levelData = this.menu.levelData;
		SceneType sceneType = this.sceneType;
		levelData.sceneType = sceneType;
	}

	// Token: 0x06002944 RID: 10564 RVA: 0x000DEF64 File Offset: 0x000DD164
	[Token(Token = "0x6002944")]
	[Address(RVA = "0x67D810", Offset = "0x67BE10", VA = "0x18067D810")]
	public ExploreMakeSceneButton()
	{
		this.grave = true;
		this.clickOffset = (ulong)1065353216L;
		this.clickOffset.y = -1f;
		this._interactable = true;
		base..ctor();
	}

	// Token: 0x04001756 RID: 5974
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001756")]
	public SceneType sceneType;

	// Token: 0x04001757 RID: 5975
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001757")]
	public TextMeshProUGUI sceneText;

	// Token: 0x04001758 RID: 5976
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4001758")]
	private ExploreMakeMenu menu;
}
