using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000193 RID: 403
[Token(Token = "0x2000193")]
public class Bullet_puffRandomColor : Bullet
{
	// Token: 0x06000701 RID: 1793 RVA: 0x00023B1C File Offset: 0x00021D1C
	[Token(Token = "0x6000701")]
	[Address(RVA = "0x80B0C0", Offset = "0x8096C0", VA = "0x18080B0C0", Slot = "9")]
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

	// Token: 0x06000702 RID: 1794 RVA: 0x00023BA8 File Offset: 0x00021DA8
	[Token(Token = "0x6000702")]
	[Address(RVA = "0x80AD00", Offset = "0x809300", VA = "0x18080AD00", Slot = "17")]
	public override void HitLand()
	{
		Transform transform = base.transform;
		Vector3 vector;
		float z = vector.z;
		base.Die();
	}

	// Token: 0x06000703 RID: 1795 RVA: 0x00023BD4 File Offset: 0x00021DD4
	[Token(Token = "0x6000703")]
	[Address(RVA = "0x80ADE0", Offset = "0x8093E0", VA = "0x18080ADE0", Slot = "22")]
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

	// Token: 0x06000704 RID: 1796 RVA: 0x00023C80 File Offset: 0x00021E80
	[Token(Token = "0x6000704")]
	[Address(RVA = "0x80A970", Offset = "0x808F70", VA = "0x18080A970")]
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

	// Token: 0x06000705 RID: 1797 RVA: 0x00023CEC File Offset: 0x00021EEC
	[Token(Token = "0x6000705")]
	[Address(RVA = "0x80B220", Offset = "0x809820", VA = "0x18080B220")]
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

	// Token: 0x06000706 RID: 1798 RVA: 0x00023D38 File Offset: 0x00021F38
	[Token(Token = "0x6000706")]
	[Address(RVA = "0x6E1DE0", Offset = "0x6E03E0", VA = "0x1806E1DE0")]
	public Bullet_puffRandomColor()
	{
	}

	// Token: 0x04000392 RID: 914
	[FieldOffset(Offset = "0x140")]
	[Token(Token = "0x4000392")]
	public Sprite sprite;

	// Token: 0x04000393 RID: 915
	[FieldOffset(Offset = "0x148")]
	[Token(Token = "0x4000393")]
	public int puffColor;
}
