using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x0200086F RID: 2159
[Token(Token = "0x200086F")]
public class EveOptionWindow : BaseWindow
{
	// Token: 0x06002BE5 RID: 11237 RVA: 0x000EEB44 File Offset: 0x000ECD44
	[Token(Token = "0x6002BE5")]
	[Address(RVA = "0x6B8130", Offset = "0x6B6730", VA = "0x1806B8130", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.SetDescription("暂无");
	}

	// Token: 0x06002BE6 RID: 11238 RVA: 0x000EEB64 File Offset: 0x000ECD64
	[Token(Token = "0x6002BE6")]
	[Address(RVA = "0x6B8340", Offset = "0x6B6940", VA = "0x1806B8340")]
	public void SetType(EveBuff eveBuff)
	{
		this.buffType = eveBuff;
		Type typeFromHandle = typeof(EveBuff);
		string text2;
		string text = Enum.GetName(typeFromHandle, typeFromHandle) + "：" + text2;
		base.SetDescription(text);
	}

	// Token: 0x06002BE7 RID: 11239 RVA: 0x000EEBA0 File Offset: 0x000ECDA0
	[Token(Token = "0x6002BE7")]
	[Address(RVA = "0x6B8180", Offset = "0x6B6780", VA = "0x1806B8180", Slot = "11")]
	public override void OnAnimOver()
	{
		base.OnAnimOver();
		int num = 0;
		GameObject gameObject = base.SetPlant((PlantType)num);
	}

	// Token: 0x06002BE8 RID: 11240 RVA: 0x000EEBC0 File Offset: 0x000ECDC0
	[Token(Token = "0x6002BE8")]
	[Address(RVA = "0x6B81B0", Offset = "0x6B67B0", VA = "0x1806B81B0")]
	public void SelectedByRow(int row)
	{
		ulong num2;
		do
		{
			this.selected = true;
			List<TextMeshProUGUI> list = this.buttonText;
			bool flag;
			if (flag)
			{
				int num = row + 1;
				string text = string.Format("第{0}路", num);
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x06002BE9 RID: 11241 RVA: 0x000EEC08 File Offset: 0x000ECE08
	[Token(Token = "0x6002BE9")]
	[Address(RVA = "0x6B8480", Offset = "0x6B6A80", VA = "0x1806B8480")]
	public EveOptionWindow()
	{
		List<TextMeshProUGUI> list = new List();
		this.buttonText = list;
		base..ctor();
	}

	// Token: 0x040019CA RID: 6602
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40019CA")]
	public List<TextMeshProUGUI> buttonText;

	// Token: 0x040019CB RID: 6603
	[FieldOffset(Offset = "0xC0")]
	[Token(Token = "0x40019CB")]
	public bool selected;

	// Token: 0x040019CC RID: 6604
	[FieldOffset(Offset = "0xC4")]
	[Token(Token = "0x40019CC")]
	public EveBuff buffType;
}
