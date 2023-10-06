﻿namespace PirateTreassureApp.Interfaces;

public interface IHero
{
    List<IHand> Hands { get; }
    void PickUp();
    void Unequip();

}
