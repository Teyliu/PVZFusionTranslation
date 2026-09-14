using System;
using System.Collections;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200079A RID: 1946
[Token(Token = "0x200079A")]
public class Weapon_doom : PlayerWeapon
{
	// Token: 0x06002790 RID: 10128 RVA: 0x000D6A00 File Offset: 0x000D4C00
	[Token(Token = "0x6002790")]
	[Address(RVA = "0x614290", Offset = "0x612890", VA = "0x180614290", Slot = "10")]
	protected override void Shoot()
	{
		Weapon_doom.<KeepShooting>d__2 <KeepShooting>d__;
		<KeepShooting>d__.System.IDisposable.Dispose();
		<KeepShooting>d__.<>1__state = (int)((ulong)0L);
		<KeepShooting>d__.<>4__this = this;
		Coroutine coroutine = base.StartCoroutine(<KeepShooting>d__);
	}

	// Token: 0x06002791 RID: 10129 RVA: 0x000D6A2C File Offset: 0x000D4C2C
	[Token(Token = "0x6002791")]
	[Address(RVA = "0x6141C0", Offset = "0x6127C0", VA = "0x1806141C0")]
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

	// Token: 0x06002792 RID: 10130 RVA: 0x000D6A78 File Offset: 0x000D4C78
	[Token(Token = "0x6002792")]
	[Address(RVA = "0x614220", Offset = "0x612820", VA = "0x180614220")]
	private IEnumerator KeepShooting()
	{
		Weapon_doom.<KeepShooting>d__2 <KeepShooting>d__;
		<KeepShooting>d__.System.IDisposable.Dispose();
		<KeepShooting>d__.<>1__state = (int)((ulong)0L);
		<KeepShooting>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06002793 RID: 10131 RVA: 0x000D6A9C File Offset: 0x000D4C9C
	[Token(Token = "0x6002793")]
	[Address(RVA = "0x614310", Offset = "0x612910", VA = "0x180614310")]
	public Weapon_doom()
	{
	}
}
