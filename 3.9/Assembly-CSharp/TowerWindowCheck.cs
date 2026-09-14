using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020000F4 RID: 244
[Token(Token = "0x20000F4")]
public class TowerWindowCheck : MonoBehaviour
{
	// Token: 0x0600049A RID: 1178 RVA: 0x00017D48 File Offset: 0x00015F48
	[Token(Token = "0x600049A")]
	[Address(RVA = "0x5EBD30", Offset = "0x5EA330", VA = "0x1805EBD30")]
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

	// Token: 0x0600049B RID: 1179 RVA: 0x00017DB8 File Offset: 0x00015FB8
	[Token(Token = "0x600049B")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public TowerWindowCheck()
	{
	}

	// Token: 0x040002B3 RID: 691
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002B3")]
	public Advanture_Btn level;

	// Token: 0x040002B4 RID: 692
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40002B4")]
	public GameObject prize;
}
