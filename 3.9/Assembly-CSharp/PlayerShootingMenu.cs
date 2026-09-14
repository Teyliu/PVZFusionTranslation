using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x02000627 RID: 1575
[Token(Token = "0x2000627")]
public class PlayerShootingMenu : BaseMenu
{
	// Token: 0x06001DAE RID: 7598 RVA: 0x0009DC20 File Offset: 0x0009BE20
	[Token(Token = "0x6001DAE")]
	[Address(RVA = "0x5719D0", Offset = "0x56FFD0", VA = "0x1805719D0", Slot = "6")]
	protected override void Awake()
	{
		Player player = PlayerShootingManager.Instance.player;
		this.player = player;
		base.Awake();
	}

	// Token: 0x06001DAF RID: 7599 RVA: 0x0009DC4C File Offset: 0x0009BE4C
	[Token(Token = "0x6001DAF")]
	[Address(RVA = "0x572A80", Offset = "0x571080", VA = "0x180572A80")]
	private void Start()
	{
		if (this.first)
		{
			Array values = Enum.GetValues(typeof(PlayerWeaponType));
			if (values != 0 && values == 0)
			{
				throw new InvalidCastException();
			}
			List<PlayerWeaponType> list = Enumerable.ToList<PlayerWeaponType>(values);
			this.firstWeapons = list;
		}
		this.InitOptions();
	}

	// Token: 0x06001DB0 RID: 7600 RVA: 0x0009DC94 File Offset: 0x0009BE94
	[Token(Token = "0x6001DB0")]
	[Address(RVA = "0x572BE0", Offset = "0x5711E0", VA = "0x180572BE0")]
	private void Update()
	{
		ulong num8;
		do
		{
			int num = 0;
			if ((this.first ? 1 : 0) != num)
			{
				List<TextMeshProUGUI> list = this.refreshText;
				bool flag;
				if (flag)
				{
				}
				ulong num2;
				if (num2 != (ulong)0L)
				{
					goto IL_008F;
				}
			}
			if (this.player.refreshCount > 0)
			{
				List<TextMeshProUGUI> list2 = this.refreshText;
				bool flag2;
				if (flag2)
				{
					int refreshCount = this.player.refreshCount;
					string text = string.Format("刷新({0})", refreshCount);
				}
				ulong num3;
				if (num3 != (ulong)0L)
				{
					goto IL_009B;
				}
			}
			bool flag3;
			if (flag3)
			{
				uint num4;
				int num5;
				num4 -= (uint)num5;
				uint num6;
				num6 -= (uint)num5;
				int num7;
				string text2 = string.Format("刷新，消耗金币{0}", num7);
			}
		}
		while (num8 != (ulong)0L);
		return;
		IL_008F:
		throw new NullReferenceException();
		IL_009B:
		throw new NullReferenceException();
	}

	// Token: 0x06001DB1 RID: 7601 RVA: 0x0009DD48 File Offset: 0x0009BF48
	[Token(Token = "0x6001DB1")]
	[Address(RVA = "0x572950", Offset = "0x570F50", VA = "0x180572950")]
	public void SetOption(PlayerShootingWindow window)
	{
		if (!window.set)
		{
			Player player = this.player;
			float basicDamage = player.basicDamage;
			player.basicDamage = basicDamage;
		}
		PlayerShootingManager instance = PlayerShootingManager.Instance;
		PlayerWeaponType weaponType = window.weaponType;
		PlayerWeaponBuff buffType = window.buffType;
		instance.GetBuff(buffType, weaponType);
		GameAPP.UIManager.Pop();
		Time.timeScale = GameAPP.config.gameSpeed;
		CursorChange.SetDefaultCursor();
	}

