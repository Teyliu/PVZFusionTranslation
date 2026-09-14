using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x0200021C RID: 540
[Token(Token = "0x200021C")]
public class Entity : MonoBehaviour, IDamageable, IDamageMaker
{
	// Token: 0x170000AD RID: 173
	// (get) Token: 0x06000944 RID: 2372 RVA: 0x00031D8C File Offset: 0x0002FF8C
	// (set) Token: 0x06000945 RID: 2373 RVA: 0x00031DA0 File Offset: 0x0002FFA0
	[Token(Token = "0x170000AD")]
	public Team Team
	{
		[Token(Token = "0x6000944")]
		[Address(RVA = "0x41DF70", Offset = "0x41C570", VA = "0x18041DF70", Slot = "7")]
		get;
		[Token(Token = "0x6000945")]
		[Address(RVA = "0x7EA240", Offset = "0x7E8840", VA = "0x1807EA240", Slot = "8")]
		set;
	}

	// Token: 0x06000946 RID: 2374 RVA: 0x00031DB4 File Offset: 0x0002FFB4
	[Token(Token = "0x6000946")]
	[Address(RVA = "0x908580", Offset = "0x906B80", VA = "0x180908580", Slot = "10")]
	protected virtual void Awake()
	{
		Transform transform = base.transform.Find("Shadow");
		this.axis = transform;
		Transform transform2 = this.axis;
		int num = 0;
		if (!(transform2 == num))
		{
			Animator component = base.GetComponent<Animator>();
			this.anim = component;
			this.anim.keepAnimatorStateOnDisable = true;
			this.GetSpriteRenderers();
			LayerMask layerMask = LayerMask.GetMask(new string[] { "Plant", "TorchWood" });
			this.plantLayer = layerMask;
			LayerMask layerMask2 = LayerMask.GetMask(new string[] { "Zombie" });
			this.zombieLayer = layerMask2;
			return;
		}
	}

	// Token: 0x06000947 RID: 2375 RVA: 0x00031E7C File Offset: 0x0003007C
	[Token(Token = "0x6000947")]
	[Address(RVA = "0x44A1E0", Offset = "0x4487E0", VA = "0x18044A1E0")]
	public void SetPosition(Vector3 targetPosition)
	{
		Transform transform = this.axis;
		Transform transform2 = base.transform;
		Vector3 vector;
		float z = vector.z;
	}

	// Token: 0x06000948 RID: 2376 RVA: 0x00031EA8 File Offset: 0x000300A8
	[Token(Token = "0x6000948")]
	[Address(RVA = "0x9087D0", Offset = "0x906DD0", VA = "0x1809087D0", Slot = "11")]
	protected virtual void GetSpriteRenderers()
	{
		int num;
		do
		{
			num = 0;
			List<GameObject> childs = global::Core.Lawnf.GetChilds(base.transform);
			Material material = GameMaterial.GetMaterial(MaterialType.Default);
			bool flag;
			if (flag)
			{
				bool flag2;
				while (!flag2)
				{
				}
				string text;
				if (!(text != "Shadow"))
				{
					continue;
				}
				List<SpriteRenderer> list = this.spriteRenderers;
				num.SetBrightness(1f);
			}
		}
		while (num != 0);
	}

	// Token: 0x06000949 RID: 2377 RVA: 0x00031F14 File Offset: 0x00030114
	[Token(Token = "0x6000949")]
	[Address(RVA = "0xA113A0", Offset = "0xA0F9A0", VA = "0x180A113A0")]
	public bool TryGetEffect<T>(EffectType effectType, [Out] T targetEffect) where T : BaseEffect
	{
		int num;
		bool flag;
		do
		{
			if ("{il2cpp array field il2cppMethodInfo->}" != (ulong)0L || "{il2cpp array field il2cppMethodInfo->}" == (ulong)0L)
			{
			}
			Dictionary<EffectType, BaseEffect> dictionary = this.effects;
			num = 0;
		}
		while (flag);
		if (0 == 0)
		{
		}
		if (num != 0 && (num == 0 || num != 0))
		{
			return true;
		}
		throw new InvalidCastException();
	}

	// Token: 0x0600094A RID: 2378 RVA: 0x00031F64 File Offset: 0x00030164
	[Token(Token = "0x600094A")]
	[Address(RVA = "0x908A60", Offset = "0x907060", VA = "0x180908A60")]
	public bool HasBuff(EffectType effectType)
	{
		Dictionary<EffectType, BaseEffect> dictionary = this.effects;
		bool flag;
		return flag;
	}

	// Token: 0x0600094B RID: 2379 RVA: 0x00031F84 File Offset: 0x00030184
	[Token(Token = "0x600094B")]
	[Address(RVA = "0x908AC0", Offset = "0x9070C0", VA = "0x180908AC0")]
	public bool RemoveBuff(EffectType effectType)
	{
		Dictionary<EffectType, BaseEffect> dictionary = this.effects;
		bool flag;
		return flag || flag;
	}

	// Token: 0x0600094C RID: 2380 RVA: 0x00031FA8 File Offset: 0x000301A8
	[Token(Token = "0x600094C")]
	[Address(RVA = "0x3E8B20", Offset = "0x3E7120", VA = "0x1803E8B20", Slot = "12")]
	public virtual void TakeDamage(int value, IDamageMaker damageFrom, DamageType DamageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x0600094D RID: 2381 RVA: 0x00031FB8 File Offset: 0x000301B8
	[Token(Token = "0x600094D")]
	[Address(RVA = "0x3F1E60", Offset = "0x3F0460", VA = "0x1803F1E60", Slot = "13")]
	public virtual bool CanAttack(IDamageable target)
	{
		return true;
	}

	// Token: 0x0600094E RID: 2382 RVA: 0x00031FC8 File Offset: 0x000301C8
	[Token(Token = "0x600094E")]
	[Address(RVA = "0x400970", Offset = "0x3FEF70", VA = "0x180400970", Slot = "14")]
	protected virtual bool DetactiveEnermy()
	{
		return false;
	}

	// Token: 0x0600094F RID: 2383 RVA: 0x00031FD8 File Offset: 0x000301D8
	[Token(Token = "0x600094F")]
	[Address(RVA = "0x908B50", Offset = "0x907150", VA = "0x180908B50")]
	public Entity()
	{
		Dictionary<EffectType, BaseEffect> dictionary = new Dictionary();
		this.effects = dictionary;
		List<SpriteRenderer> list = new List();
		this.spriteRenderers = list;
		base..ctor();
	}

	// Token: 0x04000496 RID: 1174
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000496")]
	public Animator anim;

	// Token: 0x04000497 RID: 1175
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000497")]
	public Board board;

	// Token: 0x04000498 RID: 1176
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000498")]
	public Transform axis;

	// Token: 0x04000499 RID: 1177
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000499")]
	public Dictionary<EffectType, BaseEffect> effects;

	// Token: 0x0400049A RID: 1178
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400049A")]
	public LayerMask plantLayer;

	// Token: 0x0400049B RID: 1179
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x400049B")]
	public LayerMask zombieLayer;

	// Token: 0x0400049C RID: 1180
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400049C")]
	[NonSerialized]
	public List<SpriteRenderer> spriteRenderers;
}
