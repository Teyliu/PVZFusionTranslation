using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200002E RID: 46
[Token(Token = "0x200002E")]
public class Debuff_霸凌弱者 : BaseDebuff
{
	// Token: 0x1700002E RID: 46
	// (get) Token: 0x060000C2 RID: 194 RVA: 0x0000483C File Offset: 0x00002A3C
	[Token(Token = "0x1700002E")]
	public override TravelDebuff BuffType
	{
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x3A7670", Offset = "0x3A5C70", VA = "0x1803A7670", Slot = "12")]
		get
		{
			return TravelDebuff.霸凌弱者;
		}
	}

	// Token: 0x060000C3 RID: 195 RVA: 0x00004850 File Offset: 0x00002A50
	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x3A7430", Offset = "0x3A5A30", VA = "0x1803A7430", Slot = "13")]
	public override string GetDescription()
	{
		return "霸凌弱者：植物因血量归零死亡时爆炸，对附近植物自身最大生命值的伤害";
	}

	// Token: 0x060000C4 RID: 196 RVA: 0x00004864 File Offset: 0x00002A64
	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x3A6C80", Offset = "0x3A5280", VA = "0x1803A6C80", Slot = "17")]
	public override void OnSelect(Board board)
	{
	}

	// Token: 0x060000C5 RID: 197 RVA: 0x00004874 File Offset: 0x00002A74
	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x3A7460", Offset = "0x3A5A60", VA = "0x1803A7460", Slot = "15")]
	public override void OnBoardStart(Board board)
	{
		int num = 0;
		Action<object> action;
		EventManager.AddListener_obj((GameEvent)((uint)1), action, num != 0);
	}

	// Token: 0x060000C6 RID: 198 RVA: 0x00004890 File Offset: 0x00002A90
	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x3A7500", Offset = "0x3A5B00", VA = "0x1803A7500")]
	private void OnPlantDeath(object obj)
	{
		Vector3 vector;
		float z = vector.z;
	}

	// Token: 0x060000C7 RID: 199 RVA: 0x000048B0 File Offset: 0x00002AB0
	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x39F6E0", Offset = "0x39DCE0", VA = "0x18039F6E0")]
	public Debuff_霸凌弱者()
	{
	}
}
