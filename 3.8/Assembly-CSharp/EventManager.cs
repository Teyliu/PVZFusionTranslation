using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000771 RID: 1905
[Token(Token = "0x2000771")]
public static class EventManager
{
	// Token: 0x0600268F RID: 9871 RVA: 0x000CDA74 File Offset: 0x000CBC74
	[Token(Token = "0x600268F")]
	[Address(RVA = "0x5D72B0", Offset = "0x5D58B0", VA = "0x1805D72B0")]
	public static void AddListener(GameEvent eventName, Action listener, bool dontDestroy = false)
	{
		int num = 0;
		if (dontDestroy)
		{
			bool flag = EventManager.dontDestroyListeners.Add(listener);
		}
		Dictionary<GameEvent, Action> dictionary = EventManager.enumEventDictionary;
		bool flag2;
		if (!flag2)
		{
			Dictionary<GameEvent, Action> dictionary2 = EventManager.enumEventDictionary;
			return;
		}
		Dictionary<GameEvent, Action> dictionary3 = EventManager.enumEventDictionary;
		Delegate @delegate = Delegate.Combine(num, listener);
		if (@delegate == 0 || @delegate != 0)
		{
			throw new NullReferenceException();
		}
		throw new InvalidCastException();
	}

	// Token: 0x06002690 RID: 9872 RVA: 0x000CDACC File Offset: 0x000CBCCC
	[Token(Token = "0x6002690")]
	[Address(RVA = "0x5D7480", Offset = "0x5D5A80", VA = "0x1805D7480")]
	public static void AddListener_obj(GameEvent eventName, Action<object> listener, bool dontDestroy = false)
	{
		int num = 0;
		if (dontDestroy)
		{
			bool flag = EventManager.dontDestroyListenersWithData.Add(listener);
		}
		Dictionary<GameEvent, Action<object>> dictionary = EventManager.enumEventWithDataDictionary;
		bool flag2;
		if (!flag2)
		{
			Dictionary<GameEvent, Action<object>> dictionary2 = EventManager.enumEventWithDataDictionary;
		}
		Dictionary<GameEvent, Action<object>> dictionary3 = EventManager.enumEventWithDataDictionary;
		Delegate @delegate = Delegate.Combine(num, listener);
		if (@delegate == 0 || @delegate != 0)
		{
			return;
		}
		throw new InvalidCastException();
	}

	// Token: 0x06002691 RID: 9873 RVA: 0x000CDB24 File Offset: 0x000CBD24
	[Token(Token = "0x6002691")]
	[Address(RVA = "0x5D8350", Offset = "0x5D6950", VA = "0x1805D8350")]
	public static void RemoveListener(GameEvent eventName, Action listener)
	{
		int num = 0;
		Dictionary<GameEvent, Action> dictionary = EventManager.enumEventDictionary;
		bool flag;
		if (flag)
		{
			Dictionary<GameEvent, Action> dictionary2 = EventManager.enumEventDictionary;
			Delegate @delegate = Delegate.Remove(num, listener);
			if (@delegate != 0 && @delegate == 0)
			{
				throw new InvalidCastException();
			}
		}
		bool flag2 = EventManager.dontDestroyListeners.Remove(listener);
	}

	// Token: 0x06002692 RID: 9874 RVA: 0x000CDB70 File Offset: 0x000CBD70
	[Token(Token = "0x6002692")]
	[Address(RVA = "0x5D81A0", Offset = "0x5D67A0", VA = "0x1805D81A0")]
	public static void RemoveListener(GameEvent eventName, Action<object> listener)
	{
		int num = 0;
		Dictionary<GameEvent, Action<object>> dictionary = EventManager.enumEventWithDataDictionary;
		bool flag;
		if (flag)
		{
			Dictionary<GameEvent, Action<object>> dictionary2 = EventManager.enumEventWithDataDictionary;
			Delegate @delegate = Delegate.Remove(num, listener);
			if (@delegate != 0 && @delegate == 0)
			{
				throw new InvalidCastException();
			}
		}
		bool flag2 = EventManager.dontDestroyListenersWithData.Remove(listener);
	}

