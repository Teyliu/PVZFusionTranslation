using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000206 RID: 518
[Token(Token = "0x2000206")]
public class LanternUmbrellaEffect : MonoBehaviour
{
	// Token: 0x060008C4 RID: 2244 RVA: 0x0002DB38 File Offset: 0x0002BD38
	[Token(Token = "0x60008C4")]
	[Address(RVA = "0x86A780", Offset = "0x868D80", VA = "0x18086A780")]
	private void Update()
	{
		LanternUmbrella lanternUmbrella = this.plant;
		int num = 0;
		if (lanternUmbrella == num)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x060008C5 RID: 2245 RVA: 0x0002DB64 File Offset: 0x0002BD64
	[Token(Token = "0x60008C5")]
	[Address(RVA = "0x86A5F0", Offset = "0x868BF0", VA = "0x18086A5F0")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		bool flag;
		if (flag)
		{
			int thePlantRow = this.plant.thePlantRow;
			Team <Team>k__BackingField = this.plant.<Team>k__BackingField;
			ulong num;
			this.plant.UseEnergy((int)num);
		}
	}

	// Token: 0x060008C6 RID: 2246 RVA: 0x0002DBA4 File Offset: 0x0002BDA4
	[Token(Token = "0x60008C6")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public LanternUmbrellaEffect()
	{
	}

	// Token: 0x0400045D RID: 1117
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400045D")]
	public LanternUmbrella plant;
}
