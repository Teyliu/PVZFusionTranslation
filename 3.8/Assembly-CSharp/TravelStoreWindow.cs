using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000889 RID: 2185
[Token(Token = "0x2000889")]
public class TravelStoreWindow : BaseWindow
{
	// Token: 0x06002C9A RID: 11418 RVA: 0x000F5FBC File Offset: 0x000F41BC
	[Token(Token = "0x6002C9A")]
	[Address(RVA = "0x689980", Offset = "0x687F80", VA = "0x180689980")]
	public void UpdateButtonText(string text, Color color)
	{
		ulong num;
		do
		{
			List<TextMeshProUGUI> list = this.buttonText;
			bool flag;
			if (flag)
			{
			}
		}
		while (num != (ulong)0L);
	}

	// Token: 0x06002C9B RID: 11419 RVA: 0x000F5FF4 File Offset: 0x000F41F4
	[Token(Token = "0x6002C9B")]
	[Address(RVA = "0x688E90", Offset = "0x687490", VA = "0x180688E90")]
	public void SetType(object buff)
	{
		string text;
		string text4;
		for (;;)
		{
			GameObject show = this.show;
			int num = 0;
			if (show != num)
			{
				global::UnityEngine.Object.Destroy(this.show);
			}
			this.sold = false;
			this.set = true;
			this.buff = buff;
			if (buff != 0)
			{
				if (buff == 0)
				{
					if (buff != 0)
					{
						goto IL_007C;
					}
					if (buff == 0)
					{
						if (buff == 0)
						{
							goto IL_0090;
						}
						Dictionary<TravelDebuff, ValueTuple<string, ZombieType>> debuffData = TravelDictionary.debuffData;
						bool flag;
						if (!flag)
						{
						}
					}
					List<PlantType> allStrongUltimtePlant = TravelDictionary.allStrongUltimtePlant;
					object obj;
					uint num2;
					obj -= num2;
					List<PlantType> allStrongUltimtePlant2 = TravelDictionary.allStrongUltimtePlant;
					bool flag2;
					if (flag2)
					{
						goto IL_007C;
					}
					IL_0085:
					int num3 = 0;
					this.SetBackground((TravelStoreWindow.BgType)num3);
					goto IL_0090;
					IL_007C:
					object obj2;
					PlantType plantTypeByAdvBuff = TravelMgr.GetPlantTypeByAdvBuff(obj2);
					goto IL_0085;
				}
				goto IL_010B;
			}
			IL_0090:
			text = TravelMgr.Instance.GetText(buff);
			if (!TravelMgr.Instance.data.Invest || buff == 0)
			{
				return;
			}
			if (buff == 0)
			{
				break;
			}
			List<PlantType> allStrongUltimtePlant3 = TravelDictionary.allStrongUltimtePlant;
			SynergyManager instance = SynergyManager.Instance;
			bool flag3;
			if (flag3)
			{
				SynergyType synergyType;
				string text2 = string.Format("【{0}】\n", synergyType);
				string text3 = text4 + text2;
			}
			ulong num4;
			if (num4 == (ulong)0L)
			{
				goto Block_16;
			}
		}
		if (buff != 0)
		{
			goto IL_0180;
		}
		if (buff == 0)
		{
			return;
		}
		object obj3;
		PlantType plantTypeFromBuff = TravelHelper.GetPlantTypeFromBuff(obj3);
		SynergyManager instance2 = SynergyManager.Instance;
		bool flag4;
		if (!flag4)
		{
			goto IL_0179;
		}
		SynergyType synergyType2;
		string text5 = string.Format("【{0}】\n", synergyType2);
		string text6 = "\n<color=red>" + text5;
		IL_010B:
		List<PlantType> allStrongUltimtePlant4 = TravelDictionary.allStrongUltimtePlant;
		bool flag5;
		while (!flag5)
		{
		}
		Image image = this.background;
		int num5 = 0;
		image.enabled = num5 != 0;
		Transform transform = this.background.transform;
		int num6 = 0;
		GameObject gameObject = transform.GetChild(num6).gameObject;
		int num7 = 0;
		gameObject.SetActive(num7 != 0);
		uint num8;
		ulong num9;
		this.background.transform.GetChild((int)num8).gameObject.SetActive(num9 != 0UL);
		IL_0179:
		ulong num10;
		if (num10 != (ulong)0L)
		{
			goto IL_01F4;
		}
		IL_0180:
		SynergyManager instance3 = SynergyManager.Instance;
		bool flag6;
		if (flag6)
		{
			SynergyType synergyType3;
			string text7 = string.Format("【{0}】\n", synergyType3);
		}
		ulong num11;
		if (num11 != (ulong)0L)
		{
			goto IL_01F4;
		}
		string text8 = text + text4 + "</color>";
		return;
		Block_16:
		throw new NullReferenceException();
		IL_01F4:
		throw new InvalidCastException();
	}

