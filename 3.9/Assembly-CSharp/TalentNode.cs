using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x02000A1C RID: 2588
[Token(Token = "0x2000A1C")]
public class TalentNode : TheButton
{
	// Token: 0x1700025E RID: 606
	// (get) Token: 0x0600352C RID: 13612 RVA: 0x0011A310 File Offset: 0x00118510
	[Token(Token = "0x1700025E")]
	public TalentType TalentType
	{
		[Token(Token = "0x600352C")]
		[Address(RVA = "0x784160", Offset = "0x782760", VA = "0x180784160")]
		get
		{
			int num = this.id;
			return TalentType.梦的开始;
		}
	}

	// Token: 0x0600352D RID: 13613 RVA: 0x0011A330 File Offset: 0x00118530
	[Token(Token = "0x600352D")]
	[Address(RVA = "0x782F10", Offset = "0x781510", VA = "0x180782F10")]
	private void Awake()
	{
		TextMeshProUGUI component = base.transform.Find("Name").GetComponent<TextMeshProUGUI>();
		this.nametextMesh = component;
		Image component2 = base.transform.Find("Icon").GetComponent<Image>();
		this.icon = component2;
		Image component3 = base.transform.Find("lock").GetComponent<Image>();
		this._lock = component3;
		GameObject gameObject = base.transform.Find("Trophy").gameObject;
		this.trophy = gameObject;
	}

	// Token: 0x0600352E RID: 13614 RVA: 0x0011A3E4 File Offset: 0x001185E4
	[Token(Token = "0x600352E")]
	[Address(RVA = "0x7837E0", Offset = "0x781DE0", VA = "0x1807837E0")]
	public void Init()
	{
		TalentData talentData = this.data;
		TextMeshProUGUI textMeshProUGUI = this.nametextMesh;
		throw new NullReferenceException();
	}

	// Token: 0x0600352F RID: 13615 RVA: 0x0011A404 File Offset: 0x00118604
	[Token(Token = "0x600352F")]
	[Address(RVA = "0x783820", Offset = "0x781E20", VA = "0x180783820")]
	public void Lock()
	{
		Image image = this.icon;
		int num = 0;
		image.enabled = num != 0;
		this._lock.enabled = true;
		this.locked = true;
	}

	// Token: 0x06003530 RID: 13616 RVA: 0x0011A43C File Offset: 0x0011863C
	[Token(Token = "0x6003530")]
	[Address(RVA = "0x783320", Offset = "0x781920", VA = "0x180783320")]
	public void CheckLock()
	{
		for (;;)
		{
			TalentNode talentNode = this.requireTalents;
			int num = 0;
			if (talentNode != num)
			{
				AdvantureData advantureData = AdvantureConfig.data;
				TalentNode talentNode2 = this.requireTalents;
				List<TalentType> talents = advantureData.talents;
				bool flag;
				if (!flag)
				{
					break;
				}
			}
			if (this.data.needLevel == AdvantureLevel.Default)
			{
				goto IL_0093;
			}
			AdvantureData advantureData2 = AdvantureConfig.data;
			TalentData talentData = this.data;
			List<AdvantureLevel> levelCompleted = advantureData2.levelCompleted;
			AdvantureLevel needLevel = talentData.needLevel;
			if (levelCompleted.Contains(needLevel))
			{
				goto IL_0093;
			}
		}
		Image image = this.icon;
		int num2 = 0;
		image.enabled = num2 != 0;
		this._lock.enabled = true;
		this.locked = true;
		return;
		IL_0093:
		this.icon.enabled = true;
		Image @lock = this._lock;
		int num3 = 0;
		@lock.enabled = num3 != 0;
		this.locked = false;
	}

	// Token: 0x06003531 RID: 13617 RVA: 0x0011A50C File Offset: 0x0011870C
	[Token(Token = "0x6003531")]
	[Address(RVA = "0x783870", Offset = "0x781E70", VA = "0x180783870", Slot = "11")]
	public override void OnPointerDown(PointerEventData eventData)
	{
		for (;;)
		{
			base.OnPointerDown(eventData);
			if (this.locked)
			{
				goto IL_00EF;
			}
			if (eventData.<button>k__BackingField == PointerEventData.InputButton.Right && this.id != 0)
			{
				break;
			}
			List<TalentType> talents = AdvantureConfig.data.talents;
			bool flag;
			if (flag)
			{
				goto IL_00D3;
			}
			int restStar = AdvantureConfig.data.RestStar;
			TalentData talentData = this.data;
			AdvantureData advantureData = AdvantureConfig.data;
			this.trophy.SetActive(true);
			GameAPP.PlaySound(125, 0.5f, 1f);
			AdvantureStarMenu.Instance.UpdateStarText();
			List<TalentNode> list = this.childTalents;
			bool flag2;
			if (flag2)
			{
			}
			ulong num;
			if (num == (ulong)0L)
			{
				goto IL_00D3;
			}
		}
		List<TalentNode> list2 = this.childTalents;
		List<TalentNode> allChildNodes = this.GetAllChildNodes(list2);
		bool flag3;
		if (flag3)
		{
			AdvantureData advantureData2 = AdvantureConfig.data;
		}
		ulong num2;
		if (num2 == (ulong)0L)
		{
			AdvantureData advantureData3 = AdvantureConfig.data;
			AdvantureStarMenu.Instance.UpdateStarText();
			return;
		}
		throw new NullReferenceException();
		IL_00D3:
		GameAPP.PlaySound(26, 0.5f, 1f);
		InGameText instance = InGameText.Instance;
		return;
		IL_00EF:
		GameAPP.PlaySound(26, 0.5f, 1f);
	}

