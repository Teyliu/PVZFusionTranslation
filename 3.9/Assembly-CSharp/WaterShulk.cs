using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004BF RID: 1215
[Token(Token = "0x20004BF")]
public class WaterShulk : Shulkflower
{
	// Token: 0x060016C1 RID: 5825 RVA: 0x0007D4AC File Offset: 0x0007B6AC
	[Token(Token = "0x60016C1")]
	[Address(RVA = "0x51C0B0", Offset = "0x51A6B0", VA = "0x18051C0B0", Slot = "73")]
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

	// Token: 0x060016C2 RID: 5826 RVA: 0x0007D560 File Offset: 0x0007B760
	[Token(Token = "0x60016C2")]
	[Address(RVA = "0x51C5C0", Offset = "0x51ABC0", VA = "0x18051C5C0", Slot = "23")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x060016C3 RID: 5827 RVA: 0x0007D580 File Offset: 0x0007B780
	[Token(Token = "0x60016C3")]
	[Address(RVA = "0x51C700", Offset = "0x51AD00", VA = "0x18051C700", Slot = "24")]
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

	// Token: 0x060016C4 RID: 5828 RVA: 0x0007D5FC File Offset: 0x0007B7FC
	[Token(Token = "0x60016C4")]
	[Address(RVA = "0x4A12B0", Offset = "0x49F8B0", VA = "0x1804A12B0", Slot = "58")]
	public override void InfluenceByIceShroom()
	{
	}

	// Token: 0x060016C5 RID: 5829 RVA: 0x0007D60C File Offset: 0x0007B80C
	[Token(Token = "0x60016C5")]
	[Address(RVA = "0x469910", Offset = "0x467F10", VA = "0x180469910")]
	public WaterShulk()
	{
	}

	// Token: 0x04000E0A RID: 3594
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000E0A")]
	public SpriteRenderer leaf;
}
