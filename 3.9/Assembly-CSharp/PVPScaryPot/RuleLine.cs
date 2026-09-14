using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using Cpp2IlInjected;
using UnityEngine;

namespace PVPScaryPot
{
	// Token: 0x02000AA0 RID: 2720
	[Token(Token = "0x2000AA0")]
	public class RuleLine : MonoBehaviour
	{
		// Token: 0x060037DF RID: 14303 RVA: 0x0012B980 File Offset: 0x00129B80
		[Token(Token = "0x60037DF")]
		[Address(RVA = "0x7DC3D0", Offset = "0x7DA9D0", VA = "0x1807DC3D0")]
		private void Awake()
		{
			List<SpriteRenderer> childs = global::Core.Lawnf.GetChilds<SpriteRenderer>(base.transform);
			int num = 0;
			GameMaterial.SetMaterial(childs, (MaterialType)num);
			FlashEffect flashEffect = new FlashEffect(childs);
			this.effect = flashEffect;
		}

		// Token: 0x060037E0 RID: 14304 RVA: 0x0012B9B0 File Offset: 0x00129BB0
		[Token(Token = "0x60037E0")]
		[Address(RVA = "0x7DC780", Offset = "0x7DAD80", VA = "0x1807DC780")]
		private void OnTriggerEnter2D(Collider2D collision)
		{
			bool flag;
			if (flag)
			{
				HashSet<Zombie> hashSet = this.zombies;
			}
		}

		// Token: 0x060037E1 RID: 14305 RVA: 0x0012B9D0 File Offset: 0x00129BD0
		[Token(Token = "0x60037E1")]
		[Address(RVA = "0x7DC810", Offset = "0x7DAE10", VA = "0x1807DC810")]
		private void OnTriggerExit2D(Collider2D collision)
		{
			bool flag;
			if (flag)
			{
				HashSet<Zombie> hashSet = this.zombies;
			}
		}

		// Token: 0x060037E2 RID: 14306 RVA: 0x0012B9F0 File Offset: 0x00129BF0
		[Token(Token = "0x60037E2")]
		[Address(RVA = "0x7DC4C0", Offset = "0x7DAAC0", VA = "0x1807DC4C0")]
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

		// Token: 0x060037E3 RID: 14307 RVA: 0x0012BA88 File Offset: 0x00129C88
		[Token(Token = "0x60037E3")]
		[Address(RVA = "0x7DC8A0", Offset = "0x7DAEA0", VA = "0x1807DC8A0")]
		public RuleLine()
		{
			HashSet<Zombie> hashSet = new HashSet();
			this.zombies = hashSet;
			base..ctor();
		}

		// Token: 0x04002B66 RID: 11110
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4002B66")]
		private IEffect effect;

		// Token: 0x04002B67 RID: 11111
		[FieldOffset(Offset = "0x28")]
		[Token(Token = "0x4002B67")]
		private readonly HashSet<Zombie> zombies;
	}
}
