using System;
using Cpp2IlInjected;
using TMPro;
using UnityEngine.EventSystems;

// Token: 0x020007BE RID: 1982
[Token(Token = "0x20007BE")]
public class ExploreMakeSceneButton : TheButton
{
	// Token: 0x06002813 RID: 10259 RVA: 0x000D9F00 File Offset: 0x000D8100
	[Token(Token = "0x6002813")]
	[Address(RVA = "0x62F420", Offset = "0x62DA20", VA = "0x18062F420")]
	private void Start()
	{
		ExploreMakeMenu instance = ExploreMakeMenu.Instance;
		this.menu = instance;
		int num = (int)this.sceneType;
		TextMeshProUGUI textMeshProUGUI = this.sceneText;
		throw new NullReferenceException();
	}

	// Token: 0x06002814 RID: 10260 RVA: 0x000D9F30 File Offset: 0x000D8130
	[Token(Token = "0x6002814")]
	[Address(RVA = "0x62F2E0", Offset = "0x62D8E0", VA = "0x18062F2E0", Slot = "11")]
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

	// Token: 0x06002815 RID: 10261 RVA: 0x000D9FA8 File Offset: 0x000D81A8
	[Token(Token = "0x6002815")]
	[Address(RVA = "0x619F70", Offset = "0x618570", VA = "0x180619F70")]
	public ExploreMakeSceneButton()
	{
		this.grave = true;
		this.clickOffset = (ulong)1065353216L;
		this.clickOffset.y = -1f;
		this._interactable = true;
		base..ctor();
	}

	// Token: 0x0400167A RID: 5754
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x400167A")]
	public SceneType sceneType;

	// Token: 0x0400167B RID: 5755
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x400167B")]
	public TextMeshProUGUI sceneText;

	// Token: 0x0400167C RID: 5756
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x400167C")]
	private ExploreMakeMenu menu;
}
