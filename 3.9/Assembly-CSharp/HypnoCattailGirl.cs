using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Spine;
using Spine.Unity;
using UnityEngine;

// Token: 0x0200052F RID: 1327
[Token(Token = "0x200052F")]
public class HypnoCattailGirl : CattailGirl
{
	// Token: 0x060018C3 RID: 6339 RVA: 0x0008606C File Offset: 0x0008426C
	[Token(Token = "0x60018C3")]
	[Address(RVA = "0x5270F0", Offset = "0x5256F0", VA = "0x1805270F0", Slot = "10")]
	protected override void Awake()
	{
		base.Awake();
		SkeletonAnimation component = base.GetComponent<SkeletonAnimation>();
		this.spineAnim = component;
		MeshRenderer component2 = base.GetComponent<MeshRenderer>();
		this.meshRenderer = component2;
		SkeletonAnimation skeletonAnimation = this.spineAnim;
		this.theStatus = (PlantStatus)((ulong)43L);
		skeletonAnimation.skeletonDataAsset.GetAnimationStateData().defaultMix = 0.05f;
		global::Spine.AnimationState animationState = this.spineAnim.AnimationState;
		int num = 0;
		int num2 = 0;
		TrackEntry trackEntry = animationState.SetAnimation(num2, "henshin", num != 0);
		global::Spine.AnimationState.TrackEntryDelegate trackEntryDelegate = delegate(TrackEntry entry)
		{
			this.theStatus = (PlantStatus)((ulong)0L);
		};
		trackEntry.Complete += trackEntryDelegate;
		global::Spine.AnimationState.TrackEntryDelegate trackEntryDelegate2 = delegate(TrackEntry entry)
		{
			this.canExplde = true;
		};
		trackEntry.Complete += trackEntryDelegate2;
		global::Spine.AnimationState animationState2 = this.spineAnim.AnimationState;
		int num3 = 0;
		int num4 = 0;
		TrackEntry trackEntry2 = animationState2.AddAnimation(num4, "idle", true, (float)num3);
		MaterialPropertyBlock materialPropertyBlock = new MaterialPropertyBlock();
		this.mpb = materialPropertyBlock;
		this.attributeCountdown = 3f;
	}

	// Token: 0x060018C4 RID: 6340 RVA: 0x00086158 File Offset: 0x00084358
	[Token(Token = "0x60018C4")]
	[Address(RVA = "0x527780", Offset = "0x525D80", VA = "0x180527780", Slot = "37")]
	public override void SetBrightness(float b)
	{
		MeshRenderer meshRenderer = this.meshRenderer;
		this.brightness = b;
		MaterialPropertyBlock materialPropertyBlock = this.mpb;
		meshRenderer.Internal_GetPropertyBlock(materialPropertyBlock);
		this.mpb.SetFloat("_Brightness", b);
		MeshRenderer meshRenderer2 = this.meshRenderer;
		MaterialPropertyBlock materialPropertyBlock2 = this.mpb;
		meshRenderer2.Internal_SetPropertyBlock(materialPropertyBlock2);
	}

	// Token: 0x060018C5 RID: 6341 RVA: 0x000861B0 File Offset: 0x000843B0
	[Token(Token = "0x60018C5")]
	[Address(RVA = "0x5274B0", Offset = "0x525AB0", VA = "0x1805274B0", Slot = "38")]
	protected override void OnUpdate()
	{
		float deltaTime = Time.deltaTime;
		this.idleTimer = deltaTime;
		global::Spine.AnimationState animationState = this.spineAnim.AnimationState;
		int num = global::UnityEngine.Random.Range(0, 2);
		string text = "garden2";
		if (num == 0)
		{
			text = "garden1";
		}
		int num2 = 0;
		int num3 = 0;
		TrackEntry trackEntry = animationState.SetAnimation(num3, text, num2 != 0);
		global::Spine.AnimationState animationState2 = this.spineAnim.AnimationState;
		int num4 = 0;
		int num5 = 0;
		TrackEntry trackEntry2 = animationState2.AddAnimation(num5, "idle", true, (float)num4);
		this.idleTimer = -7f;
	}

	// Token: 0x060018C6 RID: 6342 RVA: 0x00086240 File Offset: 0x00084440
	[Token(Token = "0x60018C6")]
	[Address(RVA = "0x5275E0", Offset = "0x525BE0", VA = "0x1805275E0", Slot = "44")]
	protected override void PlantShootUpdate()
	{
		base.UpdateAttackCountDown();
		float num = global::UnityEngine.Random.Range(0.95f, 1.05f);
		this.thePlantAttackCountDown = num;
		if (this.Shootable())
		{
			Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
			this.idleTimer = 0f;
		}
		if (global::UnityEngine.Random.Range(0, 2) == 0)
		{
			global::Spine.AnimationState animationState = this.spineAnim.AnimationState;
			int num2 = 0;
			TrackEntry trackEntry = animationState.SetAnimation(2, "1", num2 != 0);
		}
	}

	// Token: 0x060018C7 RID: 6343 RVA: 0x000862C4 File Offset: 0x000844C4
	[Token(Token = "0x60018C7")]
	[Address(RVA = "0x527BC0", Offset = "0x5261C0", VA = "0x180527BC0", Slot = "46")]
	protected override bool Shootable()
	{
		bool flag = base.Shootable();
		if (!flag)
		{
			return flag;
		}
		bool flag2;
		return flag2;
	}

