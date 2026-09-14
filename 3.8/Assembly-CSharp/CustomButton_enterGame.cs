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

// Token: 0x0200080A RID: 2058
[Token(Token = "0x200080A")]
public class CustomButton_enterGame : TheButton
{
	// Token: 0x060029F8 RID: 10744 RVA: 0x000E57C0 File Offset: 0x000E39C0
	[Token(Token = "0x60029F8")]
	[Address(RVA = "0x6398B0", Offset = "0x637EB0", VA = "0x1806398B0")]
	public void SetOnlineLevelInfo(OnlineLevelInfo levelInfo)
	{
		this.onlineLevelInfo = levelInfo;
		this.isOnlineLevel = true;
	}

	// Token: 0x060029F9 RID: 10745 RVA: 0x000E57DC File Offset: 0x000E39DC
	[Token(Token = "0x60029F9")]
	[Address(RVA = "0x6397E0", Offset = "0x637DE0", VA = "0x1806397E0", Slot = "12")]
	public override void OnPointerClick(PointerEventData eventData)
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x060029FA RID: 10746 RVA: 0x000E5800 File Offset: 0x000E3A00
	[Token(Token = "0x60029FA")]
	[Address(RVA = "0x639600", Offset = "0x637C00", VA = "0x180639600")]
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

	// Token: 0x060029FB RID: 10747 RVA: 0x000E5838 File Offset: 0x000E3A38
	[Token(Token = "0x60029FB")]
	[Address(RVA = "0x6393F0", Offset = "0x6379F0", VA = "0x1806393F0")]
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

	// Token: 0x060029FC RID: 10748 RVA: 0x000E58B4 File Offset: 0x000E3AB4
	[Token(Token = "0x60029FC")]
	[Address(RVA = "0x6031B0", Offset = "0x6017B0", VA = "0x1806031B0")]
	public CustomButton_enterGame()
	{
	}

	// Token: 0x04001837 RID: 6199
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001837")]
	public TextMeshProUGUI levelName;

	// Token: 0x04001838 RID: 6200
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4001838")]
	public GameObject trophy;

	// Token: 0x04001839 RID: 6201
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4001839")]
	public CustomLevelData levelData;

	// Token: 0x0400183A RID: 6202
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400183A")]
	public global::GameLevel.LevelData _levelData;

	// Token: 0x0400183B RID: 6203
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400183B")]
	public SerializedLevelData serializedLevel;

	// Token: 0x0400183C RID: 6204
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400183C")]
	public Image icon;

	// Token: 0x0400183D RID: 6205
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400183D")]
	public bool useOriginalAction;

	// Token: 0x0400183E RID: 6206
	[FieldOffset(Offset = "0x99")]
	[Token(Token = "0x400183E")]
	public bool needCheck;

	// Token: 0x0400183F RID: 6207
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400183F")]
	private OnlineLevelInfo onlineLevelInfo;

	// Token: 0x04001840 RID: 6208
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4001840")]
	private bool isOnlineLevel;
}
