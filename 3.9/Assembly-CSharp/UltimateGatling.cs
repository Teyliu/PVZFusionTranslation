using System;
using System.Collections;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005DD RID: 1501
[Token(Token = "0x20005DD")]
public class UltimateGatling : SuperCherryShooter
{
	// Token: 0x06001BE3 RID: 7139 RVA: 0x00094FCC File Offset: 0x000931CC
	[Token(Token = "0x6001BE3")]
	[Address(RVA = "0x4DE9D0", Offset = "0x4DCFD0", VA = "0x1804DE9D0", Slot = "45")]
	protected override void UpdateAttackCountDown()
	{
		base.UpdateAttackCountDown();
		if (global::Lawnf.TravelUltimate((UltiBuff)((uint)3)))
		{
			float thePlantAttackCountDown = this.thePlantAttackCountDown;
			float deltaTime = Time.deltaTime;
			this.thePlantAttackCountDown = thePlantAttackCountDown;
		}
	}

	// Token: 0x06001BE4 RID: 7140 RVA: 0x00095000 File Offset: 0x00093200
	[Token(Token = "0x6001BE4")]
	[Address(RVA = "0x3F1E60", Offset = "0x3F0460", VA = "0x1803F1E60", Slot = "56")]
	protected override bool OnStarUp()
	{
		return true;
	}

	// Token: 0x06001BE5 RID: 7141 RVA: 0x00095010 File Offset: 0x00093210
	[Token(Token = "0x6001BE5")]
	[Address(RVA = "0x564A40", Offset = "0x563040", VA = "0x180564A40")]
	private void CheatShoot()
	{
		UltimateGatling.<Shooting>d__3 <Shooting>d__;
		<Shooting>d__.System.IDisposable.Dispose();
		<Shooting>d__.<>1__state = (int)((ulong)0L);
		<Shooting>d__.<>4__this = this;
		Coroutine coroutine = base.StartCoroutine(<Shooting>d__);
		GameAPP.PlaySound(global::UnityEngine.Random.Range(3, 5), 0.5f, 1f);
	}

	// Token: 0x06001BE6 RID: 7142 RVA: 0x00095054 File Offset: 0x00093254
	[Token(Token = "0x6001BE6")]
	[Address(RVA = "0x5652F0", Offset = "0x5638F0", VA = "0x1805652F0")]
	private IEnumerator Shooting()
	{
		UltimateGatling.<Shooting>d__3 <Shooting>d__;
		<Shooting>d__.System.IDisposable.Dispose();
		<Shooting>d__.<>1__state = (int)((ulong)0L);
		<Shooting>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06001BE7 RID: 7143 RVA: 0x00095078 File Offset: 0x00093278
	[Token(Token = "0x6001BE7")]
	[Address(RVA = "0x564D40", Offset = "0x563340", VA = "0x180564D40", Slot = "68")]
	protected override Bullet Shoot1()
	{
		UltimateGatling.<Shooting>d__3 <Shooting>d__;
		<Shooting>d__.System.IDisposable.Dispose();
		int num = 0;
		<Shooting>d__.<>4__this = this;
		<Shooting>d__.<>1__state = num;
		Coroutine coroutine = base.StartCoroutine(<Shooting>d__);
		uint num2;
		uint num3;
		GameAPP.PlaySound(global::UnityEngine.Random.Range((int)num2, (int)num3), 0.5f, 1f);
		Bullet bullet = base.Shoot1();
		bool flag;
		if (flag)
		{
			CreateBullet instance = CreateBullet.Instance;
			Transform shoot = this.shoot;
			Transform shoot2 = this.shoot;
			CreateBullet instance2 = CreateBullet.Instance;
			Transform shoot3 = this.shoot;
			Transform shoot4 = this.shoot;
			int attackDamage = this.attackDamage;
			Bullet bullet2;
			bullet2.Damage = attackDamage;
			PlantType thePlantType = this.thePlantType;
			bullet2.fromType = thePlantType;
			int attackDamage2 = this.attackDamage;
			Bullet bullet3;
			bullet3.Damage = attackDamage2;
			bullet3.theExistTime = 0.5f;
			PlantType thePlantType2 = this.thePlantType;
			bullet3.fromType = thePlantType2;
		}
		bool flag2;
		if (!flag2)
		{
			bool flag3;
			if (!flag3)
			{
				goto IL_00E2;
			}
			uint num4;
			bullet.rogueStatus = (int)num4;
		}
		uint num5;
		bullet.rogueStatus = (int)num5;
		IL_00E2:
		Transform transform = bullet.transform;
		Vector3 vector;
		float z = vector.z;
		uint num6 = num5 + 1U;
		Bullet bullet4 = base.Shoot1();
		Transform transform2 = bullet4.transform;
		Vector3 vector2;
		float z2 = vector2.z;
		PlantType thePlantType3 = this.thePlantType;
		bullet4.fromType = thePlantType3;
		Transform transform3 = bullet4.transform;
		Vector3 vector3;
		float z3 = vector3.z;
		num5 += (uint)1;
		PlantType thePlantType4 = this.thePlantType;
		bullet.fromType = thePlantType4;
		bool flag4;
		if (flag4)
		{
			this.CurseShoot();
		}
		return bullet;
	}

	// Token: 0x06001BE8 RID: 7144 RVA: 0x000951EC File Offset: 0x000933EC
	[Token(Token = "0x6001BE8")]
	[Address(RVA = "0x564B10", Offset = "0x563110", VA = "0x180564B10")]
	private void CurseShoot()
	{
		int num = 0;
		uint num2;
		float boxXFromColumn = global::Lawnf.GetBoxXFromColumn((int)num2);
		Dictionary<PlantType, long> reportDic = this.board.damageReporter.ReportDic;
		PlantType thePlantType = this.thePlantType;
		bool flag = reportDic.TryGetValue(thePlantType, num);
		long num3 = this.board.damageReporter.totalDamage;
		num3 -= (long)num;
		num3 = num3.MultiplyPercent(0.0001f);
		int num4 = num3.ToInt();
		Board board = this.board;
		if (num < board.rowNum)
		{
			CreateBullet instance = CreateBullet.Instance;
			float landY = Mouse.Instance.GetLandY(boxXFromColumn, num);
			PlantType thePlantType2 = this.thePlantType;
			Bullet bullet;
			bullet.fromType = thePlantType2;
			bullet.Damage = num4;
			Board board2 = this.board;
			num++;
		}
	}

	// Token: 0x06001BE9 RID: 7145 RVA: 0x000952AC File Offset: 0x000934AC
	[Token(Token = "0x6001BE9")]
	[Address(RVA = "0x469910", Offset = "0x467F10", VA = "0x180469910")]
	public UltimateGatling()
	{
	}
}
