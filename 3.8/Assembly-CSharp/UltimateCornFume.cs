using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using Cysharp.Threading.Tasks;
using UnityEngine;

// Token: 0x020005A1 RID: 1441
[Token(Token = "0x20005A1")]
public class UltimateCornFume : CornFume
{
	// Token: 0x06001AC4 RID: 6852 RVA: 0x0008F9B0 File Offset: 0x0008DBB0
	[Token(Token = "0x6001AC4")]
	[Address(RVA = "0x4013E0", Offset = "0x3FF9E0", VA = "0x1804013E0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 1f;
	}

	// Token: 0x06001AC5 RID: 6853 RVA: 0x0008F9D0 File Offset: 0x0008DBD0
	[Token(Token = "0x6001AC5")]
	[Address(RVA = "0x4FB450", Offset = "0x4F9A50", VA = "0x1804FB450", Slot = "40")]
	protected override void AttributeEvent()
	{
		ulong num3;
		do
		{
			int thePlantRow = this.thePlantRow;
			uint num;
			List<Plant> rangePlants = Lawnf.GetRangePlants(this.thePlantColumn, thePlantRow, (int)num);
			bool flag;
			if (flag)
			{
				int thePlantColumn = this.thePlantColumn;
				int thePlantRow2 = this.thePlantRow;
				uint num2;
				num2 -= (uint)thePlantRow2;
				num2 -= (uint)thePlantColumn;
			}
		}
		while (num3 != (ulong)0L);
	}

	// Token: 0x06001AC6 RID: 6854 RVA: 0x0008FA34 File Offset: 0x0008DC34
	[Token(Token = "0x6001AC6")]
	[Address(RVA = "0x4FB990", Offset = "0x4F9F90", VA = "0x1804FB990", Slot = "62")]
	public override bool OnClicked(Mouse mouse)
	{
		int num = this.count;
		List<Zombie> zombies = this.GetZombies();
		this.anim.SetTrigger("shoot");
		this.theStatus = (PlantStatus)((ulong)25L);
		return true;
	}

	// Token: 0x06001AC7 RID: 6855 RVA: 0x0008FA74 File Offset: 0x0008DC74
	[Token(Token = "0x6001AC7")]
	[Address(RVA = "0x4FAE40", Offset = "0x4F9440", VA = "0x1804FAE40", Slot = "69")]
	protected override void AnimShoot()
	{
		int num;
		do
		{
			List<Zombie> zombies = this.GetZombies();
			num = 0;
			bool flag;
			if (flag)
			{
				CreateBullet instance = CreateBullet.Instance;
				Transform shoot = this.shoot;
				Transform shoot2 = this.shoot;
				int attackDamage = this.attackDamage;
				Bullet bullet;
				bullet.Damage = attackDamage;
				Transform shoot3 = this.shoot;
				float[] array;
				float num2 = array[0];
				bullet.Vx = num2;
				float num3 = array[1];
				bullet.Vy = num3;
				float num4 = array[1];
				bullet.detaVy = num4;
				PlantType thePlantType = this.thePlantType;
				bullet.fromType = thePlantType;
				bullet.theStatus = (BulletStatus)((ulong)9L);
				int attributeCount = this.attributeCount;
				this.attributeCount = attributeCount;
				this.attributeCount = num;
			}
		}
		while (num != 0);
		uint num5;
		GameAPP.PlaySound((int)num5, 0.5f, 1f);
		int num6 = 0;
		this.theStatus = (PlantStatus)num6;
		if (this.cancellationTokenSource != (ulong)0L)
		{
			this.cancellationTokenSource.Cancel();
			this.cancellationTokenSource.Dispose();
		}
		CancellationToken[] array2 = new CancellationToken[1];
		CancellationToken cancellationTokenOnDestroy = this.board.GetCancellationTokenOnDestroy();
		array2[0] = cancellationTokenOnDestroy;
		CancellationTokenSource cancellationTokenSource = CancellationTokenSource.CreateLinkedTokenSource(array2);
		this.cancellationTokenSource = cancellationTokenSource;
		CancellationTokenSource cancellationTokenSource2 = this.cancellationTokenSource;
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06001AC8 RID: 6856 RVA: 0x0008FC0C File Offset: 0x0008DE0C
	[Token(Token = "0x6001AC8")]
	[Address(RVA = "0x4FBAB0", Offset = "0x4FA0B0", VA = "0x1804FBAB0")]
	private void WantSpringShoot(List<Zombie> zombies, CancellationTokenSource cancel)
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06001AC9 RID: 6857 RVA: 0x0008FC30 File Offset: 0x0008DE30
	[Token(Token = "0x6001AC9")]
	[Address(RVA = "0x4FB6F0", Offset = "0x4F9CF0", VA = "0x1804FB6F0", Slot = "70")]
	protected override List<Zombie> GetZombies()
	{
		List<Zombie> list;
		ulong num;
		do
		{
			list = new List();
			List<Zombie> allZombies = Lawnf.GetAllZombies(false);
			bool flag;
			if (flag)
			{
				bool flag2;
				while (!flag2)
				{
				}
			}
		}
		while (num != (ulong)0L);
		return list;
	}

	// Token: 0x06001ACA RID: 6858 RVA: 0x0008FC80 File Offset: 0x0008DE80
	[Token(Token = "0x6001ACA")]
	[Address(RVA = "0x4FB8C0", Offset = "0x4F9EC0", VA = "0x1804FB8C0", Slot = "24")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x06001ACB RID: 6859 RVA: 0x0008FCA0 File Offset: 0x0008DEA0
	[Token(Token = "0x6001ACB")]
	[Address(RVA = "0x4FBBB0", Offset = "0x4FA1B0", VA = "0x1804FBBB0")]
	public UltimateCornFume()
	{
	}

	// Token: 0x04000E8F RID: 3727
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000E8F")]
	private readonly int count = (int)((ulong)100L);

	// Token: 0x04000E90 RID: 3728
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000E90")]
	private CancellationTokenSource cancellationTokenSource;
}
