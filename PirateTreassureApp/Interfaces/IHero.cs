﻿namespace PirateTreassureApp.Interfaces;

public interface IHero : ICharacter
{
    List<IHand> Hands { get; }
    void PickUp();
    void Unequip();

}
