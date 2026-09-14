using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003A9 RID: 937
[Token(Token = "0x20003A9")]
public class GoldNut : WallNut
{
	// Token: 0x06001130 RID: 4400 RVA: 0x00061848 File Offset: 0x0005FA48
	[Token(Token = "0x6001130")]
	[Address(RVA = "0x48BED0", Offset = "0x48A4D0", VA = "0x18048BED0", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		int attributeCount = this.attributeCount;
	}

	// Token: 0x06001131 RID: 4401 RVA: 0x00061864 File Offset: 0x0005FA64
	[Token(Token = "0x6001131")]
	[Address(RVA = "0x48BF00", Offset = "0x48A500", VA = "0x18048BF00", Slot = "42")]
	public override bool SuperSkill()
	{
		float flashCountDown = this.flashCountDown;
		int num = 0;
		if (flashCountDown <= (float)num)
		{
			Transform axis = this.axis;
			Vector3 vector;
			float z = vector.z;
			int num2 = 0;
			ulong num3;
			ulong num4;
			base.Recover(z, (DamageType)num2, num3 != 0UL, num4 != 0UL);
			uint num5;
			GameAPP.PlaySound((int)num5, 0.5f, 1f);
			this.flashCountDown = 5f;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06001132 RID: 4402 RVA: 0x000618C4 File Offset: 0x0005FAC4
	[Token(Token = "0x6001132")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public GoldNut()
	{
	}
}
