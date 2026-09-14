using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x02000890 RID: 2192
[Token(Token = "0x2000890")]
public class TreasureEvacuateMenu : BaseMenu
{
	// Token: 0x06002CB1 RID: 11441 RVA: 0x000F6B68 File Offset: 0x000F4D68
	[Token(Token = "0x6002CB1")]
	[Address(RVA = "0x68DB80", Offset = "0x68C180", VA = "0x18068DB80")]
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

	// Token: 0x06002CB2 RID: 11442 RVA: 0x000F6C10 File Offset: 0x000F4E10
	[Token(Token = "0x6002CB2")]
	[Address(RVA = "0x68DB00", Offset = "0x68C100", VA = "0x18068DB00")]
	public void Evacuate1()
	{
		TreasureManager treasureManager = this.manager;
		TreasureTask.TaskType taskType = this.taskType1;
		treasureManager.GetTask(taskType);
		throw new NullReferenceException();
	}

	// Token: 0x06002CB3 RID: 11443 RVA: 0x000F6C38 File Offset: 0x000F4E38
	[Token(Token = "0x6002CB3")]
	[Address(RVA = "0x68DB40", Offset = "0x68C140", VA = "0x18068DB40")]
	public void Evacuate2()
	{
		TreasureManager treasureManager = this.manager;
		TreasureTask.TaskType taskType = this.taskType2;
		treasureManager.GetTask(taskType);
		throw new NullReferenceException();
	}

	// Token: 0x06002CB4 RID: 11444 RVA: 0x000F6C60 File Offset: 0x000F4E60
	[Token(Token = "0x6002CB4")]
	[Address(RVA = "0x68E0D0", Offset = "0x68C6D0", VA = "0x18068E0D0")]
	public TreasureEvacuateMenu()
	{
		List<TextMeshProUGUI> list = new List();
		this.eva1Text = list;
		List<TextMeshProUGUI> list2 = new List();
		this.eva2Text = list2;
		base..ctor();
	}

	// Token: 0x04001AE6 RID: 6886
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001AE6")]
	public TreasureManager manager;

	// Token: 0x04001AE7 RID: 6887
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001AE7")]
	public List<TextMeshProUGUI> eva1Text;

	// Token: 0x04001AE8 RID: 6888
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001AE8")]
	public TreasureTask.TaskType taskType1;

	// Token: 0x04001AE9 RID: 6889
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001AE9")]
	public List<TextMeshProUGUI> eva2Text;

	// Token: 0x04001AEA RID: 6890
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001AEA")]
	public TreasureTask.TaskType taskType2;
}
