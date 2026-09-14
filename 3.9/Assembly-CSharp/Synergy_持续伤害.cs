using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020009AA RID: 2474
[Token(Token = "0x20009AA")]
public class Synergy_持续伤害 : BaseSynergyData
{
	// Token: 0x0600330F RID: 13071 RVA: 0x0010BA30 File Offset: 0x00109C30
	[Token(Token = "0x600330F")]
	[Address(RVA = "0x715410", Offset = "0x713A10", VA = "0x180715410", Slot = "6")]
	public override SynergyType GetSynergyType()
	{
		return SynergyType.持续伤害;
	}

	// Token: 0x06003310 RID: 13072 RVA: 0x0010BA40 File Offset: 0x00109C40
	[Token(Token = "0x6003310")]
	[Address(RVA = "0x759D40", Offset = "0x758340", VA = "0x180759D40", Slot = "8")]
	public override List<SynergyLevelData> GetAllData()
	{
		List<SynergyLevelData> list = new List();
		SynergyLevelData synergyLevelData = new SynergyLevelData();
		synergyLevelData.<ActiveCount>k__BackingField = (int)((ulong)2L);
		synergyLevelData.<Value>k__BackingField = 0.5f;
		synergyLevelData.<Description>k__BackingField = "羁绊队员获得20%独立伤害增幅，僵尸每有一种状态异常，每秒受到50%基础伤害";
		int size = list._size;
		list._size = synergyLevelData;
		synergyLevelData.<Value>k__BackingField = synergyLevelData;
		SynergyLevelData synergyLevelData2 = new SynergyLevelData();
		synergyLevelData2.<ActiveCount>k__BackingField = (int)((ulong)3L);
		synergyLevelData2.<Value>k__BackingField = 1f;
		synergyLevelData2.<Description>k__BackingField = "40%独立伤害增幅，100%基础伤害";
		int size2 = list._size;
		list._size = synergyLevelData2;
		synergyLevelData2.<Value>k__BackingField = synergyLevelData2;
		SynergyLevelData synergyLevelData3 = new SynergyLevelData();
		synergyLevelData3.<ActiveCount>k__BackingField = (int)((ulong)5L);
		synergyLevelData3.<Value>k__BackingField = 2f;
		synergyLevelData3.<Description>k__BackingField = "100%独立伤害增幅，200%基础伤害";
		int size3 = list._size;
		return list;
	}

	// Token: 0x06003311 RID: 13073 RVA: 0x0010BB14 File Offset: 0x00109D14
	[Token(Token = "0x6003311")]
	[Address(RVA = "0x759FE0", Offset = "0x7585E0", VA = "0x180759FE0", Slot = "4")]
	public override void OnBoardStart(Board board)
	{
		ulong num3;
		do
		{
			int num = 0;
			SynergyLevelData data = base.GetData();
			if (this.coroutine != (ulong)0L)
			{
				Coroutine coroutine = this.coroutine;
				board.StopCoroutine(coroutine);
			}
			float <Value>k__BackingField = data.<Value>k__BackingField;
			int basicDamage = TravelMgr.Instance.BasicDamage;
			float num2 = <Value>k__BackingField * 0.5f;
			Synergy_持续伤害.<DamageZombies>d__4 <DamageZombies>d__;
			<DamageZombies>d__.<>1__state = (int)((ulong)0L);
			<DamageZombies>d__.damage = num2;
			Coroutine coroutine2 = board.StartCoroutine(<DamageZombies>d__);
			this.coroutine = coroutine2;
			HashSet<PlantType> plantsContained = this.plantsContained;
			bool flag;
			if (flag)
			{
				TravelData data2 = TravelMgr.Instance.data;
				float <Value>k__BackingField2 = data.<Value>k__BackingField;
				data2.AddDamage((PlantType)num, <Value>k__BackingField2);
			}
		}
		while (num3 != (ulong)0L);
	}

	// Token: 0x06003312 RID: 13074 RVA: 0x0010BBD0 File Offset: 0x00109DD0
	[Token(Token = "0x6003312")]
	[Address(RVA = "0x759CE0", Offset = "0x7582E0", VA = "0x180759CE0")]
	public IEnumerator DamageZombies(float damage)
	{
		Synergy_持续伤害.<DamageZombies>d__4 <DamageZombies>d__;
		<DamageZombies>d__.System.IDisposable.Dispose();
		<DamageZombies>d__.damage = damage;
		<DamageZombies>d__.<>1__state = (int)((ulong)0L);
		return null;
	}

	// Token: 0x06003313 RID: 13075 RVA: 0x0010BBF4 File Offset: 0x00109DF4
	[Token(Token = "0x6003313")]
	[Address(RVA = "0x758DF0", Offset = "0x7573F0", VA = "0x180758DF0", Slot = "7")]
	public override void OnBoardEnd(Board board)
	{
		if (this.coroutine != (ulong)0L)
		{
			Coroutine coroutine = this.coroutine;
			board.StopCoroutine(coroutine);
			return;
		}
	}

	// Token: 0x06003314 RID: 13076 RVA: 0x0010BC24 File Offset: 0x00109E24
	[Token(Token = "0x6003314")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public Synergy_持续伤害()
	{
		int num = 0;
		base.OnBoardStart(num);
	}

	// Token: 0x04001D97 RID: 7575
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001D97")]
	private Coroutine coroutine;
}
