using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using GameLevel.RogueShooting;
using UnityEngine;

// Token: 0x02000079 RID: 121
[Token(Token = "0x2000079")]
public class UltimateJacksonTurn : MonoBehaviour
{
	// Token: 0x06000200 RID: 512 RVA: 0x00006C24 File Offset: 0x00004E24
	[Token(Token = "0x6000200")]
	[Address(RVA = "0x4000C0", Offset = "0x3FE6C0", VA = "0x1804000C0")]
	private void Awake()
	{
		Animator component = base.GetComponent<Animator>();
		this.anim = component;
		this.active = true;
	}

	// Token: 0x06000201 RID: 513 RVA: 0x00006C48 File Offset: 0x00004E48
	[Token(Token = "0x6000201")]
	[Address(RVA = "0x400110", Offset = "0x3FE710", VA = "0x180400110")]
	private void Start()
	{
		Board board = this.zombie.board;
		this.pointCount = (int)((ulong)1L);
	}

	// Token: 0x06000202 RID: 514 RVA: 0x00006C78 File Offset: 0x00004E78
	[Token(Token = "0x6000202")]
	[Address(RVA = "0x400640", Offset = "0x3FEC40", VA = "0x180400640")]
	private void Turn()
	{
		Transform transform = base.transform;
		if (!this.active)
		{
			this.zombie = (ulong)0L;
			return;
		}
		Zombie zombie = this.zombie;
		int attributeCount = this.zombie.attributeCount;
		this.anim.SetTrigger("point");
	}

	// Token: 0x06000203 RID: 515 RVA: 0x00006CCC File Offset: 0x00004ECC
	[Token(Token = "0x6000203")]
	[Address(RVA = "0x3FFE90", Offset = "0x3FE490", VA = "0x1803FFE90")]
	private void AnimSummon()
	{
		Zombie zombie = this.zombie;
		int num = 0;
		if (zombie != num && !this.zombie.isMindControlled)
		{
			Zombie zombie2 = this.zombie;
			if (zombie2.theZombieRow > 0)
			{
				Transform axis = zombie2.axis;
				Zombie zombie3 = this.zombie;
			}
			Zombie zombie4 = this.zombie;
			int rowNum = Board.Instance.rowNum;
			if (zombie4.theZombieRow < rowNum)
			{
				Transform axis2 = zombie4.axis;
				int num2 = this.zombie.theZombieRow;
				num2++;
			}
			Transform axis3 = this.zombie.axis;
			Zombie zombie5 = this.zombie;
			Transform axis4 = this.zombie.axis;
			Zombie zombie6 = this.zombie;
		}
	}

	// Token: 0x06000204 RID: 516 RVA: 0x00006D8C File Offset: 0x00004F8C
	[Token(Token = "0x6000204")]
	[Address(RVA = "0x400150", Offset = "0x3FE750", VA = "0x180400150")]
	private void SummonZombie(float x, int theRow)
	{
		Board instance = Board.Instance;
		int columnFromX = Lawnf.GetColumnFromX(x);
		if (instance.GetBoxType(columnFromX, theRow) != BoxType.Water)
		{
			if (this.zombie.theZombieType == ZombieType.JacksonDriverBoss)
			{
				ShootingManager instance2 = ShootingManager.Instance;
				int num = 0;
				if (instance2 != num)
				{
					CreateZombie instance3 = CreateZombie.Instance;
					Zombie zombie;
					Lawnf.SetZombieHealth(zombie, 20f);
					int size = new List()._size;
					Action<Zombie> <>9__8_ = UltimateJacksonTurn.<>c.<>9__8_0;
					if (<>9__8_ == 0)
					{
						Action<Zombie> action;
						UltimateJacksonTurn.<>c.<>9__8_0 = action;
					}
					zombie.onDeath = <>9__8_;
					return;
				}
			}
			CreateZombie instance4 = CreateZombie.Instance;
			ParticleManager instance5 = ParticleManager.Instance;
			Zombie zombie2;
			Transform axis = zombie2.axis;
			Vector3 vector;
			float z = vector.z;
			CreateZombie instance6 = CreateZombie.Instance;
			throw new NullReferenceException();
		}
	}

	// Token: 0x06000205 RID: 517 RVA: 0x00006E48 File Offset: 0x00005048
	[Token(Token = "0x6000205")]
	[Address(RVA = "0x400720", Offset = "0x3FED20", VA = "0x180400720")]
	public UltimateJacksonTurn()
	{
	}

	// Token: 0x04000079 RID: 121
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000079")]
	public Zombie zombie;

	// Token: 0x0400007A RID: 122
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400007A")]
	private Animator anim;

	// Token: 0x0400007B RID: 123
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400007B")]
	public bool active;

	// Token: 0x0400007C RID: 124
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x400007C")]
	private int pointCount = (int)((ulong)9L);
}
