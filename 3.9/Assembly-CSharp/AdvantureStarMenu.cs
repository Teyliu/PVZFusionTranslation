using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x02000818 RID: 2072
[Token(Token = "0x2000818")]
public class AdvantureStarMenu : BaseMenu
{
	// Token: 0x06002A3A RID: 10810 RVA: 0x000E4630 File Offset: 0x000E2830
	[Token(Token = "0x6002A3A")]
	[Address(RVA = "0x682210", Offset = "0x680810", VA = "0x180682210", Slot = "6")]
	protected override void Awake()
	{
		base.GetCol();
		Animator component = base.GetComponent<Animator>();
		this.anim = component;
		AdvantureStarMenu.Instance = this;
	}

	// Token: 0x06002A3B RID: 10811 RVA: 0x000E4658 File Offset: 0x000E2858
	[Token(Token = "0x6002A3B")]
	[Address(RVA = "0x6829E0", Offset = "0x680FE0", VA = "0x1806829E0")]
	private void Start()
	{
		this.GetNodes();
		this.InitTalents();
		this.UpdateStarText();
	}

	// Token: 0x06002A3C RID: 10812 RVA: 0x000E4678 File Offset: 0x000E2878
	[Token(Token = "0x6002A3C")]
	[Address(RVA = "0x682A10", Offset = "0x681010", VA = "0x180682A10")]
	public void UpdateStarText()
	{
		TextMeshProUGUI textMeshProUGUI = this.restStar;
		int num = AdvantureConfig.data.RestStar;
		string text2;
		string text = "：" + text2;
		textMeshProUGUI.text = text;
	}

	// Token: 0x06002A3D RID: 10813 RVA: 0x000E46B4 File Offset: 0x000E28B4
	[Token(Token = "0x6002A3D")]
	[Address(RVA = "0x682910", Offset = "0x680F10", VA = "0x180682910")]
	public void ResetAward()
	{
		AdvantureConfig.data.talents._size = (int)((ulong)0L);
		AdvantureConfig.data._talents.Clear();
		this.InitTalents();
		this.UpdateStarText();
	}

	// Token: 0x06002A3E RID: 10814 RVA: 0x000E46F4 File Offset: 0x000E28F4
	[Token(Token = "0x6002A3E")]
	[Address(RVA = "0x6822C0", Offset = "0x6808C0", VA = "0x1806822C0")]
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

	// Token: 0x06002A3F RID: 10815 RVA: 0x000E4784 File Offset: 0x000E2984
	[Token(Token = "0x6002A3F")]
	[Address(RVA = "0x682740", Offset = "0x680D40", VA = "0x180682740")]
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

	// Token: 0x06002A40 RID: 10816 RVA: 0x000E47DC File Offset: 0x000E29DC
	[Token(Token = "0x6002A40")]
	[Address(RVA = "0x682AD0", Offset = "0x6810D0", VA = "0x180682AD0")]
	public AdvantureStarMenu()
	{
		List<TalentNode> list = new List();
		this.talentNodes = list;
		base..ctor();
	}

	// Token: 0x04001829 RID: 6185
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001829")]
	public RectTransform talents;

	// Token: 0x0400182A RID: 6186
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400182A")]
	public TextMeshProUGUI restStar;

	// Token: 0x0400182B RID: 6187
	[Token(Token = "0x400182B")]
	public static AdvantureStarMenu Instance;

	// Token: 0x0400182C RID: 6188
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400182C")]
	private readonly List<TalentNode> talentNodes;

	// Token: 0x0400182D RID: 6189
	[Token(Token = "0x400182D")]
	public static List<TalentData> talentDatas;
}
