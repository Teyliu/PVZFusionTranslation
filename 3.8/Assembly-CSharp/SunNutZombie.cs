using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020006D6 RID: 1750
[Token(Token = "0x20006D6")]
public class SunNutZombie : WallNutZombie
{
	// Token: 0x0600227B RID: 8827 RVA: 0x000B4B00 File Offset: 0x000B2D00
	[Token(Token = "0x600227B")]
	[Address(RVA = "0x571D40", Offset = "0x570340", VA = "0x180571D40", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCountDown = 15f;
	}

	// Token: 0x0600227C RID: 8828 RVA: 0x000B4B20 File Offset: 0x000B2D20
	[Token(Token = "0x600227C")]
	[Address(RVA = "0x574010", Offset = "0x572610", VA = "0x180574010", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		float num = this.timer;
		float deltaTime = Time.deltaTime;
		this.timer = num;
		this.timer = 1f;
	}

	// Token: 0x0600227D RID: 8829 RVA: 0x000B4B58 File Offset: 0x000B2D58
	[Token(Token = "0x600227D")]
	[Address(RVA = "0x573C80", Offset = "0x572280", VA = "0x180573C80", Slot = "74")]
	protected virtual void CheckMix()
	{
		int num = 0;
		Collider2D col = this.col;
		int num2 = this.zombieLayer;
		int num3 = this.plantLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
				int theZombieRow = this.theZombieRow;
				bool isMindControlled = this.isMindControlled;
			}
			num++;
			Collider2D col2 = this.col;
			ParticleManager instance = ParticleManager.Instance;
			uint num4;
			base.Die((int)num4);
			CreateZombie instance2 = CreateZombie.Instance;
		}
	}

	// Token: 0x0600227E RID: 8830 RVA: 0x000B4BDC File Offset: 0x000B2DDC
	[Token(Token = "0x600227E")]
	[Address(RVA = "0x573B90", Offset = "0x572190", VA = "0x180573B90", Slot = "23")]
	protected override void AttributeEvent()
	{
		this.board.UseSun(25f);
		Board board = this.board;
		if (board.theSun < 0)
		{
			int num = 0;
			board.theSun = num;
			CreateItem instance = CreateItem.Instance;
			int column = base.Column;
		}
		this.attributeCountDown = 15f;
	}

	// Token: 0x0600227F RID: 8831 RVA: 0x000B4C34 File Offset: 0x000B2E34
	[Token(Token = "0x600227F")]
	[Address(RVA = "0x534450", Offset = "0x532A50", VA = "0x180534450")]
	public SunNutZombie()
	{
	}

	// Token: 0x04001136 RID: 4406
	[FieldOffset(Offset = "0x258")]
	[Token(Token = "0x4001136")]
	private float timer;
}
