using System;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000619 RID: 1561
[Token(Token = "0x2000619")]
public class TreasureTask
{
	// Token: 0x06001D81 RID: 7553 RVA: 0x0009DA48 File Offset: 0x0009BC48
	[Token(Token = "0x6001D81")]
	[Address(RVA = "0x52A6D0", Offset = "0x528CD0", VA = "0x18052A6D0")]
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
		int num = 0;
		instance2.ShowText("汽车即将启动，请等待撤离", 5f, num != 0);
	}

	// Token: 0x06001D82 RID: 7554 RVA: 0x0009DADC File Offset: 0x0009BCDC
	[Token(Token = "0x6001D82")]
	[Address(RVA = "0x52A670", Offset = "0x528C70", VA = "0x18052A670")]
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

	// Token: 0x04001018 RID: 4120
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001018")]
	public float a;

	// Token: 0x04001019 RID: 4121
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4001019")]
	public float timer;

	// Token: 0x0400101A RID: 4122
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400101A")]
	public TreasureTask.TaskType taskType;

	// Token: 0x0400101B RID: 4123
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400101B")]
	public TreasureManager manager;

	// Token: 0x0200061A RID: 1562
	[Token(Token = "0x200061A")]
	public enum TaskType
	{
		// Token: 0x0400101D RID: 4125
		[Token(Token = "0x400101D")]
		NormalEvacuate,
		// Token: 0x0400101E RID: 4126
		[Token(Token = "0x400101E")]
		LoseBagEvacuate,
		// Token: 0x0400101F RID: 4127
		[Token(Token = "0x400101F")]
		ClosesEvacuate,
		// Token: 0x04001020 RID: 4128
		[Token(Token = "0x4001020")]
		MissionEvacuate
	}
}
