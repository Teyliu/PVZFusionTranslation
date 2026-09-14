using System;
using System.Collections.Generic;
using System.Linq;
using com.cyborgAssets.inspectorButtonPro;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200025F RID: 607
[Token(Token = "0x200025F")]
public class BoardHealthSlider : MonoBehaviour
{
	// Token: 0x06000AED RID: 2797 RVA: 0x0003F0B0 File Offset: 0x0003D2B0
	[Token(Token = "0x6000AED")]
	[Address(RVA = "0x89E910", Offset = "0x89CF10", VA = "0x18089E910")]
	[ProButton]
	private void Awake()
	{
		if (this.id != -1)
		{
			int num = this.id;
			this.zombieType = (ZombieType)num;
		}
	}

	// Token: 0x06000AEE RID: 2798 RVA: 0x0003F0D4 File Offset: 0x0003D2D4
	[Token(Token = "0x6000AEE")]
	[Address(RVA = "0x89E9E0", Offset = "0x89CFE0", VA = "0x18089E9E0")]
	public void OnUpdate()
	{
		this.UpdateSlider();
		Image image = this.backImage;
		float num = this.targetValue;
		if (image.m_FillAmount < num)
		{
			float num2 = this.targetValue;
			image.fillAmount = num2;
			return;
		}
		float num3 = this.targetValue;
		float num4 = Time.deltaTime * 5f;
		if (0 > (int)num4 || num4 > 1f)
		{
		}
		image.fillAmount = num3;
	}

	// Token: 0x06000AEF RID: 2799 RVA: 0x0003F140 File Offset: 0x0003D340
	[Token(Token = "0x6000AEF")]
	[Address(RVA = "0x89E920", Offset = "0x89CF20", VA = "0x18089E920")]
	private void BackUpdate()
	{
		Image image = this.backImage;
		float num = this.targetValue;
		if (image.m_FillAmount < num)
		{
			float num2 = this.targetValue;
			image.fillAmount = num2;
			return;
		}
		float num3 = this.targetValue;
		float num4 = Time.deltaTime * 5f;
		if (0 > (int)num4 || num4 > 1f)
		{
		}
		image.fillAmount = num3;
	}

	// Token: 0x06000AF0 RID: 2800 RVA: 0x0003F1A8 File Offset: 0x0003D3A8
	[Token(Token = "0x6000AF0")]
	[Address(RVA = "0x89ECE0", Offset = "0x89D2E0", VA = "0x18089ECE0")]
	private void UpdateSlider()
	{
		for (;;)
		{
			ZombieType zombieType = this.zombieType;
			List<Zombie> certainZombies = Lawnf.GetCertainZombies(Board.Instance, zombieType);
			Func<Zombie, bool> <>9__8_ = BoardHealthSlider.<>c.<>9__8_0;
			if (<>9__8_ == 0)
			{
				Func<Zombie, bool> func;
				BoardHealthSlider.<>c.<>9__8_0 = func;
			}
			Zombie zombie = Enumerable.FirstOrDefault<Zombie>(Enumerable.Where<Zombie>(certainZombies, <>9__8_));
			int num = 0;
			if (!(zombie != num))
			{
				break;
			}
			GameObject gameObject;
			ulong num2;
			gameObject.SetActive(num2 != 0UL);
			int currentAllHealth = zombie.CurrentAllHealth;
			int totalAllHealth = zombie.TotalAllHealth;
			if (this.zombieType != ZombieType.UltimateLegionZombie)
			{
				goto IL_00B4;
			}
			Board instance = Board.Instance;
			bool flag;
			if (flag)
			{
			}
			ulong num3;
			if (num3 != (ulong)0L)
			{
				goto IL_00C0;
			}
			Board instance2 = Board.Instance;
			bool flag2;
			if (flag2)
			{
			}
			ulong num4;
			if (num4 == (ulong)0L)
			{
				goto IL_00B4;
			}
		}
		GameObject gameObject2 = base.gameObject;
		int num5 = 0;
		gameObject2.SetActive(num5 != 0);
		return;
		IL_00B4:
		throw new NullReferenceException();
		IL_00C0:
		throw new NullReferenceException();
	}

	// Token: 0x06000AF1 RID: 2801 RVA: 0x0003F27C File Offset: 0x0003D47C
	[Token(Token = "0x6000AF1")]
	[Address(RVA = "0x89EAC0", Offset = "0x89D0C0", VA = "0x18089EAC0")]
	[ProButton]
	public void SetZombieType()
	{
		ulong num2;
		do
		{
			int num = 0;
			HashSet<ZombieType> leaderZombies = TypeMgr.LeaderZombies;
			bool flag;
			if (flag)
			{
				Transform parent = base.transform.parent;
				BoardHealthSlider boardHealthSlider = global::UnityEngine.Object.Instantiate<BoardHealthSlider>(this, parent);
				boardHealthSlider.zombieType = (ZombieType)num;
				string text;
				boardHealthSlider.gameObject.name = text;
			}
		}
		while (num2 != (ulong)0L);
	}

	// Token: 0x06000AF2 RID: 2802 RVA: 0x0003F2E0 File Offset: 0x0003D4E0
	[Token(Token = "0x6000AF2")]
	[Address(RVA = "0x89F1E0", Offset = "0x89D7E0", VA = "0x18089F1E0")]
	public BoardHealthSlider()
	{
	}

	// Token: 0x040006FE RID: 1790
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40006FE")]
	public int id = (int)((ulong)4294967295L);

	// Token: 0x040006FF RID: 1791
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x40006FF")]
	public ZombieType zombieType;

	// Token: 0x04000700 RID: 1792
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000700")]
	public Slider slider;

	// Token: 0x04000701 RID: 1793
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000701")]
	public float targetValue;

	// Token: 0x04000702 RID: 1794
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000702")]
	public Image backImage;
}
