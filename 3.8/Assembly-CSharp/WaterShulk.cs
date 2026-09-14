using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200049D RID: 1181
[Token(Token = "0x200049D")]
public class WaterShulk : Shulkflower
{
	// Token: 0x06001621 RID: 5665 RVA: 0x0007AA30 File Offset: 0x00078C30
	[Token(Token = "0x6001621")]
	[Address(RVA = "0x4AD8E0", Offset = "0x4ABEE0", VA = "0x1804AD8E0", Slot = "74")]
	protected override void AttackEffect(List<Zombie> zombies)
	{
		int num2;
		for (;;)
		{
			bool result = AdvantureConfig.data.GetResult((AdvantureLevel)((uint)63), (MissionResult)((uint)2));
			if (result)
			{
			}
			bool flag;
			if (flag)
			{
				PlantType thePlantType = this.thePlantType;
			}
			ulong num;
			if (num == (ulong)0L)
			{
				int attackDamage = this.attackDamage;
				if (result)
				{
				}
				bool flag2;
				if (flag2)
				{
					PlantType thePlantType2 = this.thePlantType;
					num2 = 0;
				}
				ulong num3;
				if (num3 == (ulong)0L)
				{
					break;
				}
			}
		}
		int num4 = global::UnityEngine.Random.Range(0, 3);
		ulong num5;
		if (num5 != (ulong)0L)
		{
			Transform shoot = this.shoot;
			ParticleManager instance = ParticleManager.Instance;
			int num6 = 0;
			int num7 = 0;
			ulong num8;
			Particle particle = instance.SetParticle((ParticleType)((uint)32), num6, num2, num8 != 0UL, (float)num7);
		}
	}

	// Token: 0x06001622 RID: 5666 RVA: 0x0007AAE4 File Offset: 0x00078CE4
	[Token(Token = "0x6001622")]
	[Address(RVA = "0x4ADDF0", Offset = "0x4AC3F0", VA = "0x1804ADDF0", Slot = "24")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x06001623 RID: 5667 RVA: 0x0007AB04 File Offset: 0x00078D04
	[Token(Token = "0x6001623")]
	[Address(RVA = "0x4ADF30", Offset = "0x4AC530", VA = "0x1804ADF30", Slot = "25")]
	public override void UpdateText()
	{
		base.UpdateText();
		SpriteRenderer spriteRenderer = this.leaf;
		spriteRenderer.enabled = true;
		Transform transform = this.leaf.transform;
		int num = 0;
		GameObject gameObject = transform.GetChild(num).gameObject;
		int num2 = 0;
		gameObject.SetActive(num2 != 0);
	}

	// Token: 0x06001624 RID: 5668 RVA: 0x0007AB80 File Offset: 0x00078D80
	[Token(Token = "0x6001624")]
	[Address(RVA = "0x44CAF0", Offset = "0x44B0F0", VA = "0x18044CAF0", Slot = "59")]
	public override void InfluenceByIceShroom()
	{
	}

	// Token: 0x06001625 RID: 5669 RVA: 0x0007AB90 File Offset: 0x00078D90
	[Token(Token = "0x6001625")]
	[Address(RVA = "0x429630", Offset = "0x427C30", VA = "0x180429630")]
	public WaterShulk()
	{
	}

	// Token: 0x04000D71 RID: 3441
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000D71")]
	public SpriteRenderer leaf;
}
