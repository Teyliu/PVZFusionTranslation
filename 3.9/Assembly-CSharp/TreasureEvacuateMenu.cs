using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x020008CC RID: 2252
[Token(Token = "0x20008CC")]
public class TreasureEvacuateMenu : BaseMenu
{
	// Token: 0x06002DE3 RID: 11747 RVA: 0x000FB6F0 File Offset: 0x000F98F0
	[Token(Token = "0x6002DE3")]
	[Address(RVA = "0x707230", Offset = "0x705830", VA = "0x180707230")]
	private void Start()
	{
		for (;;)
		{
			TreasureDifficulty difficulty = TreasureData.difficulty;
			if (difficulty <= TreasureDifficulty.Hard)
			{
				break;
			}
			while (difficulty > TreasureDifficulty.Hell)
			{
			}
			List<TextMeshProUGUI> list = this.eva1Text;
			bool flag;
			if (flag)
			{
			}
			ulong num;
			if (num != (ulong)0L)
			{
				goto IL_008D;
			}
			uint num3;
			int num2 = global::UnityEngine.Random.Range(0, (int)num3);
			List<TextMeshProUGUI> list2 = this.eva2Text;
			if (num2 != 0)
			{
				bool flag2;
				if (flag2)
				{
				}
				ulong num4;
				if (num4 != (ulong)0L)
				{
					goto IL_0093;
				}
			}
			bool flag3;
			if (flag3)
			{
			}
			ulong num5;
			if (num5 == (ulong)0L)
			{
				goto Block_6;
			}
		}
		List<TextMeshProUGUI> list3 = this.eva1Text;
		bool flag4;
		if (flag4)
		{
		}
		ulong num6;
		if (num6 != (ulong)0L)
		{
			throw new NullReferenceException();
		}
		bool flag5;
		if (flag5)
		{
		}
		ulong num7;
		if (num7 == (ulong)0L)
		{
			return;
		}
		throw new NullReferenceException();
		Block_6:
		throw new NullReferenceException();
		IL_008D:
		throw new NullReferenceException();
		IL_0093:
		throw new NullReferenceException();
	}

	// Token: 0x06002DE4 RID: 11748 RVA: 0x000FB798 File Offset: 0x000F9998
	[Token(Token = "0x6002DE4")]
	[Address(RVA = "0x7071B0", Offset = "0x7057B0", VA = "0x1807071B0")]
	public void Evacuate1()
	{
		TreasureManager treasureManager = this.manager;
		TreasureTask.TaskType taskType = this.taskType1;
		treasureManager.GetTask(taskType);
		throw new NullReferenceException();
	}

	// Token: 0x06002DE5 RID: 11749 RVA: 0x000FB7C0 File Offset: 0x000F99C0
	[Token(Token = "0x6002DE5")]
	[Address(RVA = "0x7071F0", Offset = "0x7057F0", VA = "0x1807071F0")]
	public void Evacuate2()
	{
		TreasureManager treasureManager = this.manager;
		TreasureTask.TaskType taskType = this.taskType2;
		treasureManager.GetTask(taskType);
		throw new NullReferenceException();
	}

	// Token: 0x06002DE6 RID: 11750 RVA: 0x000FB7E8 File Offset: 0x000F99E8
	[Token(Token = "0x6002DE6")]
	[Address(RVA = "0x707780", Offset = "0x705D80", VA = "0x180707780")]
	public TreasureEvacuateMenu()
	{
		List<TextMeshProUGUI> list = new List();
		this.eva1Text = list;
		List<TextMeshProUGUI> list2 = new List();
		this.eva2Text = list2;
		base..ctor();
	}

	// Token: 0x04001BD4 RID: 7124
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001BD4")]
	public TreasureManager manager;

	// Token: 0x04001BD5 RID: 7125
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001BD5")]
	public List<TextMeshProUGUI> eva1Text;

	// Token: 0x04001BD6 RID: 7126
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001BD6")]
	public TreasureTask.TaskType taskType1;

	// Token: 0x04001BD7 RID: 7127
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001BD7")]
	public List<TextMeshProUGUI> eva2Text;

	// Token: 0x04001BD8 RID: 7128
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001BD8")]
	public TreasureTask.TaskType taskType2;
}
