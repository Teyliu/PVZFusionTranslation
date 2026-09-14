using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x02000833 RID: 2099
[Token(Token = "0x2000833")]
public class EveOptionWindow : BaseWindow
{
	// Token: 0x06002AB3 RID: 10931 RVA: 0x000E9D9C File Offset: 0x000E7F9C
	[Token(Token = "0x6002AB3")]
	[Address(RVA = "0x654310", Offset = "0x652910", VA = "0x180654310", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.SetDescription("暂无");
	}

	// Token: 0x06002AB4 RID: 10932 RVA: 0x000E9DBC File Offset: 0x000E7FBC
	[Token(Token = "0x6002AB4")]
	[Address(RVA = "0x654520", Offset = "0x652B20", VA = "0x180654520")]
	public void SetType(EveBuff eveBuff)
	{
		this.buffType = eveBuff;
		Type typeFromHandle = typeof(EveBuff);
		string text2;
		string text = Enum.GetName(typeFromHandle, typeFromHandle) + "：" + text2;
		base.SetDescription(text);
	}

	// Token: 0x06002AB5 RID: 10933 RVA: 0x000E9DF8 File Offset: 0x000E7FF8
	[Token(Token = "0x6002AB5")]
	[Address(RVA = "0x654360", Offset = "0x652960", VA = "0x180654360", Slot = "11")]
	public override void OnAnimOver()
	{
		base.OnAnimOver();
		int num = 0;
		GameObject gameObject = base.SetPlant((PlantType)num);
	}

	// Token: 0x06002AB6 RID: 10934 RVA: 0x000E9E18 File Offset: 0x000E8018
	[Token(Token = "0x6002AB6")]
	[Address(RVA = "0x654390", Offset = "0x652990", VA = "0x180654390")]
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

	// Token: 0x06002AB7 RID: 10935 RVA: 0x000E9E60 File Offset: 0x000E8060
	[Token(Token = "0x6002AB7")]
	[Address(RVA = "0x654660", Offset = "0x652C60", VA = "0x180654660")]
	public EveOptionWindow()
	{
		List<TextMeshProUGUI> list = new List();
		this.buttonText = list;
		base..ctor();
	}

	// Token: 0x040018DC RID: 6364
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x40018DC")]
	public List<TextMeshProUGUI> buttonText;

	// Token: 0x040018DD RID: 6365
	[FieldOffset(Offset = "0xB8")]
	[Token(Token = "0x40018DD")]
	public bool selected;

	// Token: 0x040018DE RID: 6366
	[FieldOffset(Offset = "0xBC")]
	[Token(Token = "0x40018DE")]
	public EveBuff buffType;
}
