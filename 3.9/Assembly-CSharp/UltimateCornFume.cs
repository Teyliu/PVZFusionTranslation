using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2IlInjected;
using Cysharp.Threading.Tasks;
using UnityEngine;

// Token: 0x020005D2 RID: 1490
[Token(Token = "0x20005D2")]
public class UltimateCornFume : CornFume
{
	// Token: 0x06001BAA RID: 7082 RVA: 0x00093DB0 File Offset: 0x00091FB0
	[Token(Token = "0x6001BAA")]
	[Address(RVA = "0x4454A0", Offset = "0x443AA0", VA = "0x1804454A0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		base.AttributeCountdown = 1f;
	}

	// Token: 0x06001BAB RID: 7083 RVA: 0x00093DD0 File Offset: 0x00091FD0
	[Token(Token = "0x6001BAB")]
	[Address(RVA = "0x5589E0", Offset = "0x556FE0", VA = "0x1805589E0", Slot = "39")]
	protected override void AttributeEvent()
	{
		ulong num3;
		do
		{
			int thePlantRow = this.thePlantRow;
			uint num;
			List<Plant> rangePlants = Lawnf.GetRangePlants(this.thePlantColumn, thePlantRow, (int)num);
			bool flag;
			if (flag)
			{
				int thePlantColumn = this.thePlantColumn;
				int thePlantRow2 = this.thePlantRow;
				uint num2;
				num2 -= (uint)thePlantRow2;
				num2 -= (uint)thePlantColumn;
			}
		}
		while (num3 != (ulong)0L);
	}

	// Token: 0x06001BAC RID: 7084 RVA: 0x00093E34 File Offset: 0x00092034
	[Token(Token = "0x6001BAC")]
	[Address(RVA = "0x558F20", Offset = "0x557520", VA = "0x180558F20", Slot = "61")]
	public override bool OnClicked(Mouse mouse)
	{
		int num = this.count;
		List<Zombie> zombies = this.GetZombies();
		this.anim.SetTrigger("shoot");
		this.theStatus = (PlantStatus)((ulong)25L);
		return true;
	}

	// Token: 0x06001BAD RID: 7085 RVA: 0x00093E74 File Offset: 0x00092074
	[Token(Token = "0x6001BAD")]
	[Address(RVA = "0x558470", Offset = "0x556A70", VA = "0x180558470", Slot = "68")]
	protected override void AnimShoot()
	{
		int num;
		do
		{
			List<Zombie> zombies = this.GetZombies();
			num = 0;
			bool flag;
			if (flag)
			{
				CreateBullet instance = CreateBullet.Instance;
				Transform shoot = this.shoot;
				Transform shoot2 = this.shoot;
				int attackDamage = this.attackDamage;
				Bullet bullet;
				bullet.Damage = attackDamage;
				Transform shoot3 = this.shoot;
				PlantType thePlantType = this.thePlantType;
				bullet.fromType = thePlantType;
				bullet.theStatus = (BulletStatus)((ulong)9L);
				int attributeCount = this.attributeCount;
				this.attributeCount = attributeCount;
				this.attributeCount = num;
			}
		}
		while (num != 0);
		uint num2;
		GameAPP.PlaySound((int)num2, 0.5f, 1f);
		int num3 = 0;
		this.theStatus = (PlantStatus)num3;
		if (this.cancellationTokenSource != (ulong)0L)
		{
			this.cancellationTokenSource.Cancel();
			this.cancellationTokenSource.Dispose();
		}
		CancellationToken[] array = new CancellationToken[1];
		CancellationToken cancellationTokenOnDestroy = this.board.GetCancellationTokenOnDestroy();
		array[0] = cancellationTokenOnDestroy;
		CancellationTokenSource cancellationTokenSource = CancellationTokenSource.CreateLinkedTokenSource(array);
		this.cancellationTokenSource = cancellationTokenSource;
		CancellationTokenSource cancellationTokenSource2 = this.cancellationTokenSource;
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06001BAE RID: 7086 RVA: 0x00093FB4 File Offset: 0x000921B4
	[Token(Token = "0x6001BAE")]
	[Address(RVA = "0x559040", Offset = "0x557640", VA = "0x180559040")]
	private void WantSpringShoot(List<Zombie> zombies, CancellationTokenSource cancel)
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x06001BAF RID: 7087 RVA: 0x00093FD8 File Offset: 0x000921D8
	[Token(Token = "0x6001BAF")]
	[Address(RVA = "0x558C80", Offset = "0x557280", VA = "0x180558C80", Slot = "69")]
	protected override List<Zombie> GetZombies()
	{
		List<Zombie> list;
		ulong num;
		do
		{
			list = new List();
			List<Zombie> allZombies = Lawnf.GetAllZombies(false);
			bool flag;
			if (flag)
			{
				bool flag2;
				while (!flag2)
				{
				}
			}
		}
		while (num != (ulong)0L);
		return list;
	}

	// Token: 0x06001BB0 RID: 7088 RVA: 0x00094028 File Offset: 0x00092228
	[Token(Token = "0x6001BB0")]
	[Address(RVA = "0x558E50", Offset = "0x557450", VA = "0x180558E50", Slot = "23")]
	protected override void OnAfterInitText()
	{
		HealthSlider healthSlider = this.healthSlider;
	}

	// Token: 0x06001BB1 RID: 7089 RVA: 0x00094048 File Offset: 0x00092248
	[Token(Token = "0x6001BB1")]
	[Address(RVA = "0x559140", Offset = "0x557740", VA = "0x180559140")]
	public UltimateCornFume()
	{
	}

	// Token: 0x04000F4E RID: 3918
	[FieldOffset(Offset = "0x218")]
	[Token(Token = "0x4000F4E")]
	private readonly int count = (int)((ulong)100L);

	// Token: 0x04000F4F RID: 3919
	[FieldOffset(Offset = "0x220")]
	[Token(Token = "0x4000F4F")]
	private CancellationTokenSource cancellationTokenSource;
}
