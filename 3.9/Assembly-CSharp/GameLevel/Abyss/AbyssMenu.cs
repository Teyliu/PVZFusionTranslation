using System;
using System.Collections.Generic;
using Core;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace GameLevel.Abyss
{
	// Token: 0x02000C59 RID: 3161
	[Token(Token = "0x2000C59")]
	public class AbyssMenu : BaseMenu
	{
		// Token: 0x060041DC RID: 16860 RVA: 0x0015A374 File Offset: 0x00158574
		[Token(Token = "0x60041DC")]
		[Address(RVA = "0x87B3A0", Offset = "0x8799A0", VA = "0x18087B3A0", Slot = "6")]
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
					AbyssManager instance = Singleton.Instance;
					GameConfig config = GameAPP.config;
					AbyssData abyssData = new AbyssData();
					config.abyssData = abyssData;
					instance.UpdateZombieBuff();
					SaveInfo.Instance.SavePlayerData();
					throw new NullReferenceException();
				};
			};
			theEvent_up.AddListener(unityAction);
		}

		// Token: 0x060041DD RID: 16861 RVA: 0x0015A3B4 File Offset: 0x001585B4
		[Token(Token = "0x60041DD")]
		[Address(RVA = "0x87B9C0", Offset = "0x879FC0", VA = "0x18087B9C0")]
		public void LookZombieBuff()
		{
			ulong num;
			do
			{
				List<ZombieBuff> zombieBuffs = GameAPP.config.abyssData.zombieBuffs;
				bool flag;
				if (flag)
				{
					Dictionary<ZombieBuff, ValueTuple<string, int>> zombieBuffDescription = Singleton.Instance.ZombieBuffDescription;
				}
			}
			while (num != (ulong)0L);
			InGameText instance = InGameText.Instance;
			int size = GameAPP.config.abyssData.zombieBuffs._size;
		}

		// Token: 0x060041DE RID: 16862 RVA: 0x0015A420 File Offset: 0x00158620
		[Token(Token = "0x60041DE")]
		[Address(RVA = "0x87B450", Offset = "0x879A50", VA = "0x18087B450")]
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

		// Token: 0x060041DF RID: 16863 RVA: 0x0015A590 File Offset: 0x00158790
		[Token(Token = "0x60041DF")]
		[Address(RVA = "0x87BF30", Offset = "0x87A530", VA = "0x18087BF30")]
		public AbyssMenu()
		{
			List<TheButton> list = new List();
			this.rukous = list;
			base..ctor();
		}

		// Token: 0x0400325E RID: 12894
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x400325E")]
		public TheButton firstLevelEntrance;

		// Token: 0x0400325F RID: 12895
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x400325F")]
		public TheButton resetAbyss;

		// Token: 0x04003260 RID: 12896
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4003260")]
		private readonly List<TheButton> rukous;
	}
}
