using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

// Token: 0x02000630 RID: 1584
[Token(Token = "0x2000630")]
public class TravelBuffOptionButton : UIButton
{
	// Token: 0x06001DE5 RID: 7653 RVA: 0x0009F1A0 File Offset: 0x0009D3A0
	[Token(Token = "0x6001DE5")]
	[Address(RVA = "0x57F610", Offset = "0x57DC10", VA = "0x18057F610")]
	private void Awake()
	{
		TravelMgr instance = TravelMgr.Instance;
		this.manager = instance;
		Transform transform = base.transform;
		int num = 0;
		Transform child = transform.GetChild(num);
		int num2 = 0;
		Image component = child.GetChild(num2).GetComponent<Image>();
		this.background = component;
		throw new NullReferenceException();
	}

	// Token: 0x06001DE6 RID: 7654 RVA: 0x0009F1F0 File Offset: 0x0009D3F0
	[Token(Token = "0x6001DE6")]
	[Address(RVA = "0x580430", Offset = "0x57EA30", VA = "0x180580430", Slot = "4")]
	protected override void Start()
	{
		base.Start();
		bool flag;
		if (!flag && this.set != flag)
		{
			this.SetPlant();
		}
	}

	// Token: 0x06001DE7 RID: 7655 RVA: 0x0009F218 File Offset: 0x0009D418
	[Token(Token = "0x6001DE7")]
	[Address(RVA = "0x57F6E0", Offset = "0x57DCE0", VA = "0x18057F6E0", Slot = "10")]
	public virtual void Clear()
	{
		GameObject gameObject = this.show;
		int num = 0;
		if (gameObject != num)
		{
			global::UnityEngine.Object.Destroy(this.show);
		}
		this.introduce.text = "无";
		int num2 = 0;
		this.SetBackground((TravelBuffOptionButton.BgType)num2);
	}

	// Token: 0x06001DE8 RID: 7656 RVA: 0x0009F264 File Offset: 0x0009D464
	[Token(Token = "0x6001DE8")]
	[Address(RVA = "0x57F9F0", Offset = "0x57DFF0", VA = "0x18057F9F0", Slot = "11")]
	public virtual void SetBuff(object buff, bool refresh = false)
	{
		this.set = true;
		this.buff = buff;
		string text = this.manager.GetText(buff);
		this.introduce.text = text;
		if (refresh)
		{
			this.SetPlant();
		}
	}

	// Token: 0x06001DE9 RID: 7657 RVA: 0x0009F2A8 File Offset: 0x0009D4A8
	[Token(Token = "0x6001DE9")]
	[Address(RVA = "0x57FA90", Offset = "0x57E090", VA = "0x18057FA90")]
	private void SetPlant()
	{
		GameObject gameObject = this.show;
		int num = 0;
		if (gameObject != num)
		{
			global::UnityEngine.Object.Destroy(this.show);
		}
		object obj = this.buff;
		if (obj != 0)
		{
			if (obj == 0)
			{
				int num7;
				if (obj == 0)
				{
					if (obj == 0)
					{
						if (obj == 0)
						{
							if (obj != 0)
							{
								Dictionary<TravelDebuff, ValueTuple<string, ZombieType>> debuffData = TravelDictionary.debuffData;
								bool flag;
								if (!flag)
								{
								}
								int num2 = 0;
								return;
							}
							return;
						}
						else
						{
							int num2;
							int num3 = num2;
							List<PlantType> allStrongUltimtePlant = TravelDictionary.allStrongUltimtePlant;
							uint num4;
							num3 -= (int)num4;
							int num5 = allStrongUltimtePlant[num3];
							PlantType plantType = TravelDictionary.allStrongUltimtePlant[num3];
							bool flag2;
							if (!flag2)
							{
								int num6 = 0;
								return;
							}
						}
					}
					else
					{
						int num6;
						int num3 = num6;
						PlantType plantTypeByAdvBuff = TravelMgr.GetPlantTypeByAdvBuff(num3);
						bool flag3;
						while (!flag3)
						{
						}
					}
					num7 = 0;
					return;
				}
				int num8 = num7;
				int num9 = TravelDictionary.allStrongUltimtePlant[num8];
				bool flag4;
				while (!flag4)
				{
				}
				int num10 = 0;
				Transform transform;
				GameObject gameObject2 = transform.GetChild(num10).gameObject;
				int num11 = 0;
				gameObject2.SetActive(num11 != 0);
				Transform transform2;
				uint num12;
				GameObject gameObject3 = transform2.GetChild((int)num12).gameObject;
				ulong num13;
				gameObject3.SetActive(num13 != 0UL);
				return;
			}
			else
			{
				TravelMgr instance = TravelMgr.Instance;
				if (instance == 0 || instance == 0)
				{
					throw new InvalidCastException();
				}
				int num14;
				if (num14 == 1)
				{
				}
			}
		}
	}

