using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000386 RID: 902
[Token(Token = "0x2000386")]
public class DiamondPotatoNut : WallNut
{
	// Token: 0x1700011F RID: 287
	// (get) Token: 0x0600108E RID: 4238 RVA: 0x0005E8B8 File Offset: 0x0005CAB8
	[Token(Token = "0x1700011F")]
	public override int LimDamage
	{
		[Token(Token = "0x600108E")]
		[Address(RVA = "0x480D00", Offset = "0x47F300", VA = "0x180480D00", Slot = "65")]
		get
		{
			return 200;
		}
	}

	// Token: 0x0600108F RID: 4239 RVA: 0x0005E8CC File Offset: 0x0005CACC
	[Token(Token = "0x600108F")]
	[Address(RVA = "0x4808B0", Offset = "0x47EEB0", VA = "0x1804808B0", Slot = "28")]
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

	// Token: 0x06001090 RID: 4240 RVA: 0x0005EA4C File Offset: 0x0005CC4C
	[Token(Token = "0x6001090")]
	[Address(RVA = "0x4807A0", Offset = "0x47EDA0", VA = "0x1804807A0", Slot = "51")]
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

	// Token: 0x06001091 RID: 4241 RVA: 0x0005EAB4 File Offset: 0x0005CCB4
	[Token(Token = "0x6001091")]
	[Address(RVA = "0x458C20", Offset = "0x457220", VA = "0x180458C20")]
	public DiamondPotatoNut()
	{
	}
}
