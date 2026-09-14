using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020007FC RID: 2044
[Token(Token = "0x20007FC")]
public class RogueCrisisMenu : BaseMenu
{
	// Token: 0x060029BC RID: 10684 RVA: 0x000E403C File Offset: 0x000E223C
	[Token(Token = "0x60029BC")]
	[Address(RVA = "0x6450B0", Offset = "0x6436B0", VA = "0x1806450B0")]
	private void Start()
	{
		this.ShowCrisis();
	}

	// Token: 0x060029BD RID: 10685 RVA: 0x000E4050 File Offset: 0x000E2250
	[Token(Token = "0x60029BD")]
	[Address(RVA = "0x644A80", Offset = "0x643080", VA = "0x180644A80")]
	public void Refresh()
	{
		if (!this.refreshable)
		{
			GameAPP.PlaySound(26, 0.5f, 1f);
			InGameText instance = InGameText.Instance;
			int num = 0;
			instance.ShowText("刷新机会已用完", 3f, num != 0);
			return;
		}
		GameAPP.UIManager.Pop();
		RogueManager instance2 = RogueManager.Instance;
		int num2 = this.level;
		instance2.CrisisManifested(num2, true);
	}

	// Token: 0x060029BE RID: 10686 RVA: 0x000E40C0 File Offset: 0x000E22C0
	[Token(Token = "0x60029BE")]
	[Address(RVA = "0x644B90", Offset = "0x643190", VA = "0x180644B90")]
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

	// Token: 0x060029BF RID: 10687 RVA: 0x000E41F4 File Offset: 0x000E23F4
	[Token(Token = "0x60029BF")]
	[Address(RVA = "0x6450C0", Offset = "0x6436C0", VA = "0x1806450C0")]
	public RogueCrisisMenu()
	{
	}

	// Token: 0x040017FD RID: 6141
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40017FD")]
	public Transform zombieHead;

	// Token: 0x040017FE RID: 6142
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40017FE")]
	public int level;

	// Token: 0x040017FF RID: 6143
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x40017FF")]
	public bool refreshable = true;
}
