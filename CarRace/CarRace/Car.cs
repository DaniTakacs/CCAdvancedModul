using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRace
{
    class Car : Vehicle
    {

        String[] carNames = {"Expedition", "Trailblazer", "Spotlight", "Bolt", "Phantom", "Crown", "Paradox", "Augury", "Millennium", "Cosmos", "Flux",
            "Hydra", "Mystery", "Fragment", "Tradition", "Resolve", "Pyre", "Scorpion", "Ranger",
            "Mammoth", "Centaur", "Elysium", "Prodigy", "Vindicator", "Obsidian", "Tigress", "Patron", "Prestige", "Vagabond", "Bullet",
            "Surge", "Vagabond", "Aurora", "Wish", "Thunder", "Purity", "Legacy", "Celestial", "Rune",
            "Barrage", "Blast", "Hollow", "Wolf", "Fang", "Eagle", "Blade", "Adventure", "Aeon", "Alabaster", "Albatross",
            "Apex", "Astral", "Augury", "Aura", "Aurora", "Avalanche", "Baron", "Barrage", "Basilisk",
            "Behemoth", "Blaze", "Blend", "Bliss", "Blitz", "Blizzard", "Bolt", "Buffalo", "Bullet", "Capital",
            "Catalyst", "Celestial", "Centaur", "Centurion", "Charm", "Chase", "Climax", "Cobra", "Conqueror",
            "Corsair", "Cosmos", "Crest", "Crown", "Crusader", "Crux", "Curiosity", "Dawn", "Daydream",
            "Deputy", "Desire", "Dominion", "Dragon", "Dusk", "Dynamics", "Dynamo", "Elysium", "Eminence",
            "Empire", "Empyrean", "Encounter", "Enigma", "Eon", "Eos", "Epiphany", "Epitome", "Escape",
            "Essence", "Eternity", "Ethereal", "Evolution", "Excursion", "Expedition", "Falcon", "Ferocity",
            "Fire", "Flow", "Flux", "Formula", "Fragment", "Freedom", "Gallop", "Grit", "Guardian", "Guerrilla",
            "Harmony", "Heirloom", "Hero", "Hydra", "Icon", "Inception", "Inferno", "Inquiry", "Instinct",
            "Intro", "Ivory", "Jazz", "Legacy", "Legend", "Liberty", "Lightning", "Lioness", "Magic", "Majesty",
            "Mammoth", "Marvel", "Mastery", "Meridian", "Method", "Might", "Millennium", "Mirage", "Momentum",
            "Moonlight", "Morale", "Motion", "Motive", "Mystery", "Mythic", "Nebula", "Nimbus", "Obsidian",
            "Olympian", "Onyx", "Oracle", "Orbit", "Origin", "Paladin", "Paradox", "Paragon", "Parallel",
            "Passion", "Patron", "Phantom", "Phenomenon", "Pinnacle", "Portrait", "Presence", "Prestige",
            "Prime", "Prodigy", "Prophecy", "Prospect", "Pulse", "Purity", "Pyre", "Quest", "Quicksilver",
            "Radiance", "Ranger", "Raven", "Reach", "Realm", "Reflect", "Renegade", "Resolve", "Revelation",
            "Roamer", "Rune", "Sanctuary", "Scorpion", "Scout", "Serpent", "Shadow", "Silver", "Sliver",
            "Specter", "Spire", "Spirit", "Spotlight", "Sprite", "Stardust", "Starlight", "Storm", "Striker",
            "Supremacy", "Surge", "Symbol", "Tarragon", "Temper", "Temperament", "Tempest", "Thriller",
            "Thunder", "Tigress", "Titan", "Tracer", "Tradition", "Trailblazer", "Treasure", "Triumph",
            "Twister", "Umbra", "Union", "Universe", "Utopia", "Vagabond", "Vanish", "Vertex", "Vigor",
            "Vindicator", "Viper", "Virtue", "Vision", "Vortex", "Voyage", "Vulture", "Warrior", "Whim",
            "Whirlpool", "Wish", "Zeal"};

        Random random = new Random(Guid.NewGuid().GetHashCode());

        public Car()
        {

            this.Type = "car";
            this.Name = carNames[random.Next(carNames.Length - 1)] + " " + carNames[random.Next(carNames.Length - 1)];
            this.NormalSpeed = 80 + random.Next(31);
            Console.WriteLine(NormalSpeed);
            this.ActualSpeed = NormalSpeed;
            this.DistanceTravelled = 0;
        }


        public override void PrepareForLap(bool IsThereABrokenTruck)
        {
            if (IsThereABrokenTruck)
            {
                this.ActualSpeed = 75;
            }
        }
    }
}
