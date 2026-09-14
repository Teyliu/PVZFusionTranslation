using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x020007AA RID: 1962
[Token(Token = "0x20007AA")]
public static class EventManager
{
	// Token: 0x060027BE RID: 10174 RVA: 0x000D2AE0 File Offset: 0x000D0CE0
	[Token(Token = "0x60027BE")]
	[Address(RVA = "0x63A1A0", Offset = "0x6387A0", VA = "0x18063A1A0")]
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

	// Token: 0x060027BF RID: 10175 RVA: 0x000D2B38 File Offset: 0x000D0D38
	[Token(Token = "0x60027BF")]
	[Address(RVA = "0x63A370", Offset = "0x638970", VA = "0x18063A370")]
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

	// Token: 0x060027C0 RID: 10176 RVA: 0x000D2B90 File Offset: 0x000D0D90
	[Token(Token = "0x60027C0")]
	[Address(RVA = "0x63B240", Offset = "0x639840", VA = "0x18063B240")]
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

	// Token: 0x060027C1 RID: 10177 RVA: 0x000D2BDC File Offset: 0x000D0DDC
	[Token(Token = "0x60027C1")]
	[Address(RVA = "0x63B090", Offset = "0x639690", VA = "0x18063B090")]
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

	// Token: 0x060027C2 RID: 10178 RVA: 0x000D2C28 File Offset: 0x000D0E28
	[Token(Token = "0x60027C2")]
	[Address(RVA = "0x63A080", Offset = "0x638680", VA = "0x18063A080")]
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

	// Token: 0x060027C3 RID: 10179 RVA: 0x000D2C78 File Offset: 0x000D0E78
	[Token(Token = "0x60027C3")]
	[Address(RVA = "0x63B3D0", Offset = "0x6399D0", VA = "0x18063B3D0")]
	public static void TriggerEvent(GameEvent eventName)
	{
		Dictionary<GameEvent, Action> dictionary = EventManager.enumEventDictionary;
		bool flag;
		ulong num;
		if (!flag || num != (ulong)0L)
		{
		}
	}

	// Token: 0x060027C4 RID: 10180 RVA: 0x000D2C9C File Offset: 0x000D0E9C
	[Token(Token = "0x60027C4")]
	[Address(RVA = "0x63B480", Offset = "0x639A80", VA = "0x18063B480")]
	public static void TriggerEvent(GameEvent eventName, object data)
	{
		Dictionary<GameEvent, Action<object>> dictionary = EventManager.enumEventWithDataDictionary;
		bool flag;
		ulong num;
		if (!flag || num != (ulong)0L)
		{
		}
	}

	// Token: 0x060027C5 RID: 10181 RVA: 0x000D2CC0 File Offset: 0x000D0EC0
	[Token(Token = "0x60027C5")]
	[Address(RVA = "0x63B000", Offset = "0x639600", VA = "0x18063B000")]
	private static void Log(string text)
	{
		Debug.Log(text);
	}

	// Token: 0x060027C6 RID: 10182 RVA: 0x000D2CD4 File Offset: 0x000D0ED4
	[Token(Token = "0x60027C6")]
	[Address(RVA = "0x63A550", Offset = "0x638B50", VA = "0x18063A550")]
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

	// Token: 0x060027C7 RID: 10183 RVA: 0x000D2E78 File Offset: 0x000D1078
	[Token(Token = "0x60027C7")]
	[Address(RVA = "0x63AEA0", Offset = "0x6394A0", VA = "0x18063AEA0")]
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

	// Token: 0x060027C8 RID: 10184 RVA: 0x000D2EA0 File Offset: 0x000D10A0
	[Token(Token = "0x60027C8")]
	[Address(RVA = "0x63AF60", Offset = "0x639560", VA = "0x18063AF60")]
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

	// Token: 0x060027C9 RID: 10185 RVA: 0x000D2EC4 File Offset: 0x000D10C4
	[Token(Token = "0x60027C9")]
	[Address(RVA = "0x63AD20", Offset = "0x639320", VA = "0x18063AD20")]
	public static void ForceClearAllEvents()
	{
		EventManager.enumEventDictionary.Clear();
		EventManager.enumEventWithDataDictionary.Clear();
		EventManager.dontDestroyListeners.Clear();
		EventManager.dontDestroyListenersWithData.Clear();
	}

	// Token: 0x060027CA RID: 10186 RVA: 0x000D2F00 File Offset: 0x000D1100
	[Token(Token = "0x60027CA")]
	[Address(RVA = "0x63AE20", Offset = "0x639420", VA = "0x18063AE20")]
	public static int GetDontDestroyListenerCount()
	{
		HashSet<Action> hashSet = EventManager.dontDestroyListeners;
		return EventManager.dontDestroyListenersWithData._count;
	}

	// Token: 0x04001512 RID: 5394
	[Token(Token = "0x4001512")]
	public static bool enableLog;

	// Token: 0x04001513 RID: 5395
	[Token(Token = "0x4001513")]
	private static readonly Dictionary<GameEvent, Action> enumEventDictionary = new Dictionary();

	// Token: 0x04001514 RID: 5396
	[Token(Token = "0x4001514")]
	private static readonly Dictionary<GameEvent, Action<object>> enumEventWithDataDictionary = new Dictionary();

	// Token: 0x04001515 RID: 5397
	[Token(Token = "0x4001515")]
	private static readonly HashSet<Action> dontDestroyListeners = new HashSet();

	// Token: 0x04001516 RID: 5398
	[Token(Token = "0x4001516")]
	private static readonly HashSet<Action<object>> dontDestroyListenersWithData = new HashSet();
}
