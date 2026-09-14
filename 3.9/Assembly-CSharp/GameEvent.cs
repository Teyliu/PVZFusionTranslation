using System;
using Cpp2IlInjected;

// Token: 0x020007A9 RID: 1961
[Token(Token = "0x20007A9")]
public enum GameEvent
{
	// Token: 0x040014FD RID: 5373
	[Token(Token = "0x40014FD")]
	BoardWaveAdd,
	// Token: 0x040014FE RID: 5374
	[Token(Token = "0x40014FE")]
	PlantZeroHealth,
	// Token: 0x040014FF RID: 5375
	[Token(Token = "0x40014FF")]
	ZombieDeath,
	// Token: 0x04001500 RID: 5376
	[Token(Token = "0x4001500")]
	SpawnOver,
	// Token: 0x04001501 RID: 5377
	[Token(Token = "0x4001501")]
	OnPlantMix,
	// Token: 0x04001502 RID: 5378
	[Token(Token = "0x4001502")]
	OnZombieTakeDamage,
	// Token: 0x04001503 RID: 5379
	[Token(Token = "0x4001503")]
	OnPlantShoot,
	// Token: 0x04001504 RID: 5380
	[Token(Token = "0x4001504")]
	OnPlantClick,
	// Token: 0x04001505 RID: 5381
	[Token(Token = "0x4001505")]
	OnPlantCreate,
	// Token: 0x04001506 RID: 5382
	[Token(Token = "0x4001506")]
	OnMouseClick,
	// Token: 0x04001507 RID: 5383
	[Token(Token = "0x4001507")]
	PutPlantOnPlant,
	// Token: 0x04001508 RID: 5384
	[Token(Token = "0x4001508")]
	BeforeBoardAwake,
	// Token: 0x04001509 RID: 5385
	[Token(Token = "0x4001509")]
	AfterBoardAwake,
	// Token: 0x0400150A RID: 5386
	[Token(Token = "0x400150A")]
	OnZombieDoge,
	// Token: 0x0400150B RID: 5387
	[Token(Token = "0x400150B")]
	OnZombieSpawn,
	// Token: 0x0400150C RID: 5388
	[Token(Token = "0x400150C")]
	OnPlantInjured,
	// Token: 0x0400150D RID: 5389
	[Token(Token = "0x400150D")]
	OnPlantRecover,
	// Token: 0x0400150E RID: 5390
	[Token(Token = "0x400150E")]
	OnGetSun,
	// Token: 0x0400150F RID: 5391
	[Token(Token = "0x400150F")]
	OnBulletHitLand,
	// Token: 0x04001510 RID: 5392
	[Token(Token = "0x4001510")]
	OnBoardWin,
	// Token: 0x04001511 RID: 5393
	[Token(Token = "0x4001511")]
	OnPlantDeath
}
