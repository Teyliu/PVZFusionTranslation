using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200018C RID: 396
[Token(Token = "0x200018C")]
public class Bullet_puffRandomColor : Bullet
{
	// Token: 0x060006F4 RID: 1780 RVA: 0x000241E8 File Offset: 0x000223E8
	[Token(Token = "0x60006F4")]
	[Address(RVA = "0x7DD950", Offset = "0x7DBF50", VA = "0x1807DD950", Slot = "8")]
	public override void InitData()
	{
		base.InitData();
		uint num2;
		int num = global::UnityEngine.Random.Range(0, (int)num2);
		this.puffColor = num;
		Sprite[] spritePrefab = GameAPP.spritePrefab;
		int num3 = this.puffColor;
		num3 += 50;
		Sprite sprite = spritePrefab[num3];
		this.sprite = sprite;
		SpriteRenderer component = base.GetComponent<SpriteRenderer>();
		Sprite sprite2 = this.sprite;
		component.sprite = sprite2;
		Transform transform = base.transform;
		int num4 = 0;
		ParticleSystem.MainModule main = transform.GetChild(num4).GetComponent<ParticleSystem>().main;
	}

	// Token: 0x060006F5 RID: 1781 RVA: 0x00024274 File Offset: 0x00022474
	[Token(Token = "0x60006F5")]
	[Address(RVA = "0x7DD590", Offset = "0x7DBB90", VA = "0x1807DD590", Slot = "18")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x060006F6 RID: 1782 RVA: 0x000242A0 File Offset: 0x000224A0
	[Token(Token = "0x60006F6")]
	[Address(RVA = "0x7DD670", Offset = "0x7DBC70", VA = "0x1807DD670", Slot = "25")]
	protected override void HitZombie(Zombie zombie)
	{
		int num = 0;
		bool[] controlledLevel = zombie.controlledLevel;
		int num2 = this.puffColor;
		int length = zombie.controlledLevel.Length;
		if (num < length)
		{
			num++;
		}
		int num3 = 0;
		int damage = this._damage;
		PlantType fromType = this.fromType;
		ulong num4;
		zombie.TakeDamage(damage, this, (DamageType)num3, fromType, num4 != 0UL);
		base.PlaySound(zombie);
		GameObject gameObject = GameAPP.particlePrefab[17];
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		Quaternion identityQuaternion = Quaternion.identityQuaternion;
		Transform transform2 = Board.Instance.transform;
		GameObject gameObject2;
		ParticleSystem.MainModule main = gameObject2.GetComponent<ParticleSystem>().main;
		base.Die();
	}

	// Token: 0x060006F7 RID: 1783 RVA: 0x0002434C File Offset: 0x0002254C
	[Token(Token = "0x60006F7")]
	[Address(RVA = "0x7DD210", Offset = "0x7DB810", VA = "0x1807DD210")]
	private void AttackZombie()
	{
		Transform transform = base.transform;
		int num = 0;
		int num2 = 0;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			bool flag2;
			if (flag && flag2)
			{
				int num3 = 0;
				num3++;
				if (global::UnityEngine.Random.value < 0.75f)
				{
					PlantType fromType = this.fromType;
					num2++;
				}
			}
			num2++;
		}
	}

	// Token: 0x060006F8 RID: 1784 RVA: 0x000243B4 File Offset: 0x000225B4
	[Token(Token = "0x60006F8")]
	[Address(RVA = "0x7DDAB0", Offset = "0x7DC0B0", VA = "0x1807DDAB0")]
	private void TrySetMindControl(Zombie zombie)
	{
		bool[] controlledLevel = zombie.controlledLevel;
		int num = 0;
		int length = controlledLevel.Length;
		if (num < length)
		{
			num++;
		}
		if (global::UnityEngine.Random.value < 0.75f)
		{
			PlantType fromType = this.fromType;
			return;
		}
		throw new NullReferenceException();
	}

	// Token: 0x060006F9 RID: 1785 RVA: 0x000243F8 File Offset: 0x000225F8
	[Token(Token = "0x60006F9")]
	[Address(RVA = "0x5B84F0", Offset = "0x5B6AF0", VA = "0x1805B84F0")]
	public Bullet_puffRandomColor()
	{
	}

	// Token: 0x04000389 RID: 905
	[FieldOffset(Offset = "0x120")]
	[Token(Token = "0x4000389")]
	public Sprite sprite;

	// Token: 0x0400038A RID: 906
	[FieldOffset(Offset = "0x128")]
	[Token(Token = "0x400038A")]
	public int puffColor;
}
