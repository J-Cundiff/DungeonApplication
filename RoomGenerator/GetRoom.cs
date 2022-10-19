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
        public GetRoom()
        {
            Room = _room;
        }

        //METHODS
        public override string ToString()
        {
            

            return String.Format(Room);
        }
    }
}