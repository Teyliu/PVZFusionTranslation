using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020008C5 RID: 2245
[Token(Token = "0x20008C5")]
public class TravelStoreWindow : BaseWindow
{
	// Token: 0x06002DCC RID: 11724 RVA: 0x000FAB70 File Offset: 0x000F8D70
	[Token(Token = "0x6002DCC")]
	[Address(RVA = "0x702FA0", Offset = "0x7015A0", VA = "0x180702FA0")]
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

	// Token: 0x06002DCD RID: 11725 RVA: 0x000FABA8 File Offset: 0x000F8DA8
	[Token(Token = "0x6002DCD")]
	[Address(RVA = "0x7024B0", Offset = "0x700AB0", VA = "0x1807024B0")]
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

	// Token: 0x06002DCE RID: 11726 RVA: 0x000FADB0 File Offset: 0x000F8FB0
	[Token(Token = "0x6002DCE")]
	[Address(RVA = "0x7021D0", Offset = "0x7007D0", VA = "0x1807021D0")]
	public void Clear()
	{
		this.set = false;
		string empty = string.Empty;
		base.SetDescription(empty);
		global::UnityEngine.Object.Destroy(this.show);
	}

	// Token: 0x06002DCF RID: 11727 RVA: 0x000FADE0 File Offset: 0x000F8FE0
	[Token(Token = "0x6002DCF")]
	[Address(RVA = "0x702290", Offset = "0x700890", VA = "0x180702290")]
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

	// Token: 0x06002DD0 RID: 11728 RVA: 0x000FAEF0 File Offset: 0x000F90F0
	[Token(Token = "0x6002DD0")]
	[Address(RVA = "0x7031D0", Offset = "0x7017D0", VA = "0x1807031D0")]
	public TravelStoreWindow()
	{
		List<TextMeshProUGUI> list = new List();
		this.buttonText = list;
		base..ctor();
	}

	// Token: 0x04001BAB RID: 7083
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4001BAB")]
	public object buff;

	// Token: 0x04001BAC RID: 7084
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x4001BAC")]
	public int cost;

	// Token: 0x04001BAD RID: 7085
	[FieldOffset(Offset = "0xC4")]
	[Token(Token = "0x4001BAD")]
	public bool sold;

	// Token: 0x04001BAE RID: 7086
	[FieldOffset(Offset = "0xC5")]
	[Token(Token = "0x4001BAE")]
	public bool canBuy;

	// Token: 0x04001BAF RID: 7087
	[FieldOffset(Offset = "0xC6")]
	[Token(Token = "0x4001BAF")]
	public bool set;

	// Token: 0x04001BB0 RID: 7088
	[FieldOffset(Offset = "0xC8")]
	[Token(Token = "0x4001BB0")]
	public List<TextMeshProUGUI> buttonText;

	// Token: 0x04001BB1 RID: 7089
	[FieldOffset(Offset = "0xD0")]
	[Token(Token = "0x4001BB1")]
	public Image background;

	// Token: 0x020008C6 RID: 2246
	[Token(Token = "0x20008C6")]
	private enum BgType
	{
		// Token: 0x04001BB3 RID: 7091
		[Token(Token = "0x4001BB3")]
		Day,
		// Token: 0x04001BB4 RID: 7092
		[Token(Token = "0x4001BB4")]
		Night,
		// Token: 0x04001BB5 RID: 7093
		[Token(Token = "0x4001BB5")]
		Pool
	}
}
