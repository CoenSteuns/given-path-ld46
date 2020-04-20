﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StunCard : Card
{
    public override void Use(Battle battle)
    {
        CombatCharacter enemy = battle.GetCharacter(false);
        enemy.StunnedTime = info.PrimaryValue;
        base.Use(battle);
    }

    protected override void UpdateUsedCard()
    {
        battle.UpdateUsedCard(info.Color, "Stunned the opponent for " + info.PrimaryValue + " turns");
    }
}
