using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000964 RID: 2404
[Token(Token = "0x2000964")]
public class Synergy_寰宇 : BaseSynergyData
{
	// Token: 0x060031AB RID: 12715 RVA: 0x0010596C File Offset: 0x00103B6C
	[Token(Token = "0x60031AB")]
	[Address(RVA = "0x3AE560", Offset = "0x3ACB60", VA = "0x1803AE560", Slot = "6")]
	public override SynergyType GetSynergyType()
	{
		return SynergyType.寰宇;
	}

	// Token: 0x060031AC RID: 12716 RVA: 0x0010597C File Offset: 0x00103B7C
	[Token(Token = "0x60031AC")]
	[Address(RVA = "0x6F36F0", Offset = "0x6F1CF0", VA = "0x1806F36F0", Slot = "8")]
	public override List<SynergyLevelData> GetAllData()
	{
		List<SynergyLevelData> list = new List();
		SynergyLevelData synergyLevelData = new SynergyLevelData();
		synergyLevelData.<ActiveCount>k__BackingField = (int)((ulong)2L);
		synergyLevelData.<Value>k__BackingField = 1f;
		synergyLevelData.<Value2>k__BackingField = 0.4f;
		synergyLevelData.<Description>k__BackingField = "每30秒召唤流星造成100%基础伤害，并为植物增加40%攻击力，羁绊队员获得双倍，最多叠加1层";
		int size = list._size;
		list._size = synergyLevelData;
		synergyLevelData.<Value>k__BackingField = synergyLevelData;
		SynergyLevelData synergyLevelData2 = new SynergyLevelData();
		synergyLevelData2.<ActiveCount>k__BackingField = (int)((ulong)3L);
		synergyLevelData2.<Value>k__BackingField = 2f;
		synergyLevelData2.<Value2>k__BackingField = 0.6f;
		synergyLevelData2.<Description>k__BackingField = "200%基础伤害，60%攻击力，2层";
		int size2 = list._size;
		list._size = synergyLevelData2;
		synergyLevelData2.<Value>k__BackingField = synergyLevelData2;
		SynergyLevelData synergyLevelData3 = new SynergyLevelData();
		synergyLevelData3.<ActiveCount>k__BackingField = (int)((ulong)5L);
		synergyLevelData3.<Value>k__BackingField = 4f;
		synergyLevelData3.<Value2>k__BackingField = 0.8f;
		synergyLevelData3.<Description>k__BackingField = "400%基础伤害，80%攻击力，3层";
		int size3 = list._size;
		list._size = synergyLevelData3;
		synergyLevelData3.<Value>k__BackingField = synergyLevelData3;
		SynergyLevelData synergyLevelData4 = new SynergyLevelData();
		synergyLevelData4.<ActiveCount>k__BackingField = (int)((ulong)7L);
		synergyLevelData4.<Value>k__BackingField = 8f;
		synergyLevelData4.<Value2>k__BackingField = 1.2f;
		synergyLevelData4.<Description>k__BackingField = "800%基础伤害，120%攻击力，4层";
		int size4 = list._size;
		return list;
	}

	// Token: 0x060031AD RID: 12717 RVA: 0x00105AC0 File Offset: 0x00103CC0
	[Token(Token = "0x60031AD")]
	[Address(RVA = "0x6F3AA0", Offset = "0x6F20A0", VA = "0x1806F3AA0", Slot = "4")]
	public override void OnBoardStart(Board board)
	{
		SynergyLevelData data = base.GetData();
		if (this.coroutine != (ulong)0L)
		{
			Coroutine coroutine = this.coroutine;
			board.StopCoroutine(coroutine);
		}
		int num = data.<ActiveCount>k__BackingField;
		float <Value>k__BackingField = data.<Value>k__BackingField;
		float <Value2>k__BackingField = data.<Value2>k__BackingField;
		Synergy_寰宇.<Star>d__5 <Star>d__;
		<Star>d__.System.IDisposable.Dispose();
		<Star>d__.<>1__state = (int)((ulong)0L);
		<Star>d__.<>4__this = this;
		<Star>d__.starDamage = <Value>k__BackingField;
		num -= this;
		<Star>d__.plantDamage = <Value2>k__BackingField;
		<Star>d__.addCount = num;
		Coroutine coroutine2 = board.StartCoroutine(<Star>d__);
		this.coroutine = coroutine2;
		throw new NullReferenceException();
	}

	// Token: 0x060031AE RID: 12718 RVA: 0x00105B54 File Offset: 0x00103D54
	[Token(Token = "0x60031AE")]
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

	// Token: 0x060031AF RID: 12719 RVA: 0x00105B84 File Offset: 0x00103D84
	[Token(Token = "0x60031AF")]
	[Address(RVA = "0x6F3BC0", Offset = "0x6F21C0", VA = "0x1806F3BC0")]
	private IEnumerator Star(float starDamage, float plantDamage, int addCount)
	{
		Synergy_寰宇.<Star>d__5 <Star>d__;
		<Star>d__.System.IDisposable.Dispose();
		<Star>d__.<>1__state = (int)((ulong)0L);
		<Star>d__.<>4__this = this;
		<Star>d__.starDamage = starDamage;
		<Star>d__.plantDamage = plantDamage;
		<Star>d__.addCount = addCount;
		return null;
	}

	// Token: 0x060031B0 RID: 12720 RVA: 0x00105BC0 File Offset: 0x00103DC0
	[Token(Token = "0x60031B0")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public Synergy_寰宇()
	{
		int num = 0;
		base.OnBoardStart(num);
	}

	// Token: 0x04001C94 RID: 7316
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001C94")]
	private Coroutine coroutine;
}
