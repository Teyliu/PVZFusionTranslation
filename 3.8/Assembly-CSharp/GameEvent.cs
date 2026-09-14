using System;
using Cpp2IlInjected;

// Token: 0x02000770 RID: 1904
[Token(Token = "0x2000770")]
public enum GameEvent
{
	// Token: 0x04001421 RID: 5153
	[Token(Token = "0x4001421")]
	BoardWaveAdd,
	// Token: 0x04001422 RID: 5154
	[Token(Token = "0x4001422")]
	PlantZeroHealth,
	// Token: 0x04001423 RID: 5155
	[Token(Token = "0x4001423")]
	ZombieDeath,
	// Token: 0x04001424 RID: 5156
	[Token(Token = "0x4001424")]
	SpawnOver,
	// Token: 0x04001425 RID: 5157
	[Token(Token = "0x4001425")]
	OnPlantMix,
	// Token: 0x04001426 RID: 5158
	[Token(Token = "0x4001426")]
	OnZombieTakeDamage,
	// Token: 0x04001427 RID: 5159
	[Token(Token = "0x4001427")]
	OnPlantShoot,
	// Token: 0x04001428 RID: 5160
	[Token(Token = "0x4001428")]
	OnPlantClick,
	// Token: 0x04001429 RID: 5161
	[Token(Token = "0x4001429")]
	OnPlantCreate,
	// Token: 0x0400142A RID: 5162
	[Token(Token = "0x400142A")]
	OnMouseClick,
	// Token: 0x0400142B RID: 5163
	[Token(Token = "0x400142B")]
	PutPlantOnPlant,
	// Token: 0x0400142C RID: 5164
	[Token(Token = "0x400142C")]
	BeforeBoardAwake,
	// Token: 0x0400142D RID: 5165
	[Token(Token = "0x400142D")]
	AfterBoardAwake,
	// Token: 0x0400142E RID: 5166
	[Token(Token = "0x400142E")]
	OnZombieDoge,
	// Token: 0x0400142F RID: 5167
	[Token(Token = "0x400142F")]
	OnZombieSpawn,
	// Token: 0x04001430 RID: 5168
	[Token(Token = "0x4001430")]
	OnPlantInjured,
	// Token: 0x04001431 RID: 5169
	[Token(Token = "0x4001431")]
	OnPlantRecover,
	// Token: 0x04001432 RID: 5170
	[Token(Token = "0x4001432")]
	OnGetSun,
	// Token: 0x04001433 RID: 5171
	[Token(Token = "0x4001433")]
	OnBulletHitLand,
	// Token: 0x04001434 RID: 5172
	[Token(Token = "0x4001434")]
	OnBoardWin,
	// Token: 0x04001435 RID: 5173
	[Token(Token = "0x4001435")]
	OnPlantDeath
}