	// Token: 0x06001DEA RID: 7658 RVA: 0x0009F3DC File Offset: 0x0009D5DC
	[Token(Token = "0x6001DEA")]
	[Address(RVA = "0x5800B0", Offset = "0x57E6B0", VA = "0x1805800B0")]
	private void SetPlant(PlantType thePlantType)
	{
		Transform transform = this.axis;
		Vector3 vector;
		float z = vector.z;
		GameObject gameObject;
		Transform transform2 = gameObject.transform;
		Transform transform3 = base.transform;
		transform2.parentInternal = transform3;
		bool flag;
		if (!flag)
		{
			SortingGroup sortingGroup = gameObject.AddComponent<SortingGroup>();
		}
		this.show = gameObject;
		bool flag2;
		if (flag2)
		{
			Transform transform4 = gameObject.transform;
			Vector3 vector2;
			float z2 = vector2.z;
		}
	}

	// Token: 0x06001DEB RID: 7659 RVA: 0x0009F448 File Offset: 0x0009D648
	[Token(Token = "0x6001DEB")]
	[Address(RVA = "0x5802C0", Offset = "0x57E8C0", VA = "0x1805802C0")]
	private void SetZombie(ZombieType theZombieType)
	{
		Transform transform = this.axis;
		Vector3 vector;
		float z = vector.z;
		GameObject gameObject;
		Transform transform2 = gameObject.transform;
		Transform transform3 = base.transform;
		transform2.parentInternal = transform3;
		bool flag;
		if (!flag)
		{
			SortingGroup sortingGroup = gameObject.AddComponent<SortingGroup>();
		}
		this.show = gameObject;
	}

	// Token: 0x06001DEC RID: 7660 RVA: 0x0009F49C File Offset: 0x0009D69C
	[Token(Token = "0x6001DEC")]
	[Address(RVA = "0x57F7B0", Offset = "0x57DDB0", VA = "0x18057F7B0")]
	public void OnAnimOver()
	{
		if (this.set)
		{
			this.SetPlant();
			return;
		}
	}

	// Token: 0x06001DED RID: 7661 RVA: 0x0009F4BC File Offset: 0x0009D6BC
	[Token(Token = "0x6001DED")]
	[Address(RVA = "0x57F7D0", Offset = "0x57DDD0", VA = "0x18057F7D0")]
	private void SetBackground(TravelBuffOptionButton.BgType bgType)
	{
		if (bgType != TravelBuffOptionButton.BgType.Day)
		{
			if (bgType != TravelBuffOptionButton.BgType.Day)
			{
				if (bgType == TravelBuffOptionButton.BgType.Night)
				{
					Image image = this.background;
					int num = 0;
					image.enabled = num != 0;
					Transform transform = this.background.transform;
					int num2 = 0;
					GameObject gameObject = transform.GetChild(num2).gameObject;
					int num3 = 0;
					gameObject.SetActive(num3 != 0);
					uint num4;
					ulong num5;
					this.background.transform.GetChild((int)num4).gameObject.SetActive(num5 != 0UL);
					return;
				}
				return;
			}
			else
			{
				Image image2 = this.background;
				int num6 = 0;
				image2.enabled = num6 != 0;
				Transform transform2 = this.background.transform;
				int num7 = 0;
				GameObject gameObject2 = transform2.GetChild(num7).gameObject;
			}
		}
		ulong num8;
		this.background.enabled = num8 != 0UL;
		Transform transform3 = this.background.transform;
		int num9 = 0;
		GameObject gameObject3 = transform3.GetChild(num9).gameObject;
		int num10 = 0;
		gameObject3.SetActive(num10 != 0);
		uint num11;
		GameObject gameObject4 = this.background.transform.GetChild((int)num11).gameObject;
		int num12 = 0;
		gameObject4.SetActive(num12 != 0);
	}

	// Token: 0x06001DEE RID: 7662 RVA: 0x0009F5CC File Offset: 0x0009D7CC
	[Token(Token = "0x6001DEE")]
	[Address(RVA = "0x5763F0", Offset = "0x5749F0", VA = "0x1805763F0")]
	public TravelBuffOptionButton()
	{
	}

	// Token: 0x04001041 RID: 4161
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4001041")]
	public Transform axis;

	// Token: 0x04001042 RID: 4162
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4001042")]
	public TextMeshProUGUI introduce;

	// Token: 0x04001043 RID: 4163
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4001043")]
	public TravelMgr manager;

	// Token: 0x04001044 RID: 4164
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4001044")]
	private Image background;

	// Token: 0x04001045 RID: 4165
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4001045")]
	public bool set;

	// Token: 0x04001046 RID: 4166
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4001046")]
	public object buff;

	// Token: 0x04001047 RID: 4167
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4001047")]
	public InvestBuff refreshedbuffIndex;

	// Token: 0x04001048 RID: 4168
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4001048")]
	public GameObject show;

	// Token: 0x02000631 RID: 1585
	[Token(Token = "0x2000631")]
	private enum BgType
	{
		// Token: 0x0400104A RID: 4170
		[Token(Token = "0x400104A")]
		Day,
		// Token: 0x0400104B RID: 4171
		[Token(Token = "0x400104B")]
		Night,
		// Token: 0x0400104C RID: 4172
		[Token(Token = "0x400104C")]
		Pool
	}
}
