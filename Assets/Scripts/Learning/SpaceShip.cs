using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShip
{
    
    int maxSpeed;
    string color;

    //bu fieldlara ulasmak icin property kullanacagiz, public yaparsak sikinti olur.
    //bu yuzden private yapip property ile erisiyoruz.

    #region Properties
    /// <summary>
    /// set de ekleyebiliriz ancak hizin belli olmasi ve bir daha degistirilmemesini istiyoruz
    /// </summary>
    public int MaxSpeed
    {
        get { return maxSpeed; }
    }
    /// <summary>
    /// rengi doner
    /// </summary>
    public string Color
    {
        get { return color; }
    }

    #endregion

    #region Constructors

    /// <summary>
    /// class ismi ile ayni olan methodlara diyoruz.
    /// </summary>
    public SpaceShip(int maxSpeed, string color)
    {
        this.maxSpeed = maxSpeed;
        this.color = color;
    }

    //ikinci constructor sadece hiz icin, rengi girmeye gerek kalmayacak
    public SpaceShip(int maxSpeed)
    {
        this.maxSpeed = maxSpeed;
    }
    #endregion

}
