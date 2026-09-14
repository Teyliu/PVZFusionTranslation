using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000013 RID: 19
[Token(Token = "0x2000013")]
[Serializable]
public class PlantFireEffect : PlantEffect
{
	// Token: 0x17000011 RID: 17
	// (get) Token: 0x06000053 RID: 83 RVA: 0x000030C8 File Offset: 0x000012C8
	[Token(Token = "0x17000011")]
	public override EffectType EffectType
	{
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x3FC5B0", Offset = "0x3FABB0", VA = "0x1803FC5B0", Slot = "4")]
		get
		{
			return EffectType.FireCover;
		}
	}

	// Token: 0x06000054 RID: 84 RVA: 0x000030D8 File Offset: 0x000012D8
	[Token(Token = "0x6000054")]
	[Address(RVA = "0x3FC4F0", Offset = "0x3FAAF0", VA = "0x1803FC4F0")]
	public PlantFireEffect(Plant plant)
	{
		this.first = true;
		base.OnStart();
		this.plant = plant;
		EffectType effectType = this.EffectType;
		bool flag;
		if (flag)
		{
		}
		this.blockCount = (int)((ulong)25L);
	}

	// Token: 0x06000055 RID: 85 RVA: 0x00003118 File Offset: 0x00001318
	[Token(Token = "0x6000055")]
	[Address(RVA = "0x3FC120", Offset = "0x3FA720", VA = "0x1803FC120", Slot = "5")]
	public override void OnStart()
	{
		Plant plant = this.plant;
	}

	// Token: 0x06000056 RID: 86 RVA: 0x00003134 File Offset: 0x00001334
	[Token(Token = "0x6000056")]
	[Address(RVA = "0x3FC160", Offset = "0x3FA760", VA = "0x1803FC160", Slot = "6")]
	public override void OnUpdate()
	{
		int num = 0;
		float deltaTime = Time.deltaTime;
		Plant plant = this.plant;
		this.totalDuration = deltaTime;
		Transform axis = plant.axis;
		Vector3 vector;
		float z = vector.z;
		Vector3 vector2;
		float z2 = vector2.z;
		float columnWidth = this.plant.board.gridSystem.ColumnWidth;
		int num2 = this.plant.bulletLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
				GameAPP.PlaySound(flag ? 1 : 0, 0.5f, 1f);
				this.plant.FlashOnce();
				Vector3 vector3;
				float z3 = vector3.z;
				int num3 = this.blockCount;
				this.blockCount = num3;
				if (num3 <= 0)
				{
					goto IL_00A8;
				}
			}
			num++;
			IL_00A8:
			this.OnRemove();
		}
	}

	// Token: 0x06000057 RID: 87 RVA: 0x000031F8 File Offset: 0x000013F8
	[Token(Token = "0x6000057")]
	[Address(RVA = "0x3FC0D0", Offset = "0x3FA6D0", VA = "0x1803FC0D0", Slot = "8")]
	public override void OnRemove()
	{
		base.OnRemove();
		Plant plant = this.plant;
	}

	// Token: 0x04000034 RID: 52
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000034")]
	private int blockCount;
}
