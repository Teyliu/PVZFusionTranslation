using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020003A6 RID: 934
[Token(Token = "0x20003A6")]
public class GoldHypnoDoom : Plant
{
	// Token: 0x06001121 RID: 4385 RVA: 0x00061290 File Offset: 0x0005F490
	[Token(Token = "0x6001121")]
	[Address(RVA = "0x4812D0", Offset = "0x47F8D0", VA = "0x1804812D0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 1.5f;
	}

	// Token: 0x06001122 RID: 4386 RVA: 0x000612B0 File Offset: 0x0005F4B0
	[Token(Token = "0x6001122")]
	[Address(RVA = "0x48A990", Offset = "0x488F90", VA = "0x18048A990", Slot = "39")]
	protected override void AttributeEvent()
	{
		int num = 0;
		base.OnFixedUpdate();
		Board board = this.board;
		if ((board.goldHypnoAward ? 1 : 0) != num)
		{
			InGameText instance = InGameText.Instance;
			return;
		}
		if (!global::Lawnf.TravelCurse())
		{
			int num2 = 0;
			base.Die((Plant.DieReason)num2);
			List<ZombieType> list = new List();
			int size = list._size;
			int size2 = list._size;
			int size3 = list._size;
			int size4 = list._size;
			int size5 = list._size;
			int size6 = list._size;
			int size7 = list._size;
			int size8 = list._size;
			int size9 = list._size;
			int size10 = list._size;
			int size11 = list._size;
			int size12 = list._size;
			this.board.goldHypnoAward = true;
			int sceneType = (int)this.board.sceneType;
			bool flag;
			if (!flag)
			{
				SceneType sceneType2 = this.board.sceneType;
				if (sceneType2 <= SceneType.SnowPool_night)
				{
				}
				if (sceneType2 == SceneType.NightSnow)
				{
				}
				int num3 = list._size;
				num3 = global::UnityEngine.Random.Range(0, num3);
				ZombieType zombieType = list[num3];
			}
			return;
		}
		InGameText instance2 = InGameText.Instance;
		int num4 = 0;
		base.Die((Plant.DieReason)num4);
		Transform axis = this.axis;
	}

	// Token: 0x06001123 RID: 4387 RVA: 0x000613E4 File Offset: 0x0005F5E4
	[Token(Token = "0x6001123")]
	[Address(RVA = "0x48B100", Offset = "0x489700", VA = "0x18048B100")]
	private void SummonZombie(ZombieType bossType)
	{
		Transform axis = this.axis;
		Vector3 vector;
		float z = vector.z;
		int num = 0;
		Transform axis2 = this.axis;
		CreateZombie instance = CreateZombie.Instance;
		int num2 = 0;
		Zombie zombie;
		bool flag = zombie != num2;
		if (flag)
		{
			zombie.awardLevel = (int)((ulong)2L);
			this.board.SetHealthInTravel(zombie);
		}
		if (flag <= true)
		{
		}
		Board board = this.board;
		if (num < board.rowNum)
		{
			CreateZombie instance2 = CreateZombie.Instance;
			int num3 = 0;
			Zombie zombie2;
			if (zombie2 != num3)
			{
				zombie2.awardLevel = (int)((ulong)1L);
				this.board.SetHealthInTravel(zombie2);
			}
			Board board2 = this.board;
			num++;
		}
	}

	// Token: 0x06001124 RID: 4388 RVA: 0x00061498 File Offset: 0x0005F698
	[Token(Token = "0x6001124")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public GoldHypnoDoom()
	{
	}
}
