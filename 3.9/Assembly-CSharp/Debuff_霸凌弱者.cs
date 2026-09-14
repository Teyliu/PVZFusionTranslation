using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000032 RID: 50
[Token(Token = "0x2000032")]
public class Debuff_霸凌弱者 : BaseDebuff
{
	// Token: 0x1700003B RID: 59
	// (get) Token: 0x060000D9 RID: 217 RVA: 0x00004ACC File Offset: 0x00002CCC
	[Token(Token = "0x1700003B")]
	public override TravelDebuff BuffType
	{
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x3F3460", Offset = "0x3F1A60", VA = "0x1803F3460", Slot = "12")]
		get
		{
			return TravelDebuff.霸凌弱者;
		}
	}

	// Token: 0x1700003C RID: 60
	// (get) Token: 0x060000DA RID: 218 RVA: 0x00004AE0 File Offset: 0x00002CE0
	[Token(Token = "0x1700003C")]
	public override string Description
	{
		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x3F3470", Offset = "0x3F1A70", VA = "0x1803F3470", Slot = "13")]
		get
		{
			return "霸凌弱者：植物因血量归零死亡时爆炸，对附近植物自身最大生命值的伤害";
		}
	}

	// Token: 0x060000DB RID: 219 RVA: 0x00004AF4 File Offset: 0x00002CF4
	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x3F2BE0", Offset = "0x3F11E0", VA = "0x1803F2BE0", Slot = "17")]
	public override void OnSelect(Board board)
	{
	}

	// Token: 0x060000DC RID: 220 RVA: 0x00004B04 File Offset: 0x00002D04
	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x3F3250", Offset = "0x3F1850", VA = "0x1803F3250", Slot = "15")]
	public override void OnBoardStart(Board board)
	{
		int num = 0;
		Action<object> action;
		EventManager.AddListener_obj((GameEvent)((uint)1), action, num != 0);
	}

	// Token: 0x060000DD RID: 221 RVA: 0x00004B20 File Offset: 0x00002D20
	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x3F32F0", Offset = "0x3F18F0", VA = "0x1803F32F0")]
	private void OnPlantDeath(object obj)
	{
		Vector3 vector;
		float z = vector.z;
	}

	// Token: 0x060000DE RID: 222 RVA: 0x00004B40 File Offset: 0x00002D40
	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x3EB700", Offset = "0x3E9D00", VA = "0x1803EB700")]
	public Debuff_霸凌弱者()
	{
	}
}