	// Token: 0x06002693 RID: 9875 RVA: 0x000CDBBC File Offset: 0x000CBDBC
	[Token(Token = "0x6002693")]
	[Address(RVA = "0x5D7190", Offset = "0x5D5790", VA = "0x1805D7190")]
	public static void AddListenerOnce(GameEvent eventName, Action listener)
	{
		Action wrapper = (ulong)0L;
		Action action = delegate
		{
			if (listener != 0)
			{
			}
			GameEvent eventName3 = eventName;
			Action wrapper2 = wrapper;
			int num = 0;
			Dictionary<GameEvent, Action> dictionary = EventManager.enumEventDictionary;
			bool flag;
			if (flag)
			{
				Dictionary<GameEvent, Action> dictionary2 = EventManager.enumEventDictionary;
				Delegate @delegate = Delegate.Remove(num, wrapper2);
				if (@delegate != 0 && @delegate == 0)
				{
					throw new InvalidCastException();
				}
			}
			bool flag2 = EventManager.dontDestroyListeners.Remove(wrapper2);
		};
		wrapper = action;
		GameEvent eventName2 = eventName;
	}

	// Token: 0x06002694 RID: 9876 RVA: 0x000CDC0C File Offset: 0x000CBE0C
	[Token(Token = "0x6002694")]
	[Address(RVA = "0x5D84E0", Offset = "0x5D6AE0", VA = "0x1805D84E0")]
	public static void TriggerEvent(GameEvent eventName)
	{
		Dictionary<GameEvent, Action> dictionary = EventManager.enumEventDictionary;
		bool flag;
		ulong num;
		if (!flag || num != (ulong)0L)
		{
		}
	}

	// Token: 0x06002695 RID: 9877 RVA: 0x000CDC30 File Offset: 0x000CBE30
	[Token(Token = "0x6002695")]
	[Address(RVA = "0x5D8590", Offset = "0x5D6B90", VA = "0x1805D8590")]
	public static void TriggerEvent(GameEvent eventName, object data)
	{
		Dictionary<GameEvent, Action<object>> dictionary = EventManager.enumEventWithDataDictionary;
		bool flag;
		ulong num;
		if (!flag || num != (ulong)0L)
		{
		}
	}

	// Token: 0x06002696 RID: 9878 RVA: 0x000CDC54 File Offset: 0x000CBE54
	[Token(Token = "0x6002696")]
	[Address(RVA = "0x5D8110", Offset = "0x5D6710", VA = "0x1805D8110")]
	private static void Log(string text)
	{
		Debug.Log(text);
	}

	// Token: 0x06002697 RID: 9879 RVA: 0x000CDC68 File Offset: 0x000CBE68
	[Token(Token = "0x6002697")]
	[Address(RVA = "0x5D7660", Offset = "0x5D5C60", VA = "0x1805D7660")]
	public static void ClearAllEvents()
	{
		ulong num8;
		do
		{
			int num = 0;
			List<GameEvent> list = new List(EventManager.enumEventDictionary.Keys);
			bool flag;
			if (flag)
			{
				if (!EventManager.enumEventDictionary.TryGetValue(num, num))
				{
					continue;
				}
				while (num == 0)
				{
				}
				int num2 = 0;
				HashSet<Action> hashSet = EventManager.dontDestroyListeners;
				int num3 = 0;
				if (list != 0 && list == 0)
				{
					goto IL_013C;
				}
				Delegate @delegate;
				if (hashSet.Contains(num3))
				{
					if (list != 0 && list == 0)
					{
						goto IL_0136;
					}
					if (@delegate != 0 && @delegate == 0)
					{
						goto IL_0130;
					}
				}
				num2++;
				if (@delegate == 0)
				{
					bool flag2 = EventManager.enumEventDictionary.Remove(num);
				}
				Dictionary<GameEvent, Action> dictionary = EventManager.enumEventDictionary;
			}
			ulong num4;
			if (num4 != (ulong)0L)
			{
				goto IL_0160;
			}
			List<GameEvent> list2 = new List(EventManager.enumEventWithDataDictionary.Keys);
			bool flag3;
			if (flag3)
			{
				if (EventManager.enumEventWithDataDictionary.TryGetValue(num, num))
				{
					while (num == 0)
					{
					}
					int num5 = 0;
					int num6 = 0;
					HashSet<Action<object>> hashSet2 = EventManager.dontDestroyListenersWithData;
					if (num == 0)
					{
					}
					bool flag4;
					if (!flag4)
					{
						goto IL_00FB;
					}
					int num7;
					if (num == 0)
					{
						num7 = 0;
					}
					if (num7 == 0)
					{
						goto IL_016C;
					}
					Delegate delegate2 = Delegate.Combine(num6, num7);
					if (delegate2 == 0)
					{
						goto IL_00FB;
					}
					IL_0101:
					if (delegate2 != 0)
					{
						if (delegate2 == 0)
						{
							bool flag5 = EventManager.enumEventWithDataDictionary.Remove(num);
						}
						Dictionary<GameEvent, Action<object>> dictionary2 = EventManager.enumEventWithDataDictionary;
						goto IL_011F;
					}
					goto IL_0166;
					IL_00FB:
					num5++;
					goto IL_0101;
				}
				continue;
			}
			IL_011F:;
		}
		while (num8 != (ulong)0L);
		return;
		IL_0130:
		throw new InvalidCastException();
		IL_0136:
		throw new InvalidCastException();
		IL_013C:
		throw new InvalidCastException();
		IL_0160:
		throw new IndexOutOfRangeException();
		IL_0166:
		throw new InvalidCastException();
		IL_016C:
		throw new InvalidCastException();
	}

