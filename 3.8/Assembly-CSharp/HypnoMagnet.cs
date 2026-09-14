using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003A2 RID: 930
[Token(Token = "0x20003A2")]
public class HypnoMagnet : Plant
{
	// Token: 0x06001118 RID: 4376 RVA: 0x000614D4 File Offset: 0x0005F6D4
	[Token(Token = "0x6001118")]
	[Address(RVA = "0x43BE40", Offset = "0x43A440", VA = "0x18043BE40")]
	public void Summon(BucketType type)
	{
		Animator anim = this.anim;
		this.itemType = type;
		anim.SetTrigger("summon");
		this.theStatus = (PlantStatus)((ulong)2L);
	}

	// Token: 0x06001119 RID: 4377 RVA: 0x0006150C File Offset: 0x0005F70C
	[Token(Token = "0x6001119")]
	[Address(RVA = "0x43BEB0", Offset = "0x43A4B0", VA = "0x18043BEB0", Slot = "61")]
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

	// Token: 0x0600111A RID: 4378 RVA: 0x0006155C File Offset: 0x0005F75C
	[Token(Token = "0x600111A")]
	[Address(RVA = "0x43BA50", Offset = "0x43A050", VA = "0x18043BA50")]
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

	// Token: 0x0600111B RID: 4379 RVA: 0x0006162C File Offset: 0x0005F82C
	[Token(Token = "0x600111B")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public HypnoMagnet()
	{
	}

	// Token: 0x04000BA6 RID: 2982
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000BA6")]
	public BucketType itemType;
}
