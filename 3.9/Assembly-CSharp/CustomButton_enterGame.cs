using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Cysharp.Threading.Tasks;
using GameLevel;
using GameLevel.OnLine;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x02000848 RID: 2120
[Token(Token = "0x2000848")]
public class CustomButton_enterGame : TheButton
{
	// Token: 0x06002B36 RID: 11062 RVA: 0x000EAB24 File Offset: 0x000E8D24
	[Token(Token = "0x6002B36")]
	[Address(RVA = "0x69DE20", Offset = "0x69C420", VA = "0x18069DE20")]
	public void SetOnlineLevelInfo(OnlineLevelInfo levelInfo)
	{
		this.onlineLevelInfo = levelInfo;
		this.isOnlineLevel = true;
	}

	// Token: 0x06002B37 RID: 11063 RVA: 0x000EAB40 File Offset: 0x000E8D40
	[Token(Token = "0x6002B37")]
	[Address(RVA = "0x69DD50", Offset = "0x69C350", VA = "0x18069DD50", Slot = "12")]
	public override void OnPointerClick(PointerEventData eventData)
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06002B38 RID: 11064 RVA: 0x000EAB64 File Offset: 0x000E8D64
	[Token(Token = "0x6002B38")]
	[Address(RVA = "0x69DB70", Offset = "0x69C170", VA = "0x18069DB70")]
	private UniTask LoadOnlineLevelAsync(bool user)
	{
		int num = 0;
		int num2 = 0;
		if (num == 0)
		{
		}
		if (num2 < typeof(UniTask).TypeHandle)
		{
			num2 += num2;
			num2++;
		}
		num2 += num2;
		return default(UniTask);
	}

	// Token: 0x06002B39 RID: 11065 RVA: 0x000EAB9C File Offset: 0x000E8D9C
	[Token(Token = "0x6002B39")]
	[Address(RVA = "0x69D960", Offset = "0x69BF60", VA = "0x18069D960")]
	public void Init(string name, PlantType icon)
	{
		this.levelName.text = name;
		RectTransform rectTransform = this.icon.rectTransform;
		Dictionary<PlantType, GameObject> plantPreviews = GameAPP.resourcesManager.plantPreviews;
		bool flag;
		if (flag)
		{
			Image image = this.icon;
			SpriteRenderer spriteRenderer;
			Sprite sprite = spriteRenderer.sprite;
			image.sprite = sprite;
		}
		this.icon.SetNativeSize();
		Vector2 sizeDelta = rectTransform.sizeDelta;
		int num = 0;
		Vector2 sizeDelta2 = rectTransform.sizeDelta;
		rectTransform.sizeDelta = num;
	}

	// Token: 0x06002B3A RID: 11066 RVA: 0x000EAC18 File Offset: 0x000E8E18
	[Token(Token = "0x6002B3A")]
	[Address(RVA = "0x6669C0", Offset = "0x664FC0", VA = "0x1806669C0")]
	public CustomButton_enterGame()
	{
	}

	// Token: 0x04001933 RID: 6451
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001933")]
	public TextMeshProUGUI levelName;

	// Token: 0x04001934 RID: 6452
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001934")]
	public GameObject trophy;

	// Token: 0x04001935 RID: 6453
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4001935")]
	public CustomLevelData levelData;

	// Token: 0x04001936 RID: 6454
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4001936")]
	public global::GameLevel.LevelData _levelData;

	// Token: 0x04001937 RID: 6455
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4001937")]
	public SerializedLevelData serializedLevel;

	// Token: 0x04001938 RID: 6456
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4001938")]
	public Image icon;

	// Token: 0x04001939 RID: 6457
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4001939")]
	public bool useOriginalAction;

	// Token: 0x0400193A RID: 6458
	[FieldOffset(Offset = "0x99")]
	[Token(Token = "0x400193A")]
	public bool needCheck;

	// Token: 0x0400193B RID: 6459
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400193B")]
	private OnlineLevelInfo onlineLevelInfo;

	// Token: 0x0400193C RID: 6460
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x400193C")]
	private bool isOnlineLevel;
}
