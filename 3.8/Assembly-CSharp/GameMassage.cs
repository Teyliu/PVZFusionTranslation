using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine.Events;

// Token: 0x0200099F RID: 2463
[Token(Token = "0x200099F")]
public class GameMassage
{
	// Token: 0x170001D5 RID: 469
	// (get) Token: 0x06003223 RID: 12835 RVA: 0x00108904 File Offset: 0x00106B04
	[Token(Token = "0x170001D5")]
	public static GameMassage Instance
	{
		[Token(Token = "0x6003223")]
		[Address(RVA = "0x6E5F00", Offset = "0x6E4500", VA = "0x1806E5F00")]
		get
		{
			GameMassage gameMassage = new GameMassage();
			Dictionary<string, EventInfo> dictionary = new Dictionary();
			gameMassage._eventDic = dictionary;
			GameMassage._instance = gameMassage;
			return GameMassage._instance;
		}
	}

	// Token: 0x06003224 RID: 12836 RVA: 0x00108930 File Offset: 0x00106B30
	[Token(Token = "0x6003224")]
	[Address(RVA = "0x6E5A50", Offset = "0x6E4050", VA = "0x1806E5A50")]
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

	// Token: 0x06003225 RID: 12837 RVA: 0x001089D8 File Offset: 0x00106BD8
	[Token(Token = "0x6003225")]
	[Address(RVA = "0x6E5CB0", Offset = "0x6E42B0", VA = "0x1806E5CB0")]
	public void EventTrigger(string name)
	{
		if (this._eventDic.ContainsKey(name) && this._eventDic[name].actions != (ulong)0L)
		{
			UnityAction actions = this._eventDic[name].actions;
		}
	}

	// Token: 0x06003226 RID: 12838 RVA: 0x00108A24 File Offset: 0x00106C24
	[Token(Token = "0x6003226")]
	[Address(RVA = "0x9AB210", Offset = "0x9A9810", VA = "0x1809AB210")]
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

	// Token: 0x06003227 RID: 12839 RVA: 0x00108AA4 File Offset: 0x00106CA4
	[Token(Token = "0x6003227")]
	[Address(RVA = "0x9AB3E0", Offset = "0x9A99E0", VA = "0x1809AB3E0")]
	public void EventTrigger<T>(string name)
	{
		if (this._eventDic.ContainsKey(name) && this._eventDic[name].actions != (ulong)0L)
		{
			UnityAction actions = this._eventDic[name].actions;
		}
	}

	// Token: 0x06003228 RID: 12840 RVA: 0x00108AF0 File Offset: 0x00106CF0
	[Token(Token = "0x6003228")]
	[Address(RVA = "0x6E5D70", Offset = "0x6E4370", VA = "0x1806E5D70")]
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

	// Token: 0x06003229 RID: 12841 RVA: 0x00108B50 File Offset: 0x00106D50
	[Token(Token = "0x6003229")]
	[Address(RVA = "0x6E5C60", Offset = "0x6E4260", VA = "0x1806E5C60")]
	public void Clear()
	{
		this._eventDic.Clear();
	}

	// Token: 0x0600322A RID: 12842 RVA: 0x00108B70 File Offset: 0x00106D70
	[Token(Token = "0x600322A")]
	[Address(RVA = "0x6E5E80", Offset = "0x6E4480", VA = "0x1806E5E80")]
	public GameMassage()
	{
		Dictionary<string, EventInfo> dictionary = new Dictionary();
		this._eventDic = dictionary;
		base..ctor();
	}

	// Token: 0x0400241D RID: 9245
	[Token(Token = "0x400241D")]
	private static GameMassage _instance;

	// Token: 0x0400241E RID: 9246
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400241E")]
	private readonly Dictionary<string, EventInfo> _eventDic;
}
