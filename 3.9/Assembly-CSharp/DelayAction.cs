using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020009B1 RID: 2481
[Token(Token = "0x20009B1")]
public class DelayAction : MonoBehaviour
{
	// Token: 0x06003329 RID: 13097 RVA: 0x0010C1DC File Offset: 0x0010A3DC
	[Token(Token = "0x6003329")]
	[Address(RVA = "0x749270", Offset = "0x747870", VA = "0x180749270")]
	public void SetAction(Action action, float timer)
	{
		DelayAction.ActionClip actionClip;
		actionClip.timer = timer;
		actionClip.action = action;
		actionClip.active = true;
		List<DelayAction.ActionClip> list = this.actions;
		int size = list._size;
	}

	// Token: 0x0600332A RID: 13098 RVA: 0x0010C21C File Offset: 0x0010A41C
	[Token(Token = "0x600332A")]
	[Address(RVA = "0x749370", Offset = "0x747970", VA = "0x180749370")]
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

	// Token: 0x0600332B RID: 13099 RVA: 0x0010C2A8 File Offset: 0x0010A4A8
	[Token(Token = "0x600332B")]
	[Address(RVA = "0x7494B0", Offset = "0x747AB0", VA = "0x1807494B0")]
	public DelayAction()
	{
		List<DelayAction.ActionClip> list = new List();
		this.actions = list;
		base..ctor();
	}

	// Token: 0x04001DEA RID: 7658
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4001DEA")]
	[SerializeField]
	private List<DelayAction.ActionClip> actions;

	// Token: 0x020009B2 RID: 2482
	[Token(Token = "0x20009B2")]
	[Serializable]
	private class ActionClip
	{
		// Token: 0x0600332C RID: 13100 RVA: 0x0010C2C8 File Offset: 0x0010A4C8
		[Token(Token = "0x600332C")]
		[Address(RVA = "0x748500", Offset = "0x746B00", VA = "0x180748500")]
		public ActionClip(Action action, float timer)
		{
			this.timer = timer;
			this.action = action;
			this.active = true;
		}

		// Token: 0x0600332D RID: 13101 RVA: 0x0010C2F0 File Offset: 0x0010A4F0
		[Token(Token = "0x600332D")]
		[Address(RVA = "0x7484A0", Offset = "0x746AA0", VA = "0x1807484A0")]
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

		// Token: 0x04001DEB RID: 7659
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4001DEB")]
		private float timer;

		// Token: 0x04001DEC RID: 7660
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4001DEC")]
		private readonly Action action;

		// Token: 0x04001DED RID: 7661
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4001DED")]
		public bool active;
	}
}
