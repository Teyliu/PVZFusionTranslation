using System;
using System.Collections;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020009A0 RID: 2464
[Token(Token = "0x20009A0")]
public class Synergy_寰宇 : BaseSynergyData
{
	// Token: 0x060032DE RID: 13022 RVA: 0x0010A6EC File Offset: 0x001088EC
	[Token(Token = "0x60032DE")]
	[Address(RVA = "0x3FA3D0", Offset = "0x3F89D0", VA = "0x1803FA3D0", Slot = "6")]
	public override SynergyType GetSynergyType()
	{
		return SynergyType.寰宇;
	}

	// Token: 0x060032DF RID: 13023 RVA: 0x0010A6FC File Offset: 0x001088FC
	[Token(Token = "0x60032DF")]
	[Address(RVA = "0x758A80", Offset = "0x757080", VA = "0x180758A80", Slot = "8")]
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

	// Token: 0x060032E0 RID: 13024 RVA: 0x0010A840 File Offset: 0x00108A40
	[Token(Token = "0x60032E0")]
	[Address(RVA = "0x758E30", Offset = "0x757430", VA = "0x180758E30", Slot = "4")]
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

	// Token: 0x060032E1 RID: 13025 RVA: 0x0010A8D4 File Offset: 0x00108AD4
	[Token(Token = "0x60032E1")]
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

	// Token: 0x060032E2 RID: 13026 RVA: 0x0010A904 File Offset: 0x00108B04
	[Token(Token = "0x60032E2")]
	[Address(RVA = "0x758F50", Offset = "0x757550", VA = "0x180758F50")]
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

	// Token: 0x060032E3 RID: 13027 RVA: 0x0010A940 File Offset: 0x00108B40
	[Token(Token = "0x60032E3")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public Synergy_寰宇()
	{
		int num = 0;
		base.OnBoardStart(num);
	}

	// Token: 0x04001D84 RID: 7556
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001D84")]
	private Coroutine coroutine;
}
