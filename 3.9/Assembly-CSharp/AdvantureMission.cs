using System;
using System.Runtime.CompilerServices;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020008FB RID: 2299
[Token(Token = "0x20008FB")]
[Serializable]
public class AdvantureMission
{
	// Token: 0x1700020F RID: 527
	// (get) Token: 0x06002E99 RID: 11929 RVA: 0x000FEBA8 File Offset: 0x000FCDA8
	// (set) Token: 0x06002E9A RID: 11930 RVA: 0x000FEBBC File Offset: 0x000FCDBC
	[Token(Token = "0x1700020F")]
	public int Count
	{
		[Token(Token = "0x6002E99")]
		[Address(RVA = "0x7106C0", Offset = "0x70ECC0", VA = "0x1807106C0")]
		get
		{
			return this.count;
		}
		[Token(Token = "0x6002E9A")]
		[Address(RVA = "0x7106D0", Offset = "0x70ECD0", VA = "0x1807106D0")]
		set
		{
			this.count = value;
		}
	}

	// Token: 0x06002E9B RID: 11931 RVA: 0x000FEBD0 File Offset: 0x000FCDD0
	[Token(Token = "0x6002E9B")]
	[Address(RVA = "0x7100E0", Offset = "0x70E6E0", VA = "0x1807100E0")]
	public void OnStart()
	{
		if (!string.IsNullOrEmpty(this.description))
		{
			InGameText instance = InGameText.Instance;
		}
		if (this.endResult != MissionResult.Nothing)
		{
			MissionResult missionResult = this.endResult;
			this.startEndResult = missionResult;
		}
	}

	// Token: 0x06002E9C RID: 11932 RVA: 0x000FEC14 File Offset: 0x000FCE14
	[Token(Token = "0x6002E9C")]
	[Address(RVA = "0x710260", Offset = "0x70E860", VA = "0x180710260")]
	public void Show(float time)
	{
		if (!string.IsNullOrEmpty(this.description))
		{
			InGameText instance = InGameText.Instance;
		}
	}

