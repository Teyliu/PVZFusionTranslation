using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020005ED RID: 1517
[Token(Token = "0x20005ED")]
public class FruitNinjaMenu : BaseMenu
{
	// Token: 0x06001C95 RID: 7317 RVA: 0x00098920 File Offset: 0x00096B20
	[Token(Token = "0x6001C95")]
	[Address(RVA = "0x505210", Offset = "0x503810", VA = "0x180505210")]
	private IEnumerator Start()
	{
		FruitNinjaMenu.<Start>d__1 <Start>d__;
		<Start>d__.System.IDisposable.Dispose();
		<Start>d__.<>1__state = (int)((ulong)0L);
		<Start>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06001C96 RID: 7318 RVA: 0x00098944 File Offset: 0x00096B44
	[Token(Token = "0x6001C96")]
	[Address(RVA = "0x504B60", Offset = "0x503160", VA = "0x180504B60", Slot = "6")]
	protected override void Awake()
	{
		base.Awake();
		this.InitOptions();
	}

	// Token: 0x06001C97 RID: 7319 RVA: 0x00098960 File Offset: 0x00096B60
	[Token(Token = "0x6001C97")]
	[Address(RVA = "0x505120", Offset = "0x503720", VA = "0x180505120")]
	public void SetOption(FruitNinjaSelectWindow window)
	{
		FruitNinjaManager instance = FruitNinjaManager.Instance;
		FruitBuffType buffType = window.buffType;
		instance.GetNewBuff(buffType);
		GameAPP.UIManager.Pop();
		Time.timeScale = GameAPP.config.gameSpeed;
		CursorChange.SetDefaultCursor();
	}

	// Token: 0x06001C98 RID: 7320 RVA: 0x000989A8 File Offset: 0x00096BA8
	[Token(Token = "0x6001C98")]
	[Address(RVA = "0x504B80", Offset = "0x503180", VA = "0x180504B80")]
	private void InitOptions()
	{
		int num = 0;
		Array values = Enum.GetValues(typeof(FruitBuffType));
		if (values == 0)
		{
		}
		if (values != 0)
		{
			List<FruitBuffType> list = Enumerable.ToList<FruitBuffType>(values);
			int size = list._size;
			int num2 = size - 1;
			if (size > 0)
			{
				FruitBuffType fruitBuffType = list[num2];
				FruitNinjaManager instance = FruitNinjaManager.Instance;
				bool flag;
				if (flag)
				{
					Dictionary<FruitBuffType, ValueTuple<string, int>> buffDescriptions = FruitNinjaManager.Instance.BuffDescriptions;
					bool flag2;
					if (flag2)
					{
						int num3 = num2;
						list.RemoveAt(num3);
					}
				}
			}
			if (!FruitNinjaManager.Instance.TryGetBuffCount((FruitBuffType)((uint)11), num))
			{
				bool flag3 = list.Remove((uint)16);
			}
			if (!FruitNinjaManager.Instance.TryGetBuffCount((FruitBuffType)((uint)16), num))
			{
				bool flag4 = list.Remove((uint)17);
			}
			if (!FruitNinjaManager.Instance.TryGetBuffCount((FruitBuffType)((uint)10), num))
			{
				bool flag5 = list.Remove((uint)18);
			}
			if (!FruitNinjaManager.Instance.TryGetBuffCount((FruitBuffType)((uint)18), num))
			{
				bool flag6 = list.Remove((uint)19);
			}
			if (!FruitNinjaManager.Instance.TryGetBuffCount((FruitBuffType)((uint)15), num))
			{
				bool flag7 = list.Remove((uint)20);
			}
			if (!FruitNinjaManager.Instance.TryGetBuffCount((FruitBuffType)((uint)20), num))
			{
				bool flag8 = list.Remove((uint)21);
			}
			if (!FruitNinjaManager.Instance.TryGetBuffCount((FruitBuffType)((uint)22), num))
			{
				bool flag9 = list.Remove((uint)23);
			}
			if (!FruitNinjaManager.Instance.TryGetBuffCount((FruitBuffType)((uint)23), num))
			{
				bool flag10 = list.Remove((uint)24);
			}
			List<FruitNinjaSelectWindow> list2 = this.options;
			bool flag11;
			if (flag11)
			{
				int num4 = list._size;
				int num5 = global::UnityEngine.Random.Range(0, num4);
				num4 = num5;
				FruitBuffType fruitBuffType2 = list[num4];
				num4 = num5;
				list.RemoveAt(num4);
			}
			if (num == 0)
			{
				return;
			}
		}
		throw new InvalidCastException();
	}

	// Token: 0x06001C99 RID: 7321 RVA: 0x00098B68 File Offset: 0x00096D68
	[Token(Token = "0x6001C99")]
	[Address(RVA = "0x505280", Offset = "0x503880", VA = "0x180505280")]
	public FruitNinjaMenu()
	{
		List<FruitNinjaSelectWindow> list = new List();
		this.options = list;
		base..ctor();
	}

	// Token: 0x04000F4B RID: 3915
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000F4B")]
	public List<FruitNinjaSelectWindow> options;
}
