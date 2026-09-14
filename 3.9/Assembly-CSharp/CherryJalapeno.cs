using System;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200030F RID: 783
[Token(Token = "0x200030F")]
public class CherryJalapeno : Plant
{
	// Token: 0x06000E4A RID: 3658 RVA: 0x00051E44 File Offset: 0x00050044
	[Token(Token = "0x6000E4A")]
	[Address(RVA = "0x4454A0", Offset = "0x443AA0", VA = "0x1804454A0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 1f;
	}

	// Token: 0x06000E4B RID: 3659 RVA: 0x00051E64 File Offset: 0x00050064
	[Token(Token = "0x6000E4B")]
	[Address(RVA = "0x445740", Offset = "0x443D40", VA = "0x180445740", Slot = "15")]
	protected override void Start()
	{
		base.Start();
		GameAPP.PlaySound(39, 0.5f, 1f);
	}

	// Token: 0x06000E4C RID: 3660 RVA: 0x00051E88 File Offset: 0x00050088
	[Token(Token = "0x6000E4C")]
	[Address(RVA = "0x445470", Offset = "0x443A70", VA = "0x180445470", Slot = "39")]
	protected override void AttributeEvent()
	{
		this.theStatus = (PlantStatus)((ulong)12L);
		base.RemoveFromList();
		this.freeMoving = false;
	}

	// Token: 0x06000E4D RID: 3661 RVA: 0x00051EAC File Offset: 0x000500AC
	[Token(Token = "0x6000E4D")]
	[Address(RVA = "0x4457B0", Offset = "0x443DB0", VA = "0x1804457B0", Slot = "16")]
	protected override void Update()
	{
		base.PlantUpdate();
		Transform transform = base.transform;
		float num = Time.deltaTime * 10f;
		Transform axis = this.axis;
		Mouse instance = Mouse.Instance;
		Transform axis2 = this.axis;
		Transform transform2 = base.transform;
		Vector3 vector;
		float z = vector.z;
		Transform axis3 = this.axis;
		int num2 = 0;
		base.Die((Plant.DieReason)num2);
	}

	// Token: 0x06000E4E RID: 3662 RVA: 0x00051F18 File Offset: 0x00050118
	[Token(Token = "0x6000E4E")]
	[Address(RVA = "0x4454D0", Offset = "0x443AD0", VA = "0x1804454D0")]
	private void OnTriggerStay2D(Collider2D collision)
	{
		int num = 0;
		bool flag = collision.TryGetComponent<Zombie>(num);
		if (flag)
		{
			int thePlantRow = this.thePlantRow;
			int num2 = 0;
			if (!(num == num2) && num2 != 3)
			{
				if (18446744073709551609UL <= (ulong)17L)
				{
				}
				if (num2 != 44)
				{
					if (18446744073709551609UL > (ulong)46L)
					{
						if (18446744073709551609UL == (ulong)231L || 18446744073709551609UL <= (ulong)1L)
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
	}

	// Token: 0x06000E4F RID: 3663 RVA: 0x00051FA4 File Offset: 0x000501A4
	[Token(Token = "0x6000E4F")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "12")]
	public override void TakeDamage(int damage, IDamageMaker damageFrom, DamageType damageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x06000E50 RID: 3664 RVA: 0x00051FB4 File Offset: 0x000501B4
	[Token(Token = "0x6000E50")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "34")]
	public override void Crashed(int level = 0, int soundID = 0, [Optional] Zombie zombie)
	{
	}

	// Token: 0x06000E51 RID: 3665 RVA: 0x00051FC4 File Offset: 0x000501C4
	[Token(Token = "0x6000E51")]
	[Address(RVA = "0x418EF0", Offset = "0x4174F0", VA = "0x180418EF0")]
	public CherryJalapeno()
	{
	}
}
