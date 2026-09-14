using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x02000880 RID: 2176
[Token(Token = "0x2000880")]
public class SynergyNode : MonoBehaviour
{
	// Token: 0x06002C6F RID: 11375 RVA: 0x000F4818 File Offset: 0x000F2A18
	[Token(Token = "0x6002C6F")]
	[Address(RVA = "0x686090", Offset = "0x684690", VA = "0x180686090")]
	public void InitNode()
	{
		ulong num6;
		do
		{
			int num = 0;
			Dictionary<SynergyType, BaseSynergyData> synergysData = TravelMgr.SynergysData;
			bool flag;
			if (flag)
			{
				TextMeshProUGUI textMeshProUGUI = this.synergyTitle;
				SynergyType synergyType = this.synergyType;
				string text;
				textMeshProUGUI.text = text;
				TextMeshProUGUI textMeshProUGUI2 = this.synergyTitle;
				string text2 = textMeshProUGUI2.text;
				int size = this.plantTypes_unlocked._size;
				short num2;
				string text3 = string.Format("({0}/{1})\n", text2, num2);
				string text4 = text2 + text3;
				textMeshProUGUI2.text = text4;
				int num3 = 0;
				int num4 = 0;
				bool flag2;
				if (flag2)
				{
					int size2 = this.plantTypes_unlocked._size;
					if (num4 == 0)
					{
						TextMeshProUGUI textMeshProUGUI3 = this.synergyTitle;
						string text5 = textMeshProUGUI3.text + "</color>";
						textMeshProUGUI3.text = text5;
					}
					TextMeshProUGUI textMeshProUGUI4 = this.synergyTitle;
					string text6 = textMeshProUGUI4.text;
					short num5;
					string text7 = string.Format("{0}/{1}：\n", text6, num5);
					string text8;
					textMeshProUGUI4.text = text8;
					num3++;
					while (num3 != 0)
					{
					}
					string text9 = this.synergyTitle.text;
				}
				if (num3 != 0)
				{
					continue;
				}
			}
			TextMeshProUGUI textMeshProUGUI5 = this.synergyTitle;
			SynergyType synergyType2 = this.synergyType;
			string text10;
			textMeshProUGUI5.text = text10;
			TextMeshProUGUI textMeshProUGUI6 = this.synergyTitle;
			string text11 = textMeshProUGUI6.text;
			int size3 = this.plantTypes_unlocked._size;
			int size4 = this.plantTypes_all._size;
			string text12 = string.Format("({0}/{1})\n", text11, text11);
			string text13 = text11 + text12;
			textMeshProUGUI6.text = text13;
			List<PlantType> list = this.plantTypes_all;
			bool flag3;
			if (flag3)
			{
				TheCard theCard = this.sampleCard;
				Transform transform = this.cardContainer;
				TheCard theCard2 = global::UnityEngine.Object.Instantiate<TheCard>(theCard, transform);
				theCard2.thePlantType = (PlantType)num;
				GameObject shadow = theCard2.shadow;
				bool flag4 = this.plantTypes_unlocked.Contains(num);
				shadow.SetActive(flag4);
			}
		}
		while (num6 != (ulong)0L);
		GameObject gameObject;
		global::UnityEngine.Object.Destroy(gameObject);
	}

	// Token: 0x06002C70 RID: 11376 RVA: 0x000F4A14 File Offset: 0x000F2C14
	[Token(Token = "0x6002C70")]
	[Address(RVA = "0x686880", Offset = "0x684E80", VA = "0x180686880")]
	public SynergyNode()
	{
		List<PlantType> list = new List();
		this.plantTypes_unlocked = list;
		List<PlantType> list2 = new List();
		this.plantTypes_all = list2;
		base..ctor();
	}

	// Token: 0x04001A8A RID: 6794
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001A8A")]
	public SynergyType synergyType;

	// Token: 0x04001A8B RID: 6795
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001A8B")]
	public List<PlantType> plantTypes_unlocked;

	// Token: 0x04001A8C RID: 6796
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001A8C")]
	public List<PlantType> plantTypes_all;

	// Token: 0x04001A8D RID: 6797
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001A8D")]
	public TextMeshProUGUI synergyTitle;

	// Token: 0x04001A8E RID: 6798
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001A8E")]
	public TheCard sampleCard;

	// Token: 0x04001A8F RID: 6799
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001A8F")]
	public Transform cardContainer;
}
