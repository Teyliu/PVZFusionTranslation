using System;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000724 RID: 1828
[Token(Token = "0x2000724")]
public class TallFireNutZombie : WallNutZombie
{
	// Token: 0x06002418 RID: 9240 RVA: 0x000BC594 File Offset: 0x000BA794
	[Token(Token = "0x6002418")]
	[Address(RVA = "0x5F6E60", Offset = "0x5F5460", VA = "0x1805F6E60", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		this.attributeCountDown = 1f;
	}

	// Token: 0x06002419 RID: 9241 RVA: 0x000BC5B4 File Offset: 0x000BA7B4
	[Token(Token = "0x6002419")]
	[Address(RVA = "0x5F6AA0", Offset = "0x5F50A0", VA = "0x1805F6AA0", Slot = "24")]
	protected override void AttributeEvent()
	{
		int num = 0;
		this.attributeCountDown = 1f;
		float theOriginSpeed = this.theOriginSpeed;
		this.theOriginSpeed = theOriginSpeed;
		Collider2D col = this.col;
		int num2 = this.zombieLayer;
		int num3 = this.plantLayer;
		Collider2D[] array;
		if (num < array.Length)
		{
			bool flag;
			if (flag)
			{
				bool isMindControlled = this.isMindControlled;
				int theZombieRow = this.theZombieRow;
			}
			num++;
			Collider2D col2 = this.col;
			ParticleManager instance = ParticleManager.Instance;
			uint num4;
			base.Die((int)num4);
			CreateZombie instance2 = CreateZombie.Instance;
		}
	}

	// Token: 0x0600241A RID: 9242 RVA: 0x000BC650 File Offset: 0x000BA850
	[Token(Token = "0x600241A")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "51")]
	public override void SetJalaed()
	{
	}

	// Token: 0x0600241B RID: 9243 RVA: 0x000BC660 File Offset: 0x000BA860
	[Token(Token = "0x600241B")]
	[Address(RVA = "0x58B130", Offset = "0x589730", VA = "0x18058B130")]
	public TallFireNutZombie()
	{
	}
}
