using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000506 RID: 1286
[Token(Token = "0x2000506")]
public class DoomCactus : UltimateCactus
{
	// Token: 0x06001825 RID: 6181 RVA: 0x000837CC File Offset: 0x000819CC
	[Token(Token = "0x6001825")]
	[Address(RVA = "0x520520", Offset = "0x51EB20", VA = "0x180520520", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.InitBool();
	}

	// Token: 0x06001826 RID: 6182 RVA: 0x000837E8 File Offset: 0x000819E8
	[Token(Token = "0x6001826")]
	[Address(RVA = "0x3FC860", Offset = "0x3FAE60", VA = "0x1803FC860", Slot = "70")]
	protected override BulletType GetBulletType()
	{
		return BulletType.Bullet_doomCactus;
	}

	// Token: 0x06001827 RID: 6183 RVA: 0x000837F8 File Offset: 0x000819F8
	[Token(Token = "0x6001827")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "54")]
	public override void OnCreate(int theColumn, int theRow)
	{
	}

	// Token: 0x06001828 RID: 6184 RVA: 0x00083808 File Offset: 0x00081A08
	[Token(Token = "0x6001828")]
	[Address(RVA = "0x520540", Offset = "0x51EB40", VA = "0x180520540")]
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

	// Token: 0x06001829 RID: 6185 RVA: 0x00083864 File Offset: 0x00081A64
	[Token(Token = "0x6001829")]
	[Address(RVA = "0x520670", Offset = "0x51EC70", VA = "0x180520670", Slot = "68")]
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

	// Token: 0x0600182A RID: 6186 RVA: 0x000838CC File Offset: 0x00081ACC
	[Token(Token = "0x600182A")]
	[Address(RVA = "0x520750", Offset = "0x51ED50", VA = "0x180520750", Slot = "69")]
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
		return base.Shoot2();
	}

	// Token: 0x0600182B RID: 6187 RVA: 0x00083934 File Offset: 0x00081B34
	[Token(Token = "0x600182B")]
	[Address(RVA = "0x520830", Offset = "0x51EE30", VA = "0x180520830")]
	public DoomCactus()
	{
		List<bool> list = new List();
		this.bools = list;
		base..ctor();
	}

	// Token: 0x04000E63 RID: 3683
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000E63")]
	private readonly List<bool> bools;
}
