﻿
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedClasses.Responses
{
    public class RoomResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int FloorId { get; set; }
        public int RoomsTypesTd { get; set; }
    }
}
