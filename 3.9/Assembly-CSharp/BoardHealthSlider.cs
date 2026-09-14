using System;
using System.Collections.Generic;
using System.Linq;
using com.cyborgAssets.inspectorButtonPro;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000265 RID: 613
[Token(Token = "0x2000265")]
public class BoardHealthSlider : MonoBehaviour
{
	// Token: 0x06000B09 RID: 2825 RVA: 0x0003EF5C File Offset: 0x0003D15C
	[Token(Token = "0x6000B09")]
	[Address(RVA = "0x92E890", Offset = "0x92CE90", VA = "0x18092E890")]
	[ProButton]
	private void Awake()
	{
		if (this.id != -1)
		{
			int num = this.id;
			this.zombieType = (ZombieType)num;
		}
	}

	// Token: 0x06000B0A RID: 2826 RVA: 0x0003EF80 File Offset: 0x0003D180
	[Token(Token = "0x6000B0A")]
	[Address(RVA = "0x92E960", Offset = "0x92CF60", VA = "0x18092E960")]
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

	// Token: 0x06000B0B RID: 2827 RVA: 0x0003EFEC File Offset: 0x0003D1EC
	[Token(Token = "0x6000B0B")]
	[Address(RVA = "0x92E8A0", Offset = "0x92CEA0", VA = "0x18092E8A0")]
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

	// Token: 0x06000B0C RID: 2828 RVA: 0x0003F054 File Offset: 0x0003D254
	[Token(Token = "0x6000B0C")]
	[Address(RVA = "0x92EC60", Offset = "0x92D260", VA = "0x18092EC60")]
	private void UpdateSlider()
	{
		for (;;)
		{
			ZombieType zombieType = this.zombieType;
			List<Zombie> certainZombies = Lawnf.GetCertainZombies(Board.Instance, zombieType);
			Func<Zombie, bool> <>9__8_ = BoardHealthSlider.<>c.<>9__8_0;
			if (<>9__8_ == 0)
			{
				BoardHealthSlider.<>c.<>9__8_0 = (Zombie z) => !z.isMindControlled;
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
			long currentAllHealth = zombie.CurrentAllHealth;
			long totalAllHealth = zombie.TotalAllHealth;
			if (this.zombieType != ZombieType.UltimateLegionZombie)
			{
				goto IL_00C2;
			}
			Board instance = Board.Instance;
			bool flag;
			if (flag)
			{
			}
			ulong num3;
			if (num3 != (ulong)0L)
			{
				goto IL_00CE;
			}
			Board instance2 = Board.Instance;
			bool flag2;
			if (flag2)
			{
			}
			ulong num4;
			if (num4 == (ulong)0L)
			{
				goto IL_00C2;
			}
		}
		GameObject gameObject2 = base.gameObject;
		int num5 = 0;
		gameObject2.SetActive(num5 != 0);
		return;
		IL_00C2:
		throw new NullReferenceException();
		IL_00CE:
		throw new NullReferenceException();
	}

	// Token: 0x06000B0D RID: 2829 RVA: 0x0003F138 File Offset: 0x0003D338
	[Token(Token = "0x6000B0D")]
	[Address(RVA = "0x92EA40", Offset = "0x92D040", VA = "0x18092EA40")]
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

	// Token: 0x06000B0E RID: 2830 RVA: 0x0003F19C File Offset: 0x0003D39C
	[Token(Token = "0x6000B0E")]
	[Address(RVA = "0x92F180", Offset = "0x92D780", VA = "0x18092F180")]
	public BoardHealthSlider()
	{
	}

	// Token: 0x0400070A RID: 1802
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400070A")]
	public int id = (int)((ulong)4294967295L);

	// Token: 0x0400070B RID: 1803
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x400070B")]
	public ZombieType zombieType;

	// Token: 0x0400070C RID: 1804
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400070C")]
	public Slider slider;

	// Token: 0x0400070D RID: 1805
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400070D")]
	public float targetValue;

	// Token: 0x0400070E RID: 1806
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400070E")]
	public Image backImage;
}
