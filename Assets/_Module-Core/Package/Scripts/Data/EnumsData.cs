using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VirtualTown.Enums
{
    #region Game
    public enum GameState
    {
        None,
        Initializing,
        AvatarShop,
        LoadingScene,
        InGame
    }
    #endregion

    #region Session
    public enum NetworkType
    {
        Colyseus,
        Photon
    }

    public enum UserType
    {
        Participant
    }

    public enum UIType
    {
        Desktop,
        Mobile,
        Oculus
    }
    #endregion

    #region Avatarshop
    public enum ItemType
	{
		Color,
		Head,
		Hair,
		Accessory,
		Shirt,
		Pants,
		Shoes,
	}

	public enum AcessoryType
	{
		None,
		Head,
		Eye,
		Neck
	}

	public enum AcessoryHeadType
	{
		None,
		CapFront,
		CapBack,
	}
	
	public enum GenderType
	{
		None = 0,
		OnlyMen = 1,
		OnlyWomen = 2
	}

	public enum ItemGenderType
	{
		None = 0,
		OnlyMen = 1,
		OnlyWomen = 2,
		Unisex = 3
	}

	public enum UpperBodyType
	{
		None,
		General,
		Half,
		Simple
	}

	public enum LowerBodyType
	{
		None,
		General,
		Half,
		Simple
	}
	#endregion
}
