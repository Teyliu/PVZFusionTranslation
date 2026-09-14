using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x02000874 RID: 2164
[Token(Token = "0x2000874")]
public class FruitNinjaSelectWindow : BaseWindow
{
	// Token: 0x06002C18 RID: 11288 RVA: 0x000F03EC File Offset: 0x000EE5EC
	[Token(Token = "0x6002C18")]
	[Address(RVA = "0x6BEF70", Offset = "0x6BD570", VA = "0x1806BEF70")]
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

	// Token: 0x06002C19 RID: 11289 RVA: 0x000F0460 File Offset: 0x000EE660
	[Token(Token = "0x6002C19")]
	[Address(RVA = "0x6BEF30", Offset = "0x6BD530", VA = "0x1806BEF30", Slot = "11")]
	public override void OnAnimOver()
	{
		base.OnAnimOver();
		if (this.set)
		{
			GameObject gameObject = base.SetPlant((PlantType)((uint)32));
			return;
		}
	}

	// Token: 0x06002C1A RID: 11290 RVA: 0x000F0488 File Offset: 0x000EE688
	[Token(Token = "0x6002C1A")]
	[Address(RVA = "0x6BF110", Offset = "0x6BD710", VA = "0x1806BF110")]
	public FruitNinjaSelectWindow()
	{
	}

	// Token: 0x04001A06 RID: 6662
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x4001A06")]
	public FruitBuffType buffType;

	// Token: 0x04001A07 RID: 6663
	[FieldOffset(Offset = "0xBC")]
	[Token(Token = "0x4001A07")]
	private bool set;
}
