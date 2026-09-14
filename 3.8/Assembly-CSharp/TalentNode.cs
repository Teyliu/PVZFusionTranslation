using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x020009E0 RID: 2528
[Token(Token = "0x20009E0")]
public class TalentNode : TheButton
{
	// Token: 0x17000216 RID: 534
	// (get) Token: 0x060033F8 RID: 13304 RVA: 0x00115394 File Offset: 0x00113594
	[Token(Token = "0x17000216")]
	public TalentType TalentType
	{
		[Token(Token = "0x60033F8")]
		[Address(RVA = "0x71EBE0", Offset = "0x71D1E0", VA = "0x18071EBE0")]
		get
		{
			int num = this.id;
			return TalentType.梦的开始;
		}
	}

	// Token: 0x060033F9 RID: 13305 RVA: 0x001153B4 File Offset: 0x001135B4
	[Token(Token = "0x60033F9")]
	[Address(RVA = "0x71D9A0", Offset = "0x71BFA0", VA = "0x18071D9A0")]
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

	// Token: 0x060033FA RID: 13306 RVA: 0x00115468 File Offset: 0x00113668
	[Token(Token = "0x60033FA")]
	[Address(RVA = "0x71E270", Offset = "0x71C870", VA = "0x18071E270")]
	public void Init()
	{
		TalentData talentData = this.data;
		TextMeshProUGUI textMeshProUGUI = this.nametextMesh;
		throw new NullReferenceException();
	}

	// Token: 0x060033FB RID: 13307 RVA: 0x00115488 File Offset: 0x00113688
	[Token(Token = "0x60033FB")]
	[Address(RVA = "0x71E2B0", Offset = "0x71C8B0", VA = "0x18071E2B0")]
	public void Lock()
	{
		Image image = this.icon;
		int num = 0;
		image.enabled = num != 0;
		this._lock.enabled = true;
		this.locked = true;
	}

	// Token: 0x060033FC RID: 13308 RVA: 0x001154C0 File Offset: 0x001136C0
	[Token(Token = "0x60033FC")]
	[Address(RVA = "0x71DDB0", Offset = "0x71C3B0", VA = "0x18071DDB0")]
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

	// Token: 0x060033FD RID: 13309 RVA: 0x00115590 File Offset: 0x00113790
	[Token(Token = "0x60033FD")]
	[Address(RVA = "0x71E300", Offset = "0x71C900", VA = "0x18071E300", Slot = "11")]
	public override void OnPointerDown(PointerEventData eventData)
	{
		for (;;)
		{
			base.OnPointerDown(eventData);
			if (this.locked)
			{
				goto IL_0105;
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
		int num3 = 0;
		instance.ShowText("您已获取该奖励", 3f, num3 != 0);
		return;
		IL_0105:
		GameAPP.PlaySound(26, 0.5f, 1f);
	}

	// Token: 0x060033FE RID: 13310 RVA: 0x001156D8 File Offset: 0x001138D8
	[Token(Token = "0x60033FE")]
	[Address(RVA = "0x71E8D0", Offset = "0x71CED0", VA = "0x18071E8D0", Slot = "9")]
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
		int num = 0;
		instance.ShowText(description, 300f, num != 0);
	}

	// Token: 0x060033FF RID: 13311 RVA: 0x001157D8 File Offset: 0x001139D8
	[Token(Token = "0x60033FF")]
	[Address(RVA = "0x71EB30", Offset = "0x71D130", VA = "0x18071EB30", Slot = "10")]
	public override void OnPointerExit(PointerEventData eventData)
	{
		base.OnPointerExit(eventData);
		InGameText.Instance.TimeOver();
	}

	// Token: 0x06003400 RID: 13312 RVA: 0x00115800 File Offset: 0x00113A00
	[Token(Token = "0x6003400")]
	[Address(RVA = "0x6FC660", Offset = "0x6FAC60", VA = "0x1806FC660")]
	private void OnDestroy()
	{
		InGameText.Instance.TimeOver();
	}

	// Token: 0x06003401 RID: 13313 RVA: 0x00115820 File Offset: 0x00113A20
	[Token(Token = "0x6003401")]
	[Address(RVA = "0x71DF90", Offset = "0x71C590", VA = "0x18071DF90")]
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

	// Token: 0x06003402 RID: 13314 RVA: 0x001158A8 File Offset: 0x00113AA8
	[Token(Token = "0x6003402")]
	[Address(RVA = "0x71DB70", Offset = "0x71C170", VA = "0x18071DB70")]
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

	// Token: 0x06003403 RID: 13315 RVA: 0x00115918 File Offset: 0x00113B18
	[Token(Token = "0x6003403")]
	[Address(RVA = "0x71EB60", Offset = "0x71D160", VA = "0x18071EB60")]
	public TalentNode()
	{
		List<TalentNode> list = new List();
		this.childTalents = list;
		base..ctor();
	}

	// Token: 0x04002575 RID: 9589
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4002575")]
	public TalentData data;

	// Token: 0x04002576 RID: 9590
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x4002576")]
	public TextMeshProUGUI nametextMesh;

	// Token: 0x04002577 RID: 9591
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4002577")]
	public Image icon;

	// Token: 0x04002578 RID: 9592
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4002578")]
	public Image _lock;

	// Token: 0x04002579 RID: 9593
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4002579")]
	public GameObject trophy;

	// Token: 0x0400257A RID: 9594
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x400257A")]
	public bool locked;

	// Token: 0x0400257B RID: 9595
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x400257B")]
	[Header("编辑器")]
	public TalentLayout talentLayout;

	// Token: 0x0400257C RID: 9596
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x400257C")]
	public GameObject parentLine;

	// Token: 0x0400257D RID: 9597
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x400257D")]
	public TalentNode requireTalents;

	// Token: 0x0400257E RID: 9598
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x400257E")]
	public List<TalentNode> childTalents;

	// Token: 0x0400257F RID: 9599
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x400257F")]
	public int layer;

	// Token: 0x04002580 RID: 9600
	[FieldOffset(Offset = "0xBC")]
	[Token(Token = "0x4002580")]
	public int id;
}
