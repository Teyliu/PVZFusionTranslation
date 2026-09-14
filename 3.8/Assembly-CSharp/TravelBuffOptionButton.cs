using System;
using System.Collections.Generic;
using Cpp2IlInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

// Token: 0x020005FB RID: 1531
[Token(Token = "0x20005FB")]
public class TravelBuffOptionButton : UIButton
{
	// Token: 0x06001CE6 RID: 7398 RVA: 0x0009A684 File Offset: 0x00098884
	[Token(Token = "0x6001CE6")]
	[Address(RVA = "0x51F590", Offset = "0x51DB90", VA = "0x18051F590")]
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

	// Token: 0x06001CE7 RID: 7399 RVA: 0x0009A6D4 File Offset: 0x000988D4
	[Token(Token = "0x6001CE7")]
	[Address(RVA = "0x5203B0", Offset = "0x51E9B0", VA = "0x1805203B0", Slot = "4")]
	protected override void Start()
	{
		base.Start();
		bool flag;
		if (!flag && this.set != flag)
		{
			this.SetPlant();
		}
	}

	// Token: 0x06001CE8 RID: 7400 RVA: 0x0009A6FC File Offset: 0x000988FC
	[Token(Token = "0x6001CE8")]
	[Address(RVA = "0x51F660", Offset = "0x51DC60", VA = "0x18051F660", Slot = "10")]
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

	// Token: 0x06001CE9 RID: 7401 RVA: 0x0009A748 File Offset: 0x00098948
	[Token(Token = "0x6001CE9")]
	[Address(RVA = "0x51F970", Offset = "0x51DF70", VA = "0x18051F970", Slot = "11")]
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

	// Token: 0x06001CEA RID: 7402 RVA: 0x0009A78C File Offset: 0x0009898C
	[Token(Token = "0x6001CEA")]
	[Address(RVA = "0x51FA10", Offset = "0x51E010", VA = "0x18051FA10")]
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

	// Token: 0x06001CEB RID: 7403 RVA: 0x0009A8C0 File Offset: 0x00098AC0
	[Token(Token = "0x6001CEB")]
	[Address(RVA = "0x520030", Offset = "0x51E630", VA = "0x180520030")]
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

	// Token: 0x06001CEC RID: 7404 RVA: 0x0009A92C File Offset: 0x00098B2C
	[Token(Token = "0x6001CEC")]
	[Address(RVA = "0x520240", Offset = "0x51E840", VA = "0x180520240")]
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

	// Token: 0x06001CED RID: 7405 RVA: 0x0009A980 File Offset: 0x00098B80
	[Token(Token = "0x6001CED")]
	[Address(RVA = "0x51F730", Offset = "0x51DD30", VA = "0x18051F730")]
	public void OnAnimOver()
	{
		if (this.set)
		{
			this.SetPlant();
			return;
		}
	}

	// Token: 0x06001CEE RID: 7406 RVA: 0x0009A9A0 File Offset: 0x00098BA0
	[Token(Token = "0x6001CEE")]
	[Address(RVA = "0x51F750", Offset = "0x51DD50", VA = "0x18051F750")]
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

	// Token: 0x06001CEF RID: 7407 RVA: 0x0009AAB0 File Offset: 0x00098CB0
	[Token(Token = "0x6001CEF")]
	[Address(RVA = "0x51C260", Offset = "0x51A860", VA = "0x18051C260")]
	public TravelBuffOptionButton()
	{
	}

	// Token: 0x04000F79 RID: 3961
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x4000F79")]
	public Transform axis;

	// Token: 0x04000F7A RID: 3962
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000F7A")]
	public TextMeshProUGUI introduce;

	// Token: 0x04000F7B RID: 3963
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000F7B")]
	public TravelMgr manager;

	// Token: 0x04000F7C RID: 3964
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x4000F7C")]
	private Image background;

	// Token: 0x04000F7D RID: 3965
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x4000F7D")]
	public bool set;

	// Token: 0x04000F7E RID: 3966
	[FieldOffset(Offset = "0xA0")]
	[Token(Token = "0x4000F7E")]
	public object buff;

	// Token: 0x04000F7F RID: 3967
	[FieldOffset(Offset = "0xA8")]
	[Token(Token = "0x4000F7F")]
	public InvestBuff refreshedbuffIndex;

	// Token: 0x04000F80 RID: 3968
	[FieldOffset(Offset = "0xB0")]
	[Token(Token = "0x4000F80")]
	public GameObject show;

	// Token: 0x020005FC RID: 1532
	[Token(Token = "0x20005FC")]
	private enum BgType
	{
		// Token: 0x04000F82 RID: 3970
		[Token(Token = "0x4000F82")]
		Day,
		// Token: 0x04000F83 RID: 3971
		[Token(Token = "0x4000F83")]
		Night,
		// Token: 0x04000F84 RID: 3972
		[Token(Token = "0x4000F84")]
		Pool
	}
}