	// Token: 0x06001DB2 RID: 7602 RVA: 0x0009DDBC File Offset: 0x0009BFBC
	[Token(Token = "0x6001DB2")]
	[Address(RVA = "0x572560", Offset = "0x570B60", VA = "0x180572560")]
	public void Refresh()
	{
		for (;;)
		{
			int num = 0;
			if ((this.first ? 1 : 0) == num)
			{
				break;
			}
			this.InitOptions();
			List<PlayerShootingWindow> list = this.options;
			bool flag;
			if (flag)
			{
			}
			ulong num2;
			if (num2 == (ulong)0L)
			{
				goto Block_3;
			}
		}
		Player player = this.player;
		uint num3;
		int num4;
		num3 -= (uint)num4;
		if (this.player.refreshCount > 0)
		{
		}
		Board.Instance.UseMoney((int)num3);
		this.InitOptions();
		List<PlayerShootingWindow> list2 = this.options;
		bool flag2;
		if (flag2)
		{
		}
		ulong num5;
		if (num5 == (ulong)0L)
		{
			int num6;
			if (num6 > 0)
			{
			}
			int num7;
			if (num7 > 0)
			{
				Board instance = Board.Instance;
				uint num8;
				num8 += num8;
				ulong num9;
				instance.GetSun((float)num8, num9 != 0UL);
			}
			return;
		}
		throw new NullReferenceException();
		Block_3:
		throw new NullReferenceException();
	}

	// Token: 0x06001DB3 RID: 7603 RVA: 0x0009DE8C File Offset: 0x0009C08C
	[Token(Token = "0x6001DB3")]
	[Address(RVA = "0x571B80", Offset = "0x570180", VA = "0x180571B80")]
	private void InitOptions()
	{
		int num;
		List<PlayerWeaponBuff> list;
		PlayerWeapon playerWeapon;
		int num2;
		do
		{
			num = 0;
			if ((this.first ? 1 : 0) != num)
			{
				goto IL_0211;
			}
			list = new List();
			if (Enumerable.Cast<PlayerWeaponType>(Enum.GetValues(typeof(PlayerWeaponType))) == 0)
			{
				goto IL_00B9;
			}
			if (num < typeof(IEnumerator).TypeHandle)
			{
				num += num;
				if (num == typeof(IEnumerator).TypeHandle)
				{
					goto IL_00AD;
				}
				num++;
			}
			List<PlayerWeapon> playerWeapons = this.player.playerWeapons;
			PlayerWeaponType playerWeaponType;
			Func<PlayerWeapon, bool> func = delegate(PlayerWeapon w)
			{
				PlayerWeaponType playerWeaponType3 = playerWeaponType;
				return w.theWeaponType == playerWeaponType3;
			};
			playerWeapon = Enumerable.FirstOrDefault<PlayerWeapon>(playerWeapons, func);
			num2 = 0;
		}
		while (!(playerWeapon != num2));
		int level = this.player.level;
		while (playerWeapon.level >= level)
		{
		}
		Dictionary<PlayerWeaponType, PlayerWeaponBuff[]> weaponBuffsMap = PlayerShootingData._weaponBuffsMap;
		bool flag;
		while (!flag)
		{
		}
		list.AddRange(num);
		IL_00AD:
		list += list;
		num += 312;
		IL_00B9:
		if ("{il2cpp array field local9->}" != (ulong)0L)
		{
		}
		if (num == 0)
		{
			int num3 = 0;
			int size = list._size;
			int num4 = size - 1;
			int num5;
			if (size > 0)
			{
				num5 = list[num4];
				Type typeFromHandle = typeof(PlayerWeaponBuff);
				string name = Enum.GetName(typeFromHandle, typeFromHandle);
				uint num6;
				if (global::UnityEngine.Random.Range(0, (int)num6) == 1 && (name.Contains("count") || name.Contains("maganize")))
				{
					list.RemoveAt(num4);
				}
			}
			if (Enum.GetValues(typeof(PlayerWeaponType)) == 0)
			{
			}
			if (num3 != 0)
			{
				List<PlayerWeaponType> list2 = Enumerable.ToList<PlayerWeaponType>(num3);
				Predicate<PlayerWeaponType> predicate = delegate(PlayerWeaponType w)
				{
					Player player = num5.player;
					bool flag2;
					return flag2;
				};
				int num7 = list2.RemoveAll(predicate);
				int size2 = list._size;
				uint num8;
				list._size = (int)num8;
				PlayerShootingWindow playerShootingWindow;
				playerShootingWindow.set = false;
				ulong num9;
				if (num9 == (ulong)0L || num3 == 0)
				{
				}
				int num10 = list._size;
				int num11 = global::UnityEngine.Random.Range(0, num10);
				num10 = num11;
				int num12 = list[num10];
				num10 = num11;
				list.RemoveAt(num10);
				if (num12 == 0)
				{
					int num13 = list2._size;
					int num14 = global::UnityEngine.Random.Range(0, num13);
					num13 = num14;
					PlayerWeaponType playerWeaponType4 = list2[num13];
					playerShootingWindow.weaponType = playerWeaponType4;
					num13 = num14;
					list2.RemoveAt(num13);
				}
				num3++;
				while (playerShootingWindow != 0)
				{
				}
				goto IL_0211;
			}
		}
		throw new InvalidCastException();
		IL_0211:
		List<PlayerShootingWindow> list3 = this.options;
		PlayerShootingWindow playerShootingWindow2 = this.options[num];
		playerShootingWindow2.set = num != 0;
		List<PlayerWeaponType> list4 = this.firstWeapons;
		playerShootingWindow2.weaponType = (PlayerWeaponType)num;
		int num15 = list4._size;
		int num16 = global::UnityEngine.Random.Range(0, num15);
		List<PlayerWeaponType> list5 = this.firstWeapons;
		num15 = num16;
		PlayerWeaponType playerWeaponType2 = list5[num15];
		playerShootingWindow2.weaponType = playerWeaponType2;
		List<PlayerWeaponType> list6 = this.firstWeapons;
		num15 = num16;
		list6.RemoveAt(num15);
		playerShootingWindow2.set = true;
		int num17 = 0;
		playerShootingWindow2.SetType((PlayerWeaponBuff)num17);
		num++;
		List<PlayerShootingWindow> list7 = this.options;
	}

