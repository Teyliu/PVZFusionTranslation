using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020004DE RID: 1246
[Token(Token = "0x20004DE")]
public class DoomCactus : UltimateCactus
{
	// Token: 0x0600176E RID: 5998 RVA: 0x0008054C File Offset: 0x0007E74C
	[Token(Token = "0x600176E")]
	[Address(RVA = "0x4A0870", Offset = "0x49EE70", VA = "0x1804A0870", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.InitBool();
	}

	// Token: 0x0600176F RID: 5999 RVA: 0x00080568 File Offset: 0x0007E768
	[Token(Token = "0x600176F")]
	[Address(RVA = "0x3B05A0", Offset = "0x3AEBA0", VA = "0x1803B05A0", Slot = "71")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_doomCactus;
	}

	// Token: 0x06001770 RID: 6000 RVA: 0x00080578 File Offset: 0x0007E778
	[Token(Token = "0x6001770")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "55")]
	public override void OnCreate(int theColumn, int theRow)
	{
	}

	// Token: 0x06001771 RID: 6001 RVA: 0x00080588 File Offset: 0x0007E788
	[Token(Token = "0x6001771")]
	[Address(RVA = "0x4A0890", Offset = "0x49EE90", VA = "0x1804A0890")]
	private void InitBool()
	{
		List<bool> list = this.bools;
		int num = 0;
		list._size = num;
		List<bool> list2 = this.bools;
		int size = list2._size;
		list2._size = 1;
		num++;
		List<bool> list3 = this.bools;
		int size2 = list3._size;
	}

	// Token: 0x06001772 RID: 6002 RVA: 0x000805E4 File Offset: 0x0007E7E4
	[Token(Token = "0x6001772")]
	[Address(RVA = "0x4A09C0", Offset = "0x49EFC0", VA = "0x1804A09C0", Slot = "69")]
	protected override Bullet Shoot1()
	{
		int num = this.bools._size;
		int num2 = global::UnityEngine.Random.Range(0, num);
		List<bool> list = this.bools;
		num = num2;
		if (list[num] == 0)
		{
			List<bool> list2 = this.bools;
			num = num2;
			list2.RemoveAt(num);
		}
		this.InitBool();
		this.anim.SetTrigger("super");
		return base.Shoot1();
	}

	// Token: 0x06001773 RID: 6003 RVA: 0x0008064C File Offset: 0x0007E84C
	[Token(Token = "0x6001773")]
	[Address(RVA = "0x4A0AA0", Offset = "0x49F0A0", VA = "0x1804A0AA0", Slot = "70")]
	protected override Bullet Shoot2()
	{
		int num = this.bools._size;
		int num2 = global::UnityEngine.Random.Range(0, num);
		List<bool> list = this.bools;
		num = num2;
		if (list[num] == 0)
		{
			List<bool> list2 = this.bools;
			num = num2;
			list2.RemoveAt(num);
		}
		this.InitBool();
		this.anim.SetTrigger("super");
		Transform transform = base.transform.Find("Shoot2").transform;
		CreateBullet instance = CreateBullet.Instance;
		BulletType bulletType = this.GetBulletType();
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		return bullet;
	}

	// Token: 0x06001774 RID: 6004 RVA: 0x000806F8 File Offset: 0x0007E8F8
	[Token(Token = "0x6001774")]
	[Address(RVA = "0x4A0D00", Offset = "0x49F300", VA = "0x1804A0D00")]
	public DoomCactus()
	{
		List<bool> list = new List();
		this.bools = list;
		base..ctor();
	}

	// Token: 0x04000DBC RID: 3516
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000DBC")]
	private readonly List<bool> bools;
}
