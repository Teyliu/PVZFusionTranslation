using System;
using System.Collections.Generic;
using com.cyborgAssets.inspectorButtonPro;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000A1B RID: 2587
[Token(Token = "0x2000A1B")]
public class TalentLayout : MonoBehaviour
{
	// Token: 0x0600352A RID: 13610 RVA: 0x0011A248 File Offset: 0x00118448
	[Token(Token = "0x600352A")]
	[Address(RVA = "0x7829C0", Offset = "0x780FC0", VA = "0x1807829C0")]
	[ProButton]
	public void LoadData()
	{
		int num2;
		do
		{
			GameAPP.resourcesManager = new ResourcesManager();
			List<TalentNode> list = this.talentNodes;
			int num = 0;
			bool flag;
			if (flag)
			{
				string text = string.Format("node_{0}", flag);
				string text2 = string.Format("{0}", text);
			}
			if (num != 0)
			{
				goto IL_008E;
			}
			num2 = 0;
			List<TalentData> talentDatas = JsonUtility.FromJson<TalentDatas>(Resources.Load<TextAsset>("Talent/TalentData").text).talentDatas;
			bool flag2;
			if (flag2)
			{
				bool flag3;
				if (flag3)
				{
				}
				if (num2 != 0)
				{
					goto IL_0094;
				}
			}
		}
		while (num2 != 0);
		GameAPP.resourcesManager = 0;
		return;
		IL_008E:
		throw new NullReferenceException();
		IL_0094:
		throw new NullReferenceException();
	}

	// Token: 0x0600352B RID: 13611 RVA: 0x0011A2F0 File Offset: 0x001184F0
	[Token(Token = "0x600352B")]
	[Address(RVA = "0x782E90", Offset = "0x781490", VA = "0x180782E90")]
	public TalentLayout()
	{
		List<TalentNode> list = new List();
		this.talentNodes = list;
		base..ctor();
	}

	// Token: 0x04002682 RID: 9858
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002682")]
	public List<TalentNode> talentNodes;

	// Token: 0x04002683 RID: 9859
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002683")]
	public GameObject nodePrefab;

	// Token: 0x04002684 RID: 9860
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4002684")]
	public RectTransform nodeContainer;

	// Token: 0x04002685 RID: 9861
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4002685")]
	public GameObject linePrefab;

	// Token: 0x04002686 RID: 9862
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4002686")]
	public RectTransform lineContainer;
}
