using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000376 RID: 886
[Token(Token = "0x2000376")]
public class DiamondPotatoNut : WallNut
{
	// Token: 0x170000DC RID: 220
	// (get) Token: 0x06001042 RID: 4162 RVA: 0x0005D924 File Offset: 0x0005BB24
	[Token(Token = "0x170000DC")]
	public override int LimDamage
	{
		[Token(Token = "0x6001042")]
		[Address(RVA = "0x430540", Offset = "0x42EB40", VA = "0x180430540", Slot = "66")]
		get
		{
			return 200;
		}
	}

	// Token: 0x06001043 RID: 4163 RVA: 0x0005D938 File Offset: 0x0005BB38
	[Token(Token = "0x6001043")]
	[Address(RVA = "0x4300F0", Offset = "0x42E6F0", VA = "0x1804300F0", Slot = "29")]
	protected override void ReplaceSprite()
	{
		int num = this.thePlantMaxHealth;
		num += num;
		Transform transform = base.transform;
		int num2 = 0;
		GameObject gameObject = transform.GetChild(num2).gameObject;
		int num3 = 0;
		gameObject.SetActive(num3 != 0);
		uint num4;
		ulong num5;
		base.transform.GetChild((int)num4).gameObject.SetActive(num5 != 0UL);
		uint num6;
		GameObject gameObject2 = base.transform.GetChild((int)num6).gameObject;
		int num7 = 0;
		gameObject2.SetActive(num7 != 0);
		this.attributeCount = (int)((ulong)1L);
		Transform transform2 = base.transform;
		int num8 = 0;
		ulong num9;
		transform2.GetChild(num8).gameObject.SetActive(num9 != 0UL);
		uint num10;
		GameObject gameObject3 = base.transform.GetChild((int)num10).gameObject;
		int num11 = 0;
		gameObject3.SetActive(num11 != 0);
		uint num12;
		GameObject gameObject4 = base.transform.GetChild((int)num12).gameObject;
		int num13 = 0;
		gameObject4.SetActive(num13 != 0);
	}

	// Token: 0x06001044 RID: 4164 RVA: 0x0005DAB8 File Offset: 0x0005BCB8
	[Token(Token = "0x6001044")]
	[Address(RVA = "0x42FFE0", Offset = "0x42E5E0", VA = "0x18042FFE0", Slot = "52")]
	protected override void DieEvent(Plant.DieReason reason = Plant.DieReason.Default)
	{
		Board board = this.board;
		int num = 0;
		board.GetPoint(500f, num != 0);
		Transform axis = this.axis;
		ParticleManager instance = ParticleManager.Instance;
		int num2 = 0;
		int thePlantRow = this.thePlantRow;
		int num3 = 0;
		ulong num4;
		Particle particle = instance.SetParticle((ParticleType)((uint)106), num2, thePlantRow, num4 != 0UL, (float)num3);
		GameAPP.PlaySound(125, 0.5f, 1f);
	}

	// Token: 0x06001045 RID: 4165 RVA: 0x0005DB20 File Offset: 0x0005BD20
	[Token(Token = "0x6001045")]
	[Address(RVA = "0x415110", Offset = "0x413710", VA = "0x180415110")]
	public DiamondPotatoNut()
	{
	}
}
