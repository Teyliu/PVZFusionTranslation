using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000680 RID: 1664
[Token(Token = "0x2000680")]
public class DolphinriderZ : Zombie
{
	// Token: 0x06001F90 RID: 8080 RVA: 0x000A7C9C File Offset: 0x000A5E9C
	[Token(Token = "0x6001F90")]
	[Address(RVA = "0x59EF10", Offset = "0x59D510", VA = "0x18059EF10", Slot = "16")]
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

	// Token: 0x06001F91 RID: 8081 RVA: 0x000A7CF0 File Offset: 0x000A5EF0
	[Token(Token = "0x6001F91")]
	[Address(RVA = "0x59E5E0", Offset = "0x59CBE0", VA = "0x18059E5E0", Slot = "28")]
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

	// Token: 0x06001F92 RID: 8082 RVA: 0x000A7D40 File Offset: 0x000A5F40
	[Token(Token = "0x6001F92")]
	[Address(RVA = "0x59E8E0", Offset = "0x59CEE0", VA = "0x18059E8E0", Slot = "18")]
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

	// Token: 0x06001F93 RID: 8083 RVA: 0x000A7E24 File Offset: 0x000A6024
	[Token(Token = "0x6001F93")]
	[Address(RVA = "0x59EF00", Offset = "0x59D500", VA = "0x18059EF00", Slot = "76")]
	public virtual void JumpOver()
	{
		int num = 0;
		base.ChangeStatus((ZombieStatus)num);
	}

	// Token: 0x06001F94 RID: 8084 RVA: 0x000A7E3C File Offset: 0x000A603C
	[Token(Token = "0x6001F94")]
	[Address(RVA = "0x59E480", Offset = "0x59CA80", VA = "0x18059E480")]
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

	// Token: 0x06001F95 RID: 8085 RVA: 0x000A7EA0 File Offset: 0x000A60A0
	[Token(Token = "0x6001F95")]
	[Address(RVA = "0x59E3E0", Offset = "0x59C9E0", VA = "0x18059E3E0", Slot = "38")]
	protected override void ChangeArmSpirte(GameObject arm)
	{
		SpriteRenderer component = arm.GetComponent<SpriteRenderer>();
		Sprite sprite = Resources.Load<Sprite>("Zombies/Zombie_dolphinrider/Zombie_dolphinrider_outerarm_upper2");
		component.sprite = sprite;
	}

	// Token: 0x06001F96 RID: 8086 RVA: 0x000A7ED0 File Offset: 0x000A60D0
	[Token(Token = "0x6001F96")]
	[Address(RVA = "0x59EC70", Offset = "0x59D270", VA = "0x18059EC70", Slot = "77")]
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

	// Token: 0x06001F97 RID: 8087 RVA: 0x000A7F70 File Offset: 0x000A6170
	[Token(Token = "0x6001F97")]
	[Address(RVA = "0x59E730", Offset = "0x59CD30", VA = "0x18059E730")]
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

	// Token: 0x06001F98 RID: 8088 RVA: 0x000A7FBC File Offset: 0x000A61BC
	[Token(Token = "0x6001F98")]
	[Address(RVA = "0x59F010", Offset = "0x59D610", VA = "0x18059F010")]
	public DolphinriderZ()
	{
		this.range.y = 2f;
		base..ctor();
	}

	// Token: 0x04001122 RID: 4386
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x4001122")]
	private Vector2 jumpPos2;

	// Token: 0x04001123 RID: 4387
	[FieldOffset(Offset = "0x280")]
	[Token(Token = "0x4001123")]
	private Vector2 range = (ulong)1060320051L;

	// Token: 0x04001124 RID: 4388
	[FieldOffset(Offset = "0x288")]
	[Token(Token = "0x4001124")]
	private bool willJumpFail;

	// Token: 0x04001125 RID: 4389
	[FieldOffset(Offset = "0x28C")]
	[Token(Token = "0x4001125")]
	private Vector3 failPos;
}
