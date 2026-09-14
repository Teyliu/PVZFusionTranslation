using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005E9 RID: 1513
[Token(Token = "0x20005E9")]
public class SingleBuffManager : MonoBehaviour
{
	// Token: 0x06001C83 RID: 7299 RVA: 0x000984AC File Offset: 0x000966AC
	[Token(Token = "0x6001C83")]
	[Address(RVA = "0x50A7F0", Offset = "0x508DF0", VA = "0x18050A7F0")]
	private void Awake()
	{
		SingleBuffManager.Instance = this;
	}

	// Token: 0x06001C84 RID: 7300 RVA: 0x000984C0 File Offset: 0x000966C0
	[Token(Token = "0x6001C84")]
	[Address(RVA = "0x50A140", Offset = "0x508740", VA = "0x18050A140")]
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
				int num3 = 0;
				instance9.ShowText("大荒星陨！", 5f, num3 != 0);
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

	// Token: 0x06001C85 RID: 7301 RVA: 0x000985C0 File Offset: 0x000967C0
	[Token(Token = "0x6001C85")]
	[Address(RVA = "0x50A850", Offset = "0x508E50", VA = "0x18050A850")]
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

	// Token: 0x06001C86 RID: 7302 RVA: 0x0009861C File Offset: 0x0009681C
	[Token(Token = "0x6001C86")]
	[Address(RVA = "0x50A960", Offset = "0x508F60", VA = "0x18050A960")]
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

	// Token: 0x06001C87 RID: 7303 RVA: 0x00098694 File Offset: 0x00096894
	[Token(Token = "0x6001C87")]
	[Address(RVA = "0x50AA70", Offset = "0x509070", VA = "0x18050AA70")]
	public SingleBuffManager()
	{
		List<SingleBuffManager.SingleBuff> list = new List();
		this.singleBuffs = list;
		base..ctor();
	}

	// Token: 0x04000F38 RID: 3896
	[Token(Token = "0x4000F38")]
	public static SingleBuffManager Instance;

	// Token: 0x04000F39 RID: 3897
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000F39")]
	public List<SingleBuffManager.SingleBuff> singleBuffs;

	// Token: 0x020005EA RID: 1514
	[Token(Token = "0x20005EA")]
	public enum BuffType
	{
		// Token: 0x04000F3B RID: 3899
		[Token(Token = "0x4000F3B")]
		Damage,
		// Token: 0x04000F3C RID: 3900
		[Token(Token = "0x4000F3C")]
		IceShroom,
		// Token: 0x04000F3D RID: 3901
		[Token(Token = "0x4000F3D")]
		Jalapeno,
		// Token: 0x04000F3E RID: 3902
		[Token(Token = "0x4000F3E")]
		StealHealth,
		// Token: 0x04000F3F RID: 3903
		[Token(Token = "0x4000F3F")]
		ZombieSupport,
		// Token: 0x04000F40 RID: 3904
		[Token(Token = "0x4000F40")]
		SunSupport,
		// Token: 0x04000F41 RID: 3905
		[Token(Token = "0x4000F41")]
		WallNut,
		// Token: 0x04000F42 RID: 3906
		[Token(Token = "0x4000F42")]
		BigStar
	}

	// Token: 0x020005EB RID: 1515
	[Token(Token = "0x20005EB")]
	public class SingleBuff
	{
		// Token: 0x06001C88 RID: 7304 RVA: 0x000986B4 File Offset: 0x000968B4
		[Token(Token = "0x6001C88")]
		[Address(RVA = "0x50AAF0", Offset = "0x5090F0", VA = "0x18050AAF0")]
		public void OnUpdate()
		{
			float num = this.timer;
			float deltaTime = Time.deltaTime;
			this.timer = num;
		}

		// Token: 0x06001C89 RID: 7305 RVA: 0x000986D8 File Offset: 0x000968D8
		[Token(Token = "0x6001C89")]
		[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
		public SingleBuff()
		{
		}

		// Token: 0x04000F43 RID: 3907
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000F43")]
		public SingleBuffManager.BuffType buffType;

		// Token: 0x04000F44 RID: 3908
		[FieldOffset(Offset = "0x14")]
		[Token(Token = "0x4000F44")]
		public float timer;
	}
}