	// Token: 0x06001DB4 RID: 7604 RVA: 0x0009E178 File Offset: 0x0009C378
	[Token(Token = "0x6001DB4")]
	[Address(RVA = "0x571A40", Offset = "0x570040", VA = "0x180571A40")]
	private bool CheckUpgrade(PlayerWeaponType playerWeaponType)
	{
		List<PlayerWeapon> playerWeapons = this.player.playerWeapons;
		Func<PlayerWeapon, bool> func = delegate(PlayerWeapon w)
		{
			PlayerWeaponType playerWeaponType2 = playerWeaponType;
			return w.theWeaponType == playerWeaponType2;
		};
		PlayerWeapon playerWeapon = Enumerable.FirstOrDefault<PlayerWeapon>(playerWeapons, func);
		int num = 0;
		if (playerWeapon != num)
		{
			int level = this.player.level;
			return playerWeapon.level < level;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06001DB5 RID: 7605 RVA: 0x0009E1E8 File Offset: 0x0009C3E8
	[Token(Token = "0x6001DB5")]
	[Address(RVA = "0x572FD0", Offset = "0x5715D0", VA = "0x180572FD0")]
	public PlayerShootingMenu()
	{
		List<PlayerShootingWindow> list = new List();
		this.options = list;
		List<TextMeshProUGUI> list2 = new List();
		this.refreshText = list2;
		base..ctor();
	}

	// Token: 0x04001022 RID: 4130
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001022")]
	public bool first;

	// Token: 0x04001023 RID: 4131
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4001023")]
	public List<PlayerShootingWindow> options;

	// Token: 0x04001024 RID: 4132
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4001024")]
	public List<TextMeshProUGUI> refreshText;

	// Token: 0x04001025 RID: 4133
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4001025")]
	private Player player;

	// Token: 0x04001026 RID: 4134
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4001026")]
	private List<PlayerWeaponType> firstWeapons;
}
