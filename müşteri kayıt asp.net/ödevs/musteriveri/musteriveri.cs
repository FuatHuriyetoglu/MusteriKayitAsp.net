using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ödevs.musteriveri
{
    public class musteriveri
    {
        public static List<Models.musteri> KMusteri = new List<Models.musteri>
{
new Models.musteri
{
Id=1,
Ad="mehmet",
SoyAd="Atay",
Dogtar= Convert.ToDateTime("27/04/1995"),
TCkimlikno="19574125842",
Adres="Akhisar mah derince sok...Antakya/Hatay"
},
new Models.musteri
{
Id=2,
Ad="Fuat",
SoyAd="Hüriyetoğlu",
Dogtar=Convert.ToDateTime("19/01/2000"),
TCkimlikno="35426581552",
Adres="serinyol Mah. irfan sok...Antakya/Hatay"
}
};
        
    }
}