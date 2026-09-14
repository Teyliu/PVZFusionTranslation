using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x02000838 RID: 2104
[Token(Token = "0x2000838")]
public class FruitNinjaSelectWindow : BaseWindow
{
	// Token: 0x06002AE6 RID: 10982 RVA: 0x000EB6AC File Offset: 0x000E98AC
	[Token(Token = "0x6002AE6")]
	[Address(RVA = "0x65B110", Offset = "0x659710", VA = "0x18065B110")]
	public void SetType(FruitBuffType fruitBuffType)
	{
		this.set = true;
		int num = 0;
		this.buffType = fruitBuffType;
		Dictionary<FruitBuffType, ValueTuple<string, int>> buffDescriptions = FruitNinjaManager.Instance.BuffDescriptions;
		bool flag;
		if (flag)
		{
			Type typeFromHandle = typeof(FruitBuffType);
			FruitBuffType fruitBuffType2 = this.buffType;
			string name = Enum.GetName(typeFromHandle, typeFromHandle);
			TextMeshProUGUI introduce = this.introduce;
			string text = name + "：" + num;
			introduce.text = text;
		}
	}

	// Token: 0x06002AE7 RID: 10983 RVA: 0x000EB720 File Offset: 0x000E9920
	[Token(Token = "0x6002AE7")]
	[Address(RVA = "0x65B0D0", Offset = "0x6596D0", VA = "0x18065B0D0", Slot = "11")]
	public override void OnAnimOver()
	{
		base.OnAnimOver();
		if (this.set)
		{
			GameObject gameObject = base.SetPlant((PlantType)((uint)32));
			return;
		}
	}

	// Token: 0x06002AE8 RID: 10984 RVA: 0x000EB748 File Offset: 0x000E9948
	[Token(Token = "0x6002AE8")]
	[Address(RVA = "0x65B2B0", Offset = "0x6598B0", VA = "0x18065B2B0")]
	public FruitNinjaSelectWindow()
	{
	}

	// Token: 0x04001918 RID: 6424
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4001918")]
	public FruitBuffType buffType;

	// Token: 0x04001919 RID: 6425
	[FieldOffset(Offset = "0xB4")]
	[Token(Token = "0x4001919")]
	private bool set;
}
