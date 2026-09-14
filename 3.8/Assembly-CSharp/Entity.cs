using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Core;
using Cpp2IlInjected;
using UnityEngine;

// Token: 0x02000217 RID: 535
[Token(Token = "0x2000217")]
public class Entity : MonoBehaviour, IDamageable, IDamageMaker
{
	// Token: 0x17000070 RID: 112
	// (get) Token: 0x0600092E RID: 2350 RVA: 0x00031F70 File Offset: 0x00030170
	// (set) Token: 0x0600092F RID: 2351 RVA: 0x00031F84 File Offset: 0x00030184
	[Token(Token = "0x17000070")]
	public Team Team
	{
		[Token(Token = "0x600092E")]
		[Address(RVA = "0x3D1110", Offset = "0x3CF710", VA = "0x1803D1110", Slot = "7")]
		get;
		[Token(Token = "0x600092F")]
		[Address(RVA = "0x783390", Offset = "0x781990", VA = "0x180783390", Slot = "8")]
		set;
	}

	// Token: 0x06000930 RID: 2352 RVA: 0x00031F98 File Offset: 0x00030198
	[Token(Token = "0x6000930")]
	[Address(RVA = "0x878AF0", Offset = "0x8770F0", VA = "0x180878AF0", Slot = "10")]
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

	// Token: 0x06000931 RID: 2353 RVA: 0x00032060 File Offset: 0x00030260
	[Token(Token = "0x6000931")]
	[Address(RVA = "0x3ED7C0", Offset = "0x3EBDC0", VA = "0x1803ED7C0")]
	public void SetPosition(Vector3 targetPosition)
	{
		Transform transform = this.axis;
		Transform transform2 = base.transform;
		Vector3 vector;
		float z = vector.z;
	}

	// Token: 0x06000932 RID: 2354 RVA: 0x0003208C File Offset: 0x0003028C
	[Token(Token = "0x6000932")]
	[Address(RVA = "0x878D40", Offset = "0x877340", VA = "0x180878D40", Slot = "11")]
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

	// Token: 0x06000933 RID: 2355 RVA: 0x000320F8 File Offset: 0x000302F8
	[Token(Token = "0x6000933")]
	[Address(RVA = "0x94EE70", Offset = "0x94D470", VA = "0x18094EE70")]
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

	// Token: 0x06000934 RID: 2356 RVA: 0x00032148 File Offset: 0x00030348
	[Token(Token = "0x6000934")]
	[Address(RVA = "0x878FD0", Offset = "0x8775D0", VA = "0x180878FD0")]
	public bool HasBuff(EffectType effectType)
	{
		Dictionary<EffectType, BaseEffect> dictionary = this.effects;
		bool flag;
		return flag;
	}

	// Token: 0x06000935 RID: 2357 RVA: 0x00032168 File Offset: 0x00030368
	[Token(Token = "0x6000935")]
	[Address(RVA = "0x879030", Offset = "0x877630", VA = "0x180879030")]
	public bool RemoveBuff(EffectType effectType)
	{
		Dictionary<EffectType, BaseEffect> dictionary = this.effects;
		bool flag;
		return flag || flag;
	}

	// Token: 0x06000936 RID: 2358 RVA: 0x0003218C File Offset: 0x0003038C
	[Token(Token = "0x6000936")]
	[Address(RVA = "0x39CB10", Offset = "0x39B110", VA = "0x18039CB10", Slot = "12")]
	public virtual void TakeDamage(int value, IDamageMaker damageFrom, DamageType DamageType = DamageType.Normal, PlantType reportType = PlantType.Nothing, bool fix = false)
	{
	}

	// Token: 0x06000937 RID: 2359 RVA: 0x0003219C File Offset: 0x0003039C
	[Token(Token = "0x6000937")]
	[Address(RVA = "0x3A5ED0", Offset = "0x3A44D0", VA = "0x1803A5ED0", Slot = "13")]
	public virtual bool CanAttack(IDamageable target)
	{
		return true;
	}

	// Token: 0x06000938 RID: 2360 RVA: 0x000321AC File Offset: 0x000303AC
	[Token(Token = "0x6000938")]
	[Address(RVA = "0x3F2500", Offset = "0x3F0B00", VA = "0x1803F2500", Slot = "14")]
	protected virtual bool DetactiveEnermy()
	{
		return false;
	}

	// Token: 0x06000939 RID: 2361 RVA: 0x000321BC File Offset: 0x000303BC
	[Token(Token = "0x6000939")]
	[Address(RVA = "0x8790C0", Offset = "0x8776C0", VA = "0x1808790C0")]
	public Entity()
	{
		Dictionary<EffectType, BaseEffect> dictionary = new Dictionary();
		this.effects = dictionary;
		List<SpriteRenderer> list = new List();
		this.spriteRenderers = list;
		base..ctor();
	}

	// Token: 0x04000491 RID: 1169
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000491")]
	public Animator anim;

	// Token: 0x04000492 RID: 1170
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000492")]
	public Board board;

	// Token: 0x04000493 RID: 1171
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000493")]
	public Transform axis;

	// Token: 0x04000494 RID: 1172
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000494")]
	public Dictionary<EffectType, BaseEffect> effects;

	// Token: 0x04000495 RID: 1173
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000495")]
	public LayerMask plantLayer;

	// Token: 0x04000496 RID: 1174
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x4000496")]
	public LayerMask zombieLayer;

	// Token: 0x04000497 RID: 1175
	[global::Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000497")]
	[NonSerialized]
	public List<SpriteRenderer> spriteRenderers;
}
