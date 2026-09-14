using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000975 RID: 2421
[Token(Token = "0x2000975")]
public class DelayAction : MonoBehaviour
{
	// Token: 0x060031F5 RID: 12789 RVA: 0x0010745C File Offset: 0x0010565C
	[Token(Token = "0x60031F5")]
	[Address(RVA = "0x6E3EB0", Offset = "0x6E24B0", VA = "0x1806E3EB0")]
	public void SetAction(Action action, float timer)
	{
		DelayAction.ActionClip actionClip;
		actionClip.timer = timer;
		actionClip.action = action;
		actionClip.active = true;
		List<DelayAction.ActionClip> list = this.actions;
		int size = list._size;
	}

	// Token: 0x060031F6 RID: 12790 RVA: 0x0010749C File Offset: 0x0010569C
	[Token(Token = "0x60031F6")]
	[Address(RVA = "0x6E3FB0", Offset = "0x6E25B0", VA = "0x1806E3FB0")]
	private void Update()
	{
		int size = this.actions._size;
		int num = size - 1;
		if (size > 0)
		{
			DelayAction.ActionClip actionClip = this.actions[num];
			if (actionClip.active)
			{
				float timer = actionClip.timer;
				float deltaTime = Time.deltaTime;
				actionClip.timer = timer;
				if (actionClip.action != 0)
				{
				}
				actionClip.active = false;
			}
			if (!this.actions[num].active)
			{
				this.actions.RemoveAt(num);
			}
		}
	}

	// Token: 0x060031F7 RID: 12791 RVA: 0x00107528 File Offset: 0x00105728
	[Token(Token = "0x60031F7")]
	[Address(RVA = "0x6E40F0", Offset = "0x6E26F0", VA = "0x1806E40F0")]
	public DelayAction()
	{
		List<DelayAction.ActionClip> list = new List();
		this.actions = list;
		base..ctor();
	}

	// Token: 0x04001CFA RID: 7418
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001CFA")]
	[SerializeField]
	private List<DelayAction.ActionClip> actions;

	// Token: 0x02000976 RID: 2422
	[Token(Token = "0x2000976")]
	[Serializable]
	private class ActionClip
	{
		// Token: 0x060031F8 RID: 12792 RVA: 0x00107548 File Offset: 0x00105748
		[Token(Token = "0x60031F8")]
		[Address(RVA = "0x6E31F0", Offset = "0x6E17F0", VA = "0x1806E31F0")]
		public ActionClip(Action action, float timer)
		{
			this.timer = timer;
			this.action = action;
			this.active = true;
		}

		// Token: 0x060031F9 RID: 12793 RVA: 0x00107570 File Offset: 0x00105770
		[Token(Token = "0x60031F9")]
		[Address(RVA = "0x6E3190", Offset = "0x6E1790", VA = "0x1806E3190")]
		public void Update()
		{
			if (this.active)
			{
				float num = this.timer;
				float deltaTime = Time.deltaTime;
				this.timer = num;
				if (this.action != 0)
				{
				}
				this.active = false;
			}
		}

		// Token: 0x04001CFB RID: 7419
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4001CFB")]
		private float timer;

		// Token: 0x04001CFC RID: 7420
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4001CFC")]
		private readonly Action action;

		// Token: 0x04001CFD RID: 7421
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4001CFD")]
		public bool active;
	}
}
