using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine.Events;

// Token: 0x020009DB RID: 2523
[Token(Token = "0x20009DB")]
public class GameMassage
{
	// Token: 0x1700021D RID: 541
	// (get) Token: 0x06003357 RID: 13143 RVA: 0x0010D6D8 File Offset: 0x0010B8D8
	[Token(Token = "0x1700021D")]
	public static GameMassage Instance
	{
		[Token(Token = "0x6003357")]
		[Address(RVA = "0x74B410", Offset = "0x749A10", VA = "0x18074B410")]
		get
		{
			GameMassage gameMassage = new GameMassage();
			Dictionary<string, EventInfo> dictionary = new Dictionary();
			gameMassage._eventDic = dictionary;
			GameMassage._instance = gameMassage;
			return GameMassage._instance;
		}
	}

	// Token: 0x06003358 RID: 13144 RVA: 0x0010D704 File Offset: 0x0010B904
	[Token(Token = "0x6003358")]
	[Address(RVA = "0x74AF60", Offset = "0x749560", VA = "0x18074AF60")]
	public void AddEventListener(string name, UnityAction action)
	{
		bool flag = this._eventDic.ContainsKey(name);
		Dictionary<string, EventInfo> eventDic = this._eventDic;
		if (!flag)
		{
			EventInfo eventInfo;
			Delegate @delegate = Delegate.Combine(eventInfo.actions, action);
			int num = 0;
			if (@delegate == 0)
			{
				eventInfo.actions = num;
			}
			if (@delegate != 0)
			{
				eventInfo.actions = @delegate;
				if (@delegate != 0)
				{
					eventDic.Add(name, eventInfo);
					return;
				}
			}
			throw new InvalidCastException();
		}
		EventInfo eventInfo2 = eventDic[name];
		Delegate delegate2 = Delegate.Combine(eventInfo2.actions, action);
		int num2 = 0;
		if (delegate2 == 0)
		{
			eventInfo2.actions = num2;
		}
		if (delegate2 != 0)
		{
			eventInfo2.actions = delegate2;
			if (delegate2 != 0)
			{
				throw new NullReferenceException();
			}
		}
		throw new InvalidCastException();
	}

	// Token: 0x06003359 RID: 13145 RVA: 0x0010D7AC File Offset: 0x0010B9AC
	[Token(Token = "0x6003359")]
	[Address(RVA = "0x74B1C0", Offset = "0x7497C0", VA = "0x18074B1C0")]
	public void EventTrigger(string name)
	{
		if (this._eventDic.ContainsKey(name) && this._eventDic[name].actions != (ulong)0L)
		{
			UnityAction actions = this._eventDic[name].actions;
		}
	}

	// Token: 0x0600335A RID: 13146 RVA: 0x0010D7F8 File Offset: 0x0010B9F8
	[Token(Token = "0x600335A")]
	[Address(RVA = "0xA547D0", Offset = "0xA52DD0", VA = "0x180A547D0")]
	public void AddEventListener<T>(string name, UnityAction action)
	{
		if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
		{
		}
		bool flag = this._eventDic.ContainsKey(name);
		Dictionary<string, EventInfo> eventDic = this._eventDic;
		if (!flag)
		{
			EventInfo eventInfo = new EventInfo(action);
			eventDic.Add(name, eventInfo);
			return;
		}
		EventInfo eventInfo2;
		UnityAction actions = eventInfo2.actions;
		int num = 0;
		Delegate @delegate;
		if (@delegate == 0)
		{
			eventInfo2.actions = num;
		}
		if (@delegate != 0)
		{
			eventInfo2.actions = @delegate;
			if (@delegate != 0)
			{
				throw new NullReferenceException();
			}
		}
		throw new InvalidCastException();
	}

	// Token: 0x0600335B RID: 13147 RVA: 0x0010D878 File Offset: 0x0010BA78
	[Token(Token = "0x600335B")]
	[Address(RVA = "0xA549A0", Offset = "0xA52FA0", VA = "0x180A549A0")]
	public void EventTrigger<T>(string name)
	{
		if (this._eventDic.ContainsKey(name) && this._eventDic[name].actions != (ulong)0L)
		{
			UnityAction actions = this._eventDic[name].actions;
		}
	}

	// Token: 0x0600335C RID: 13148 RVA: 0x0010D8C4 File Offset: 0x0010BAC4
	[Token(Token = "0x600335C")]
	[Address(RVA = "0x74B280", Offset = "0x749880", VA = "0x18074B280")]
	public void RemoveEventLister(string name, UnityAction action)
	{
		if (this._eventDic.ContainsKey(name))
		{
			EventInfo eventInfo = this._eventDic[name];
			Delegate @delegate = Delegate.Remove(eventInfo.actions, action);
			int num = 0;
			if (@delegate == 0)
			{
				eventInfo.actions = num;
			}
			if (@delegate != 0)
			{
				eventInfo.actions = @delegate;
				if (@delegate != 0)
				{
					return;
				}
			}
			throw new InvalidCastException();
		}
	}

	// Token: 0x0600335D RID: 13149 RVA: 0x0010D924 File Offset: 0x0010BB24
	[Token(Token = "0x600335D")]
	[Address(RVA = "0x74B170", Offset = "0x749770", VA = "0x18074B170")]
	public void Clear()
	{
		this._eventDic.Clear();
	}

	// Token: 0x0600335E RID: 13150 RVA: 0x0010D944 File Offset: 0x0010BB44
	[Token(Token = "0x600335E")]
	[Address(RVA = "0x74B390", Offset = "0x749990", VA = "0x18074B390")]
	public GameMassage()
	{
		Dictionary<string, EventInfo> dictionary = new Dictionary();
		this._eventDic = dictionary;
		base..ctor();
	}

	// Token: 0x0400252E RID: 9518
	[Token(Token = "0x400252E")]
	private static GameMassage _instance;

	// Token: 0x0400252F RID: 9519
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400252F")]
	private readonly Dictionary<string, EventInfo> _eventDic;
}
