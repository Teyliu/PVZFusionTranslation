using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200070E RID: 1806
[Token(Token = "0x200070E")]
public class SunNutZombie : WallNutZombie
{
	// Token: 0x06002395 RID: 9109 RVA: 0x000B98B8 File Offset: 0x000B7AB8
	[Token(Token = "0x6002395")]
	[Address(RVA = "0x5D53A0", Offset = "0x5D39A0", VA = "0x1805D53A0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCountDown = 15f;
	}

	// Token: 0x06002396 RID: 9110 RVA: 0x000B98D8 File Offset: 0x000B7AD8
	[Token(Token = "0x6002396")]
	[Address(RVA = "0x5D7680", Offset = "0x5D5C80", VA = "0x1805D7680", Slot = "17")]
	protected override void Update()
	{
		base.Update();
		float num = this.timer;
		float deltaTime = Time.deltaTime;
		this.timer = num;
		this.timer = 1f;
	}

	// Token: 0x06002397 RID: 9111 RVA: 0x000B9910 File Offset: 0x000B7B10
	[Token(Token = "0x6002397")]
	[Address(RVA = "0x5D72F0", Offset = "0x5D58F0", VA = "0x1805D72F0", Slot = "76")]
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

	// Token: 0x06002398 RID: 9112 RVA: 0x000B9994 File Offset: 0x000B7B94
	[Token(Token = "0x6002398")]
	[Address(RVA = "0x5D7200", Offset = "0x5D5800", VA = "0x1805D7200", Slot = "24")]
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

	// Token: 0x06002399 RID: 9113 RVA: 0x000B99EC File Offset: 0x000B7BEC
	[Token(Token = "0x6002399")]
	[Address(RVA = "0x58B130", Offset = "0x589730", VA = "0x18058B130")]
	public SunNutZombie()
	{
	}

	// Token: 0x04001203 RID: 4611
	[FieldOffset(Offset = "0x278")]
	[Token(Token = "0x4001203")]
	private float timer;
}
