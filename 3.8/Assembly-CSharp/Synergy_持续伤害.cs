using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200096E RID: 2414
[Token(Token = "0x200096E")]
public class Synergy_持续伤害 : BaseSynergyData
{
	// Token: 0x060031DC RID: 12764 RVA: 0x00106CAC File Offset: 0x00104EAC
	[Token(Token = "0x60031DC")]
	[Address(RVA = "0x69B2B0", Offset = "0x6998B0", VA = "0x18069B2B0", Slot = "6")]
	public override SynergyType GetSynergyType()
	{
		return SynergyType.持续伤害;
	}

	// Token: 0x060031DD RID: 12765 RVA: 0x00106CBC File Offset: 0x00104EBC
	[Token(Token = "0x60031DD")]
	[Address(RVA = "0x6F49B0", Offset = "0x6F2FB0", VA = "0x1806F49B0", Slot = "8")]
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

	// Token: 0x060031DE RID: 12766 RVA: 0x00106D90 File Offset: 0x00104F90
	[Token(Token = "0x60031DE")]
	[Address(RVA = "0x6F4C50", Offset = "0x6F3250", VA = "0x1806F4C50", Slot = "4")]
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

	// Token: 0x060031DF RID: 12767 RVA: 0x00106E4C File Offset: 0x0010504C
	[Token(Token = "0x60031DF")]
	[Address(RVA = "0x6F4950", Offset = "0x6F2F50", VA = "0x1806F4950")]
	public IEnumerator DamageZombies(float damage)
	{
		Synergy_持续伤害.<DamageZombies>d__4 <DamageZombies>d__;
		<DamageZombies>d__.System.IDisposable.Dispose();
		<DamageZombies>d__.damage = damage;
		<DamageZombies>d__.<>1__state = (int)((ulong)0L);
		return null;
	}

	// Token: 0x060031E0 RID: 12768 RVA: 0x00106E70 File Offset: 0x00105070
	[Token(Token = "0x60031E0")]
	[Address(RVA = "0x6F3A60", Offset = "0x6F2060", VA = "0x1806F3A60", Slot = "7")]
	public override void OnBoardEnd(Board board)
	{
		if (this.coroutine != (ulong)0L)
		{
			Coroutine coroutine = this.coroutine;
			board.StopCoroutine(coroutine);
			return;
		}
	}

	// Token: 0x060031E1 RID: 12769 RVA: 0x00106EA0 File Offset: 0x001050A0
	[Token(Token = "0x60031E1")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public Synergy_持续伤害()
	{
		int num = 0;
		base.OnBoardStart(num);
	}

	// Token: 0x04001CA7 RID: 7335
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001CA7")]
	private Coroutine coroutine;
}
