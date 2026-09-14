using System;
using System.Collections.Generic;
using com.cyborgAssets.inspectorButtonPro;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020009DF RID: 2527
[Token(Token = "0x20009DF")]
public class TalentLayout : MonoBehaviour
{
	// Token: 0x060033F6 RID: 13302 RVA: 0x001152CC File Offset: 0x001134CC
	[Token(Token = "0x60033F6")]
	[Address(RVA = "0x71D450", Offset = "0x71BA50", VA = "0x18071D450")]
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

	// Token: 0x060033F7 RID: 13303 RVA: 0x00115374 File Offset: 0x00113574
	[Token(Token = "0x60033F7")]
	[Address(RVA = "0x71D920", Offset = "0x71BF20", VA = "0x18071D920")]
	public TalentLayout()
	{
		List<TalentNode> list = new List();
		this.talentNodes = list;
		base..ctor();
	}

	// Token: 0x04002570 RID: 9584
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4002570")]
	public List<TalentNode> talentNodes;

	// Token: 0x04002571 RID: 9585
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4002571")]
	public GameObject nodePrefab;

	// Token: 0x04002572 RID: 9586
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4002572")]
	public RectTransform nodeContainer;

	// Token: 0x04002573 RID: 9587
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4002573")]
	public GameObject linePrefab;

	// Token: 0x04002574 RID: 9588
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4002574")]
	public RectTransform lineContainer;
}
