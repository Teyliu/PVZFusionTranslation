using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000393 RID: 915
[Token(Token = "0x2000393")]
public class GoldHypnoDoom : Plant
{
	// Token: 0x060010C7 RID: 4295 RVA: 0x0005FD44 File Offset: 0x0005DF44
	[Token(Token = "0x60010C7")]
	[Address(RVA = "0x4309E0", Offset = "0x42EFE0", VA = "0x1804309E0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 1.5f;
	}

	// Token: 0x060010C8 RID: 4296 RVA: 0x0005FD64 File Offset: 0x0005DF64
	[Token(Token = "0x60010C8")]
	[Address(RVA = "0x4370B0", Offset = "0x4356B0", VA = "0x1804370B0", Slot = "40")]
	protected override void AttributeEvent()
	{
		int num = 0;
		base.OnFixedUpdate();
		Board board = this.board;
		if ((board.goldHypnoAward ? 1 : 0) != num)
		{
			InGameText instance = InGameText.Instance;
			int num2 = 0;
			instance.ShowText("每轮只能使用一次", 5f, num2 != 0);
			return;
		}
		if (!global::Lawnf.TravelCurse())
		{
			int num3 = 0;
			base.Die((Plant.DieReason)num3);
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
				int num4 = list._size;
				num4 = global::UnityEngine.Random.Range(0, num4);
				ZombieType zombieType = list[num4];
			}
			return;
		}
		InGameText instance2 = InGameText.Instance;
		int num5 = 0;
		instance2.ShowText("诅咒模式禁用该植物", 5f, num5 != 0);
		int num6 = 0;
		base.Die((Plant.DieReason)num6);
		Transform axis = this.axis;
	}

	// Token: 0x060010C9 RID: 4297 RVA: 0x0005FEC4 File Offset: 0x0005E0C4
	[Token(Token = "0x60010C9")]
	[Address(RVA = "0x437800", Offset = "0x435E00", VA = "0x180437800")]
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

	// Token: 0x060010CA RID: 4298 RVA: 0x0005FF78 File Offset: 0x0005E178
	[Token(Token = "0x60010CA")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public GoldHypnoDoom()
	{
	}
}
