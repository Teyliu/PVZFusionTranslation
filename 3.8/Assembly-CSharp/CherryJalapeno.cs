using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020002FF RID: 767
[Token(Token = "0x20002FF")]
public class CherryJalapeno : Plant
{
	// Token: 0x06000E01 RID: 3585 RVA: 0x00050EE0 File Offset: 0x0004F0E0
	[Token(Token = "0x6000E01")]
	[Address(RVA = "0x4013E0", Offset = "0x3FF9E0", VA = "0x1804013E0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 1f;
	}

	// Token: 0x06000E02 RID: 3586 RVA: 0x00050F00 File Offset: 0x0004F100
	[Token(Token = "0x6000E02")]
	[Address(RVA = "0x4015E0", Offset = "0x3FFBE0", VA = "0x1804015E0", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		GameAPP.PlaySound(39, 0.5f, 1f);
	}

	// Token: 0x06000E03 RID: 3587 RVA: 0x00050F24 File Offset: 0x0004F124
	[Token(Token = "0x6000E03")]
	[Address(RVA = "0x4013B0", Offset = "0x3FF9B0", VA = "0x1804013B0", Slot = "40")]
	protected override void AttributeEvent()
	{
		this.theStatus = (PlantStatus)((ulong)12L);
		base.RemoveFromList();
		this.freeMoving = false;
	}

	// Token: 0x06000E04 RID: 3588 RVA: 0x00050F48 File Offset: 0x0004F148
	[Token(Token = "0x6000E04")]
	[Address(RVA = "0x401650", Offset = "0x3FFC50", VA = "0x180401650", Slot = "16")]
	protected override void Update()
	{
		base.Update();
		Transform transform = base.transform;
		float num = Time.deltaTime * 10f;
		Transform axis = this.axis;
		int num2 = 0;
		base.Die((Plant.DieReason)num2);
	}

	// Token: 0x06000E05 RID: 3589 RVA: 0x00050F8C File Offset: 0x0004F18C
	[Token(Token = "0x6000E05")]
	[Address(RVA = "0x401410", Offset = "0x3FFA10", VA = "0x180401410")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		int num = 0;
		bool flag = collision.TryGetComponent<Zombie>(num);
		if (flag)
		{
			int thePlantRow = this.thePlantRow;
			bool flag2 = base.AttackLandZombie(num);
			if (flag2)
			{
				if (flag2 > true)
				{
					if (flag2 || flag2)
					{
						return;
					}
				}
				else
				{
					while (flag)
					{
					}
				}
				BoardAction boardAction = this.board.boardAction;
				PlantType thePlantType = this.thePlantType;
				int attackDamage = this.attackDamage;
				PlantType thePlantType2 = this.thePlantType;
				return;
			}
		}
	}

	// Token: 0x06000E06 RID: 3590 RVA: 0x00050FF8 File Offset: 0x0004F1F8
	[Token(Token = "0x6000E06")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x06000E07 RID: 3591 RVA: 0x00051008 File Offset: 0x0004F208
	[Token(Token = "0x6000E07")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "35")]
	public override void Crashed(int level = 0, int soundID = 0, [Optional] Zombie zombie)
	{
	}

	// Token: 0x06000E08 RID: 3592 RVA: 0x00051018 File Offset: 0x0004F218
	[Token(Token = "0x6000E08")]
	[Address(RVA = "0x3CC070", Offset = "0x3CA670", VA = "0x1803CC070")]
	public CherryJalapeno()
	{
	}
}
