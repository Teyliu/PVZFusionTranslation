using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020007D3 RID: 2003
[Token(Token = "0x20007D3")]
public class Weapon_doom : PlayerWeapon
{
	// Token: 0x060028BF RID: 10431 RVA: 0x000DB9E8 File Offset: 0x000D9BE8
	[Token(Token = "0x60028BF")]
	[Address(RVA = "0x677B20", Offset = "0x676120", VA = "0x180677B20", Slot = "10")]
	protected override void Shoot()
	{
		Weapon_doom.<KeepShooting>d__2 <KeepShooting>d__;
		<KeepShooting>d__.System.IDisposable.Dispose();
		<KeepShooting>d__.<>1__state = (int)((ulong)0L);
		<KeepShooting>d__.<>4__this = this;
		Coroutine coroutine = base.StartCoroutine(<KeepShooting>d__);
	}

	// Token: 0x060028C0 RID: 10432 RVA: 0x000DBA14 File Offset: 0x000D9C14
	[Token(Token = "0x60028C0")]
	[Address(RVA = "0x677A50", Offset = "0x676050", VA = "0x180677A50")]
	private bool CheckZombie(Zombie zombie)
	{
		if (!zombie.isMindControlled && !zombie.beforeDying && zombie.theStatus != ZombieStatus.Dying)
		{
			Player player = this.player;
			int theZombieRow = zombie.theZombieRow;
			int row = player.Row;
			return theZombieRow == row;
		}
		throw new NullReferenceException();
	}

	// Token: 0x060028C1 RID: 10433 RVA: 0x000DBA60 File Offset: 0x000D9C60
	[Token(Token = "0x60028C1")]
	[Address(RVA = "0x677AB0", Offset = "0x6760B0", VA = "0x180677AB0")]
	private IEnumerator KeepShooting()
	{
		Weapon_doom.<KeepShooting>d__2 <KeepShooting>d__;
		<KeepShooting>d__.System.IDisposable.Dispose();
		<KeepShooting>d__.<>1__state = (int)((ulong)0L);
		<KeepShooting>d__.<>4__this = this;
		return null;
	}

	// Token: 0x060028C2 RID: 10434 RVA: 0x000DBA84 File Offset: 0x000D9C84
	[Token(Token = "0x60028C2")]
	[Address(RVA = "0x677BA0", Offset = "0x6761A0", VA = "0x180677BA0")]
	public Weapon_doom()
	{
	}
}
