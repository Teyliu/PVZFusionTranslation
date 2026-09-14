using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000837 RID: 2103
[Token(Token = "0x2000837")]
public class RogueCrisisMenu : BaseMenu
{
	// Token: 0x06002AF2 RID: 10994 RVA: 0x000E9108 File Offset: 0x000E7308
	[Token(Token = "0x6002AF2")]
	[Address(RVA = "0x6A9820", Offset = "0x6A7E20", VA = "0x1806A9820")]
	private void Start()
	{
		this.ShowCrisis();
	}

	// Token: 0x06002AF3 RID: 10995 RVA: 0x000E911C File Offset: 0x000E731C
	[Token(Token = "0x6002AF3")]
	[Address(RVA = "0x6A91E0", Offset = "0x6A77E0", VA = "0x1806A91E0")]
	public void Refresh()
	{
		if (!this.refreshable)
		{
			GameAPP.PlaySound(26, 0.5f, 1f);
			InGameText instance = InGameText.Instance;
			return;
		}
		GameAPP.UIManager.Pop();
		RogueManager instance2 = RogueManager.Instance;
		int num = this.level;
		instance2.CrisisManifested(num, true);
	}

	// Token: 0x06002AF4 RID: 10996 RVA: 0x000E9178 File Offset: 0x000E7378
	[Token(Token = "0x6002AF4")]
	[Address(RVA = "0x6A9300", Offset = "0x6A7900", VA = "0x1806A9300")]
	private void ShowCrisis()
	{
		ulong num4;
		do
		{
			int num = 0;
			List<ZombieType> zombies_a = RogueManager.Instance.zombies_a;
			bool flag;
			if (flag)
			{
				GameObject gameObject = Resources.Load<GameObject>("UI/CrisisZombieWindow");
				Transform transform = this.zombieHead;
				global::UnityEngine.Object.Instantiate<GameObject>(gameObject, transform).GetComponent<CrisisZombieWindow>().SetZombieType((ZombieType)num, 4);
			}
			ulong num2;
			if (num2 != (ulong)0L)
			{
				goto IL_010C;
			}
			List<ZombieType> zombies_b = RogueManager.Instance.zombies_b;
			bool flag2;
			if (flag2)
			{
				GameObject gameObject2 = Resources.Load<GameObject>("UI/CrisisZombieWindow");
				GameObject gameObject3;
				gameObject3.GetComponent<CrisisZombieWindow>().SetZombieType((ZombieType)num, 8);
			}
			ulong num3;
			if (num3 != (ulong)0L)
			{
				goto IL_0118;
			}
			List<ZombieType> zombies_c = RogueManager.Instance.zombies_c;
			bool flag3;
			if (flag3)
			{
				GameObject gameObject4 = Resources.Load<GameObject>("UI/CrisisZombieWindow");
				GameObject gameObject5;
				gameObject5.GetComponent<CrisisZombieWindow>().SetZombieType((ZombieType)num, 12);
			}
		}
		while (num4 != (ulong)0L);
		if (RogueManager.Instance.boss != ZombieType.NormalZombie)
		{
			GameObject gameObject6 = Resources.Load<GameObject>("UI/CrisisZombieWindow");
			GameObject gameObject7;
			CrisisZombieWindow component = gameObject7.GetComponent<CrisisZombieWindow>();
			ZombieType boss = RogueManager.Instance.boss;
			component.SetZombieType(boss, 16);
		}
		return;
		IL_010C:
		throw new NullReferenceException();
		IL_0118:
		throw new NullReferenceException();
	}

	// Token: 0x06002AF5 RID: 10997 RVA: 0x000E92AC File Offset: 0x000E74AC
	[Token(Token = "0x6002AF5")]
	[Address(RVA = "0x6A9830", Offset = "0x6A7E30", VA = "0x1806A9830")]
	public RogueCrisisMenu()
	{
	}

	// Token: 0x040018E8 RID: 6376
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40018E8")]
	public Transform zombieHead;

	// Token: 0x040018E9 RID: 6377
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40018E9")]
	public int level;

	// Token: 0x040018EA RID: 6378
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x40018EA")]
	public bool refreshable = true;
}
