﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenPawn : PawnInputAnalizer
{
    private const PawnType _playerType = PawnType.green;
    private void Awake()
    {
        pawnType = _playerType;
    }
    public override void OnClick()
    {
        print("clicked :" + _playerType);
        if (DiceController.instance.currentPawn != _playerType)
            return;
        base.OnClick();
    }
}
