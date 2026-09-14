using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x020007DF RID: 2015
[Token(Token = "0x20007DF")]
public class AdvantureStarMenu : BaseMenu
{
	// Token: 0x0600290B RID: 10507 RVA: 0x000DF6A4 File Offset: 0x000DD8A4
	[Token(Token = "0x600290B")]
	[Address(RVA = "0x61E920", Offset = "0x61CF20", VA = "0x18061E920", Slot = "6")]
	protected override void Awake()
	{
		base.GetCol();
		Animator component = base.GetComponent<Animator>();
		this.anim = component;
		AdvantureStarMenu.Instance = this;
	}

	// Token: 0x0600290C RID: 10508 RVA: 0x000DF6CC File Offset: 0x000DD8CC
	[Token(Token = "0x600290C")]
	[Address(RVA = "0x61F0F0", Offset = "0x61D6F0", VA = "0x18061F0F0")]
	private void Start()
	{
		this.GetNodes();
		this.InitTalents();
		this.UpdateStarText();
	}

	// Token: 0x0600290D RID: 10509 RVA: 0x000DF6EC File Offset: 0x000DD8EC
	[Token(Token = "0x600290D")]
	[Address(RVA = "0x61F120", Offset = "0x61D720", VA = "0x18061F120")]
	public void UpdateStarText()
	{
		TextMeshProUGUI textMeshProUGUI = this.restStar;
		int num = AdvantureConfig.data.RestStar;
		string text2;
		string text = "：" + text2;
		textMeshProUGUI.text = text;
	}

	// Token: 0x0600290E RID: 10510 RVA: 0x000DF728 File Offset: 0x000DD928
	[Token(Token = "0x600290E")]
	[Address(RVA = "0x61F020", Offset = "0x61D620", VA = "0x18061F020")]
	public void ResetAward()
	{
		AdvantureConfig.data.talents._size = (int)((ulong)0L);
		AdvantureConfig.data._talents.Clear();
		this.InitTalents();
		this.UpdateStarText();
	}

	// Token: 0x0600290F RID: 10511 RVA: 0x000DF768 File Offset: 0x000DD968
	[Token(Token = "0x600290F")]
	[Address(RVA = "0x61E9D0", Offset = "0x61CFD0", VA = "0x18061E9D0")]
	private void GetNodes()
	{
		int num2;
		do
		{
			int num = 0;
			List<GameObject> childs = global::Core.Lawnf.GetChilds(this.talents);
			bool flag;
			if (flag)
			{
				bool flag2;
				while (!flag2)
				{
				}
				List<TalentNode> list = this.talentNodes;
			}
			if (num != 0)
			{
				goto IL_0074;
			}
			num2 = 0;
			AdvantureStarMenu.talentDatas = JsonUtility.FromJson<TalentDatas>(Resources.Load<TextAsset>("Talent/TalentData").text).talentDatas;
			List<TalentData> list2 = AdvantureStarMenu.talentDatas;
			bool flag3;
			if (flag3)
			{
				bool flag4;
				if (flag4)
				{
				}
				if (num2 != 0)
				{
					goto IL_007A;
				}
			}
		}
		while (num2 != 0);
		return;
		IL_0074:
		throw new NullReferenceException();
		IL_007A:
		throw new NullReferenceException();
	}

	// Token: 0x06002910 RID: 10512 RVA: 0x000DF7F8 File Offset: 0x000DD9F8
	[Token(Token = "0x6002910")]
	[Address(RVA = "0x61EE50", Offset = "0x61D450", VA = "0x18061EE50")]
	private void InitTalents()
	{
		ulong num2;
		do
		{
			AdvantureData data = AdvantureConfig.data;
			List<TalentNode> list = this.talentNodes;
			bool flag;
			if (flag)
			{
				int num = 0;
				bool flag2 = data.talents.Contains(num);
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x06002911 RID: 10513 RVA: 0x000DF850 File Offset: 0x000DDA50
	[Token(Token = "0x6002911")]
	[Address(RVA = "0x61F1E0", Offset = "0x61D7E0", VA = "0x18061F1E0")]
	public AdvantureStarMenu()
	{
		List<TalentNode> list = new List();
		this.talentNodes = list;
		base..ctor();
	}

	// Token: 0x0400174D RID: 5965
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400174D")]
	public RectTransform talents;

	// Token: 0x0400174E RID: 5966
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400174E")]
	public TextMeshProUGUI restStar;

	// Token: 0x0400174F RID: 5967
	[Token(Token = "0x400174F")]
	public static AdvantureStarMenu Instance;

	// Token: 0x04001750 RID: 5968
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001750")]
	private readonly List<TalentNode> talentNodes;

	// Token: 0x04001751 RID: 5969
	[Token(Token = "0x4001751")]
	public static List<TalentData> talentDatas;
}
