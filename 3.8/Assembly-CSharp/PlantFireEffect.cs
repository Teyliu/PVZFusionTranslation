using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200000E RID: 14
[Token(Token = "0x200000E")]
[Serializable]
public class PlantFireEffect : PlantEffect
{
	// Token: 0x1700000B RID: 11
	// (get) Token: 0x06000039 RID: 57 RVA: 0x00002D70 File Offset: 0x00000F70
	[Token(Token = "0x1700000B")]
	public override EffectType EffectType
	{
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x3B02F0", Offset = "0x3AE8F0", VA = "0x1803B02F0", Slot = "4")]
		get
		{
			return EffectType.FireCover;
		}
	}

	// Token: 0x0600003A RID: 58 RVA: 0x00002D80 File Offset: 0x00000F80
	[Token(Token = "0x600003A")]
	[Address(RVA = "0x3B0230", Offset = "0x3AE830", VA = "0x1803B0230")]
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

	// Token: 0x0600003B RID: 59 RVA: 0x00002DC0 File Offset: 0x00000FC0
	[Token(Token = "0x600003B")]
	[Address(RVA = "0x3AFE60", Offset = "0x3AE460", VA = "0x1803AFE60", Slot = "5")]
	public override void OnStart()
	{
		Plant plant = this.plant;
	}

	// Token: 0x0600003C RID: 60 RVA: 0x00002DDC File Offset: 0x00000FDC
	[Token(Token = "0x600003C")]
	[Address(RVA = "0x3AFEA0", Offset = "0x3AE4A0", VA = "0x1803AFEA0", Slot = "6")]
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

	// Token: 0x0600003D RID: 61 RVA: 0x00002EA0 File Offset: 0x000010A0
	[Token(Token = "0x600003D")]
	[Address(RVA = "0x3AFE10", Offset = "0x3AE410", VA = "0x1803AFE10", Slot = "8")]
	public override void OnRemove()
	{
		base.OnRemove();
		Plant plant = this.plant;
	}

	// Token: 0x0400002B RID: 43
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400002B")]
	private int blockCount;
}