	// Token: 0x06002E9D RID: 11933 RVA: 0x000FEC40 File Offset: 0x000FCE40
	[Token(Token = "0x6002E9D")]
	[Address(RVA = "0x710150", Offset = "0x70E750", VA = "0x180710150")]
	public void OnUpdate()
	{
		if (!this.complete && this.target != (ulong)0L)
		{
			if (this.startEndResult != MissionResult.Nothing && this.endResult == MissionResult.Nothing)
			{
				InGameText instance = InGameText.Instance;
				if (this.startEndResult == MissionResult.First)
				{
				}
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

	// Token: 0x06002E9E RID: 11934 RVA: 0x000FECFC File Offset: 0x000FCEFC
	[Token(Token = "0x6002E9E")]
	[Address(RVA = "0x70FFE0", Offset = "0x70E5E0", VA = "0x18070FFE0")]
	private void MissionComplete()
	{
		this.complete = true;
		bool flag;
		if (!flag)
		{
			InGameText instance = InGameText.Instance;
			GameAPP.PlaySound(125, 0.5f, 1f);
		}
	}

	// Token: 0x06002E9F RID: 11935 RVA: 0x000FED34 File Offset: 0x000FCF34
	[Token(Token = "0x6002E9F")]
	[Address(RVA = "0x7102D0", Offset = "0x70E8D0", VA = "0x1807102D0")]
	public void Submit()
	{
		if (this.end)
		{
			uint num;
			GameAPP.PlaySound((int)num, 0.5f, 1f);
			InGameText instance = InGameText.Instance;
			return;
		}
		if (this.complete)
		{
			uint num2;
			GameAPP.PlaySound((int)num2, 0.5f, 1f);
			InGameText instance2 = InGameText.Instance;
			return;
		}
		if (this.onSubmit == (ulong)0L)
		{
			uint num3;
			GameAPP.PlaySound((int)num3, 0.5f, 1f);
			InGameText instance3 = InGameText.Instance;
			return;
		}
		Func<ValueTuple<MissionResult, int>> func = this.onSubmit;
		this.submitCount = "还差{0}个";
		string text;
		if ("还差{0}个" < this.needSubmitCount)
		{
			InGameText instance4 = InGameText.Instance;
			int num4 = this.needSubmitCount;
			text = string.Format("还差{0}个", instance4);
			return;
		}
		this.result = text;
	}

	// Token: 0x06002EA0 RID: 11936 RVA: 0x000FEE04 File Offset: 0x000FD004
	[Token(Token = "0x6002EA0")]
	[Address(RVA = "0x70FF40", Offset = "0x70E540", VA = "0x18070FF40")]
	public void LookProgress()
	{
		if (this.onLook == (ulong)0L)
		{
			InGameText instance = InGameText.Instance;
			return;
		}
		Action action = this.onLook;
		throw new NullReferenceException();
	}

	// Token: 0x06002EA1 RID: 11937 RVA: 0x000FEE34 File Offset: 0x000FD034
	[Token(Token = "0x6002EA1")]
	[Address(RVA = "0x710580", Offset = "0x70EB80", VA = "0x180710580")]
	public static void TryAddCount(AdvantureLevel level)
	{
		AdvantureManager instance = AdvantureManager.Instance;
		int num = 0;
		if (!(instance != num) || instance.mission == (ulong)0L || instance.mission.level == level)
		{
		}
	}

	// Token: 0x06002EA2 RID: 11938 RVA: 0x000FEE74 File Offset: 0x000FD074
	[Token(Token = "0x6002EA2")]
	[Address(RVA = "0x710620", Offset = "0x70EC20", VA = "0x180710620")]
	public static void TryAddCount(AdvantureLevel level, int value)
	{
		AdvantureManager instance = AdvantureManager.Instance;
		int num = 0;
		if (!(instance != num) || instance.mission == (ulong)0L || instance.mission.level == level)
		{
		}
	}

	// Token: 0x06002EA3 RID: 11939 RVA: 0x000FEEB4 File Offset: 0x000FD0B4
	[Token(Token = "0x6002EA3")]
	[Address(RVA = "0x3FB4C0", Offset = "0x3F9AC0", VA = "0x1803FB4C0")]
	public AdvantureMission()
	{
	}

	// Token: 0x04001CE1 RID: 7393
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001CE1")]
	public Board board;

	// Token: 0x04001CE2 RID: 7394
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001CE2")]
	public string description;

	// Token: 0x04001CE3 RID: 7395
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001CE3")]
	public string complete1;

	// Token: 0x04001CE4 RID: 7396
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4001CE4")]
	public string complete2;

	// Token: 0x04001CE5 RID: 7397
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4001CE5")]
	public float timer;

	// Token: 0x04001CE6 RID: 7398
	[FieldOffset(Offset = "0x34")]
	[Token(Token = "0x4001CE6")]
	public bool end;

	// Token: 0x04001CE7 RID: 7399
	[FieldOffset(Offset = "0x35")]
	[Token(Token = "0x4001CE7")]
	public bool complete;

	// Token: 0x04001CE8 RID: 7400
	[FieldOffset(Offset = "0x36")]
	[Token(Token = "0x4001CE8")]
	public bool single;

	// Token: 0x04001CE9 RID: 7401
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4001CE9")]
	public MissionResult result;

	// Token: 0x04001CEA RID: 7402
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4001CEA")]
	public MissionResult endResult;

	// Token: 0x04001CEB RID: 7403
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001CEB")]
	private MissionResult startEndResult;

	// Token: 0x04001CEC RID: 7404
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001CEC")]
	public Func<MissionResult> target;

	// Token: 0x04001CED RID: 7405
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001CED")]
	public Action onLook;

	// Token: 0x04001CEE RID: 7406
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001CEE")]
	[TupleElementNames(new string[] { "result", "count" })]
	public Func<ValueTuple<MissionResult, int>> onSubmit;

	// Token: 0x04001CEF RID: 7407
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001CEF")]
	public int needSubmitCount;

	// Token: 0x04001CF0 RID: 7408
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4001CF0")]
	public int submitCount;

	// Token: 0x04001CF1 RID: 7409
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4001CF1")]
	[SerializeField]
	private int count;

	// Token: 0x04001CF2 RID: 7410
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x4001CF2")]
	public AdvantureLevel level;
}
