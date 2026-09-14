using System;
using System.Runtime.CompilerServices;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020008BF RID: 2239
[Token(Token = "0x20008BF")]
[Serializable]
public class AdvantureMission
{
	// Token: 0x170001C7 RID: 455
	// (get) Token: 0x06002D66 RID: 11622 RVA: 0x000FA014 File Offset: 0x000F8214
	// (set) Token: 0x06002D67 RID: 11623 RVA: 0x000FA028 File Offset: 0x000F8228
	[Token(Token = "0x170001C7")]
	public int Count
	{
		[Token(Token = "0x6002D66")]
		[Address(RVA = "0x6965C0", Offset = "0x694BC0", VA = "0x1806965C0")]
		get
		{
			return this.count;
		}
		[Token(Token = "0x6002D67")]
		[Address(RVA = "0x6965D0", Offset = "0x694BD0", VA = "0x1806965D0")]
		set
		{
			this.count = value;
		}
	}

	// Token: 0x06002D68 RID: 11624 RVA: 0x000FA03C File Offset: 0x000F823C
	[Token(Token = "0x6002D68")]
	[Address(RVA = "0x696050", Offset = "0x694650", VA = "0x180696050")]
	public void OnStart()
	{
		if (!string.IsNullOrEmpty(this.description))
		{
			InGameText instance = InGameText.Instance;
			int num = 0;
			string text = this.description;
			instance.ShowText(text, 30f, num != 0);
		}
		if (this.endResult != MissionResult.Nothing)
		{
			MissionResult missionResult = this.endResult;
			this.startEndResult = missionResult;
		}
	}

	// Token: 0x06002D69 RID: 11625 RVA: 0x000FA094 File Offset: 0x000F8294
	[Token(Token = "0x6002D69")]
	[Address(RVA = "0x6961B0", Offset = "0x6947B0", VA = "0x1806961B0")]
	public void Show(float time)
	{
		if (!string.IsNullOrEmpty(this.description))
		{
			InGameText instance = InGameText.Instance;
			string text = this.description;
			int num = 0;
			instance.ShowText(text, time, num != 0);
		}
	}

	// Token: 0x06002D6A RID: 11626 RVA: 0x000FA0D0 File Offset: 0x000F82D0
	[Token(Token = "0x6002D6A")]
	[Address(RVA = "0x6960B0", Offset = "0x6946B0", VA = "0x1806960B0")]
	public void OnUpdate()
	{
		if (!this.complete && this.target != (ulong)0L)
		{
			if (this.startEndResult != MissionResult.Nothing && this.endResult == MissionResult.Nothing)
			{
				InGameText instance = InGameText.Instance;
				string text = "【任务二】已失败";
				if (this.startEndResult == MissionResult.First)
				{
					text = "【任务一】已失败";
				}
				int num = 0;
				instance.ShowText(text, 3f, num != 0);
				this.startEndResult = (MissionResult)((ulong)0L);
			}
			if (!this.end)
			{
				if (this.result == MissionResult.Nothing)
				{
					Func<MissionResult> func = this.target;
					this.result = "【任务一】已失败";
					if ("【任务一】已失败" != 0)
					{
						this.MissionComplete();
						return;
					}
					return;
				}
			}
			else
			{
				if (this.endResult == MissionResult.Nothing)
				{
					return;
				}
				MissionResult missionResult = this.endResult;
				this.result = missionResult;
			}
			this.MissionComplete();
			return;
		}
	}

	// Token: 0x06002D6B RID: 11627 RVA: 0x000FA19C File Offset: 0x000F839C
	[Token(Token = "0x6002D6B")]
	[Address(RVA = "0x695F70", Offset = "0x694570", VA = "0x180695F70")]
	private void MissionComplete()
	{
		this.complete = true;
		int num = 0;
		bool flag;
		if (!flag)
		{
			InGameText instance = InGameText.Instance;
			string text = "任务完成：从<color=red>下一关</color>开始，" + num;
			instance.ShowText(text, 10f, true);
			GameAPP.PlaySound(125, 0.5f, 1f);
		}
	}

