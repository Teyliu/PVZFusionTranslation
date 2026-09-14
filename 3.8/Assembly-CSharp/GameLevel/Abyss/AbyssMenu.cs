using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace GameLevel.Abyss
{
	// Token: 0x02000CF4 RID: 3316
	[Token(Token = "0x2000CF4")]
	public class AbyssMenu : BaseMenu
	{
		// Token: 0x06004572 RID: 17778 RVA: 0x0016042C File Offset: 0x0015E62C
		[Token(Token = "0x6004572")]
		[Address(RVA = "0x846F90", Offset = "0x845590", VA = "0x180846F90", Slot = "6")]
		protected override void Awake()
		{
			base.Awake();
			this.InitEntrance();
			UnityEvent theEvent_up = this.resetAbyss.theEvent_up;
			UnityAction unityAction = delegate
			{
				UIResourcesLoader uimanager = GameAPP.UIManager;
				int num = 0;
				BaseMenu baseMenu = uimanager.Push((UIType)((uint)68), num != 0);
				UnityAction unityAction2 = delegate
				{
					Singleton.Instance.StartNewAdventure();
					throw new NullReferenceException();
				};
			};
			theEvent_up.AddListener(unityAction);
		}

		// Token: 0x06004573 RID: 17779 RVA: 0x0016046C File Offset: 0x0015E66C
		[Token(Token = "0x6004573")]
		[Address(RVA = "0x8475B0", Offset = "0x845BB0", VA = "0x1808475B0")]
		public void LookZombieBuff()
		{
			ulong num;
			do
			{
				List<ZombieBuff> zombieBuffs = AbyssManager.Data.zombieBuffs;
				bool flag;
				if (flag)
				{
					Dictionary<ZombieBuff, ValueTuple<string, int>> zombieBuffDescription = Singleton.Instance.ZombieBuffDescription;
				}
			}
			while (num != (ulong)0L);
			InGameText instance = InGameText.Instance;
			int size = AbyssManager.Data.zombieBuffs._size;
		}

		// Token: 0x06004574 RID: 17780 RVA: 0x001604D4 File Offset: 0x0015E6D4
		[Token(Token = "0x6004574")]
		[Address(RVA = "0x847040", Offset = "0x845640", VA = "0x180847040")]
		private void InitEntrance()
		{
			ulong num3;
			do
			{
				Dictionary<ValueTuple<LevelType, int>, LevelData> <PredefinedLevels>k__BackingField = LevelManager.registry.<PredefinedLevels>k__BackingField;
				bool flag;
				if (flag)
				{
					while (!flag)
					{
					}
					AbyssData data = AbyssManager.Data;
					TheButton theButton = this.firstLevelEntrance;
					Transform parent = theButton.transform.parent;
					TheButton theButton2 = global::UnityEngine.Object.Instantiate<TheButton>(theButton, parent);
					UnityEvent theEvent = theButton2.theEvent;
					AbyssMenu.<>c__DisplayClass5_0 CS$<>8__locals1;
					UnityAction unityAction = delegate
					{
						int number2 = CS$<>8__locals1.number;
						int num4 = 0;
						UIMgr.EnterGame((LevelType)((uint)7), number2, -1, num4);
						CursorChange.SetDefaultCursor();
					};
					theEvent.AddListener(unityAction);
					TextMeshProUGUI componentInChildren = theButton2.GetComponentInChildren<TextMeshProUGUI>();
					int number = CS$<>8__locals1.number;
					string text = string.Format("第{0}关", componentInChildren);
					componentInChildren.text = text;
					GameObject gameObject = theButton2.transform.Find("Win").gameObject;
					int arrivedLevel = AbyssManager.Data.arrivedLevel;
					int num = CS$<>8__locals1.number;
					num++;
					bool flag2 = arrivedLevel >= num;
					gameObject.SetActive(flag2);
					List<TheButton> list = this.rukous;
				}
				ulong num2;
				if (num2 != (ulong)0L)
				{
					goto IL_0156;
				}
				bool flag3;
				if (flag3)
				{
					Transform transform;
					transform.SetAsFirstSibling();
				}
			}
			while (num3 != (ulong)0L);
			GameObject gameObject2;
			global::UnityEngine.Object.Destroy(gameObject2);
			return;
			IL_0156:
			throw new NullReferenceException();
		}

		// Token: 0x06004575 RID: 17781 RVA: 0x00160644 File Offset: 0x0015E844
		[Token(Token = "0x6004575")]
		[Address(RVA = "0x8479B0", Offset = "0x845FB0", VA = "0x1808479B0")]
		public AbyssMenu()
		{
			List<TheButton> list = new List();
			this.rukous = list;
			base..ctor();
		}

		// Token: 0x040031B9 RID: 12729
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x40031B9")]
		public TheButton firstLevelEntrance;

		// Token: 0x040031BA RID: 12730
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x40031BA")]
		public TheButton resetAbyss;

		// Token: 0x040031BB RID: 12731
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x40031BB")]
		private readonly List<TheButton> rukous;
	}
}
