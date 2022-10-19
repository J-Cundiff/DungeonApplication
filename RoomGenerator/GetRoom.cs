using System;

namespace RoomGenerator
{
    public class GetRoom
    {
        //FIELDS
        private string _room;




        //PROPERTIES
        public string Room
        {
            get { return _room; }
            set { _room = value; }
        }
       
        //CONSTRUCTORS
        public GetRoom(string room)
        {
            Room = room;
        }

        //METHODS
        public override string ToString()
        {
            return base.ToString();
        }
    }
}