	// Token: 0x060018C8 RID: 6344 RVA: 0x000862E4 File Offset: 0x000844E4
	[Token(Token = "0x60018C8")]
	[Address(RVA = "0x527470", Offset = "0x525A70", VA = "0x180527470", Slot = "18")]
	protected override void OnFixedUpdate()
	{
		base.OnFixedUpdate();
		global::Spine.AnimationState animationState = this.spineAnim.AnimationState;
		float thePlantSpeed = this.thePlantSpeed;
		animationState.timeScale = thePlantSpeed;
	}

	// Token: 0x060018C9 RID: 6345 RVA: 0x00086318 File Offset: 0x00084518
	[Token(Token = "0x60018C9")]
	[Address(RVA = "0x527BF0", Offset = "0x5261F0", VA = "0x180527BF0")]
	private void SpineShoot()
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x060018CA RID: 6346 RVA: 0x00086338 File Offset: 0x00084538
	[Token(Token = "0x60018CA")]
	[Address(RVA = "0x527900", Offset = "0x525F00", VA = "0x180527900", Slot = "68")]
	protected override Bullet Shoot1()
	{
		Transform shoot = this.shoot;
		CreateBullet instance = CreateBullet.Instance;
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		float attributeCountdown = this.attributeCountdown;
		if (attributeCountdown > 1f)
		{
			this.attributeCountdown = attributeCountdown;
		}
		return bullet;
	}

	// Token: 0x060018CB RID: 6347 RVA: 0x00086398 File Offset: 0x00084598
	[Token(Token = "0x60018CB")]
	[Address(RVA = "0x527A60", Offset = "0x526060", VA = "0x180527A60", Slot = "69")]
	protected override Bullet Shoot2()
	{
		Transform shoot = this.shoot2;
		CreateBullet instance = CreateBullet.Instance;
		int attackDamage = this.attackDamage;
		Bullet bullet;
		bullet.Damage = attackDamage;
		PlantType thePlantType = this.thePlantType;
		bullet.fromType = thePlantType;
		float attributeCountdown = this.attributeCountdown;
		if (attributeCountdown > 1f)
		{
			this.attributeCountdown = attributeCountdown;
		}
		return bullet;
	}

	// Token: 0x060018CC RID: 6348 RVA: 0x000863F8 File Offset: 0x000845F8
	[Token(Token = "0x60018CC")]
	[Address(RVA = "0x527430", Offset = "0x525A30", VA = "0x180527430", Slot = "61")]
	public override bool OnClicked(Mouse mouse)
	{
		if (this.canExplde)
		{
			float attributeCountdown = this.attributeCountdown;
			int num = 0;
			if (attributeCountdown <= (float)num)
			{
				base.CreateCannonTarget(mouse);
				return true;
			}
		}
		return false;
	}

	// Token: 0x060018CD RID: 6349 RVA: 0x00086428 File Offset: 0x00084628
	[Token(Token = "0x60018CD")]
	[Address(RVA = "0x527820", Offset = "0x525E20", VA = "0x180527820", Slot = "62")]
	public override void SetTargetByMouse(Mouse mouse)
	{
		Action defaultContextAction = AsyncVoidMethodBuilder.Create().m_coreState.m_defaultContextAction;
	}

	// Token: 0x060018CE RID: 6350 RVA: 0x0008644C File Offset: 0x0008464C
	[Token(Token = "0x60018CE")]
	[Address(RVA = "0x527340", Offset = "0x525940", VA = "0x180527340", Slot = "52")]
	protected override void DieEventMustExecute(Plant.DieReason reason = Plant.DieReason.Default)
	{
		if (reason == Plant.DieReason.ByShovel)
		{
			Transform axis = this.axis;
			DroppedCard droppedCard;
			Action<Plant> action;
			droppedCard.plantAction = action;
		}
	}

	// Token: 0x060018CF RID: 6351 RVA: 0x00086474 File Offset: 0x00084674
	[Token(Token = "0x60018CF")]
	[Address(RVA = "0x42F0B0", Offset = "0x42D6B0", VA = "0x18042F0B0")]
	public HypnoCattailGirl()
	{
	}

	// Token: 0x04000E87 RID: 3719
	[FieldOffset(Offset = "0x228")]
	[Token(Token = "0x4000E87")]
	private SkeletonAnimation spineAnim;

	// Token: 0x04000E88 RID: 3720
	[FieldOffset(Offset = "0x230")]
	[Token(Token = "0x4000E88")]
	private MaterialPropertyBlock mpb;

	// Token: 0x04000E89 RID: 3721
	[FieldOffset(Offset = "0x238")]
	[Token(Token = "0x4000E89")]
	private MeshRenderer meshRenderer;

	// Token: 0x04000E8A RID: 3722
	[FieldOffset(Offset = "0x240")]
	[Token(Token = "0x4000E8A")]
	public SkeletonUtilityBone skillBone;

	// Token: 0x04000E8B RID: 3723
	[FieldOffset(Offset = "0x248")]
	[Token(Token = "0x4000E8B")]
	private float idleTimer;

	// Token: 0x04000E8C RID: 3724
	[FieldOffset(Offset = "0x24C")]
	[Token(Token = "0x4000E8C")]
	private bool canExplde;
}
