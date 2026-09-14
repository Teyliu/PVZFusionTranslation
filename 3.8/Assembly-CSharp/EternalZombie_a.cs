using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000663 RID: 1635
[Token(Token = "0x2000663")]
public class EternalZombie_a : Zombie
{
	// Token: 0x06001F1A RID: 7962 RVA: 0x000A59E4 File Offset: 0x000A3BE4
	[Token(Token = "0x6001F1A")]
	[Address(RVA = "0x5448D0", Offset = "0x542ED0", VA = "0x1805448D0", Slot = "28")]
	protected override void DieEvent(int reason = 0)
	{
		base.DieEvent(reason);
		this.anim.SetTrigger("shake");
	}

	// Token: 0x06001F1B RID: 7963 RVA: 0x000A5A10 File Offset: 0x000A3C10
	[Token(Token = "0x6001F1B")]
	[Address(RVA = "0x544700", Offset = "0x542D00", VA = "0x180544700", Slot = "36")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		int num = 0;
		component.enabled = num != 0;
		Transform transform = arm.transform;
		int num2 = 0;
		transform.GetChild(num2).gameObject.SetActive(true);
	}

	// Token: 0x06001F1C RID: 7964 RVA: 0x000A5A50 File Offset: 0x000A3C50
	[Token(Token = "0x6001F1C")]
	[Address(RVA = "0x5447A0", Offset = "0x542DA0", VA = "0x1805447A0", Slot = "45")]
	public override void DestoryZombie()
	{
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		GameAPP.PlaySound(40, 0.5f, 1f);
		global::UnityEngine.Object.Destroy(base.gameObject);
		this.AttackPlants();
	}

	// Token: 0x06001F1D RID: 7965 RVA: 0x000A5A98 File Offset: 0x000A3C98
	[Token(Token = "0x6001F1D")]
	[Address(RVA = "0x544480", Offset = "0x542A80", VA = "0x180544480")]
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

	// Token: 0x06001F1E RID: 7966 RVA: 0x000A5B08 File Offset: 0x000A3D08
	[Token(Token = "0x6001F1E")]
	[Address(RVA = "0x544930", Offset = "0x542F30", VA = "0x180544930")]
	public EternalZombie_a()
	{
	}
}
