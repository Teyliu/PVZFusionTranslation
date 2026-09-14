using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000622 RID: 1570
[Token(Token = "0x2000622")]
public class FruitNinjaMenu : BaseMenu
{
	// Token: 0x06001D94 RID: 7572 RVA: 0x0009D470 File Offset: 0x0009B670
	[Token(Token = "0x6001D94")]
	[Address(RVA = "0x570920", Offset = "0x56EF20", VA = "0x180570920")]
	private IEnumerator Start()
	{
		FruitNinjaMenu.<Start>d__1 <Start>d__;
		<Start>d__.System.IDisposable.Dispose();
		<Start>d__.<>1__state = (int)((ulong)0L);
		<Start>d__.<>4__this = this;
		return null;
	}

	// Token: 0x06001D95 RID: 7573 RVA: 0x0009D494 File Offset: 0x0009B694
	[Token(Token = "0x6001D95")]
	[Address(RVA = "0x570270", Offset = "0x56E870", VA = "0x180570270", Slot = "6")]
	protected override void Awake()
	{
		base.Awake();
		this.InitOptions();
	}

	// Token: 0x06001D96 RID: 7574 RVA: 0x0009D4B0 File Offset: 0x0009B6B0
	[Token(Token = "0x6001D96")]
	[Address(RVA = "0x570830", Offset = "0x56EE30", VA = "0x180570830")]
	public void SetOption(FruitNinjaSelectWindow window)
	{
		FruitNinjaManager instance = FruitNinjaManager.Instance;
		FruitBuffType buffType = window.buffType;
		instance.GetNewBuff(buffType);
		GameAPP.UIManager.Pop();
		Time.timeScale = GameAPP.config.gameSpeed;
		CursorChange.SetDefaultCursor();
	}

	// Token: 0x06001D97 RID: 7575 RVA: 0x0009D4F8 File Offset: 0x0009B6F8
	[Token(Token = "0x6001D97")]
	[Address(RVA = "0x570290", Offset = "0x56E890", VA = "0x180570290")]
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

	// Token: 0x06001D98 RID: 7576 RVA: 0x0009D6B8 File Offset: 0x0009B8B8
	[Token(Token = "0x6001D98")]
	[Address(RVA = "0x570990", Offset = "0x56EF90", VA = "0x180570990")]
	public FruitNinjaMenu()
	{
		List<FruitNinjaSelectWindow> list = new List();
		this.options = list;
		base..ctor();
	}

	// Token: 0x04001013 RID: 4115
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4001013")]
	public List<FruitNinjaSelectWindow> options;
}
