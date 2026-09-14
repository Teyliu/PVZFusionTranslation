using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x020008BC RID: 2236
[Token(Token = "0x20008BC")]
public class SynergyNode : MonoBehaviour
{
	// Token: 0x06002DA1 RID: 11681 RVA: 0x000F9498 File Offset: 0x000F7698
	[Token(Token = "0x6002DA1")]
	[Address(RVA = "0x6FF660", Offset = "0x6FDC60", VA = "0x1806FF660")]
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

	// Token: 0x06002DA2 RID: 11682 RVA: 0x000F9694 File Offset: 0x000F7894
	[Token(Token = "0x6002DA2")]
	[Address(RVA = "0x6FFE50", Offset = "0x6FE450", VA = "0x1806FFE50")]
	public SynergyNode()
	{
		List<PlantType> list = new List();
		this.plantTypes_unlocked = list;
		List<PlantType> list2 = new List();
		this.plantTypes_all = list2;
		base..ctor();
	}

	// Token: 0x04001B78 RID: 7032
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001B78")]
	public SynergyType synergyType;

	// Token: 0x04001B79 RID: 7033
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001B79")]
	public List<PlantType> plantTypes_unlocked;

	// Token: 0x04001B7A RID: 7034
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001B7A")]
	public List<PlantType> plantTypes_all;

	// Token: 0x04001B7B RID: 7035
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001B7B")]
	public TextMeshProUGUI synergyTitle;

	// Token: 0x04001B7C RID: 7036
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001B7C")]
	public TheCard sampleCard;

	// Token: 0x04001B7D RID: 7037
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001B7D")]
	public Transform cardContainer;
}