	// Token: 0x06002D6C RID: 11628 RVA: 0x000FA1F4 File Offset: 0x000F83F4
	[Token(Token = "0x6002D6C")]
	[Address(RVA = "0x696210", Offset = "0x694810", VA = "0x180696210")]
	public void Submit()
	{
		if (this.end)
		{
			uint num;
			GameAPP.PlaySound((int)num, 0.5f, 1f);
			InGameText instance = InGameText.Instance;
			int num2 = 0;
			instance.ShowText("关卡已结束", 3f, num2 != 0);
			return;
		}
		if (this.complete)
		{
			uint num3;
			GameAPP.PlaySound((int)num3, 0.5f, 1f);
			InGameText instance2 = InGameText.Instance;
			int num4 = 0;
			instance2.ShowText("任务已经结束", 3f, num4 != 0);
			return;
		}
		if (this.onSubmit == (ulong)0L)
		{
			uint num5;
			GameAPP.PlaySound((int)num5, 0.5f, 1f);
			InGameText instance3 = InGameText.Instance;
			int num6 = 0;
			instance3.ShowText("没有需要提交的任务", 3f, num6 != 0);
			return;
		}
		Func<ValueTuple<MissionResult, int>> func = this.onSubmit;
		this.submitCount = "还差{0}个";
		string text;
		if ("还差{0}个" < this.needSubmitCount)
		{
			InGameText instance4 = InGameText.Instance;
			int num7 = this.needSubmitCount;
			text = string.Format("还差{0}个", instance4);
			int num8 = 0;
			instance4.ShowText(text, 3f, num8 != 0);
			return;
		}
		this.result = text;
	}

	// Token: 0x06002D6D RID: 11629 RVA: 0x000FA318 File Offset: 0x000F8518
	[Token(Token = "0x6002D6D")]
	[Address(RVA = "0x695EE0", Offset = "0x6944E0", VA = "0x180695EE0")]
	public void LookProgress()
	{
		if (this.onLook == (ulong)0L)
		{
			InGameText instance = InGameText.Instance;
			int num = 0;
			instance.ShowText("暂无", 3f, num != 0);
			return;
		}
		Action action = this.onLook;
		throw new NullReferenceException();
	}

	// Token: 0x06002D6E RID: 11630 RVA: 0x000FA35C File Offset: 0x000F855C
	[Token(Token = "0x6002D6E")]
	[Address(RVA = "0x696480", Offset = "0x694A80", VA = "0x180696480")]
	public static void TryAddCount(AdvantureLevel level)
	{
		AdvantureManager instance = AdvantureManager.Instance;
		int num = 0;
		if (!(instance != num) || instance.mission == (ulong)0L || instance.mission.level == level)
		{
		}
	}

	// Token: 0x06002D6F RID: 11631 RVA: 0x000FA39C File Offset: 0x000F859C
	[Token(Token = "0x6002D6F")]
	[Address(RVA = "0x696520", Offset = "0x694B20", VA = "0x180696520")]
	public static void TryAddCount(AdvantureLevel level, int value)
	{
		AdvantureManager instance = AdvantureManager.Instance;
		int num = 0;
		if (!(instance != num) || instance.mission == (ulong)0L || instance.mission.level == level)
		{
		}
	}

	// Token: 0x06002D70 RID: 11632 RVA: 0x000FA3DC File Offset: 0x000F85DC
	[Token(Token = "0x6002D70")]
	[Address(RVA = "0x3B2FC0", Offset = "0x3B15C0", VA = "0x1803B2FC0")]
	public AdvantureMission()
	{
	}

	// Token: 0x04001BF1 RID: 7153
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001BF1")]
	public Board board;

	// Token: 0x04001BF2 RID: 7154
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001BF2")]
	public string description;

	// Token: 0x04001BF3 RID: 7155
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001BF3")]
	public string complete1;

	// Token: 0x04001BF4 RID: 7156
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001BF4")]
	public string complete2;

	// Token: 0x04001BF5 RID: 7157
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001BF5")]
	public float timer;

	// Token: 0x04001BF6 RID: 7158
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4001BF6")]
	public bool end;

	// Token: 0x04001BF7 RID: 7159
	[FieldOffset(Offset = "0x35")]
	[Token(Token = "0x4001BF7")]
	public bool complete;

	// Token: 0x04001BF8 RID: 7160
	[FieldOffset(Offset = "0x36")]
	[Token(Token = "0x4001BF8")]
	public bool single;

	// Token: 0x04001BF9 RID: 7161
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001BF9")]
	public MissionResult result;

	// Token: 0x04001BFA RID: 7162
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4001BFA")]
	public MissionResult endResult;

	// Token: 0x04001BFB RID: 7163
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001BFB")]
	private MissionResult startEndResult;

	// Token: 0x04001BFC RID: 7164
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001BFC")]
	public Func<MissionResult> target;

	// Token: 0x04001BFD RID: 7165
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001BFD")]
	public Action onLook;

	// Token: 0x04001BFE RID: 7166
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001BFE")]
	[TupleElementNames(new string[] { "result", "count" })]
	public Func<ValueTuple<MissionResult, int>> onSubmit;

	// Token: 0x04001BFF RID: 7167
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001BFF")]
	public int needSubmitCount;

	// Token: 0x04001C00 RID: 7168
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4001C00")]
	public int submitCount;

	// Token: 0x04001C01 RID: 7169
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001C01")]
	[SerializeField]
	private int count;

	// Token: 0x04001C02 RID: 7170
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x4001C02")]
	public AdvantureLevel level;
}