	// Token: 0x06002C9C RID: 11420 RVA: 0x000F61FC File Offset: 0x000F43FC
	[Token(Token = "0x6002C9C")]
	[Address(RVA = "0x688BB0", Offset = "0x6871B0", VA = "0x180688BB0")]
	public void Clear()
	{
		this.set = false;
		string empty = string.Empty;
		base.SetDescription(empty);
		global::UnityEngine.Object.Destroy(this.show);
	}

	// Token: 0x06002C9D RID: 11421 RVA: 0x000F622C File Offset: 0x000F442C
	[Token(Token = "0x6002C9D")]
	[Address(RVA = "0x688C70", Offset = "0x687270", VA = "0x180688C70")]
	private void SetBackground(TravelStoreWindow.BgType bgType)
	{
		if (bgType != TravelStoreWindow.BgType.Day)
		{
			if (bgType != TravelStoreWindow.BgType.Day)
			{
				if (bgType == TravelStoreWindow.BgType.Night)
				{
					Image image = this.background;
					int num = 0;
					image.enabled = num != 0;
					Transform transform = this.background.transform;
					int num2 = 0;
					GameObject gameObject = transform.GetChild(num2).gameObject;
					int num3 = 0;
					gameObject.SetActive(num3 != 0);
					uint num4;
					ulong num5;
					this.background.transform.GetChild((int)num4).gameObject.SetActive(num5 != 0UL);
					return;
				}
				return;
			}
			else
			{
				Image image2 = this.background;
				int num6 = 0;
				image2.enabled = num6 != 0;
				Transform transform2 = this.background.transform;
				int num7 = 0;
				GameObject gameObject2 = transform2.GetChild(num7).gameObject;
			}
		}
		ulong num8;
		this.background.enabled = num8 != 0UL;
		Transform transform3 = this.background.transform;
		int num9 = 0;
		GameObject gameObject3 = transform3.GetChild(num9).gameObject;
		int num10 = 0;
		gameObject3.SetActive(num10 != 0);
		uint num11;
		GameObject gameObject4 = this.background.transform.GetChild((int)num11).gameObject;
		int num12 = 0;
		gameObject4.SetActive(num12 != 0);
	}

	// Token: 0x06002C9E RID: 11422 RVA: 0x000F633C File Offset: 0x000F453C
	[Token(Token = "0x6002C9E")]
	[Address(RVA = "0x689BB0", Offset = "0x6881B0", VA = "0x180689BB0")]
	public TravelStoreWindow()
	{
		List<TextMeshProUGUI> list = new List();
		this.buttonText = list;
		base..ctor();
	}

	// Token: 0x04001ABD RID: 6845
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4001ABD")]
	public object buff;

	// Token: 0x04001ABE RID: 6846
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4001ABE")]
	public int cost;

	// Token: 0x04001ABF RID: 6847
	[FieldOffset(Offset = "0xBC")]
	[Token(Token = "0x4001ABF")]
	public bool sold;

	// Token: 0x04001AC0 RID: 6848
	[FieldOffset(Offset = "0xBD")]
	[Token(Token = "0x4001AC0")]
	public bool canBuy;

	// Token: 0x04001AC1 RID: 6849
	[FieldOffset(Offset = "0xBE")]
	[Token(Token = "0x4001AC1")]
	public bool set;

	// Token: 0x04001AC2 RID: 6850
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4001AC2")]
	public List<TextMeshProUGUI> buttonText;

	// Token: 0x04001AC3 RID: 6851
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4001AC3")]
	public Image background;

	// Token: 0x0200088A RID: 2186
	[Token(Token = "0x200088A")]
	private enum BgType
	{
		// Token: 0x04001AC5 RID: 6853
		[Token(Token = "0x4001AC5")]
		Day,
		// Token: 0x04001AC6 RID: 6854
		[Token(Token = "0x4001AC6")]
		Night,
		// Token: 0x04001AC7 RID: 6855
		[Token(Token = "0x4001AC7")]
		Pool
	}
}
