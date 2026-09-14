using System;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200064E RID: 1614
[Token(Token = "0x200064E")]
public class TreasureTask
{
	// Token: 0x06001E80 RID: 7808 RVA: 0x000A24B8 File Offset: 0x000A06B8
	[Token(Token = "0x6001E80")]
	[Address(RVA = "0x5958B0", Offset = "0x593EB0", VA = "0x1805958B0")]
	public TreasureTask(TreasureManager manager, TreasureTask.TaskType taskType)
	{
		this.taskType = taskType;
		this.manager = manager;
		if (taskType != TreasureTask.TaskType.NormalEvacuate)
		{
			if (taskType != TreasureTask.TaskType.NormalEvacuate)
			{
				if (taskType != TreasureTask.TaskType.NormalEvacuate)
				{
					if (taskType != TreasureTask.TaskType.LoseBagEvacuate)
					{
						goto IL_005E;
					}
					CreateZombie instance = CreateZombie.Instance;
					Zombie zombie;
					global::Lawnf.SetZombieHealth(zombie.GetComponent<Zombie>(), 10f);
				}
				this.timer = 300f;
			}
			this.timer = 30f;
		}
		this.timer = 10f;
		IL_005E:
		InGameText instance2 = InGameText.Instance;
	}

	// Token: 0x06001E81 RID: 7809 RVA: 0x000A2534 File Offset: 0x000A0734
	[Token(Token = "0x6001E81")]
	[Address(RVA = "0x595850", Offset = "0x593E50", VA = "0x180595850")]
	public bool Check()
	{
		float num = this.timer;
		int num2 = 0;
		if (num > (float)num2)
		{
			float deltaTime = Time.deltaTime;
			this.timer = num;
			this.timer = 0f;
			return true;
		}
		return false;
	}

	// Token: 0x040010E0 RID: 4320
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40010E0")]
	public float a;

	// Token: 0x040010E1 RID: 4321
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x40010E1")]
	public float timer;

	// Token: 0x040010E2 RID: 4322
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40010E2")]
	public TreasureTask.TaskType taskType;

	// Token: 0x040010E3 RID: 4323
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40010E3")]
	public TreasureManager manager;

	// Token: 0x0200064F RID: 1615
	[Token(Token = "0x200064F")]
	public enum TaskType
	{
		// Token: 0x040010E5 RID: 4325
		[Token(Token = "0x40010E5")]
		NormalEvacuate,
		// Token: 0x040010E6 RID: 4326
		[Token(Token = "0x40010E6")]
		LoseBagEvacuate,
		// Token: 0x040010E7 RID: 4327
		[Token(Token = "0x40010E7")]
		ClosesEvacuate,
		// Token: 0x040010E8 RID: 4328
		[Token(Token = "0x40010E8")]
		MissionEvacuate
	}
}