	// Token: 0x06002698 RID: 9880 RVA: 0x000CDE0C File Offset: 0x000CC00C
	[Token(Token = "0x6002698")]
	[Address(RVA = "0x5D7FB0", Offset = "0x5D65B0", VA = "0x1805D7FB0")]
	public static int GetListenerCount(GameEvent eventName)
	{
		Dictionary<GameEvent, Action> dictionary = EventManager.enumEventDictionary;
		bool flag;
		ulong num;
		if (!flag || num != (ulong)0L)
		{
		}
		return 0;
	}

	// Token: 0x06002699 RID: 9881 RVA: 0x000CDE34 File Offset: 0x000CC034
	[Token(Token = "0x6002699")]
	[Address(RVA = "0x5D8070", Offset = "0x5D6670", VA = "0x1805D8070")]
	public static bool HasListener(GameEvent eventName)
	{
		Dictionary<GameEvent, Action> dictionary = EventManager.enumEventDictionary;
		bool flag;
		if (!flag)
		{
			return flag;
		}
		return flag;
	}

	// Token: 0x0600269A RID: 9882 RVA: 0x000CDE58 File Offset: 0x000CC058
	[Token(Token = "0x600269A")]
	[Address(RVA = "0x5D7E30", Offset = "0x5D6430", VA = "0x1805D7E30")]
	public static void ForceClearAllEvents()
	{
		EventManager.enumEventDictionary.Clear();
		EventManager.enumEventWithDataDictionary.Clear();
		EventManager.dontDestroyListeners.Clear();
		EventManager.dontDestroyListenersWithData.Clear();
	}

	// Token: 0x0600269B RID: 9883 RVA: 0x000CDE94 File Offset: 0x000CC094
	[Token(Token = "0x600269B")]
	[Address(RVA = "0x5D7F30", Offset = "0x5D6530", VA = "0x1805D7F30")]
	public static int GetDontDestroyListenerCount()
	{
		HashSet<Action> hashSet = EventManager.dontDestroyListeners;
		return EventManager.dontDestroyListenersWithData._count;
	}

	// Token: 0x04001436 RID: 5174
	[Token(Token = "0x4001436")]
	public static bool enableLog;

	// Token: 0x04001437 RID: 5175
	[Token(Token = "0x4001437")]
	private static readonly Dictionary<GameEvent, Action> enumEventDictionary = new Dictionary();

	// Token: 0x04001438 RID: 5176
	[Token(Token = "0x4001438")]
	private static readonly Dictionary<GameEvent, Action<object>> enumEventWithDataDictionary = new Dictionary();

	// Token: 0x04001439 RID: 5177
	[Token(Token = "0x4001439")]
	private static readonly HashSet<Action> dontDestroyListeners = new HashSet();

	// Token: 0x0400143A RID: 5178
	[Token(Token = "0x400143A")]
	private static readonly HashSet<Action<object>> dontDestroyListenersWithData = new HashSet();
}
