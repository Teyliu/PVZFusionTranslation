using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200020D RID: 525
[Token(Token = "0x200020D")]
public class LanternUmbrellaEffect : MonoBehaviour
{
	// Token: 0x060008DE RID: 2270 RVA: 0x0002DB34 File Offset: 0x0002BD34
	[Token(Token = "0x60008DE")]
	[Address(RVA = "0x8F94D0", Offset = "0x8F7AD0", VA = "0x1808F94D0")]
	private void Update()
	{
		LanternUmbrella lanternUmbrella = this.plant;
		int num = 0;
		if (lanternUmbrella == num)
		{
			global::UnityEngine.Object.Destroy(base.gameObject);
		}
	}

	// Token: 0x060008DF RID: 2271 RVA: 0x0002DB60 File Offset: 0x0002BD60
	[Token(Token = "0x60008DF")]
	[Address(RVA = "0x8F9340", Offset = "0x8F7940", VA = "0x1808F9340")]
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

	// Token: 0x060008E0 RID: 2272 RVA: 0x0002DBA0 File Offset: 0x0002BDA0
	[Token(Token = "0x60008E0")]
	[Address(RVA = "0x3E88A0", Offset = "0x3E6EA0", VA = "0x1803E88A0")]
	public LanternUmbrellaEffect()
	{
	}

	// Token: 0x04000467 RID: 1127
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000467")]
	public LanternUmbrella plant;
}