	// Token: 0x06003532 RID: 13618 RVA: 0x0011A640 File Offset: 0x00118840
	[Token(Token = "0x6003532")]
	[Address(RVA = "0x783E40", Offset = "0x782440", VA = "0x180783E40", Slot = "9")]
	public override void OnPointerEnter(PointerEventData eventData)
	{
		base.OnPointerEnter(eventData);
		string description = this.data.description;
		if (this.data.cost != 0)
		{
			AdvantureData advantureData = AdvantureConfig.data;
			List<TalentType> talents = advantureData.talents;
			bool flag;
			if (!flag)
			{
				int restStar = advantureData.RestStar;
				TalentData talentData = this.data;
				if (!this.locked)
				{
					int cost = talentData.cost;
				}
				int cost2 = talentData.cost;
				string text = string.Format("\n<color=red>价格：{0}</color>", restStar);
				string text2 = description + text;
				TalentData talentData2 = this.data;
				if (talentData2.needLevel != AdvantureLevel.Default)
				{
					List<AdvantureLevel> levelCompleted = advantureData.levelCompleted;
					AdvantureLevel needLevel = talentData2.needLevel;
					if (!levelCompleted.Contains(needLevel))
					{
						AdvantureLevel needLevel2 = this.data.needLevel;
						string text3 = string.Format("\n<color=red>需要完成前置关卡：{0}</color>", needLevel2);
						string text4 = text2 + text3;
					}
				}
			}
		}
		InGameText instance = InGameText.Instance;
	}

	// Token: 0x06003533 RID: 13619 RVA: 0x0011A730 File Offset: 0x00118930
	[Token(Token = "0x6003533")]
	[Address(RVA = "0x7840B0", Offset = "0x7826B0", VA = "0x1807840B0", Slot = "10")]
	public override void OnPointerExit(PointerEventData eventData)
	{
		base.OnPointerExit(eventData);
		InGameText.Instance.TimeOver();
	}

	// Token: 0x06003534 RID: 13620 RVA: 0x0011A758 File Offset: 0x00118958
	[Token(Token = "0x6003534")]
	[Address(RVA = "0x761A00", Offset = "0x760000", VA = "0x180761A00")]
	private void OnDestroy()
	{
		InGameText.Instance.TimeOver();
	}

	// Token: 0x06003535 RID: 13621 RVA: 0x0011A778 File Offset: 0x00118978
	[Token(Token = "0x6003535")]
	[Address(RVA = "0x783500", Offset = "0x781B00", VA = "0x180783500")]
	private List<TalentNode> GetAllChildNodes(IEnumerable<TalentNode> childTalents)
	{
		List<TalentNode> list;
		for (;;)
		{
			int num = 0;
			list = new List();
			Stack<TalentNode> stack = new Stack(childTalents);
			TalentNode talentNode = stack.Pop();
			int size = list._size;
			list._size = talentNode;
			talentNode.theEvent = talentNode;
			while (talentNode.childTalents == (ulong)0L)
			{
			}
			if (Enumerable.Any<TalentNode>(talentNode.childTalents))
			{
				List<TalentNode> list2 = talentNode.childTalents;
				bool flag;
				if (flag)
				{
					stack.Push(num);
				}
				ulong num2;
				if (num2 == (ulong)0L)
				{
					break;
				}
			}
		}
		return list;
	}

	// Token: 0x06003536 RID: 13622 RVA: 0x0011A800 File Offset: 0x00118A00
	[Token(Token = "0x6003536")]
	[Address(RVA = "0x7830E0", Offset = "0x7816E0", VA = "0x1807830E0")]
	public void ChangeCardSprite(PlantType thePlantType)
	{
		RectTransform component = this.icon.GetComponent<RectTransform>();
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
		Vector2 sizeDelta = component.sizeDelta;
		int num = 0;
		Vector2 sizeDelta2 = component.sizeDelta;
		component.sizeDelta = num;
	}

	// Token: 0x06003537 RID: 13623 RVA: 0x0011A870 File Offset: 0x00118A70
	[Token(Token = "0x6003537")]
	[Address(RVA = "0x7840E0", Offset = "0x7826E0", VA = "0x1807840E0")]
	public TalentNode()
	{
		List<TalentNode> list = new List();
		this.childTalents = list;
		base..ctor();
	}

	// Token: 0x04002687 RID: 9863
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4002687")]
	public TalentData data;

	// Token: 0x04002688 RID: 9864
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4002688")]
	public TextMeshProUGUI nametextMesh;

	// Token: 0x04002689 RID: 9865
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4002689")]
	public Image icon;

	// Token: 0x0400268A RID: 9866
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x400268A")]
	public Image _lock;

	// Token: 0x0400268B RID: 9867
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x400268B")]
	public GameObject trophy;

	// Token: 0x0400268C RID: 9868
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400268C")]
	public bool locked;

	// Token: 0x0400268D RID: 9869
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400268D")]
	[Header("编辑器")]
	public TalentLayout talentLayout;

	// Token: 0x0400268E RID: 9870
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400268E")]
	public GameObject parentLine;

	// Token: 0x0400268F RID: 9871
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x400268F")]
	public TalentNode requireTalents;

	// Token: 0x04002690 RID: 9872
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4002690")]
	public List<TalentNode> childTalents;

	// Token: 0x04002691 RID: 9873
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4002691")]
	public int layer;

	// Token: 0x04002692 RID: 9874
	[FieldOffset(Offset = "0xBC")]
	[Token(Token = "0x4002692")]
	public int id;
}
