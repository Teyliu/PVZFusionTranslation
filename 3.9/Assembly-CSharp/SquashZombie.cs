using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000705 RID: 1797
[Token(Token = "0x2000705")]
public class SquashZombie : Zombie
{
	// Token: 0x06002364 RID: 9060 RVA: 0x000B8C60 File Offset: 0x000B6E60
	[Token(Token = "0x6002364")]
	[Address(RVA = "0x400970", Offset = "0x3FEF70", VA = "0x180400970", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x06002365 RID: 9061 RVA: 0x000B8C70 File Offset: 0x000B6E70
	[Token(Token = "0x6002365")]
	[Address(RVA = "0x5D4E80", Offset = "0x5D3480", VA = "0x1805D4E80")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		bool flag;
		if (flag)
		{
			int theZombieRow = this.theZombieRow;
			bool flag2;
			if (!flag2)
			{
				this.anim.CrossFade("idle", 0.01f);
				Transform transform = this.squashHead;
				GameObject gameObject = this.squashPrefab;
				Vector3 vector;
				float z = vector.z;
				Quaternion identityQuaternion = Quaternion.identityQuaternion;
				Transform transform2 = this.board.transform;
				GameObject gameObject2;
				ZombieSquash component = gameObject2.GetComponent<ZombieSquash>();
				ulong num;
				component.targetColumn = (int)num;
				component.targetRow = (int)num;
				ZombieType theZombieType = this.theZombieType;
				component.ZombieType = theZombieType;
				GameObject gameObject3 = this.squashHead.gameObject;
				int num2 = 0;
				gameObject3.SetActive(num2 != 0);
				int num3 = 0;
				bool flag3 = base.HasBuff((EffectType)num3);
				if (flag3 || !flag3)
				{
					component.jala = false;
				}
				this.beforeDying = true;
				num3 += num3;
				this.theHealth = (long)num3;
			}
		}
	}

	// Token: 0x06002366 RID: 9062 RVA: 0x000B8D54 File Offset: 0x000B6F54
	[Token(Token = "0x6002366")]
	[Address(RVA = "0x5D51D0", Offset = "0x5D37D0", VA = "0x1805D51D0")]
	public SquashZombie()
	{
	}

	// Token: 0x040011FE RID: 4606
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x40011FE")]
	public Transform squashHead;

	// Token: 0x040011FF RID: 4607
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x40011FF")]
	public GameObject squashPrefab;
}
