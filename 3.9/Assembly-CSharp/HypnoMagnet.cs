using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003B6 RID: 950
[Token(Token = "0x20003B6")]
public class HypnoMagnet : Plant
{
	// Token: 0x06001174 RID: 4468 RVA: 0x00062B2C File Offset: 0x00060D2C
	[Token(Token = "0x6001174")]
	[Address(RVA = "0x48F690", Offset = "0x48DC90", VA = "0x18048F690")]
	public void Summon(BucketType type)
	{
		Animator anim = this.anim;
		this.itemType = type;
		anim.SetTrigger("summon");
		this.theStatus = (PlantStatus)((ulong)2L);
	}

	// Token: 0x06001175 RID: 4469 RVA: 0x00062B64 File Offset: 0x00060D64
	[Token(Token = "0x6001175")]
	[Address(RVA = "0x48F700", Offset = "0x48DD00", VA = "0x18048F700", Slot = "60")]
	public override bool UseItem(BucketType type, Bucket bucket)
	{
		int num = 0;
		if (bucket != num)
		{
			global::UnityEngine.Object.Destroy(bucket.gameObject);
		}
		Animator anim = this.anim;
		this.itemType = type;
		anim.SetTrigger("summon");
		this.theStatus = (PlantStatus)((ulong)2L);
		return true;
	}

	// Token: 0x06001176 RID: 4470 RVA: 0x00062BB4 File Offset: 0x00060DB4
	[Token(Token = "0x6001176")]
	[Address(RVA = "0x48F2A0", Offset = "0x48D8A0", VA = "0x18048F2A0")]
	private void AnimSummon()
	{
		int num = 0;
		uint num3;
		int num2 = global::UnityEngine.Random.Range(num, (int)num3);
		if (this.itemType <= BucketType.PortalHeart)
		{
			if (num2 == 0 || num2 == 0 || num2 == 1)
			{
			}
			if (num2 == 0 || num2 == 0 || num2 == 1)
			{
			}
			if (num2 <= 1)
			{
			}
			if (num2 <= 1)
			{
			}
			if (num2 > 1)
			{
				goto IL_006F;
			}
		}
		Board board = this.board;
		int thePlantRow = this.thePlantRow;
		int thePlantColumn = this.thePlantColumn;
		if (board.GetBoxType(thePlantColumn, thePlantRow) != BoxType.Water)
		{
			Transform axis = this.axis;
			CreateZombie instance = CreateZombie.Instance;
		}
		IL_006F:
		Transform axis2 = this.axis;
		CreateZombie instance2 = CreateZombie.Instance;
		Zombie zombie;
		Zombie component = zombie.GetComponent<Zombie>();
		uint num4;
		if ((num4 == (uint)28 && component == 0) || (num4 != (uint)32 && num4 != (uint)34) || component != 0)
		{
		}
		Lawnf.SetZombieHealth(component, 0.4f);
		this.theStatus = (PlantStatus)((ulong)0L);
	}

	// Token: 0x06001177 RID: 4471 RVA: 0x00062C84 File Offset: 0x00060E84
	[Token(Token = "0x6001177")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public HypnoMagnet()
	{
	}

	// Token: 0x04000C0C RID: 3084
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000C0C")]
	public BucketType itemType;
}
