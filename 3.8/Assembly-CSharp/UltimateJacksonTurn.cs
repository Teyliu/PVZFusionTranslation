using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000075 RID: 117
[Token(Token = "0x2000075")]
public class UltimateJacksonTurn : MonoBehaviour
{
	// Token: 0x060001E9 RID: 489 RVA: 0x00006988 File Offset: 0x00004B88
	[Token(Token = "0x60001E9")]
	[Address(RVA = "0x3B3900", Offset = "0x3B1F00", VA = "0x1803B3900")]
	private void Awake()
	{
		Animator component = base.GetComponent<Animator>();
		this.anim = component;
		this.active = true;
	}

	// Token: 0x060001EA RID: 490 RVA: 0x000069AC File Offset: 0x00004BAC
	[Token(Token = "0x60001EA")]
	[Address(RVA = "0x3B3B00", Offset = "0x3B2100", VA = "0x1803B3B00")]
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
		ulong num;
		num += num;
		while ((ulong)attributeCount != num)
		{
		}
		this.anim.SetTrigger("point");
	}

	// Token: 0x060001EB RID: 491 RVA: 0x00006A0C File Offset: 0x00004C0C
	[Token(Token = "0x60001EB")]
	[Address(RVA = "0x3B36D0", Offset = "0x3B1CD0", VA = "0x1803B36D0")]
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

	// Token: 0x060001EC RID: 492 RVA: 0x00006ACC File Offset: 0x00004CCC
	[Token(Token = "0x60001EC")]
	[Address(RVA = "0x3B3950", Offset = "0x3B1F50", VA = "0x1803B3950")]
	private void SummonZombie(float x, int theRow)
	{
		Board instance = Board.Instance;
		int columnFromX = Lawnf.GetColumnFromX(x);
		if (instance.GetBoxType(columnFromX, theRow) != BoxType.Water)
		{
			CreateZombie instance2 = CreateZombie.Instance;
			int num = 0;
			Transform axis = instance2.SetZombie(theRow, (ZombieType)((uint)207), x, num != 0).GetComponent<Zombie>().axis;
			Vector3 vector;
			float y = vector.y;
			float z = vector.z;
			CreateZombie instance3 = CreateZombie.Instance;
			Zombie zombie = instance3.SetZombie(theRow, (ZombieType)((uint)217), x, num != 0);
		}
	}

	// Token: 0x060001ED RID: 493 RVA: 0x00006B4C File Offset: 0x00004D4C
	[Token(Token = "0x60001ED")]
	[Address(RVA = "0x39C890", Offset = "0x39AE90", VA = "0x18039C890")]
	public UltimateJacksonTurn()
	{
	}

	// Token: 0x0400006F RID: 111
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400006F")]
	public Zombie zombie;

	// Token: 0x04000070 RID: 112
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000070")]
	private Animator anim;

	// Token: 0x04000071 RID: 113
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000071")]
	public bool active;
}
