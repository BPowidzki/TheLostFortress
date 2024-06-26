using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheLostFortress.gameClasses;

namespace TheLostFortress
{
    ///<summary>
    ///The Adventure class contains the "world" ofthis game 
    ///it vreates and initializes the player and the map. 
    /// </summary>
    public class Adventure
    {
        private RoomList _map;
        private Player _player;

        public Adventure()
        {
            /*
           * 
           * Troll Room -- Forest
           *    |
           *  Cave  -----  Dungeon  
           * */

            _map = new RoomList();

            _map.Add(Rm.MuschroomRoom, new Room("Muschroom Room", "In the heart of the verdant labyrinth lies the Mushroom Room, a mystical " +
                "chamber where the air is thick with spores and magic. Bioluminescent fungi cast an ethereal glow, illuminating " +
                "the path forward. Giant toadstools tower like ancient trees, their caps large enough to provide shelter or a makeshift platform." +
                " The air hums with the whispers of the forest, and every step stirs up a cloud of glittering dust. Here, adventurers must tread carefully," +
                " for the mushrooms are not what they seem—some hold healing powers, while others harbor perilous traps.", Rm.NOEXIT, Rm.Cave, Rm.NOEXIT, Rm.Forest));
            _map.Add(Rm.Forest, new Room("Forest", "Nestled within the confines of the maze’s stone walls, the Forest Room is an unexpected oasis of greenery." +
                " Moss and ivy climb the cold dungeon bricks, softening their harshness. Ancient trees stretch their limbs across the room," +
                " their leaves whispering secrets of the maze. The air is fresh with the scent of pine and earth, " +
                "a stark contrast to the musty corridors outside. Sunlight filters in through unseen crevices, dappling the ground with patches of light" +
                ". In this serene woodland glade, hidden within an action-packed labyrinth, player must stay vigilant for both hidden dangers and hidden treasures.", Rm.NOEXIT, Rm.NOEXIT, Rm.MuschroomRoom, Rm.NOEXIT));
            _map.Add(Rm.Cave, new Room("Cave", "The Cave Room, a cavernous expanse within the maze, echoes with the drip of ancient groundwater." +
                " Stalactites and stalagmites jut out like jagged teeth, creating natural barriers and hiding spots. The air is cool and damp," +
                " carrying the scent of mineral-rich stone and the faintest hint of something ancient and dormant. Echoes betray the size of the chamber," +
                " suggesting it stretches far beyond the torchlight. Here, in the bowels of the earth, players must navigate with care," +
                " as shadows may conceal lurking creatures or the glint of precious gems embedded in the walls. ", Rm.MuschroomRoom, Rm.NOEXIT, Rm.NOEXIT, Rm.Dungeon));
            _map.Add(Rm.Dungeon, new Room("Dungeon", "The Dungeon Room is a grim chamber of echoing stone and iron. Torches flicker along the walls," +
                " casting long shadows that dance with the movement of chains. The air is heavy with the scent of rust and the faint," +
                " lingering traces of battles past. The clank of metal and the scrape of stone underfoot serve as a constant reminder of the perilous journey ahead." +
                " In this room, remnants of ancient warriors’ armor and weapons hint at the challenges that lie in wait, " +
                "daring adventurers to press on and discover the secrets that the dungeon keeps. ", Rm.NOEXIT, Rm.NOEXIT, Rm.Cave, Rm.NOEXIT));

            _player = new Player("You", "The Player", _map.RoomAt(Rm.MuschroomRoom));
        }

        ///XXXXPlayer
        public Player Player
        {
            get => _player;
        }
        public string MovePlayerTo(Rm newpos)
        {
            string s;
            if (newpos == Rm.NOEXIT)
            {
                s = "There is no exit in this direction\n";
            }
            else
            {
                _player.Location = _map.RoomAt(newpos);
                s = $"You are now in the {_player.Location.Name}\n";
            }
            return s;
        }
    }
}
