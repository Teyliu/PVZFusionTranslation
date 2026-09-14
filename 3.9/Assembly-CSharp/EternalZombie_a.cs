using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000699 RID: 1689
[Token(Token = "0x2000699")]
public class EternalZombie_a : Zombie
{
	// Token: 0x0600201C RID: 8220 RVA: 0x000AA15C File Offset: 0x000A835C
	[Token(Token = "0x600201C")]
	[Address(RVA = "0x5A6EF0", Offset = "0x5A54F0", VA = "0x1805A6EF0", Slot = "29")]
	protected override void DieEvent(int reason = 0)
	{
		base.DieEvent(reason);
		this.anim.SetTrigger("shake");
	}

	// Token: 0x0600201D RID: 8221 RVA: 0x000AA188 File Offset: 0x000A8388
	[Token(Token = "0x600201D")]
	[Address(RVA = "0x5A6D20", Offset = "0x5A5320", VA = "0x1805A6D20", Slot = "38")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		int num = 0;
		component.enabled = num != 0;
		Transform transform = arm.transform;
		int num2 = 0;
		transform.GetChild(num2).gameObject.SetActive(true);
	}

	// Token: 0x0600201E RID: 8222 RVA: 0x000AA1C8 File Offset: 0x000A83C8
	[Token(Token = "0x600201E")]
	[Address(RVA = "0x5A6DC0", Offset = "0x5A53C0", VA = "0x1805A6DC0", Slot = "47")]
	public override void DestoryZombie()
	{
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		GameAPP.PlaySound(40, 0.5f, 1f);
		global::UnityEngine.Object.Destroy(base.gameObject);
		this.AttackPlants();
	}

	// Token: 0x0600201F RID: 8223 RVA: 0x000AA210 File Offset: 0x000A8410
	[Token(Token = "0x600201F")]
	[Address(RVA = "0x5A6AA0", Offset = "0x5A50A0", VA = "0x1805A6AA0")]
	private void AttackPlants()
	{
		Transform axis = this.axis;
		int num = 0;
		int num2 = this.plantLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			LayerMask layerMask;
			int mask = layerMask.m_Mask;
			bool flag;
			if (layerMask != 0 && flag)
			{
				int num3 = 0;
				Plant plant;
				if (!(plant == num3))
				{
				}
				int num4 = 0;
				int num5 = this.theAttackDamage;
				num5 -= num4;
			}
			num++;
		}
	}

	// Token: 0x06002020 RID: 8224 RVA: 0x000AA280 File Offset: 0x000A8480
	[Token(Token = "0x6002020")]
	[Address(RVA = "0x5A6F50", Offset = "0x5A5550", VA = "0x1805A6F50")]
	public EternalZombie_a()
	{
	}
}
