using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;

// Token: 0x020005F2 RID: 1522
[Token(Token = "0x20005F2")]
public class PlayerShootingMenu : BaseMenu
{
	// Token: 0x06001CAF RID: 7343 RVA: 0x000990D8 File Offset: 0x000972D8
	[Token(Token = "0x6001CAF")]
	[Address(RVA = "0x5062B0", Offset = "0x5048B0", VA = "0x1805062B0", Slot = "6")]
	protected override void Awake()
	{
		Player player = PlayerShootingManager.Instance.player;
		this.player = player;
		base.Awake();
	}

	// Token: 0x06001CB0 RID: 7344 RVA: 0x00099104 File Offset: 0x00097304
	[Token(Token = "0x6001CB0")]
	[Address(RVA = "0x507350", Offset = "0x505950", VA = "0x180507350")]
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

	// Token: 0x06001CB1 RID: 7345 RVA: 0x00099150 File Offset: 0x00097350
	[Token(Token = "0x6001CB1")]
	[Address(RVA = "0x5074B0", Offset = "0x505AB0", VA = "0x1805074B0")]
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

	// Token: 0x06001CB2 RID: 7346 RVA: 0x00099204 File Offset: 0x00097404
	[Token(Token = "0x6001CB2")]
	[Address(RVA = "0x507220", Offset = "0x505820", VA = "0x180507220")]
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

	// Token: 0x06001CB3 RID: 7347 RVA: 0x00099278 File Offset: 0x00097478
	[Token(Token = "0x6001CB3")]
	[Address(RVA = "0x506E40", Offset = "0x505440", VA = "0x180506E40")]
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

	// Token: 0x06001CB4 RID: 7348 RVA: 0x00099360 File Offset: 0x00097560
	[Token(Token = "0x6001CB4")]
	[Address(RVA = "0x506460", Offset = "0x504A60", VA = "0x180506460")]
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
				goto IL_01FD;
			}
			list = new List();
			if (Enumerable.Cast<PlayerWeaponType>(Enum.GetValues(typeof(PlayerWeaponType))) == 0)
			{
				goto IL_00A5;
			}
			if (num < typeof(IEnumerator).TypeHandle)
			{
				num += num;
				if (num == typeof(IEnumerator).TypeHandle)
				{
					goto IL_0099;
				}
				num++;
			}
			Func<PlayerWeapon, bool> func;
			playerWeapon = Enumerable.FirstOrDefault<PlayerWeapon>(this.player.playerWeapons, func);
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
		IL_0099:
		list += list;
		num += 312;
		IL_00A5:
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
					PlayerWeaponType playerWeaponType3 = list2[num13];
					playerShootingWindow.weaponType = playerWeaponType3;
					num13 = num14;
					list2.RemoveAt(num13);
				}
				num3++;
				while (playerShootingWindow != 0)
				{
				}
				goto IL_01FD;
			}
		}
		throw new InvalidCastException();
		IL_01FD:
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

	// Token: 0x06001CB5 RID: 7349 RVA: 0x00099638 File Offset: 0x00097838
	[Token(Token = "0x6001CB5")]
	[Address(RVA = "0x506320", Offset = "0x504920", VA = "0x180506320")]
	private bool CheckUpgrade(PlayerWeaponType playerWeaponType)
	{
		new PlayerShootingMenu.<>c__DisplayClass11_0().playerWeaponType = playerWeaponType;
		Func<PlayerWeapon, bool> func;
		PlayerWeapon playerWeapon = Enumerable.FirstOrDefault<PlayerWeapon>(this.player.playerWeapons, func);
		int num = 0;
		if (playerWeapon != num)
		{
			int level = this.player.level;
			return playerWeapon.level < level;
		}
		throw new NullReferenceException();
	}

	// Token: 0x06001CB6 RID: 7350 RVA: 0x00099690 File Offset: 0x00097890
	[Token(Token = "0x6001CB6")]
	[Address(RVA = "0x5078A0", Offset = "0x505EA0", VA = "0x1805078A0")]
	public PlayerShootingMenu()
	{
		List<PlayerShootingWindow> list = new List();
		this.options = list;
		List<TextMeshProUGUI> list2 = new List();
		this.refreshText = list2;
		base..ctor();
	}

	// Token: 0x04000F5A RID: 3930
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000F5A")]
	public bool first;

	// Token: 0x04000F5B RID: 3931
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000F5B")]
	public List<PlayerShootingWindow> options;

	// Token: 0x04000F5C RID: 3932
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000F5C")]
	public List<TextMeshProUGUI> refreshText;

	// Token: 0x04000F5D RID: 3933
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000F5D")]
	private Player player;

	// Token: 0x04000F5E RID: 3934
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x4000F5E")]
	private List<PlayerWeaponType> firstWeapons;
}
