using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;
using UnityEngine;

namespace PVPScaryPot
{
	// Token: 0x02000A60 RID: 2656
	[Token(Token = "0x2000A60")]
	public class RuleLine : MonoBehaviour
	{
		// Token: 0x0600369B RID: 13979 RVA: 0x00126750 File Offset: 0x00124950
		[Token(Token = "0x600369B")]
		[Address(RVA = "0x775540", Offset = "0x773B40", VA = "0x180775540")]
		private void Awake()
		{
			List<SpriteRenderer> childs = global::Core.Lawnf.GetChilds<SpriteRenderer>(base.transform);
			int num = 0;
			GameMaterial.SetMaterial(childs, (MaterialType)num);
			FlashEffect flashEffect = new FlashEffect(childs);
			this.effect = flashEffect;
		}

		// Token: 0x0600369C RID: 13980 RVA: 0x00126780 File Offset: 0x00124980
		[Token(Token = "0x600369C")]
		[Address(RVA = "0x7758F0", Offset = "0x773EF0", VA = "0x1807758F0")]
		private void OnTriggerEnter2D(Collider2D collision)
		{
			bool flag;
			if (flag)
			{
				HashSet<Zombie> hashSet = this.zombies;
			}
		}

		// Token: 0x0600369D RID: 13981 RVA: 0x001267A0 File Offset: 0x001249A0
		[Token(Token = "0x600369D")]
		[Address(RVA = "0x775980", Offset = "0x773F80", VA = "0x180775980")]
		private void OnTriggerExit2D(Collider2D collision)
		{
			bool flag;
			if (flag)
			{
				HashSet<Zombie> hashSet = this.zombies;
			}
		}

		// Token: 0x0600369E RID: 13982 RVA: 0x001267C0 File Offset: 0x001249C0
		[Token(Token = "0x600369E")]
		[Address(RVA = "0x775630", Offset = "0x773C30", VA = "0x180775630")]
		private void FixedUpdate()
		{
			ulong num3;
			do
			{
				int num = 0;
				IEffect effect = this.effect;
				List<Zombie> list = Enumerable.ToList<Zombie>(this.zombies);
				bool flag;
				if (flag)
				{
					int num2 = 0;
					if (num == num2)
					{
						continue;
					}
					Transform transform = base.transform;
					if (!PVPScareyPot.Instance.OnZombieNearLine(num))
					{
						continue;
					}
					IEffect effect2 = this.effect;
					bool flag2 = this.zombies.Remove(num);
				}
			}
			while (num3 != (ulong)0L);
		}

		// Token: 0x0600369F RID: 13983 RVA: 0x00126858 File Offset: 0x00124A58
		[Token(Token = "0x600369F")]
		[Address(RVA = "0x775A10", Offset = "0x774010", VA = "0x180775A10")]
		public RuleLine()
		{
			HashSet<Zombie> hashSet = new HashSet();
			this.zombies = hashSet;
			base..ctor();
		}

		// Token: 0x040029F3 RID: 10739
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40029F3")]
		private IEffect effect;

		// Token: 0x040029F4 RID: 10740
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x40029F4")]
		private readonly HashSet<Zombie> zombies;
	}
}
