using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006CD RID: 1741
[Token(Token = "0x20006CD")]
public class SquashZombie : Zombie
{
	// Token: 0x06002249 RID: 8777 RVA: 0x000B3E94 File Offset: 0x000B2094
	[Token(Token = "0x6002249")]
	[Address(RVA = "0x5717A0", Offset = "0x56FDA0", VA = "0x1805717A0", Slot = "28")]
	protected override void DieEvent(int reason = 0)
	{
		ZombieSquash zombieSquash = this.squash;
		int num = 0;
		if (zombieSquash != num)
		{
			global::UnityEngine.Object.Destroy(this.squash.gameObject);
		}
	}

	// Token: 0x0600224A RID: 8778 RVA: 0x000B3ECC File Offset: 0x000B20CC
	[Token(Token = "0x600224A")]
	[Address(RVA = "0x3F2500", Offset = "0x3F0B00", VA = "0x1803F2500", Slot = "13")]
	public override bool CanAttack(IDamageable target)
	{
		return false;
	}

	// Token: 0x0600224B RID: 8779 RVA: 0x000B3EDC File Offset: 0x000B20DC
	[Token(Token = "0x600224B")]
	[Address(RVA = "0x571840", Offset = "0x56FE40", VA = "0x180571840")]
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
				this.squash = component;
				GameObject gameObject3 = this.squashHead.gameObject;
				int num2 = 0;
				gameObject3.SetActive(num2 != 0);
				int num3 = 0;
				bool flag3 = base.HasBuff((EffectType)num3);
				if (flag3 || !flag3)
				{
					component.jala = false;
				}
				int theHealth = this.theHealth;
				this.beforeDying = true;
				num3 += num3;
				this.theHealth = num3;
			}
		}
	}

	// Token: 0x0600224C RID: 8780 RVA: 0x000B3FC0 File Offset: 0x000B21C0
	[Token(Token = "0x600224C")]
	[Address(RVA = "0x571B80", Offset = "0x570180", VA = "0x180571B80")]
	public SquashZombie()
	{
	}

	// Token: 0x04001130 RID: 4400
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x4001130")]
	public Transform squashHead;

	// Token: 0x04001131 RID: 4401
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x4001131")]
	public GameObject squashPrefab;

	// Token: 0x04001132 RID: 4402
	[FieldOffset(Offset = "0x268")]
	[Token(Token = "0x4001132")]
	private ZombieSquash squash;
}
