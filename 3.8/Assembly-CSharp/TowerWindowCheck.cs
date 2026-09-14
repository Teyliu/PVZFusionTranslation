using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020000EF RID: 239
[Token(Token = "0x20000EF")]
public class TowerWindowCheck : MonoBehaviour
{
	// Token: 0x0600047F RID: 1151 RVA: 0x0001793C File Offset: 0x00015B3C
	[Token(Token = "0x600047F")]
	[Address(RVA = "0x5B62A0", Offset = "0x5B48A0", VA = "0x1805B62A0")]
	private void Start()
	{
		GameObject gameObject = base.gameObject;
		int buttonNumber = this.level.buttonNumber;
		bool flag = "{il2cpp field on {'constant10' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StaticFieldsPtr)}, offset 0xD8}" >= buttonNumber;
		gameObject.SetActive(flag);
		Advanture_Btn advanture_Btn = this.level;
		GameObject gameObject2 = this.prize;
		int num = advanture_Btn.buttonNumber;
		num++;
		bool flag2 = "{il2cpp field on {'constant15' (constant value of type Cpp2IL.Core.Analysis.ResultModels.StaticFieldsPtr)}, offset 0xD8}" >= num;
		gameObject2.SetActive(flag2);
	}

	// Token: 0x06000480 RID: 1152 RVA: 0x000179AC File Offset: 0x00015BAC
	[Token(Token = "0x6000480")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public TowerWindowCheck()
	{
	}

	// Token: 0x040002A5 RID: 677
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002A5")]
	public Advanture_Btn level;

	// Token: 0x040002A6 RID: 678
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002A6")]
	public GameObject prize;
}
