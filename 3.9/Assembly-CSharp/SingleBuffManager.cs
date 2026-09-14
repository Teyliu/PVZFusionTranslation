using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200061E RID: 1566
[Token(Token = "0x200061E")]
public class SingleBuffManager : MonoBehaviour
{
	// Token: 0x06001D82 RID: 7554 RVA: 0x0009D014 File Offset: 0x0009B214
	[Token(Token = "0x6001D82")]
	[Address(RVA = "0x577880", Offset = "0x575E80", VA = "0x180577880")]
	private void Awake()
	{
		SingleBuffManager.Instance = this;
	}

	// Token: 0x06001D83 RID: 7555 RVA: 0x0009D028 File Offset: 0x0009B228
	[Token(Token = "0x6001D83")]
	[Address(RVA = "0x5771C0", Offset = "0x5757C0", VA = "0x1805771C0")]
	public void AddNewBuff(SingleBuffManager.BuffType type, Board board, Vector2 postion, int row)
	{
		if (type <= SingleBuffManager.BuffType.BigStar)
		{
			int num = 0;
			int i = 0;
			CreatePlant instance = CreatePlant.Instance;
			if (i < board.rowNum)
			{
				CreatePlant instance2 = CreatePlant.Instance;
				i++;
			}
			while (i >= board.rowNum)
			{
			}
			CreateZombie instance3 = CreateZombie.Instance;
			i++;
			CreateItem instance4 = CreateItem.Instance;
			CreateItem instance5 = CreateItem.Instance;
			CreateItem instance6 = CreateItem.Instance;
			CreateItem instance7 = CreateItem.Instance;
			CreatePlant instance8 = CreatePlant.Instance;
			Transform transform = global::UnityEngine.Object.Instantiate<GameObject>(GameAPP.itemPrefab[10]).transform;
			Transform transform2 = board.transform;
			transform.parentInternal = transform2;
			int num2 = 0;
			if ("大荒星陨！" != 0)
			{
				InGameText instance9 = InGameText.Instance;
			}
			if (num2 <= num)
			{
				return;
			}
		}
		SingleBuffManager.SingleBuff singleBuff = new SingleBuffManager.SingleBuff();
		singleBuff.buffType = type;
		List<SingleBuffManager.SingleBuff> list = this.singleBuffs;
		int size = list._size;
	}

	// Token: 0x06001D84 RID: 7556 RVA: 0x0009D110 File Offset: 0x0009B310
	[Token(Token = "0x6001D84")]
	[Address(RVA = "0x5778E0", Offset = "0x575EE0", VA = "0x1805778E0")]
	public static bool CheckBuff(SingleBuffManager.BuffType type)
	{
		SingleBuffManager instance = SingleBuffManager.Instance;
		int num = 0;
		if (instance != num)
		{
			int size = SingleBuffManager.Instance.singleBuffs._size;
			if (size > 0)
			{
				if (SingleBuffManager.Instance.singleBuffs[size].buffType != type)
				{
				}
				return true;
			}
		}
		throw new NullReferenceException();
	}

	// Token: 0x06001D85 RID: 7557 RVA: 0x0009D16C File Offset: 0x0009B36C
	[Token(Token = "0x6001D85")]
	[Address(RVA = "0x5779F0", Offset = "0x575FF0", VA = "0x1805779F0")]
	private void Update()
	{
		int size = this.singleBuffs._size;
		int num = size - 1;
		if (size > 0)
		{
			int num2 = 0;
			SingleBuffManager.SingleBuff singleBuff = this.singleBuffs[num];
			float timer = singleBuff.timer;
			float deltaTime = Time.deltaTime;
			List<SingleBuffManager.SingleBuff> list = this.singleBuffs;
			singleBuff.timer = timer;
			SingleBuffManager.SingleBuff singleBuff2 = list[num];
			if (num2 > (int)singleBuff2.timer)
			{
				this.singleBuffs.RemoveAt(num);
			}
		}
	}

	// Token: 0x06001D86 RID: 7558 RVA: 0x0009D1E4 File Offset: 0x0009B3E4
	[Token(Token = "0x6001D86")]
	[Address(RVA = "0x577B00", Offset = "0x576100", VA = "0x180577B00")]
	public SingleBuffManager()
	{
		List<SingleBuffManager.SingleBuff> list = new List();
		this.singleBuffs = list;
		base..ctor();
	}

	// Token: 0x04001000 RID: 4096
	[Token(Token = "0x4001000")]
	public static SingleBuffManager Instance;

	// Token: 0x04001001 RID: 4097
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001001")]
	public List<SingleBuffManager.SingleBuff> singleBuffs;

	// Token: 0x0200061F RID: 1567
	[Token(Token = "0x200061F")]
	public enum BuffType
	{
		// Token: 0x04001003 RID: 4099
		[Token(Token = "0x4001003")]
		Damage,
		// Token: 0x04001004 RID: 4100
		[Token(Token = "0x4001004")]
		IceShroom,
		// Token: 0x04001005 RID: 4101
		[Token(Token = "0x4001005")]
		Jalapeno,
		// Token: 0x04001006 RID: 4102
		[Token(Token = "0x4001006")]
		StealHealth,
		// Token: 0x04001007 RID: 4103
		[Token(Token = "0x4001007")]
		ZombieSupport,
		// Token: 0x04001008 RID: 4104
		[Token(Token = "0x4001008")]
		SunSupport,
		// Token: 0x04001009 RID: 4105
		[Token(Token = "0x4001009")]
		WallNut,
		// Token: 0x0400100A RID: 4106
		[Token(Token = "0x400100A")]
		BigStar
	}

	// Token: 0x02000620 RID: 1568
	[Token(Token = "0x2000620")]
	public class SingleBuff
	{
		// Token: 0x06001D87 RID: 7559 RVA: 0x0009D204 File Offset: 0x0009B404
		[Token(Token = "0x6001D87")]
		[Address(RVA = "0x577B80", Offset = "0x576180", VA = "0x180577B80")]
		public void OnUpdate()
		{
			float num = this.timer;
			float deltaTime = Time.deltaTime;
			this.timer = num;
		}

		// Token: 0x06001D88 RID: 7560 RVA: 0x0009D228 File Offset: 0x0009B428
		[Token(Token = "0x6001D88")]
		[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
		public SingleBuff()
		{
		}

		// Token: 0x0400100B RID: 4107
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x400100B")]
		public SingleBuffManager.BuffType buffType;

		// Token: 0x0400100C RID: 4108
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x400100C")]
		public float timer;
	}
}
