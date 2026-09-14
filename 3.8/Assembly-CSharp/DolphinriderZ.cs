using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200064A RID: 1610
[Token(Token = "0x200064A")]
public class DolphinriderZ : Zombie
{
	// Token: 0x06001E8E RID: 7822 RVA: 0x000A354C File Offset: 0x000A174C
	[Token(Token = "0x6001E8E")]
	[Address(RVA = "0x53C920", Offset = "0x53AF20", VA = "0x18053C920", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		GameAPP.PlaySound(78, 1f, 1f);
		Animator anim = this.anim;
		this.theStatus = (ZombieStatus)((ulong)8L);
		anim.Play("ride");
		this.inWater = true;
		base.SetMaskLayer();
	}

	// Token: 0x06001E8F RID: 7823 RVA: 0x000A35A0 File Offset: 0x000A17A0
	[Token(Token = "0x6001E8F")]
	[Address(RVA = "0x53BFF0", Offset = "0x53A5F0", VA = "0x18053BFF0", Slot = "27")]
	public override void Die(int reason = 0)
	{
		Animator anim = this.anim;
		AnimatorStateInfo animatorStateInfo;
		float length = animatorStateInfo.m_Length;
		int loop = animatorStateInfo.m_Loop;
		Animator anim2 = this.anim;
		AnimatorStateInfo animatorStateInfo2;
		float length2 = animatorStateInfo2.m_Length;
		int loop2 = animatorStateInfo2.m_Loop;
		base.Die(2);
	}

	// Token: 0x06001E90 RID: 7824 RVA: 0x000A35F0 File Offset: 0x000A17F0
	[Token(Token = "0x6001E90")]
	[Address(RVA = "0x53C2F0", Offset = "0x53A8F0", VA = "0x18053C2F0", Slot = "17")]
	protected override void FixedUpdate()
	{
		int num = 0;
		base.FixedUpdate();
		bool flag;
		if (!flag)
		{
			Transform axis = this.axis;
			Transform axis2 = this.axis;
			LayerMask plantLayer = this.plantLayer;
			Vector3 vector;
			float y = vector.y;
			this.jumpPos2.y = y;
			int num2 = plantLayer;
			Collider2D[] array;
			if (num < array.Length)
			{
				bool flag2;
				bool flag3;
				if (flag2 && !flag3)
				{
					int theZombieRow = this.theZombieRow;
				}
				num++;
				bool flag4;
				if (flag4)
				{
					this.willJumpFail = true;
					Transform axis3 = this.axis;
					Vector3 vector2;
					float z = vector2.z;
					this.failPos.z = z;
					this.failPos.z = 1f;
				}
				this.theStatus = (ZombieStatus)((ulong)9L);
				this.anim.SetTrigger("jump");
				uint num3;
				GameAPP.PlaySound((int)num3, 0.5f, 1f);
			}
		}
	}

	// Token: 0x06001E91 RID: 7825 RVA: 0x000A36D4 File Offset: 0x000A18D4
	[Token(Token = "0x6001E91")]
	[Address(RVA = "0x53C910", Offset = "0x53AF10", VA = "0x18053C910", Slot = "74")]
	public virtual void JumpOver()
	{
		int num = 0;
		base.ChangeStatus((ZombieStatus)num);
	}

	// Token: 0x06001E92 RID: 7826 RVA: 0x000A36EC File Offset: 0x000A18EC
	[Token(Token = "0x6001E92")]
	[Address(RVA = "0x53BE90", Offset = "0x53A490", VA = "0x18053BE90")]
	private void CreateWaterSplash()
	{
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		int num = 0;
		Transform axis2 = this.axis;
		ParticleManager instance = ParticleManager.Instance;
		int num2 = 0;
		int theZombieRow = this.theZombieRow;
		ulong num3;
		Particle particle = instance.SetParticle((ParticleType)((uint)32), num2, theZombieRow, num3 != 0UL, (float)num);
		GameAPP.PlaySound(75, 0.5f, 1f);
	}

	// Token: 0x06001E93 RID: 7827 RVA: 0x000A3750 File Offset: 0x000A1950
	[Token(Token = "0x6001E93")]
	[Address(RVA = "0x53BDF0", Offset = "0x53A3F0", VA = "0x18053BDF0", Slot = "36")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		Sprite sprite = Resources.Load<Sprite>("Zombies/Zombie_dolphinrider/Zombie_dolphinrider_outerarm_upper2");
		component.sprite = sprite;
	}

	// Token: 0x06001E94 RID: 7828 RVA: 0x000A3780 File Offset: 0x000A1980
	[Token(Token = "0x6001E94")]
	[Address(RVA = "0x53C680", Offset = "0x53AC80", VA = "0x18053C680", Slot = "75")]
	protected virtual void JumpFail()
	{
		if (this.willJumpFail)
		{
			GameAPP.PlaySound(64, 0.5f, 1f);
			this.anim.Play("swim");
			Transform axis = this.axis;
			int num = 0;
			if (axis != num)
			{
				float z = this.failPos.z;
				this.theStatus = (ZombieStatus)((ulong)0L);
				GameObject[] particlePrefab = GameAPP.particlePrefab;
				Transform axis2 = this.axis;
				GameObject gameObject = particlePrefab[23];
				Transform axis3 = this.axis;
				Quaternion identityQuaternion = Quaternion.identityQuaternion;
				Transform transform = this.board.transform;
			}
		}
	}

	// Token: 0x06001E95 RID: 7829 RVA: 0x000A3820 File Offset: 0x000A1A20
	[Token(Token = "0x6001E95")]
	[Address(RVA = "0x53C140", Offset = "0x53A740", VA = "0x18053C140")]
	private bool FindTallNut(int theColumn, int theRow)
	{
		for (;;)
		{
			int num = 0;
			List<Plant> plantArray = this.board.boardEntity.plantArray;
			bool flag;
			ulong num3;
			if (flag)
			{
				int num2 = 0;
				if (num != num2)
				{
					break;
				}
			}
			else if (num3 == (ulong)0L)
			{
				goto Block_2;
			}
		}
		return true;
		Block_2:
		throw new NullReferenceException();
	}

	// Token: 0x06001E96 RID: 7830 RVA: 0x000A386C File Offset: 0x000A1A6C
	[Token(Token = "0x6001E96")]
	[Address(RVA = "0x53CA20", Offset = "0x53B020", VA = "0x18053CA20")]
	public DolphinriderZ()
	{
		this.range.y = 2f;
		base..ctor();
	}

	// Token: 0x04001056 RID: 4182
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x4001056")]
	private Vector2 jumpPos2;

	// Token: 0x04001057 RID: 4183
	[FieldOffset(Offset = "0x260")]
	[Token(Token = "0x4001057")]
	private Vector2 range = (ulong)1060320051L;

	// Token: 0x04001058 RID: 4184
	[FieldOffset(Offset = "0x268")]
	[Token(Token = "0x4001058")]
	private bool willJumpFail;

	// Token: 0x04001059 RID: 4185
	[FieldOffset(Offset = "0x26C")]
	[Token(Token = "0x4001059")]
	private Vector3 failPos;
}
