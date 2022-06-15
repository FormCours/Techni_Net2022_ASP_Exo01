using Demo_ASP_MVC_Exo01.Models;

namespace Demo_ASP_MVC_Exo01.Data
{
    public static class FakeDB
    {
        public static IEnumerable<House> Houses = new List<House>
        {
            new House()
            {
                Id= 1,
                Name = "Stark",
                Headquarters = new List<string>
                {
                    "Winterfell"
                },
                Motto = "L'hiver vient",
                MilitaryStrength = 10_000,
                Image = "stark.png"
            },
            new House()
            {
                Id= 2,
                Name = "Targaryen",
                Headquarters = new List<string>
                {
                    "Peyredragon",
                    "Port-Réal"
                },
                Motto = "Feu et Sang",
                MilitaryStrength = 19_001,
                Image = "targ.png"
            },
            new House()
            {
                Id= 3,
                Name = "Lannister",
                Headquarters = new List<string>
                {
                    "Castral Roc"
                },
                Motto = "Je Rugis!",
                MilitaryStrength = 1,
                Image = "lannister.png"
            },
            new House()
            {
                Id= 4,
                Name = "Technifutur .Net",
                Headquarters = null,
                Motto = "C'est quand la pause ?",
                MilitaryStrength = 12,
                Image = "techni.png"
            },
        };

    }
}
