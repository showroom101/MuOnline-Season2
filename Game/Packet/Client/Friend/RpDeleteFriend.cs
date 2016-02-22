﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Packet;
using Common.Model;


using Game.Network;
using Game.Packet.Server;

namespace Game.Packet.Client
{


    public class RpDeleteFriend : PacketReader
    {
        public override void Execute(User user)
        {

           
            byte opCode = ReadByte();
            byte sizeCode = ReadByte();
            byte headCode = ReadByte();
            string friendName = ReadString(10); 
           
           
            return;
        }
    }
}